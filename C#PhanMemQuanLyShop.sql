create database PhanMemQuanLyShop
go

USE PhanMemQuanLyShop
go

-- Khach Hang R
-- Account r
-- Hang hóa r
-- Nhân viên R
-- Thông tin hóa đơn
-- Hóa đơn




create table KhachHang
(
	MaKH INT IDENTITY PRIMARY KEY,
	TenKH NVARCHAR(250),
	SDT NUMERIC(18, 0),
	GioiTinh NCHAR(100),    --NAM || NỮ--
	DiaChi NVARCHAR(250)
)
GO

CREATE TABLE Account
(
	id INT IDENTITY PRIMARY KEY,
	TaiKhoan NVARCHAR(100) NOT NULL,
	MatKhau NVARCHAR(1000) NOT NULL,
	TenHienThi NVARCHAR(100) NOT NULL,
	Quyen INT NOT NULL DEFAULT 0 -- 1 ADMIN , 0 USER--
)
GO

CREATE TABLE HangHoa
(
	MaHang INT 	PRIMARY KEY,
	TenHang NVARCHAR (250),
	DonGia FLOAT,
	SoLuong NUMERIC (18, 0),
	DVT NUMERIC (18, 0)
)
GO

CREATE TABLE NhanVien
(
	MaNV NCHAR(20) PRIMARY KEY,
	TenNhanVien NVARCHAR(250),
	NgaySinh DATE,
	GioiTinh NCHAR(5),
	DiaChi NVARCHAR(50),
	SDT NVARCHAR(12)
)
GO

CREATE TABLE HoaDon
(
	MaHoaDon INT IDENTITY PRIMARY KEY,
	MaKH INT,
	TenNhanVien NVARCHAR(250)
	
)
GO

CREATE TABLE CTHD
(
	MaHoaDon INT IDENTITY PRIMARY KEY,
	MaHang INT ,
	MaKH INT,
	DonGia FLOAT,
	SoLuong NUMERIC (18, 0),
	DVT NUMERIC (18, 0),
	ThanhTien FLOAT,
	TrangThai INT NOT NULL DEFAULT 0 --1 THANH TOÁN, 0 CHƯA THANH TOÁN--
)
GO

INSERT INTO dbo.Account
			(
				TaiKhoan,
				MatKhau,
				TenHienThi,
				Quyen
			)
VALUES		( N'HAO',
			  N'1',
			  N'HAO',
			  1
			 )
INSERT INTO dbo.Account
			(
				TaiKhoan,
				MatKhau,
				TenHienThi,
				Quyen
			)
VALUES		( N'staff',
			  N'1',
			  N'HAO',
			  1
			 )


SELECT * FROM dbo.Account

GO
CREATE PROC HangHoa_GetListHangHoa
@TenHang nvarchar(250)
AS
BEGIN
	SELECT * FROM dbo.HangHoa WHERE TenHang = @TenHang
END
GO

EXEC dbo.HangHoa_GetListHangHoa @TenHang = N'nhẫn'