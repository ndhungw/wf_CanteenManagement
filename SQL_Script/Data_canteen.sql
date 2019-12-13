use Canteen

--Table Account
INSERT INTO Account(UserName, PassWord, DisplayName, AccType)	VALUES('admin','1234', 'ADMINISTRATOR', 1);
INSERT INTO Account(UserName, PassWord, DisplayName, AccType)	VALUES('alaska123','123', N'Trần Quang Tùng', 0);

--- Table NhanVien
INSERT INTO NhanVien(HoTen, NgaySinh)	VALUES(N'Trần Phúc Lộc','09/10/1978')
INSERT INTO NhanVien(HoTen, NgaySinh)   VALUES(N'Đoàn Văn Hậu','05/17/1999')
INSERT INTO NhanVien(HoTen, NgaySinh)	VALUES(N'Huỳnh Tấn Sinh','03/07/1998')
INSERT INTO NhanVien(HoTen, NgaySinh)	VALUES(N'Nguyễn Thành Chung','12/02/1978')
INSERT INTO NhanVien(HoTen, NgaySinh)	VALUES(N'Nguyễn Quang Hải','1/5/1998')
INSERT INTO NhanVien(HoTen, NgaySinh)	VALUES(N'Nguyễn Trọng Hùng','09/16/1977')
INSERT INTO NhanVien(HoTen, NgaySinh)	VALUES(N'Đỗ Hùng Dũng','10/04/1989')
INSERT INTO NhanVien(HoTen, NgaySinh)	VALUES(N'Hà Đức Chinh','09/18/1982')
INSERT INTO NhanVien(HoTen, NgaySinh)	VALUES(N'Nguyễn Tiến Linh','01/06/1985')

---Table MonAn
INSERT INTO MonAn(Ten,Gia,idLoaiMonAn,MieuTa)	VALUES(N'Bánh canh',35000,1,NULL)
INSERT INTO MonAn(Ten,Gia,idLoaiMonAn,MieuTa)	VALUES(N'Bánh mì',15000,1,N'bánh mì chả cá, nem, thịt')
INSERT INTO MonAn(Ten,Gia,idLoaiMonAn,MieuTa)	VALUES(N'Cá hú kho tộ',25000,1,NULL)
INSERT INTO MonAn(Ten,Gia,idLoaiMonAn,MieuTa)	VALUES(N'Cá lóc kho tộ',25000,1,NULL)
INSERT INTO MonAn(Ten,Gia,idLoaiMonAn,MieuTa)	VALUES(N'Ba rọi nướng',25000,1,NULL)
INSERT INTO MonAn(Ten,Gia,idLoaiMonAn,MieuTa)	VALUES(N'Cá kèo kho tộ',20000,1,NULL)
INSERT INTO MonAn(Ten,Gia,idLoaiMonAn,MieuTa)	VALUES(N'Thị kho đậu hũ trứng cút',25000,1,NULL)
INSERT INTO MonAn(Ten,Gia,idLoaiMonAn,MieuTa)   VALUES(N'Sườn non ram mặn',30000,1,NULL)
INSERT INTO MonAn(Ten,Gia,idLoaiMonAn,MieuTa)   VALUES(N'Heo quay',25000,1,NULL)
INSERT INTO MonAn(Ten,Gia,idLoaiMonAn,MieuTa)   VALUES(N'Gà kho',25000,1,NULL)
INSERT INTO MonAn(Ten,Gia,idLoaiMonAn,MieuTa)   VALUES(N'Trứng chiên',25000,1,NULL)
INSERT INTO MonAn(Ten,Gia,idLoaiMonAn,MieuTa)   VALUES(N'Bò xào',25000,1,NULL)
INSERT INTO MonAn(Ten,Gia,idLoaiMonAn,MieuTa)   VALUES(N'Hủ tiếu',25000,1,NULL)
INSERT INTO MonAn(Ten,Gia,idLoaiMonAn,MieuTa)   VALUES(N'Tôm rim mặn',25000,1,NULL)

INSERT INTO MonAn(Ten,Gia,idLoaiMonAn,MieuTa)   VALUES(N'Chè bưởi',15000,2,NULL)
INSERT INTO MonAn(Ten,Gia,idLoaiMonAn,MieuTa)   VALUES(N'Chè hạt sen',10000,2,NULL)
INSERT INTO MonAn(Ten,Gia,idLoaiMonAn,MieuTa)   VALUES(N'Chè đậu đỏ',10000,2,NULL)
INSERT INTO MonAn(Ten,Gia,idLoaiMonAn,MieuTa)   VALUES(N'Chè đậu đen',10000,2,NULL)
INSERT INTO MonAn(Ten,Gia,idLoaiMonAn,MieuTa)   VALUES(N'Nước suối',5000,2,NULL)

INSERT INTO MonAn(Ten,Gia,idLoaiMonAn,MieuTa)   VALUES(N'Chanh dây',15000,3,NULL)
INSERT INTO MonAn(Ten,Gia,idLoaiMonAn,MieuTa)   VALUES(N'Nước cam',15000,3,NULL)
INSERT INTO MonAn(Ten,Gia,idLoaiMonAn,MieuTa)   VALUES(N'Trà xanh',10000,3,NULL)
INSERT INTO MonAn(Ten,Gia,idLoaiMonAn,MieuTa)   VALUES(N'Xá xị',10000,3,NULL)

--- Table LoaiMonAn
INSERT INTO LoaiMonAn(Ten_loai)	VALUES(N'Cơm phần')
INSERT INTO LoaiMonAn(Ten_loai) VALUES(N'Chè')
INSERT INTO LoaiMonAn(Ten_loai) VALUES(N'Nước')

