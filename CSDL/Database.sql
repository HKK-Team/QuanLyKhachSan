create database QL_Khach_San;
create table KHACHHANG
(
	MAKH CHAR(4) PRIMARY KEY,
	HOTEN NVARCHAR(30),
	SOCMND CHAR(9) unique,
	NGAYDEN DATE,
	MAPHONG CHAR(4),
	FOREIGN KEY (MAPHONG) REFERENCES PHONG(MAPHONG),
    TinhTrangTT nvarchar(30)
);
create table THONGKEGIAODICH
(
	MAGD INT AUTO_INCREMENT primary KEY,
    MAKH CHAR(4),
    foreign key (MAKH) references KHACHHANG(MAKH),
    MAPHONG CHAR(4),
    foreign key (MAPHONG) references PHONG(MAPHONG),
    NGAYDEN datetime,
    NGAYDI date,
    SOTIENDATHANHTOAN int
);
CREATE TABLE PHONG
(
	MAPHONG CHAR(4) PRIMARY KEY,
	SOGIUONG INT,
	DONGIA INT,
	TINHTRANG NVARCHAR(12)
);
create table Admin
(
	TaiKhoan nchar(50),
    MatKhau nchar(50)
);
INSERT INTO PHONG(MAPHONG,SOGIUONG,DONGIA,TINHTRANG) VALUES('P01',2,320000,'Còn trống');
INSERT INTO PHONG(MAPHONG,SOGIUONG,DONGIA,TINHTRANG) VALUES('P02',3,400000,'Còn trống');
INSERT INTO PHONG(MAPHONG,SOGIUONG,DONGIA,TINHTRANG) VALUES('P03',4,520000,'Còn trống');
INSERT INTO PHONG(MAPHONG,SOGIUONG,DONGIA,TINHTRANG) VALUES('P04',1,150000,'Còn trống');
INSERT INTO PHONG(MAPHONG,SOGIUONG,DONGIA,TINHTRANG) VALUES('P05',2,320000,'Còn trống');
INSERT INTO PHONG(MAPHONG,SOGIUONG,DONGIA,TINHTRANG) VALUES('P06',5,650000,'Còn trống');
INSERT INTO PHONG(MAPHONG,SOGIUONG,DONGIA,TINHTRANG) VALUES('P07',3,400000,'Còn trống');
INSERT INTO PHONG(MAPHONG,SOGIUONG,DONGIA,TINHTRANG) VALUES('P08',1,150000,'Còn trống');
INSERT INTO PHONG(MAPHONG,SOGIUONG,DONGIA,TINHTRANG) VALUES('P09',2,320000,'Còn trống');
INSERT INTO PHONG(MAPHONG,SOGIUONG,DONGIA,TINHTRANG) VALUES('P10',1,150000,'Còn trống');
INSERT INTO PHONG(MAPHONG,SOGIUONG,DONGIA,TINHTRANG) VALUES('P11',4,520000,'Còn trống');
INSERT INTO PHONG(MAPHONG,SOGIUONG,DONGIA,TINHTRANG) VALUES('P12',5,650000,'Còn trống');
INSERT INTO PHONG(MAPHONG,SOGIUONG,DONGIA,TINHTRANG) VALUES('P13',4,520000,'Còn trống');
INSERT INTO PHONG(MAPHONG,SOGIUONG,DONGIA,TINHTRANG) VALUES('P14',3,400000,'Còn trống');
INSERT INTO PHONG(MAPHONG,SOGIUONG,DONGIA,TINHTRANG) VALUES('P15',5,650000,'Còn trống');

update phong set tinhtrang = 'Còn Trống' where maphong = 'P15';
insert into admin(taikhoan,matkhau) values('admin26062001@gmail.com','admin2001');	
select * from admin;
Select khachhang.makh,ngayden,PHONG.MAPHONG,KHACHHANG.HOTEN, curdate() - khachhang.ngayden as "Ngay ở",((curdate() - khachhang.NGAYDEN) *phong.DONGIA) as lbtongtien
FROM PHONG Inner Join KHACHHANG
ON PHONG.MAPHONG = KHACHHANG.MAPHONG
Where KHACHHANG.MAPHONG = phong.maphong;
update phong set tinhtrang = 'Đã Có Khách' where phong.MAPHONG = txtMaPhong.Text;
select hoten,khachhang.MAPHONG,tinhtrang
from phong,khachhang
where phong.MAPHONG = khachhang.MAPHONG;
alter table khachhang add column TinhTrangThanhToan nvarchar(100);
select curdate() as ngayhientai;
select ngayden from khachhang;
delete from thongkegiaodich where makh = 'KH01' or MAPHONG = 'P01';
select count(MAPHONG) as soluongphong from phong where TINHTRANG = 'Còn Trống';
select count(MAGD) as TongBill from thongkegiaodich;
select sum(SOTIENDATHANHTOAN) as tongdoanhthu from thongkegiaodich