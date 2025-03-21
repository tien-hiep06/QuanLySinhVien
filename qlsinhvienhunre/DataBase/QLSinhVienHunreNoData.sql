USE [qlsinhvienhunre]
GO
/****** Object:  Table [dbo].[GiangVien]    Script Date: 16/05/2024 12:14:32 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiangVien](
	[maGiangVien] [varchar](50) NULL,
	[hotenGiangVien] [nvarchar](50) NULL,
	[ngaySinh] [date] NULL,
	[gioiTinh] [nvarchar](5) NULL,
	[idGiangVien] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [GiangVien_PK] PRIMARY KEY CLUSTERED 
(
	[idGiangVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [GiangVien_UNIQUE] UNIQUE NONCLUSTERED 
(
	[maGiangVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HinhThuc]    Script Date: 16/05/2024 12:14:32 SA ******/
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
/****** Object:  Table [dbo].[Lop]    Script Date: 16/05/2024 12:14:32 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[maLop] [varchar](50) NULL,
	[idLop] [int] IDENTITY(1,1) NOT NULL,
	[idNganhHoc] [int] NULL,
	[idGiangVien] [int] NULL,
 CONSTRAINT [Lop_PK] PRIMARY KEY CLUSTERED 
(
	[idLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LopHocPhan]    Script Date: 16/05/2024 12:14:32 SA ******/
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
	[idLopHocPhan] [int] IDENTITY(1,1) NOT NULL,
	[idGiangVien] [int] NULL,
	[idMonHoc] [int] NULL,
 CONSTRAINT [LopHocPhan_PK] PRIMARY KEY CLUSTERED 
(
	[idLopHocPhan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [LopHocPhan_UNIQUE] UNIQUE NONCLUSTERED 
(
	[maLopHocPhan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 16/05/2024 12:14:32 SA ******/
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
	[idMonHoc] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [MonHoc_PK] PRIMARY KEY CLUSTERED 
(
	[idMonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [MonHoc_UNIQUE] UNIQUE NONCLUSTERED 
(
	[maMonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NganhHoc]    Script Date: 16/05/2024 12:14:32 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NganhHoc](
	[maNganhHoc] [varchar](50) NOT NULL,
	[tenNganhHoc] [nvarchar](max) NULL,
	[soTinChi] [int] NULL,
	[namBatDau] [int] NULL,
	[idNganhHoc] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [NganhHoc_PK] PRIMARY KEY CLUSTERED 
(
	[idNganhHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [NganhHoc_UNIQUE] UNIQUE NONCLUSTERED 
(
	[maNganhHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 16/05/2024 12:14:32 SA ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [NguoiDung_UNIQUE] UNIQUE NONCLUSTERED 
(
	[idSinhVien] ASC,
	[idGiangVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhanChiaMonHoc]    Script Date: 16/05/2024 12:14:32 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanChiaMonHoc](
	[idNganhHoc] [int] NOT NULL,
	[idMonHoc] [int] NOT NULL,
	[idChiaMon] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PhanChiaMonHoc_PK] PRIMARY KEY CLUSTERED 
(
	[idChiaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [PhanChiaMonHoc_UNIQUE] UNIQUE NONCLUSTERED 
(
	[idNganhHoc] ASC,
	[idMonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 16/05/2024 12:14:32 SA ******/
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
	[idSinhVien] [int] IDENTITY(1,1) NOT NULL,
	[idLop] [int] NULL,
 CONSTRAINT [SinhVien_PK] PRIMARY KEY CLUSTERED 
(
	[idSinhVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [SinhVien_UNIQUE] UNIQUE NONCLUSTERED 
(
	[maSinhVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThamGiaLopHoc]    Script Date: 16/05/2024 12:14:32 SA ******/
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
INSERT [dbo].[NguoiDung] ([chucVu], [matKhau], [idNguoiDung], [idSinhVien], [idGiangVien]) VALUES (N'ADMIN', N'123456ADMIN', 0, NULL, NULL)