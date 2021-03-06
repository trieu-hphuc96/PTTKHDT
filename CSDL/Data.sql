USE [NhaHangDoNuong]
GO
DELETE FROM [dbo].[NhaCungCap]
GO
DELETE FROM [dbo].[CT_HoaDon]
GO
DELETE FROM [dbo].[CongThuc]
GO
DELETE FROM [dbo].[CT_PhieuDat]
GO
DELETE FROM [dbo].[HoaDon]
GO
DELETE FROM [dbo].[SanPham]
GO
DELETE FROM [dbo].[LoaiSP]
GO
DELETE FROM [dbo].[KhachHang]
GO
DELETE FROM [dbo].[LoaiKH]
GO
DELETE FROM [dbo].[CT_PhieuKiem]
GO
DELETE FROM [dbo].[PhieuKiem]
GO
DELETE FROM [dbo].[CT_PhieuNhap]
GO
DELETE FROM [dbo].[NhaCC]
GO
DELETE FROM [dbo].[NguyenLieu]
GO
DELETE FROM [dbo].[LoaiNL]
GO
DELETE FROM [dbo].[PhieuNhap]
GO
DELETE FROM [dbo].[PhieuDat]
GO
DELETE FROM [dbo].[NhanVien]
GO
DELETE FROM [dbo].[LoaiNV]
GO
INSERT [dbo].[LoaiNV] ([MaLoai], [TenLoai]) VALUES (1, N'Quản lý')
GO
INSERT [dbo].[LoaiNV] ([MaLoai], [TenLoai]) VALUES (2, N'Thu ngân')
GO
INSERT [dbo].[LoaiNV] ([MaLoai], [TenLoai]) VALUES (3, N'Phục vụ')
GO
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

GO
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [DiaChi], [CMND], [SoDT], [TenDangNhap], [MatKhau], [MaLoaiNV]) VALUES (1, N'Lê Văn Lý', CAST(0xC3150B00 AS Date), NULL, NULL, NULL, N'manager                         ', N'123456                          ', 1)
GO
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [DiaChi], [CMND], [SoDT], [TenDangNhap], [MatKhau], [MaLoaiNV]) VALUES (3, N'Nguyễn Thị Ngân', CAST(0x2B1A0B00 AS Date), NULL, NULL, NULL, N'casher                          ', N'123456                          ', 2)
GO
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [DiaChi], [CMND], [SoDT], [TenDangNhap], [MatKhau], [MaLoaiNV]) VALUES (6, N'Đào Minh Vụ', CAST(0xAD1F0B00 AS Date), NULL, NULL, NULL, NULL, NULL, 3)
GO
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
GO
SET IDENTITY_INSERT [dbo].[PhieuDat] ON 

GO
INSERT [dbo].[PhieuDat] ([MaPhieu], [MaNV], [NgayDat], [NgayGiao], [TinhTrang]) VALUES (1, 1, CAST(0x0000A76900DFB81E AS DateTime), CAST(0x0000A76900DF84AA AS DateTime), 2)
GO
INSERT [dbo].[PhieuDat] ([MaPhieu], [MaNV], [NgayDat], [NgayGiao], [TinhTrang]) VALUES (2, 1, CAST(0x0000A76900E11183 AS DateTime), CAST(0x0000A76900E09957 AS DateTime), 1)
GO
INSERT [dbo].[PhieuDat] ([MaPhieu], [MaNV], [NgayDat], [NgayGiao], [TinhTrang]) VALUES (3, 1, CAST(0x0000A76A000FF47E AS DateTime), CAST(0x0000A76A000FB8A9 AS DateTime), 1)
GO
INSERT [dbo].[PhieuDat] ([MaPhieu], [MaNV], [NgayDat], [NgayGiao], [TinhTrang]) VALUES (4, 1, CAST(0x0000A76E011259D6 AS DateTime), CAST(0x0000A77701121604 AS DateTime), 2)
GO
SET IDENTITY_INSERT [dbo].[PhieuDat] OFF
GO
SET IDENTITY_INSERT [dbo].[PhieuNhap] ON 

