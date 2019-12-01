use Canteen

--- Table NhanVien
INSERT INTO NhanVien(idNhanVien,HoTen, NgaySinh)	VALUES( 1,'Trần Phúc Lộc','10/09/1978')
INSERT INTO NhanVien(idNhanVien,HoTen, NgaySinh)	 VALUES( 2,'Đoàn Văn Hậu','17/05/1999')
INSERT INTO NhanVien(idNhanVien,HoTen, NgaySinh)	 VALUES( 3,'Huỳnh Tấn Sinh','22/03/1998')
INSERT INTO NhanVien(idNhanVien,HoTen, NgaySinh)	 VALUES( 4,'Nguyễn Thành Chung','14/012/1978')
INSERT INTO NhanVien(idNhanVien,HoTen, NgaySinh)	 VALUES( 5,'Nguyễn Quang Hải','5/1/1998')
INSERT INTO NhanVien(idNhanVien,HoTen, NgaySinh)	 VALUES( 6,'Nguyễn Trọng Hùng','16/09/1977')
INSERT INTO NhanVien(idNhanVien,HoTen, NgaySinh)	 VALUES( 7,'Đỗ Hùng Dũng','10/04/1989')
INSERT INTO NhanVien(idNhanVien,HoTen, NgaySinh)	 VALUES( 8,'Hà Đức Chinh','17/09/1982')
INSERT INTO NhanVien(idNhanVien,HoTen, NgaySinh)	 VALUES( 9,'Nguyễn Tiến Linh','01/06/1985')


---Table HoaDon
INSERT INTO HoaDon(idHoaDon,NgayLap,TongTien,NhanVien_idNhanVien)	 VALUES( 1,'10/09/2019',25000,'001' )
INSERT INTO HoaDon(idHoaDon,NgayLap,TongTien,NhanVien_idNhanVien)    VALUES(2 ,'10/09/2019',40000,'001' )
INSERT INTO HoaDon(idHoaDon,NgayLap,TongTien,NhanVien_idNhanVien)    VALUES( 3,'11/09/2019',55000,'002' )
INSERT INTO HoaDon(idHoaDon,NgayLap,TongTien,NhanVien_idNhanVien)    VALUES(4,'12/09/2019',20000,'002' )
INSERT INTO HoaDon(idHoaDon,NgayLap,TongTien,NhanVien_idNhanVien)    VALUES(5,'12/09/2019',25000,'005' )
INSERT INTO HoaDon(idHoaDon,NgayLap,TongTien,NhanVien_idNhanVien)    VALUES(6,'10/09/2019',25000,'005' )
INSERT INTO HoaDon(idHoaDon,NgayLap,TongTien,NhanVien_idNhanVien)    VALUES(7,'10/09/2019',30000,'001' )
INSERT INTO HoaDon(idHoaDon,NgayLap,TongTien,NhanVien_idNhanVien)    VALUES(8,'10/09/2019',35000,'001' )
INSERT INTO HoaDon(idHoaDon,NgayLap,TongTien,NhanVien_idNhanVien)    VALUES(9,'11/09/2019',35000,'002' )
INSERT INTO HoaDon(idHoaDon,NgayLap,TongTien,NhanVien_idNhanVien)    VALUES(10,'11/09/2019',25000,'002' )
INSERT INTO HoaDon(idHoaDon,NgayLap,TongTien,NhanVien_idNhanVien)    VALUES(11,'10/09/2019',25000,'002' )
INSERT INTO HoaDon(idHoaDon,NgayLap,TongTien,NhanVien_idNhanVien)    VALUES(12,'12/09/2019',35000,'005' )
INSERT INTO HoaDon(idHoaDon,NgayLap,TongTien,NhanVien_idNhanVien)    VALUES(13,'12/09/2019',35000,'005' )
INSERT INTO HoaDon(idHoaDon,NgayLap,TongTien,NhanVien_idNhanVien)    VALUES(14,'10/09/2019',25000, '005' )
INSERT INTO HoaDon(idHoaDon,NgayLap,TongTien,NhanVien_idNhanVien)    VALUES(15,'13/09/2019',40000, '006' )
INSERT INTO HoaDon(idHoaDon,NgayLap,TongTien,NhanVien_idNhanVien)    VALUES(16,'13/09/2019',25000, '006' )
INSERT INTO HoaDon(idHoaDon,NgayLap,TongTien,NhanVien_idNhanVien)    VALUES(17,'11/09/2019',35000, '001' )
INSERT INTO HoaDon(idHoaDon,NgayLap,TongTien,NhanVien_idNhanVien)    VALUES(18,'10/09/2019',25000, '006' )
INSERT INTO HoaDon(idHoaDon,NgayLap,TongTien,NhanVien_idNhanVien)    VALUES(19,'12/09/2019',45000, '006' )

