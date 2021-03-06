USE [NhaHangDoNuong]
GO
/****** Object:  StoredProcedure [dbo].[sp_StatisticByProduct]    Script Date: 28/04/2017 3:02:44 PM ******/
DROP PROCEDURE [dbo].[sp_StatisticByProduct]
GO
/****** Object:  StoredProcedure [dbo].[sp_StatisticByBill]    Script Date: 28/04/2017 3:02:45 PM ******/
DROP PROCEDURE [dbo].[sp_StatisticByBill]
GO
/****** Object:  StoredProcedure [dbo].[sp_insertItemsToBill]    Script Date: 28/04/2017 3:02:45 PM ******/
DROP PROCEDURE [dbo].[sp_insertItemsToBill]
GO
/****** Object:  StoredProcedure [dbo].[sp_FoodSearch]    Script Date: 28/04/2017 3:02:45 PM ******/
DROP PROCEDURE [dbo].[sp_FoodSearch]
GO
/****** Object:  StoredProcedure [dbo].[sp_CustomerDetail]    Script Date: 28/04/2017 3:02:45 PM ******/
DROP PROCEDURE [dbo].[sp_CustomerDetail]
GO
/****** Object:  StoredProcedure [dbo].[sp_createNewBillInfo]    Script Date: 28/04/2017 3:02:45 PM ******/
DROP PROCEDURE [dbo].[sp_createNewBillInfo]
GO
/****** Object:  StoredProcedure [dbo].[sp_BeverageSearch]    Script Date: 28/04/2017 3:02:45 PM ******/
DROP PROCEDURE [dbo].[sp_BeverageSearch]
GO
/****** Object:  StoredProcedure [dbo].[sp_BeverageSearch]    Script Date: 28/04/2017 3:02:45 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_createNewBillInfo]    Script Date: 28/04/2017 3:02:45 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_CustomerDetail]    Script Date: 28/04/2017 3:02:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_CustomerDetail]
	@MaKH int
as
select kh.MaKH, kh.HoTenKH, kh.CMND, kh.SoDT, l_kh.TenLoai, l_kh.TyLeChietKhau
from KhachHang kh join LoaiKH l_kh on (kh.MaLoaiKH = l_kh.MaLoai)
where kh.MaKH = @MaKH 
GO
/****** Object:  StoredProcedure [dbo].[sp_FoodSearch]    Script Date: 28/04/2017 3:02:45 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_insertItemsToBill]    Script Date: 28/04/2017 3:02:45 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_StatisticByBill]    Script Date: 28/04/2017 3:02:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_StatisticByBill]
	@NgayBD date,
	@NgayKT date
as
select hd.MaHD 'Mã HĐ', sum(cthd.GiaBan) 'Tổng giá trị', sum(cthd.GiaBan)*hd.TiLeChietKhau 'Tiền chiết khấu', sum(cthd.GiaBan)*(1-hd.TiLeChietKhau) 'Thanh toán', hd.MaKH 'Mã KH', hd.MaNV 'Mã NV', hd.Ngay 'Ngày', hd.Gio 'Giờ'
from HoaDon hd join CT_HoaDon cthd on (hd.MaHD=cthd.MaHD)
where hd.Ngay >= @NgayBD and hd.Ngay <= @NgayKT
group by hd.MaHD, hd.TiLeChietKhau, hd.MaKH, hd.MaNV, hd.Ngay, hd.Gio
order by hd.MaHD desc
GO
/****** Object:  StoredProcedure [dbo].[sp_StatisticByProduct]    Script Date: 28/04/2017 3:02:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_StatisticByProduct]
	@NgayBD date,
	@NgayKT date
as
select cthd.MaSP 'Mã SP', sp.TenSP 'Tên SP', sum(cthd.SoLuong) 'Số lượng bán ra', sum(cthd.GiaBan*cthd.SoLuong) 'Doanh thu'
from HoaDon hd join CT_HoaDon cthd on (hd.MaHD=cthd.MaHD) right join SanPham sp on (sp.MaSP = cthd.MaSP)
where hd.Ngay >= @NgayBD and hd.Ngay <= @NgayKT
group by cthd.MaSP, sp.TenSP
order by sum(cthd.GiaBan) desc
GO
