USE Canteen
GO

--check tài khoản login
CREATE PROC USER_Login
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord
END
GO

--Hủy hóa đơn đang được tạo (đang dược thêm món, đã có chi tiết hóa đơn được tạo)
CREATE PROC Huy_Hoa_Don_Dang_Tao @IdHoaDon INT
AS
BEGIN
	DELETE dbo.ChiTietHoaDon WHERE HoaDon_idHoaDon = @IdHoaDon--Xóa chi tiết hóa đơn trước
	DELETE dbo.HoaDon WHERE idHoaDon = @IdHoaDon--Xóa hóa đơn hóa đơn
END
GO

--Thêm [Hóa Đơn]
CREATE PROC Them_Hoa_Don @idNhanVien INT
AS
BEGIN
	INSERT dbo.HoaDon VALUES(GETDATE(),0,@idNhanVien)
END
GO

CREATE PROC Them_Hoa_Don_Tung_Mon @IdHoaDon INT, @IdMonAn INT, @SoLuongThemVao INT, @IdNhanVien INT
AS
	DECLARE @LaHoaDonTonTai INT = 0
	SELECT @LaHoaDonTonTai = idHoaDon
	FROM dbo.HoaDon
	WHERE idHoaDon = @IdHoaDon

	DECLARE @SoLuongHienCo INT = 0
	SELECT @SoLuongHienCo = SoLuong
	FROM dbo.ChiTietHoaDon
	WHERE HoaDon_idHoaDon = @IdHoaDon AND MonAn_idMonAn = @IdMonAn
	
	DECLARE @SoLuongMoi INT = @SoLuongHienCo + @SoLuongThemVao --Tính số lượng sau cùng sẽ lưu sau lần thêm này
	
	DECLARE @TongTienHienTai INT = 0
	SELECT @TongTienHienTai = TongTien
	FROM dbo.HoaDon
	WHERE idHoaDon = @IdHoaDon

	DECLARE @TongTienMoi INT

	IF (@LaHoaDonTonTai>0)--*Hóa đơn tồn tại
	BEGIN
		IF(@SoLuongHienCo>0)--Hóa đơn tồn tại, *món này tồn tại
		BEGIN
			IF (@SoLuongMoi > 0)--Hóa đơn tồn tại, món tồn tại, *số lượng sau cùng hợp lệ
			BEGIN--Tăng số lượng ở chi tiết hóa đơn, tăng tổng tiền ở hóa đơn, cập nhật ngày của hóa đơn
				UPDATE dbo.ChiTietHoaDon SET SoLuong = @SoLuongMoi
				WHERE HoaDon_idHoaDon = @IdHoaDon AND MonAn_idMonAn = @IdMonAn

				SET @TongTienMoi= @TongTienHienTai + (SELECT MA.Gia
											FROM dbo.MonAn AS MA 
											WHERE MA.idMonAn=@IdMonAn)*@SoLuongThemVao
				UPDATE dbo.HoaDon SET TongTien = @TongTienMoi, NgayLap = GETDATE()
				WHERE idHoaDon = @IdHoaDon
			END
			ELSE--Hóa đơn tồn tại, món tồn tại, *số lượng sau cùng KHÔNG hợp lệ (<0)
			BEGIN--Chỉnh/Xóa [chi tiết hóa đơn], nếu [hóa đơn] chỉ có 1 [chi tiết hóa đơn] thì xóa luôn [hóa đơn]
				DELETE dbo.ChiTietHoaDon WHERE HoaDon_idHoaDon = @IdHoaDon--Xóa chi tiết hóa đơn trước
				DELETE dbo.HoaDon WHERE idHoaDon = @IdHoaDon--Xóa hóa đơn hóa đơn
			END
		END
		ELSE--Hóa đơn tồn tại, *món này KHÔNG tồn tại
		BEGIN
			IF (@SoLuongMoi > 0)--Hóa đơn tồn tại, món này KHÔNG tồn tại, *số lượng sau cùng hợp lệ
			BEGIN--Thêm [chi tiết hóa đơn], cập nhật tổng tiền và ngày lập trên [Hóa Đơn]
				INSERT dbo.ChiTietHoaDon VALUES(@IdHoaDon,@IdMonAn,@SoLuongThemVao)--Thêm Chi Tiết Hóa Đơn

				SET @TongTienMoi= @TongTienHienTai + (SELECT MA.Gia
											FROM dbo.MonAn AS MA 
											WHERE MA.idMonAn=@IdMonAn)*@SoLuongThemVao

				UPDATE dbo.HoaDon SET TongTien = @TongTienMoi, NgayLap = GETDATE()
				WHERE idHoaDon = @IdHoaDon;
			END
			--Hóa đơn tồn tại, món này KHÔNG tồn tại, *số lượng sau cùng KHÔNG hợp lệ -> Không làm gì cả
		END--/Hóa đơn tồn tại, *món này KHÔNG tồn tại
	END
	ELSE--*Hóa đơn KHÔNG tồn tại
	BEGIN
		IF (@SoLuongMoi > 0)--Hóa đơn KHÔNG tồn tại, *số lượng sau cùng hợp lệ
		BEGIN--Thêm HoaDon, thêm ChiTietHoaDon	
			INSERT dbo.ChiTietHoaDon VALUES(@IdHoaDon,@IdMonAn,@SoLuongThemVao)--Thêm Chi Tiết Hóa Đơn
			SET @TongTienMoi= @TongTienHienTai + (SELECT MA.Gia
												FROM dbo.MonAn AS MA 
												WHERE MA.idMonAn=@IdMonAn)*@SoLuongThemVao
			INSERT dbo.HoaDon VALUES(GETDATE(),@TongTienMoi,@IdNhanVien)	--Thêm Hóa Đơn
		END
		--Hóa đơn KHÔNG tồn tại, *số lượng sau cùng KHÔNG hợp lệ -> KHÔNG LÀM GÌ CẢ
	END
