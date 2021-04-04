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

select count(MAPHONG)  from Phong where Tinhtrang = N'Còn Trống'; 
select count(MaKh) from khachhang ;
select count(MAGD) from thongkegiaodich;
INSERT INTO admin(TaiKhoan,matkhau) VALUES('MinhKhanh','020901'); 
INSERT INTO admin(TaiKhoan,matkhau) VALUES('KhanhVu','020901'); 

/* capnhat admin */
alter table admin
add column UserID int AUTO_INCREMENT primary key,
add column Firstname nvarchar(20) not null,
add column lastname nvarchar(20) not null,
add column Position nvarchar (100) not null,
add column Email nvarchar(150)not null;

ALTER TABLE admin CHANGE TaiKhoan LoginName nvarchar(100);
ALTER TABLE admin CHANGE MatKhau Password nvarchar(100);


UPDATE admin 
SET 
	Firstname = 'Vu',
    lastname = 'Quoc Khanh',
    Position ='Staff',
    email = '0982483015kk@gmail.com'
WHERE
    UserId = 3;
    
/* chuan hoa tien */
DELIMITER $$
CREATE PROCEDURE  usp_tongten ()
BEGIN
set @a  = (select sum(SOTIENDATHANHTOAN) from thongkegiaodich);
set @b = (select length(@a));
set @c = (select left(@a, 3));
IF  (select @b = 6 ) then select concat((select left(@a, 3)),' ','K');
elseif  (select @b = 7)  then select concat((select left(@a, 1)),' ','Tr');
elseif (select @b = 8 ) then select concat((select left(@a, 2)),' ','Tr');
elseif (select @b = 9) then select concat((select left(@a, 3)),' ','Tr');
elseif (select @b = 10 ) then select concat((select left(@a, 1)),' ','Tỉ');
end if;
END;
DELIMITER;
call ql_khach_san.usp_tongten();
select lastname from admin where

select* from Phong where Tinhtrang = N'Còn Trống'