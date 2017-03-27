ngcreate proc get_NV
as 
begin
select MaNV as [Mã NV], TenNV as[Tên NV],ChucVu as [Chức vụ],Gioitinh as [Giới tính],DiaChi as [Địa Chỉ],SDT  from NhanVien
end
go
create proc get_kh
as
begin
select MaKh as [Mã Khách hàng],TenKH as [Tên Khách hàng],Diachi as[Địa chỉ],GioiTinh as [Giới tính],SDT ,diem as [Điểm] from KhachHang
end
go
create proc get_pn
as begin
select MaPN as[Mã PN],TenKho as [Tên Kho],TenNV as[Tên Thủ Kho],Ngaylap as[Ngày Lập],
VAT as [VAT (%)],Tongtien as [Tổng Tiền ] from PhieuNhap,NhanVien,KhoHang
where PhieuNhap.MaKho=KhoHang.MaKho and PhieuNhap.MaThuKho=NhanVien.MaNV
end
go

select mapn from PhieuNhap,NhanVien where PhieuNhap.MaThuKho=NhanVien.MaNV
create proc get_ctn(@ma char(10))
as begin
select Mactn as[Mã CTN],TenHH as[Tên HH],Soluong as [SL],Dongia as[Gia] ,Tien as[Tiền] from ChitietNhap,HangHoa
where HangHoa.MaHH=ChitietNhap.MaHH and MaPN=@ma
end
go
create proc get_Kho
as
begin
select MaKho as[Mã Kho], TenKho as[Tên Kho],TenNV as[Tên Thủ Kho],KhoHang.DiaChi as[Địa chỉ] from KhoHang,NhanVien
where NhanVien.MaNV=KhoHang.MaThuKho
end
go
create proc get_HH
as begin
select MaHH as[Mã Hàng Hóa],TenHH as[Tên Hàng Hóa],ChungLoai as[Chủng Loại],DonViTinh as[Đơn vị tính],trongluong as [Trọng Lượng],
GiaBan as[Giá Bán],NoiSX as[ Nơi SX],HSD as[Hạn sử dụng] from HangHoa
end
go
create proc get_HH1(@ma char(15))
as begin
select MaHH as[Mã Hàng Hóa],TenHH as[Tên Hàng Hóa],ChungLoai as[Chủng Loại],DonViTinh as[Đơn vị tính],trongluong as [Trọng Lượng],
GiaBan as[Giá Bán],NoiSX as[ Nơi SX],HSD as[Hạn sử dụng] from HangHoa where MaHH=@ma
end
--hóa đơn
go
alter proc get_hoadon
as
begin

select MaHD as[Mã Hóa đơn],TenNV as[Tên NV],MaKH as[Mã KH],Ngaylap as[Ngày Lập],cast((VAT*100)as int) as[Thuế VAT(%)],cast(Tongtien as int) as[Tổng tiền] from HoaDon,NhanVien
where NhanVien.MaNV=HoaDon.MaNV
end
go
alter proc get_cthd(@ma char(10))
as
begin
select MactHD as[Mã CTHD],TenHH as[Tên HH],cast(Dongia as int) as[Đơn giá],soluong as[Số Lượng],DonViTinh  as[DVT],cast(Tien as int) as[Tiền] from ChitietHoaDon,HangHoa
where ChitietHoaDon.MaHH=HangHoa.MaHH and MaHD=@ma
end
go
--get_cthd 'hd001'
alter proc them_hoadon(@mahd char(10),@manv char(10),@makh char(10),@ngaylap datetime,@vat float)
as 
begin
if exists(select MaKH from HoaDon where MaHD=@mahd) print('khong them duoc')
else
insert into HoaDon(MaHD,MaNV,MaKH,Ngaylap,VAT) values(@mahd,@manv,@makh,@ngaylap,@vat)
end
go
create proc xoa_hoadon(@ma char(10))
as
begin
delete HoaDon
where MaHD=@ma
delete ChitietHoaDon
where MaHD=@ma
end
go
alter proc sua_hoadon(@mahd char(10),@manv char(10),@makh char(10),@ngaylap datetime,@vat float)
as
begin
update HoaDon
set MaNV=@manv,
    MaKH=@makh,
	Ngaylap=@ngaylap,
	VAT=@vat
where MaHD=@mahd
end
go
create proc luu_tien(@mahd char(10),@tongtien float)
as begin
update HoaDon
set Tongtien=@tongtien
where MaHD=@mahd
end
go
--Chi tiet hoa don
create proc them_cthd(@macthd char(10),@mahd char(10),@mahh char(15),@dongia float,@sl int,@tien float)
as 
begin
if exists(select macthd from ChitietHoaDon where MactHD=@macthd) print('khong them duoc')
else
insert into ChitietHoaDon values(@macthd,@mahd,@mahh,@dongia,@sl,@tien)
end
go
alter proc sua_cthd(@macthd char(10),@mahh char(15),@dongia float,@sl int,@tien float)
as begin
update ChitietHoaDon
set MaHH=@mahh,
    Dongia =@dongia,
	soluong=@sl,
	Tien=@tien
	where MactHD=@macthd
end
go
create proc xoa_cthd(@macthd char(10))
as begin
delete ChitietHoaDon where MactHD=@macthd
end
go
update HoaDon set Tongtien=0
go
update ChitietHoaDon set Tien=0
go
update ChitietHoaDon
set Dongia=(select GiaBan from HangHoa where HangHoa.MaHH=ChitietHoaDon.MaHH)
go

