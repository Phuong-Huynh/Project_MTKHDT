USE [MyStudent]
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([Id], [RoleName]) VALUES (1, N'hoc_sinh')
INSERT [dbo].[Roles] ([Id], [RoleName]) VALUES (2, N'giao_vien')
INSERT [dbo].[Roles] ([Id], [RoleName]) VALUES (3, N'Admin')
SET IDENTITY_INSERT [dbo].[Roles] OFF
SET IDENTITY_INSERT [dbo].[TaiKhoans] ON 

INSERT [dbo].[TaiKhoans] ([Id], [UserName], [Password], [RoleID]) VALUES (1, N'aaa', N'123456', 1)
INSERT [dbo].[TaiKhoans] ([Id], [UserName], [Password], [RoleID]) VALUES (2, N'bbb', N'123456', 2)
INSERT [dbo].[TaiKhoans] ([Id], [UserName], [Password], [RoleID]) VALUES (3, N'ccc', N'123456', 3)
INSERT [dbo].[TaiKhoans] ([Id], [UserName], [Password], [RoleID]) VALUES (4, N'bbb1', N'123456', 2)
INSERT [dbo].[TaiKhoans] ([Id], [UserName], [Password], [RoleID]) VALUES (5, N'aaa1', N'123456', 1)
SET IDENTITY_INSERT [dbo].[TaiKhoans] OFF
SET IDENTITY_INSERT [dbo].[MonHocs] ON 

INSERT [dbo].[MonHocs] ([Id], [TenMonHoc], [SoTinChi], [SoTiet]) VALUES (1, N'Toán tích', 4, 20)
INSERT [dbo].[MonHocs] ([Id], [TenMonHoc], [SoTinChi], [SoTiet]) VALUES (2, N'Toán rời rạc', 4, 20)
INSERT [dbo].[MonHocs] ([Id], [TenMonHoc], [SoTinChi], [SoTiet]) VALUES (3, N'Lập trình hướng đối tượng', 5, 25)
INSERT [dbo].[MonHocs] ([Id], [TenMonHoc], [SoTinChi], [SoTiet]) VALUES (4, N'HQTCSDL NC', 3, 15)
INSERT [dbo].[MonHocs] ([Id], [TenMonHoc], [SoTinChi], [SoTiet]) VALUES (5, N'HQT CSDL', 4, 20)
SET IDENTITY_INSERT [dbo].[MonHocs] OFF
SET IDENTITY_INSERT [dbo].[GiangViens] ON 

INSERT [dbo].[GiangViens] ([Id], [HoTen], [NgaySinh], [DiaChi], [MonHocID], [TaiKhoanID]) VALUES (2, N'Nguyen Van Phu', CAST(0x351A0B00 AS Date), N'12, Nguyen Van Cu', 2, 2)
INSERT [dbo].[GiangViens] ([Id], [HoTen], [NgaySinh], [DiaChi], [MonHocID], [TaiKhoanID]) VALUES (3, N'Truong Minh Giang', CAST(0x5A1B0B00 AS Date), N'23, Ngyen Thuy', 3, 4)
SET IDENTITY_INSERT [dbo].[GiangViens] OFF
SET IDENTITY_INSERT [dbo].[HocKis] ON 

INSERT [dbo].[HocKis] ([Id], [TenHK], [BatDau], [KetThuc]) VALUES (1, N'I         ', CAST(0x76390B00 AS Date), CAST(0xD0390B00 AS Date))
INSERT [dbo].[HocKis] ([Id], [TenHK], [BatDau], [KetThuc]) VALUES (3, N'II        ', CAST(0x613A0B00 AS Date), CAST(0xBC3A0B00 AS Date))
SET IDENTITY_INSERT [dbo].[HocKis] OFF
SET IDENTITY_INSERT [dbo].[CTHocKis] ON 

INSERT [dbo].[CTHocKis] ([Id], [PhongHoc], [NgayHoc], [GioHoc], [HocKiID], [GiangVienID]) VALUES (7, N'R1', CAST(0x743A0B00 AS Date), N'31/12/2015', 3,  2)
INSERT [dbo].[CTHocKis] ([Id], [PhongHoc], [NgayHoc], [GioHoc], [HocKiID], [GiangVienID]) VALUES (11, N'R2', CAST(0x743A0B00 AS Date), N'31/12/2015', 3, 3)
INSERT [dbo].[CTHocKis] ([Id], [PhongHoc], [NgayHoc], [GioHoc], [HocKiID], [GiangVienID]) VALUES (12, N'R3', CAST(0x743A0B00 AS Date), N'31/12/2015', 3, 2)
INSERT [dbo].[CTHocKis] ([Id], [PhongHoc], [NgayHoc], [GioHoc], [HocKiID], [GiangVienID]) VALUES (15, N'R4', CAST(0x7D3A0B00 AS Date), N'31/12/2015', 3, 2)
SET IDENTITY_INSERT [dbo].[CTHocKis] OFF
SET IDENTITY_INSERT [dbo].[Lops] ON 

INSERT [dbo].[Lops] ([Id], [TenLop]) VALUES (1, N'A1')
INSERT [dbo].[Lops] ([Id], [TenLop]) VALUES (2, N'A2')
INSERT [dbo].[Lops] ([Id], [TenLop]) VALUES (3, N'A3')
SET IDENTITY_INSERT [dbo].[Lops] OFF
SET IDENTITY_INSERT [dbo].[HocSinhs] ON 

INSERT [dbo].[HocSinhs] ([Id], [MSSV], [HoTen], [NgaySinh], [DiaChi], [LopID], [TaiKhoanID]) VALUES (1, N'1112223', N'Huynh Duy Tien', CAST(0x7C1E0B00 AS Date), N'43, Ngo GIa Tu', 1, 1)
INSERT [dbo].[HocSinhs] ([Id], [MSSV], [HoTen], [NgaySinh], [DiaChi], [LopID], [TaiKhoanID]) VALUES (2, N'1112224', N'Do Tieng Trong', CAST(0xB81E0B00 AS Date), N'12, Nguyen Van Cu', 1, 5)
SET IDENTITY_INSERT [dbo].[HocSinhs] OFF
