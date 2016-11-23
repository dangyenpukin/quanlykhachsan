create database quanlykhachsan
use quanlykhachsan

create table NhanVien(
MaNV int  NOT NULL ,
TenNV nvarchar(30),
NgaySinh date,
GT nvarchar(3) check(GT in (N'Nam',N'Nữ')),
Luong int,
QuocTich nvarchar(50),
DiaChi nvarchar(100),
SDT int,
SoCMND int,
MaDV int,
primary key(MaNV) 
)

create table KhachHang(
MaKH int NOT NULL ,
TenKH nvarchar(30),
NgaySinh date,
GT nvarchar(3) check (GT in (N'Nam',N'Nữ')),
SDT int,
SoCMND int,
DiaChi nvarchar(100),
NgheNghiep nvarchar(100),
QuocTich nvarchar(50),
primary key(MaKH)
)

create table DichVu(
MaDV int NOT NULL ,
TenDV nvarchar(30),
Gia int,
MaNQL int,
primary key(MaDV)
)

create table ChiTiet_DichVu(
MaCTDV int NOT NULL ,
MaDV int,
MaPT int,
SoPhong int,
NgaySuDung date,
Gia int,---không phải dữ liệu nhập mà update từ dịch vụ qua
primary key(MaCTDV)
)

create table HoaDon(
MaHD int NOT NULL ,
MaNV int,
NgayLap date,
MaPT int unique,
NgayDen date,---update từ phiếu thuê
MaKH int, ---uodate từ phiếu thuê
TongSoPhong int,---tính từ chi tiết hóa đơn
TongTienDV int,---tính từ các bảng
TongTienPhong int,---tính từ các bảng
TongTien int,---không phải dữ liệu nhập mà là tính dựa vào các bảng
primary key(MaHD)
)

create table ChiTiet_HoaDon(
MaCTHD int NOT NULL ,
MaNV int,
NgayLap date,
MaPT int,
SoPhong int,
--MaKH int ,---dữ liệu update từ Chi tiết phiếu thuê
NgayDen date,---không phải dữ liệu để insert mà update từ  phiếu thuê
NgayDi date,
TongNgay int,---cái tổng ngày không phải dữ liệu để insert mà tự tính ra nhờ dữ liệu trong  bảng
TienPhong int,--tính từ giá phòng
TienDV int,---tính từ bảng dịch vụ
Tien int,--tính từ tiền dv và tiền phòng
primary key(MaCTHD)
)

create table PhieuThue(
MaPT int NOT NULL ,
NgayDK date,
NgayDen date,
MaKH int,
TongSoPhong int, ---update tính sau khi lập chi tiết phiếu thuê
TrangThai nvarchar(30) check(TrangThai in(N'Đã Trả',N'Chưa Trả'))
primary key (MaPT)
)

create table ChiTiet_PhieuThue(
SoPhong int ,
MaPT int,
TienDatCoc int,
--MaKH int,
TrangThai nvarchar(30) check (TrangThai in (N'Đã Trả',N'Chưa Trả')),--trạng thái này để dùng tích mỗi khi phòng được trả
primary key(SoPhong,MaPT)
)
--alter table Phong  ADD CONSTRAINT KT_P CHECK(TrangThai in (N'Đã Trả',N'Chưa Trả',N'Đang Ở'))

create table DangNhap(
Userrr nchar(100) NOT NULL,
Password nchar(50),
PhanQuyen int,
primary key(Userrr)
) 

create table Phong(
SoPhong int NOT NULL ,
LoaiPhong nvarchar(50),
Gia int,
MaNV int,
TrangThai nvarchar(10) check(TrangThai in(N'Trống',N'Đã Thuê',N'Đang Ở')),
primary key (SoPhong)
)
alter table phong alter column  TrangThai  nvarchar(10)
--alter table Phong  ADD CONSTRAINT KT_P CHECK(TrangThai in (N'Trống',N'Đã Thuê',N'Đang Ở'))
select * from ChiTiet_DichVu
-- thêm dữ liệu vào các bảng nhân viên , dịch vụ,  phòng  , rồi mới chạy các ràng buộc
alter table NhanVien add constraint FK_NV_DV foreign key(MaDV) references DichVu(MaDV)
alter table ChiTiet_DichVu add  constraint FK_CTDV_CTPT foreign key(SoPhong,MaPT) references ChiTiet_PhieuThue(SoPhong,MaPT)
alter table ChiTiet_DichVu add	constraint FK_CTDV_DV foreign key(MaDV) references DichVu(MaDV)					      
alter table ChiTiet_HoaDon add constraint FK_CTHD_CTPT foreign key(SoPhong,MaPT) references ChiTiet_phieuThue(SoPhong,MaPT)
alter table ChiTiet_HoaDon add constraint FK_CTHD_NV foreign key(MaNV) references NhanVien(MaNV)
alter table Phong add constraint FK_Phong_NV foreign key(MaNV) references NhanVien(MaNV)
alter table ChiTiet_PhieuThue add constraint FK_CTPT_Phong foreign key(SoPhong) references Phong(SoPhong),
						          constraint FK_CTPT_PT foreign key(MaPT) references PhieuThue(MaPT)