GO
INSERT [dbo].[PhieuNhap] ([MaPhieu], [MaPhieuDat], [MaNV], [NgayGio]) VALUES (1, 1, 1, CAST(0x0000A76900E13793 AS DateTime))
GO
INSERT [dbo].[PhieuNhap] ([MaPhieu], [MaPhieuDat], [MaNV], [NgayGio]) VALUES (2, 2, 1, CAST(0x0000A76900E26B94 AS DateTime))
GO
INSERT [dbo].[PhieuNhap] ([MaPhieu], [MaPhieuDat], [MaNV], [NgayGio]) VALUES (3, 3, 1, CAST(0x0000A76A00116A6A AS DateTime))
GO
INSERT [dbo].[PhieuNhap] ([MaPhieu], [MaPhieuDat], [MaNV], [NgayGio]) VALUES (4, 4, 1, CAST(0x0000A76E0112B163 AS DateTime))
GO
INSERT [dbo].[PhieuNhap] ([MaPhieu], [MaPhieuDat], [MaNV], [NgayGio]) VALUES (5, 4, 1, CAST(0x0000A76E0112CC68 AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[PhieuNhap] OFF
GO
SET IDENTITY_INSERT [dbo].[LoaiNL] ON 

GO
INSERT [dbo].[LoaiNL] ([MaLoai], [TenLoai]) VALUES (1, N'Thịt')
GO
INSERT [dbo].[LoaiNL] ([MaLoai], [TenLoai]) VALUES (2, N'Sữa')
GO
INSERT [dbo].[LoaiNL] ([MaLoai], [TenLoai]) VALUES (3, N'Rau củ quả')
GO
INSERT [dbo].[LoaiNL] ([MaLoai], [TenLoai]) VALUES (4, N'Đồ hộp')
GO
INSERT [dbo].[LoaiNL] ([MaLoai], [TenLoai]) VALUES (5, N'Nước đóng chai')
GO
INSERT [dbo].[LoaiNL] ([MaLoai], [TenLoai]) VALUES (6, N'Gia vị')
GO
INSERT [dbo].[LoaiNL] ([MaLoai], [TenLoai]) VALUES (7, N'Thịt viên')
GO
SET IDENTITY_INSERT [dbo].[LoaiNL] OFF
GO
SET IDENTITY_INSERT [dbo].[NguyenLieu] ON 

GO
INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [DonVi], [HSD], [Gia], [SoLuong], [MaLoaiNL]) VALUES (1, N'Ba chỉ heo', N'Kg', N'1 tháng', 120000, CAST(60.000 AS Decimal(18, 3)), 1)
GO
INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [DonVi], [HSD], [Gia], [SoLuong], [MaLoaiNL]) VALUES (2, N'Dẻ sườn bò', N'Kg', N'2 tháng', 350000, CAST(104.400 AS Decimal(18, 3)), 1)
GO
INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [DonVi], [HSD], [Gia], [SoLuong], [MaLoaiNL]) VALUES (3, N'Xà lách', N'Kg', N'2 tuần', 30000, CAST(151.000 AS Decimal(18, 3)), 3)
GO
INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [DonVi], [HSD], [Gia], [SoLuong], [MaLoaiNL]) VALUES (4, N'Pepsi', N'Thùng', N'1 năm', 150000, CAST(43.000 AS Decimal(18, 3)), 5)
GO
INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [DonVi], [HSD], [Gia], [SoLuong], [MaLoaiNL]) VALUES (5, N'Cà chua', N'Kg', N'3 tuần', 40000, CAST(116.500 AS Decimal(18, 3)), 3)
GO
INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [DonVi], [HSD], [Gia], [SoLuong], [MaLoaiNL]) VALUES (6, N'7up', N'Thùng', N'1 năm', 160000, CAST(60.500 AS Decimal(18, 3)), 5)
GO
INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [DonVi], [HSD], [Gia], [SoLuong], [MaLoaiNL]) VALUES (7, N'Xã', N'Kg', N'3 tuần', 10000, CAST(27.000 AS Decimal(18, 3)), 3)
GO
INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [DonVi], [HSD], [Gia], [SoLuong], [MaLoaiNL]) VALUES (8, N'Ớt', N'Kg', N'1 tuần', 15000, CAST(8.000 AS Decimal(18, 3)), 3)
GO
INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [DonVi], [HSD], [Gia], [SoLuong], [MaLoaiNL]) VALUES (9, N'Chanh', N'Kg', N'1 tháng', 30000, CAST(86.500 AS Decimal(18, 3)), 3)
GO
INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [DonVi], [HSD], [Gia], [SoLuong], [MaLoaiNL]) VALUES (10, N'Bia 333', N'Thùng', N'1 năm', 150000, CAST(5.000 AS Decimal(18, 3)), 5)
GO
INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [DonVi], [HSD], [Gia], [SoLuong], [MaLoaiNL]) VALUES (11, N'Bia Heineken', N'Thùng', N'1 năm', 200000, CAST(6.000 AS Decimal(18, 3)), 5)
GO
INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [DonVi], [HSD], [Gia], [SoLuong], [MaLoaiNL]) VALUES (12, N'Tôm sú tươi', N'Kg', N'1 tuần', 200000, CAST(10.000 AS Decimal(18, 3)), 1)
GO
INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [DonVi], [HSD], [Gia], [SoLuong], [MaLoaiNL]) VALUES (14, N'Cá viên', N'Bịch', N'2 tuần', 30000, CAST(20.000 AS Decimal(18, 3)), 7)
GO
INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [DonVi], [HSD], [Gia], [SoLuong], [MaLoaiNL]) VALUES (15, N'Bò viên', N'Bịch', N'2 tuần', 50000, CAST(70.400 AS Decimal(18, 3)), 7)
GO
INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [DonVi], [HSD], [Gia], [SoLuong], [MaLoaiNL]) VALUES (16, N'Tôm viên', N'Bịch', N'2 tuần', 40000, CAST(20.000 AS Decimal(18, 3)), 7)
GO
INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [DonVi], [HSD], [Gia], [SoLuong], [MaLoaiNL]) VALUES (17, N'Bạch tuộc tươi', N'Kg', N'1 tuần', 100000, CAST(10.000 AS Decimal(18, 3)), 1)
GO
INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [DonVi], [HSD], [Gia], [SoLuong], [MaLoaiNL]) VALUES (18, N'Cá đuối tươi', N'Kg', N'1 tuần', 100000, CAST(10.000 AS Decimal(18, 3)), 1)
GO
INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [DonVi], [HSD], [Gia], [SoLuong], [MaLoaiNL]) VALUES (19, N'Muối', N'Kg', N'3 tháng', 50000, CAST(20.000 AS Decimal(18, 3)), 6)
GO
SET IDENTITY_INSERT [dbo].[NguyenLieu] OFF
GO
SET IDENTITY_INSERT [dbo].[NhaCC] ON 

