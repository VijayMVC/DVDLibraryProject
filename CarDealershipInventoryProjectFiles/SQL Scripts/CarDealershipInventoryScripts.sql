USE [master]
GO
/****** Object:  Database [CarDealershipInventory]    Script Date: 10/29/2015 9:22:38 AM ******/
CREATE DATABASE [CarDealershipInventory]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CarDealershipInventory', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQL2014\MSSQL\DATA\CarDealershipInventory.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CarDealershipInventory_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQL2014\MSSQL\DATA\CarDealershipInventory_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [CarDealershipInventory] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CarDealershipInventory].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CarDealershipInventory] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CarDealershipInventory] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CarDealershipInventory] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CarDealershipInventory] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CarDealershipInventory] SET ARITHABORT OFF 
GO
ALTER DATABASE [CarDealershipInventory] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CarDealershipInventory] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CarDealershipInventory] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CarDealershipInventory] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CarDealershipInventory] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CarDealershipInventory] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CarDealershipInventory] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CarDealershipInventory] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CarDealershipInventory] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CarDealershipInventory] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CarDealershipInventory] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CarDealershipInventory] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CarDealershipInventory] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CarDealershipInventory] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CarDealershipInventory] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CarDealershipInventory] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CarDealershipInventory] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CarDealershipInventory] SET RECOVERY FULL 
GO
ALTER DATABASE [CarDealershipInventory] SET  MULTI_USER 
GO
ALTER DATABASE [CarDealershipInventory] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CarDealershipInventory] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CarDealershipInventory] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CarDealershipInventory] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [CarDealershipInventory] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'CarDealershipInventory', N'ON'
GO
USE [CarDealershipInventory]
GO
/****** Object:  Table [dbo].[RequestForInfo]    Script Date: 10/29/2015 9:22:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RequestForInfo](
	[RequestID] [int] IDENTITY(1,1) NOT NULL,
	[VehicleID] [int] NOT NULL,
	[Name] [nvarchar](90) NOT NULL,
	[Email] [nvarchar](120) NOT NULL,
	[PhoneNumber] [nvarchar](20) NOT NULL,
	[BestTimeToCall] [nvarchar](90) NOT NULL,
	[PreferredContact] [nvarchar](120) NOT NULL,
	[TimeframeToPurchase] [nvarchar](120) NOT NULL,
	[AdditionalInfo] [nvarchar](500) NOT NULL,
	[LastContactDate] [datetime] NOT NULL DEFAULT (getdate()),
	[Status] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_RequestForInfo] PRIMARY KEY CLUSTERED 
(
	[RequestID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StatusOfRequest]    Script Date: 10/29/2015 9:22:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StatusOfRequest](
	[Status] [nvarchar](20) NOT NULL,
	[Description] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[Status] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Vehicle]    Script Date: 10/29/2015 9:22:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehicle](
	[VehicleID] [int] IDENTITY(1,1) NOT NULL,
	[Make] [nvarchar](30) NOT NULL,
	[Model] [nvarchar](30) NOT NULL,
	[Year] [date] NOT NULL,
	[Mileage] [int] NOT NULL,
	[AdTitle] [nvarchar](100) NULL,
	[Description] [nvarchar](3000) NULL,
	[Price] [decimal](8, 2) NULL,
	[urlPicture] [nvarchar](500) NULL,
	[isAvailable] [bit] NOT NULL,
 CONSTRAINT [PK_Vehicle] PRIMARY KEY CLUSTERED 
(
	[VehicleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
USE [master]
GO
ALTER DATABASE [CarDealershipInventory] SET  READ_WRITE 
GO
