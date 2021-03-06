USE [master]
GO
/****** Object:  Database [NhaHangDoNuong]    Script Date: 21/4/2017 10:33:17 PM ******/
CREATE DATABASE [NhaHangDoNuong]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'NhaHangDoNuong', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.PHUC1\MSSQL\DATA\NhaHangDoNuong.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'NhaHangDoNuong_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.PHUC1\MSSQL\DATA\NhaHangDoNuong_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [NhaHangDoNuong] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [NhaHangDoNuong].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [NhaHangDoNuong] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [NhaHangDoNuong] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [NhaHangDoNuong] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [NhaHangDoNuong] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [NhaHangDoNuong] SET ARITHABORT OFF 
GO
ALTER DATABASE [NhaHangDoNuong] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [NhaHangDoNuong] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [NhaHangDoNuong] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [NhaHangDoNuong] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [NhaHangDoNuong] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [NhaHangDoNuong] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [NhaHangDoNuong] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [NhaHangDoNuong] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [NhaHangDoNuong] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [NhaHangDoNuong] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [NhaHangDoNuong] SET  DISABLE_BROKER 
GO
ALTER DATABASE [NhaHangDoNuong] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [NhaHangDoNuong] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [NhaHangDoNuong] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [NhaHangDoNuong] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [NhaHangDoNuong] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [NhaHangDoNuong] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [NhaHangDoNuong] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [NhaHangDoNuong] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [NhaHangDoNuong] SET  MULTI_USER 
GO
ALTER DATABASE [NhaHangDoNuong] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [NhaHangDoNuong] SET DB_CHAINING OFF 
GO
ALTER DATABASE [NhaHangDoNuong] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [NhaHangDoNuong] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [NhaHangDoNuong]
GO
/****** Object:  StoredProcedure [dbo].[sp_AddGoodsReceiptDetails]    Script Date: 21/4/2017 10:33:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_AddGoodsReceiptDetails]
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
GO
/****** Object:  StoredProcedure [dbo].[sp_AddInventoryListDetails]    Script Date: 21/4/2017 10:33:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_AddInventoryListDetails]
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
GO
/****** Object:  StoredProcedure [dbo].[sp_CheckLogin]    Script Date: 21/4/2017 10:33:17 PM ******/
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
GO
/****** Object:  StoredProcedure [dbo].[sp_CheckUsername]    Script Date: 21/4/2017 10:33:17 PM ******/
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
GO
/****** Object:  StoredProcedure [dbo].[sp_CreateGoodsReceipt]    Script Date: 21/4/2017 10:33:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_CreateGoodsReceipt]
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
GO
/****** Object:  StoredProcedure [dbo].[sp_CreateInventoryList]    Script Date: 21/4/2017 10:33:17 PM ******/
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
	values (@ngaygio,@manv)
	select @maphieu = maphieu from @table
