USE [QLThueVayCuoi]
GO
/****** Object:  Table [dbo].[chitietphieuthue]    Script Date: 11/10/2023 09:19:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chitietphieuthue](
	[chitietphieuthue] [int] NOT NULL,
	[sophieu] [int] NULL,
	[masp] [int] NULL,
	[soluong] [int] NOT NULL,
	[hoadon] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[chitietphieuthue] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[khachhang]    Script Date: 11/10/2023 09:19:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khachhang](
	[makh] [int] NOT NULL,
	[tenkh] [nvarchar](50) NOT NULL,
	[diachi] [nvarchar](200) NULL,
	[sodienthoai] [nvarchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[makh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 11/10/2023 09:19:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhanvien](
	[manhanvien] [varchar](10) NOT NULL,
	[tennhanvien] [nvarchar](100) NULL,
	[ngaysinh] [date] NULL,
	[email] [nvarchar](100) NULL,
	[sodienthoainv] [varchar](15) NULL,
	[diachi] [nvarchar](200) NULL,
	[sodonhang] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[manhanvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sanphamthue]    Script Date: 11/10/2023 09:19:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sanphamthue](
	[masp] [int] NOT NULL,
	[tensp] [nvarchar](100) NOT NULL,
	[nuocsx] [nvarchar](50) NULL,
	[tinhtrangsp] [nvarchar](100) NULL,
	[giavon] [int] NOT NULL,
	[giathue1ngay] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[masp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[thue]    Script Date: 11/10/2023 09:19:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[thue](
	[sophieu] [int] NOT NULL,
	[makh] [int] NULL,
	[ngaychothue] [date] NOT NULL,
	[ngaytra] [date] NULL,
	[tientradutinh] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[sophieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tknhanvien]    Script Date: 11/10/2023 09:19:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tknhanvien](
	[manhanvien] [varchar](10) NOT NULL,
	[taikhoan] [nvarchar](100) NULL,
	[matkhau] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[manhanvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[chitietphieuthue] ([chitietphieuthue], [sophieu], [masp], [soluong], [hoadon]) VALUES (1, 1, 1, 1, CAST(30.00 AS Decimal(10, 2)))
INSERT [dbo].[chitietphieuthue] ([chitietphieuthue], [sophieu], [masp], [soluong], [hoadon]) VALUES (2, 2, 2, 1, CAST(90.00 AS Decimal(10, 2)))
INSERT [dbo].[chitietphieuthue] ([chitietphieuthue], [sophieu], [masp], [soluong], [hoadon]) VALUES (3, 2, 3, 1, CAST(15.00 AS Decimal(10, 2)))
INSERT [dbo].[chitietphieuthue] ([chitietphieuthue], [sophieu], [masp], [soluong], [hoadon]) VALUES (4, 3, 2, 1, CAST(50.00 AS Decimal(10, 2)))
INSERT [dbo].[chitietphieuthue] ([chitietphieuthue], [sophieu], [masp], [soluong], [hoadon]) VALUES (5, 2, 2, 2, CAST(10.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[khachhang] ([makh], [tenkh], [diachi], [sodienthoai]) VALUES (1, N'Huỳnh Long Vũ', N'622 Cộng Hoà', N'123-456-7890')
INSERT [dbo].[khachhang] ([makh], [tenkh], [diachi], [sodienthoai]) VALUES (2, N'Mai Thị Ngọc Vân', N'456 Ký Ức ', N'987-654-3210')
INSERT [dbo].[khachhang] ([makh], [tenkh], [diachi], [sodienthoai]) VALUES (3, N'Mưa Thiếu Mây', N'009 Phạm Hữu Nhật', N'555-555-5555')
INSERT [dbo].[khachhang] ([makh], [tenkh], [diachi], [sodienthoai]) VALUES (4, N'Nguyễn Thái Sơn', N'67 HIệp Bình ', N'09986651')
INSERT [dbo].[khachhang] ([makh], [tenkh], [diachi], [sodienthoai]) VALUES (5, N'Đế THiên', N'không có', N'0099887')
GO
INSERT [dbo].[nhanvien] ([manhanvien], [tennhanvien], [ngaysinh], [email], [sodienthoainv], [diachi], [sodonhang]) VALUES (N'NV01', N'Nguyễn Thanh Hơn', CAST(N'2002-08-29' AS Date), N'nguyenthanhhon@gmail.com', N'0123-456-7890', N'123 Đường Cộng Hoà, phường 13, quận Tân Bình', 2)
INSERT [dbo].[nhanvien] ([manhanvien], [tennhanvien], [ngaysinh], [email], [sodienthoainv], [diachi], [sodonhang]) VALUES (N'NV02', N'Vũ Minh Đức', CAST(N'2002-06-25' AS Date), N'ducpan@gmail.com', N'0987-654-3210', N'234 Đường Sài Gòn, phường 3, quận 4, quận 4', 1)
INSERT [dbo].[nhanvien] ([manhanvien], [tennhanvien], [ngaysinh], [email], [sodienthoainv], [diachi], [sodonhang]) VALUES (N'NV03', N'Huỳnh Long Vũ', CAST(N'2002-11-16' AS Date), N'gosuzero2002@gmail.com', N'0932-113-3210', N'123 Đường Đến Tim Em, phường 2, quận Thủ Đức', 3)
GO
INSERT [dbo].[sanphamthue] ([masp], [tensp], [nuocsx], [tinhtrangsp], [giavon], [giathue1ngay]) VALUES (1, N'VÁY TÙNG TO', N'USA', N'Mới, Chưa cho thuê', 20000, CAST(15.00 AS Decimal(10, 2)))
INSERT [dbo].[sanphamthue] ([masp], [tensp], [nuocsx], [tinhtrangsp], [giavon], [giathue1ngay]) VALUES (2, N'VÁY CƯỚI ĐƠN GIẢN ', N'Canada', N'Còn mới, Đã cọc', 40000, CAST(25.00 AS Decimal(10, 2)))
INSERT [dbo].[sanphamthue] ([masp], [tensp], [nuocsx], [tinhtrangsp], [giavon], [giathue1ngay]) VALUES (3, N'VÁY ĐUÔI CÁ', N'Vietnam', N'Đang cho thuê', 10000, CAST(30.00 AS Decimal(10, 2)))
INSERT [dbo].[sanphamthue] ([masp], [tensp], [nuocsx], [tinhtrangsp], [giavon], [giathue1ngay]) VALUES (4, N'VÁY CƯỚI THÙNG ', N'ĐỨC', N'MỚI', 40500, CAST(24.00 AS Decimal(10, 2)))
INSERT [dbo].[sanphamthue] ([masp], [tensp], [nuocsx], [tinhtrangsp], [giavon], [giathue1ngay]) VALUES (5, N'ÁO CƯỚI CHÚ RỂ', N'ĐỨC', N'Mới Toanh', 75000, CAST(50.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[thue] ([sophieu], [makh], [ngaychothue], [ngaytra], [tientradutinh]) VALUES (1, 2, CAST(N'2023-09-01' AS Date), CAST(N'2023-09-03' AS Date), CAST(75.00 AS Decimal(10, 2)))
INSERT [dbo].[thue] ([sophieu], [makh], [ngaychothue], [ngaytra], [tientradutinh]) VALUES (2, 3, CAST(N'2023-09-02' AS Date), CAST(N'2023-09-04' AS Date), CAST(90.00 AS Decimal(10, 2)))
INSERT [dbo].[thue] ([sophieu], [makh], [ngaychothue], [ngaytra], [tientradutinh]) VALUES (3, 1, CAST(N'2023-09-03' AS Date), NULL, CAST(15.00 AS Decimal(10, 2)))
INSERT [dbo].[thue] ([sophieu], [makh], [ngaychothue], [ngaytra], [tientradutinh]) VALUES (4, 4, CAST(N'2023-10-10' AS Date), CAST(N'2023-10-12' AS Date), CAST(50.00 AS Decimal(10, 2)))
INSERT [dbo].[thue] ([sophieu], [makh], [ngaychothue], [ngaytra], [tientradutinh]) VALUES (5, 3, CAST(N'2023-10-22' AS Date), CAST(N'2023-10-25' AS Date), CAST(60.00 AS Decimal(10, 2)))
INSERT [dbo].[thue] ([sophieu], [makh], [ngaychothue], [ngaytra], [tientradutinh]) VALUES (6, 3, CAST(N'2023-10-24' AS Date), CAST(N'2023-10-27' AS Date), CAST(123.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tknhanvien] ([manhanvien], [taikhoan], [matkhau]) VALUES (N'NV01', N'thanhon2982', N'thanhhon2908')
INSERT [dbo].[tknhanvien] ([manhanvien], [taikhoan], [matkhau]) VALUES (N'NV02', N'ducpan', N'panpanshopee')
INSERT [dbo].[tknhanvien] ([manhanvien], [taikhoan], [matkhau]) VALUES (N'NV03', N'gosu', N'16112002')
GO
ALTER TABLE [dbo].[chitietphieuthue]  WITH CHECK ADD FOREIGN KEY([sophieu])
REFERENCES [dbo].[thue] ([sophieu])
GO
ALTER TABLE [dbo].[chitietphieuthue]  WITH CHECK ADD FOREIGN KEY([masp])
REFERENCES [dbo].[sanphamthue] ([masp])
GO
ALTER TABLE [dbo].[nhanvien]  WITH CHECK ADD FOREIGN KEY([manhanvien])
REFERENCES [dbo].[tknhanvien] ([manhanvien])
GO
ALTER TABLE [dbo].[thue]  WITH CHECK ADD FOREIGN KEY([makh])
REFERENCES [dbo].[khachhang] ([makh])
GO