alter table HoaDon add constraint FK_HD_NV foreign key(MaNV) references NhanVien(MaNV),
					   constraint FK_HD_PT foreign key(MaPT) references PhieuThue(MaPT)
alter table PhieuThue add constraint FK_PT_KH foreign key(MaKH) references KhachHang(MaKH)


select * from ChiTiet_PhieuThue
select * from NhanVien
select * from KhachHang
select * from DichVu
select * from ChiTiet_DichVu
select MaPT from PhieuThue where MaPT not in (select distinct MaPT from ChiTiet_PhieuThue where TrangThai=N'Chưa Trả')
---insert into ChiTiet_DichVu(MaDV,MaPT,SoPhong,NgaySuDung) 
select * from HoaDon
--insert into HoaDon(MaHD,MaNV,NgayLap,MaPT)
select * from ChiTiet_HoaDon
--insert into ChiTiet_HoaDon(MaCTHD,MaNV,NgayLap,NgayDi,MaPT,SoPhong) 
select * from PhieuThue
--insert into PhieuThue(MaPT,NgayDK,NgayDen,MaKH) 
select MaPT from PhieuThue where MaPT not in (select distinct MaPT from ChiTiet_PhieuThue where TrangThai=N'Chưa Trả') 
                                      and MaPT in (select distinct MaPT from ChiTiet_PhieuThue )
select * from Phong
		select MaPT from PhieuThue where MaPT not in (select distinct MaPT from ChiTiet_PhieuThue c,Phong p where c.TrangThai=N'Chưa Trả' and p.SoPhong= c.SoPhong and p.TrangThai=N'Đang Ở')
                                     and MaPT not in (select distinct MaPT from ChiTiet_PhieuThue c,Phong p where c.TrangThai=N'Đã Trả')																						
------------------------------------------tạo các trigger
--tự động update giá của chi tiết dịch vụ 
create trigger UpdateDV_CTDV on ChiTiet_DichVu
for insert,update
as 
if exists (select * from inserted)
begin
update ChiTiet_DichVu
set Gia=(select Gia from DichVu d where ChiTiet_DichVu.MaDV=d.MaDV)
from inserted i
where ChiTiet_DichVu.MaCTDV=i.MaCTDV
end
---tự động tính tổng số phòng,tổng tiền dv,tổng tiền phòng, tổng tiền vao hóa đơn 

create trigger Tinh_HoaDon on HoaDon
for insert,upDate
as
if exists (select * from inserted)
begin
update HoaDon
set NgayDen=(select NgayDen from PhieuThue p where p.MaPT =HoaDon.MaPT)
from inserted i
where HoaDon.MaHD=i.MaHD

update HoaDon
set TongSoPhong=(select count(SoPhong) from ChiTiet_HoaDon c where HoaDon.MaPT=c.MaPT group by c.MaPT)
from inserted i
where HoaDon.MaHD=i.MaHD

update HoaDon
set TongTienPhong=(select sum(TienPhong) from ChiTiet_HoaDon c where HoaDon.MaPT=c.MaPT group by c.MaPT  )
from inserted i
where HoaDon.MaHD=i.MaHD

update HoaDon
set TongTienDV=(select sum(TienDV) from ChiTiet_HoaDon c where HoaDon.MaPT=c.MaPT group by c.MaPT  )
from inserted i
where HoaDon.MaHD=i.MaHD

update HoaDon
set TongTien=HoaDon.TongTienPhong+HoaDon.TongTienDV
from inserted i
where HoaDon.MaHD=i.MaHD

