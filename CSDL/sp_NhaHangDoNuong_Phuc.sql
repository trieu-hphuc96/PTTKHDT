use NhaHangDoNuong

----------------------------------------------------------------------------------------------
go
--Lấy danh sách nguyên liệu
drop proc sp_LoadIngredients

go
create proc sp_LoadIngredients
as
	select * from NguyenLieu

----------------------------------------------------------------------------------------------
go
--Tìm kiếm nguyên liệu
drop proc sp_SearchIngredients

go
create proc sp_SearchIngredients
			@keyword nvarchar(50)
as
	select distinct *
	from nguyenlieu
	where MANL like '%'+@keyword+'%' or TENNL like '%'+@keyword+'%' or donvi like '%'+@keyword+'%' or hsd like '%'+@keyword+'%'
----------------------------------------------------------------------------------------------
go
--Tạo phiếu kiểm hàng
drop proc sp_CreateInventoryList

go
create proc sp_CreateInventoryList
			@manv int,
			@ngaygio datetime,
			@maphieu int out
as
	declare @table table(maphieu int)
	insert into PhieuKiem
	output inserted.MaPhieu into @table
	values (@manv,@ngaygio)
	select @maphieu = maphieu from @table
----------------------------------------------------------------------------------------------
go
--Thêm chi tiết phiếu kiểm
drop proc sp_AddInventoryListDetails

go
create proc sp_AddInventoryListDetails
			@maphieu int,
			@manl int,
			@gia int,
			@sltonlt decimal(7,3),
			@sltontt decimal(7,3),
			@slhu decimal(7,3)
as
	--cập nhật số lượng thực tế của nguyên liệu
	update NguyenLieu 
	set SoLuong=@sltontt
	where MaNL=@manl

	--cập nhật số lượng tồn lý thuyết
	declare @ngaytaophieukiem date
	select @ngaytaophieukiem = ngaygio from PhieuKiem where MaPhieu = @maphieu
	declare @slban_homnay float
	select @slban_homnay=sum(LUONG*SOLUONG)
	from HOADON hd, CT_HoaDon hd_ct,CONGTHUC ct
	where hd.Ngay >= @ngaytaophieukiem and hd.Ngay < dateadd(day,1,@ngaytaophieukiem) and hd.MAHD = hd_ct.MAHD and hd_ct.MaSP= ct.MaSP
	and ct.MANL=@manl
	if(@slban_homnay IS NULL) 
		set @slban_homnay=0
	set @sltonlt = @sltonlt - @slban_homnay

	--thêm chi tiết phiếu kiểm
	insert into CT_PhieuKiem values (@maphieu,@manl,@gia,@sltonlt,@sltontt,@slhu)
----------------------------------------------------------------------------------------------
go
--Tìm kiếm phiếu kiểm theo mã
drop proc sp_SearchInventoryList_byNumber

go
create proc sp_SearchInventoryList_byNumber
			@ma nvarchar(50)
as
	select distinct pk.*, nv.TenNV
	from PhieuKiem pk, NhanVien nv
	where (MaPhieu like '%'+@ma+'%' or
		nv.MaNV like '%'+@ma+'%'or 
		nv.TenNV like '%'+@ma+'%') and
		pk.MaNV = nv.MaNV

----------------------------------------------------------------------------------------------
go
--Tìm kiếm phiếu kiểm theo ngày
drop proc sp_SearchInventoryList_byDate

go
create proc sp_SearchInventoryList_byDate
			@tungay date,
			@denngay date
as
	select distinct pk.*, nv.TenNV
	from PhieuKiem pk, NhanVien nv
	where NgayGio >= @tungay and NgayGio < dateadd(day,1,@denngay) and pk.MaNV = nv.MaNV
----------------------------------------------------------------------------------------------
go
--Lấy phiếu kiểm
drop proc sp_LoadInventoryList

go
create proc sp_LoadInventoryList
as
	select distinct pk.*, nv.TenNV
	from PhieuKiem pk, NhanVien nv
	where pk.MaNV = nv.MaNV
----------------------------------------------------------------------------------------------
go
--Load phiếu kiểm chi tiết
drop proc sp_LoadInventoryListDetails

go
create proc sp_LoadInventoryListDetails
			@maphieu int
