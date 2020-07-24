CREATE DATABASE SHOP2
GO
USE SHOP2


-- NHANVIEN
CREATE TABLE NHANVIEN(
	MANV	char(4) not null,	
	HOTEN	varchar(40),
	SODT	varchar(20),
	CMND 	NUMERIC(18,0)
	constraint pk_nv primary key(MANV)
)
---------------------------------------------
-- SANPHAM
CREATE TABLE SANPHAM(
	MASP	char(4) not null,
	TENSP	NVARCHAR(250),
	DVT	NVARCHAR(250),
	GIA	FLOAT,
	CONSTRAINT pk_sp PRIMARY KEY(MASP)	
)
---------------------------------------------
-- HOADON
CREATE TABLE HOADON(
	SOHD	int not null,
	NGHD 	smalldatetime,
	MANV 	char(4),
	constraint pk_hd primary key(SOHD)
)
---------------------------------------------
--Đôi tác
CREATE TABLE DOITAC(
	TENDOITAC NVARCHAR(250),
	SODT NVARCHAR(10),
	DCHI NVARCHAR(250),
	TENSP NVARCHAR(250),
	CONSTRAINT pk_dt PRIMARY KEY(TENDOITAC)
)
	
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
	
INSERT dbo.SANPHAM( MASP, TENSP, DVT, GIA )VALUES  ( '', '', '',NULL )
-- Khoa ngoai cho bang HOADON
ALTER TABLE HOADON ADD CONSTRAINT fk02_HD FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV)
-- Khoa ngoai cho bang CTHD
ALTER TABLE CTHD ADD CONSTRAINT fk01_CTHD FOREIGN KEY(SOHD) REFERENCES HOADON(SOHD)
ALTER TABLE CTHD ADD CONSTRAINT fk02_CTHD FOREIGN KEY(MASP) REFERENCES SANPHAM(MASP)
-----------------------------------------------------
-----------------------------------------------------
set dateformat dmy

----------------------------------------------------------------
UPDATE dbo.SANPHAM SET MASP = N'M07', TENSP = 'toc' WHERE 

--
INSERT dbo.NHANVIEN ( MANV, HOTEN, SODT, NGVL ) VALUES  ( '', '', '', NULL ) 
select * from dbo.Account where TaiKhoan = N'admin' AND MatKhau = N'admin'
	--
	select * from dbo.Account
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
ALTER TABLE  Account ADD NhapLaiMatKhau NVARCHAR(250)
ALTER TABLE dbo.HOADON ADD SL NVARCHAR(10)