GO
INSERT [dbo].[NhaCC] ([MaNCC], [TenNCC]) VALUES (1, N'BigC')
GO
INSERT [dbo].[NhaCC] ([MaNCC], [TenNCC]) VALUES (2, N'Co.opmart')
GO
INSERT [dbo].[NhaCC] ([MaNCC], [TenNCC]) VALUES (3, N'FreshFoods')
GO
INSERT [dbo].[NhaCC] ([MaNCC], [TenNCC]) VALUES (4, N'GreenFoods')
GO
INSERT [dbo].[NhaCC] ([MaNCC], [TenNCC]) VALUES (5, N'Khác')
GO
SET IDENTITY_INSERT [dbo].[NhaCC] OFF
GO
INSERT [dbo].[CT_PhieuNhap] ([MaPhieu], [MaNL], [NhaCC], [GiaNhap], [SoLuongNhap], [SoLuongTra], [LyDo]) VALUES (1, 1, 1, 120000, CAST(50.000 AS Decimal(7, 3)), CAST(0.000 AS Decimal(7, 3)), N'')
GO
INSERT [dbo].[CT_PhieuNhap] ([MaPhieu], [MaNL], [NhaCC], [GiaNhap], [SoLuongNhap], [SoLuongTra], [LyDo]) VALUES (1, 2, 1, 350000, CAST(20.000 AS Decimal(7, 3)), CAST(0.000 AS Decimal(7, 3)), N'')
GO
INSERT [dbo].[CT_PhieuNhap] ([MaPhieu], [MaNL], [NhaCC], [GiaNhap], [SoLuongNhap], [SoLuongTra], [LyDo]) VALUES (1, 3, 1, 30000, CAST(30.000 AS Decimal(7, 3)), CAST(0.000 AS Decimal(7, 3)), N'')
GO
INSERT [dbo].[CT_PhieuNhap] ([MaPhieu], [MaNL], [NhaCC], [GiaNhap], [SoLuongNhap], [SoLuongTra], [LyDo]) VALUES (1, 4, 1, 150000, CAST(25.000 AS Decimal(7, 3)), CAST(0.000 AS Decimal(7, 3)), N'')
GO
INSERT [dbo].[CT_PhieuNhap] ([MaPhieu], [MaNL], [NhaCC], [GiaNhap], [SoLuongNhap], [SoLuongTra], [LyDo]) VALUES (1, 5, 1, 40000, CAST(25.500 AS Decimal(7, 3)), CAST(0.000 AS Decimal(7, 3)), N'')
GO
INSERT [dbo].[CT_PhieuNhap] ([MaPhieu], [MaNL], [NhaCC], [GiaNhap], [SoLuongNhap], [SoLuongTra], [LyDo]) VALUES (1, 6, 1, 160000, CAST(30.500 AS Decimal(7, 3)), CAST(0.000 AS Decimal(7, 3)), N'')
GO
INSERT [dbo].[CT_PhieuNhap] ([MaPhieu], [MaNL], [NhaCC], [GiaNhap], [SoLuongNhap], [SoLuongTra], [LyDo]) VALUES (1, 7, 4, 10000, CAST(19.000 AS Decimal(7, 3)), CAST(0.000 AS Decimal(7, 3)), N'')
GO
INSERT [dbo].[CT_PhieuNhap] ([MaPhieu], [MaNL], [NhaCC], [GiaNhap], [SoLuongNhap], [SoLuongTra], [LyDo]) VALUES (2, 4, 5, 150000, CAST(8.000 AS Decimal(7, 3)), CAST(2.000 AS Decimal(7, 3)), N'Thực phẩm không tươi')
GO
INSERT [dbo].[CT_PhieuNhap] ([MaPhieu], [MaNL], [NhaCC], [GiaNhap], [SoLuongNhap], [SoLuongTra], [LyDo]) VALUES (3, 5, 1, 40000, CAST(1.000 AS Decimal(7, 3)), CAST(0.000 AS Decimal(7, 3)), N'')
GO
INSERT [dbo].[CT_PhieuNhap] ([MaPhieu], [MaNL], [NhaCC], [GiaNhap], [SoLuongNhap], [SoLuongTra], [LyDo]) VALUES (3, 6, 4, 160000, CAST(20.000 AS Decimal(7, 3)), CAST(30.500 AS Decimal(7, 3)), N'Thực phẩm không tươi')
GO
INSERT [dbo].[CT_PhieuNhap] ([MaPhieu], [MaNL], [NhaCC], [GiaNhap], [SoLuongNhap], [SoLuongTra], [LyDo]) VALUES (3, 11, 4, 200000, CAST(1.000 AS Decimal(7, 3)), CAST(0.000 AS Decimal(7, 3)), N'')
GO
INSERT [dbo].[CT_PhieuNhap] ([MaPhieu], [MaNL], [NhaCC], [GiaNhap], [SoLuongNhap], [SoLuongTra], [LyDo]) VALUES (4, 2, 3, 350000, CAST(30.000 AS Decimal(7, 3)), CAST(0.000 AS Decimal(7, 3)), N'Chưa có hàng')
GO
INSERT [dbo].[CT_PhieuNhap] ([MaPhieu], [MaNL], [NhaCC], [GiaNhap], [SoLuongNhap], [SoLuongTra], [LyDo]) VALUES (4, 3, 3, 30000, CAST(57.000 AS Decimal(7, 3)), CAST(0.000 AS Decimal(7, 3)), N'')
GO
INSERT [dbo].[CT_PhieuNhap] ([MaPhieu], [MaNL], [NhaCC], [GiaNhap], [SoLuongNhap], [SoLuongTra], [LyDo]) VALUES (4, 9, 3, 30000, CAST(56.500 AS Decimal(7, 3)), CAST(0.000 AS Decimal(7, 3)), N'')
GO
INSERT [dbo].[CT_PhieuNhap] ([MaPhieu], [MaNL], [NhaCC], [GiaNhap], [SoLuongNhap], [SoLuongTra], [LyDo]) VALUES (4, 15, 1, 50000, CAST(20.000 AS Decimal(7, 3)), CAST(0.000 AS Decimal(7, 3)), N'Chưa có hàng')
GO
INSERT [dbo].[CT_PhieuNhap] ([MaPhieu], [MaNL], [NhaCC], [GiaNhap], [SoLuongNhap], [SoLuongTra], [LyDo]) VALUES (5, 2, 2, 350000, CAST(26.400 AS Decimal(7, 3)), CAST(0.000 AS Decimal(7, 3)), N'')
GO
INSERT [dbo].[CT_PhieuNhap] ([MaPhieu], [MaNL], [NhaCC], [GiaNhap], [SoLuongNhap], [SoLuongTra], [LyDo]) VALUES (5, 15, 5, 50000, CAST(30.400 AS Decimal(7, 3)), CAST(0.000 AS Decimal(7, 3)), N'')
GO
INSERT [dbo].[LoaiKH] ([MaLoai], [TenLoai], [TyLeChietKhau]) VALUES (1, N'Bình thường', 0)
GO
INSERT [dbo].[LoaiKH] ([MaLoai], [TenLoai], [TyLeChietKhau]) VALUES (2, N'Thân thiết', 0.1)
GO
INSERT [dbo].[LoaiKH] ([MaLoai], [TenLoai], [TyLeChietKhau]) VALUES (3, N'VIP', 0.2)
GO
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