as
	select ctpk.*, ctpk.SLTonLT- (ctpk.SLTonTT + ctpk.SLHu) as SL_HAOHUT, nl.TENNL, nl.DonVi, tongtien_haohut
	from CT_PhieuKiem ctpk, NGUYENLIEU nl, (select sum((ctpk.SLTonLT- (ctpk.SLTonTT + ctpk.SLHu))*nl.GIA) as tongtien_haohut
												from  CT_PhieuKiem ctpk, NGUYENLIEU nl
												where ctpk.MaPhieu=@maphieu and ctpk.MANL=nl.MANL) as tt_hh
	where ctpk.MaPhieu=@maphieu and ctpk.MANL=nl.MANL

	exec sp_LoadInventoryListDetails 8
----------------------------------------------------------------------------------------------
go
--Tạo phiếu nhập hàng
drop proc sp_CreateGoodsReceipt

go
create proc sp_CreateGoodsReceipt
			@maphieudat int,
			@manv int,
			@ngaygio datetime,
			@maphieu int out
as
	declare @table table(maphieu int)
	insert into PhieuNhap
	output inserted.MaPhieu into @table
	values
	(@maphieudat,@manv,@ngaygio)
	select @maphieu=MaPhieu from @table

	update PhieuDat
	set TinhTrang = 1
	where MaPhieu = @maphieudat
----------------------------------------------------------------------------------------------
go
--Thêm chi tiết phiếu nhập
drop proc sp_AddGoodsReceiptDetails

go
create proc sp_AddGoodsReceiptDetails
			@maphieu int,
			@manl int,
			@nhacc int,
			@gianhap int,
			@soluongnhap decimal(7,3),
			@soluongtra decimal(7,3),
			@lydo nvarchar(100)
as
	insert into CT_PhieuNhap
	values (@maphieu,@manl,@nhacc,@gianhap,@soluongnhap,@soluongtra,@lydo)

	--cập nhật số lượng trong nguyên liệu
	update NguyenLieu
	set SoLuong = SoLuong + @soluongnhap
	where MaNL=@manl

	--cập nhật số lượng nhập trong chi tiết phiếu đặt
	declare @maphieudat int
	select @maphieudat=MaPhieuDat from PhieuNhap where MaPhieu = @maphieu
	update CT_PhieuDat
	set SoLuongDaNhap += @soluongnhap
	where MaPhieu = @maphieudat and MaNL = @manl

	--cập nhật tình trạng phiếu đặt
	if(exists(select SoLuongDat,SoLuongDaNhap from CT_PhieuDat where MaPhieu=@maphieudat and SoLuongDat!=SoLuongDaNhap))
		begin
			update PhieuDat
			set TinhTrang = 1
			where MaPhieu=@maphieudat
		end
	else
		begin
			update PhieuDat
			set TinhTrang = 2
			where MaPhieu=@maphieudat
		end
----------------------------------------------------------------------------------------------
go
--Tìm kiếm phiếu nhập theo mã
drop proc sp_SearchGoodsReceipt_byNumber

go
create proc sp_SearchGoodsReceipt_byNumber
			@ma nvarchar(50)
as
	select distinct pn.*,nv.TenNV
	from PhieuNhap pn, NhanVien nv
	where (MaPhieu like '%'+@ma+'%' or 
		pn.MaNV like '%'+@ma+'%' or 
		nv.TenNV like '%'+@ma+'%') and 
		pn.MaNV = nv.MaNV

----------------------------------------------------------------------------------------------
go
--Tìm kiếm phiếu nhập theo ngày
drop proc sp_SearchGoodsReceipt_byDate

go
create proc sp_SearchGoodsReceipt_byDate
			@tungay date,
			@denngay date
as
	select pn.*,nv.TenNV
	from PhieuNhap pn, NhanVien nv
	where NgayGio >= @tungay and NgayGio < dateadd(day,1,@denngay) and pn.MaNV = nv.MaNV
----------------------------------------------------------------------------------------------
go
--Lấy phiếu nhập
drop proc sp_LoadGoodsReceipt

go
create proc sp_LoadGoodsReceipt
as
	select pn.*,nv.TenNV
	from PhieuNhap pn, NhanVien nv 
	where pn.MaNV = nv.MaNV
----------------------------------------------------------------------------------------------
go
--Lấy chi tiết phiếu nhập
drop proc sp_LoadGoodsReceiptDetails

go
create proc sp_LoadGoodsReceiptDetails
			@maphieu int
