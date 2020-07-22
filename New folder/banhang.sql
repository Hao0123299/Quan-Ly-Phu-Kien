CREATE DATABASE SHOP2
GO
USE SHOP2
-- KHACHANG
CREATE TABLE KHACHHANG(
	MAKH	char(4) not null,	
	HOTEN	nvarchar(40),
	DCHI	nvarchar(50),
	SODT	nvarchar(20),
	NGSINH	date,
	NGDK	date,
	DOANHSO	money,
	constraint pk_kh primary key(MAKH)
)
---------------------------------------------
-- NHANVIEN
CREATE TABLE NHANVIEN(
	MANV	char(4) not null,	
	HOTEN	varchar(40),
	SODT	varchar(20),
<<<<<<< HEAD
	CMND 	NUMERIC(18,0)
=======
<<<<<<< HEAD
	CMND 	NUMERIC(18,0)
=======
	NGVL	smalldatetime	
>>>>>>> 08c170dcfdb7a1df82c6fb0c3a0fcfb6d1affc6f
>>>>>>> 6ead9ff9b40c86cacbff09c7f9a41abb9cd196c5
	constraint pk_nv primary key(MANV)
)
---------------------------------------------
-- SANPHAM
CREATE TABLE SANPHAM(
	MASP	char(4) not null,
	TENSP	NVARCHAR(250),
	DVT	NVARCHAR(250),
	GIA	FLOAT,
	constraint pk_sp primary key(MASP)	
)
---------------------------------------------
-- HOADON
CREATE TABLE HOADON(
	SOHD	int not null,
	NGHD 	smalldatetime,
	MAKH 	char(4),
	MANV 	char(4),
	constraint pk_hd primary key(SOHD)
)
---------------------------------------------
<<<<<<< HEAD
--Đôi tác
CREATE TABLE DoiTac(
	
=======
<<<<<<< HEAD
--Đôi tác
CREATE TABLE DoiTac(
	
=======
>>>>>>> 08c170dcfdb7a1df82c6fb0c3a0fcfb6d1affc6f
>>>>>>> 6ead9ff9b40c86cacbff09c7f9a41abb9cd196c5
-- CTHD
   CREATE TABLE CTHD(
	SOHD	int,
	MASP	char(4),
	SL	int,
	constraint pk_cthd primary key(SOHD,MASP)
)

--Account 
	CREATE TABLE Account
	(
	TaiKhoan NVARCHAR(250) primary key,
	MatKhau NVARCHAR(250),
	)
--them cot quyen
	ALTER TABLE Account ADD quyen nvarchar(10);
	--
	select * from dbo.Account where TaiKhoan = N'admin' AND MatKhau = N'admin'
	--
	select * from dbo.Account
	--
	
	--
	go

	create proc USP_Account
	@TaiKhoan nvarchar(250), @MatKhau nvarchar(250)
	as
	begin
		select * from  dbo.Account where TaiKhoan = @TaiKhoan AND MatKhau = @MatKhau
	end
	GO
    
	--
	GO
	DECLARE @i  int = 0

	WHILE @i <=5
	BEGIN
		INSERT dbo.SANPHAM (MASP) VALUES  ( N'Ma ' + @i)
		SET @i =@i +1
	END 

	INSERT INTO dbo.SANPHAM ( MASP, TENSP, DVT, GIA ) VALUES  ( '', '', '', '') ( MASP, TENSP, DVT, GIA )
	VALUES  ( '', -- MASP - char(4)
	          '', -- TENSP - varchar(40)
	          '', -- DVT - varchar(20)
	          NULL  -- GIA - money
	          )( MASP, TENSP, DVT, GIA)
	VALUES  ( N'Ma01', -- MASP - char(4)
	          N'Nhan', -- TENSP - varchar(40)
	          N'chiec', -- DVT - varchar(20)
	          NULL  -- GIA - money
	          )
--
INSERT dbo.SANPHAM( MASP, TENSP, DVT, GIA )VALUES  ( '', '', '',NULL )
-- Khoa ngoai cho bang HOADON
ALTER TABLE HOADON ADD CONSTRAINT fk01_HD FOREIGN KEY(MAKH) REFERENCES KHACHHANG(MAKH)
ALTER TABLE HOADON ADD CONSTRAINT fk02_HD FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV)
-- Khoa ngoai cho bang CTHD
ALTER TABLE CTHD ADD CONSTRAINT fk01_CTHD FOREIGN KEY(SOHD) REFERENCES HOADON(SOHD)
ALTER TABLE CTHD ADD CONSTRAINT fk02_CTHD FOREIGN KEY(MASP) REFERENCES SANPHAM(MASP)
-----------------------------------------------------
-----------------------------------------------------
set dateformat dmy
-------------------------------
-- KHACHHANG
insert into khachhang values('KH01','Nguyen Van A','731 Tran Hung Dao, Q5, TpHCM','8823451','22/10/1960','22/07/2006',13060000)
insert into khachhang values('KH02','Tran Ngoc Han','23/5 Nguyen Trai, Q5, TpHCM','908256478','03/04/1974','30/07/2006',280000)
insert into khachhang values('KH03','Tran Ngoc Linh','45 Nguyen Canh Chan, Q1, TpHCM','938776266','12/06/1980','08/05/2006',3860000)
insert into khachhang values('KH04','Tran Minh Long','50/34 Le Dai Hanh, Q10, TpHCM','917325476','09/03/1965','10/02/2006',250000)
insert into khachhang values('KH05','Le Nhat Minh','34 Truong Dinh, Q3, TpHCM','8246108','10/03/1950','28/10/2006',21000)
insert into khachhang values('KH06','Le Hoai Thuong','227 Nguyen Van Cu, Q5, TpHCM','8631738','31/12/1981','24/11/2006',915000)
insert into khachhang values('KH07','Nguyen Van Tam','32/3 Tran Binh Trong, Q5, TpHCM','916783565','06/04/1971','12/01/2006',12500)
insert into khachhang values('KH08','Phan Thi Thanh','45/2 An Duong Vuong, Q5, TpHCM','938435756','10/01/1971','13/12/2006',365000)
insert into khachhang values('KH09','Le Ha Vinh','873 Le Hong Phong, Q5, TpHCM','8654763','03/09/1979','14/01/2007',70000)
insert into khachhang values('KH10','Ha Duy Lap','34/34B Nguyen Trai, Q1, TpHCM','8768904','02/05/1983','16/01/2007',67500)

-------------------------------
-- NHANVIEN
insert into nhanvien values('NV01','Nguyen Nhu Nhut','927345678','13/04/2006')
insert into nhanvien values('NV02','Le Thi Phi Yen','987567390','21/04/2006')
insert into nhanvien values('NV03','Nguyen Van B','997047382','27/04/2006')
insert into nhanvien values('NV04','Ngo Thanh Tuan','913758498','24/06/2006')
insert into nhanvien values('NV05','Nguyen Thi Truc Thanh','918590387','20/07/2006')

-------------------------------
-- SANPHAM
insert into sanpham values('M01','Nhan','chiec',150000)
insert into sanpham values('M02','Day chuyen','soi',500000)
insert into sanpham values('M03','Kep toc','cai',3500)
insert into sanpham values('M04','No','cai',30000)
insert into sanpham values('M05','Quat','cai',35000)
insert into sanpham values('M06','Tat','doi',25000)


-------------------------------
-- HOADON
insert into hoadon values(1001,'23/07/2006','KH01','NV01',650000)
insert into hoadon values(1002,'12/08/2006','KH01','NV02',840000)
insert into hoadon values(1003,'23/08/2006','KH02','NV01',100000)
insert into hoadon values(1004,'01/09/2006','KH02','NV01',180000)
insert into hoadon values(1005,'20/10/2006','KH01','NV02',3800000)

--Account
insert into Account values('admin','admin')
insert into Account values('user1','user1')
insert into Account values('user2','user2')

-------------------------------
-- CTHD
insert into cthd values(1001,'M01',10)
insert into cthd values(1001,'M02',5)
insert into cthd values(1001,'M03',5)
insert into cthd values(1001,'M04',10)

----------------------------------------------------------------
----------------------------------------------------------------
UPDATE dbo.SANPHAM SET MASP = N'M07', TENSP = 'toc' WHERE 

--
INSERT dbo.NHANVIEN ( MANV, HOTEN, SODT, NGVL ) VALUES  ( '', '', '', NULL ) 
          