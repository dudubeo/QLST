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
cast((VAT*100)as int) as[Thuế VAT(%)],cast(Tongtien as int) as[Tổng tiền] from PhieuNhap,NhanVien,KhoHang
where PhieuNhap.MaKho=KhoHang.MaKho and PhieuNhap.MaThuKho=NhanVien.MaNV
end
go

select mapn from PhieuNhap,NhanVien where PhieuNhap.MaThuKho=NhanVien.MaNV
alter proc get_ctn(@ma char(10))
as begin
select Mactn as[Mã CTN],TenHH as[Tên HH],chitietnhap.Soluong as [SL],Dongia as[Gia] ,Tien as[Tiền] from ChitietNhap,HangHoa
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
create proc get_cthd(@ma char(10))
as
begin
select MactHD as[Mã CTHD],TenHH as[Tên HH],cast(Dongia as int) as[Đơn giá],ChitietHoaDon.soluong as[Số Lượng],DonViTinh  as[DVT],cast(Tien as int) as[Tiền] from ChitietHoaDon,HangHoa
where ChitietHoaDon.MaHH=HangHoa.MaHH and MaHD=@ma
end
go
get_cthd 'hd001'
alter proc them_hoadon(@mahd char(10),@manv char(10),@makh char(10),@ngaylap datetime,@vat float,@tongtien float)
as 
begin
if exists(select MaKH from HoaDon where MaHD=@mahd) print('khong them duoc')
else
insert into HoaDon(MaHD,MaNV,MaKH,Ngaylap,VAT,Tongtien) values(@mahd,@manv,@makh,@ngaylap,@vat,@tongtien )
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
update ChitietNhap set Dongia=0
go
update ChitietNhap
set Dongia=(select cast((GiaBan-GiaBan*0.2)as int) from HangHoa where HangHoa.MaHH=ChitietNhap.MaHH)
go
update HangHoa
set soluong=100
go
alter trigger update_sl on Chitiethoadon for update,delete,insert as
begin
declare @macthd1 char(10),@macthd2 char(10),@sl1 int,@sl2 int,@mahh1 char(15),@mahh2 char(15)
select @macthd1=macthd from inserted
select @sl1=soluong,@mahh1=MaHH from ChitietHoaDon where MactHD=@macthd1
select @macthd2=macthd from deleted
select @sl2=soluong,@mahh2=MaHH from ChitietHoaDon where MactHD=@macthd2
update HangHoa
set soluong=soluong-@sl1
where MaHH=@mahh1
update HangHoa
set soluong =soluong+@sl2
where MaHH=@mahh2
  end
  go
alter trigger update_sl1 on chitiethoadon for update as
 begin
if update(soluong)
    update HangHoa
set hanghoa.soluong=HangHoa.soluong-  (inserted.soluong-deleted.soluong)
    FROM inserted,deleted
    WHERE inserted.MaHH = HangHoa.MaHH 
	end
go
create trigger update_sl2 on chitietnhap for update as
 begin
if update(soluong)
    update HangHoa
set hanghoa.soluong=HangHoa.soluong+ (inserted.soluong-deleted.soluong)
    FROM inserted,deleted
    WHERE inserted.MaHH = HangHoa.MaHH 
	end
go
create trigger update_sl4 on Chitietnhap for update,delete,insert as
begin
declare @mactn1 char(10),@mactn2 char(10),@sl1 int,@sl2 int,@mahh1 char(15),@mahh2 char(15)
select @mactn1=mactn from inserted
select @sl1=soluong,@mahh1=MaHH from ChitietHoaDon where MactHD=@mactn1
select @mactn2=mactn from deleted
select @sl2=soluong,@mahh2=MaHH from ChitietHoaDon where MactHD=@mactn2
update HangHoa
set soluong=soluong+@sl1
where MaHH=@mahh1
update HangHoa
set soluong =soluong-@sl2
where MaHH=@mahh2
  end
  go
update ChitietHoaDon
set soluong =2
go 
update ChitietNhap
set Soluong=2
go
create trigger tongtien on chitiethoadon for update,delete,insert
 as
 begin
declare @macthd1 char(10),@macthd2 char(10),@mahd1 char(10), @mahd2 char(10)
select @macthd1=macthd from inserted
select @mahd1=mahd from ChitietHoaDon  where MactHD=@macthd1
select @macthd2=macthd from deleted
select @mahd2=mahd from ChitietHoaDon  where MactHD=@macthd2

end
go
create trigger tongtien1 on chitiethoadon for update as
 begin