update HoaDon
set MaKH=(select MaKH from PhieuThue p where p.MaPT= HoaDon.MaPT)
from inserted i
where HoaDon.MaHD=i.MaHD

end
---tự động update ngày đến từ phiếu thuê,mã khách hàng từ Chi tiết phiếu thuê, tính tổng ngày, tổng tiền dv, tiền phong, tổng tiền
create trigger Update_CTHD on ChiTiet_HoaDon
for insert,upDate
as
if exists (select * from inserted)
begin
update ChiTiet_HoaDon
set NgayDen=(select NgayDen from PhieuThue p where ChiTiet_HoaDon.MaPT=p.MaPT)
from inserted i
where ChiTiet_HoaDon.MaCTHD=i.MaCTHD

update ChiTiet_HoaDon
set TongNgay= DATEDIFF (day, ChiTiet_HoaDon.NgayDen, ChiTiet_HoaDon.NgayDi) 
from inserted i
where ChiTiet_HoaDon.MaCTHD=i.MaCTHD

update ChiTiet_HoaDon
set TienPhong=ChiTiet_HoaDon.TongNgay*(select Gia from Phong p where p.SoPhong=ChiTiet_HoaDon.SoPhong)
from inserted i
where ChiTiet_HoaDon.MaCTHD=i.MaCTHD

update ChiTiet_HoaDon
set TienDV=(select sum(Gia) from ChiTiet_DichVu c where c.SoPhong=ChiTiet_HoaDon.SoPhong and c.MaPT=ChiTiet_HoaDon.MaPT  group by MaPT,SoPhong)
from inserted i
where ChiTiet_HoaDon.MaCTHD=i.MaCTHD 

update ChiTiet_HoaDon
set TienDV= ISNULL(ChiTiet_HoaDon.TienDV, 0)-- chuyển giá trị null thành giá trị bên cạnh
from inserted i
where ChiTiet_HoaDon.MaCTHD=i.MaCTHD

update ChiTiet_HoaDon
set Tien=ChiTiet_HoaDon.TienPhong+ChiTiet_HoaDon.TienDV
from inserted i
where ChiTiet_HoaDon.MaCTHD=i.MaCTHD 
end


---Xóa chi Tiết Phiếu Thuê
create proc Xoa_CTPT(@SoPhong int,@MaPT int)
as
begin
delete from ChiTiet_PhieuThue
where SoPhong=@SoPhong and MaPT=@MaPT
end

--tự động cập nhật tổng số phòng trong phiếu thuê nếu xóa chi tiết phiếu thuê
create trigger Update_CTPT on ChiTiet_PhieuThue
for delete
as
if exists (select * from deleted)
begin
update PhieuThue
set TongSoPhong=(select count(SoPhong) from ChiTiet_PhieuThue c where c.MaPT=PhieuThue.MaPT group by MaPT)
from deleted d
where PhieuThue.MaPT=d.MaPT
end
--- tính tổng số phòng vào phiếu thuê từ chi tiết phiếu thuê
create proc TinhTongPhong_PT(@MaPT int)
as
begin
update PhieuThue
set TongSoPhong=(select count(SoPhong) from ChiTiet_PhieuThue c where c.MaPT=PhieuThue.MaPT and PhieuThue.MaPT=@MaPT group by MaPT)
end


---
---kiểm tra khi thêm dữ liệu vào khách hàng chỉ nhập số phòng trong số các số phòng trong chi tiết phiếu thuê của phiếu thuê đó