as
	select ctpn.*, nl.TenNL,nl.DonVi, ncc.TenNCC
	from CT_PhieuNhap ctpn, NguyenLieu nl, NhaCC ncc
	where ctpn.MaNL=nl.MaNL and ctpn.MaPhieu = @maphieu and ctpn.NhaCC=ncc.MaNCC
----------------------------------------------------------------------------------------------
go
--Kiểm tra tên đăng nhập
drop proc sp_CheckUsername

go
create proc sp_CheckUsername
			@tendangnhap char(32),
			@check int out
as
	select * from NhanVien where TenDangNhap=@tendangnhap
	if @@ROWCOUNT > 0
		set @check = 1
	else set @check = 0
----------------------------------------------------------------------------------------------
go
--Kiểm tra đăng nhập
drop proc sp_CheckLogin

go
create proc sp_CheckLogin
			@tendangnhap char(32),
			@matkhau char(32),
			@check int out
as
	select * from NhanVien where TenDangNhap=@tendangnhap and MatKhau=@matkhau
	if @@ROWCOUNT > 0
		set @check = 1
	else set @check = 0
----------------------------------------------------------------------------------------------
go
--Tạo phiếu đặt hàng
drop proc sp_CreateAOrder

go
create proc sp_CreateAOrder
			@manv int,
			@ngaydat datetime,
			@ngaygiao datetime,
			@tinhtrang int,
			@maphieu int out
as
	declare @table table(maphieu int)
	insert into PhieuDat
	output inserted.MaPhieu into @table
	values
	(@manv,@ngaydat,@ngaygiao,@tinhtrang)
	select @maphieu=MaPhieu from @table
----------------------------------------------------------------------------------------------
go
--Thêm chi tiết phiếu đặt
drop proc sp_AddOrderDetails

go
create proc sp_AddOrderDetails
			@maphieu int,
			@manl int,
			@soluongdat decimal(7,3)
as
	insert into CT_PhieuDat
	values (@maphieu,@manl,@soluongdat,0)

----------------------------------------------------------------------------------------------
go
--Huỷ phiếu đặt hàng
drop proc sp_CancelAOrder

go
create proc sp_CancelAOrder
			@maphieu int 
as
	update PhieuDat
	set TinhTrang = 2
	where MaPhieu = @maphieu
----------------------------------------------------------------------------------------------
go
--Tìm kiếm phiếu đặt theo mã
drop proc sp_SearchOrder_byNumber

go
create proc sp_SearchOrder_byNumber
			@ma nvarchar(50)
as
	select distinct pd.*,nv.TenNV
	from PhieuDat pd, NhanVien nv
	where (pd.MaPhieu like '%'+@ma+'%' or 
		pd.MaNV like '%'+@ma+'%' or 
		nv.TenNV like '%'+@ma+'%')
		and pd.MaNV = nv.MaNV

----------------------------------------------------------------------------------------------
go
--Tìm kiếm phiếu đặt theo ngày
drop proc sp_SearchOrder_byDate

go
create proc sp_SearchOrder_byDate
			@tungay date,
			@denngay date
as
	select distinct pd.*,nv.TenNV
	from PhieuDat pd, NhanVien nv
	where pd.NgayDat >= @tungay and pd.NgayDat < dateadd(day,1,@denngay) and pd.MaNV = nv.MaNV

----------------------------------------------------------------------------------------------
go
--Lấy phiếu đặt
drop proc sp_LoadOrder

go
create proc sp_LoadOrder
as
	select pd.*,nv.TenNV
	from PhieuDat pd, NhanVien nv
	where pd.MaNV = nv.MaNV
----------------------------------------------------------------------------------------------
go
--Lấy chi tiết phiếu đặt
drop proc sp_LoadOrderDetails

go
create proc sp_LoadOrderDetails
			@maphieu int
as
	select ctpd.*, nl.TenNL,nl.DonVi,nl.Gia
	from CT_PhieuDat ctpd, NguyenLieu nl
	where ctpd.MaNL=nl.MaNL and ctpd.MaPhieu = @maphieu

--exec sp_LoadOrderDetails 1013
----------------------------------------------------------------------------------------------
go
--Lấy thông tin nhà cung cấp
drop proc sp_LoadSupplier

go
create proc sp_LoadSupplier
as
	select MaNCC,TenNCC
	from NhaCC