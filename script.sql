USE [master]
GO
/****** Object:  Database [VideoStoreManagementContext-9f99a30d-566c-4e97-a3d7-be840175e342]    Script Date: 20/08/2020 9:12:17 AM ******/
CREATE DATABASE [VideoStoreManagementContext-9f99a30d-566c-4e97-a3d7-be840175e342]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VideoStoreManagementContext-9f99a30d-566c-4e97-a3d7-be840175e342', FILENAME = N'C:\Users\cdup\VideoStoreManagementContext-9f99a30d-566c-4e97-a3d7-be840175e342.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'VideoStoreManagementContext-9f99a30d-566c-4e97-a3d7-be840175e342_log', FILENAME = N'C:\Users\cdup\VideoStoreManagementContext-9f99a30d-566c-4e97-a3d7-be840175e342_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [VideoStoreManagementContext-9f99a30d-566c-4e97-a3d7-be840175e342] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VideoStoreManagementContext-9f99a30d-566c-4e97-a3d7-be840175e342].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VideoStoreManagementContext-9f99a30d-566c-4e97-a3d7-be840175e342] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VideoStoreManagementContext-9f99a30d-566c-4e97-a3d7-be840175e342] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VideoStoreManagementContext-9f99a30d-566c-4e97-a3d7-be840175e342] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VideoStoreManagementContext-9f99a30d-566c-4e97-a3d7-be840175e342] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VideoStoreManagementContext-9f99a30d-566c-4e97-a3d7-be840175e342] SET ARITHABORT OFF 
GO
ALTER DATABASE [VideoStoreManagementContext-9f99a30d-566c-4e97-a3d7-be840175e342] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [VideoStoreManagementContext-9f99a30d-566c-4e97-a3d7-be840175e342] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VideoStoreManagementContext-9f99a30d-566c-4e97-a3d7-be840175e342] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VideoStoreManagementContext-9f99a30d-566c-4e97-a3d7-be840175e342] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VideoStoreManagementContext-9f99a30d-566c-4e97-a3d7-be840175e342] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VideoStoreManagementContext-9f99a30d-566c-4e97-a3d7-be840175e342] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VideoStoreManagementContext-9f99a30d-566c-4e97-a3d7-be840175e342] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VideoStoreManagementContext-9f99a30d-566c-4e97-a3d7-be840175e342] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VideoStoreManagementContext-9f99a30d-566c-4e97-a3d7-be840175e342] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VideoStoreManagementContext-9f99a30d-566c-4e97-a3d7-be840175e342] SET  ENABLE_BROKER 
GO
ALTER DATABASE [VideoStoreManagementContext-9f99a30d-566c-4e97-a3d7-be840175e342] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VideoStoreManagementContext-9f99a30d-566c-4e97-a3d7-be840175e342] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VideoStoreManagementContext-9f99a30d-566c-4e97-a3d7-be840175e342] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VideoStoreManagementContext-9f99a30d-566c-4e97-a3d7-be840175e342] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VideoStoreManagementContext-9f99a30d-566c-4e97-a3d7-be840175e342] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VideoStoreManagementContext-9f99a30d-566c-4e97-a3d7-be840175e342] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [VideoStoreManagementContext-9f99a30d-566c-4e97-a3d7-be840175e342] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VideoStoreManagementContext-9f99a30d-566c-4e97-a3d7-be840175e342] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [VideoStoreManagementContext-9f99a30d-566c-4e97-a3d7-be840175e342] SET  MULTI_USER 
GO
ALTER DATABASE [VideoStoreManagementContext-9f99a30d-566c-4e97-a3d7-be840175e342] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VideoStoreManagementContext-9f99a30d-566c-4e97-a3d7-be840175e342] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VideoStoreManagementContext-9f99a30d-566c-4e97-a3d7-be840175e342] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VideoStoreManagementContext-9f99a30d-566c-4e97-a3d7-be840175e342] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [VideoStoreManagementContext-9f99a30d-566c-4e97-a3d7-be840175e342] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [VideoStoreManagementContext-9f99a30d-566c-4e97-a3d7-be840175e342] SET QUERY_STORE = OFF
GO
USE [VideoStoreManagementContext-9f99a30d-566c-4e97-a3d7-be840175e342]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [VideoStoreManagementContext-9f99a30d-566c-4e97-a3d7-be840175e342]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 20/08/2020 9:12:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 20/08/2020 9:12:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[Phone] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movie]    Script Date: 20/08/2020 9:12:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movie](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NOT NULL,
	[Release] [datetime2](7) NOT NULL,
	[Copies] [int] NOT NULL,
	[Cost] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Movie] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MovieRental]    Script Date: 20/08/2020 9:12:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MovieRental](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DateIsued] [datetime2](7) NOT NULL,
	[DateReterned] [datetime2](7) NOT NULL,
	[IsMovieLateReturned] [bit] NOT NULL,
	[MovieFK] [int] NOT NULL,
	[CustomerFK] [int] NOT NULL,
 CONSTRAINT [PK_MovieRental] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200814014828_VideoStoreMDB', N'3.1.6')
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([Id], [FirstName], [LastName], [Address], [Phone]) VALUES (1, N'Carel', N'du Plessis', N'131 Huntington, Hamilton', N'122332432434')
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Movie] ON 

INSERT [dbo].[Movie] ([Id], [Title], [Release], [Copies], [Cost]) VALUES (2, N'aa', CAST(N'2020-08-05T15:42:00.0000000' AS DateTime2), 2, CAST(5.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Movie] OFF
GO
SET IDENTITY_INSERT [dbo].[MovieRental] ON 

INSERT [dbo].[MovieRental] ([Id], [DateIsued], [DateReterned], [IsMovieLateReturned], [MovieFK], [CustomerFK]) VALUES (3, CAST(N'2020-08-04T15:42:00.0000000' AS DateTime2), CAST(N'2020-08-11T15:42:00.0000000' AS DateTime2), 0, 2, 1)
SET IDENTITY_INSERT [dbo].[MovieRental] OFF
GO
/****** Object:  Index [IX_MovieRental_CustomerFK]    Script Date: 20/08/2020 9:12:17 AM ******/
CREATE NONCLUSTERED INDEX [IX_MovieRental_CustomerFK] ON [dbo].[MovieRental]
(
	[CustomerFK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MovieRental_MovieFK]    Script Date: 20/08/2020 9:12:17 AM ******/
CREATE NONCLUSTERED INDEX [IX_MovieRental_MovieFK] ON [dbo].[MovieRental]
(
	[MovieFK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[MovieRental]  WITH CHECK ADD  CONSTRAINT [FK_MovieRental_Customer_CustomerFK] FOREIGN KEY([CustomerFK])
REFERENCES [dbo].[Customer] ([Id])
GO
ALTER TABLE [dbo].[MovieRental] CHECK CONSTRAINT [FK_MovieRental_Customer_CustomerFK]
GO
ALTER TABLE [dbo].[MovieRental]  WITH CHECK ADD  CONSTRAINT [FK_MovieRental_Movie_MovieFK] FOREIGN KEY([MovieFK])
REFERENCES [dbo].[Movie] ([Id])
GO
ALTER TABLE [dbo].[MovieRental] CHECK CONSTRAINT [FK_MovieRental_Movie_MovieFK]
GO
USE [master]
GO
ALTER DATABASE [VideoStoreManagementContext-9f99a30d-566c-4e97-a3d7-be840175e342] SET  READ_WRITE 
GO
