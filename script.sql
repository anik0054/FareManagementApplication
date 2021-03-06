USE [master]
GO
/****** Object:  Database [FareDB]    Script Date: 5/27/2015 9:33:15 PM ******/
CREATE DATABASE [FareDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FareDB', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\FareDB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'FareDB_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\FareDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [FareDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FareDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FareDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FareDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FareDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FareDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FareDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [FareDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FareDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [FareDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FareDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FareDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FareDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FareDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FareDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FareDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FareDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FareDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FareDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FareDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FareDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FareDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FareDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FareDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FareDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FareDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FareDB] SET  MULTI_USER 
GO
ALTER DATABASE [FareDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FareDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FareDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FareDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [FareDB]
GO
/****** Object:  Table [dbo].[VisitorTable]    Script Date: 5/27/2015 9:33:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VisitorTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[ContactNumber] [varchar](50) NOT NULL,
 CONSTRAINT [PK_VisitorTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VisitorZoneTable]    Script Date: 5/27/2015 9:33:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VisitorZoneTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[VisitorId] [int] NOT NULL,
	[ZoneId] [int] NOT NULL,
 CONSTRAINT [PK_VisitorZoneTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ZoneTable]    Script Date: 5/27/2015 9:33:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ZoneTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ZoneTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[VisitorZone]    Script Date: 5/27/2015 9:33:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VisitorZone] AS
SELECT VisitorTable.Id AS VisitorId,VisitorTable.Name AS VisitorName, VisitorTable.Email AS VisitorEmail,VisitorTable.ContactNumber AS VisitorContactNumber, ZoneTable.Id AS ZoneId, ZoneTable.Name AS ZoneName
FROM VisitorTable
INNER JOIN VisitorZoneTable
ON VisitorTable.Id=VisitorZoneTable.VisitorId
INNER JOIN ZoneTable
ON VisitorZoneTable.ZoneId=ZoneTable.Id


GO
SET IDENTITY_INSERT [dbo].[VisitorTable] ON 

INSERT [dbo].[VisitorTable] ([Id], [Name], [Email], [ContactNumber]) VALUES (1, N'Anik', N'anik@gmail.com', N'01738363937')
INSERT [dbo].[VisitorTable] ([Id], [Name], [Email], [ContactNumber]) VALUES (2, N'Asif', N'asif@gmail.com', N'01736386934')
SET IDENTITY_INSERT [dbo].[VisitorTable] OFF
SET IDENTITY_INSERT [dbo].[VisitorZoneTable] ON 

INSERT [dbo].[VisitorZoneTable] ([Id], [VisitorId], [ZoneId]) VALUES (1, 1, 1)
INSERT [dbo].[VisitorZoneTable] ([Id], [VisitorId], [ZoneId]) VALUES (2, 1, 2)
INSERT [dbo].[VisitorZoneTable] ([Id], [VisitorId], [ZoneId]) VALUES (3, 2, 1)
INSERT [dbo].[VisitorZoneTable] ([Id], [VisitorId], [ZoneId]) VALUES (4, 2, 2)
INSERT [dbo].[VisitorZoneTable] ([Id], [VisitorId], [ZoneId]) VALUES (5, 2, 3)
INSERT [dbo].[VisitorZoneTable] ([Id], [VisitorId], [ZoneId]) VALUES (6, 2, 4)
INSERT [dbo].[VisitorZoneTable] ([Id], [VisitorId], [ZoneId]) VALUES (7, 2, 5)
SET IDENTITY_INSERT [dbo].[VisitorZoneTable] OFF
SET IDENTITY_INSERT [dbo].[ZoneTable] ON 

INSERT [dbo].[ZoneTable] ([Id], [Name]) VALUES (1, N'Enterprize Application Zone')
INSERT [dbo].[ZoneTable] ([Id], [Name]) VALUES (2, N'Mobile Apps Zone')
INSERT [dbo].[ZoneTable] ([Id], [Name]) VALUES (3, N'Games & Multimedia Zone')
INSERT [dbo].[ZoneTable] ([Id], [Name]) VALUES (4, N'Telecom Sofatware Zone')
INSERT [dbo].[ZoneTable] ([Id], [Name]) VALUES (5, N'Digital Bangladesh Zone')
SET IDENTITY_INSERT [dbo].[ZoneTable] OFF
/****** Object:  Index [IX_VisitorTable]    Script Date: 5/27/2015 9:33:16 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_VisitorTable] ON [dbo].[VisitorTable]
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_VisitorZoneTable]    Script Date: 5/27/2015 9:33:16 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_VisitorZoneTable] ON [dbo].[VisitorZoneTable]
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ZoneTable]    Script Date: 5/27/2015 9:33:16 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_ZoneTable] ON [dbo].[ZoneTable]
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[VisitorZoneTable]  WITH CHECK ADD  CONSTRAINT [FK_VisitorZoneTable_VisitorTable] FOREIGN KEY([VisitorId])
REFERENCES [dbo].[VisitorTable] ([Id])
GO
ALTER TABLE [dbo].[VisitorZoneTable] CHECK CONSTRAINT [FK_VisitorZoneTable_VisitorTable]
GO
ALTER TABLE [dbo].[VisitorZoneTable]  WITH CHECK ADD  CONSTRAINT [FK_VisitorZoneTable_ZoneTable] FOREIGN KEY([ZoneId])
REFERENCES [dbo].[ZoneTable] ([Id])
GO
ALTER TABLE [dbo].[VisitorZoneTable] CHECK CONSTRAINT [FK_VisitorZoneTable_ZoneTable]
GO
USE [master]
GO
ALTER DATABASE [FareDB] SET  READ_WRITE 
GO
