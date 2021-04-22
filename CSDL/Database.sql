create database QL_Khach_San;
use ql_khach_san;
create table KHACHHANG
(
	MAKH int AUTO_INCREMENT PRIMARY KEY,
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
create table THONGKEGIAODICH
(
	MAGD INT AUTO_INCREMENT primary KEY,
    MAKH int,
    foreign key (MAKH) references KHACHHANG(MAKH),
    MAPHONG CHAR(4),
    foreign key (MAPHONG) references PHONG(MAPHONG),
    NGAYDEN datetime,
    NGAYDI date,
    SOTIENDATHANHTOAN int
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
/* truy van 
update phong set tinhtrang = 'Còn Trống' where maphong = 'P15';
insert into admin(taikhoan,matkhau) values('admin26062001@gmail.com','admin2001');	
select * from admin;
Select khachhang.makh,ngayden,PHONG.MAPHONG,KHACHHANG.HOTEN, datediff(curdate() , khachhang.ngayden) as "Ngay_o",datediff(curdate(),khachhang.NGAYDEN) *phong.DONGIA as lbtongtien
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
*/
#

/* capnhat admin */
alter table admin
add column UserID int AUTO_INCREMENT primary key,
add column Firstname nvarchar(20) not null,
add column lastname nvarchar(20) not null,
add column Position nvarchar (100) not null,
add column Email nvarchar(150)not null;
ALTER TABLE admin CHANGE TaiKhoan LoginName nvarchar(100);
ALTER TABLE admin CHANGE MatKhau Password nvarchar(100);
-- rằng buộc cho ngày nhân viên nhập vào phải nhỏ hơn ngày hiện tại
alter table khachhang add constraint CK_NGAY check(datediff(curdate(),ngayden) >= 0);
select ngayden, curdate() as ngayhientai from khachhang;
# them tài khoản
INSERT INTO admin(TaiKhoan,MatKhau) VALUES('MinhKhanh','020901'); 
INSERT INTO admin(TaiKhoan,MatKhau) VALUES('KhanhVu','020901');
INSERT INTO admin(TaiKhoan,MatKhau) VALUES('adminhuy','260601');
UPDATE admin 
SET 
	Firstname = N'Vũ',
    lastname = N'Quốc Khánh',
    Position ='Staff',
    email = '0982483015kk@gmail.com'
WHERE
    UserId = 2;
    
UPDATE admin 
SET 
	Firstname = N'Đoàn',
    lastname = N'Minh Khánh',
    Position ='Staff',
    email = 'khanhdoan693@gmail.com'
WHERE
    UserId = 1;
    
UPDATE admin 
SET 
	Firstname = N'Huỳnh',
    lastname = N'Đức Huy',
    Position ='Staff',
    email = 'huynhduchuy2001@gmail.com'
WHERE
    UserId = 3;
    
/* chuan hoa tien */
DELIMITER $$
CREATE PROCEDURE  usp_tongten ()
BEGIN
set @a  = (select sum(SOTIENDATHANHTOAN) from thongkegiaodich);
set @b = (select length(@a));
IF  (select @b = 6 ) then select concat((select left(@a, 3)),',',(select SUBSTRING((select @a),4, 1)),' ','K');
elseif  (select @b = 7)  then select concat((select left(@a, 1)),',',(select SUBSTRING((select @a),4, 1)),' ','Tr');
elseif (select @b = 8 ) then select concat((select left(@a, 2)),',',(select SUBSTRING((select @a),4, 1)),' ','Tr');
elseif (select @b = 9) then select concat((select left(@a, 3)),',',(select SUBSTRING((select @a),4, 1)),' ','Tr');
elseif (select @b = 10 ) then select concat((select left(@a, 1)),',',(select SUBSTRING((select @a),2, 1)),' ','Tỉ');
elseif (select @b = 11 ) then select concat((select left(@a, 2)),',',(select SUBSTRING((select @a),3, 1)),' ','Tỉ');
end if;
END;
DELIMITER;
call ql_khach_san.usp_tongten();

/* TK thang , Nam*/
select month(ngaydi) as "Thang",sum(sotiendathanhtoan) as "Thang" from thongkegiaodich 
group by month(ngaydi)
order by month(ngaydi);

select year(ngaydi) as "Nam",sum(sotiendathanhtoan) as "Tong_DT_Nam" from thongkegiaodich
group by year(ngaydi)
order by year(ngaydi);
create View ShowDT AS select month(ngaydi) as "Thang",sum(sotiendathanhtoan) as "Tong_DT_Thang" from thongkegiaodich
group by month(ngaydi);

/* updata khachhang*/
INSERT INTO `ql_khach_san`.`khachhang` (`HOTEN`, `SOCMND`, `NGAYDEN`, `MAPHONG`, `TinhTrangTT`) VALUES ('Vũ Quốc Khánh', '10', '2021-02-02', 'P03', 'Chưa Thanh Toán');
INSERT INTO `ql_khach_san`.`khachhang` (`HOTEN`, `SOCMND`, `NGAYDEN`, `MAPHONG`, `TinhTrangTT`) VALUES ('Vũ Quốc Khánh', '3', '2021-10-02', 'P04', 'Chưa Thanh Toán');
INSERT INTO `ql_khach_san`.`khachhang` (`HOTEN`, `SOCMND`, `NGAYDEN`, `MAPHONG`, `TinhTrangTT`) VALUES ('Vũ Quốc Khánh', '4', '2021-01-02', 'P05', 'Chưa Thanh Toán');
INSERT INTO `ql_khach_san`.`khachhang` (`HOTEN`, `SOCMND`, `NGAYDEN`, `MAPHONG`, `TinhTrangTT`) VALUES ('Vũ Quốc Khánh', '5', '2021-05-02', 'P06', 'Chưa Thanh Toán');
INSERT INTO `ql_khach_san`.`khachhang` (`HOTEN`, `SOCMND`, `NGAYDEN`, `MAPHONG`, `TinhTrangTT`) VALUES ('Vũ Quốc Khánh', '6', '2021-06-02', 'P07', 'Chưa Thanh Toán');
INSERT INTO `ql_khach_san`.`khachhang` (`HOTEN`, `SOCMND`, `NGAYDEN`, `MAPHONG`, `TinhTrangTT`) VALUES ('Vũ Quốc Khánh', '7', '2021-07-02', 'P08', 'Chưa Thanh Toán');
INSERT INTO `ql_khach_san`.`khachhang` (`HOTEN`, `SOCMND`, `NGAYDEN`, `MAPHONG`, `TinhTrangTT`) VALUES ('Vũ Quốc Khánh', '8', '2021-08-02', 'P09', 'Chưa Thanh Toán');
INSERT INTO `ql_khach_san`.`khachhang` (`HOTEN`, `SOCMND`, `NGAYDEN`, `MAPHONG`, `TinhTrangTT`) VALUES ('Vũ Quốc Khánh', '9', '2021-09-02', 'P10', 'Chưa Thanh Toán');

INSERT INTO `ql_khach_san`.`khachhang` (`HOTEN`, `SOCMND`, `NGAYDEN`, `MAPHONG`, `TinhTrangTT`) VALUES ('Vũ Quốc Khánh', '99', '2020-08-02', 'P09', 'Chưa Thanh Toán');
INSERT INTO `ql_khach_san`.`khachhang` (`HOTEN`, `SOCMND`, `NGAYDEN`, `MAPHONG`, `TinhTrangTT`) VALUES ('Vũ Quốc Khánh', '98', '2019-09-02', 'P10', 'Chưa Thanh Toán');
INSERT INTO `ql_khach_san`.`khachhang` (`HOTEN`, `SOCMND`, `NGAYDEN`, `MAPHONG`, `TinhTrangTT`) VALUES ('Vũ Quốc Khánh', '97', '2018-08-02', 'P09', 'Chưa Thanh Toán');
INSERT INTO `ql_khach_san`.`khachhang` (`HOTEN`, `SOCMND`, `NGAYDEN`, `MAPHONG`, `TinhTrangTT`) VALUES ('Vũ Quốc Khánh', '96', '2017-09-02', 'P10', 'Chưa Thanh Toán');
INSERT INTO `ql_khach_san`.`khachhang` (`HOTEN`, `SOCMND`, `NGAYDEN`, `MAPHONG`, `TinhTrangTT`) VALUES ('Vũ Quốc Khánh', '91', '2016-09-02', 'P10', 'Chưa Thanh Toán');


/* xem gia tri cuoi auto tang */
SELECT last_insert_id()

# xem mỗi lươt tăng bao nhieu value
SELECT `AUTO_INCREMENT`
FROM  INFORMATION_SCHEMA.TABLES
WHERE TABLE_SCHEMA = 'ql_khach_san'
AND   TABLE_NAME   = 'khachhang';

# show
SHOW TABLE STATUS FROM `ql_khach_san` WHERE `name` LIKE 'khachhang' ;

# gia tri tiep theo cua MaKH
SELECT max(makh)+1 FROM khachhang ;

# Chỉ cho xem phòng còn trống 
select maphong from phong where TinhTrang = 'Còn Trống'

# cập nhật tiền tệ trong thongkegiaodich
ALTER TABLE `ql_khach_san`.`thongkegiaodich` 
CHANGE COLUMN `sotiendathanhtoan` `sotiendathanhtoan` DECIMAL(12) NULL DEFAULT NULL ;



select makh,maphong from khachhang where maphong = 'P03';




