USE Canteen
GO
CREATE PROC Them_Mon_An @TEN NVARCHAR(45),@GIA INT,@MIEUTA NVARCHAR(45),@HINHANH NVARCHAR(256)
AS
	INSERT INTO MonAn(Ten,Gia,MieuTa,HinhAnh) VALUES (@TEN,@GIA,@MIEUTA,@HINHANH)
GO
CREATE PROC Them_Loai_Mon_An @TEN NVARCHAR(45)
AS
	INSERT INTO LoaiMonAn(Ten_loai) VALUES(@TEN)
GO
CREATE PROC Mon_An
AS
	SELECT MA.idMonAn,MA.Ten,MA.Gia,MA.MieuTa,MA.HinhAnh
	FROM MonAn AS MA
GO
CREATE PROC Loai_Mon_An
AS
	SELECT LMA.idLoaiMonAn,LMA.Ten_loai
	FROM LoaiMonAn AS LMA
GO
CREATE TYPE LOAI_TEMP AS TABLE(
	idloai INT,
	ten NVARCHAR(45))
GO
CREATE PROC Tim_Mon_An_Theo_Loai @DSLOAI LOAI_TEMP READONLY
AS 
	SELECT MA.idMonAn,MA.Ten,MA.MieuTa,MA.Gia,MA.HinhAnh
	FROM MonAn_thuoc_LoaiMon_ AS LMA INNER JOIN MonAn AS MA ON MA.idMonAn=LMA.MonAn_idMonAn
	WHERE LMA.LoaiMonAn_idLoaiMonAn IN(
										SELECT DS.idloai
										FROM @DSLOAI AS DS)
GO
CREATE PROC Filter_Mon_An_Theo_Loai @DSLOAI LOAI_TEMP READONLY
AS 
	SELECT MA.idMonAn,MA.Ten,MA.MieuTa,MA.Gia,MA.HinhAnh
	FROM MonAn AS MA
	WHERE NOT EXISTS(
						SELECT DS.idloai
						FROM @DSLOAI AS DS
						EXCEPT(
									SELECT DISTINCT LMA.LoaiMonAn_idLoaiMonAn
									FROM MonAn_thuoc_LoaiMon_ AS LMA
									WHERE MA.idMonAn=LMA.MonAn_idMonAn))
GO
CREATE PROC Tim_Theo_Loai @DSLOAI1 LOAI_TEMP READONLY,@FLAG TINYINT--Chạy tìm kiếm bằng cái này
AS  
	IF @FLAG = 1
	BEGIN
		EXEC Filter_Mon_An_Theo_Loai @DSLOAI1
	END 
	ELSE
	BEGIN
		EXEC Tim_Mon_An_Theo_Loai @DSLOAI1
	END
GO
CREATE TYPE MonAn_Temp AS TABLE(
	idMon INT,
	Soluong INT)
GO
CREATE TYPE TEMP AS TABLE(
	IdMon INT)
GO
CREATE PROC Them_Hoa_Don @NHANVIEN INT, @DSMON MonAn_Temp READONLY--Nhập vào một bảng gồm món ăn và số lượng
AS
	DECLARE @NGAYLAP DATETIME,@TONGTIEN INT,@IDMON INT,@TEMP1 TEMP
	SET @NGAYLAP=GETDATE()

	SET @TONGTIEN=(SELECT SUM(MA.Gia*DS.Soluong)
	FROM @DSMON AS DS INNER JOIN MonAn AS MA ON DS.idMon=MA.idMonAn)

	INSERT INTO HoaDon(NhanVien_idNhanVien,NgayLap,TongTien) VALUES(@NHANVIEN,@NGAYLAP,@TONGTIEN)

	SET @IDMON=@@IDENTITY
	INSERT INTO @TEMP1(IdMon) VALUES (@IDMON)

	INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon,MonAn_idMonAn,SoLuong)
	(SELECT T.IdMon,DS.idMon,DS.Soluong
	FROM @TEMP1 AS T,@DSMON AS DS)
GO											
CREATE PROC Tim_Hoa_Don_Theo_Ngay @BEGIN DATETIME,@END DATETIME
AS
	SELECT CT.HoaDon_idHoaDon,CT.MonAn_idMonAn,CT.SoLuong,HD1.NgayLap,HD1.NhanVien_idNhanVien,HD1.TongTien
	FROM ChiTietHoaDon AS CT INNER JOIN (SELECT *
											FROM HoaDon AS HD 
											WHERE HD.NgayLap BETWEEN @BEGIN AND @END)  AS HD1 ON HD1.idHoaDon=CT.HoaDon_idHoaDon
GO
EXEC Tim_Hoa_Don_Theo_Ngay '2019/10/8','2019/10/9'


--Tránh lỗi SQL Injection như ví dụ sau:
--<		SELECT * FROM dbo.Account WHERE UserName = '' AND PassWord = N'' OR 1=1--'		>
CREATE PROC USER_Login
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord
END
GO
--EXEC USER_Login 'admin', '1234'