---liệt kê các phòng còn trống
create proc LietKePhongTrong
as
begin
select SoPhong,LoaiPhong,Gia 
from Phong
where TrangThai=N'Trống'
end
---liệt kê các phòng Vip còn trống
create proc LietKePhongVipTrong
as
begin
select SoPhong,LoaiPhong,Gia 
from Phong
where TrangThai=N'Trống' and LoaiPhong='Vip'
end
---
select * from Phong
create proc LietKePhongThuongTrong
as
begin
select SoPhong,LoaiPhong,Gia 
from Phong
where TrangThai=N'Trống' and LoaiPhong=N'Thường'
end
---tính tiền dịch vụ khách đã sử dụng từ ngày này đến ngày kia 
create proc DVSuDung(@NgayDau date,@NgayCuoi date,@TongDV int output)
as
begin
/*declare contro cursor for (select Gia 
						   from ChiTiet_DichVu
						   where NgaySuDung>=@NgayDau and NgaySuDung<=@NgayCuoi)
declare @Gia int
open contro
while @@FETCH_STATUS=0
begin
fetch next from contro into @Gia
select @Tong=@Tong+@Gia
end
close contro
deallocate contro*/
select  @TongDV=Sum(Gia) --c2
from ChiTiet_DichVu
where NgaySuDung>=@NgayDau and NgaySuDung<=@NgayCuoi
end
------tiền dịch vụ đã thu dk(trả hóa đơn xog) từ ngày này đến ngày kia
create proc DoanhThuDV(@NgayDau date,@NgayCuoi date,@DoanhThuDV int output)
as
begin
select @DoanhThuDV=sum(Gia) 
from ChiTiet_DichVu c,HoaDon h 
where c.MaPT=h.MaPT and h.NgayLap<=@NgayCuoi and h.NgayLap>=@NgayDau
end
declare @DV int
exec DoanhThuDV '5/17/2016','5/18/2016',@DV
select @DV
---Doanh thu tiền phòng (đã trả tiền ) từ ngày này đến ngày kia
create proc DoanhThuPhong(@NgayDau date,@NgayCuoi date,@DoanhThuPhong int output)
as
begin
select @DoanhThuPhong=sum(TienPhong) 
from ChiTiet_HoaDon c,HoaDon h
where c.MaPT=h.MaPT and h.NgayLap<=@NgayCuoi and h.NgayLap>=@NgayDau
end
---tính giá dịch vụ của khách j đó từ đầu cho đến 1 ngày nào đó
create proc UocTinhDV(@SoPhong int,@MaPT int,@NgayCuoi date,@Tong int output)
as
begin
/*declare contro cursor for (select Gia 
						   from ChiTiet_DichVu cd
						   where NgaySuDung<=@NgayCuoi and cd.SoPhong=@soPhong and cd.MaPT=@MaPT)

declare @GiaDV int
open contro
while @@FETCH_STATUS=0
begin
fetch next from contro into @GiaDV
set @Tong=@Tong+@GiaDV
end
close contro
deallocate contro*/
select @Tong=Gia 
from ChiTiet_DichVu cd
where NgaySuDung<=@NgayCuoi and cd.SoPhong=@soPhong and cd.MaPT=@MaPT
end
--drop proc UocTinhGia
declare @TienTra int=0
exec UocTinhDV 36418264,'10/1/2016', @TienTra output
select @TienTra
select * from KhachHang

---tính gía phòng từ ngày đầu đến ngày nà đó của khách j đó
create proc UocTinhPhong(@SoPhong int,@MaPT int,@NgayCuoi date , @Tong int output)
as
begin
declare @Gia int
declare @TongNgay int
select @Gia=(select Gia from Phong p where p.SoPhong=@SoPhong)
select @TongNgay=DATEDIFF(day,(select NgayDen from PhieuThue p where  p.MaPT=@MaPT),@NgayCuoi)
select @Tong=@Gia*@TongNgay
end
select * from NhanVien
select @@IDENTITY from NhanVien
SELECT TOP 1 TenTaiKhoan FROM DangNhap ORDER BY TenTaiKhoan DESC
--tự động update tổng số phòng vào phiếu thuê nếu thêm chi tiết phiếu thuê
create trigger UpDate_PT on ChiTiet_PhieuThue
for update , insert
as
if exists (select * from inserted)
begin
update PhieuThue
set TongSoPhong=(select count(SoPhong) from ChiTiet_PhieuThue c where c.MaPT=PhieuThue.MaPT  group by MaPT)
from inserted i,deleted d
where PhieuThue.MaPT=i.MaPT or PhieuThue.MaPT=d.MaPT
end
select * from Phong where TrangThai=N'Trống'
--các dịch vụ mà mã phiếu thuê nào đó đã dùng
create proc DV_Phong (@SoPhong int,@MaPT int)
as
begin
select MaCTDV,c.MaDV,TenDV,c.Gia,NgaySuDung
from ChiTiet_DichVu c,DichVu d
where c.MaPT=@MaPT and c.SoPhong=@SoPhong and c.MaDV=d.MaDV
end
exec DV_Phong 2,1
---các Phiếu Thuê đã được trả hết phòng
create proc PT_Tra
as
begin
select MaPT 
from PhieuThue p
where MaPT not in (select distinct p.MaPT from PhieuThue p,ChiTiet_PhieuThue c where c.MaPT=p.MaPT and c.TrangThai='Chưa Trả' )
end
---in hóa đơn
create view InHoaDon as
select MaHD,TenNV,h.NgayLap,h.MaPT,k1.TenKH,TongSoPhong,TongTienDV,TongTienPhong,TongTien,SoPhong,c.NgayDen,NgayDi,TongNgay,TienPhong,TienDV,Tien
from HoaDon h, ChiTiet_HoaDon c, NhanVien n,KhachHang k1
where
h.MaPT=c.MaPT and h.MaNV=n.MaNV and k1.MaKH=h.MaKH 
select * from InHoaDon
select * from DangNhap
--hàm 
--select convert(varchar,NgaySuDung,103) 
---thông tin thanh số hd, ngaydh,sophong,ngaydi,ngayden,chi tiet dịch vụ theo từng phòng,tổng tiền