GO


--test
	--SELECT *
	--FROM dbo.HoaDon

	--SELECT *
	--FROM dbo.ChiTietHoaDon

	--SELECT COUNT(*)
	--FROM dbo.ChiTietHoaDon
	--WHERE HoaDon_idHoaDon = 2
---------------------------------------

--Thêm MÓN ĂN
CREATE PROC Them_Mon_An @TEN NVARCHAR(45),@GIA INT,@MIEUTA NVARCHAR(45),@HINHANH NVARCHAR(256)
AS
	INSERT INTO MonAn(Ten,Gia,MieuTa,HinhAnh) VALUES (@TEN,@GIA,@MIEUTA,@HINHANH)
GO

--Thêm LOẠI MÓN ĂN
CREATE PROC Them_Loai_Mon_An @TEN NVARCHAR(45)
AS
	INSERT INTO LoaiMonAn(Ten_loai) VALUES(@TEN)
GO

--??
CREATE PROC Mon_An
AS
	SELECT MA.idMonAn,MA.Ten,MA.Gia,MA.MieuTa,MA.HinhAnh
	FROM MonAn AS MA
GO

--???
CREATE PROC Loai_Mon_An
AS
	SELECT LMA.idLoaiMonAn,LMA.Ten_loai
	FROM LoaiMonAn AS LMA
GO

--???
CREATE TYPE LOAI_TEMP AS TABLE(
	idloai INT,
	ten NVARCHAR(45))
GO

--Tìm MÓN ĂN theo LOẠI
CREATE PROC Tim_Mon_An_Theo_Loai @DSLOAI LOAI_TEMP READONLY
AS 
	SELECT MA.idMonAn,MA.Ten,MA.MieuTa,MA.Gia,MA.HinhAnh
	FROM MonAn_thuoc_LoaiMon_ AS LMA INNER JOIN MonAn AS MA ON MA.idMonAn=LMA.MonAn_idMonAn
	WHERE LMA.LoaiMonAn_idLoaiMonAn IN(
										SELECT DS.idloai
										FROM @DSLOAI AS DS)
GO

--Lọc MÓN ĂN theo LOẠI
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

--Tìm theo LOẠI
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

--??
CREATE TYPE MonAn_Temp AS TABLE(
	idMon INT,
	Soluong INT)
GO

--??
CREATE TYPE ID_TEMP AS TABLE(
	IdMon INT)
GO

----??@DSMON
--CREATE PROC Them_Hoa_Don @IdNHANVIEN INT, @DSMON MonAn_Temp READONLY--Nhập vào một bảng gồm món ăn và số lượng
--AS
--	DECLARE @NGAYLAP DATETIME,@TongTienMoi INT,@IdMON INT,@IdMONTABLE ID_TEMP
--	SET @NGAYLAP=GETDATE()

