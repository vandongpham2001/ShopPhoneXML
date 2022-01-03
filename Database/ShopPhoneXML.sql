create table DanhMuc
(
	Id int identity(1,1) primary key,
	TenDanhMuc nvarchar(50),
	TrangThai nvarchar(50)
)
create table SanPham
(
	Id int identity(1,1) primary key,
	TenSanPham nvarchar(100),
	NhaSX nvarchar(50),
	ROM nvarchar(50),
	RAM nvarchar(50),
	CPU nvarchar(50),
	ManHinh nvarchar(50),
	Pin nvarchar(50),
	Camera nvarchar(50),
	Mau nvarchar(20),
	DonGia money,
	SoLuong int,
	MoTa nvarchar(max),
	ThoiGianBaoHanh int,
	TrangThai nvarchar(50), 
	IdDanhMuc int foreign key references DanhMuc(Id)
)
/*create table ChiTietSanPham
(
	Id int identity(1,1) primary key,
	ROM nvarchar(50),
	RAM nvarchar(50),
	CPU nvarchar(50),
	ManHinh nvarchar(50),
	Pin nvarchar(50),
	Camera nvarchar(50),
	Mau nvarchar(20),
	DonGia money,
	SoLuong int,
	MoTa nvarchar(max),
	IdSanPham int foreign key references SanPham(Id)
)*/
Create table NhanVien
(
	id int identity(1,1),
	username varchar(50),
	password varchar(50),
	HoTen nvarchar(100),
	SDT varchar(11),
	GioiTinh int,
	Email varchar(30),
	ngaySinh date,
	TrangThai nvarchar(50),
	primary key(id),
)
Create table KhachHang
(
	id int identity(1,1) ,
	Hoten nvarchar(100),
	SDT varchar(11),
	ngaySinh date,
	diaChi nvarchar(50),
	email varchar(50),
	primary key (id)
)
Create table DonHang
(
	id int identity(1,1),
	idKhachHang int,
	idNhanVien int,
	diaChi nvarchar(50),
	SDT varchar(11),
	TrangThai nvarchar(30),
	ngaytao date,
	primary key (id),
	foreign key(idKhachHang) references KhachHang(id),
	foreign key(idNhanVien) references NhanVien(id)
)
Create table ChiTietDonHang
(
	idSanPham int,
	idDonHang int,
	soluong int,
	giaMua Decimal,
	ngayDat date,
	primary key(idSanPham, idDonHang),
	foreign key(idSanPham) references SanPham(id),
	foreign key(idDonHang) references DonHang(id)
)