GO
/****** Object:  StoredProcedure [dbo].[sp_LoadGoodsReceipt]    Script Date: 21/4/2017 10:33:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Lấy phiếu nhập
create proc [dbo].[sp_LoadGoodsReceipt]
as
	select *
	from PhieuNhap
GO
/****** Object:  StoredProcedure [dbo].[sp_LoadGoodsReceiptDetails]    Script Date: 21/4/2017 10:33:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LoadGoodsReceiptDetails]
			@maphieu int
as
	select ctpn.*, nl.TenNL,nl.DonVi
	from CT_PhieuNhap ctpn, NguyenLieu nl
	where ctpn.MaNL=nl.MaNL and ctpn.MaPhieu = @maphieu
GO
/****** Object:  StoredProcedure [dbo].[sp_LoadIngredients]    Script Date: 21/4/2017 10:33:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LoadIngredients]
as
	select * from NguyenLieu
GO
/****** Object:  StoredProcedure [dbo].[sp_LoadInventoryList]    Script Date: 21/4/2017 10:33:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LoadInventoryList]
as
	select *
	from PhieuKiem
GO
/****** Object:  StoredProcedure [dbo].[sp_LoadInventoryListDetails]    Script Date: 21/4/2017 10:33:17 PM ******/
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
GO
/****** Object:  StoredProcedure [dbo].[sp_SearchGoodsReceipt_byDate]    Script Date: 21/4/2017 10:33:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Tìm kiếm phiếu nhập theo ngày
create proc [dbo].[sp_SearchGoodsReceipt_byDate]
			@tungay date,
			@denngay date
as
	select *
	from PhieuNhap
	where NgayGio >= @tungay and NgayGio < dateadd(day,1,@denngay)
----------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[sp_SearchGoodsReceipt_byNumber]    Script Date: 21/4/2017 10:33:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Tìm kiếm phiếu nhập theo mã
create proc [dbo].[sp_SearchGoodsReceipt_byNumber]
			@ma nvarchar(50)
as
	select distinct *
	from PhieuKiem
	where MaPhieu like '%'+@ma+'%' or MaNV like '%'+@ma+'%'

----------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[sp_SearchIngredients]    Script Date: 21/4/2017 10:33:17 PM ******/
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
GO
/****** Object:  StoredProcedure [dbo].[sp_SearchInventoryList_byDate]    Script Date: 21/4/2017 10:33:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Tìm kiếm thống kê kho theo ngày
--drop proc sp_SearchInventoryList_byDate
create proc [dbo].[sp_SearchInventoryList_byDate]
			@tungay date,
			@denngay date
as
	select *
	from PhieuKiem
	where NgayGio >= @tungay and NgayGio < dateadd(day,1,@denngay)
GO
/****** Object:  StoredProcedure [dbo].[sp_SearchInventoryList_byNumber]    Script Date: 21/4/2017 10:33:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Tìm kiếm thống kê kho theo mã
--drop proc sp_SearchInventoryList_byNumber
create proc [dbo].[sp_SearchInventoryList_byNumber]
			@ma nvarchar(50)
as
	select distinct *
	from PhieuKiem
	where MaPhieu like '%'+@ma+'%' or MaNV like '%'+@ma+'%'

----------------------------------------------------------------------------------------------

GO
/****** Object:  Table [dbo].[CongThuc]    Script Date: 21/4/2017 10:33:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CongThuc](
	[MaSP] [int] NOT NULL,
	[MaNL] [int] NOT NULL,
	[Luong] [decimal](18, 3) NULL,
 CONSTRAINT [PK_CongThuc] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC,
	[MaNL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CT_HoaDon]    Script Date: 21/4/2017 10:33:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_HoaDon](
	[MaHD] [int] NOT NULL,
	[MaSP] [int] NOT NULL,
	[SoLuong] [nchar](10) NULL,
	[GiaBan] [nchar](10) NULL,
 CONSTRAINT [PK_CT_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CT_PhieuKiem]    Script Date: 21/4/2017 10:33:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_PhieuKiem](
	[MaPhieu] [int] NOT NULL,
	[MaNL] [int] NOT NULL,
	[Gia] [int] NULL,
	[SLTonLT] [decimal](3, 0) NULL,
	[SLTonTT] [decimal](3, 0) NULL,
	[SLHu] [decimal](3, 0) NULL,
 CONSTRAINT [PK_CTphieuKiem] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC,
	[MaNL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CT_PhieuNhap]    Script Date: 21/4/2017 10:33:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_PhieuNhap](
	[MaPhieu] [int] NOT NULL,
	[MaNL] [int] NOT NULL,
	[NhaCC] [nvarchar](50) NULL,
	[GiaNhap] [int] NULL,
	[SoLuong] [decimal](3, 0) NULL,
 CONSTRAINT [PK_CTphieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC,
	[MaNL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 21/4/2017 10:33:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [int] NOT NULL,
	[Ngay] [date] NULL,
	[Gio] [time](7) NULL,
	[MaNV] [int] NULL,
	[MaKH] [int] NULL,
	[TiLeChietKhau] [float] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 21/4/2017 10:33:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[HoTenKH] [nvarchar](50) NOT NULL,
	[CMND] [varchar](15) NOT NULL,
	[SoDT] [varchar](20) NULL,
	[MaLoaiKH] [int] NOT NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiKH]    Script Date: 21/4/2017 10:33:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiKH](
	[MaLoai] [int] NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
	[TyLeChietKhau] [float] NULL,
 CONSTRAINT [PK_LoaiKH] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiNL]    Script Date: 21/4/2017 10:33:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiNL](
	[MaLoai] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiNL] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiNV]    Script Date: 21/4/2017 10:33:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiNV](
	[MaLoai] [int] NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiNV] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiSP]    Script Date: 21/4/2017 10:33:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSP](
	[MaLoai] [int] NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiSP] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NguyenLieu]    Script Date: 21/4/2017 10:33:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguyenLieu](
	[MaNL] [int] IDENTITY(1,1) NOT NULL,
	[TenNL] [nvarchar](50) NOT NULL,
	[DonVi] [nvarchar](20) NULL,
	[HSD] [nvarchar](50) NOT NULL,
	[Gia] [int] NOT NULL,
	[SoLuong] [decimal](3, 0) NULL,
	[MaLoaiNL] [int] NOT NULL,
 CONSTRAINT [PK_NguyenLieu] PRIMARY KEY CLUSTERED 
(
	[MaNL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 21/4/2017 10:33:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[CMND] [nchar](15) NULL,
	[SoDT] [nchar](15) NULL,
	[TenDangNhap] [char](32) NULL,
	[MatKhau] [char](32) NULL,
	[MaLoaiNV] [int] NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuKiem]    Script Date: 21/4/2017 10:33:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuKiem](
	[MaPhieu] [int] IDENTITY(1,1) NOT NULL,
	[NgayGio] [datetime] NOT NULL,
	[MaNV] [int] NOT NULL,
 CONSTRAINT [PK_PhieuKiem] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 21/4/2017 10:33:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPhieu] [int] IDENTITY(1,1) NOT NULL,
	[NgayGio] [datetime] NOT NULL,
	[MaNV] [int] NOT NULL,
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 21/4/2017 10:33:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [int] IDENTITY(1,1) NOT NULL,
	[TenSP] [nvarchar](50) NULL,
	[Gia] [int] NULL,
	[MaLoaiSP] [int] NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[CongThuc]  WITH CHECK ADD  CONSTRAINT [FK_CongThuc_NguyenLieu] FOREIGN KEY([MaNL])
REFERENCES [dbo].[NguyenLieu] ([MaNL])
GO
ALTER TABLE [dbo].[CongThuc] CHECK CONSTRAINT [FK_CongThuc_NguyenLieu]
GO
ALTER TABLE [dbo].[CongThuc]  WITH CHECK ADD  CONSTRAINT [FK_CongThuc_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[CongThuc] CHECK CONSTRAINT [FK_CongThuc_SanPham]
GO
ALTER TABLE [dbo].[CT_HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_CT_HoaDon_HoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[CT_HoaDon] CHECK CONSTRAINT [FK_CT_HoaDon_HoaDon]
GO
ALTER TABLE [dbo].[CT_HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_CT_HoaDon_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[CT_HoaDon] CHECK CONSTRAINT [FK_CT_HoaDon_SanPham]
GO
ALTER TABLE [dbo].[CT_PhieuKiem]  WITH CHECK ADD  CONSTRAINT [FK_CT_PhieuKiem_NguyenLieu] FOREIGN KEY([MaNL])
REFERENCES [dbo].[NguyenLieu] ([MaNL])
GO
ALTER TABLE [dbo].[CT_PhieuKiem] CHECK CONSTRAINT [FK_CT_PhieuKiem_NguyenLieu]
GO
ALTER TABLE [dbo].[CT_PhieuKiem]  WITH CHECK ADD  CONSTRAINT [FK_CT_PhieuKiem_PhieuKiem] FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[PhieuKiem] ([MaPhieu])
GO
ALTER TABLE [dbo].[CT_PhieuKiem] CHECK CONSTRAINT [FK_CT_PhieuKiem_PhieuKiem]
GO
ALTER TABLE [dbo].[CT_PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_CT_PhieuNhap_NguyenLieu] FOREIGN KEY([MaNL])
REFERENCES [dbo].[NguyenLieu] ([MaNL])
GO
ALTER TABLE [dbo].[CT_PhieuNhap] CHECK CONSTRAINT [FK_CT_PhieuNhap_NguyenLieu]
GO
ALTER TABLE [dbo].[CT_PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_CT_PhieuNhap_PhieuNhap] FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[PhieuNhap] ([MaPhieu])
GO
ALTER TABLE [dbo].[CT_PhieuNhap] CHECK CONSTRAINT [FK_CT_PhieuNhap_PhieuNhap]
GO
ALTER TABLE [dbo].[CT_PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_CT_PhieuNhap_PhieuNhap1] FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[PhieuNhap] ([MaPhieu])
GO
ALTER TABLE [dbo].[CT_PhieuNhap] CHECK CONSTRAINT [FK_CT_PhieuNhap_PhieuNhap1]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_LoaiKH] FOREIGN KEY([MaLoaiKH])
REFERENCES [dbo].[LoaiKH] ([MaLoai])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_LoaiKH]
GO
ALTER TABLE [dbo].[NguyenLieu]  WITH CHECK ADD  CONSTRAINT [FK_NguyenLieu_LoaiNL] FOREIGN KEY([MaLoaiNL])
REFERENCES [dbo].[LoaiNL] ([MaLoai])
GO
ALTER TABLE [dbo].[NguyenLieu] CHECK CONSTRAINT [FK_NguyenLieu_LoaiNL]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_LoaiNV] FOREIGN KEY([MaLoaiNV])
REFERENCES [dbo].[LoaiNV] ([MaLoai])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_LoaiNV]
GO
ALTER TABLE [dbo].[PhieuKiem]  WITH CHECK ADD  CONSTRAINT [FK_PhieuKiem_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuKiem] CHECK CONSTRAINT [FK_PhieuKiem_NhanVien]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhanVien]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_LoaiSP] FOREIGN KEY([MaLoaiSP])
REFERENCES [dbo].[LoaiSP] ([MaLoai])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_LoaiSP]
GO
USE [master]
GO
ALTER DATABASE [NhaHangDoNuong] SET  READ_WRITE 
GO
