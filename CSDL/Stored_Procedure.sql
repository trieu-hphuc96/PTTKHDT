USE [NhaHangDoNuong]
GO
/****** Object:  StoredProcedure [dbo].[sp_UpgradeCustomerToVIP]    Script Date: 09/05/2017 4:26:25 PM ******/
DROP PROCEDURE [dbo].[sp_UpgradeCustomerToVIP]
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdatePoint]    Script Date: 09/05/2017 4:26:25 PM ******/
DROP PROCEDURE [dbo].[sp_UpdatePoint]
GO
/****** Object:  StoredProcedure [dbo].[sp_StatisticByProduct]    Script Date: 09/05/2017 4:26:25 PM ******/
DROP PROCEDURE [dbo].[sp_StatisticByProduct]
GO
/****** Object:  StoredProcedure [dbo].[sp_StatisticByBill]    Script Date: 09/05/2017 4:26:25 PM ******/
DROP PROCEDURE [dbo].[sp_StatisticByBill]
GO
/****** Object:  StoredProcedure [dbo].[sp_SearchOrder_byNumber]    Script Date: 09/05/2017 4:26:25 PM ******/
DROP PROCEDURE [dbo].[sp_SearchOrder_byNumber]
GO
/****** Object:  StoredProcedure [dbo].[sp_SearchOrder_byDate]    Script Date: 09/05/2017 4:26:25 PM ******/
DROP PROCEDURE [dbo].[sp_SearchOrder_byDate]
GO
/****** Object:  StoredProcedure [dbo].[sp_SearchInventoryList_byNumber]    Script Date: 09/05/2017 4:26:25 PM ******/
DROP PROCEDURE [dbo].[sp_SearchInventoryList_byNumber]
GO
/****** Object:  StoredProcedure [dbo].[sp_SearchInventoryList_byDate]    Script Date: 09/05/2017 4:26:25 PM ******/
DROP PROCEDURE [dbo].[sp_SearchInventoryList_byDate]
GO
/****** Object:  StoredProcedure [dbo].[sp_SearchIngredients]    Script Date: 09/05/2017 4:26:25 PM ******/
DROP PROCEDURE [dbo].[sp_SearchIngredients]
GO
/****** Object:  StoredProcedure [dbo].[sp_SearchGoodsReceipt_byNumber]    Script Date: 09/05/2017 4:26:25 PM ******/
DROP PROCEDURE [dbo].[sp_SearchGoodsReceipt_byNumber]
GO
/****** Object:  StoredProcedure [dbo].[sp_SearchGoodsReceipt_byDate]    Script Date: 09/05/2017 4:26:25 PM ******/
DROP PROCEDURE [dbo].[sp_SearchGoodsReceipt_byDate]
GO
/****** Object:  StoredProcedure [dbo].[sp_LoadSupplier]    Script Date: 09/05/2017 4:26:25 PM ******/
DROP PROCEDURE [dbo].[sp_LoadSupplier]
GO
/****** Object:  StoredProcedure [dbo].[sp_LoadOrderDetails]    Script Date: 09/05/2017 4:26:25 PM ******/
DROP PROCEDURE [dbo].[sp_LoadOrderDetails]
GO
/****** Object:  StoredProcedure [dbo].[sp_LoadOrder]    Script Date: 09/05/2017 4:26:25 PM ******/
DROP PROCEDURE [dbo].[sp_LoadOrder]
GO
/****** Object:  StoredProcedure [dbo].[sp_LoadInventoryListDetails]    Script Date: 09/05/2017 4:26:25 PM ******/
DROP PROCEDURE [dbo].[sp_LoadInventoryListDetails]
GO
/****** Object:  StoredProcedure [dbo].[sp_LoadInventoryList]    Script Date: 09/05/2017 4:26:25 PM ******/
DROP PROCEDURE [dbo].[sp_LoadInventoryList]
GO
/****** Object:  StoredProcedure [dbo].[sp_LoadIngredients]    Script Date: 09/05/2017 4:26:25 PM ******/
DROP PROCEDURE [dbo].[sp_LoadIngredients]
GO
/****** Object:  StoredProcedure [dbo].[sp_LoadGoodsReceiptDetails]    Script Date: 09/05/2017 4:26:25 PM ******/
DROP PROCEDURE [dbo].[sp_LoadGoodsReceiptDetails]
GO
/****** Object:  StoredProcedure [dbo].[sp_LoadGoodsReceipt]    Script Date: 09/05/2017 4:26:25 PM ******/
DROP PROCEDURE [dbo].[sp_LoadGoodsReceipt]
GO
/****** Object:  StoredProcedure [dbo].[sp_insertItemsToBill]    Script Date: 09/05/2017 4:26:25 PM ******/
DROP PROCEDURE [dbo].[sp_insertItemsToBill]
GO
/****** Object:  StoredProcedure [dbo].[sp_getBillDetail]    Script Date: 09/05/2017 4:26:25 PM ******/
DROP PROCEDURE [dbo].[sp_getBillDetail]
GO
/****** Object:  StoredProcedure [dbo].[sp_FoodSearch]    Script Date: 09/05/2017 4:26:25 PM ******/
DROP PROCEDURE [dbo].[sp_FoodSearch]
GO
/****** Object:  StoredProcedure [dbo].[sp_CustomerDetail]    Script Date: 09/05/2017 4:26:25 PM ******/
DROP PROCEDURE [dbo].[sp_CustomerDetail]
GO
/****** Object:  StoredProcedure [dbo].[sp_createNewBillInfo]    Script Date: 09/05/2017 4:26:25 PM ******/
DROP PROCEDURE [dbo].[sp_createNewBillInfo]
GO
/****** Object:  StoredProcedure [dbo].[sp_CreateInventoryList]    Script Date: 09/05/2017 4:26:25 PM ******/
DROP PROCEDURE [dbo].[sp_CreateInventoryList]
GO
/****** Object:  StoredProcedure [dbo].[sp_CreateGoodsReceipt]    Script Date: 09/05/2017 4:26:25 PM ******/
DROP PROCEDURE [dbo].[sp_CreateGoodsReceipt]
GO
/****** Object:  StoredProcedure [dbo].[sp_CreateAOrder]    Script Date: 09/05/2017 4:26:25 PM ******/
DROP PROCEDURE [dbo].[sp_CreateAOrder]
GO
/****** Object:  StoredProcedure [dbo].[sp_CheckUsername]    Script Date: 09/05/2017 4:26:25 PM ******/
DROP PROCEDURE [dbo].[sp_CheckUsername]
GO
/****** Object:  StoredProcedure [dbo].[sp_CheckLogin]    Script Date: 09/05/2017 4:26:25 PM ******/
DROP PROCEDURE [dbo].[sp_CheckLogin]
GO
/****** Object:  StoredProcedure [dbo].[sp_CancelAOrder]    Script Date: 09/05/2017 4:26:25 PM ******/
DROP PROCEDURE [dbo].[sp_CancelAOrder]
GO
/****** Object:  StoredProcedure [dbo].[sp_BeverageSearch]    Script Date: 09/05/2017 4:26:25 PM ******/
DROP PROCEDURE [dbo].[sp_BeverageSearch]
GO
/****** Object:  StoredProcedure [dbo].[sp_AddOrderDetails]    Script Date: 09/05/2017 4:26:25 PM ******/
DROP PROCEDURE [dbo].[sp_AddOrderDetails]
GO
/****** Object:  StoredProcedure [dbo].[sp_AddInventoryListDetails]    Script Date: 09/05/2017 4:26:25 PM ******/
DROP PROCEDURE [dbo].[sp_AddInventoryListDetails]
GO
/****** Object:  StoredProcedure [dbo].[sp_AddGoodsReceiptDetails]    Script Date: 09/05/2017 4:26:25 PM ******/
DROP PROCEDURE [dbo].[sp_AddGoodsReceiptDetails]
GO
/****** Object:  StoredProcedure [dbo].[sp_AddGoodsReceiptDetails]    Script Date: 09/05/2017 4:26:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_AddGoodsReceiptDetails]
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
	if(exists(select SoLuongDat,SoLuongDaNhap from CT_PhieuDat where MaPhieu=@maphieudat and SoLuongDat>SoLuongDaNhap))
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

GO
/****** Object:  StoredProcedure [dbo].[sp_AddInventoryListDetails]    Script Date: 09/05/2017 4:26:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_AddInventoryListDetails]
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

GO
/****** Object:  StoredProcedure [dbo].[sp_AddOrderDetails]    Script Date: 09/05/2017 4:26:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_AddOrderDetails]
			@maphieu int,
			@manl int,
			@soluongdat decimal(7,3)
as
	insert into CT_PhieuDat
	values (@maphieu,@manl,@soluongdat,0)

----------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[sp_BeverageSearch]    Script Date: 09/05/2017 4:26:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[sp_BeverageSearch]
	@TenSP nvarchar(50)
as
select MaSP as 'Mã thức uống', TenSP as 'Tên thức uống', Gia as 'Giá', TenLoai 'Loại'
from SanPham sp join LoaiSP l_sp on (sp.MaLoaiSP = l_sp.MaLoai) 
where MaLoaiSP = 1 and TenSP like '%' + @TenSP + '%'

GO
/****** Object:  StoredProcedure [dbo].[sp_CancelAOrder]    Script Date: 09/05/2017 4:26:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_CancelAOrder]
			@maphieu int 
as
	update PhieuDat
	set TinhTrang = 2
	where MaPhieu = @maphieu
----------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[sp_CheckLogin]    Script Date: 09/05/2017 4:26:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_CheckLogin]
			@tendangnhap char(32),
			@matkhau char(32),
			@check int out
as
	select * from NhanVien where TenDangNhap=@tendangnhap and MatKhau=@matkhau
	if @@ROWCOUNT > 0
		set @check = 1
	else set @check = 0
----------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[sp_CheckUsername]    Script Date: 09/05/2017 4:26:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_CheckUsername]
			@tendangnhap char(32),
			@check int out
as
	select * from NhanVien where TenDangNhap=@tendangnhap
	if @@ROWCOUNT > 0
		set @check = 1
	else set @check = 0
----------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[sp_CreateAOrder]    Script Date: 09/05/2017 4:26:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_CreateAOrder]
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

GO
/****** Object:  StoredProcedure [dbo].[sp_CreateGoodsReceipt]    Script Date: 09/05/2017 4:26:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_CreateGoodsReceipt]
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

GO
/****** Object:  StoredProcedure [dbo].[sp_CreateInventoryList]    Script Date: 09/05/2017 4:26:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_CreateInventoryList]
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

GO
/****** Object:  StoredProcedure [dbo].[sp_createNewBillInfo]    Script Date: 09/05/2017 4:26:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_createNewBillInfo]
	@NgayGio datetime,
	@MaNV int,
	@MaKH int,
	@TiLeChietKhau float,
	@MaHD int out
as
	begin
		insert into HoaDon(Ngay, Gio, MaNV, MaKH, TiLeChietKhau)
		values(Convert(date, @NgayGio), Convert(time(7), @NgayGio), @MaNV, @MaKH, @TiLeChietKhau)
		select @MaHD = SCOPE_IDENTITY()
		return;
	end

GO
/****** Object:  StoredProcedure [dbo].[sp_CustomerDetail]    Script Date: 09/05/2017 4:26:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_CustomerDetail]
	@MaKH int
as
select kh.MaKH, kh.HoTenKH, kh.CMND, kh.SoDT, l_kh.TenLoai, l_kh.TyLeChietKhau, DiemTichLuy
from KhachHang kh join LoaiKH l_kh on (kh.MaLoaiKH = l_kh.MaLoai)
where kh.MaKH = @MaKH 
GO
/****** Object:  StoredProcedure [dbo].[sp_FoodSearch]    Script Date: 09/05/2017 4:26:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_FoodSearch]
	@TenSP nvarchar(50)
as
select MaSP as 'Mã món ăn', TenSP as 'Tên món ăn', Gia as 'Giá', TenLoai as 'Loại'
from SanPham sp join LoaiSP l_sp on (sp.MaLoaiSP = l_sp.MaLoai) 
where MaLoaiSP != 1 and TenSP like '%' + @TenSP + '%'
GO
/****** Object:  StoredProcedure [dbo].[sp_getBillDetail]    Script Date: 09/05/2017 4:26:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_getBillDetail]
	@MaHD int
as
select sp.MaSP 'Mã SP', sp.TenSP 'Tên SP', cthd.GiaBan 'Giá bán', cthd.SoLuong 'Số lượng' , (cthd.SoLuong*cthd.GiaBan) 'Thành tiền'
from CT_HoaDon cthd join SanPham sp on (cthd.MaSP = sp.MaSP)
where cthd.MaHD = @MaHD
GO
/****** Object:  StoredProcedure [dbo].[sp_insertItemsToBill]    Script Date: 09/05/2017 4:26:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_insertItemsToBill]
	@MaHD int,
	@MaSP int,
	@GiaBan int,
	@SoLuong int
as
	insert into CT_HoaDon(MaHD, MaSP, GiaBan, SoLuong)
	values(@MaHD ,@MaSP, @GiaBan, @SoLuong)
GO
/****** Object:  StoredProcedure [dbo].[sp_LoadGoodsReceipt]    Script Date: 09/05/2017 4:26:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LoadGoodsReceipt]
as
	select pn.*,nv.TenNV
	from PhieuNhap pn, NhanVien nv 
	where pn.MaNV = nv.MaNV
----------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[sp_LoadGoodsReceiptDetails]    Script Date: 09/05/2017 4:26:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LoadGoodsReceiptDetails]
			@maphieu int
as
	select ctpn.*, nl.TenNL,nl.DonVi, ncc.TenNCC
	from CT_PhieuNhap ctpn, NguyenLieu nl, NhaCC ncc
	where ctpn.MaNL=nl.MaNL and ctpn.MaPhieu = @maphieu and ctpn.NhaCC=ncc.MaNCC
----------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[sp_LoadIngredients]    Script Date: 09/05/2017 4:26:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LoadIngredients]
as
	select * from NguyenLieu

----------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[sp_LoadInventoryList]    Script Date: 09/05/2017 4:26:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LoadInventoryList]
as
	select distinct pk.*, nv.TenNV
	from PhieuKiem pk, NhanVien nv
	where pk.MaNV = nv.MaNV
----------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[sp_LoadInventoryListDetails]    Script Date: 09/05/2017 4:26:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LoadInventoryListDetails]
			@maphieu int
as
	select ctpk.*, ctpk.SLTonLT- (ctpk.SLTonTT + ctpk.SLHu) as SL_HAOHUT, nl.TENNL, nl.DonVi, tongtien_haohut
	from CT_PhieuKiem ctpk, NGUYENLIEU nl, (select sum((ctpk.SLTonLT- (ctpk.SLTonTT + ctpk.SLHu))*nl.GIA) as tongtien_haohut
												from  CT_PhieuKiem ctpk, NGUYENLIEU nl
												where ctpk.MaPhieu=@maphieu and ctpk.MANL=nl.MANL) as tt_hh
	where ctpk.MaPhieu=@maphieu and ctpk.MANL=nl.MANL

	exec sp_LoadInventoryListDetails 8
----------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[sp_LoadOrder]    Script Date: 09/05/2017 4:26:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LoadOrder]
as
	select pd.*,nv.TenNV
	from PhieuDat pd, NhanVien nv
	where pd.MaNV = nv.MaNV
----------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[sp_LoadOrderDetails]    Script Date: 09/05/2017 4:26:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LoadOrderDetails]
			@maphieu int
as
	select ctpd.*, nl.TenNL,nl.DonVi,nl.Gia
	from CT_PhieuDat ctpd, NguyenLieu nl
	where ctpd.MaNL=nl.MaNL and ctpd.MaPhieu = @maphieu

--exec sp_LoadOrderDetails 1013
----------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[sp_LoadSupplier]    Script Date: 09/05/2017 4:26:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LoadSupplier]
as
	select MaNCC,TenNCC
	from NhaCC
GO
/****** Object:  StoredProcedure [dbo].[sp_SearchGoodsReceipt_byDate]    Script Date: 09/05/2017 4:26:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_SearchGoodsReceipt_byDate]
			@tungay date,
			@denngay date
as
	select pn.*,nv.TenNV
	from PhieuNhap pn, NhanVien nv
	where NgayGio >= @tungay and NgayGio < dateadd(day,1,@denngay) and pn.MaNV = nv.MaNV
----------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[sp_SearchGoodsReceipt_byNumber]    Script Date: 09/05/2017 4:26:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_SearchGoodsReceipt_byNumber]
			@ma nvarchar(50)
as
	select distinct pn.*,nv.TenNV
	from PhieuNhap pn, NhanVien nv
	where (MaPhieu like '%'+@ma+'%' or 
		pn.MaNV like '%'+@ma+'%' or 
		nv.TenNV like '%'+@ma+'%') and 
		pn.MaNV = nv.MaNV

----------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[sp_SearchIngredients]    Script Date: 09/05/2017 4:26:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_SearchIngredients]
			@keyword nvarchar(50)
as
	select distinct *
	from nguyenlieu
	where MANL like '%'+@keyword+'%' or TENNL like '%'+@keyword+'%' or donvi like '%'+@keyword+'%' or hsd like '%'+@keyword+'%'
----------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[sp_SearchInventoryList_byDate]    Script Date: 09/05/2017 4:26:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_SearchInventoryList_byDate]
			@tungay date,
			@denngay date
as
	select distinct pk.*, nv.TenNV
	from PhieuKiem pk, NhanVien nv
	where NgayGio >= @tungay and NgayGio < dateadd(day,1,@denngay) and pk.MaNV = nv.MaNV
----------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[sp_SearchInventoryList_byNumber]    Script Date: 09/05/2017 4:26:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_SearchInventoryList_byNumber]
			@ma nvarchar(50)
as
	select distinct pk.*, nv.TenNV
	from PhieuKiem pk, NhanVien nv
	where (MaPhieu like '%'+@ma+'%' or
		nv.MaNV like '%'+@ma+'%'or 
		nv.TenNV like '%'+@ma+'%') and
		pk.MaNV = nv.MaNV

----------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[sp_SearchOrder_byDate]    Script Date: 09/05/2017 4:26:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_SearchOrder_byDate]
			@tungay date,
			@denngay date
as
	select distinct pd.*,nv.TenNV
	from PhieuDat pd, NhanVien nv
	where pd.NgayDat >= @tungay and pd.NgayDat < dateadd(day,1,@denngay) and pd.MaNV = nv.MaNV

----------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[sp_SearchOrder_byNumber]    Script Date: 09/05/2017 4:26:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_SearchOrder_byNumber]
			@ma nvarchar(50)
as
	select distinct pd.*,nv.TenNV
	from PhieuDat pd, NhanVien nv
	where (pd.MaPhieu like '%'+@ma+'%' or 
		pd.MaNV like '%'+@ma+'%' or 
		nv.TenNV like '%'+@ma+'%')
		and pd.MaNV = nv.MaNV

----------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[sp_StatisticByBill]    Script Date: 09/05/2017 4:26:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_StatisticByBill]
	@NgayBD date,
	@NgayKT date
as
select hd.MaHD 'Mã HĐ', sum(cthd.GiaBan*cthd.SoLuong) 'Tổng giá trị', sum(cthd.GiaBan*cthd.SoLuong)*hd.TiLeChietKhau 'Tiền chiết khấu', sum(cthd.GiaBan*cthd.SoLuong)*(1-hd.TiLeChietKhau) 'Thanh toán', hd.MaKH 'Mã KH', hd.MaNV 'Mã NV', hd.Ngay 'Ngày', hd.Gio 'Giờ'
from HoaDon hd join CT_HoaDon cthd on (hd.MaHD=cthd.MaHD)
where hd.Ngay >= @NgayBD and hd.Ngay <= @NgayKT
group by hd.MaHD, hd.TiLeChietKhau, hd.MaKH, hd.MaNV, hd.Ngay, hd.Gio
order by hd.MaHD desc
GO
/****** Object:  StoredProcedure [dbo].[sp_StatisticByProduct]    Script Date: 09/05/2017 4:26:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_StatisticByProduct]
	@NgayBD date,
	@NgayKT date
as
select cthd.MaSP 'Mã SP', sp.TenSP 'Tên SP', sum(cthd.SoLuong) 'Số lượng bán ra', sum(cthd.GiaBan*cthd.SoLuong) 'Doanh thu', l_sp.TenLoai 'Loại SP'
from HoaDon hd join CT_HoaDon cthd on (hd.MaHD=cthd.MaHD) right join SanPham sp on (sp.MaSP = cthd.MaSP) join LoaiSP l_sp on (sp.MaLoaiSP = l_sp.MaLoai)
where hd.Ngay >= @NgayBD and hd.Ngay <= @NgayKT
group by cthd.MaSP, sp.TenSP, l_sp.TenLoai
order by sum(cthd.GiaBan) desc
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdatePoint]    Script Date: 09/05/2017 4:26:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[sp_UpdatePoint]
	@MaKH int,
	@DiemTichLuy int
as
	update KhachHang 
	set DiemTichLuy = @DiemTichLuy
	where MaKH = @MaKH
GO
/****** Object:  StoredProcedure [dbo].[sp_UpgradeCustomerToVIP]    Script Date: 09/05/2017 4:26:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[sp_UpgradeCustomerToVIP]
	@MaKH int
as
	update KhachHang 
	set MaLoaiKH = (
		select l_kh.MaLoai
		from LoaiKH l_kh
		where TenLoai = 'VIP'
	)
	where MaKH = @MaKH
GO