GO
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [CMND], [SoDT], [MaLoaiKH], [DiemTichLuy]) VALUES (1, N'Nguyễn Văn Lai', N'01234', NULL, 1, 0)
GO
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [CMND], [SoDT], [MaLoaiKH], [DiemTichLuy]) VALUES (2, N'Lê Văn Thiết', N'06789', NULL, 2, 0)
GO
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [CMND], [SoDT], [MaLoaiKH], [DiemTichLuy]) VALUES (5, N'Bùi Minh Víp', N'04321', NULL, 3, 0)
GO
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [CMND], [SoDT], [MaLoaiKH], [DiemTichLuy]) VALUES (6, N'Thiết 2', N'054321', NULL, 3, 0)
GO
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
GO
INSERT [dbo].[LoaiSP] ([MaLoai], [TenLoai]) VALUES (1, N'Đồ uống')
GO
INSERT [dbo].[LoaiSP] ([MaLoai], [TenLoai]) VALUES (2, N'Xiên que')
GO
INSERT [dbo].[LoaiSP] ([MaLoai], [TenLoai]) VALUES (3, N'Món nướng')
GO
INSERT [dbo].[LoaiSP] ([MaLoai], [TenLoai]) VALUES (4, N'Khác')
GO
SET IDENTITY_INSERT [dbo].[SanPham] ON 

GO
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Gia], [MaLoaiSP]) VALUES (1, N'Pepsi', 10000, 1)
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Gia], [MaLoaiSP]) VALUES (2, N'Bia 333', 13000, 1)
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Gia], [MaLoaiSP]) VALUES (3, N'Bia Heineken', 16000, 1)
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Gia], [MaLoaiSP]) VALUES (4, N'Tôm nướng muối ớt', 10000, 2)
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Gia], [MaLoaiSP]) VALUES (5, N'Xiên cá ', 10000, 2)
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Gia], [MaLoaiSP]) VALUES (6, N'Xiên bò', 10000, 2)
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Gia], [MaLoaiSP]) VALUES (7, N'Xiên tôm', 10000, 2)
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Gia], [MaLoaiSP]) VALUES (8, N'Bạch tuộc nướng mọi', 50000, 3)
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Gia], [MaLoaiSP]) VALUES (9, N'Cá đuối nướng mọi', 50000, 3)
GO
SET IDENTITY_INSERT [dbo].[SanPham] OFF
GO
SET IDENTITY_INSERT [dbo].[HoaDon] ON 

GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (1, CAST(0xB03C0B00 AS Date), CAST(0x0730EE305DAD0000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (2, CAST(0xB03C0B00 AS Date), CAST(0x07909D9D5EAD0000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (3, CAST(0xB03C0B00 AS Date), CAST(0x07805B3965AD0000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (4, CAST(0xB03C0B00 AS Date), CAST(0x07904AE965AD0000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (5, CAST(0xB03C0B00 AS Date), CAST(0x07D01E68DAB40000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (6, CAST(0xB03C0B00 AS Date), CAST(0x073087D157B50000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (7, CAST(0xB03C0B00 AS Date), CAST(0x0770C33CB1B50000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (8, CAST(0xB03C0B00 AS Date), CAST(0x07603D81F8B50000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (9, CAST(0xB03C0B00 AS Date), CAST(0x07F0D76B51B60000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (10, CAST(0xB03C0B00 AS Date), CAST(0x07F01EFB8EB60000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (11, CAST(0xB03C0B00 AS Date), CAST(0x0760C2A0BCB60000 AS Time), 1, 5, 0.2)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (12, CAST(0xB03C0B00 AS Date), CAST(0x07D0D02E1BBA0000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (13, CAST(0xB03C0B00 AS Date), CAST(0x0790493A8BBA0000 AS Time), 1, 2, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (14, CAST(0xB03C0B00 AS Date), CAST(0x07B06CB58ABB0000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (15, CAST(0xB03C0B00 AS Date), CAST(0x074071DD39BE0000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (16, CAST(0xB03C0B00 AS Date), CAST(0x07D0DDC13ABE0000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (17, CAST(0xB03C0B00 AS Date), CAST(0x0780F85FD6BE0000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (18, CAST(0xB03C0B00 AS Date), CAST(0x070002D3A6BF0000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (19, CAST(0xB03C0B00 AS Date), CAST(0x07600964D9C10000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (20, CAST(0xB03C0B00 AS Date), CAST(0x0770F2DC00C40000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (21, CAST(0xB43C0B00 AS Date), CAST(0x0760AE81248C0000 AS Time), 1, 2, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (22, CAST(0xB43C0B00 AS Date), CAST(0x07F0F9A1C78D0000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (23, CAST(0xB93C0B00 AS Date), CAST(0x07A0184FF3540000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (24, CAST(0xB93C0B00 AS Date), CAST(0x07108350F4540000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (25, CAST(0xB93C0B00 AS Date), CAST(0x07806F6CF4540000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (26, CAST(0xB93C0B00 AS Date), CAST(0x0730020C4E550000 AS Time), 1, 2, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (27, CAST(0xB93C0B00 AS Date), CAST(0x07B0D2397A550000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (28, CAST(0xB93C0B00 AS Date), CAST(0x07F09C3795550000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (29, CAST(0xB93C0B00 AS Date), CAST(0x07E04F4CD8550000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (30, CAST(0xB93C0B00 AS Date), CAST(0x07302CE3A0560000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (31, CAST(0xB93C0B00 AS Date), CAST(0x07E0C82C8C570000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (32, CAST(0xB93C0B00 AS Date), CAST(0x0700FD8394580000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (33, CAST(0xB93C0B00 AS Date), CAST(0x0740142696580000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (34, CAST(0xB93C0B00 AS Date), CAST(0x07405C33EE5A0000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (35, CAST(0xB93C0B00 AS Date), CAST(0x07701797985C0000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (36, CAST(0xB93C0B00 AS Date), CAST(0x07F0676EC85C0000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (37, CAST(0xB93C0B00 AS Date), CAST(0x0790C8B6D35D0000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (38, CAST(0xB93C0B00 AS Date), CAST(0x0740630037610000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (39, CAST(0xBA3C0B00 AS Date), CAST(0x07E02F9BA7020000 AS Time), 1, 5, 0.2)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (40, CAST(0xBA3C0B00 AS Date), CAST(0x072049D5DC020000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (41, CAST(0xBA3C0B00 AS Date), CAST(0x07F05C0951030000 AS Time), 1, 5, 0.2)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (42, CAST(0xBA3C0B00 AS Date), CAST(0x0700B4AC73030000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (43, CAST(0xBA3C0B00 AS Date), CAST(0x07707D13E2030000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (44, CAST(0xBA3C0B00 AS Date), CAST(0x07702284EA030000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (45, CAST(0xBA3C0B00 AS Date), CAST(0x07F0C9BC6E060000 AS Time), 1, 5, 0.2)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (46, CAST(0xBA3C0B00 AS Date), CAST(0x07A0ACA3DE670000 AS Time), 1, 5, 0.2)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (47, CAST(0xBA3C0B00 AS Date), CAST(0x074028A8636D0000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (48, CAST(0xBA3C0B00 AS Date), CAST(0x0770F5DBAC750000 AS Time), 1, 5, 0.2)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (49, CAST(0xBA3C0B00 AS Date), CAST(0x07B0AB48BD750000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (50, CAST(0xBA3C0B00 AS Date), CAST(0x0730D439CE750000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (51, CAST(0xBA3C0B00 AS Date), CAST(0x07905A0DFB750000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (52, CAST(0xBB3C0B00 AS Date), CAST(0x07106CABA91F0000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (53, CAST(0xBB3C0B00 AS Date), CAST(0x071025CBB71F0000 AS Time), 1, 2, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (54, CAST(0xBB3C0B00 AS Date), CAST(0x07E00D2815200000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (55, CAST(0xBB3C0B00 AS Date), CAST(0x07F06754AF530000 AS Time), 1, 5, 0.2)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (56, CAST(0xBB3C0B00 AS Date), CAST(0x07F0B84F35540000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (57, CAST(0xBB3C0B00 AS Date), CAST(0x07106CAC50540000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (58, CAST(0xBB3C0B00 AS Date), CAST(0x07A0F3E676540000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (59, CAST(0xBB3C0B00 AS Date), CAST(0x07D08B62D6560000 AS Time), 1, 5, 0.2)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (60, CAST(0xBB3C0B00 AS Date), CAST(0x07B08A4BF0560000 AS Time), 1, 5, 0.2)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (61, CAST(0xBB3C0B00 AS Date), CAST(0x07908A5A86590000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (62, CAST(0xBB3C0B00 AS Date), CAST(0x07F0E0874C5A0000 AS Time), 1, 5, 0.2)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (63, CAST(0xBD3C0B00 AS Date), CAST(0x07901EF165040000 AS Time), 1, 5, 0.2)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (64, CAST(0xBD3C0B00 AS Date), CAST(0x073080B5C7040000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (65, CAST(0xBD3C0B00 AS Date), CAST(0x07301B80E4040000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (66, CAST(0xBD3C0B00 AS Date), CAST(0x0710B2BA0F050000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (67, CAST(0xBD3C0B00 AS Date), CAST(0x07D06A8E4F050000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (68, CAST(0xBF3C0B00 AS Date), CAST(0x07504A6652020000 AS Time), 1, 5, 0.2)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (69, CAST(0xC03C0B00 AS Date), CAST(0x07F013A24E920000 AS Time), 1, 5, 0.2)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (70, CAST(0xC03C0B00 AS Date), CAST(0x07105FE889C30000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (71, CAST(0xC03C0B00 AS Date), CAST(0x07900F9A93C30000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (72, CAST(0xC03C0B00 AS Date), CAST(0x0730FB71EEC30000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (73, CAST(0xC03C0B00 AS Date), CAST(0x07007CB644C40000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (74, CAST(0xC03C0B00 AS Date), CAST(0x0780D92D95C40000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (75, CAST(0xC03C0B00 AS Date), CAST(0x07802736D0C40000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (76, CAST(0xC03C0B00 AS Date), CAST(0x07F0A29565C60000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (77, CAST(0xC03C0B00 AS Date), CAST(0x0710E10FDDC60000 AS Time), 1, 2, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (78, CAST(0xC13C0B00 AS Date), CAST(0x07B0AEE508940000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (79, CAST(0xC43C0B00 AS Date), CAST(0x0720027ED1060000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (80, CAST(0xC43C0B00 AS Date), CAST(0x07D021DC680A0000 AS Time), 3, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (81, CAST(0xC43C0B00 AS Date), CAST(0x072057A28A3D0000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (82, CAST(0xC83C0B00 AS Date), CAST(0x0720F8F8A0980000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (83, CAST(0xC83C0B00 AS Date), CAST(0x07D035947AA40000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (84, CAST(0xC83C0B00 AS Date), CAST(0x07E02C5DC3A40000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (85, CAST(0xC83C0B00 AS Date), CAST(0x07A03B1B27A50000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (86, CAST(0xC83C0B00 AS Date), CAST(0x07D0B6FF69A50000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (87, CAST(0xC83C0B00 AS Date), CAST(0x07804163E9A50000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (88, CAST(0xC83C0B00 AS Date), CAST(0x071037E423A60000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (89, CAST(0xC83C0B00 AS Date), CAST(0x07204B4D55A60000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (90, CAST(0xC83C0B00 AS Date), CAST(0x0770DC2DB6A60000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (91, CAST(0xC83C0B00 AS Date), CAST(0x0710541219A70000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (92, CAST(0xC83C0B00 AS Date), CAST(0x07902C8E99A70000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (93, CAST(0xC83C0B00 AS Date), CAST(0x0710A3FFD1A70000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (94, CAST(0xC83C0B00 AS Date), CAST(0x07B0C7036DA80000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (95, CAST(0xC83C0B00 AS Date), CAST(0x070032F697A80000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (96, CAST(0xC83C0B00 AS Date), CAST(0x07F05E05A8A80000 AS Time), 1, 6, 0.2)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (97, CAST(0xC83C0B00 AS Date), CAST(0x0790448A10A90000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (98, CAST(0xC83C0B00 AS Date), CAST(0x0770DD1E26A90000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (99, CAST(0xC83C0B00 AS Date), CAST(0x07D094D97BA90000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (100, CAST(0xC83C0B00 AS Date), CAST(0x07601D0C8BA90000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (101, CAST(0xC83C0B00 AS Date), CAST(0x07E0F932A3A90000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (102, CAST(0xC83C0B00 AS Date), CAST(0x07A00CD1AAA90000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (103, CAST(0xC83C0B00 AS Date), CAST(0x072000F2B1A90000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (104, CAST(0xC83C0B00 AS Date), CAST(0x0720BB99CCA90000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (105, CAST(0xC83C0B00 AS Date), CAST(0x0770FD1A81AA0000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (106, CAST(0xC83C0B00 AS Date), CAST(0x0770ABFD95AA0000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (107, CAST(0xC83C0B00 AS Date), CAST(0x077043962DAB0000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (108, CAST(0xC83C0B00 AS Date), CAST(0x07F0BD55C8AB0000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (109, CAST(0xC83C0B00 AS Date), CAST(0x07F0290DE6AB0000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (110, CAST(0xC83C0B00 AS Date), CAST(0x075049BB5DAC0000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (111, CAST(0xC83C0B00 AS Date), CAST(0x0770CDE67EAC0000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (112, CAST(0xC83C0B00 AS Date), CAST(0x07D0633DF0AC0000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (113, CAST(0xC83C0B00 AS Date), CAST(0x07E000940FAD0000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (114, CAST(0xC83C0B00 AS Date), CAST(0x07F07FB58BAD0000 AS Time), 1, 6, 0.2)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (115, CAST(0xC83C0B00 AS Date), CAST(0x07E001E5F8AD0000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (116, CAST(0xC83C0B00 AS Date), CAST(0x07B0AF151DAE0000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (117, CAST(0xC83C0B00 AS Date), CAST(0x07709E42A0AE0000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (118, CAST(0xC83C0B00 AS Date), CAST(0x0770E339AAAE0000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (119, CAST(0xC83C0B00 AS Date), CAST(0x077025A3EAAE0000 AS Time), 1, 6, 0.2)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (120, CAST(0xC83C0B00 AS Date), CAST(0x07D003B43BAF0000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (121, CAST(0xC83C0B00 AS Date), CAST(0x0770A8564AAF0000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (122, CAST(0xC83C0B00 AS Date), CAST(0x07707911F4B00000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (123, CAST(0xC83C0B00 AS Date), CAST(0x07E0B09F8AB20000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (124, CAST(0xC93C0B00 AS Date), CAST(0x07607FC57F850000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (125, CAST(0xC93C0B00 AS Date), CAST(0x07901D81F5850000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (126, CAST(0xC93C0B00 AS Date), CAST(0x0750D514D5860000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (127, CAST(0xC93C0B00 AS Date), CAST(0x07D07672E2860000 AS Time), 1, 1, 0)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (128, CAST(0xC93C0B00 AS Date), CAST(0x0710069B71870000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (129, CAST(0xC93C0B00 AS Date), CAST(0x0700FEC175880000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (130, CAST(0xC93C0B00 AS Date), CAST(0x0710B548AF880000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (131, CAST(0xC93C0B00 AS Date), CAST(0x0720686CC8880000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (132, CAST(0xC93C0B00 AS Date), CAST(0x07E0F521DC8A0000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (133, CAST(0xC93C0B00 AS Date), CAST(0x0730CF3BF38A0000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (134, CAST(0xC93C0B00 AS Date), CAST(0x0770C1902F8B0000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (135, CAST(0xC93C0B00 AS Date), CAST(0x07E05416478B0000 AS Time), 1, 6, 0.1)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [Gio], [MaNV], [MaKH], [TiLeChietKhau]) VALUES (136, CAST(0xC93C0B00 AS Date), CAST(0x0760DDF1588B0000 AS Time), 1, 6, 0.1)
GO
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
GO
INSERT [dbo].[CT_PhieuDat] ([MaPhieu], [MaNL], [SoLuongDat], [SoLuongDaNhap]) VALUES (1, 1, CAST(50.000 AS Decimal(7, 3)), CAST(50.000 AS Decimal(7, 3)))
GO
INSERT [dbo].[CT_PhieuDat] ([MaPhieu], [MaNL], [SoLuongDat], [SoLuongDaNhap]) VALUES (1, 2, CAST(20.000 AS Decimal(7, 3)), CAST(20.000 AS Decimal(7, 3)))
GO
INSERT [dbo].[CT_PhieuDat] ([MaPhieu], [MaNL], [SoLuongDat], [SoLuongDaNhap]) VALUES (1, 3, CAST(30.000 AS Decimal(7, 3)), CAST(30.000 AS Decimal(7, 3)))
GO
INSERT [dbo].[CT_PhieuDat] ([MaPhieu], [MaNL], [SoLuongDat], [SoLuongDaNhap]) VALUES (1, 4, CAST(25.000 AS Decimal(7, 3)), CAST(25.000 AS Decimal(7, 3)))
GO
INSERT [dbo].[CT_PhieuDat] ([MaPhieu], [MaNL], [SoLuongDat], [SoLuongDaNhap]) VALUES (1, 5, CAST(25.500 AS Decimal(7, 3)), CAST(25.500 AS Decimal(7, 3)))
GO
INSERT [dbo].[CT_PhieuDat] ([MaPhieu], [MaNL], [SoLuongDat], [SoLuongDaNhap]) VALUES (1, 6, CAST(30.500 AS Decimal(7, 3)), CAST(30.500 AS Decimal(7, 3)))
GO
INSERT [dbo].[CT_PhieuDat] ([MaPhieu], [MaNL], [SoLuongDat], [SoLuongDaNhap]) VALUES (1, 7, CAST(19.000 AS Decimal(7, 3)), CAST(19.000 AS Decimal(7, 3)))
GO
INSERT [dbo].[CT_PhieuDat] ([MaPhieu], [MaNL], [SoLuongDat], [SoLuongDaNhap]) VALUES (2, 4, CAST(10.000 AS Decimal(7, 3)), CAST(8.000 AS Decimal(7, 3)))
GO
INSERT [dbo].[CT_PhieuDat] ([MaPhieu], [MaNL], [SoLuongDat], [SoLuongDaNhap]) VALUES (3, 5, CAST(1.000 AS Decimal(7, 3)), CAST(1.000 AS Decimal(7, 3)))
GO
INSERT [dbo].[CT_PhieuDat] ([MaPhieu], [MaNL], [SoLuongDat], [SoLuongDaNhap]) VALUES (3, 6, CAST(50.500 AS Decimal(7, 3)), CAST(20.000 AS Decimal(7, 3)))
GO
INSERT [dbo].[CT_PhieuDat] ([MaPhieu], [MaNL], [SoLuongDat], [SoLuongDaNhap]) VALUES (3, 11, CAST(1.000 AS Decimal(7, 3)), CAST(1.000 AS Decimal(7, 3)))
GO
INSERT [dbo].[CT_PhieuDat] ([MaPhieu], [MaNL], [SoLuongDat], [SoLuongDaNhap]) VALUES (4, 2, CAST(56.400 AS Decimal(7, 3)), CAST(56.400 AS Decimal(7, 3)))
GO
INSERT [dbo].[CT_PhieuDat] ([MaPhieu], [MaNL], [SoLuongDat], [SoLuongDaNhap]) VALUES (4, 3, CAST(57.000 AS Decimal(7, 3)), CAST(57.000 AS Decimal(7, 3)))
GO
INSERT [dbo].[CT_PhieuDat] ([MaPhieu], [MaNL], [SoLuongDat], [SoLuongDaNhap]) VALUES (4, 9, CAST(56.500 AS Decimal(7, 3)), CAST(56.500 AS Decimal(7, 3)))
GO
INSERT [dbo].[CT_PhieuDat] ([MaPhieu], [MaNL], [SoLuongDat], [SoLuongDaNhap]) VALUES (4, 15, CAST(50.400 AS Decimal(7, 3)), CAST(50.400 AS Decimal(7, 3)))
GO
INSERT [dbo].[CongThuc] ([MaSP], [MaNL], [Luong]) VALUES (1, 4, CAST(0.420 AS Decimal(18, 3)))
GO
INSERT [dbo].[CongThuc] ([MaSP], [MaNL], [Luong]) VALUES (2, 10, CAST(0.420 AS Decimal(18, 3)))
GO
INSERT [dbo].[CongThuc] ([MaSP], [MaNL], [Luong]) VALUES (3, 11, CAST(0.420 AS Decimal(18, 3)))
GO
INSERT [dbo].[CongThuc] ([MaSP], [MaNL], [Luong]) VALUES (4, 8, CAST(0.001 AS Decimal(18, 3)))
GO
INSERT [dbo].[CongThuc] ([MaSP], [MaNL], [Luong]) VALUES (4, 12, CAST(0.500 AS Decimal(18, 3)))
GO
INSERT [dbo].[CongThuc] ([MaSP], [MaNL], [Luong]) VALUES (4, 19, CAST(0.002 AS Decimal(18, 3)))
GO
INSERT [dbo].[CongThuc] ([MaSP], [MaNL], [Luong]) VALUES (5, 14, CAST(0.040 AS Decimal(18, 3)))
GO
INSERT [dbo].[CongThuc] ([MaSP], [MaNL], [Luong]) VALUES (6, 15, CAST(0.040 AS Decimal(18, 3)))
GO
INSERT [dbo].[CongThuc] ([MaSP], [MaNL], [Luong]) VALUES (7, 16, CAST(0.040 AS Decimal(18, 3)))
GO
INSERT [dbo].[CongThuc] ([MaSP], [MaNL], [Luong]) VALUES (8, 17, CAST(0.500 AS Decimal(18, 3)))
GO
INSERT [dbo].[CongThuc] ([MaSP], [MaNL], [Luong]) VALUES (9, 18, CAST(0.500 AS Decimal(18, 3)))
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (1, 1, 1, 300)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (10, 8, 3, 50000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (10, 9, 3, 50000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (11, 8, 3, 50000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (11, 9, 3, 50000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (18, 9, 10, 50000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (19, 6, 7, 10000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (21, 2, 25, 13000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (21, 3, 20, 16000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (21, 5, 20, 10000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (21, 7, 20, 10000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (32, 6, 5, 10000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (33, 9, 10, 50000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (35, 7, 8, 10000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (36, 1, 6, 10000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (39, 1, 100, 10000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (39, 2, 100, 13000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (39, 3, 100, 16000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (39, 5, 100, 10000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (39, 6, 100, 10000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (39, 7, 100, 10000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (39, 8, 100, 50000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (39, 9, 100, 50000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (40, 1, 100, 10000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (40, 2, 100, 13000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (40, 3, 100, 16000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (40, 5, 100, 10000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (40, 6, 100, 10000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (40, 7, 100, 10000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (40, 8, 100, 50000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (40, 9, 100, 50000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (41, 1, 100, 10000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (41, 2, 100, 13000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (41, 3, 100, 16000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (41, 5, 100, 10000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (41, 6, 100, 10000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (41, 7, 100, 10000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (41, 8, 100, 50000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (41, 9, 100, 50000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (43, 5, 100, 10000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (43, 6, 100, 10000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (43, 7, 100, 10000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (43, 8, 200, 50000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (43, 9, 100, 50000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (45, 1, 100, 10000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (45, 2, 100, 13000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (45, 3, 100, 16000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (45, 7, 100, 10000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (46, 8, 1000, 50000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (53, 8, 12, 50000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (59, 9, 21, 50000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (60, 5, 100, 10000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (60, 6, 100, 10000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (60, 7, 100, 10000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (60, 8, 100, 50000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (60, 9, 100, 50000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (62, 6, 500, 10000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (63, 7, 10, 10000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (63, 8, 10, 50000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (76, 8, 100, 50000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (77, 3, 10, 16000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (77, 7, 1, 10000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (77, 9, 100, 50000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (78, 7, 100, 10000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (78, 8, 100, 50000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (78, 9, 100, 50000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (79, 8, 100, 50000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (81, 7, 1, 10000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (81, 8, 101, 50000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (81, 9, 1, 50000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (82, 9, 10, 50000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (88, 9, 150, 50000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (89, 9, 150, 50000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (90, 9, 160, 50000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (91, 9, 150, 50000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (92, 8, 100, 50000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (95, 9, 100, 50000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (97, 6, 100, 10000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (98, 8, 150, 50000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (99, 9, 50, 50000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (105, 9, 100, 50000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (115, 9, 1, 50000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (121, 9, 100, 50000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (125, 9, 500, 50000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (130, 7, 600, 10000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (130, 9, 1, 50000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (131, 8, 500, 50000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (132, 7, 400, 10000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (133, 7, 500, 10000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (134, 6, 500, 10000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (135, 7, 1, 10000)
GO
INSERT [dbo].[CT_HoaDon] ([MaHD], [MaSP], [SoLuong], [GiaBan]) VALUES (136, 7, 200, 10000)
GO