---Table MonAn
INSERT INTO MonAn(idMonAn, Ten,Gia,MieuTa,HinhAnh)  VALUES(1,'Bánh canh',35000, NULL,NULL)
INSERT INTO MonAn(idMonAn, Ten,Gia,MieuTa,HinhAnh)  VALUES(2,'Bánh mì',15000, 'bánh mì chả cá, nem, thịt',NULL)
INSERT INTO MonAn(idMonAn, Ten,Gia,MieuTa,HinhAnh)  VALUES(3,'Cá hú kho tộ ',25000, NULL,NULL)
INSERT INTO MonAn(idMonAn, Ten,Gia,MieuTa,HinhAnh)  VALUES(4,'Cá lóc kho tộ',25000, NULL,NULL)
INSERT INTO MonAn(idMonAn, Ten,Gia,MieuTa,HinhAnh)     VALUES(5,'Ba rọi nướng',25000, NULL,NULL)
INSERT INTO MonAn(idMonAn, Ten,Gia,MieuTa,HinhAnh)     VALUES(6,'Cá kèo kho tộ',20000, NULL,NULL)
INSERT INTO MonAn(idMonAn, Ten,Gia,MieuTa,HinhAnh)     VALUES(7,'Thị kho đậu hũ trứng cút',25000, NULL,NULL)
INSERT INTO MonAn(idMonAn, Ten,Gia,MieuTa,HinhAnh)     VALUES(8,'Sườn non ram mặn',30000, NULL,NULL)
INSERT INTO MonAn(idMonAn, Ten,Gia,MieuTa,HinhAnh)     VALUES(9,'Heo quay',25000, NULL,NULL)
INSERT INTO MonAn(idMonAn, Ten,Gia,MieuTa,HinhAnh)     VALUES(10,'Gà kho',25000, NULL,NULL)
INSERT INTO MonAn(idMonAn, Ten,Gia,MieuTa,HinhAnh)     VALUES(11,'Trứng chiên',25000, NULL,NULL)
INSERT INTO MonAn(idMonAn, Ten,Gia,MieuTa,HinhAnh)     VALUES(12,'Bò xào',25000, NULL,NULL)
INSERT INTO MonAn(idMonAn, Ten,Gia,MieuTa,HinhAnh)     VALUES(13,'Hủ tiếu',25000, NULL,NULL)
INSERT INTO MonAn(idMonAn, Ten,Gia,MieuTa,HinhAnh)     VALUES(14,'Tôm rim mặn',25000, NULL,NULL)
INSERT INTO MonAn(idMonAn, Ten,Gia,MieuTa,HinhAnh)     VALUES(15,'Chè bưởi',15000, NULL,NULL)
INSERT INTO MonAn(idMonAn, Ten,Gia,MieuTa,HinhAnh)     VALUES(16,'Chè hạt sen',10000, NULL,NULL)
INSERT INTO MonAn(idMonAn, Ten,Gia,MieuTa,HinhAnh)     VALUES(17,'Chè đậu đỏ',10000, NULL,NULL)
INSERT INTO MonAn(idMonAn, Ten,Gia,MieuTa,HinhAnh)     VALUES(18,'Chè đậu đen',10000, NULL,NULL)
INSERT INTO MonAn(idMonAn, Ten,Gia,MieuTa,HinhAnh)     VALUES(19,'Nước suối',5000, NULL,NULL)
INSERT INTO MonAn(idMonAn, Ten,Gia,MieuTa,HinhAnh)     VALUES(20,'Chanh dây',15000, NULL,NULL)
INSERT INTO MonAn(idMonAn, Ten,Gia,MieuTa,HinhAnh)     VALUES(21,'Nước cam',15000, NULL,NULL)
INSERT INTO MonAn(idMonAn, Ten,Gia,MieuTa,HinhAnh)     VALUES(22,'Trà xanh',10000, NULL,NULL)
INSERT INTO MonAn(idMonAn, Ten,Gia,MieuTa,HinhAnh)     VALUES(23,'Xá xị',10000, NULL,NULL)