--	SET @TongTienMoi=(SELECT SUM(MA.Gia*DS.Soluong)
--	FROM @DSMON AS DS INNER JOIN MonAn AS MA ON DS.idMon=MA.idMonAn)

--	INSERT INTO HoaDon(NhanVien_idNhanVien,NgayLap,TongTien) VALUES(@IdNHANVIEN,@NGAYLAP,@TongTienMoi)

--	SET @IdMON=@@IDENTITY




--	INSERT INTO @IdMONTABLE(IdMon) VALUES (@IdMON)

--	INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon,MonAn_idMonAn,SoLuong)
--	(SELECT T.IdMon,DS.idMon,DS.Soluong
--	FROM @IdMONTABLE AS T,@DSMON AS DS)
--GO			

--Tìm HÓA ĐƠN theo ngày
CREATE PROC Tim_Hoa_Don_Theo_Ngay @BEGIN DATETIME,@END DATETIME
AS
	SELECT CT.HoaDon_idHoaDon,CT.MonAn_idMonAn,CT.SoLuong,HD1.NgayLap,HD1.NhanVien_idNhanVien,HD1.TongTien
	FROM ChiTietHoaDon AS CT INNER JOIN (SELECT *
											FROM HoaDon AS HD 
											WHERE HD.NgayLap BETWEEN @BEGIN AND @END)  AS HD1 ON HD1.idHoaDon=CT.HoaDon_idHoaDon
GO


--CREATE PROC Them_Hoa_Don_Tung_Mon @IdNHANVIEN INT,@IdMONAN INT,@SOLUONG INT,@IdHOADON_OUT INT OUTPUT--Trả về id hóa đơn để lần sau thêm các món vào chi tiết hóa đơn
----Thêm hóa đơn lần đầu
--AS
--	DECLARE @NGAYLAP DATETIME,@TONGTIEN INT,@IdHOADON INT
--	SET @NGAYLAP=GETDATE()
--	SET @TONGTIEN=(SELECT MA.Gia*@SOLUONG FROM MonAn AS MA WHERE MA.idMonAn=@IdMONAN)
--	INSERT INTO HoaDon(NhanVien_idNhanVien,NgayLap,TongTien) VALUES (@IdNHANVIEN,@NGAYLAP,@TONGTIEN)
--	SET @IdHOADON=@@IDENTITY

--	INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon,MonAn_idMonAn,SoLuong) VALUES (@IdHOADON,@IdMONAN,@SOLUONG)
--	--SELECT @IdHOADON_OUT=@IdHOADON
--	--print(@idhoadon)
--GO

<<<<<<< HEAD
--DÙNG

