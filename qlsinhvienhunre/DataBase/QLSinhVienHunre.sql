USE [qlsinhvienhunre]
GO
/****** Object:  Table [dbo].[GiangVien]    Script Date: 16/05/2024 12:15:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiangVien](
	[maGiangVien] [varchar](50) NULL,
	[hotenGiangVien] [nvarchar](50) NULL,
	[ngaySinh] [date] NULL,
	[gioiTinh] [nvarchar](5) NULL,
	[idGiangVien] [int] IDENTITY(0,1) NOT NULL,
 CONSTRAINT [GiangVien_PK] PRIMARY KEY CLUSTERED 
(
	[idGiangVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HinhThuc]    Script Date: 16/05/2024 12:15:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HinhThuc](
	[hinhThucDanhGia] [varchar](3) NOT NULL,
	[tenHinhThucDanhGia] [nvarchar](100) NULL,
 CONSTRAINT [HinhThuc_PK] PRIMARY KEY CLUSTERED 
(
	[hinhThucDanhGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 16/05/2024 12:15:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[maLop] [varchar](50) NULL,
	[idLop] [int] IDENTITY(0,1) NOT NULL,
	[idNganhHoc] [int] NULL,
	[idGiangVien] [int] NULL,
 CONSTRAINT [Lop_PK] PRIMARY KEY CLUSTERED 
(
	[idLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LopHocPhan]    Script Date: 16/05/2024 12:15:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LopHocPhan](
	[maLopHocPhan] [varchar](50) NULL,
	[namHoc] [int] NULL,
	[hocKy] [int] NULL,
	[moTa] [nvarchar](100) NULL,
	[gioiHanSinhVien] [float] NULL,
	[idLopHocPhan] [int] IDENTITY(0,1) NOT NULL,
	[idGiangVien] [int] NULL,
	[idMonHoc] [int] NULL,
 CONSTRAINT [LopHocPhan_PK] PRIMARY KEY CLUSTERED 
(
	[idLopHocPhan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 16/05/2024 12:15:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[maMonHoc] [varchar](50) NULL,
	[tenMonHoc] [nvarchar](100) NULL,
	[soTinChi] [int] NULL,
	[namBatDau] [int] NULL,
	[quyDinh] [nvarchar](8) NULL,
	[moTaMonHoc] [nvarchar](100) NULL,
	[hinhThucDanhGia] [varchar](3) NULL,
	[idMonHoc] [int] IDENTITY(0,1) NOT NULL,
 CONSTRAINT [MonHoc_PK] PRIMARY KEY CLUSTERED 
(
	[idMonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NganhHoc]    Script Date: 16/05/2024 12:15:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NganhHoc](
	[maNganhHoc] [varchar](50) NOT NULL,
	[tenNganhHoc] [nvarchar](max) NULL,
	[soTinChi] [int] NULL,
	[namBatDau] [int] NULL,
	[idNganhHoc] [int] IDENTITY(0,1) NOT NULL,
 CONSTRAINT [NganhHoc_PK] PRIMARY KEY CLUSTERED 
(
	[idNganhHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 16/05/2024 12:15:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[chucVu] [varchar](5) NULL,
	[matKhau] [varchar](100) NULL,
	[idNguoiDung] [int] IDENTITY(0,1) NOT NULL,
	[idSinhVien] [int] NULL,
	[idGiangVien] [int] NULL,
 CONSTRAINT [NguoiDung_PK] PRIMARY KEY CLUSTERED 
(
	[idNguoiDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhanChiaMonHoc]    Script Date: 16/05/2024 12:15:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanChiaMonHoc](
	[idNganhHoc] [int] NOT NULL,
	[idMonHoc] [int] NOT NULL,
	[idChiaMon] [int] IDENTITY(0,1) NOT NULL,
 CONSTRAINT [PhanChiaMonHoc_PK] PRIMARY KEY CLUSTERED 
(
	[idChiaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 16/05/2024 12:15:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[maSinhVien] [varchar](50) NULL,
	[hotenSinhVien] [nvarchar](100) NULL,
	[ngaySinh] [date] NULL,
	[gioiTinh] [nvarchar](5) NULL,
	[namNhapHoc] [int] NULL,
	[idSinhVien] [int] IDENTITY(0,1) NOT NULL,
	[idLop] [int] NULL,
 CONSTRAINT [SinhVien_PK] PRIMARY KEY CLUSTERED 
(
	[idSinhVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThamGiaLopHoc]    Script Date: 16/05/2024 12:15:12 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThamGiaLopHoc](
	[diemSo] [float] NULL,
	[diemChu] [char](8) NULL,
	[maKetQua] [nvarchar](8) NULL,
	[idLopHocPhan] [int] NOT NULL,
	[idSinhVien] [int] NOT NULL,
 CONSTRAINT [ThamGiaLopHoc_PK] PRIMARY KEY CLUSTERED 
(
	[idLopHocPhan] ASC,
	[idSinhVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[GiangVien] ON 

INSERT [dbo].[GiangVien] ([maGiangVien], [hotenGiangVien], [ngaySinh], [gioiTinh], [idGiangVien]) VALUES (N'GV1', N'San', CAST(N'1991-02-03' AS Date), N'Nam', 1)
INSERT [dbo].[GiangVien] ([maGiangVien], [hotenGiangVien], [ngaySinh], [gioiTinh], [idGiangVien]) VALUES (N'GV2', N'Khải', CAST(N'1996-04-04' AS Date), N'Nam', 2)
INSERT [dbo].[GiangVien] ([maGiangVien], [hotenGiangVien], [ngaySinh], [gioiTinh], [idGiangVien]) VALUES (N'GV3', N'Thuận', CAST(N'1990-07-23' AS Date), N'Nam', 3)
INSERT [dbo].[GiangVien] ([maGiangVien], [hotenGiangVien], [ngaySinh], [gioiTinh], [idGiangVien]) VALUES (N'GV4', N'Anh', CAST(N'1989-06-12' AS Date), N'Nữ', 4)
INSERT [dbo].[GiangVien] ([maGiangVien], [hotenGiangVien], [ngaySinh], [gioiTinh], [idGiangVien]) VALUES (N'GV5', N'Liêm', CAST(N'2000-01-17' AS Date), N'Nữ', 5)
INSERT [dbo].[GiangVien] ([maGiangVien], [hotenGiangVien], [ngaySinh], [gioiTinh], [idGiangVien]) VALUES (N'GV6', N'Sang', CAST(N'2024-04-16' AS Date), N'Nam', 6)
SET IDENTITY_INSERT [dbo].[GiangVien] OFF
GO
INSERT [dbo].[HinhThuc] ([hinhThucDanhGia], [tenHinhThucDanhGia]) VALUES (N'BTL', N'Bài tập lớn')
INSERT [dbo].[HinhThuc] ([hinhThucDanhGia], [tenHinhThucDanhGia]) VALUES (N'TH', N'Thực hành')
INSERT [dbo].[HinhThuc] ([hinhThucDanhGia], [tenHinhThucDanhGia]) VALUES (N'TL', N'Tự luận')
INSERT [dbo].[HinhThuc] ([hinhThucDanhGia], [tenHinhThucDanhGia]) VALUES (N'TN', N'Trắc nghiệm')
GO
SET IDENTITY_INSERT [dbo].[Lop] ON 

INSERT [dbo].[Lop] ([maLop], [idLop], [idNganhHoc], [idGiangVien]) VALUES (N'C1', 1, 1, 1)
INSERT [dbo].[Lop] ([maLop], [idLop], [idNganhHoc], [idGiangVien]) VALUES (N'KT1001', 1001, 1, 6)
INSERT [dbo].[Lop] ([maLop], [idLop], [idNganhHoc], [idGiangVien]) VALUES (N'KT1002', 1002, 1, 3)
INSERT [dbo].[Lop] ([maLop], [idLop], [idNganhHoc], [idGiangVien]) VALUES (N'QLDD1004', 1004, 2, 3)
SET IDENTITY_INSERT [dbo].[Lop] OFF
GO
SET IDENTITY_INSERT [dbo].[LopHocPhan] ON 

INSERT [dbo].[LopHocPhan] ([maLopHocPhan], [namHoc], [hocKy], [moTa], [gioiHanSinhVien], [idLopHocPhan], [idGiangVien], [idMonHoc]) VALUES (N'1', 2020, 2, N'"Chưa có mô tả"', 200, 1, 1, 1)
INSERT [dbo].[LopHocPhan] ([maLopHocPhan], [namHoc], [hocKy], [moTa], [gioiHanSinhVien], [idLopHocPhan], [idGiangVien], [idMonHoc]) VALUES (N'2', 2020, 1, N'"Chưa có mô tả"', 200, 2, 1, 4)
INSERT [dbo].[LopHocPhan] ([maLopHocPhan], [namHoc], [hocKy], [moTa], [gioiHanSinhVien], [idLopHocPhan], [idGiangVien], [idMonHoc]) VALUES (N'20202', 2020, 1, N'"Chưa có mô tả"', 200, 1013, 1, 1)
INSERT [dbo].[LopHocPhan] ([maLopHocPhan], [namHoc], [hocKy], [moTa], [gioiHanSinhVien], [idLopHocPhan], [idGiangVien], [idMonHoc]) VALUES (N'20204', 2019, 1, N'"Chưa có mô tả"', 200, 1015, 5, 3)
INSERT [dbo].[LopHocPhan] ([maLopHocPhan], [namHoc], [hocKy], [moTa], [gioiHanSinhVien], [idLopHocPhan], [idGiangVien], [idMonHoc]) VALUES (N'2019KT', 2019, 1, N'"Chưa có mô tả"', 250, 2016, 2, 8)
SET IDENTITY_INSERT [dbo].[LopHocPhan] OFF
GO
SET IDENTITY_INSERT [dbo].[MonHoc] ON 

INSERT [dbo].[MonHoc] ([maMonHoc], [tenMonHoc], [soTinChi], [namBatDau], [quyDinh], [moTaMonHoc], [hinhThucDanhGia], [idMonHoc]) VALUES (N'TRR', N'Toán Rời Rạc', 3, 2024, N'Bắt buộc', N'"Chưa có mô tả"', N'BTL', 1)
INSERT [dbo].[MonHoc] ([maMonHoc], [tenMonHoc], [soTinChi], [namBatDau], [quyDinh], [moTaMonHoc], [hinhThucDanhGia], [idMonHoc]) VALUES (N'K', N'Kinh tế vĩ mô', 3, 2024, N'Tự chọn', N'"Chưa có mô tả"', N'BTL', 2)
INSERT [dbo].[MonHoc] ([maMonHoc], [tenMonHoc], [soTinChi], [namBatDau], [quyDinh], [moTaMonHoc], [hinhThucDanhGia], [idMonHoc]) VALUES (N'LA', N'Lập trình Android', 2, 2024, N'Tự chọn', N'"Chưa có mô tả"', N'TL', 3)
INSERT [dbo].[MonHoc] ([maMonHoc], [tenMonHoc], [soTinChi], [namBatDau], [quyDinh], [moTaMonHoc], [hinhThucDanhGia], [idMonHoc]) VALUES (N'LWEB', N'Lập trình WEB', 3, 2024, N'Bắt buộc', N'"Chưa có mô tả"', N'TN', 4)
INSERT [dbo].[MonHoc] ([maMonHoc], [tenMonHoc], [soTinChi], [namBatDau], [quyDinh], [moTaMonHoc], [hinhThucDanhGia], [idMonHoc]) VALUES (N'CNNET', N'Công Nghệ NET', 3, 2024, N'Bắt buộc', N'"Chưa có mô tả"', N'BTL', 7)
INSERT [dbo].[MonHoc] ([maMonHoc], [tenMonHoc], [soTinChi], [namBatDau], [quyDinh], [moTaMonHoc], [hinhThucDanhGia], [idMonHoc]) VALUES (N'KT', N'Kiểm Thử', 4, 2024, N'Bắt buộc', N'"Chưa có mô tả"', N'TH', 8)
INSERT [dbo].[MonHoc] ([maMonHoc], [tenMonHoc], [soTinChi], [namBatDau], [quyDinh], [moTaMonHoc], [hinhThucDanhGia], [idMonHoc]) VALUES (N'QLD', N'Quản Lý Dự án', 3, 2019, N'Bắt buộc', N'"Chưa có mô tả"', N'BTL', 9)
INSERT [dbo].[MonHoc] ([maMonHoc], [tenMonHoc], [soTinChi], [namBatDau], [quyDinh], [moTaMonHoc], [hinhThucDanhGia], [idMonHoc]) VALUES (N'KTVM', N'Kinh Tế Vĩ Mô', 3, 2019, N'Tự chọn', N'"Chưa có mô tả"', N'TN', 1010)
SET IDENTITY_INSERT [dbo].[MonHoc] OFF
GO
SET IDENTITY_INSERT [dbo].[NganhHoc] ON 

INSERT [dbo].[NganhHoc] ([maNganhHoc], [tenNganhHoc], [soTinChi], [namBatDau], [idNganhHoc]) VALUES (N'KT', N'Kế Toán', 9, 2024, 1)
INSERT [dbo].[NganhHoc] ([maNganhHoc], [tenNganhHoc], [soTinChi], [namBatDau], [idNganhHoc]) VALUES (N'QLÐÐ', N'Quản Lý Đất Đất', 9, 2024, 2)
INSERT [dbo].[NganhHoc] ([maNganhHoc], [tenNganhHoc], [soTinChi], [namBatDau], [idNganhHoc]) VALUES (N'QLKD', N'Quản Lý Kinh Doanh', 18, 2020, 3)
INSERT [dbo].[NganhHoc] ([maNganhHoc], [tenNganhHoc], [soTinChi], [namBatDau], [idNganhHoc]) VALUES (N'CNTT', N'Công Nghệ Thông Tin', 3, 2019, 4)
SET IDENTITY_INSERT [dbo].[NganhHoc] OFF
GO
SET IDENTITY_INSERT [dbo].[NguoiDung] ON 

INSERT [dbo].[NguoiDung] ([chucVu], [matKhau], [idNguoiDung], [idSinhVien], [idGiangVien]) VALUES (N'ADMIN', N'123456ADMIN', 0, NULL, NULL)
INSERT [dbo].[NguoiDung] ([chucVu], [matKhau], [idNguoiDung], [idSinhVien], [idGiangVien]) VALUES (N'GV', N'1', 1, NULL, 1)
INSERT [dbo].[NguoiDung] ([chucVu], [matKhau], [idNguoiDung], [idSinhVien], [idGiangVien]) VALUES (N'SV', N'1', 2, 2018, NULL)
INSERT [dbo].[NguoiDung] ([chucVu], [matKhau], [idNguoiDung], [idSinhVien], [idGiangVien]) VALUES (N'SV', N'2025SV2025', 3, 2025, NULL)
INSERT [dbo].[NguoiDung] ([chucVu], [matKhau], [idNguoiDung], [idSinhVien], [idGiangVien]) VALUES (N'SV', N'2026SV2026', 4, 2026, NULL)
INSERT [dbo].[NguoiDung] ([chucVu], [matKhau], [idNguoiDung], [idSinhVien], [idGiangVien]) VALUES (N'SV', N'3019SV3019', 1003, 3019, NULL)
INSERT [dbo].[NguoiDung] ([chucVu], [matKhau], [idNguoiDung], [idSinhVien], [idGiangVien]) VALUES (N'SV', N'3023SV3023', 1006, 3023, NULL)
INSERT [dbo].[NguoiDung] ([chucVu], [matKhau], [idNguoiDung], [idSinhVien], [idGiangVien]) VALUES (N'SV', N'1231', 1009, 3026, NULL)
INSERT [dbo].[NguoiDung] ([chucVu], [matKhau], [idNguoiDung], [idSinhVien], [idGiangVien]) VALUES (N'SV', N'hih', 1011, 3029, NULL)
INSERT [dbo].[NguoiDung] ([chucVu], [matKhau], [idNguoiDung], [idSinhVien], [idGiangVien]) VALUES (N'GV', N'2GV2', 2007, NULL, 2)
INSERT [dbo].[NguoiDung] ([chucVu], [matKhau], [idNguoiDung], [idSinhVien], [idGiangVien]) VALUES (N'GV', N'3GV3', 2008, NULL, 3)
INSERT [dbo].[NguoiDung] ([chucVu], [matKhau], [idNguoiDung], [idSinhVien], [idGiangVien]) VALUES (N'GV', N'4GV4', 2009, NULL, 4)
INSERT [dbo].[NguoiDung] ([chucVu], [matKhau], [idNguoiDung], [idSinhVien], [idGiangVien]) VALUES (N'GV', N'5GV5', 2010, NULL, 5)
INSERT [dbo].[NguoiDung] ([chucVu], [matKhau], [idNguoiDung], [idSinhVien], [idGiangVien]) VALUES (N'GV', N'6GV6', 2011, NULL, 6)
INSERT [dbo].[NguoiDung] ([chucVu], [matKhau], [idNguoiDung], [idSinhVien], [idGiangVien]) VALUES (N'SV', N'4024SV4024', 2014, 4024, NULL)
INSERT [dbo].[NguoiDung] ([chucVu], [matKhau], [idNguoiDung], [idSinhVien], [idGiangVien]) VALUES (N'SV', N'4025SV4025', 2015, 4025, NULL)
INSERT [dbo].[NguoiDung] ([chucVu], [matKhau], [idNguoiDung], [idSinhVien], [idGiangVien]) VALUES (N'SV', N'4026SV4026', 2016, 4026, NULL)
INSERT [dbo].[NguoiDung] ([chucVu], [matKhau], [idNguoiDung], [idSinhVien], [idGiangVien]) VALUES (N'SV', N'4028SV4028', 2018, 4028, NULL)
INSERT [dbo].[NguoiDung] ([chucVu], [matKhau], [idNguoiDung], [idSinhVien], [idGiangVien]) VALUES (N'SV', N'4031SV4031', 2021, 4031, NULL)
SET IDENTITY_INSERT [dbo].[NguoiDung] OFF
GO
SET IDENTITY_INSERT [dbo].[PhanChiaMonHoc] ON 

INSERT [dbo].[PhanChiaMonHoc] ([idNganhHoc], [idMonHoc], [idChiaMon]) VALUES (1, 1, 0)
INSERT [dbo].[PhanChiaMonHoc] ([idNganhHoc], [idMonHoc], [idChiaMon]) VALUES (1, 2, 1)
INSERT [dbo].[PhanChiaMonHoc] ([idNganhHoc], [idMonHoc], [idChiaMon]) VALUES (1, 7, 1007)
INSERT [dbo].[PhanChiaMonHoc] ([idNganhHoc], [idMonHoc], [idChiaMon]) VALUES (2, 1, 3)
INSERT [dbo].[PhanChiaMonHoc] ([idNganhHoc], [idMonHoc], [idChiaMon]) VALUES (2, 4, 13)
INSERT [dbo].[PhanChiaMonHoc] ([idNganhHoc], [idMonHoc], [idChiaMon]) VALUES (2, 7, 1004)
INSERT [dbo].[PhanChiaMonHoc] ([idNganhHoc], [idMonHoc], [idChiaMon]) VALUES (3, 1, 12)
INSERT [dbo].[PhanChiaMonHoc] ([idNganhHoc], [idMonHoc], [idChiaMon]) VALUES (3, 2, 9)
INSERT [dbo].[PhanChiaMonHoc] ([idNganhHoc], [idMonHoc], [idChiaMon]) VALUES (3, 3, 10)
INSERT [dbo].[PhanChiaMonHoc] ([idNganhHoc], [idMonHoc], [idChiaMon]) VALUES (3, 7, 5)
INSERT [dbo].[PhanChiaMonHoc] ([idNganhHoc], [idMonHoc], [idChiaMon]) VALUES (3, 8, 8)
INSERT [dbo].[PhanChiaMonHoc] ([idNganhHoc], [idMonHoc], [idChiaMon]) VALUES (3, 9, 11)
INSERT [dbo].[PhanChiaMonHoc] ([idNganhHoc], [idMonHoc], [idChiaMon]) VALUES (4, 1, 2006)
SET IDENTITY_INSERT [dbo].[PhanChiaMonHoc] OFF
GO
SET IDENTITY_INSERT [dbo].[SinhVien] ON 

INSERT [dbo].[SinhVien] ([maSinhVien], [hotenSinhVien], [ngaySinh], [gioiTinh], [namNhapHoc], [idSinhVien], [idLop]) VALUES (N'SV2018', N'Sơn', CAST(N'2003-07-25' AS Date), N'Nữ', 2018, 2018, 1)
INSERT [dbo].[SinhVien] ([maSinhVien], [hotenSinhVien], [ngaySinh], [gioiTinh], [namNhapHoc], [idSinhVien], [idLop]) VALUES (N'SV2025', N'Hiệp', CAST(N'2024-04-15' AS Date), N'Nam', 2018, 2025, 1001)
INSERT [dbo].[SinhVien] ([maSinhVien], [hotenSinhVien], [ngaySinh], [gioiTinh], [namNhapHoc], [idSinhVien], [idLop]) VALUES (N'SV2026', N'Hiệp123', CAST(N'2024-04-15' AS Date), N'Nam', 2024, 2026, 1)
INSERT [dbo].[SinhVien] ([maSinhVien], [hotenSinhVien], [ngaySinh], [gioiTinh], [namNhapHoc], [idSinhVien], [idLop]) VALUES (N'SV3019', N'Hiệp', CAST(N'2024-04-16' AS Date), N'Nam', 2018, 3019, 1)
INSERT [dbo].[SinhVien] ([maSinhVien], [hotenSinhVien], [ngaySinh], [gioiTinh], [namNhapHoc], [idSinhVien], [idLop]) VALUES (N'SV3023', N'Phương', CAST(N'2024-04-16' AS Date), N'Nam', 2018, 3023, 1)
INSERT [dbo].[SinhVien] ([maSinhVien], [hotenSinhVien], [ngaySinh], [gioiTinh], [namNhapHoc], [idSinhVien], [idLop]) VALUES (N'SV3026', N'Sơn', CAST(N'2024-04-16' AS Date), N'Nam', 2019, 3026, 1)
INSERT [dbo].[SinhVien] ([maSinhVien], [hotenSinhVien], [ngaySinh], [gioiTinh], [namNhapHoc], [idSinhVien], [idLop]) VALUES (N'SV3029', N'Hiếu', CAST(N'2024-04-16' AS Date), N'Nam', 2018, 3029, 1)
INSERT [dbo].[SinhVien] ([maSinhVien], [hotenSinhVien], [ngaySinh], [gioiTinh], [namNhapHoc], [idSinhVien], [idLop]) VALUES (N'SV4024', N'Phương', CAST(N'2019-02-16' AS Date), N'Nữ', 2010, 4024, 1001)
INSERT [dbo].[SinhVien] ([maSinhVien], [hotenSinhVien], [ngaySinh], [gioiTinh], [namNhapHoc], [idSinhVien], [idLop]) VALUES (N'SV4025', N'Hiệp', CAST(N'2003-06-12' AS Date), N'Nam', 2011, 4025, 1002)
INSERT [dbo].[SinhVien] ([maSinhVien], [hotenSinhVien], [ngaySinh], [gioiTinh], [namNhapHoc], [idSinhVien], [idLop]) VALUES (N'SV4026', N'Hiệp', CAST(N'2003-05-29' AS Date), N'Nữ', 2010, 4026, 1002)
INSERT [dbo].[SinhVien] ([maSinhVien], [hotenSinhVien], [ngaySinh], [gioiTinh], [namNhapHoc], [idSinhVien], [idLop]) VALUES (N'SV4028', N'Phương', CAST(N'2019-02-16' AS Date), N'Nam', 2018, 4028, 1001)
INSERT [dbo].[SinhVien] ([maSinhVien], [hotenSinhVien], [ngaySinh], [gioiTinh], [namNhapHoc], [idSinhVien], [idLop]) VALUES (N'SV4031', N'Sơn', CAST(N'2024-04-16' AS Date), N'Nữ', 2019, 4031, 1)
SET IDENTITY_INSERT [dbo].[SinhVien] OFF
GO
INSERT [dbo].[ThamGiaLopHoc] ([diemSo], [diemChu], [maKetQua], [idLopHocPhan], [idSinhVien]) VALUES (10, N'A       ', NULL, 1, 2018)
INSERT [dbo].[ThamGiaLopHoc] ([diemSo], [diemChu], [maKetQua], [idLopHocPhan], [idSinhVien]) VALUES (2.5, N'B       ', NULL, 1, 2025)
INSERT [dbo].[ThamGiaLopHoc] ([diemSo], [diemChu], [maKetQua], [idLopHocPhan], [idSinhVien]) VALUES (NULL, NULL, NULL, 1, 2026)
INSERT [dbo].[ThamGiaLopHoc] ([diemSo], [diemChu], [maKetQua], [idLopHocPhan], [idSinhVien]) VALUES (NULL, NULL, NULL, 1, 3019)
INSERT [dbo].[ThamGiaLopHoc] ([diemSo], [diemChu], [maKetQua], [idLopHocPhan], [idSinhVien]) VALUES (NULL, NULL, NULL, 1, 3023)
INSERT [dbo].[ThamGiaLopHoc] ([diemSo], [diemChu], [maKetQua], [idLopHocPhan], [idSinhVien]) VALUES (NULL, NULL, NULL, 1, 3026)
INSERT [dbo].[ThamGiaLopHoc] ([diemSo], [diemChu], [maKetQua], [idLopHocPhan], [idSinhVien]) VALUES (NULL, NULL, NULL, 1, 3029)
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [GiangVien_UNIQUE]    Script Date: 16/05/2024 12:15:12 SA ******/
ALTER TABLE [dbo].[GiangVien] ADD  CONSTRAINT [GiangVien_UNIQUE] UNIQUE NONCLUSTERED 
(
	[maGiangVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [LopHocPhan_UNIQUE]    Script Date: 16/05/2024 12:15:12 SA ******/
ALTER TABLE [dbo].[LopHocPhan] ADD  CONSTRAINT [LopHocPhan_UNIQUE] UNIQUE NONCLUSTERED 
(
	[maLopHocPhan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [MonHoc_UNIQUE]    Script Date: 16/05/2024 12:15:12 SA ******/
ALTER TABLE [dbo].[MonHoc] ADD  CONSTRAINT [MonHoc_UNIQUE] UNIQUE NONCLUSTERED 
(
	[maMonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [NganhHoc_UNIQUE]    Script Date: 16/05/2024 12:15:12 SA ******/
ALTER TABLE [dbo].[NganhHoc] ADD  CONSTRAINT [NganhHoc_UNIQUE] UNIQUE NONCLUSTERED 
(
	[maNganhHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [NguoiDung_UNIQUE]    Script Date: 16/05/2024 12:15:12 SA ******/
ALTER TABLE [dbo].[NguoiDung] ADD  CONSTRAINT [NguoiDung_UNIQUE] UNIQUE NONCLUSTERED 
(
	[idSinhVien] ASC,
	[idGiangVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [PhanChiaMonHoc_UNIQUE]    Script Date: 16/05/2024 12:15:12 SA ******/
ALTER TABLE [dbo].[PhanChiaMonHoc] ADD  CONSTRAINT [PhanChiaMonHoc_UNIQUE] UNIQUE NONCLUSTERED 
(
	[idNganhHoc] ASC,
	[idMonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [SinhVien_UNIQUE]    Script Date: 16/05/2024 12:15:12 SA ******/
ALTER TABLE [dbo].[SinhVien] ADD  CONSTRAINT [SinhVien_UNIQUE] UNIQUE NONCLUSTERED 
(
	[maSinhVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [Lop_GiangVien_FK] FOREIGN KEY([idGiangVien])
REFERENCES [dbo].[GiangVien] ([idGiangVien])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [Lop_GiangVien_FK]
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [Lop_NganhHoc_FK] FOREIGN KEY([idNganhHoc])
REFERENCES [dbo].[NganhHoc] ([idNganhHoc])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [Lop_NganhHoc_FK]
GO
ALTER TABLE [dbo].[LopHocPhan]  WITH CHECK ADD  CONSTRAINT [LopHocPhan_GiangVien_FK] FOREIGN KEY([idGiangVien])
REFERENCES [dbo].[GiangVien] ([idGiangVien])
GO
ALTER TABLE [dbo].[LopHocPhan] CHECK CONSTRAINT [LopHocPhan_GiangVien_FK]
GO
ALTER TABLE [dbo].[LopHocPhan]  WITH CHECK ADD  CONSTRAINT [LopHocPhan_MonHoc_FK] FOREIGN KEY([idMonHoc])
REFERENCES [dbo].[MonHoc] ([idMonHoc])
GO
ALTER TABLE [dbo].[LopHocPhan] CHECK CONSTRAINT [LopHocPhan_MonHoc_FK]
GO
ALTER TABLE [dbo].[MonHoc]  WITH CHECK ADD  CONSTRAINT [MonHoc_HinhThuc_FK] FOREIGN KEY([hinhThucDanhGia])
REFERENCES [dbo].[HinhThuc] ([hinhThucDanhGia])
GO
ALTER TABLE [dbo].[MonHoc] CHECK CONSTRAINT [MonHoc_HinhThuc_FK]
GO
ALTER TABLE [dbo].[NguoiDung]  WITH CHECK ADD  CONSTRAINT [NguoiDung_GiangVien_FK] FOREIGN KEY([idGiangVien])
REFERENCES [dbo].[GiangVien] ([idGiangVien])
GO
ALTER TABLE [dbo].[NguoiDung] CHECK CONSTRAINT [NguoiDung_GiangVien_FK]
GO
ALTER TABLE [dbo].[NguoiDung]  WITH CHECK ADD  CONSTRAINT [NguoiDung_SinhVien_FK] FOREIGN KEY([idSinhVien])
REFERENCES [dbo].[SinhVien] ([idSinhVien])
GO
ALTER TABLE [dbo].[NguoiDung] CHECK CONSTRAINT [NguoiDung_SinhVien_FK]
GO
ALTER TABLE [dbo].[PhanChiaMonHoc]  WITH CHECK ADD  CONSTRAINT [PhanChiaMonHoc_MonHoc_FK] FOREIGN KEY([idMonHoc])
REFERENCES [dbo].[MonHoc] ([idMonHoc])
GO
ALTER TABLE [dbo].[PhanChiaMonHoc] CHECK CONSTRAINT [PhanChiaMonHoc_MonHoc_FK]
GO
ALTER TABLE [dbo].[PhanChiaMonHoc]  WITH CHECK ADD  CONSTRAINT [PhanChiaMonHoc_NganhHoc_FK] FOREIGN KEY([idNganhHoc])
REFERENCES [dbo].[NganhHoc] ([idNganhHoc])
GO
ALTER TABLE [dbo].[PhanChiaMonHoc] CHECK CONSTRAINT [PhanChiaMonHoc_NganhHoc_FK]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [SinhVien_Lop_FK] FOREIGN KEY([idLop])
REFERENCES [dbo].[Lop] ([idLop])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [SinhVien_Lop_FK]
GO
ALTER TABLE [dbo].[ThamGiaLopHoc]  WITH CHECK ADD  CONSTRAINT [ThamGiaLopHoc_LopHocPhan_FK] FOREIGN KEY([idLopHocPhan])
REFERENCES [dbo].[LopHocPhan] ([idLopHocPhan])
GO
ALTER TABLE [dbo].[ThamGiaLopHoc] CHECK CONSTRAINT [ThamGiaLopHoc_LopHocPhan_FK]
GO
ALTER TABLE [dbo].[ThamGiaLopHoc]  WITH CHECK ADD  CONSTRAINT [ThamGiaLopHoc_SinhVien_FK] FOREIGN KEY([idSinhVien])
REFERENCES [dbo].[SinhVien] ([idSinhVien])
GO
ALTER TABLE [dbo].[ThamGiaLopHoc] CHECK CONSTRAINT [ThamGiaLopHoc_SinhVien_FK]
GO