if update(soluong)
    update HoaDon
set Tongtien=(select sum(tien) from ChitietHoaDon where ChitietHoaDon.MaHD=HoaDon.MaHD)
    FROM inserted,deleted
    WHERE inserted.MaHD = HoaDon.MaHD
	end
go
create trigger tongtien3 on chitietnhap for update,delete,insert
 as
 begin
declare @mactn1 char(10),@mactn2 char(10),@mapn1 char(10), @mapn2 char(10)
select @mactn1=mactn from inserted
select @mapn1=MaPN from Chitietnhap  where Mactn=@mactn1
select @mactn2=mactn from deleted
select @mapn2=mapn from Chitietnhap  where Mactn=@mactn2
update PhieuNhap
set Tongtien=(select sum(tien) from ChitietNhap where ChitietNhap.Mapn=PhieuNhap.MaPN)
where MaPN=@mapn1
update PhieuNhap
set Tongtien=(select sum(tien) from ChitietNhap where ChitietNhap.Mapn=PhieuNhap.MaPN)
where MaPN=@mapn2
end
go
create trigger tongtien4 on chitietnhap for update as
 begin
if update(soluong)
    update PhieuNhap
set Tongtien=(select sum(tien) from ChitietHoaDon where ChitietHoaDon.MaHD=PhieuNhap.MaPN)
    FROM inserted,deleted
    WHERE inserted.MaPN = PhieuNhap.MaPN
	end
	go
	update ChitietHoaDon
	set Tien=Dongia*soluong
	go
	update ChitietNhap
	set Tien=Dongia*Soluong
---nhân viên----
create proc them_nv(@manv char(10),@tennv nvarchar(50),@chucvu nvarchar(50),@gt nvarchar(3),@diachi nvarchar(50),@sdt char(15))
as
begin
if exists(select MaNV from NhanVien where Manv=@manv) print('khong them duoc')
else
insert NhanVien values(@manv,@tennv,@chucvu,@gt,@diachi,@sdt)
end
go
create proc sua_nv(@manv char(10),@tennv nvarchar(50),@chucvu nvarchar(50),@gt nvarchar(3),@diachi nvarchar(50),@sdt char(15))
as
begin
update NhanVien
set TenNV=@tennv,
    ChucVu=@chucvu,
	Gioitinh=@gt,
	DiaChi=@diachi,
	SDT=@sdt
	where MaNV=@manv
end
go
create proc xoa_nv(@manv char(10))
as
begin
delete NhanVien
where MaNV=@manv
end 
go