select MaHD,NgayLap,NgayDen,TongSoPhong,NgayDen,TongTien,h.MaKH,k.TenKH from HoaDon h,KhachHang k where k.MaKH=h.MaKH

select TienDV,TienPhong,Tien,SoPhong from ChiTiet_HoaDon
create proc CTDV (@MaCTHD int)
as
begin
select * from ChiTiet_DichVu c
 where  c.MaPT=(select MaPT from ChiTiet_HoaDon ch where ch.MaCTHD=@MaCTHD ) and c.SoPhong=(select SoPhong from ChiTiet_HoaDon ch where ch.MaCTHD=@MaCTHD)
end
create proc CTDV_(@MaPT int,@SoPhong int)
as
begin
select * from ChiTiet_DichVu 
 where  MaPT in(select MaPT from ChiTiet_HoaDon) and SoPhong in(select SoPhong from ChiTiet_HoaDon) and SoPhong=@SoPhong and MaPT=@MaPT
end
--đếm số người tham gia theo từng đoàn
select count(SoPhong),MaPT from ChiTiet_PhieuThue  group by MaPT
select count(MaKH),MaPT from ChiTiet_PhieuThue  group by MaPT

create proc CTDV2 (@MaHD int)
as
begin
select * from ChiTiet_DichVu c
 where  c.MaPT=(select MaPT) 
end
----------------
insert into NhanVien values(1,N'Đặng Thị Hải Yến','7/27/1995',N'Nữ',10000000,N'Việt Nam',N'Thái Bình',646,64557,1),
							(2,N'Lê Thị Trang','3/18/1993',N'Nữ',10000000,N'Việt Nam',N'Bình Định',224345,2132,2),
							(3,N'Lê Hoàng Sơn','1/8/1992',N'Nam',10000000,N'Việt Nam',N'Thanh Hóa',67675,908,3),
							(4,N'Vũ Quốc Tuấn','7/7/1995',N'Nam',10000000,N'Việt Nam',N'Thái Bình',5644444,8978,3),
							(5,N'Lê Minh A','7/2/1995',N'Nam',10000000,N'Việt Nam',N'Ninh Bình',797666,3243,1),
							(6,N'Đặng Văn B','6/2/1995',N'Nam',10000000,N'Việt Nam',N'Vũng Tàu',09734365,767,2),
							(7,N'Lê Thị C','7/20/1995',N'Nữ',10000000,N'Việt Nam',N'Hòa Bình',5464567,455,4),
							(8,N'Nguyễn giao Linh','7/21/1995',N'Nữ',10000000,N'Việt Nam',N'Thái Bình',242354,657,6)
							
insert into DichVu values(0,'Giặt là',100000,1),
						 (1,'Ăn uống',100000,3),
						 (2,'Làm đẹp',100000,1),
						 (3,'Bơi',100000,2),
						 (4,'Xông Hơi',100000,1),
						 (5,'Hát',100000,2),
						 (6,'Game giải trí',100000,4)

insert into Phong values(0,'Vip',200000,1,N'Trống'),
						 (1,'Vip',200000,3,N'Trống'),
						 (2,'Vip',200000,1,N'Trống'),
						 (3,'Vip',200000,2,N'Trống'),
						 (4,'Thường',100000,1,N'Trống'),
						 (5,'Thường',100000,2,N'Trống'),
						 (6,'Thường',100000,4,N'Trống')
