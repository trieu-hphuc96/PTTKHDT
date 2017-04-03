USE [NhaHangDoNuong]
GO
INSERT [dbo].[LoaiKH] ([MaLoai], [TenLoai], [TyLeChietKhau]) VALUES (1, N'Vãng lai', 0)
INSERT [dbo].[LoaiKH] ([MaLoai], [TenLoai], [TyLeChietKhau]) VALUES (2, N'Thân thiết', 0.1)
INSERT [dbo].[LoaiKH] ([MaLoai], [TenLoai], [TyLeChietKhau]) VALUES (3, N'VIP', 0.2)
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [CMND], [SoDT], [MaLoaiKH]) VALUES (1, N'Nguyễn Văn Lai', N'01234', NULL, 1)
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [CMND], [SoDT], [MaLoaiKH]) VALUES (2, N'Lê Văn Thiết', N'06789', NULL, 2)
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [CMND], [SoDT], [MaLoaiKH]) VALUES (5, N'Bùi Minh Víp', N'04321', NULL, 3)
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
INSERT [dbo].[LoaiNV] ([MaLoai], [TenLoai]) VALUES (1, N'Quản lý')
INSERT [dbo].[LoaiNV] ([MaLoai], [TenLoai]) VALUES (2, N'Thu ngân')
INSERT [dbo].[LoaiNV] ([MaLoai], [TenLoai]) VALUES (3, N'Phục vụ')
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [DiaChi], [CMND], [SoDT], [MatKhau], [MaLoaiNV]) VALUES (1, N'Lê Văn Lý', CAST(0xC3150B00 AS Date), NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [DiaChi], [CMND], [SoDT], [MatKhau], [MaLoaiNV]) VALUES (3, N'Nguyễn Thị Ngân', CAST(0x2B1A0B00 AS Date), NULL, NULL, NULL, NULL, 2)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [DiaChi], [CMND], [SoDT], [MatKhau], [MaLoaiNV]) VALUES (6, N'Đào Minh Vụ', CAST(0xAD1F0B00 AS Date), NULL, NULL, NULL, NULL, 3)
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
SET IDENTITY_INSERT [dbo].[LoaiNL] ON 

INSERT [dbo].[LoaiNL] ([MaLoai], [TenLoai]) VALUES (1, N'Thịt')
INSERT [dbo].[LoaiNL] ([MaLoai], [TenLoai]) VALUES (2, N'Sữa')
INSERT [dbo].[LoaiNL] ([MaLoai], [TenLoai]) VALUES (3, N'Rau')
INSERT [dbo].[LoaiNL] ([MaLoai], [TenLoai]) VALUES (4, N'Đồ hộp')
INSERT [dbo].[LoaiNL] ([MaLoai], [TenLoai]) VALUES (5, N'Nước đóng chai')
INSERT [dbo].[LoaiNL] ([MaLoai], [TenLoai]) VALUES (6, N'Gia vị')
SET IDENTITY_INSERT [dbo].[LoaiNL] OFF
SET IDENTITY_INSERT [dbo].[NguyenLieu] ON 

INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [Gia], [SoLuong], [DonVi], [HSD], [MaLoaiNL]) VALUES (1, N'Ba chỉ heo', 120000, 0, N'Kg', N'1 tháng', 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [Gia], [SoLuong], [DonVi], [HSD], [MaLoaiNL]) VALUES (2, N'Dẻ sườn bò', 350000, 0, N'Kg', N'2 tháng', 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [Gia], [SoLuong], [DonVi], [HSD], [MaLoaiNL]) VALUES (3, N'Xà lách', 30000, 0, N'Kg', N'2 tuần', 3)
INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [Gia], [SoLuong], [DonVi], [HSD], [MaLoaiNL]) VALUES (4, N'Pepsi', 150000, 0, N'Thùng', N'1 năm', 5)
INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [Gia], [SoLuong], [DonVi], [HSD], [MaLoaiNL]) VALUES (5, N'Cà chua', 40000, 0, N'Kg', N'3 tuần', 3)
INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [Gia], [SoLuong], [DonVi], [HSD], [MaLoaiNL]) VALUES (6, N'7up', 160000, 0, N'Thùng', N'1 năm', 5)
SET IDENTITY_INSERT [dbo].[NguyenLieu] OFF
