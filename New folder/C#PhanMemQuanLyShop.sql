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
	TenKH NVARCHAR(250) PRIMARY KEY,
	SDT NUMERIC(18, 0),
	GioiTinh NCHAR(100),    --NAM || NỮ--
	DiaChi NVARCHAR(250)
)
GO

CREATE TABLE Account
(
	TaiKhoan NVARCHAR(100) PRIMARY KEY NOT NULL,
	MatKhau NVARCHAR(1000) NOT NULL,
)
GO

CREATE TABLE HangHoa
(
	MaHang INT 	PRIMARY KEY,
	TenHang NVARCHAR (250),
	DonGia FLOAT,
	SoLuong NUMERIC (18, 0),
)
GO

CREATE TABLE NhanVien
(
	MaNV NCHAR(20),
	TenNhanVien NVARCHAR(250) PRIMARY KEY,
	NgaySinh DATE,
	GioiTinh NCHAR(5),
	DiaChi NVARCHAR(50),
	SDT NVARCHAR(12)
)
GO

CREATE TABLE TTHD
(
	MaHoaDon INT IDENTITY PRIMARY KEY,

	TenNhanVien NVARCHAR(250), -- tên nhan viên bang nv
	TenKH NVARCHAR(250), -- tenkh bang khach hang
	NgayLap Date	

	FOREIGN KEY (TenNhanVien) REFERENCES dbo.NhanVien(TenNhanVien)
)
GO

CREATE TABLE CTHD
(
	TenHang NVARCHAR (250), -- bang hang hoa
	DonGia FLOAT,
	SoLuong NUMERIC (18, 0),
	ThanhTien FLOAT,
)
GO

INSERT INTO dbo.Account
			(
				TaiKhoan,
				MatKhau,
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