USE [NhaHangDoNuong]
GO
ALTER TABLE [dbo].[SanPham] DROP CONSTRAINT [FK_SanPham_LoaiSP]
GO
ALTER TABLE [dbo].[PhieuNhap] DROP CONSTRAINT [FK_PhieuNhap_PhieuDat]
GO
ALTER TABLE [dbo].[PhieuNhap] DROP CONSTRAINT [FK_PhieuNhap_NhanVien]
GO
ALTER TABLE [dbo].[PhieuKiem] DROP CONSTRAINT [FK_PhieuKiem_NhanVien]
GO
ALTER TABLE [dbo].[PhieuDat] DROP CONSTRAINT [FK_PhieuDat_NhanVien]
GO
ALTER TABLE [dbo].[NhanVien] DROP CONSTRAINT [FK_NhanVien_LoaiNV]
GO
ALTER TABLE [dbo].[NguyenLieu] DROP CONSTRAINT [FK_NguyenLieu_LoaiNL]
GO
ALTER TABLE [dbo].[KhachHang] DROP CONSTRAINT [FK_KhachHang_LoaiKH]
GO
ALTER TABLE [dbo].[HoaDon] DROP CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [dbo].[HoaDon] DROP CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[CT_PhieuNhap] DROP CONSTRAINT [FK_CT_PhieuNhap_PhieuNhap]
GO
ALTER TABLE [dbo].[CT_PhieuNhap] DROP CONSTRAINT [FK_CT_PhieuNhap_NhaCC]
GO
ALTER TABLE [dbo].[CT_PhieuNhap] DROP CONSTRAINT [FK_CT_PhieuNhap_NguyenLieu]
GO
ALTER TABLE [dbo].[CT_PhieuKiem] DROP CONSTRAINT [FK_CT_PhieuKiem_PhieuKiem]
GO
ALTER TABLE [dbo].[CT_PhieuKiem] DROP CONSTRAINT [FK_CT_PhieuKiem_NguyenLieu]
GO
ALTER TABLE [dbo].[CT_PhieuDat] DROP CONSTRAINT [FK_CT_PhieuDat_PhieuDat]
GO
ALTER TABLE [dbo].[CT_PhieuDat] DROP CONSTRAINT [FK_CT_PhieuDat_NguyenLieu]
GO
ALTER TABLE [dbo].[CT_HoaDon] DROP CONSTRAINT [FK_CT_HoaDon_SanPham]
GO
ALTER TABLE [dbo].[CT_HoaDon] DROP CONSTRAINT [FK_CT_HoaDon_HoaDon]
GO
ALTER TABLE [dbo].[CongThuc] DROP CONSTRAINT [FK_CongThuc_SanPham]
GO
ALTER TABLE [dbo].[CongThuc] DROP CONSTRAINT [FK_CongThuc_NguyenLieu]
GO
ALTER TABLE [dbo].[KhachHang] DROP CONSTRAINT [DF_KhachHang_DiemTichLuy]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 09/05/2017 4:24:29 PM ******/
DROP TABLE [dbo].[SanPham]
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 09/05/2017 4:24:29 PM ******/
DROP TABLE [dbo].[PhieuNhap]
GO
/****** Object:  Table [dbo].[PhieuKiem]    Script Date: 09/05/2017 4:24:29 PM ******/
DROP TABLE [dbo].[PhieuKiem]
GO
/****** Object:  Table [dbo].[PhieuDat]    Script Date: 09/05/2017 4:24:29 PM ******/
DROP TABLE [dbo].[PhieuDat]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 09/05/2017 4:24:29 PM ******/
DROP TABLE [dbo].[NhanVien]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 09/05/2017 4:24:29 PM ******/
DROP TABLE [dbo].[NhaCungCap]
GO
/****** Object:  Table [dbo].[NhaCC]    Script Date: 09/05/2017 4:24:29 PM ******/
DROP TABLE [dbo].[NhaCC]
GO
/****** Object:  Table [dbo].[NguyenLieu]    Script Date: 09/05/2017 4:24:29 PM ******/
DROP TABLE [dbo].[NguyenLieu]
GO
/****** Object:  Table [dbo].[LoaiSP]    Script Date: 09/05/2017 4:24:29 PM ******/
DROP TABLE [dbo].[LoaiSP]
GO
/****** Object:  Table [dbo].[LoaiNV]    Script Date: 09/05/2017 4:24:29 PM ******/
DROP TABLE [dbo].[LoaiNV]
GO
/****** Object:  Table [dbo].[LoaiNL]    Script Date: 09/05/2017 4:24:29 PM ******/
DROP TABLE [dbo].[LoaiNL]
GO
/****** Object:  Table [dbo].[LoaiKH]    Script Date: 09/05/2017 4:24:29 PM ******/
DROP TABLE [dbo].[LoaiKH]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 09/05/2017 4:24:29 PM ******/
DROP TABLE [dbo].[KhachHang]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 09/05/2017 4:24:29 PM ******/
DROP TABLE [dbo].[HoaDon]
GO
/****** Object:  Table [dbo].[CT_PhieuNhap]    Script Date: 09/05/2017 4:24:29 PM ******/
DROP TABLE [dbo].[CT_PhieuNhap]
GO
/****** Object:  Table [dbo].[CT_PhieuKiem]    Script Date: 09/05/2017 4:24:29 PM ******/
DROP TABLE [dbo].[CT_PhieuKiem]
GO
/****** Object:  Table [dbo].[CT_PhieuDat]    Script Date: 09/05/2017 4:24:29 PM ******/
DROP TABLE [dbo].[CT_PhieuDat]
GO
/****** Object:  Table [dbo].[CT_HoaDon]    Script Date: 09/05/2017 4:24:29 PM ******/
DROP TABLE [dbo].[CT_HoaDon]
GO
/****** Object:  Table [dbo].[CongThuc]    Script Date: 09/05/2017 4:24:29 PM ******/
DROP TABLE [dbo].[CongThuc]
GO
/****** Object:  Table [dbo].[CongThuc]    Script Date: 09/05/2017 4:24:29 PM ******/
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
/****** Object:  Table [dbo].[CT_HoaDon]    Script Date: 09/05/2017 4:24:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_HoaDon](
	[MaHD] [int] NOT NULL,
	[MaSP] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[GiaBan] [int] NULL,
 CONSTRAINT [PK_CT_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CT_PhieuDat]    Script Date: 09/05/2017 4:24:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_PhieuDat](
	[MaPhieu] [int] NOT NULL,
	[MaNL] [int] NOT NULL,
	[SoLuongDat] [decimal](7, 3) NULL,
	[SoLuongDaNhap] [decimal](7, 3) NULL,
 CONSTRAINT [PK_CT_PhieuDat] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC,
	[MaNL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CT_PhieuKiem]    Script Date: 09/05/2017 4:24:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_PhieuKiem](
	[MaPhieu] [int] NOT NULL,
	[MaNL] [int] NOT NULL,
	[Gia] [int] NULL,
	[SLTonLT] [decimal](7, 3) NULL,
	[SLTonTT] [decimal](7, 3) NULL,
	[SLHu] [decimal](7, 3) NULL,
 CONSTRAINT [PK_CTphieuKiem] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC,
	[MaNL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CT_PhieuNhap]    Script Date: 09/05/2017 4:24:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_PhieuNhap](
	[MaPhieu] [int] NOT NULL,
	[MaNL] [int] NOT NULL,
	[NhaCC] [int] NOT NULL,
	[GiaNhap] [int] NOT NULL,
	[SoLuongNhap] [decimal](7, 3) NOT NULL,
	[SoLuongTra] [decimal](7, 3) NOT NULL,
	[LyDo] [nvarchar](100) NULL,
 CONSTRAINT [PK_CTphieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC,
	[MaNL] ASC,
	[NhaCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 09/05/2017 4:24:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [int] IDENTITY(1,1) NOT NULL,
	[Ngay] [date] NOT NULL,
	[Gio] [time](7) NOT NULL,
	[MaNV] [int] NOT NULL,
	[MaKH] [int] NOT NULL,
	[TiLeChietKhau] [float] NOT NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 09/05/2017 4:24:29 PM ******/
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
	[DiemTichLuy] [int] NOT NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiKH]    Script Date: 09/05/2017 4:24:29 PM ******/
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
/****** Object:  Table [dbo].[LoaiNL]    Script Date: 09/05/2017 4:24:29 PM ******/
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
/****** Object:  Table [dbo].[LoaiNV]    Script Date: 09/05/2017 4:24:29 PM ******/
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
/****** Object:  Table [dbo].[LoaiSP]    Script Date: 09/05/2017 4:24:29 PM ******/
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
/****** Object:  Table [dbo].[NguyenLieu]    Script Date: 09/05/2017 4:24:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguyenLieu](
	[MaNL] [int] IDENTITY(1,1) NOT NULL,
	[TenNL] [nvarchar](50) NOT NULL,
	[DonVi] [nvarchar](20) NULL,
	[HSD] [nvarchar](30) NULL,
	[Gia] [int] NOT NULL,
	[SoLuong] [decimal](18, 3) NULL,
	[MaLoaiNL] [int] NOT NULL,
 CONSTRAINT [PK_NguyenLieu] PRIMARY KEY CLUSTERED 
(
	[MaNL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaCC]    Script Date: 09/05/2017 4:24:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCC](
	[MaNCC] [int] IDENTITY(1,1) NOT NULL,
	[TenNCC] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NhaCC] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 09/05/2017 4:24:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [int] IDENTITY(1,1) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 09/05/2017 4:24:29 PM ******/
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
/****** Object:  Table [dbo].[PhieuDat]    Script Date: 09/05/2017 4:24:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuDat](
	[MaPhieu] [int] IDENTITY(1,1) NOT NULL,
	[MaNV] [int] NOT NULL,
	[NgayDat] [datetime] NOT NULL,
	[NgayGiao] [datetime] NULL,
	[TinhTrang] [int] NOT NULL,
 CONSTRAINT [PK_PhieuDat] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuKiem]    Script Date: 09/05/2017 4:24:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuKiem](
	[MaPhieu] [int] IDENTITY(1,1) NOT NULL,
	[MaNV] [int] NOT NULL,
	[NgayGio] [datetime] NOT NULL,
 CONSTRAINT [PK_PhieuKiem] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 09/05/2017 4:24:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPhieu] [int] IDENTITY(1,1) NOT NULL,
	[MaPhieuDat] [int] NOT NULL,
	[MaNV] [int] NOT NULL,
	[NgayGio] [datetime] NOT NULL,
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 09/05/2017 4:24:29 PM ******/
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
ALTER TABLE [dbo].[KhachHang] ADD  CONSTRAINT [DF_KhachHang_DiemTichLuy]  DEFAULT ((0)) FOR [DiemTichLuy]
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
ALTER TABLE [dbo].[CT_PhieuDat]  WITH CHECK ADD  CONSTRAINT [FK_CT_PhieuDat_NguyenLieu] FOREIGN KEY([MaNL])
REFERENCES [dbo].[NguyenLieu] ([MaNL])
GO
ALTER TABLE [dbo].[CT_PhieuDat] CHECK CONSTRAINT [FK_CT_PhieuDat_NguyenLieu]
GO
ALTER TABLE [dbo].[CT_PhieuDat]  WITH CHECK ADD  CONSTRAINT [FK_CT_PhieuDat_PhieuDat] FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[PhieuDat] ([MaPhieu])
GO
ALTER TABLE [dbo].[CT_PhieuDat] CHECK CONSTRAINT [FK_CT_PhieuDat_PhieuDat]
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
ALTER TABLE [dbo].[CT_PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_CT_PhieuNhap_NhaCC] FOREIGN KEY([NhaCC])
REFERENCES [dbo].[NhaCC] ([MaNCC])
GO
ALTER TABLE [dbo].[CT_PhieuNhap] CHECK CONSTRAINT [FK_CT_PhieuNhap_NhaCC]
GO
ALTER TABLE [dbo].[CT_PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_CT_PhieuNhap_PhieuNhap] FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[PhieuNhap] ([MaPhieu])
GO
ALTER TABLE [dbo].[CT_PhieuNhap] CHECK CONSTRAINT [FK_CT_PhieuNhap_PhieuNhap]
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
ALTER TABLE [dbo].[PhieuDat]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDat_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuDat] CHECK CONSTRAINT [FK_PhieuDat_NhanVien]
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
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_PhieuDat] FOREIGN KEY([MaPhieuDat])
REFERENCES [dbo].[PhieuDat] ([MaPhieu])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_PhieuDat]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_LoaiSP] FOREIGN KEY([MaLoaiSP])
REFERENCES [dbo].[LoaiSP] ([MaLoai])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_LoaiSP]
GO
