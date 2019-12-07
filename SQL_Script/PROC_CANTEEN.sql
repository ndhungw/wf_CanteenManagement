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
CREATE TYPE ID_TEMP AS TABLE(
	IdMon INT)
GO
CREATE PROC Them_Hoa_Don @IdNHANVIEN INT, @DSMON MonAn_Temp READONLY--Nhập vào một bảng gồm món ăn và số lượng
AS
	DECLARE @NGAYLAP DATETIME,@TONGTIEN INT,@IdMON INT,@IdMONTABLE ID_TEMP
	SET @NGAYLAP=GETDATE()

	SET @TONGTIEN=(SELECT SUM(MA.Gia*DS.Soluong)
	FROM @DSMON AS DS INNER JOIN MonAn AS MA ON DS.idMon=MA.idMonAn)

	INSERT INTO HoaDon(NhanVien_idNhanVien,NgayLap,TongTien) VALUES(@IdNHANVIEN,@NGAYLAP,@TONGTIEN)

	SET @IdMON=@@IDENTITY
	INSERT INTO @IdMONTABLE(IdMon) VALUES (@IdMON)

	INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon,MonAn_idMonAn,SoLuong)
	(SELECT T.IdMon,DS.idMon,DS.Soluong
	FROM @IdMONTABLE AS T,@DSMON AS DS)
GO											
CREATE PROC Tim_Hoa_Don_Theo_Ngay @BEGIN DATETIME,@END DATETIME
AS
	SELECT CT.HoaDon_idHoaDon,CT.MonAn_idMonAn,CT.SoLuong,HD1.NgayLap,HD1.NhanVien_idNhanVien,HD1.TongTien
	FROM ChiTietHoaDon AS CT INNER JOIN (SELECT *
											FROM HoaDon AS HD 
											WHERE HD.NgayLap BETWEEN @BEGIN AND @END)  AS HD1 ON HD1.idHoaDon=CT.HoaDon_idHoaDon
GO
CREATE PROC Them_Hoa_Don_Tung_Mon @IdNHANVIEN INT,@IdMONAN INT,@SOLUONG INT,@IdHOADON_OUT INT OUTPUT--Trả về id hóa đơn để lần sau thêm các món vào chi tiết hóa đơn
--Thêm hóa đơn lần đầu
AS
	DECLARE @NGAYLAP DATETIME,@TONGTIEN INT,@IdHOADON INT
	SET @NGAYLAP=GETDATE()
	SET @TONGTIEN=(SELECT MA.Gia*@SOLUONG FROM MonAn AS MA WHERE MA.idMonAn=@IdMONAN)
	INSERT INTO HoaDon(NhanVien_idNhanVien,NgayLap,TongTien) VALUES (@IdNHANVIEN,@NGAYLAP,@TONGTIEN)
	SET @IdHOADON=@@IDENTITY
	INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon,MonAn_idMonAn,SoLuong) VALUES (@IdHOADON,@IdMONAN,@SOLUONG)
	SELECT @IdHOADON_OUT=@IdHOADON
	print(@idhoadon)
GO
CREATE PROC Them_CT_Hoa_Don_Tung_Mon @IdHOADON INT,@IdMONAN INT,@SOLUONG INT
AS
	INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon,MonAn_idMonAn,SoLuong) VALUES(@IdHOADON,@IdMONAN,@SOLUONG)
	UPDATE HoaDon
	SET TongTien+=(SELECT MA.Gia*@SOLUONG FROM MONAN AS MA WHERE MA.idMonAn=@IdMONAN)
	WHERE idHoaDon=@IdHOADON
GO
