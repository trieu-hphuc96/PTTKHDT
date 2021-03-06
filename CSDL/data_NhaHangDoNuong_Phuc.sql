USE [NhaHangDoNuong]
GO
INSERT [dbo].[LoaiNV] ([MaLoai], [TenLoai]) VALUES (1, N'Quản lý')
INSERT [dbo].[LoaiNV] ([MaLoai], [TenLoai]) VALUES (2, N'Thu ngân')
INSERT [dbo].[LoaiNV] ([MaLoai], [TenLoai]) VALUES (3, N'Phục vụ')
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [DiaChi], [CMND], [SoDT], [TenDangNhap], [MatKhau], [MaLoaiNV]) VALUES (1, N'Lê Văn Lý', CAST(0xC3150B00 AS Date), NULL, NULL, NULL, N'manager                         ', N'123456                          ', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [DiaChi], [CMND], [SoDT], [TenDangNhap], [MatKhau], [MaLoaiNV]) VALUES (3, N'Nguyễn Thị Ngân', CAST(0x2B1A0B00 AS Date), NULL, NULL, NULL, N'casher                          ', N'123456                          ', 2)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [DiaChi], [CMND], [SoDT], [TenDangNhap], [MatKhau], [MaLoaiNV]) VALUES (6, N'Đào Minh Vụ', CAST(0xAD1F0B00 AS Date), NULL, NULL, NULL, NULL, NULL, 3)
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
SET IDENTITY_INSERT [dbo].[PhieuKiem] ON 


INSERT [dbo].[PhieuKiem] ([MaPhieu], [NgayGio], [MaNV]) VALUES (8, CAST(0x0000A750000649EE AS DateTime), 1)
INSERT [dbo].[PhieuKiem] ([MaPhieu], [NgayGio], [MaNV]) VALUES (9, CAST(0x0000A753018089A1 AS DateTime), 1)
INSERT [dbo].[PhieuKiem] ([MaPhieu], [NgayGio], [MaNV]) VALUES (10, CAST(0x0000A7530180EA51 AS DateTime), 1)
INSERT [dbo].[PhieuKiem] ([MaPhieu], [NgayGio], [MaNV]) VALUES (11, CAST(0x0000A753018115F7 AS DateTime), 1)
INSERT [dbo].[PhieuKiem] ([MaPhieu], [NgayGio], [MaNV]) VALUES (12, CAST(0x0000A7530181A737 AS DateTime), 1)
INSERT [dbo].[PhieuKiem] ([MaPhieu], [NgayGio], [MaNV]) VALUES (13, CAST(0x0000A75301834D41 AS DateTime), 1)
INSERT [dbo].[PhieuKiem] ([MaPhieu], [NgayGio], [MaNV]) VALUES (14, CAST(0x0000A753018410A6 AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[PhieuKiem] OFF
SET IDENTITY_INSERT [dbo].[LoaiNL] ON 

INSERT [dbo].[LoaiNL] ([MaLoai], [TenLoai]) VALUES (1, N'Thịt')
INSERT [dbo].[LoaiNL] ([MaLoai], [TenLoai]) VALUES (2, N'Sữa')
INSERT [dbo].[LoaiNL] ([MaLoai], [TenLoai]) VALUES (3, N'Rau')
INSERT [dbo].[LoaiNL] ([MaLoai], [TenLoai]) VALUES (4, N'Đồ hộp')
INSERT [dbo].[LoaiNL] ([MaLoai], [TenLoai]) VALUES (5, N'Nước đóng chai')
INSERT [dbo].[LoaiNL] ([MaLoai], [TenLoai]) VALUES (6, N'Gia vị')
SET IDENTITY_INSERT [dbo].[LoaiNL] OFF
SET IDENTITY_INSERT [dbo].[NguyenLieu] ON 

INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [DonVi], [HSD], [Gia], [SoLuong], [MaLoaiNL]) VALUES (1, N'Ba chỉ heo', N'Kg', N'1 tháng', 120000, CAST(77 AS Decimal(3, 0)), 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [DonVi], [HSD], [Gia], [SoLuong], [MaLoaiNL]) VALUES (2, N'Dẻ sườn bò', N'Kg', N'2 tháng', 350000, CAST(23 AS Decimal(3, 0)), 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [DonVi], [HSD], [Gia], [SoLuong], [MaLoaiNL]) VALUES (3, N'Xà lách', N'Kg', N'2 tuần', 30000, CAST(60 AS Decimal(3, 0)), 3)
INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [DonVi], [HSD], [Gia], [SoLuong], [MaLoaiNL]) VALUES (4, N'Pepsi', N'Thùng', N'1 năm', 150000, CAST(46 AS Decimal(3, 0)), 5)
INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [DonVi], [HSD], [Gia], [SoLuong], [MaLoaiNL]) VALUES (5, N'Cà chua', N'Kg', N'3 tuần', 40000, CAST(37 AS Decimal(3, 0)), 3)
INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [DonVi], [HSD], [Gia], [SoLuong], [MaLoaiNL]) VALUES (6, N'7up', N'Thùng', N'1 năm', 160000, CAST(23 AS Decimal(3, 0)), 5)
SET IDENTITY_INSERT [dbo].[NguyenLieu] OFF
SET IDENTITY_INSERT [dbo].[PhieuNhap] ON 

