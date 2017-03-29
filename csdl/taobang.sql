create table NhanVien(
MaNV char(10) not null,
TenNV nvarchar(50),
ChucVu nvarchar(50),
Gioitinh nvarchar(3) check(Gioitinh in('Nam',N'Nữ')),
DiaChi nvarchar(50),
SDT char(15),
constraint NV_MANV_PK primary key(MaNV)
)
go
create table HangHoa(
MaHH char(15) not null,
TenHH nvarchar(50),
ChungLoai nvarchar(30),
DonViTinh nvarchar(10),
TrongLuong int,
GiaBan float,
NoiSX nvarchar(5),
HSD date,
constraint HH_MAHH_PK primary key(MaHH)
)
go
create table HoaDon(
MaHD char(10) not null,
MaNV char(10),
MaKH char(10),
Ngaylap datetime,
VAT float,
Tongtien float,
constraint HD_MaHD_Pk primary key(MaHD),
constraint HD_NV_FK foreign key(manv) references NhanVien(manv),
constraint HD_KH_FK foreign key(makh) references KhachHang(makh)
)
go
create table ChitietHoaDon(
MactHD char(10) not null,
MaHD char(10),
MaHH char(15),
Dongia float,
soluong int,
Tien float,
constraint CTHD_MACTHD_PK primary key(MactHD),
constraint CTHD_HD_FK foreign key(MaHD) references HoaDon(MaHD),
constraint CTHD_HH_FK foreign key(MaHH) references HangHoa(MaHH)
)
go
create table KhachHang(
 MaKh char(10) not null,
 TenKH nvarchar(50),
 Diachi nvarchar(50),
 GioiTinh nvarchar(3) check (GioiTinh in('Nam',N'Nữ')),
 SDT char(15),
 diem  int,
 constraint KH_MaKH_PK primary key(MaKH)
)
go
create table KhoHang(
MaKho char(10) not null,
TenKho nvarchar(50),
MaThuKho char(10),
DiaChi nvarchar(30),
constraint KH_MaKho_PK primary key(MaKho),
constraint KH_NV_FK foreign key(MaThuKho) references NhanVien(MaNV)
)
go
create table PhieuNhap(
MaPN char(10) not null,
MaThuKho char(10),
MaKho char(10),
Ngaylap datetime,
VAT float,
Tongtien money,
constraint PN_MaPN_PK primary key(MaPN),
constraint PN_KH_FK foreign key(MaKho) references KhoHang(MaKho)
constraint PN_NV_FK foreign key(mathukho) references nhanvien(manv)
)
go
create table ChitietNhap(
Mactn char(10) not null,
MaPN char(10),
MaHH char(15),
Soluong int,
Dongia float,
Tien float,
constraint CTN_MACTN_Pk primary key(Mactn),
constraint CTN_HH_FK foreign key(MaHH) references HangHoa(MaHH),
constraint CTN_PN_FK foreign key(MaPN) references PhieuNhap(MaPN)
)

