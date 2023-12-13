create database dbQuanLyBanDienThoai_2
go

use dbQuanLyBanDienThoai_2 
go

create table DienThoai
(
	MaDT varchar(50) primary key,
	TenDT nvarchar(200),
	MoTa nvarchar(max),
	Gia numeric(18,0),
	SoLuong numeric(18,0),
	Anh varchar(50)
)
go

create table KhachHang
(
	MaKH varchar(50) primary key,
	TenKH nvarchar(200),
	DiaChi nvarchar(max),
	SDT varchar(10),
	NamSinh int
)
go

create table NhanVien
(
	MaNV varchar(50) primary key,
	TenNV nvarchar(200),
	KPI int,
	SDT varchar (10),
	NamSinh int
)
go

create table TaiKhoan
(
	TenTK varchar(100) primary key,
	MatKhau varchar(100),
	MaNV varchar(50) foreign key references NhanVien(MaNV)
)
go

create table DonHang 
(
	MaDH varchar(50) primary key,
	NgayDH date,
	MaKH varchar(50) foreign key references KhachHang(MaKH),
	MaNV varchar(50) foreign key references NhanVien(MaNV),
)
go

create table ChiTietDonHang
(
	MaDH varchar(50) foreign key references DonHang(MaDH),
	MaDT varchar(50) foreign key references DienThoai(MaDT),
	SoLuong numeric(18,0)
	primary key (MaDH, MaDT)
)
go

insert into DienThoai
values 
	('DT01', 'iPhone X', 'iphone apple', 18000000, 100, 'hinh1.png'),
	('DT02', 'iPhone 15 Pro', 'iphone apple', 30000000, 100, 'hinh2.png'),
	('DT03', 'Samsung Galaxy S22 Ultra', 'dien thoai samsung', 25000000, 200, 'hinh3.png'),
	('DT04', 'Samsung Galaxy Z Fold5', 'dien thoai samsung', 26000000, 150, 'hinh4.png'),
	('DT05', 'iPhone 14', 'iphone apple', 20000000, 240, 'hinh5.png'),
	('DT06', 'OPPO Reno10', 'dien thoai oppo', 10000000, 500, 'hinh6.png'),
	('DT07', 'Redmi 13T', 'dien thoai redmi', 11000000, 100, 'hinh7.png'),
	('DT08', 'iPhone 11 Pro Max', 'iphone apple', 20000000, 300, 'hinh8.png'),
	('DT09', 'Samsung Galaxy Note 9', 'dien thoai samsung', 15000000, 250, 'hinh9.png'),
	('DT10', 'iPhone 15 Pro Max', 'iphone apple', 31000000, 100, 'hinh10.png')
go

insert into KhachHang
values 
	('KH01', N'Nguyễn Viết Hùng', N'Đà Nẵng', '0905838948', 1995),
	('KH02', N'Trần Nguyên Thảo', N'Đà Nẵng', '0937736877', 1997),
	('KH03', N'Lê Xuân An', N'Đà Nẵng', '0905863448', 2000),
	('KH04', N'Nguyễn Trọng Nhân', N'Quảng Nam', '0337534242', 1987),
	('KH05', N'Nguyễn Lan Ngọc', N'Huế', '0905837465', 1991),
	('KH06', N'Trần Văn Tiến', N'Đà Nẵng', '0903556594', 2003),
	('KH07', N'Lê Viết Đức', N'Đà Nẵng', '0908836946', 1999),
	('KH08', N'Lê Mai Hương', N'Đà Nẵng', '0907838463', 1986)
go

insert into NhanVien
values 
	('NV01', N'Nguyễn Nam Hưng', 20, '0905358455', 1999),
	('NV02', N'Lê Minh Thành', 15, '0937736877', 1998),
	('NV03', N'Phan Minh Hùng', 16, '0905862358', 2001),
	('NV04', N'Nguyễn Khánh Sơn', 22, '0337534345', 1999)
go

insert into TaiKhoan
values
	('hung_pro', 'Abc123!@#', 'NV01'),
	('lethanh', 'helloWorld8', 'NV02'),
	('hung_phan', 'noHope@01', 'NV03'),
	('kson', 'Qn92promax', 'NV04')
go

set dateformat dmy;
insert into DonHang
values
	('DH01', '1/6/2023', 'KH01', 'NV03'),
	('DH02', '15/6/2023', 'KH02', 'NV03'),
	('DH03', '23/7/2023', 'KH03', 'NV02'),
	('DH04', '25/7/2023', 'KH04', 'NV01'),
	('DH05', '15/8/2023', 'KH05', 'NV01'),
	('DH06', '8/9/2023', 'KH06', 'NV04'),
	('DH07', '6/10/2023', 'KH07', 'NV02'),
	('DH08', '31/10/2023', 'KH08', 'NV04')
go

insert into ChiTietDonHang
values 
	('DH01', 'DT02', 1),
	('DH02', 'DT08', 1),
	('DH03', 'DT04', 1),
	('DH04', 'DT01', 1),
	('DH04', 'DT06', 1),
	('DH05', 'DT07', 1),
	('DH05', 'DT02', 1),
	('DH06', 'DT09', 1),
	('DH07', 'DT10', 1),
	('DH08', 'DT03', 1)
go