INSERT [dbo].[PhieuNhap] ([MaPhieu], [NgayGio], [MaNV]) VALUES (3, CAST(0x0000A75B016B4389 AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[PhieuNhap] OFF
INSERT [dbo].[LoaiKH] ([MaLoai], [TenLoai], [TyLeChietKhau]) VALUES (1, N'Vãng lai', 0)
INSERT [dbo].[LoaiKH] ([MaLoai], [TenLoai], [TyLeChietKhau]) VALUES (2, N'Thân thiết', 0.1)
INSERT [dbo].[LoaiKH] ([MaLoai], [TenLoai], [TyLeChietKhau]) VALUES (3, N'VIP', 0.2)
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [CMND], [SoDT], [MaLoaiKH]) VALUES (1, N'Nguyễn Văn Lai', N'01234', NULL, 1)
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [CMND], [SoDT], [MaLoaiKH]) VALUES (2, N'Lê Văn Thiết', N'06789', NULL, 2)
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [CMND], [SoDT], [MaLoaiKH]) VALUES (5, N'Bùi Minh Víp', N'04321', NULL, 3)
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
INSERT [dbo].[CT_PhieuNhap] ([MaPhieu], [MaNL], [NhaCC], [GiaNhap], [SoLuong]) VALUES (3, 1, N'BigC', 120000, CAST(27 AS Decimal(3, 0)))
INSERT [dbo].[CT_PhieuNhap] ([MaPhieu], [MaNL], [NhaCC], [GiaNhap], [SoLuong]) VALUES (3, 2, N'BigC', 350000, CAST(23 AS Decimal(3, 0)))
INSERT [dbo].[CT_PhieuNhap] ([MaPhieu], [MaNL], [NhaCC], [GiaNhap], [SoLuong]) VALUES (3, 3, N'BigC', 30000, CAST(60 AS Decimal(3, 0)))
INSERT [dbo].[CT_PhieuNhap] ([MaPhieu], [MaNL], [NhaCC], [GiaNhap], [SoLuong]) VALUES (3, 4, N'BigC', 150000, CAST(46 AS Decimal(3, 0)))
INSERT [dbo].[CT_PhieuNhap] ([MaPhieu], [MaNL], [NhaCC], [GiaNhap], [SoLuong]) VALUES (3, 5, N'BigC', 40000, CAST(37 AS Decimal(3, 0)))
INSERT [dbo].[CT_PhieuNhap] ([MaPhieu], [MaNL], [NhaCC], [GiaNhap], [SoLuong]) VALUES (3, 6, N'BigC', 160000, CAST(23 AS Decimal(3, 0)))
