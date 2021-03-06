USE [master]
GO
/****** Object:  Database [stockmgmtsystem]    Script Date: 6/23/2019 11:53:31 AM ******/
CREATE DATABASE [stockmgmtsystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'stockmgmtsystem', FILENAME = N'E:\Github Repo\CP\Implementation\Back End\stockmgmtsystem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'stockmgmtsystem_log', FILENAME = N'E:\Github Repo\CP\Implementation\Back End\stockmgmtsystem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [stockmgmtsystem] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [stockmgmtsystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [stockmgmtsystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [stockmgmtsystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [stockmgmtsystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [stockmgmtsystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [stockmgmtsystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [stockmgmtsystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [stockmgmtsystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [stockmgmtsystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [stockmgmtsystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [stockmgmtsystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [stockmgmtsystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [stockmgmtsystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [stockmgmtsystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [stockmgmtsystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [stockmgmtsystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [stockmgmtsystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [stockmgmtsystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [stockmgmtsystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [stockmgmtsystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [stockmgmtsystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [stockmgmtsystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [stockmgmtsystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [stockmgmtsystem] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [stockmgmtsystem] SET  MULTI_USER 
GO
ALTER DATABASE [stockmgmtsystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [stockmgmtsystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [stockmgmtsystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [stockmgmtsystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [stockmgmtsystem] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [stockmgmtsystem] SET QUERY_STORE = OFF
GO
USE [stockmgmtsystem]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 6/23/2019 11:53:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[BillId] [int] IDENTITY(1,1) NOT NULL,
	[TotalAmount] [decimal](19, 2) NOT NULL,
	[CustomerId] [int] NULL,
 CONSTRAINT [Pk_BillId] PRIMARY KEY CLUSTERED 
(
	[BillId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[discount]    Script Date: 6/23/2019 11:53:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[discount](
	[discount] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Liquor]    Script Date: 6/23/2019 11:53:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Liquor](
	[LiquorId] [int] IDENTITY(1,1) NOT NULL,
	[LiquorName] [varchar](255) NOT NULL,
	[LiquorPrice] [decimal](19, 2) NOT NULL,
	[CategoryId] [int] NOT NULL,
 CONSTRAINT [Pk_LiquorId] PRIMARY KEY CLUSTERED 
(
	[LiquorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LiquorBill]    Script Date: 6/23/2019 11:53:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LiquorBill](
	[BillId] [int] NOT NULL,
	[LiquorId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LiquorCategory]    Script Date: 6/23/2019 11:53:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LiquorCategory](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [varchar](255) NOT NULL,
 CONSTRAINT [Pk_CategoryId] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LiquorQuantity]    Script Date: 6/23/2019 11:53:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LiquorQuantity](
	[LiquorId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Threshold] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoyalCustomer]    Script Date: 6/23/2019 11:53:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoyalCustomer](
	[LoyalCustomerId] [int] IDENTITY(1,1) NOT NULL,
	[Email] [varchar](255) NOT NULL,
	[Points] [int] NOT NULL,
 CONSTRAINT [Pk_LoyalCustomerId] PRIMARY KEY CLUSTERED 
(
	[LoyalCustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [Uk_Email] UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 6/23/2019 11:53:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Pin] [nvarchar](255) NOT NULL,
	[Recoverycode] [nvarchar](255) NOT NULL,
 CONSTRAINT [Pk_Pin] PRIMARY KEY CLUSTERED 
(
	[Pin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[LoyalCustomer] ([LoyalCustomerId])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_CustomerId]
GO
ALTER TABLE [dbo].[Liquor]  WITH CHECK ADD  CONSTRAINT [FK_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[LiquorCategory] ([CategoryId])
GO
ALTER TABLE [dbo].[Liquor] CHECK CONSTRAINT [FK_CategoryId]
GO
ALTER TABLE [dbo].[LiquorBill]  WITH CHECK ADD  CONSTRAINT [Fk_BillId] FOREIGN KEY([BillId])
REFERENCES [dbo].[Bill] ([BillId])
GO
ALTER TABLE [dbo].[LiquorBill] CHECK CONSTRAINT [Fk_BillId]
GO
ALTER TABLE [dbo].[LiquorBill]  WITH CHECK ADD  CONSTRAINT [Fk_LiquorId2] FOREIGN KEY([LiquorId])
REFERENCES [dbo].[Liquor] ([LiquorId])
GO
ALTER TABLE [dbo].[LiquorBill] CHECK CONSTRAINT [Fk_LiquorId2]
GO
ALTER TABLE [dbo].[LiquorQuantity]  WITH CHECK ADD  CONSTRAINT [Fk_LiquorId] FOREIGN KEY([LiquorId])
REFERENCES [dbo].[Liquor] ([LiquorId])
GO
ALTER TABLE [dbo].[LiquorQuantity] CHECK CONSTRAINT [Fk_LiquorId]
GO
INSERT INTO [dbo].[discount] VALUES (5)
GO
INSERT INTO [dbo].[LiquorCategory] VALUES ('vodka') , ('rum'), ('whiskey'), ('red wine')
Go
USE [master]
GO
ALTER DATABASE [stockmgmtsystem] SET  READ_WRITE 
GO
