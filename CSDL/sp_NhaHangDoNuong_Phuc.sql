use NhaHangDoNuong

----------------------------------------------------------------------------------------------
go
--Lấy danh sách nguyên liệu
--drop proc sp_LoadIngredient
create proc sp_LoadIngredients
as
	select * from NguyenLieu

----------------------------------------------------------------------------------------------
go
--Tìm kiếm nguyên liệu
--drop proc sp_SearchIngredient
create proc sp_SearchIngredients
			@keyword nvarchar(50)
as
	select distinct *
	from nguyenlieu
	where MANL like '%'+@keyword+'%' or TENNL like '%'+@keyword+'%' or donvi like '%'+@keyword+'%' or hsd like '%'+@keyword+'%'
----------------------------------------------------------------------------------------------
go
--Tạo phiếu kiểm hàng
create proc sp_CreateInventoryList
			@manv int,
			@ngaygio datetime,
			@maphieu int out
as
	declare @table table(maphieu int)
	insert into PhieuKiem
	output inserted.MaPhieu into @table
	values (@ngaygio,@manv)
	select @maphieu = maphieu from @table
----------------------------------------------------------------------------------------------
go
--Thêm chi tiết phiếu kiểm
--drop proc sp_AddInventoryListDetails
create proc sp_AddInventoryListDetails
			@maphieu int,
			@manl int,
			@gia int,
			@sltonlt decimal(3),
			@sltontt decimal(3),
			@slhu decimal(3)
as
	insert into CT_PhieuKiem values (@maphieu,@manl,@gia,@sltonlt,@sltontt,@slhu)
	update NguyenLieu 
	set SoLuong=@sltontt
	where MaNL=@manl
----------------------------------------------------------------------------------------------
go
--Tìm kiếm phiếu kiểm theo mã
--drop proc sp_SearchInventoryList_byNumber
create proc sp_SearchInventoryList_byNumber
			@ma nvarchar(50)
as
	select distinct *
	from PhieuKiem
	where MaPhieu like '%'+@ma+'%' or MaNV like '%'+@ma+'%'

----------------------------------------------------------------------------------------------
--Tìm kiếm phiếu kiểm theo ngày
--drop proc sp_SearchInventoryList_byDate
create proc sp_SearchInventoryList_byDate
			@tungay date,
			@denngay date
as
	select *
	from PhieuKiem
	where NgayGio >= @tungay and NgayGio < dateadd(day,1,@denngay)
----------------------------------------------------------------------------------------------
go
--Lấy phiếu kiểm
--drop proc sp_LoadInventoryList
create proc sp_LoadInventoryList
as
	select *
	from PhieuKiem
----------------------------------------------------------------------------------------------
go
--Load phiếu kiểm chi tiết
--drop proc sp_LoadInventoryListDetails
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
create proc sp_CreateGoodsReceipt
			@manv int,
			@ngaygio datetime,
			@maphieu int out
as
	declare @table table(maphieu int)
	insert into PhieuNhap
	output inserted.MaPhieu into @table
	values
	(@ngaygio,@manv)
	select @maphieu=MaPhieu from @table
----------------------------------------------------------------------------------------------
go
--Thêm chi tiết phiếu nhập
--drop proc sp_AddGoodsReceipt
create proc sp_AddGoodsReceiptDetails
			@maphieu int,
			@manl int,
			@nhacc nvarchar(50),
			@gianhap int,
			@soluong decimal
as
	insert into CT_PhieuNhap
	values (@maphieu,@manl,@nhacc,@gianhap,@soluong)
	update NguyenLieu
	set SoLuong = SoLuong + @soluong
	where MaNL=@manl
----------------------------------------------------------------------------------------------
go
--Tìm kiếm phiếu nhập theo mã
create proc sp_SearchGoodsReceipt_byNumber
			@ma nvarchar(50)
as
	select distinct *
	from PhieuKiem
	where MaPhieu like '%'+@ma+'%' or MaNV like '%'+@ma+'%'

----------------------------------------------------------------------------------------------
go
--Tìm kiếm phiếu nhập theo ngày
create proc sp_SearchGoodsReceipt_byDate
			@tungay date,
			@denngay date
as
	select *
	from PhieuNhap
	where NgayGio >= @tungay and NgayGio < dateadd(day,1,@denngay)
----------------------------------------------------------------------------------------------
go
--Lấy phiếu nhập
create proc sp_LoadGoodsReceipt
as
	select *
	from PhieuNhap
----------------------------------------------------------------------------------------------
go
--Lấy chi tiết phiếu nhập
--drop proc sp_LoadGoodsReceiptDetails
create proc sp_LoadGoodsReceiptDetails
			@maphieu int
as
	select ctpn.*, nl.TenNL,nl.DonVi
	from CT_PhieuNhap ctpn, NguyenLieu nl
	where ctpn.MaNL=nl.MaNL and ctpn.MaPhieu = @maphieu
----------------------------------------------------------------------------------------------
go
--Kiểm tra tên đăng nhập
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
create proc sp_CheckLogin
			@tendangnhap char(32),
			@matkhau char(32),
			@check int out
as
	select * from NhanVien where TenDangNhap=@tendangnhap and MatKhau=@matkhau
	if @@ROWCOUNT > 0
		set @check = 1
	else set @check = 0