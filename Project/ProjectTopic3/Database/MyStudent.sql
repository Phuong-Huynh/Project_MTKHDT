USE [master]
GO
/****** Object:  Database [MyStudent]    Script Date: 06/15/2015 17:17:24 ******/
CREATE DATABASE [MyStudent] GO
ALTER DATABASE [MyStudent] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MyStudent].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MyStudent] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [MyStudent] SET ANSI_NULLS OFF
GO
ALTER DATABASE [MyStudent] SET ANSI_PADDING OFF
GO
ALTER DATABASE [MyStudent] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [MyStudent] SET ARITHABORT OFF
GO
ALTER DATABASE [MyStudent] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [MyStudent] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [MyStudent] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [MyStudent] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [MyStudent] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [MyStudent] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [MyStudent] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [MyStudent] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [MyStudent] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [MyStudent] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [MyStudent] SET  DISABLE_BROKER
GO
ALTER DATABASE [MyStudent] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [MyStudent] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [MyStudent] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [MyStudent] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [MyStudent] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [MyStudent] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [MyStudent] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [MyStudent] SET  READ_WRITE
GO
ALTER DATABASE [MyStudent] SET RECOVERY SIMPLE
GO
ALTER DATABASE [MyStudent] SET  MULTI_USER
GO
ALTER DATABASE [MyStudent] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [MyStudent] SET DB_CHAINING OFF
GO
USE [MyStudent]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 06/15/2015 17:17:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](15) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 06/15/2015 17:17:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TenMonHoc] [nvarchar](50) NULL,
	[SoTinChi] [int] NULL,
	[SoTiet] [int] NULL,
 CONSTRAINT [PK_MonHoc] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 06/15/2015 17:17:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TenLop] [nvarchar](20) NULL,
 CONSTRAINT [PK_Lop] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HocKi]    Script Date: 06/15/2015 17:17:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocKi](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TenHK] [nchar](10) NOT NULL,
	[BatDau] [date] NOT NULL,
	[KetThuc] [date] NOT NULL,
 CONSTRAINT [PK_HocKi] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 06/15/2015 17:17:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[IdRole] [int] NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HocSinh]    Script Date: 06/15/2015 17:17:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocSinh](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MSSV] [nvarchar](20) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](70) NULL,
	[IdLop] [int] NOT NULL,
	[IdTaiKhoan] [int] NOT NULL,
 CONSTRAINT [PK_HocSinh] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiangVien]    Script Date: 06/15/2015 17:17:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiangVien](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](70) NULL,
	[IdMonHoc] [int] NULL,
	[IdTaiKhoan] [int] NOT NULL,
 CONSTRAINT [PK_GiangVien] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTHocKi]    Script Date: 06/15/2015 17:17:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHocKi](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PhongHoc] [nvarchar](15) NOT NULL,
	[NgayHoc] [date] NOT NULL,
	[GioHoc] [nvarchar](50) NOT NULL,
	[IdHocKi] [int] NOT NULL,
	[IdMonHoc] [int] NOT NULL,
	[IdGiangVien] [int] NOT NULL,
 CONSTRAINT [PK_CTHocKi] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TongKetHK]    Script Date: 06/15/2015 17:17:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TongKetHK](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdHocSinh] [int] NULL,
	[IdHocKi] [int] NULL,
	[DiemTB] [int] NULL,
 CONSTRAINT [PK_TongKetHK] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TKB]    Script Date: 06/15/2015 17:17:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TKB](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdHocSinh] [int] NOT NULL,
	[IdCTHocKi] [int] NOT NULL,
	[Diem] [int] NULL,
 CONSTRAINT [PK_TKB] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_TaiKhoan_Role]    Script Date: 06/15/2015 17:17:26 ******/
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_Role] FOREIGN KEY([IdRole])
REFERENCES [dbo].[Role] ([Id])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_Role]
GO
/****** Object:  ForeignKey [FK_HocSinh_Lop]    Script Date: 06/15/2015 17:17:26 ******/
ALTER TABLE [dbo].[HocSinh]  WITH CHECK ADD  CONSTRAINT [FK_HocSinh_Lop] FOREIGN KEY([IdLop])
REFERENCES [dbo].[Lop] ([Id])
GO
ALTER TABLE [dbo].[HocSinh] CHECK CONSTRAINT [FK_HocSinh_Lop]
GO
/****** Object:  ForeignKey [FK_HocSinh_TaiKhoan]    Script Date: 06/15/2015 17:17:26 ******/
ALTER TABLE [dbo].[HocSinh]  WITH CHECK ADD  CONSTRAINT [FK_HocSinh_TaiKhoan] FOREIGN KEY([IdTaiKhoan])
REFERENCES [dbo].[TaiKhoan] ([Id])
GO
ALTER TABLE [dbo].[HocSinh] CHECK CONSTRAINT [FK_HocSinh_TaiKhoan]
GO
/****** Object:  ForeignKey [FK_GiangVien_MonHoc]    Script Date: 06/15/2015 17:17:26 ******/
ALTER TABLE [dbo].[GiangVien]  WITH CHECK ADD  CONSTRAINT [FK_GiangVien_MonHoc] FOREIGN KEY([IdMonHoc])
REFERENCES [dbo].[MonHoc] ([Id])
GO
ALTER TABLE [dbo].[GiangVien] CHECK CONSTRAINT [FK_GiangVien_MonHoc]
GO
/****** Object:  ForeignKey [FK_GiangVien_TaiKhoan]    Script Date: 06/15/2015 17:17:26 ******/
ALTER TABLE [dbo].[GiangVien]  WITH CHECK ADD  CONSTRAINT [FK_GiangVien_TaiKhoan] FOREIGN KEY([IdTaiKhoan])
REFERENCES [dbo].[TaiKhoan] ([Id])
GO
ALTER TABLE [dbo].[GiangVien] CHECK CONSTRAINT [FK_GiangVien_TaiKhoan]
GO
/****** Object:  ForeignKey [FK_CTHocKi_GiangVien]    Script Date: 06/15/2015 17:17:26 ******/
ALTER TABLE [dbo].[CTHocKi]  WITH CHECK ADD  CONSTRAINT [FK_CTHocKi_GiangVien] FOREIGN KEY([IdGiangVien])
REFERENCES [dbo].[GiangVien] ([Id])
GO
ALTER TABLE [dbo].[CTHocKi] CHECK CONSTRAINT [FK_CTHocKi_GiangVien]
GO
/****** Object:  ForeignKey [FK_CTHocKi_HocKi]    Script Date: 06/15/2015 17:17:26 ******/
ALTER TABLE [dbo].[CTHocKi]  WITH CHECK ADD  CONSTRAINT [FK_CTHocKi_HocKi] FOREIGN KEY([IdHocKi])
REFERENCES [dbo].[HocKi] ([Id])
GO
ALTER TABLE [dbo].[CTHocKi] CHECK CONSTRAINT [FK_CTHocKi_HocKi]
GO
/****** Object:  ForeignKey [FK_CTHocKi_MonHoc]    Script Date: 06/15/2015 17:17:26 ******/
ALTER TABLE [dbo].[CTHocKi]  WITH CHECK ADD  CONSTRAINT [FK_CTHocKi_MonHoc] FOREIGN KEY([IdMonHoc])
REFERENCES [dbo].[MonHoc] ([Id])
GO
ALTER TABLE [dbo].[CTHocKi] CHECK CONSTRAINT [FK_CTHocKi_MonHoc]
GO
/****** Object:  ForeignKey [FK_TongKetHK_HocKi]    Script Date: 06/15/2015 17:17:26 ******/
ALTER TABLE [dbo].[TongKetHK]  WITH CHECK ADD  CONSTRAINT [FK_TongKetHK_HocKi] FOREIGN KEY([IdHocKi])
REFERENCES [dbo].[HocKi] ([Id])
GO
ALTER TABLE [dbo].[TongKetHK] CHECK CONSTRAINT [FK_TongKetHK_HocKi]
GO
/****** Object:  ForeignKey [FK_TongKetHK_HocSinh]    Script Date: 06/15/2015 17:17:26 ******/
ALTER TABLE [dbo].[TongKetHK]  WITH CHECK ADD  CONSTRAINT [FK_TongKetHK_HocSinh] FOREIGN KEY([IdHocSinh])
REFERENCES [dbo].[HocSinh] ([Id])
GO
ALTER TABLE [dbo].[TongKetHK] CHECK CONSTRAINT [FK_TongKetHK_HocSinh]
GO
/****** Object:  ForeignKey [FK_TKB_CTHocKi]    Script Date: 06/15/2015 17:17:26 ******/
ALTER TABLE [dbo].[TKB]  WITH CHECK ADD  CONSTRAINT [FK_TKB_CTHocKi] FOREIGN KEY([IdCTHocKi])
REFERENCES [dbo].[CTHocKi] ([Id])
GO
ALTER TABLE [dbo].[TKB] CHECK CONSTRAINT [FK_TKB_CTHocKi]
GO
/****** Object:  ForeignKey [FK_TKB_HocSinh]    Script Date: 06/15/2015 17:17:26 ******/
ALTER TABLE [dbo].[TKB]  WITH CHECK ADD  CONSTRAINT [FK_TKB_HocSinh] FOREIGN KEY([IdHocSinh])
REFERENCES [dbo].[HocSinh] ([Id])
GO
ALTER TABLE [dbo].[TKB] CHECK CONSTRAINT [FK_TKB_HocSinh]
GO
