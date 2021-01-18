﻿create database QL_KhachSan
create table KHACHHANG
(
	MAKH CHAR(4) PRIMARY KEY,
	HOTEN NVARCHAR(30),
	SOCMND CHAR(9),
	NGAYDEN DATE,
	MAPHONG CHAR(4),
	FOREIGN KEY (MAPHONG) REFERENCES PHONG(MAPHONG),
	SONGAYLUUTRU DATE,
	THANHTIEN FLOAT
)
CREATE TABLE PHONG
(
	MAPHONG CHAR(4) PRIMARY KEY,
	SOGIUONG INT,
	DONGIA INT,
	TINHTRANG NVARCHAR(12)
)
INSERT INTO PHONG(MAPHONG,SOGIUONG,DONGIA,TINHTRANG) VALUES('P01',2,320000,N'Còn trống')
INSERT INTO PHONG(MAPHONG,SOGIUONG,DONGIA,TINHTRANG) VALUES('P02',3,400000,N'Còn trống')
INSERT INTO PHONG(MAPHONG,SOGIUONG,DONGIA,TINHTRANG) VALUES('P03',4,520000,N'Còn trống')
INSERT INTO PHONG(MAPHONG,SOGIUONG,DONGIA,TINHTRANG) VALUES('P04',1,150000,N'Đã có')
INSERT INTO PHONG(MAPHONG,SOGIUONG,DONGIA,TINHTRANG) VALUES('P05',2,320000,N'Còn trống')
INSERT INTO PHONG(MAPHONG,SOGIUONG,DONGIA,TINHTRANG) VALUES('P06',5,650000,N'Còn trống')
INSERT INTO PHONG(MAPHONG,SOGIUONG,DONGIA,TINHTRANG) VALUES('P07',3,400000,N'Đã có')
INSERT INTO PHONG(MAPHONG,SOGIUONG,DONGIA,TINHTRANG) VALUES('P08',1,150000,N'Còn trống')
INSERT INTO PHONG(MAPHONG,SOGIUONG,DONGIA,TINHTRANG) VALUES('P09',2,320000,N'Đã có')
INSERT INTO PHONG(MAPHONG,SOGIUONG,DONGIA,TINHTRANG) VALUES('P010',1,150000,N'Còn trống')
INSERT INTO PHONG(MAPHONG,SOGIUONG,DONGIA,TINHTRANG) VALUES('P011',4,520000,N'Còn trống')
INSERT INTO PHONG(MAPHONG,SOGIUONG,DONGIA,TINHTRANG) VALUES('P012',5,650000,N'Còn trống')
INSERT INTO PHONG(MAPHONG,SOGIUONG,DONGIA,TINHTRANG) VALUES('P013',4,520000,N'Đã có')
INSERT INTO PHONG(MAPHONG,SOGIUONG,DONGIA,TINHTRANG) VALUES('P014',3,400000,N'Còn trống')
INSERT INTO PHONG(MAPHONG,SOGIUONG,DONGIA,TINHTRANG) VALUES('P015',5,650000,N'Đã có')
ALTER TABLE KHACHHANG
ADD SONGAYLUUTRU INT
INSERT INTO KHACHHANG(MAKH,HOTEN,SOCMND,NGAYDEN,MAPHONG,SONGAYLUUTRU,THANHTIEN) VALUES('KH01',N'Huỳnh Đức Huy','123','2021-01-14','P01',5,1600000)
INSERT INTO KHACHHANG(MAKH,HOTEN,SOCMND,NGAYDEN,MAPHONG,SONGAYLUUTRU,THANHTIEN) VALUES('KH02',N'Huỳnh Đức Hoan','124','2021-01-13','P02',2,800000)
INSERT INTO KHACHHANG(MAKH,HOTEN,SOCMND,NGAYDEN,MAPHONG,SONGAYLUUTRU,THANHTIEN) VALUES('KH03',N'Huỳnh Đức Hùng','125','2021-01-16','P05',3,960000)
INSERT INTO KHACHHANG(MAKH,HOTEN,SOCMND,NGAYDEN,MAPHONG,SONGAYLUUTRU,THANHTIEN) VALUES('KH04',N'Phan Thị Cẩm Vân','126','2021-01-14','P011',6,3120000)
INSERT INTO KHACHHANG(MAKH,HOTEN,SOCMND,NGAYDEN,MAPHONG,SONGAYLUUTRU,THANHTIEN) VALUES('KH05',N'Huỳnh Đức Trường','127','2021-01-12','P015',2,1300000)
INSERT INTO KHACHHANG(MAKH,HOTEN,SOCMND,NGAYDEN,MAPHONG,SONGAYLUUTRU,THANHTIEN) VALUES('KH06',N'Huỳnh Trường Sinh','128','2021-01-11','P03',4,2080000)
INSERT INTO KHACHHANG(MAKH,HOTEN,SOCMND,NGAYDEN,MAPHONG,SONGAYLUUTRU,THANHTIEN) VALUES('KH07',N'Thân Văn Cây','129','2021-01-13','P06',3,1950000)
INSERT INTO KHACHHANG(MAKH,HOTEN,SOCMND,NGAYDEN,MAPHONG,SONGAYLUUTRU,THANHTIEN) VALUES('KH08',N'Ngô Thị Tường Vy','130','2021-01-14','P010',1,150000)
INSERT INTO KHACHHANG(MAKH,HOTEN,SOCMND,NGAYDEN,MAPHONG,SONGAYLUUTRU,THANHTIEN) VALUES('KH09',N'Huỳnh Đức Châu','131','2021-01-15','P08',3,450000)
INSERT INTO KHACHHANG(MAKH,HOTEN,SOCMND,NGAYDEN,MAPHONG,SONGAYLUUTRU,THANHTIEN) VALUES('KH10',N'Huỳnh Đức Cường','132','2021-01-12','P012',4,2600000)
INSERT INTO KHACHHANG(MAKH,HOTEN,SOCMND,NGAYDEN,MAPHONG,SONGAYLUUTRU,THANHTIEN) VALUES('KH11',N'Huỳnh Đức Dũng','133','2021-01-13','P04',2,300000)
INSERT INTO KHACHHANG(MAKH,HOTEN,SOCMND,NGAYDEN,MAPHONG,SONGAYLUUTRU,THANHTIEN) VALUES('KH12',N'Phan Hữu Khương','134','2021-01-14','P07',4,1600000)
INSERT INTO KHACHHANG(MAKH,HOTEN,SOCMND,NGAYDEN,MAPHONG,SONGAYLUUTRU,THANHTIEN) VALUES('KH13',N'Huỳnh Trà','135','2021-01-16','P09',1,320000)
INSERT INTO KHACHHANG(MAKH,HOTEN,SOCMND,NGAYDEN,MAPHONG,SONGAYLUUTRU,THANHTIEN) VALUES('KH14',N'Phan Hòa Bình','136','2021-01-12','P013',2,1040000)
INSERT INTO KHACHHANG(MAKH,HOTEN,SOCMND,NGAYDEN,MAPHONG,SONGAYLUUTRU,THANHTIEN) VALUES('KH10',N'Phan Ninh','137','2021-01-13','P015',3,1950000)

SELECT * FROM KHACHHANG
SELECT * FROM PHONG
SELECT DATEDIFF(DAY,KHACHHANG.NGAYDEN,GETDATE()) AS 'Số Ngày Ở' FROM KHACHHANG