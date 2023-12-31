USE [master]
GO
/****** Object:  Database [dotNetQLK]    Script Date: 1/8/2024 6:01:06 PM ******/
CREATE DATABASE [dotNetQLK]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dotNetQLK', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\dotNetQLK.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'dotNetQLK_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\dotNetQLK_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [dotNetQLK] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dotNetQLK].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dotNetQLK] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dotNetQLK] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dotNetQLK] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dotNetQLK] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dotNetQLK] SET ARITHABORT OFF 
GO
ALTER DATABASE [dotNetQLK] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dotNetQLK] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dotNetQLK] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dotNetQLK] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dotNetQLK] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dotNetQLK] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dotNetQLK] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dotNetQLK] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dotNetQLK] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dotNetQLK] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dotNetQLK] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dotNetQLK] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dotNetQLK] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dotNetQLK] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dotNetQLK] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dotNetQLK] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dotNetQLK] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dotNetQLK] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dotNetQLK] SET  MULTI_USER 
GO
ALTER DATABASE [dotNetQLK] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dotNetQLK] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dotNetQLK] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dotNetQLK] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [dotNetQLK] SET DELAYED_DURABILITY = DISABLED 
GO
USE [dotNetQLK]
GO
/****** Object:  Table [dbo].[LichSu]    Script Date: 1/8/2024 6:01:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichSu](
	[MaLichSu] [int] IDENTITY(1,1) NOT NULL,
	[LoaiThaoTac] [nvarchar](50) NULL,
	[MaSanPham] [int] NULL,
	[TenDangNhap] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[GhiChu] [nvarchar](255) NULL,
	[MaPhieuNhap] [int] NULL,
	[MaPhieuXuat] [int] NULL,
 CONSTRAINT [PK__LichSu__C443222AD29916E9] PRIMARY KEY CLUSTERED 
(
	[MaLichSu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 1/8/2024 6:01:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSanPham](
	[MaLoaiSanPham] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiSanPham] [nvarchar](50) NULL,
 CONSTRAINT [PK__LoaiSanP__ECCF699F3329EAB2] PRIMARY KEY CLUSTERED 
(
	[MaLoaiSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 1/8/2024 6:01:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MaNhanVien] [nvarchar](20) NULL,
	[TenDangNhap] [nvarchar](50) NULL,
	[MatKhau] [nvarchar](100) NULL,
	[HoTen] [nvarchar](100) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](255) NULL,
	[SoDienThoai] [nvarchar](20) NULL,
	[VaiTro] [nvarchar](20) NULL,
 CONSTRAINT [PK__NhanVien__3214EC07FE9EE41E] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhapHang]    Script Date: 1/8/2024 6:01:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhapHang](
	[MaPhieuNhap] [int] IDENTITY(1,1) NOT NULL,
	[NgayNhap] [datetime] NULL,
	[MaNhaPhanPhoi] [int] NULL,
	[MaSanPham] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[TenDangNhap] [nvarchar](50) NULL,
 CONSTRAINT [PK__NhapHang__1470EF3BC2AC9B33] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaPhanPhoi]    Script Date: 1/8/2024 6:01:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaPhanPhoi](
	[MaNhaPhanPhoi] [int] IDENTITY(1,1) NOT NULL,
	[TenNhaPhanPhoi] [nvarchar](100) NULL,
	[DiaChi] [nvarchar](255) NULL,
	[SoDienThoai] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhaPhanPhoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 1/8/2024 6:01:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSanPham] [int] IDENTITY(1,1) NOT NULL,
	[TenSanPham] [nvarchar](100) NULL,
	[SoLuongTon] [int] NULL,
	[MaLoaiSanPham] [int] NULL,
 CONSTRAINT [PK__SanPham__FAC7442D6695DEBF] PRIMARY KEY CLUSTERED 
(
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[XuatHang]    Script Date: 1/8/2024 6:01:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[XuatHang](
	[MaPhieuXuat] [int] IDENTITY(1,1) NOT NULL,
	[NgayXuat] [datetime] NULL,
	[MaNhaPhanPhoi] [int] NULL,
	[MaSanPham] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[TenDangNhap] [nvarchar](50) NULL,
 CONSTRAINT [PK__XuatHang__26C4B5A29D493220] PRIMARY KEY CLUSTERED 
(
	[MaPhieuXuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[LichSu] ON 

INSERT [dbo].[LichSu] ([MaLichSu], [LoaiThaoTac], [MaSanPham], [TenDangNhap], [SoLuong], [GhiChu], [MaPhieuNhap], [MaPhieuXuat]) VALUES (1, N'Nhập', 203, N'anhtho', 11, NULL, NULL, NULL)
INSERT [dbo].[LichSu] ([MaLichSu], [LoaiThaoTac], [MaSanPham], [TenDangNhap], [SoLuong], [GhiChu], [MaPhieuNhap], [MaPhieuXuat]) VALUES (2, N'Nhập', 203, N'anhtho', 2, NULL, 6, NULL)
INSERT [dbo].[LichSu] ([MaLichSu], [LoaiThaoTac], [MaSanPham], [TenDangNhap], [SoLuong], [GhiChu], [MaPhieuNhap], [MaPhieuXuat]) VALUES (3, N'Xu?t', 203, N'anhtho', 19, NULL, NULL, 1)
INSERT [dbo].[LichSu] ([MaLichSu], [LoaiThaoTac], [MaSanPham], [TenDangNhap], [SoLuong], [GhiChu], [MaPhieuNhap], [MaPhieuXuat]) VALUES (4, N'Xuất', 8, N'anhtho', 6, NULL, NULL, 2)
SET IDENTITY_INSERT [dbo].[LichSu] OFF
SET IDENTITY_INSERT [dbo].[LoaiSanPham] ON 

INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (1, N'Điện thoại di động')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (2, N'Laptop')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (3, N'Máy tính bảng')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (4, N'Điều hòa không khí')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (5, N'Tivi')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (6, N'Tủ lạnh')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (7, N'Máy giặt')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (8, N'Bàn là')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (9, N'Máy tính')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (10, N'Tai nghe không dây')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (21, N'Xe máy')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (32, N'Xe đua')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (33, N'Xe rùa')
SET IDENTITY_INSERT [dbo].[LoaiSanPham] OFF
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([Id], [MaNhanVien], [TenDangNhap], [MatKhau], [HoTen], [NgaySinh], [DiaChi], [SoDienThoai], [VaiTro]) VALUES (5, N'A02', N'hbtungg', N'123', N'Huỳnh Bá Thanh Tùng', CAST(N'2002-10-20' AS Date), N'Thừa Thiên Huế', N'0332012764', N'Admin')
INSERT [dbo].[NhanVien] ([Id], [MaNhanVien], [TenDangNhap], [MatKhau], [HoTen], [NgaySinh], [DiaChi], [SoDienThoai], [VaiTro]) VALUES (6, N'NV01', N'anhtho', N'1234', N'Văn Anh Thơ', CAST(N'2003-07-05' AS Date), N'Gia Lai', N'0981543055', N'Nhân viên')
INSERT [dbo].[NhanVien] ([Id], [MaNhanVien], [TenDangNhap], [MatKhau], [HoTen], [NgaySinh], [DiaChi], [SoDienThoai], [VaiTro]) VALUES (8, N'A03', N'user1', N'password1', N'Nguyễn Văn A', CAST(N'1990-01-01' AS Date), N'Ð?a Ch? 1', N'123456789', N'Admin')
INSERT [dbo].[NhanVien] ([Id], [MaNhanVien], [TenDangNhap], [MatKhau], [HoTen], [NgaySinh], [DiaChi], [SoDienThoai], [VaiTro]) VALUES (9, N'NV02', N'user2', N'password2', N'Trần Thị B', CAST(N'1991-02-02' AS Date), N'Ð?a Ch? 2', N'234567890', N'Nhân viên')
INSERT [dbo].[NhanVien] ([Id], [MaNhanVien], [TenDangNhap], [MatKhau], [HoTen], [NgaySinh], [DiaChi], [SoDienThoai], [VaiTro]) VALUES (10, N'NV03', N'user3', N'password3', N'Lê Văn C', CAST(N'1992-03-03' AS Date), N'Ð?a Ch? 3', N'345678901', N'Nhân viên')
INSERT [dbo].[NhanVien] ([Id], [MaNhanVien], [TenDangNhap], [MatKhau], [HoTen], [NgaySinh], [DiaChi], [SoDienThoai], [VaiTro]) VALUES (11, N'NV04', N'user4', N'password4', N'Phạm Thị D', CAST(N'1993-04-04' AS Date), N'Ð?a Ch? 4', N'456789012', N'Nhân viên')
INSERT [dbo].[NhanVien] ([Id], [MaNhanVien], [TenDangNhap], [MatKhau], [HoTen], [NgaySinh], [DiaChi], [SoDienThoai], [VaiTro]) VALUES (12, N'A04', N'user5', N'password5', N'Võ Văn E', CAST(N'1994-05-05' AS Date), N'Ð?a Ch? 5', N'567890123', N'Admin')
INSERT [dbo].[NhanVien] ([Id], [MaNhanVien], [TenDangNhap], [MatKhau], [HoTen], [NgaySinh], [DiaChi], [SoDienThoai], [VaiTro]) VALUES (13, N'NV05', N'user6', N'password6', N'Đặng Thị F', CAST(N'1995-06-06' AS Date), N'Ð?a Ch? 6', N'678901234', N'Nhân viên')
INSERT [dbo].[NhanVien] ([Id], [MaNhanVien], [TenDangNhap], [MatKhau], [HoTen], [NgaySinh], [DiaChi], [SoDienThoai], [VaiTro]) VALUES (14, N'NV06', N'user7', N'password7', N'Ngô Van G', CAST(N'1996-07-07' AS Date), N'Ð?a Ch? 7', N'789012345', N'Nhân viên')
INSERT [dbo].[NhanVien] ([Id], [MaNhanVien], [TenDangNhap], [MatKhau], [HoTen], [NgaySinh], [DiaChi], [SoDienThoai], [VaiTro]) VALUES (15, N'NV07', N'user8', N'password8', N'Bùi Thị H', CAST(N'1997-08-08' AS Date), N'Ð?a Ch? 8', N'890123456', N'Nhân viên')
INSERT [dbo].[NhanVien] ([Id], [MaNhanVien], [TenDangNhap], [MatKhau], [HoTen], [NgaySinh], [DiaChi], [SoDienThoai], [VaiTro]) VALUES (16, N'A05', N'user9', N'password9', N'Hoàng Văn L', CAST(N'1998-09-09' AS Date), N'Ð?a Ch? 9', N'901234567', N'Admin')
INSERT [dbo].[NhanVien] ([Id], [MaNhanVien], [TenDangNhap], [MatKhau], [HoTen], [NgaySinh], [DiaChi], [SoDienThoai], [VaiTro]) VALUES (17, N'NV08', N'user10', N'password10', N'Nguyễn Thị K', CAST(N'1999-10-10' AS Date), N'Ð?a Ch? 10', N'012345678', N'Nhân viên')
INSERT [dbo].[NhanVien] ([Id], [MaNhanVien], [TenDangNhap], [MatKhau], [HoTen], [NgaySinh], [DiaChi], [SoDienThoai], [VaiTro]) VALUES (18, N'A06', N'user11', N'password11', N'Trần Thị L', CAST(N'2000-11-11' AS Date), N'Ð?a Ch? 11', N'111223344', N'Admin')
INSERT [dbo].[NhanVien] ([Id], [MaNhanVien], [TenDangNhap], [MatKhau], [HoTen], [NgaySinh], [DiaChi], [SoDienThoai], [VaiTro]) VALUES (19, N'NV09', N'user12', N'password12', N'Nguyễn Văn M', CAST(N'2001-12-12' AS Date), N'Ð?a Ch? 12', N'122334455', N'Nhân viên')
INSERT [dbo].[NhanVien] ([Id], [MaNhanVien], [TenDangNhap], [MatKhau], [HoTen], [NgaySinh], [DiaChi], [SoDienThoai], [VaiTro]) VALUES (20, N'NV10', N'user13', N'password13', N'Lê Thị N', CAST(N'2002-01-01' AS Date), N'Ð?a Ch? 13', N'233445566', N'Nhân viên')
INSERT [dbo].[NhanVien] ([Id], [MaNhanVien], [TenDangNhap], [MatKhau], [HoTen], [NgaySinh], [DiaChi], [SoDienThoai], [VaiTro]) VALUES (21, N'NV11', N'user14', N'password14', N'Phạm Văn O', CAST(N'2003-02-02' AS Date), N'Ð?a Ch? 14', N'344556677', N'Nhân viên')
INSERT [dbo].[NhanVien] ([Id], [MaNhanVien], [TenDangNhap], [MatKhau], [HoTen], [NgaySinh], [DiaChi], [SoDienThoai], [VaiTro]) VALUES (22, N'A07', N'user15', N'password15', N'Võ Th? P', CAST(N'2004-03-03' AS Date), N'Ð?a Ch? 15', N'455667788', N'Admin')
INSERT [dbo].[NhanVien] ([Id], [MaNhanVien], [TenDangNhap], [MatKhau], [HoTen], [NgaySinh], [DiaChi], [SoDienThoai], [VaiTro]) VALUES (23, N'NV12', N'user16', N'password16', N'Ð?ng Van Q', CAST(N'2005-04-04' AS Date), N'Ð?a Ch? 16', N'566778899', N'Nhân viên')
INSERT [dbo].[NhanVien] ([Id], [MaNhanVien], [TenDangNhap], [MatKhau], [HoTen], [NgaySinh], [DiaChi], [SoDienThoai], [VaiTro]) VALUES (24, N'NV13', N'user17', N'password17', N'Ngô Th? R', CAST(N'2006-05-05' AS Date), N'Ð?a Ch? 17', N'677889900', N'Nhân viên')
INSERT [dbo].[NhanVien] ([Id], [MaNhanVien], [TenDangNhap], [MatKhau], [HoTen], [NgaySinh], [DiaChi], [SoDienThoai], [VaiTro]) VALUES (25, N'NV14', N'user18', N'password18', N'Bùi Van S', CAST(N'2007-06-06' AS Date), N'Ð?a Ch? 18', N'788990011', N'Nhân viên')
INSERT [dbo].[NhanVien] ([Id], [MaNhanVien], [TenDangNhap], [MatKhau], [HoTen], [NgaySinh], [DiaChi], [SoDienThoai], [VaiTro]) VALUES (26, N'A08', N'user19', N'password19', N'Hoàng Th? T', CAST(N'2008-07-07' AS Date), N'Ð?a Ch? 19', N'889900122', N'Admin')
INSERT [dbo].[NhanVien] ([Id], [MaNhanVien], [TenDangNhap], [MatKhau], [HoTen], [NgaySinh], [DiaChi], [SoDienThoai], [VaiTro]) VALUES (27, N'NV15', N'user20', N'password20', N'Nguy?n Van U', CAST(N'2009-08-08' AS Date), N'Ð?a Ch? 20', N'990011233', N'Nhân viên')
INSERT [dbo].[NhanVien] ([Id], [MaNhanVien], [TenDangNhap], [MatKhau], [HoTen], [NgaySinh], [DiaChi], [SoDienThoai], [VaiTro]) VALUES (28, N'', N'', N'', N'', CAST(N'2023-12-04' AS Date), N'', N'', N'')
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
SET IDENTITY_INSERT [dbo].[NhapHang] ON 

INSERT [dbo].[NhapHang] ([MaPhieuNhap], [NgayNhap], [MaNhaPhanPhoi], [MaSanPham], [SoLuong], [TenDangNhap]) VALUES (2, CAST(N'2023-12-31 00:00:00.000' AS DateTime), 1, 204, 10, N'anhtho')
INSERT [dbo].[NhapHang] ([MaPhieuNhap], [NgayNhap], [MaNhaPhanPhoi], [MaSanPham], [SoLuong], [TenDangNhap]) VALUES (3, CAST(N'2023-12-31 00:00:00.000' AS DateTime), 2, 202, 23, N'anhtho')
INSERT [dbo].[NhapHang] ([MaPhieuNhap], [NgayNhap], [MaNhaPhanPhoi], [MaSanPham], [SoLuong], [TenDangNhap]) VALUES (4, CAST(N'2023-12-31 00:00:00.000' AS DateTime), 2, 203, 11, N'anhtho')
INSERT [dbo].[NhapHang] ([MaPhieuNhap], [NgayNhap], [MaNhaPhanPhoi], [MaSanPham], [SoLuong], [TenDangNhap]) VALUES (5, CAST(N'2023-12-31 00:00:00.000' AS DateTime), 1, 203, 7, N'anhtho')
INSERT [dbo].[NhapHang] ([MaPhieuNhap], [NgayNhap], [MaNhaPhanPhoi], [MaSanPham], [SoLuong], [TenDangNhap]) VALUES (6, CAST(N'2023-12-31 00:00:00.000' AS DateTime), 1, 203, 2, N'anhtho')
SET IDENTITY_INSERT [dbo].[NhapHang] OFF
SET IDENTITY_INSERT [dbo].[NhaPhanPhoi] ON 

INSERT [dbo].[NhaPhanPhoi] ([MaNhaPhanPhoi], [TenNhaPhanPhoi], [DiaChi], [SoDienThoai]) VALUES (1, N'Công An Nhân Dân', N'Việt Nam', N'113')
INSERT [dbo].[NhaPhanPhoi] ([MaNhaPhanPhoi], [TenNhaPhanPhoi], [DiaChi], [SoDienThoai]) VALUES (2, N'Bệnh Viện Quốc Tế', N'Huế', N'115')
INSERT [dbo].[NhaPhanPhoi] ([MaNhaPhanPhoi], [TenNhaPhanPhoi], [DiaChi], [SoDienThoai]) VALUES (4, N'Trung tâm phòng cháy chữa cháy', N'Huế', N'114')
INSERT [dbo].[NhaPhanPhoi] ([MaNhaPhanPhoi], [TenNhaPhanPhoi], [DiaChi], [SoDienThoai]) VALUES (5, N'CTy Cổ Phần Tương Dương', N'Trung Quốc', N'06165')
SET IDENTITY_INSERT [dbo].[NhaPhanPhoi] OFF
SET IDENTITY_INSERT [dbo].[SanPham] ON 

INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (1, N'Dien thoai Samsung Galaxy A51', 50, 1)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (2, N'Dien thoai iPhone 12', 30, 1)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (3, N'Dien thoai Xiaomi Redmi Note 10', 25, 1)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (4, N'Dien thoai Oppo Reno5', 40, 1)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (5, N'Dien thoai Vivo V21', 20, 1)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (6, N'Dien thoai Realme 8 Pro', 35, 1)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (7, N'Dien thoai Nokia 5.4', 15, 1)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (8, N'Dien thoai Huawei P40 Lite', 22, 1)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (9, N'Dien thoai Motorola Moto G Power', 22, 1)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (10, N'Dien thoai LG K92 5G', 18, 1)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (11, N'Laptop Dell Inspiron 15', 30, 2)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (12, N'Laptop HP Pavilion x360', 25, 2)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (13, N'Laptop Lenovo ThinkPad X1 Carbon', 20, 2)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (14, N'Laptop Asus ROG Zephyrus G14', 15, 2)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (15, N'Laptop Acer Predator Helios 300', 18, 2)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (16, N'Laptop MSI GS66 Stealth', 22, 2)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (17, N'Laptop Apple MacBook Air', 28, 2)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (18, N'Laptop LG Gram 17', 10, 2)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (19, N'Laptop Microsoft Surface Laptop 4', 12, 2)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (20, N'Laptop Huawei MateBook X Pro', 8, 2)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (21, N'May tinh bang Samsung Galaxy Tab S7', 30, 3)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (22, N'May tinh bang Apple iPad Air', 25, 3)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (23, N'May tinh bang Lenovo Tab P11', 20, 3)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (24, N'May tinh bang Huawei MatePad Pro', 15, 3)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (25, N'May tinh bang Amazon Fire HD 10', 18, 3)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (26, N'May tinh bang Microsoft Surface Go 2', 22, 3)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (27, N'May tinh bang Asus ZenPad 3S 10', 28, 3)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (28, N'May tinh bang Xiaomi Mi Pad 5', 10, 3)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (29, N'May tinh bang Acer Iconia One 10', 12, 3)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (30, N'May tinh bang Google Pixel Slate', 8, 3)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (31, N'Dieu hoa Panasonic Inverter', 40, 4)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (32, N'Dieu hoa Daikin FTKM71P', 35, 4)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (33, N'Dieu hoa LG Dual Inverter', 30, 4)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (34, N'Dieu hoa Mitsubishi Heavy SRK-ZSX', 25, 4)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (35, N'Dieu hoa Samsung Wind-Free', 20, 4)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (36, N'Dieu hoa Electrolux Inverter', 18, 4)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (37, N'Dieu hoa Gree Fairy GWH12QB', 22, 4)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (38, N'Dieu hoa Sharp AH-A12SEV', 28, 4)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (39, N'Dieu hoa Toshiba RAS-H10NKCV', 12, 4)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (40, N'Dieu hoa Haier Inverter', 15, 4)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (41, N'Tivi Samsung QLED Q70T', 50, 5)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (42, N'Tivi Sony Bravia XR A80J', 45, 5)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (43, N'Tivi LG OLED CX', 35, 5)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (44, N'Tivi Panasonic Viera HX940', 28, 5)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (45, N'Tivi TCL 6-Series', 22, 5)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (46, N'Tivi Philips OLED 805', 18, 5)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (47, N'Tivi Hisense U7G', 30, 5)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (48, N'Tivi Vizio M-Series Quantum', 40, 5)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (49, N'Tivi Sharp Aquos LC-90LE745U', 12, 5)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (50, N'Tivi Xiaomi Mi TV 4S', 15, 5)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (51, N'Tu lanh Samsung Side-by-Side', 35, 6)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (52, N'Tu lanh LG French Door', 30, 6)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (53, N'Tu lanh Panasonic Inverter', 25, 6)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (54, N'Tu lanh Electrolux Bottom Freezer', 20, 6)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (55, N'Tu lanh Haier Top Mount', 18, 6)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (56, N'Tu lanh Sharp Side-by-Side', 22, 6)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (57, N'Tu lanh Mitsubishi Multi Door', 28, 6)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (58, N'Tu lanh Bosch French Door', 15, 6)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (59, N'Tu lanh Whirlpool SideKicks', 12, 6)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (60, N'Tu lanh Hitachi French Bottom Freezer', 8, 6)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (61, N'May giat LG Front Load', 40, 7)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (62, N'May giat Samsung Top Load', 35, 7)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (63, N'May giat Electrolux Fully Automatic', 30, 7)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (64, N'May giat Panasonic Inverter', 25, 7)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (65, N'May giat Haier Twin Tub', 20, 7)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (66, N'May giat Bosch Serie 6', 18, 7)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (67, N'May giat Sharp ES-F800P', 22, 7)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (68, N'May giat Toshiba AW-8570SM', 28, 7)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (69, N'May giat Whirlpool Cabrio', 12, 7)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (70, N'May giat Midea Front Loading', 15, 7)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (71, N'Ban la Philips Steam Iron', 35, 8)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (72, N'Ban la Rowenta DW5080', 30, 8)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (73, N'Ban la Black + Decker Digital Advantage', 25, 8)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (74, N'Ban la Sunbeam Steammaster', 20, 8)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (75, N'Ban la Shark Ultimate Professional', 18, 8)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (76, N'Ban la Maytag M400', 22, 8)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (77, N'Ban la T-fal FV4495 Ultraglide', 28, 8)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (78, N'Ban la Hamilton Beach Durathon', 15, 8)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (79, N'Ban la Conair ExtremeSteam', 12, 8)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (80, N'Ban la Reliable Ovo 150GT', 8, 8)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (81, N'May anh Canon EOS 5D Mark IV', 30, 9)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (82, N'May anh Nikon D850', 25, 9)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (83, N'May anh Sony Alpha A7 III', 20, 9)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (84, N'May anh Fujifilm X-T4', 15, 9)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (85, N'May anh Panasonic Lumix GH5', 18, 9)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (86, N'May anh Olympus OM-D E-M1 Mark III', 22, 9)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (87, N'May anh Leica Q2', 28, 9)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (88, N'May anh Pentax K-1 Mark II', 10, 9)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (89, N'May anh Samsung Galaxy Camera', 12, 9)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (90, N'May anh GoPro Hero 9 Black', 8, 9)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (91, N'Tai nghe Sony WH-1000XM4', 50, 10)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (92, N'Tai nghe Apple AirPods Pro', 45, 10)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (93, N'Tai nghe Bose QuietComfort 35 II', 35, 10)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (94, N'Tai nghe JBL Free X', 28, 10)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (95, N'Tai nghe Sennheiser Momentum True Wireless 2', 22, 10)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (96, N'Tai nghe Samsung Galaxy Buds Pro', 18, 10)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (97, N'Tai nghe Anker Soundcore Liberty Air 2 Pro', 30, 10)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (98, N'Tai nghe Beats Solo Pro', 40, 10)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (99, N'Tai nghe Xiaomi Mi True Wireless Earbuds', 12, 10)
GO
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (100, N'Tai nghe Huawei FreeBuds Pro', 15, 10)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (202, N'Xe Aston Martin V12', 23, 32)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (203, N'Xe Porcshe Panamera', 1, 32)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [SoLuongTon], [MaLoaiSanPham]) VALUES (204, N'Nissan GTR r34', 20, 32)
SET IDENTITY_INSERT [dbo].[SanPham] OFF
SET IDENTITY_INSERT [dbo].[XuatHang] ON 

INSERT [dbo].[XuatHang] ([MaPhieuXuat], [NgayXuat], [MaNhaPhanPhoi], [MaSanPham], [SoLuong], [TenDangNhap]) VALUES (1, CAST(N'2023-12-31 00:00:00.000' AS DateTime), 1, 203, 19, N'anhtho')
INSERT [dbo].[XuatHang] ([MaPhieuXuat], [NgayXuat], [MaNhaPhanPhoi], [MaSanPham], [SoLuong], [TenDangNhap]) VALUES (2, CAST(N'2024-01-08 00:00:00.000' AS DateTime), 1, 8, 6, N'anhtho')
SET IDENTITY_INSERT [dbo].[XuatHang] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__NhanVien__55F68FC01AD7F4E2]    Script Date: 1/8/2024 6:01:06 PM ******/
ALTER TABLE [dbo].[NhanVien] ADD  CONSTRAINT [UQ__NhanVien__55F68FC01AD7F4E2] UNIQUE NONCLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__NhanVien__77B2CA46E31C5CB6]    Script Date: 1/8/2024 6:01:06 PM ******/
ALTER TABLE [dbo].[NhanVien] ADD  CONSTRAINT [UQ__NhanVien__77B2CA46E31C5CB6] UNIQUE NONCLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[LichSu]  WITH CHECK ADD  CONSTRAINT [FK__LichSu__MaPhieuN__239E4DCF] FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[NhapHang] ([MaPhieuNhap])
GO
ALTER TABLE [dbo].[LichSu] CHECK CONSTRAINT [FK__LichSu__MaPhieuN__239E4DCF]
GO
ALTER TABLE [dbo].[LichSu]  WITH CHECK ADD  CONSTRAINT [FK__LichSu__MaPhieuX__24927208] FOREIGN KEY([MaPhieuXuat])
REFERENCES [dbo].[XuatHang] ([MaPhieuXuat])
GO
ALTER TABLE [dbo].[LichSu] CHECK CONSTRAINT [FK__LichSu__MaPhieuX__24927208]
GO
ALTER TABLE [dbo].[LichSu]  WITH CHECK ADD  CONSTRAINT [FK__LichSu__MaSanPha__21B6055D] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
GO
ALTER TABLE [dbo].[LichSu] CHECK CONSTRAINT [FK__LichSu__MaSanPha__21B6055D]
GO
ALTER TABLE [dbo].[LichSu]  WITH CHECK ADD  CONSTRAINT [FK_LichSu_NhanVien] FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[NhanVien] ([TenDangNhap])
GO
ALTER TABLE [dbo].[LichSu] CHECK CONSTRAINT [FK_LichSu_NhanVien]
GO
ALTER TABLE [dbo].[NhapHang]  WITH CHECK ADD  CONSTRAINT [FK__NhapHang__MaNhaP__1BFD2C07] FOREIGN KEY([MaNhaPhanPhoi])
REFERENCES [dbo].[NhaPhanPhoi] ([MaNhaPhanPhoi])
GO
ALTER TABLE [dbo].[NhapHang] CHECK CONSTRAINT [FK__NhapHang__MaNhaP__1BFD2C07]
GO
ALTER TABLE [dbo].[NhapHang]  WITH CHECK ADD  CONSTRAINT [FK_NhapHang_NhanVien] FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[NhanVien] ([TenDangNhap])
GO
ALTER TABLE [dbo].[NhapHang] CHECK CONSTRAINT [FK_NhapHang_NhanVien]
GO
ALTER TABLE [dbo].[NhapHang]  WITH CHECK ADD  CONSTRAINT [FK_NhapHang_SanPham] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
GO
ALTER TABLE [dbo].[NhapHang] CHECK CONSTRAINT [FK_NhapHang_SanPham]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK__SanPham__MaLoaiS__164452B1] FOREIGN KEY([MaLoaiSanPham])
REFERENCES [dbo].[LoaiSanPham] ([MaLoaiSanPham])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK__SanPham__MaLoaiS__164452B1]
GO
ALTER TABLE [dbo].[XuatHang]  WITH CHECK ADD  CONSTRAINT [FK__XuatHang__MaNhaP__1ED998B2] FOREIGN KEY([MaNhaPhanPhoi])
REFERENCES [dbo].[NhaPhanPhoi] ([MaNhaPhanPhoi])
GO
ALTER TABLE [dbo].[XuatHang] CHECK CONSTRAINT [FK__XuatHang__MaNhaP__1ED998B2]
GO
ALTER TABLE [dbo].[XuatHang]  WITH CHECK ADD  CONSTRAINT [FK_XuatHang_NhanVien] FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[NhanVien] ([TenDangNhap])
GO
ALTER TABLE [dbo].[XuatHang] CHECK CONSTRAINT [FK_XuatHang_NhanVien]
GO
USE [master]
GO
ALTER DATABASE [dotNetQLK] SET  READ_WRITE 
GO
