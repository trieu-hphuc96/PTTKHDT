use NhaHangDoNuong

----------------------------------------------------------------------------------------------
go
--Lấy danh sách nguyên liệu
create proc sp_LoadIngredient
as
	select * from NguyenLieu

----------------------------------------------------------------------------------------------
go
--Tìm kiếm nguyên liệu
create proc sp_SearchIngredient
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
--Tìm kiếm thống kê kho theo mã
--drop proc sp_SearchInventoryList_byNumber
create proc sp_SearchInventoryList_byNumber
			@ma nvarchar(50)
as
	select distinct *
	from PhieuKiem
	where MaPhieu like '%'+@ma+'%' or MaNV like '%'+@ma+'%'

----------------------------------------------------------------------------------------------
--Tìm kiếm thống kê kho theo ngày
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
--Tìm kiếm thống kê kho theo ngày
--drop proc sp_LoadInventoryList
create proc sp_LoadInventoryList
as
	select *
	from PhieuKiem
----------------------------------------------------------------------------------------------
go
--Load thống kê kho chi tiết
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