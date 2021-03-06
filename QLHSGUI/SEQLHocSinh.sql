USE [SEQLHocSinh]
GO
/****** Object:  Table [dbo].[HocSinh]    Script Date: 3/12/2018 11:20:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HocSinh](
	[MaHS] [varchar](20) NOT NULL,
	[TenHS] [nvarchar](100) NOT NULL,
	[NgaySinh] [datetime] NULL,
	[DiaChi] [nvarchar](150) NULL,
	[DTB] [real] NULL,
	[MaLop] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 3/12/2018 11:20:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Lop](
	[MaLop] [varchar](20) NOT NULL,
	[TenLop] [nvarchar](100) NOT NULL,
	[SiSo] [smallint] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [DiaChi], [DTB], [MaLop]) VALUES (N'', N'Tèo Nguyễn', CAST(N'2016-03-22 14:11:32.243' AS DateTime), N'123 Ung Khiêm', 9.5, N'10A3')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [DiaChi], [DTB], [MaLop]) VALUES (N'HS0001', N'Nguyễn Thanh Tùng', CAST(N'1995-02-11 00:00:00.000' AS DateTime), N'123 Ký Con, Q12', 7.77, N'10A1')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [DiaChi], [DTB], [MaLop]) VALUES (N'HS0002', N'Lê Thanh Thủy', CAST(N'1995-02-23 00:00:00.000' AS DateTime), N'456 Lê Lợi, Q1', 6.66, N'10A1')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [DiaChi], [DTB], [MaLop]) VALUES (N'HS0003', N'Trần Ngọc Thanh', CAST(N'1990-01-30 20:53:44.000' AS DateTime), N'222 Lê Văn Sỹ, Quận 3, TpHCM', 8.77, N'10A1')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [DiaChi], [DTB], [MaLop]) VALUES (N'HS0004', N'Lương Ngọc Hân', CAST(N'2011-05-26 19:57:49.097' AS DateTime), N'123 An Dương Vương', 9.87, N'10A1')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [DiaChi], [DTB], [MaLop]) VALUES (N'HS0005', N'Tèo Nguyễn', CAST(N'2016-03-22 14:11:32.243' AS DateTime), N'123 Ung Khiêm', 9.5, N'10A3')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [DiaChi], [DTB], [MaLop]) VALUES (N'HS0006', N'Lê Thanh Thủy', CAST(N'2016-03-22 16:40:11.010' AS DateTime), N'123 QL1', 6, N'10A1')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SiSo]) VALUES (N'10A1', N'Lớp 10A1', 30)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SiSo]) VALUES (N'10A2', N'Lớp 10A2', 25)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SiSo]) VALUES (N'10A3', N'Lớp 10A3', 22)
ALTER TABLE [dbo].[HocSinh]  WITH CHECK ADD  CONSTRAINT [FK_HocSinh_Lop] FOREIGN KEY([MaLop])
REFERENCES [dbo].[Lop] ([MaLop])
GO
ALTER TABLE [dbo].[HocSinh] CHECK CONSTRAINT [FK_HocSinh_Lop]
GO
/****** Object:  StoredProcedure [dbo].[spThem]    Script Date: 3/12/2018 11:20:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spThem] 
	-- Add the parameters for the stored procedure here
	@Ma  VARCHAR(20),
	@Ten NVARCHAR(100),
	@SiSo SMALLINT
AS
BEGIN
	INSERT INTO Lop(MaLop,TenLop,SiSo)
	VALUES(@Ma,@Ten,@SiSo)
END

GO
