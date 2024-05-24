USE [Db_DealershipManagment]
GO
/****** Object:  Table [dbo].[Cars]    Script Date: 24.05.2024 3:11:58 ******/
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
 CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED 
(
	[id_car] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 24.05.2024 3:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[id_client] [uniqueidentifier] NOT NULL,
	[fio] [nvarchar](75) NOT NULL,
	[pass] [nvarchar](10) NOT NULL,
	[tel_num] [nvarchar](12) NOT NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[id_client] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marks]    Script Date: 24.05.2024 3:11:58 ******/
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
/****** Object:  Table [dbo].[Reports]    Script Date: 24.05.2024 3:11:58 ******/
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
	[date_report] [date] NOT NULL,
 CONSTRAINT [PK_Reports] PRIMARY KEY CLUSTERED 
(
	[id_report] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Requests]    Script Date: 24.05.2024 3:11:58 ******/
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
 CONSTRAINT [PK_Requests] PRIMARY KEY CLUSTERED 
(
	[id_request] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 24.05.2024 3:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[id_role] [int] IDENTITY(1,1) NOT NULL,
	[name_role] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[id_role] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sales]    Script Date: 24.05.2024 3:11:58 ******/
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
/****** Object:  Table [dbo].[Workers]    Script Date: 24.05.2024 3:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Workers](
	[id_worker] [uniqueidentifier] NOT NULL,
	[fio] [nvarchar](75) NOT NULL,
	[pass] [nvarchar](10) NOT NULL,
	[tel_num] [nvarchar](12) NOT NULL,
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
INSERT [dbo].[Cars] ([id_car], [mark_id], [drive], [transmission], [body_type], [engine_type], [release_year], [VIN], [price], [notes], [status], [model]) VALUES (N'1132bcee-91c1-4735-872c-06fa1e9d39e1', N'30885fc4-c2f6-485f-9c1f-61f5914fae01', 1, 0, 3, 1, 2019, N'WVWFK7AU3AE516207', 22000.0000, N'Автомобиль с пробегом', 0, N'Polo')
INSERT [dbo].[Cars] ([id_car], [mark_id], [drive], [transmission], [body_type], [engine_type], [release_year], [VIN], [price], [notes], [status], [model]) VALUES (N'86d5fc0c-ee9d-4e9f-b6bf-28c10bd6446b', N'59a212b0-698e-42af-a5f0-7bb08455e53a', 0, 1, 2, 0, 2021, N'1FAHP3F29CL170518', 30000.0000, N'Новый автомобиль', 0, N'Mustang')
INSERT [dbo].[Cars] ([id_car], [mark_id], [drive], [transmission], [body_type], [engine_type], [release_year], [VIN], [price], [notes], [status], [model]) VALUES (N'18cdf347-a892-4e50-861f-405f0d2a16c6', N'5f15d39a-4883-4341-bb8e-709b827c8206', 1, 1, 1, 1, 2018, N'JHMCM56688C028586', 18000.0000, N'Автомобиль с пробегом', 0, N'Civic')
INSERT [dbo].[Cars] ([id_car], [mark_id], [drive], [transmission], [body_type], [engine_type], [release_year], [VIN], [price], [notes], [status], [model]) VALUES (N'41233405-dfe4-4437-ae4b-4ff8be6ac63d', N'fa6b6d86-16cf-4e5e-b3b5-7f61ce68b7eb', 0, 0, 0, 0, 2020, N'JTDKB20U393066152', 25000.0000, N'Новый автомобиль', 0, N'Mark 2')
INSERT [dbo].[Cars] ([id_car], [mark_id], [drive], [transmission], [body_type], [engine_type], [release_year], [VIN], [price], [notes], [status], [model]) VALUES (N'f70c793f-bac8-48e7-ae5d-d8b8d081b319', N'b05dc97f-424c-4ce2-9b91-7c790d18a78c', 1, 1, 2, 1, 2022, N'WBA3C1C03LF508905', 45000.0000, N'Новый автомобиль', 0, N'E30')
GO
INSERT [dbo].[Clients] ([id_client], [fio], [pass], [tel_num]) VALUES (N'28dbc13f-ef44-43cc-8c1c-51d8571c4077', N'Иванов Иван Иванович', N'1234', N'89001112233')
INSERT [dbo].[Clients] ([id_client], [fio], [pass], [tel_num]) VALUES (N'15b14a6a-3f63-4bda-b391-8f6825c120bf', N'Белова Мария Викторовна', N'7890', N'89005556677')
INSERT [dbo].[Clients] ([id_client], [fio], [pass], [tel_num]) VALUES (N'61c25f8b-c366-4ce6-ad2d-ce503b20b2e9', N'Петров Петр Петрович', N'5678', N'89002223344')
INSERT [dbo].[Clients] ([id_client], [fio], [pass], [tel_num]) VALUES (N'fa331c53-c317-4f7e-aa1b-de38ad3dd012', N'Сидорова Анна Сергеевна', N'9012', N'89003334455')
INSERT [dbo].[Clients] ([id_client], [fio], [pass], [tel_num]) VALUES (N'e628aa51-5788-4ab5-8c5a-f2d5851fc58d', N'Кузнецов Максим Алексеевич', N'3456', N'89004445566')
GO
INSERT [dbo].[Marks] ([id_mark], [name_mark]) VALUES (N'30885fc4-c2f6-485f-9c1f-61f5914fae01', N'Volkswagen')
INSERT [dbo].[Marks] ([id_mark], [name_mark]) VALUES (N'5f15d39a-4883-4341-bb8e-709b827c8206', N'Honda')
INSERT [dbo].[Marks] ([id_mark], [name_mark]) VALUES (N'59a212b0-698e-42af-a5f0-7bb08455e53a', N'Ford')
INSERT [dbo].[Marks] ([id_mark], [name_mark]) VALUES (N'b05dc97f-424c-4ce2-9b91-7c790d18a78c', N'BMW')
INSERT [dbo].[Marks] ([id_mark], [name_mark]) VALUES (N'fa6b6d86-16cf-4e5e-b3b5-7f61ce68b7eb', N'Toyota')
GO
INSERT [dbo].[Reports] ([id_report], [monthReport], [hoursWork], [salary], [prize], [worker_id], [date_report]) VALUES (N'7c04b136-c073-47a3-9465-0fbb14848dfe', N'Июнь 2023', 180, 4000.0000, 800.0000, N'8a7f4884-c058-453d-baba-07951101c605', CAST(N'2023-07-01' AS Date))
INSERT [dbo].[Reports] ([id_report], [monthReport], [hoursWork], [salary], [prize], [worker_id], [date_report]) VALUES (N'b5bee87a-6334-4005-bb6f-5afb49f84f2e', N'Апрель 2023', 150, 3000.0000, 300.0000, N'4d6824d8-a24d-46c7-8ac1-6d4c8385bf6d', CAST(N'2023-05-01' AS Date))
INSERT [dbo].[Reports] ([id_report], [monthReport], [hoursWork], [salary], [prize], [worker_id], [date_report]) VALUES (N'1265f40a-4db1-4c08-bbc1-a4b605bfc145', N'Июль 2023', 165, 3700.0000, 600.0000, N'1018947f-0d85-46d4-8f1e-6d84233241bd', CAST(N'2023-08-01' AS Date))
INSERT [dbo].[Reports] ([id_report], [monthReport], [hoursWork], [salary], [prize], [worker_id], [date_report]) VALUES (N'9a00599b-3091-488c-ab07-af18aad20ee0', N'Март 2023', 140, 2800.0000, 200.0000, N'80b3fe68-3186-4ddb-97fe-933507cd36a6', CAST(N'2023-04-01' AS Date))
INSERT [dbo].[Reports] ([id_report], [monthReport], [hoursWork], [salary], [prize], [worker_id], [date_report]) VALUES (N'9b651f0f-6522-487e-9a87-c48680a7b402', N'Май 2023', 160, 3500.0000, 500.0000, N'708319ef-9c81-4714-96ee-9778537b8bd7', CAST(N'2023-06-01' AS Date))
GO
INSERT [dbo].[Requests] ([id_request], [car_id], [status_zayavki], [notes], [dateStartRepair], [dateEndRepair]) VALUES (N'157df505-aae6-4215-924c-0e5d848925db', N'41233405-dfe4-4437-ae4b-4ff8be6ac63d', 0, N'Требуется диагностика', CAST(N'2023-05-01T00:00:00.000' AS DateTime), CAST(N'2023-05-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Requests] ([id_request], [car_id], [status_zayavki], [notes], [dateStartRepair], [dateEndRepair]) VALUES (N'baf42d1f-f9b6-4073-8ae0-641516ccf607', N'f70c793f-bac8-48e7-ae5d-d8b8d081b319', 0, N'Замена шин', CAST(N'2023-07-01T00:00:00.000' AS DateTime), CAST(N'2023-07-02T00:00:00.000' AS DateTime))
INSERT [dbo].[Requests] ([id_request], [car_id], [status_zayavki], [notes], [dateStartRepair], [dateEndRepair]) VALUES (N'64a9d35e-3aa0-4662-a3c4-b25035f6ccf6', N'18cdf347-a892-4e50-861f-405f0d2a16c6', 1, N'Замена масла', CAST(N'2023-04-15T00:00:00.000' AS DateTime), CAST(N'2023-04-20T00:00:00.000' AS DateTime))
INSERT [dbo].[Requests] ([id_request], [car_id], [status_zayavki], [notes], [dateStartRepair], [dateEndRepair]) VALUES (N'790d2eb4-e8c6-4265-8a58-cb55d612c1e2', N'86d5fc0c-ee9d-4e9f-b6bf-28c10bd6446b', 0, N'Замена тормозных колодок', CAST(N'2023-06-01T00:00:00.000' AS DateTime), CAST(N'2023-06-03T00:00:00.000' AS DateTime))
INSERT [dbo].[Requests] ([id_request], [car_id], [status_zayavki], [notes], [dateStartRepair], [dateEndRepair]) VALUES (N'cee5297a-de00-41d2-aa2f-d6b495973361', N'1132bcee-91c1-4735-872c-06fa1e9d39e1', 2, N'Ремонт двигателя', CAST(N'2023-03-20T00:00:00.000' AS DateTime), CAST(N'2023-04-05T00:00:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([id_role], [name_role]) VALUES (2, N'Кладовщик')
INSERT [dbo].[Roles] ([id_role], [name_role]) VALUES (3, N'Бухгалтер')
INSERT [dbo].[Roles] ([id_role], [name_role]) VALUES (4, N'Менеджер по продажам')
INSERT [dbo].[Roles] ([id_role], [name_role]) VALUES (5, N'Сотрудник сервиса')
INSERT [dbo].[Roles] ([id_role], [name_role]) VALUES (6, N'Руководитель')
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
INSERT [dbo].[Sales] ([id_sale], [car_id], [total], [client_id], [worker_id], [notes], [date_sale]) VALUES (N'a4fc7836-219d-490f-b272-077954a81484', N'1132bcee-91c1-4735-872c-06fa1e9d39e1', 22000.0000, N'e628aa51-5788-4ab5-8c5a-f2d5851fc58d', N'8a7f4884-c058-453d-baba-07951101c605', N'Продажа машины с пробегом', CAST(N'2023-07-20T00:00:00.000' AS DateTime))
INSERT [dbo].[Sales] ([id_sale], [car_id], [total], [client_id], [worker_id], [notes], [date_sale]) VALUES (N'4b3494ac-19df-4f4a-a8d7-4b33508ba8a6', N'86d5fc0c-ee9d-4e9f-b6bf-28c10bd6446b', 30000.0000, N'fa331c53-c317-4f7e-aa1b-de38ad3dd012', N'8a7f4884-c058-453d-baba-07951101c605', N'Продажа новой машины', CAST(N'2023-06-01T00:00:00.000' AS DateTime))
INSERT [dbo].[Sales] ([id_sale], [car_id], [total], [client_id], [worker_id], [notes], [date_sale]) VALUES (N'a874b19c-b751-4eca-85ad-75d1b9435c57', N'18cdf347-a892-4e50-861f-405f0d2a16c6', 18000.0000, N'61c25f8b-c366-4ce6-ad2d-ce503b20b2e9', N'8a7f4884-c058-453d-baba-07951101c605', N'Продажа машины с пробегом', CAST(N'2023-05-15T00:00:00.000' AS DateTime))
INSERT [dbo].[Sales] ([id_sale], [car_id], [total], [client_id], [worker_id], [notes], [date_sale]) VALUES (N'92098d09-6165-4a2f-a382-e13cb211f698', N'41233405-dfe4-4437-ae4b-4ff8be6ac63d', 25000.0000, N'28dbc13f-ef44-43cc-8c1c-51d8571c4077', N'8a7f4884-c058-453d-baba-07951101c605', N'Продажа новой машины', CAST(N'2023-04-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Sales] ([id_sale], [car_id], [total], [client_id], [worker_id], [notes], [date_sale]) VALUES (N'70078065-43ee-46a6-92eb-fdb628566b59', N'f70c793f-bac8-48e7-ae5d-d8b8d081b319', 45000.0000, N'15b14a6a-3f63-4bda-b391-8f6825c120bf', N'8a7f4884-c058-453d-baba-07951101c605', N'Продажа новой машины', CAST(N'2023-08-05T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Workers] ([id_worker], [fio], [pass], [tel_num], [role_id], [status], [login], [password]) VALUES (N'8a7f4884-c058-453d-baba-07951101c605', N'Сидоров Петр Петрович', N'admin456', N'89004445566', 4, 0, N'4', N'4')
INSERT [dbo].[Workers] ([id_worker], [fio], [pass], [tel_num], [role_id], [status], [login], [password]) VALUES (N'4d6824d8-a24d-46c7-8ac1-6d4c8385bf6d', N'Белова Мария Викторовна', N'sales789', N'89005556677', 6, 0, N'6', N'6')
INSERT [dbo].[Workers] ([id_worker], [fio], [pass], [tel_num], [role_id], [status], [login], [password]) VALUES (N'1018947f-0d85-46d4-8f1e-6d84233241bd', N'Иванов Иван Иванович', N'admin123', N'89001112233', 2, 0, N'1', N'1')
INSERT [dbo].[Workers] ([id_worker], [fio], [pass], [tel_num], [role_id], [status], [login], [password]) VALUES (N'80b3fe68-3186-4ddb-97fe-933507cd36a6', N'Петрова Анна Сергеевна', N'sales456', N'89002223344', 2, 0, N'2', N'2')
INSERT [dbo].[Workers] ([id_worker], [fio], [pass], [tel_num], [role_id], [status], [login], [password]) VALUES (N'708319ef-9c81-4714-96ee-9778537b8bd7', N'Кузнецов Максим Алексеевич', N'service789', N'89003334455', 3, 0, N'3', N'3')
INSERT [dbo].[Workers] ([id_worker], [fio], [pass], [tel_num], [role_id], [status], [login], [password]) VALUES (N'7d7a33a8-7170-44a1-a8b4-9e103d99fab2', N'Зубенко Михаил Петрович', N'admin456', N'89004445566', 5, 0, N'5', N'5')
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
ALTER TABLE [dbo].[Workers]  WITH CHECK ADD  CONSTRAINT [FK_Workers_Roles] FOREIGN KEY([role_id])
REFERENCES [dbo].[Roles] ([id_role])
GO
ALTER TABLE [dbo].[Workers] CHECK CONSTRAINT [FK_Workers_Roles]
GO