--- Table ChiTietHoaDon
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(1,11 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(11,11 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(5,11 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(3,11 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(3,6 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(3,18 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(8,5 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(8,22 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(4,6 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(7,20 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(7,21 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(12,12 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(12,23 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(18,14 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(10,11 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(14,11 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(2,14 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(2,20 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(9,11 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(9,23 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(6,11 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(15,10 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(15,23 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(16,11 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(17,9 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(17,18 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(18,11 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(19,9 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(19,22 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(19,23 ,1)


--- Table LoaiMonAn
INSERT INTO LoaiMonAn(idLoaiMonAn, Ten_loai)  VALUES(1,'Cơm phần')
INSERT INTO LoaiMonAn(idLoaiMonAn, Ten_loai)    VALUES(2,'Chè')
INSERT INTO LoaiMonAn(idLoaiMonAn, Ten_loai)    VALUES(3,'Nước')

--- Table MonAn_thuoc_LoaiMon_
INSERT INTO MonAn_thuoc_LoaiMon_(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)	 VALUES(1,1)
INSERT INTO MonAn_thuoc_LoaiMon_(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)  VALUES(1,2)
INSERT INTO MonAn_thuoc_LoaiMon_(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)  VALUES(1,3)
INSERT INTO MonAn_thuoc_LoaiMon_(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)   VALUES(1,4)
INSERT INTO MonAn_thuoc_LoaiMon_(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)	VALUES(1,5)
INSERT INTO MonAn_thuoc_LoaiMon_(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)	VALUES(1,6)
INSERT INTO MonAn_thuoc_LoaiMon_(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)	VALUES(1,7)
INSERT INTO MonAn_thuoc_LoaiMon_(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)	VALUES(1,8)
INSERT INTO MonAn_thuoc_LoaiMon_(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)	VALUES(1,9)
INSERT INTO MonAn_thuoc_LoaiMon_(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)	VALUES(1,10)
INSERT INTO MonAn_thuoc_LoaiMon_(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)	VALUES(1,11)
INSERT INTO MonAn_thuoc_LoaiMon_(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)	VALUES(1,12)
INSERT INTO MonAn_thuoc_LoaiMon_(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)	VALUES(1,13)
INSERT INTO MonAn_thuoc_LoaiMon_(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)	VALUES(1,14)
INSERT INTO MonAn_thuoc_LoaiMon_(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)	VALUES(1,15)
INSERT INTO MonAn_thuoc_LoaiMon_(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)	VALUES(1,16)
INSERT INTO MonAn_thuoc_LoaiMon_(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)	VALUES(2,17)
INSERT INTO MonAn_thuoc_LoaiMon_(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)	VALUES(2,18)
INSERT INTO MonAn_thuoc_LoaiMon_(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)	VALUES(2,19)
INSERT INTO MonAn_thuoc_LoaiMon_(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)	VALUES(3,20)
INSERT INTO MonAn_thuoc_LoaiMon_(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)	VALUES(3,21)
INSERT INTO MonAn_thuoc_LoaiMon_(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)	VALUES(3,22)
INSERT INTO MonAn_thuoc_LoaiMon_(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)	VALUES(3,23)
