----Khách hàng
create proc them_kh(@makh char(10),@tenkh nvarchar(50),@diachi nvarchar(50),@gt nvarchar(30),@sdt char(15),@diem int)
as begin
if exists(select MaKh from KhachHang where MaKh=@makh) print('khong them duoc')
else insert KhachHang values(@makh,@tenkh,@diachi,@gt,@sdt,@diem)
end
go
create proc sua_kh(@makh char(10),@tenkh nvarchar(50),@diachi nvarchar(50),@gt nvarchar(30),@sdt char(15),@diem int)
as begin
update KhachHang
set TenKH=@tenkh,
Diachi=@diachi,
GioiTinh=@gt,
SDT=@sdt,
diem=@diachi
where MaKh=@makh
end
go
create proc xoa_kh(@makh char(10))
as begin
delete KhachHang where MaKh=@makh
end
go
---Nhập hàng
---phiếu nhập
create proc them_pn(@mapn char(10),@mathukho char(10),@makho char(10),@ngaylap datetime,@vat float,@tongtien float)
as
begin
if exists(select Mapn from phieunhap where MaPN=@mapn) print('khong them duoc')
else
insert PhieuNhap values(@mapn,@mathukho,@makho,@ngaylap,@vat,@tongtien)
end
go
create proc sua_pn(@mapn char(10),@mathukho char(10),@makho char(10),@ngaylap datetime,@vat float)
as begin
update PhieuNhap
set MaThuKho=@mathukho,
MaKho=@makho,
Ngaylap=@ngaylap,
VAT=@vat
where MaPN=@mapn
end
go
create proc xoa_pn(@mapn char(10))
as begin
delete ChitietNhap where maPN=@mapn
delete PhieuNhap where MaPN=@mapn
end
go
create proc luu_tien_nhap(@mapn char(10),@tongtien float)
as
begin
update PhieuNhap
set Tongtien=@tongtien
where MaPN=@mapn
end
go
create trigger tt on ChitietNhap for update,insert,delete
as
begin
declare @MAPNCU char(10),@MAPNMOI char(10)
select @MAPNCU=MaPN from deleted
select @MAPNMOI=MaPN from inserted
update PhieuNhap
set Tongtien=(select sum(Tien) from ChitietNhap where MaPN=@MAPNMOI)
where MaPN=@MAPNMOI
update PhieuNhap
set Tongtien=(select sum(Tien) from ChitietNhap where MaPN=@MAPNCU)
where MaPN=@MAPNCU
end
go
---chi tiết nhập
create proc them_ctn(@mactn char(10),@mapn char(10),@mahh char(15),@soluong int,@tien float,@dongia float)
as begin
if exists(select Mactn from ChitietNhap where Mactn=@mactn) print('khong them duoc')
else insert ChitietNhap values(@mactn,@mapn,@mahh,@soluong,@tien,@dongia)
end
go
create proc sua_ctn(@mactn char(10),@mahh char(15),@soluong int,@tien float,@dongia float)
as begin
update ChitietNhap
set MaHH=@mahh,
Soluong=@soluong,
Tien=@tien,
Dongia=@dongia
where Mactn=@mactn
end
go
create proc xoa_ctn(@mactn char(10))
as begin
delete ChitietNhap where Mactn=@mactn
end
<<<<<<< HEAD
----
go
create proc get_HH2(@giaban1 float,@giaban2 float)
as begin
select MaHH as[Mã Hàng Hóa],TenHH as[Tên Hàng Hóa],ChungLoai as[Chủng Loại],DonViTinh as[Đơn vị tính],trongluong as [Trọng Lượng],
GiaBan as[Giá Bán],NoiSX as[ Nơi SX],HSD as[Hạn sử dụng] from HangHoa where GiaBan >@giaban1 and GiaBan<@giaban2
end
------
go
alter proc get_HH3(@chungloai nvarchar(30))
as begin
select MaHH as[Mã Hàng Hóa],TenHH as[Tên Hàng Hóa],ChungLoai as[Chủng Loại],DonViTinh as[Đơn vị tính],trongluong as [Trọng Lượng],
GiaBan as[Giá Bán],NoiSX as[ Nơi SX],HSD as[Hạn sử dụng] from HangHoa where ChungLoai = @chungloai
end
=======



--thong ke hang hoa

create proc tkhh
as
select CTN.MaHH as 'Mã HH',HH.TenHH as'Tên HH',SLBD=100, sum( CTN.Soluong )as 'SL Nhập' ,sum(CTHD.soluong) as 'SL Bán', HH.Soluong as 'SL Còn'
from ChitietNhap CTN, HangHoa HH, ChitietHoaDon CTHD
where CTN.MaHH=HH.MaHH and HH.MaHH=CTHD.MaHH
group by CTN.MaHH, HH.TenHH, HH.Soluong
go
create proc tk_ban
as
select CTHD.MaHH as 'Mã HH', HH.TenHH as'Tên HH', sum(CTHD.soluong) as 'Số Lượng',CTHD.Dongia as 'Đơn Giá', sum(CTHD.Tien) as 'Tiền Thu'
from HoaDon HD, HangHoa HH, ChitietHoaDon CTHD
where HD.MaHD=CTHD.MaHD and CTHD.MaHH=HH.MaHH
group by CTHD.MaHH,HH.TenHH,CTHD.Dongia

go
create proc tk_nhap
as
select CTN.MaHH as 'Mã HH', HH.TenHH as'Tên HH', sum(CTN.Soluong) as 'Số Lượng', CTN.Dongia as 'Đơn Giá',(CTN.Tien) as 'Tiền Trả'
from ChitietNhap CTN, HangHoa HH,PhieuNhap PN
where CTn.MaHH=HH.MaHH and CTN.MaPN=PN.MaPN
group by CTN.MaHH,HH.TenHH, CTN.Dongia,CTN.Tien

>>>>>>> ac83f9ff2f81bc51a61ee2d568dc2b1d2a48ce1c
/*update HangHoa
set Soluong=100
update ChitietHoaDon
set soluong=2
update
ChitietNhap
set Soluong=2
update HoaDon
set Tongtien=(select sum(tien) from ChitietHoaDon where ChitietHoaDon.MaHD=HoaDon.MaHD)
update ChitietHoaDon
set Tien=Dongia*soluong
update ChitietNhap
set Tien=Dongia*Soluong
update PhieuNhap
set Tongtien=(select sum(tien) from ChitietNhap where ChitietNhap.MaPN=PhieuNhap.MaPN)*/