create PROC Them_Hoa_Don_Tung_Mon @IdHoaDon INT, @IdMonAn INT, @SoLuongThemVao INT, @IdNhanVien INT
AS
	DECLARE @LaHoaDonTonTai INT = 0
	SELECT @LaHoaDonTonTai = idHoaDon
	FROM dbo.HoaDon
	WHERE idHoaDon = @IdHoaDon

	DECLARE @SoLuongHienCo INT = 0
	SELECT @SoLuongHienCo = SoLuong
	FROM dbo.ChiTietHoaDon
	WHERE HoaDon_idHoaDon = @IdHoaDon AND MonAn_idMonAn = @IdMonAn
	
	DECLARE @SoLuongMoi INT = @SoLuongHienCo + @SoLuongThemVao --Tính số lượng sau cùng sẽ lưu sau lần thêm này
	
	DECLARE @TongTienHienTai INT = 0
	SELECT @TongTienHienTai = TongTien
	FROM dbo.HoaDon
	WHERE idHoaDon = @IdHoaDon

	DECLARE @TongTienMoi INT

	IF (@LaHoaDonTonTai>0)--*Hóa đơn tồn tại
	BEGIN
		IF(@SoLuongHienCo>0)--Hóa đơn tồn tại, *món này tồn tại
		BEGIN
			IF (@SoLuongMoi > 0)--Hóa đơn tồn tại, món tồn tại, *số lượng sau cùng hợp lệ
			BEGIN--Tăng số lượng ở chi tiết hóa đơn, tăng tổng tiền ở hóa đơn, cập nhật ngày của hóa đơn
				UPDATE dbo.ChiTietHoaDon SET SoLuong = @SoLuongMoi
				WHERE HoaDon_idHoaDon = @IdHoaDon AND MonAn_idMonAn = @IdMonAn

				SET @TongTienMoi= @TongTienHienTai + (SELECT MA.Gia
											FROM dbo.MonAn AS MA 
											WHERE MA.idMonAn=@IdMonAn)*@SoLuongThemVao
				UPDATE dbo.HoaDon SET TongTien = @TongTienMoi, NgayLap = GETDATE()
				WHERE idHoaDon = @IdHoaDon
			END
			ELSE--Hóa đơn tồn tại, món tồn tại, *số lượng sau cùng KHÔNG hợp lệ (<0)
			BEGIN--Chỉnh/Xóa [chi tiết hóa đơn], nếu [hóa đơn] chỉ có 1 [chi tiết hóa đơn] thì xóa luôn [hóa đơn]
				DELETE dbo.ChiTietHoaDon WHERE HoaDon_idHoaDon = @IdHoaDon--Xóa chi tiết hóa đơn trước
				--Xử lí sau, cái này là tạm : UPDATE NEWS: Nguy hiem qua!!! Khong duoc dung
				--DELETE dbo.HoaDon WHERE idHoaDon = @IdHoaDon--Xóa hóa đơn
				--TẠM THỜI DO CHỖ NÀY NÊN KHÔNG ĐỂ COUNT LÀ SỐ ÂM ĐƯỢC -> CHỈNH BÊN GIAO DIỆN NUMERICUPDOWN MIN = 0
			END
		END
		ELSE--Hóa đơn tồn tại, *món này KHÔNG tồn tại
		BEGIN
			IF (@SoLuongMoi > 0)--Hóa đơn tồn tại, món này KHÔNG tồn tại, *số lượng sau cùng hợp lệ
			BEGIN--Thêm [chi tiết hóa đơn], cập nhật tổng tiền và ngày lập trên [Hóa Đơn]
				INSERT dbo.ChiTietHoaDon VALUES(@IdHoaDon,@IdMonAn,@SoLuongThemVao)--Thêm Chi Tiết Hóa Đơn

				SET @TongTienMoi= @TongTienHienTai + (SELECT MA.Gia
											FROM dbo.MonAn AS MA 
											WHERE MA.idMonAn=@IdMonAn)*@SoLuongThemVao

				UPDATE dbo.HoaDon SET TongTien = @TongTienMoi, NgayLap = GETDATE()
				WHERE idHoaDon = @IdHoaDon;
			END
			--Hóa đơn tồn tại, món này KHÔNG tồn tại, *số lượng sau cùng KHÔNG hợp lệ -> Không làm gì cả
		END--/Hóa đơn tồn tại, *món này KHÔNG tồn tại
	END
	ELSE--*Hóa đơn KHÔNG tồn tại
	BEGIN--Thêm HoaDon, thêm ChiTietHoaDon	
		INSERT dbo.ChiTietHoaDon VALUES(@IdHoaDon,@IdMonAn,@SoLuongThemVao)--Thêm Chi Tiết Hóa Đơn
		SET @TongTienMoi= @TongTienHienTai + (SELECT MA.Gia
											FROM dbo.MonAn AS MA 
											WHERE MA.idMonAn=@IdMonAn)*@SoLuongThemVao
		INSERT dbo.HoaDon VALUES(GETDATE(),@TongTienMoi,@IdNhanVien)	--Thêm Hóa Đơn
	END
GO

--Thêm [Hóa Đơn]
CREATE PROC Them_Hoa_Don @idNhanVien INT
AS
BEGIN
	INSERT dbo.HoaDon VALUES(GETDATE(),0,@idNhanVien)
END
GO

--test
	--SELECT *
	--FROM dbo.HoaDon

	--SELECT *
	--FROM dbo.ChiTietHoaDon


=======
>>>>>>> 4d153c0e666cf15a655cb0fdfe5d6eb678a3c7dd
--khong dun`g
--CREATE PROC Them_CT_Hoa_Don_Tung_Mon @IdHOADON INT,@IdMONAN INT,@SOLUONG INT
--AS
--	INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon,MonAn_idMonAn,SoLuong) VALUES(@IdHOADON,@IdMONAN,@SOLUONG)
--	UPDATE HoaDon
--	SET TongTien+=(SELECT MA.Gia*@SOLUONG FROM MONAN AS MA WHERE MA.idMonAn=@IdMONAN)
--	WHERE idHoaDon=@IdHOADON
--GO