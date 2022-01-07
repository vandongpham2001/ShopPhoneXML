--create database ShopPhone
go
use ShopPhone
go
create table NhaCungCap
(
	MaNCC varchar(10) primary key,
	TenNCC nvarchar(50),
	DiaChi nvarchar(100),
	SDT	   nvarchar(11),
	Email	nvarchar(100)
)
create table Hang
(
	MaHang varchar(10) primary key,
	TenHang nvarchar(100),
	NhaSX nvarchar(50),
	ROM nvarchar(50),
	RAM nvarchar(50),
	CPU nvarchar(50),
	ManHinh nvarchar(50),
	Pin nvarchar(50),
	Camera nvarchar(50),
	DonGia money,
	SoLuong int,
	MaNCC varchar(10) foreign key references NhaCungCap(MaNCC) on delete cascade on update cascade
)
Create table NhanVien
(
	MaNhanVien varchar(10),
	TenNhanVien nvarchar(100),
	NgaySinh date,
	SDT varchar(11),
	Email varchar(30),
	GioiTinh varchar(10),
	primary key(MaNhanVien),
)
Create table TaiKhoan
(
	MaNhanVien varchar(10),
	MatKhau varchar(50),
	quyen int,
	foreign key(MaNhanVien) references NhanVien(MaNhanVien) on delete cascade on update cascade

)
Create table KhachHang
(
	MaKhachHang varchar(10),
	TenKhachHang nvarchar(100),
	SDT varchar(11),
	NgaySinh date,
	DiaChi nvarchar(50),
	Email varchar(50),
	primary key (MaKhachHang)
)
Create table HoaDon
(
	SoHoaDon int,
	MaKhachHang varchar(10),
	MaNhanVien varchar(10),
	diaChi nvarchar(50),
	SDT varchar(11),
	TrangThai nvarchar(30),
	ngaytao date,
	primary key (SoHoaDon),
	foreign key(MaKhachHang) references KhachHang(MaKhachHang) on delete cascade on update cascade,
	foreign key(MaNhanVien) references NhanVien(MaNhanVien) on delete cascade on update cascade
)
Create table ChiTietHoaDon
(
	Id int primary key,
	MaHang varchar(10),
	SoHoaDon int,
	soluong int,
	giaMua Decimal,
	ngayDat date,
	foreign key(MaHang) references Hang(MaHang) on delete cascade on update cascade,
	foreign key(SoHoaDon) references HoaDon(SoHoaDon) on delete cascade on update cascade
)