--- Table MonAn_thuoc_LoaiMon
INSERT INTO MonAn_thuoc_LoaiMon(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)	VALUES(1,1)
INSERT INTO MonAn_thuoc_LoaiMon(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)	VALUES(1,2)
INSERT INTO MonAn_thuoc_LoaiMon(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)	VALUES(1,3)
INSERT INTO MonAn_thuoc_LoaiMon(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)   VALUES(1,4)
INSERT INTO MonAn_thuoc_LoaiMon(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)	VALUES(1,5)
INSERT INTO MonAn_thuoc_LoaiMon(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)	VALUES(1,6)
INSERT INTO MonAn_thuoc_LoaiMon(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)	VALUES(1,7)
INSERT INTO MonAn_thuoc_LoaiMon(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)	VALUES(1,8)
INSERT INTO MonAn_thuoc_LoaiMon(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)	VALUES(1,9)
INSERT INTO MonAn_thuoc_LoaiMon(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)	VALUES(1,10)
INSERT INTO MonAn_thuoc_LoaiMon(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)	VALUES(1,11)
INSERT INTO MonAn_thuoc_LoaiMon(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)	VALUES(1,12)
INSERT INTO MonAn_thuoc_LoaiMon(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)	VALUES(1,13)
INSERT INTO MonAn_thuoc_LoaiMon(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)	VALUES(1,14)
INSERT INTO MonAn_thuoc_LoaiMon(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)	VALUES(2,15)
INSERT INTO MonAn_thuoc_LoaiMon(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)	VALUES(2,16)
INSERT INTO MonAn_thuoc_LoaiMon(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)	VALUES(2,17)
INSERT INTO MonAn_thuoc_LoaiMon(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)	VALUES(2,18)
INSERT INTO MonAn_thuoc_LoaiMon(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)	VALUES(3,19)
INSERT INTO MonAn_thuoc_LoaiMon(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)	VALUES(3,20)
INSERT INTO MonAn_thuoc_LoaiMon(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)	VALUES(3,21)
INSERT INTO MonAn_thuoc_LoaiMon(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)	VALUES(3,22)
INSERT INTO MonAn_thuoc_LoaiMon(LoaiMonAn_idLoaiMonAn,MonAn_idMonAn)	VALUES(3,23)


--Table HoaDon
INSERT INTO HoaDon(NgayLap,TongTien,NhanVien_idNhanVien)	VALUES('2019/10/9',25000,'001')
INSERT INTO HoaDon(NgayLap,TongTien,NhanVien_idNhanVien)  VALUES('2019/10/13',40000,'001')
INSERT INTO HoaDon(NgayLap,TongTien,NhanVien_idNhanVien)  VALUES('2019/11/9',55000,'002')
INSERT INTO HoaDon(NgayLap,TongTien,NhanVien_idNhanVien)  VALUES('2019/12/19',20000,'002')

INSERT INTO HoaDon(NgayLap,TongTien,NhanVien_idNhanVien)  VALUES('9/12/2019',25000,'005' )
INSERT INTO HoaDon(NgayLap,TongTien,NhanVien_idNhanVien)  VALUES('9/10/2019',25000,'005' )
INSERT INTO HoaDon(NgayLap,TongTien,NhanVien_idNhanVien)  VALUES('9/10/2019',30000,'001' )
INSERT INTO HoaDon(NgayLap,TongTien,NhanVien_idNhanVien)  VALUES('9/10/2019',35000,'001' )
INSERT INTO HoaDon(NgayLap,TongTien,NhanVien_idNhanVien)  VALUES('9/11/2019',35000,'002' )
INSERT INTO HoaDon(NgayLap,TongTien,NhanVien_idNhanVien)  VALUES('9/11/2019',25000,'002' )
INSERT INTO HoaDon(NgayLap,TongTien,NhanVien_idNhanVien)  VALUES('9/10/2019',25000,'002' )
INSERT INTO HoaDon(NgayLap,TongTien,NhanVien_idNhanVien)  VALUES('9/12/2019',35000,'005' )
INSERT INTO HoaDon(NgayLap,TongTien,NhanVien_idNhanVien)  VALUES('9/12/2019',35000,'005' )
INSERT INTO HoaDon(NgayLap,TongTien,NhanVien_idNhanVien)  VALUES('9/10/2019',25000, '005' )
INSERT INTO HoaDon(NgayLap,TongTien,NhanVien_idNhanVien)  VALUES('9/11/2019',40000, '006' )
INSERT INTO HoaDon(NgayLap,TongTien,NhanVien_idNhanVien)  VALUES('9/11/2019',25000, '006' )
INSERT INTO HoaDon(NgayLap,TongTien,NhanVien_idNhanVien)  VALUES('9/11/2019',35000, '001' )
INSERT INTO HoaDon(NgayLap,TongTien,NhanVien_idNhanVien)  VALUES('9/10/2019',25000, '006' )
INSERT INTO HoaDon(NgayLap,TongTien,NhanVien_idNhanVien)  VALUES('9/12/2019',45000, '006' )

-- Table ChiTietHoaDon
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(1,11 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(2,14 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(2,20 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(3,6 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(3,18 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(3,11 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(4,6 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(5,11 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(6,11 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(7,20 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(7,21 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(8,5 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(8,22 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(9,11 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(9,23 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(10,11 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(11,11 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(12,12 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(12,23 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(14,11 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(15,10 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(15,23 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(16,11 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(17,9 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(17,18 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(18,11 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(18,14 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(19,9 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(19,22 ,1)
INSERT INTO ChiTietHoaDon(HoaDon_idHoaDon, MonAn_idMonAn,SoLuong)   VALUES(19,23 ,1)
























