USE [master]
GO
/****** Object:  Database [Db_DealershipManagment]    Script Date: 06.06.2024 0:21:24 ******/
CREATE DATABASE [Db_DealershipManagment]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Db_DealershipManagment', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Db_DealershipManagment.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Db_DealershipManagment_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Db_DealershipManagment_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Db_DealershipManagment] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Db_DealershipManagment].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Db_DealershipManagment] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Db_DealershipManagment] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Db_DealershipManagment] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Db_DealershipManagment] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Db_DealershipManagment] SET ARITHABORT OFF 
GO
ALTER DATABASE [Db_DealershipManagment] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Db_DealershipManagment] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Db_DealershipManagment] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Db_DealershipManagment] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Db_DealershipManagment] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Db_DealershipManagment] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Db_DealershipManagment] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Db_DealershipManagment] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Db_DealershipManagment] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Db_DealershipManagment] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Db_DealershipManagment] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Db_DealershipManagment] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Db_DealershipManagment] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Db_DealershipManagment] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Db_DealershipManagment] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Db_DealershipManagment] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Db_DealershipManagment] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Db_DealershipManagment] SET RECOVERY FULL 
GO
ALTER DATABASE [Db_DealershipManagment] SET  MULTI_USER 
GO
ALTER DATABASE [Db_DealershipManagment] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Db_DealershipManagment] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Db_DealershipManagment] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Db_DealershipManagment] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Db_DealershipManagment] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Db_DealershipManagment] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Db_DealershipManagment', N'ON'
GO
ALTER DATABASE [Db_DealershipManagment] SET QUERY_STORE = ON
GO
ALTER DATABASE [Db_DealershipManagment] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Db_DealershipManagment]
GO
/****** Object:  UserDefinedFunction [dbo].[HashPassword]    Script Date: 06.06.2024 0:21:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[HashPassword](@password VARCHAR(255))
RETURNS VARCHAR(255)
AS
BEGIN
    RETURN CONVERT(VARCHAR(255), HASHBYTES('SHA2_256', @password), 2)
END
GO
/****** Object:  Table [dbo].[Cars]    Script Date: 06.06.2024 0:21:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cars](
	[id_car] [uniqueidentifier] NOT NULL,
	[mark_id] [uniqueidentifier] NOT NULL,
	[drive] [int] NOT NULL,
	[transmission] [int] NOT NULL,
	[body_type] [int] NOT NULL,
	[engine_type] [int] NOT NULL,
	[release_year] [int] NOT NULL,
	[VIN] [nvarchar](17) NOT NULL,
	[price] [money] NOT NULL,
	[notes] [nvarchar](max) NULL,
	[status] [int] NOT NULL,
	[model] [nvarchar](100) NOT NULL,
	[color] [nvarchar](50) NULL,
	[power] [int] NULL,
 CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED 
(
	[id_car] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 06.06.2024 0:21:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[id_client] [uniqueidentifier] NOT NULL,
	[fio] [nvarchar](75) NOT NULL,
	[pass] [nvarchar](10) NOT NULL,
	[tel_num] [nvarchar](17) NOT NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[id_client] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marks]    Script Date: 06.06.2024 0:21:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marks](
	[id_mark] [uniqueidentifier] NOT NULL,
	[name_mark] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Marks] PRIMARY KEY CLUSTERED 
(
	[id_mark] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reports]    Script Date: 06.06.2024 0:21:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reports](
	[id_report] [uniqueidentifier] NOT NULL,
	[monthReport] [nvarchar](20) NOT NULL,
	[hoursWork] [int] NOT NULL,
	[salary] [money] NOT NULL,
	[prize] [money] NOT NULL,
	[worker_id] [uniqueidentifier] NOT NULL,
	[date_report] [datetime] NOT NULL,
 CONSTRAINT [PK_Reports] PRIMARY KEY CLUSTERED 
(
	[id_report] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Requests]    Script Date: 06.06.2024 0:21:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Requests](
	[id_request] [uniqueidentifier] NOT NULL,
	[car_id] [uniqueidentifier] NOT NULL,
	[status_zayavki] [int] NOT NULL,
	[notes] [nvarchar](max) NULL,
	[dateStartRepair] [datetime] NULL,
	[dateEndRepair] [datetime] NULL,
	[price] [money] NULL,
 CONSTRAINT [PK_Requests] PRIMARY KEY CLUSTERED 
(
	[id_request] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sales]    Script Date: 06.06.2024 0:21:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales](
	[id_sale] [uniqueidentifier] NOT NULL,
	[car_id] [uniqueidentifier] NOT NULL,
	[total] [money] NOT NULL,
	[client_id] [uniqueidentifier] NOT NULL,
	[worker_id] [uniqueidentifier] NOT NULL,
	[notes] [nvarchar](max) NULL,
	[date_sale] [datetime] NOT NULL,
 CONSTRAINT [PK_Sales] PRIMARY KEY CLUSTERED 
(
	[id_sale] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Workers]    Script Date: 06.06.2024 0:21:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Workers](
	[id_worker] [uniqueidentifier] NOT NULL,
	[fio] [nvarchar](75) NOT NULL,
	[pass] [nvarchar](10) NOT NULL,
	[tel_num] [nvarchar](17) NOT NULL,
	[role_id] [int] NOT NULL,
	[status] [int] NOT NULL,
	[login] [nvarchar](50) NOT NULL,
	[password] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_Workers] PRIMARY KEY CLUSTERED 
(
	[id_worker] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Cars] ([id_car], [mark_id], [drive], [transmission], [body_type], [engine_type], [release_year], [VIN], [price], [notes], [status], [model], [color], [power]) VALUES (N'84760353-0c6c-45bc-bf5d-0597b780ff3d', N'6e560227-2fbf-4ce2-976c-1664a7f43219', 2, 1, 2, 3, 2021, N'WAURD65438A139845', 500000.0000, N'', 3, N'E-Class', N'Красный', 120)
INSERT [dbo].[Cars] ([id_car], [mark_id], [drive], [transmission], [body_type], [engine_type], [release_year], [VIN], [price], [notes], [status], [model], [color], [power]) VALUES (N'714929e9-0a54-4561-82a7-5c2ab3e9d325', N'c73892fb-37c3-4076-9f72-61d845e0dc6b', 1, 1, 3, 2, 2022, N'WBAET37422NJ43237', 450000.0000, N'', 1, N'A4', N'Синий', 140)
INSERT [dbo].[Cars] ([id_car], [mark_id], [drive], [transmission], [body_type], [engine_type], [release_year], [VIN], [price], [notes], [status], [model], [color], [power]) VALUES (N'3f284d4c-6cde-44dc-ba85-62e5db0a2c91', N'38f6d726-111d-40f0-b79f-71b5f1b09728', 1, 2, 3, 1, 2020, N'1FTFW1EF5CFB23945', 300000.0000, N'', 0, N'Civic', N'Синий', 133)
INSERT [dbo].[Cars] ([id_car], [mark_id], [drive], [transmission], [body_type], [engine_type], [release_year], [VIN], [price], [notes], [status], [model], [color], [power]) VALUES (N'63d0024c-bd4d-4655-be9a-6a92b07b52eb', N'f91ff391-6e1f-4bef-9072-77d71b154e80', 2, 2, 1, 1, 2018, N'JHLRE48754A092385', 3500000.0000, N'', 3, N'X6', N'Зелёный', 170)
INSERT [dbo].[Cars] ([id_car], [mark_id], [drive], [transmission], [body_type], [engine_type], [release_year], [VIN], [price], [notes], [status], [model], [color], [power]) VALUES (N'4f733be3-0419-4e5c-8213-a6888d88e71a', N'8a249a6e-8ef9-455e-9b94-acec373dce30', 2, 1, 1, 4, 2019, N'2HKRL38554A093848', 250000.0000, N'', 3, N'Camry', N'Зелёный', 200)
GO
INSERT [dbo].[Clients] ([id_client], [fio], [pass], [tel_num]) VALUES (N'4d551ef0-35d2-4da2-9e51-469d51980834', N'Сидоров Алексей Павлович', N'4578582257', N'+7(934)567-89-01')
INSERT [dbo].[Clients] ([id_client], [fio], [pass], [tel_num]) VALUES (N'76aa3ad6-d0f5-4b80-8032-8b8526368fdd', N'Козлова Елена Андреевна', N'7896541125', N'+7(945)678-90-12')
INSERT [dbo].[Clients] ([id_client], [fio], [pass], [tel_num]) VALUES (N'9d0b7543-978c-4755-9af1-96a5b4eaaa1a', N'Иванов Иван Иванович', N'4578457845', N'+7(912)345-67-89')
INSERT [dbo].[Clients] ([id_client], [fio], [pass], [tel_num]) VALUES (N'6e41a68d-d0bc-4081-aca5-9acd79da5626', N'Павлов Кирилл Дмитриевич', N'7854142254', N'+7(956)789-01-23')
INSERT [dbo].[Clients] ([id_client], [fio], [pass], [tel_num]) VALUES (N'a71bb596-4d22-4bd6-a3a5-e58d192a2c65', N'Петрова Мария Сергеевна', N'9632145541', N'+7(923)456-78-90')
GO
INSERT [dbo].[Marks] ([id_mark], [name_mark]) VALUES (N'6e560227-2fbf-4ce2-976c-1664a7f43219', N'Mercedes')
INSERT [dbo].[Marks] ([id_mark], [name_mark]) VALUES (N'c73892fb-37c3-4076-9f72-61d845e0dc6b', N'Audi')
INSERT [dbo].[Marks] ([id_mark], [name_mark]) VALUES (N'38f6d726-111d-40f0-b79f-71b5f1b09728', N'Honda')
INSERT [dbo].[Marks] ([id_mark], [name_mark]) VALUES (N'f91ff391-6e1f-4bef-9072-77d71b154e80', N'BMW')
INSERT [dbo].[Marks] ([id_mark], [name_mark]) VALUES (N'8a249a6e-8ef9-455e-9b94-acec373dce30', N'Toyota')
GO
INSERT [dbo].[Reports] ([id_report], [monthReport], [hoursWork], [salary], [prize], [worker_id], [date_report]) VALUES (N'359271a1-cf35-46d5-aeff-745f67b8a0f1', N'Май 2024', 165, 26000.0000, 1400.0000, N'c9a1f8bb-e0b2-4331-bfb7-52f2580c25e9', CAST(N'2024-05-31T00:00:00.000' AS DateTime))
INSERT [dbo].[Reports] ([id_report], [monthReport], [hoursWork], [salary], [prize], [worker_id], [date_report]) VALUES (N'707f3110-62a7-41a7-a89a-9b9cb5c67636', N'Январь 2024', 200, 2.0000, 2.0000, N'48861a8f-21ba-4a00-a608-18501646e035', CAST(N'2024-05-30T14:05:25.327' AS DateTime))
INSERT [dbo].[Reports] ([id_report], [monthReport], [hoursWork], [salary], [prize], [worker_id], [date_report]) VALUES (N'b6a9c2d6-7976-44b8-adc0-a3788d6da438', N'Январь 2024', 160, 25000.0000, 1000.0000, N'0caa4e82-75da-47d9-af8a-a6e1253c8408', CAST(N'2024-01-31T00:00:00.000' AS DateTime))
INSERT [dbo].[Reports] ([id_report], [monthReport], [hoursWork], [salary], [prize], [worker_id], [date_report]) VALUES (N'4627b79c-c9d9-4586-92fd-c752d849a35c', N'Февраль 2024', 150, 23000.0000, 1500.0000, N'a63abb31-aafc-4557-8e73-ea9417da705f', CAST(N'2024-02-29T00:00:00.000' AS DateTime))
INSERT [dbo].[Reports] ([id_report], [monthReport], [hoursWork], [salary], [prize], [worker_id], [date_report]) VALUES (N'63fb3a1f-9505-4343-ac44-de486535c389', N'Апрель 2024', 155, 24000.0000, 1300.0000, N'48861a8f-21ba-4a00-a608-18501646e035', CAST(N'2024-04-30T00:00:00.000' AS DateTime))
INSERT [dbo].[Reports] ([id_report], [monthReport], [hoursWork], [salary], [prize], [worker_id], [date_report]) VALUES (N'374098ed-6e37-4f72-9cea-e53a3f4164ab', N'Март 2024', 140, 22000.0000, 1200.0000, N'b44644e7-dbfb-4dbd-97b0-cce1f8e73342', CAST(N'2024-03-31T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Requests] ([id_request], [car_id], [status_zayavki], [notes], [dateStartRepair], [dateEndRepair], [price]) VALUES (N'24590dbb-9cc0-4afe-97e7-1499c55c5c3f', N'714929e9-0a54-4561-82a7-5c2ab3e9d325', 1, N'', CAST(N'2024-05-29T04:52:14.420' AS DateTime), NULL, 3000.0000)
INSERT [dbo].[Requests] ([id_request], [car_id], [status_zayavki], [notes], [dateStartRepair], [dateEndRepair], [price]) VALUES (N'0a34bf9a-9de1-4758-8c9e-343808c74b8f', N'84760353-0c6c-45bc-bf5d-0597b780ff3d', 1, N'', CAST(N'2024-05-29T04:52:12.870' AS DateTime), NULL, 5000.0000)
INSERT [dbo].[Requests] ([id_request], [car_id], [status_zayavki], [notes], [dateStartRepair], [dateEndRepair], [price]) VALUES (N'd0ec3063-e7cf-4041-beca-3f71337ca4dd', N'4f733be3-0419-4e5c-8213-a6888d88e71a', 1, N'', CAST(N'2024-05-29T04:52:22.653' AS DateTime), NULL, 1000.0000)
INSERT [dbo].[Requests] ([id_request], [car_id], [status_zayavki], [notes], [dateStartRepair], [dateEndRepair], [price]) VALUES (N'2a9534df-6ab1-4de6-994b-63b22c2d7f7d', N'63d0024c-bd4d-4655-be9a-6a92b07b52eb', 2, N'', CAST(N'2024-05-29T04:52:18.073' AS DateTime), CAST(N'2024-05-31T14:22:53.270' AS DateTime), 1500.0000)
INSERT [dbo].[Requests] ([id_request], [car_id], [status_zayavki], [notes], [dateStartRepair], [dateEndRepair], [price]) VALUES (N'4a13ac43-97bb-44ef-8941-c12deb1b169e', N'3f284d4c-6cde-44dc-ba85-62e5db0a2c91', 2, N'', CAST(N'2024-05-30T14:52:47.173' AS DateTime), CAST(N'2024-05-30T15:05:17.743' AS DateTime), 800.0000)
GO
INSERT [dbo].[Sales] ([id_sale], [car_id], [total], [client_id], [worker_id], [notes], [date_sale]) VALUES (N'c14f6cd3-c70b-40f9-a8dc-06e57d3f275b', N'63d0024c-bd4d-4655-be9a-6a92b07b52eb', 350000.0000, N'a71bb596-4d22-4bd6-a3a5-e58d192a2c65', N'b44644e7-dbfb-4dbd-97b0-cce1f8e73342', N'', CAST(N'2024-05-10T17:00:00.000' AS DateTime))
INSERT [dbo].[Sales] ([id_sale], [car_id], [total], [client_id], [worker_id], [notes], [date_sale]) VALUES (N'440d32fc-0064-4f75-b210-251a7acb95da', N'84760353-0c6c-45bc-bf5d-0597b780ff3d', 500000.0000, N'4d551ef0-35d2-4da2-9e51-469d51980834', N'b44644e7-dbfb-4dbd-97b0-cce1f8e73342', N'', CAST(N'2024-05-15T11:45:00.000' AS DateTime))
INSERT [dbo].[Sales] ([id_sale], [car_id], [total], [client_id], [worker_id], [notes], [date_sale]) VALUES (N'91e514c4-da25-4ee1-a091-579af5bc5381', N'4f733be3-0419-4e5c-8213-a6888d88e71a', 250000.0000, N'76aa3ad6-d0f5-4b80-8032-8b8526368fdd', N'b44644e7-dbfb-4dbd-97b0-cce1f8e73342', N'', CAST(N'2024-05-20T14:20:00.000' AS DateTime))
INSERT [dbo].[Sales] ([id_sale], [car_id], [total], [client_id], [worker_id], [notes], [date_sale]) VALUES (N'6cb2f79f-26a9-4f8b-b23a-96095738fff8', N'714929e9-0a54-4561-82a7-5c2ab3e9d325', 450000.0000, N'9d0b7543-978c-4755-9af1-96a5b4eaaa1a', N'b44644e7-dbfb-4dbd-97b0-cce1f8e73342', N'', CAST(N'2024-05-05T15:30:00.000' AS DateTime))
INSERT [dbo].[Sales] ([id_sale], [car_id], [total], [client_id], [worker_id], [notes], [date_sale]) VALUES (N'75bba77c-ce32-47a0-9fa2-e09e1bcfdc77', N'3f284d4c-6cde-44dc-ba85-62e5db0a2c91', 300000.0000, N'6e41a68d-d0bc-4081-aca5-9acd79da5626', N'b44644e7-dbfb-4dbd-97b0-cce1f8e73342', N'', CAST(N'2024-05-25T18:30:00.000' AS DateTime))
GO
INSERT [dbo].[Workers] ([id_worker], [fio], [pass], [tel_num], [role_id], [status], [login], [password]) VALUES (N'48861a8f-21ba-4a00-a608-18501646e035', N'Козлов Иван Михайлович', N'4177894454', N'+7(934)567-89-01', 3, 1, N'4', N'4B227777D4DD1FC61C6F884F48641D02B4D121D3FD328CB08B5531FCACDABF8A')
INSERT [dbo].[Workers] ([id_worker], [fio], [pass], [tel_num], [role_id], [status], [login], [password]) VALUES (N'c9a1f8bb-e0b2-4331-bfb7-52f2580c25e9', N'Зубенко Михаил Петрович', N'4124369951', N'+7(934)567-89-01', 4, 1, N'5', N'EF2D127DE37B942BAAD06145E54B0C619A1F22327B2EBBCFBEC78F5564AFE39D')
INSERT [dbo].[Workers] ([id_worker], [fio], [pass], [tel_num], [role_id], [status], [login], [password]) VALUES (N'0caa4e82-75da-47d9-af8a-a6e1253c8408', N'Иванов Алексей Петрович', N'3344215546', N'+7(901)234-56-78', 0, 1, N'1', N'6B86B273FF34FCE19D6B804EFF5A3F5747ADA4EAA22F1D49C01E52DDB7875B4B')
INSERT [dbo].[Workers] ([id_worker], [fio], [pass], [tel_num], [role_id], [status], [login], [password]) VALUES (N'7b128820-1f3e-4031-8ff3-a9b00b95fa60', N'Павлова Екатерина Александровна', N'9999456645', N'+7(945)678-90-12', 5, 1, N'6', N'E7F6C011776E8DB7CD330B54174FD76F7D0216B612387A5FFCFB81E6F0919683')
INSERT [dbo].[Workers] ([id_worker], [fio], [pass], [tel_num], [role_id], [status], [login], [password]) VALUES (N'b44644e7-dbfb-4dbd-97b0-cce1f8e73342', N'Сидорова Ольга Николаевна', N'4578216645', N'+7(923)456-78-90', 2, 1, N'3', N'4E07408562BEDB8B60CE05C1DECFE3AD16B72230967DE01F640B7E4729B49FCE')
INSERT [dbo].[Workers] ([id_worker], [fio], [pass], [tel_num], [role_id], [status], [login], [password]) VALUES (N'a63abb31-aafc-4557-8e73-ea9417da705f', N'Петров Сергей Иванович', N'4788945578', N'+7(912)345-67-89', 1, 1, N'2', N'D4735E3A265E16EEE03F59718B9B5D03019C07D8B6C51F90DA3A666EEC13AB35')
GO
ALTER TABLE [dbo].[Cars]  WITH CHECK ADD  CONSTRAINT [FK_Cars_Marks] FOREIGN KEY([mark_id])
REFERENCES [dbo].[Marks] ([id_mark])
GO
ALTER TABLE [dbo].[Cars] CHECK CONSTRAINT [FK_Cars_Marks]
GO
ALTER TABLE [dbo].[Reports]  WITH CHECK ADD  CONSTRAINT [FK_Reports_Workers] FOREIGN KEY([worker_id])
REFERENCES [dbo].[Workers] ([id_worker])
GO
ALTER TABLE [dbo].[Reports] CHECK CONSTRAINT [FK_Reports_Workers]
GO
ALTER TABLE [dbo].[Requests]  WITH CHECK ADD  CONSTRAINT [FK_Requests_Cars] FOREIGN KEY([car_id])
REFERENCES [dbo].[Cars] ([id_car])
GO
ALTER TABLE [dbo].[Requests] CHECK CONSTRAINT [FK_Requests_Cars]
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Cars] FOREIGN KEY([car_id])
REFERENCES [dbo].[Cars] ([id_car])
GO
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_Sales_Cars]
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Clients] FOREIGN KEY([client_id])
REFERENCES [dbo].[Clients] ([id_client])
GO
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_Sales_Clients]
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Workers] FOREIGN KEY([worker_id])
REFERENCES [dbo].[Workers] ([id_worker])
GO
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_Sales_Workers]
GO
USE [master]
GO
ALTER DATABASE [Db_DealershipManagment] SET  READ_WRITE 
GO
