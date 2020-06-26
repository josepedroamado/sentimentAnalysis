USE [SentimentAnalysis]
GO
/****** Object:  Table [dbo].[Alarms]    Script Date: 6/25/2020 8:47:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alarms](
	[AlarmId] [uniqueidentifier] NOT NULL,
	[RequiredPostQuantity] [int] NOT NULL,
	[TimeFrame] [bigint] NOT NULL,
	[Active] [bit] NOT NULL,
	[Entity_EntityDtoId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_dbo.Alarms] PRIMARY KEY CLUSTERED 
(
	[AlarmId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AuthorAlarms]    Script Date: 6/25/2020 8:47:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AuthorAlarms](
	[AlarmId] [uniqueidentifier] NOT NULL,
	[PhrasesType] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_dbo.AuthorAlarms] PRIMARY KEY CLUSTERED 
(
	[AlarmId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Authors]    Script Date: 6/25/2020 8:47:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authors](
	[AuthorId] [uniqueidentifier] NOT NULL,
	[UserName] [nvarchar](10) NOT NULL,
	[FirstName] [nvarchar](15) NOT NULL,
	[LastName] [nvarchar](15) NOT NULL,
	[BirthDate] [datetime] NOT NULL,
 CONSTRAINT [PK_dbo.Authors] PRIMARY KEY CLUSTERED 
(
	[AuthorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Entities]    Script Date: 6/25/2020 8:47:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entities](
	[EntityId] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_dbo.Entities] PRIMARY KEY CLUSTERED 
(
	[EntityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NegativeAlarms]    Script Date: 6/25/2020 8:47:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NegativeAlarms](
	[AlarmId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_dbo.NegativeAlarms] PRIMARY KEY CLUSTERED 
(
	[AlarmId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NegativeSentiments]    Script Date: 6/25/2020 8:47:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NegativeSentiments](
	[SentimentId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_dbo.NegativeSentiments] PRIMARY KEY CLUSTERED 
(
	[SentimentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NeutralSentiments]    Script Date: 6/25/2020 8:47:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NeutralSentiments](
	[SentimentId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_dbo.NeutralSentiments] PRIMARY KEY CLUSTERED 
(
	[SentimentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PositiveAlarms]    Script Date: 6/25/2020 8:47:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PositiveAlarms](
	[AlarmId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_dbo.PositiveAlarms] PRIMARY KEY CLUSTERED 
(
	[AlarmId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PositiveSentiments]    Script Date: 6/25/2020 8:47:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PositiveSentiments](
	[SentimentId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_dbo.PositiveSentiments] PRIMARY KEY CLUSTERED 
(
	[SentimentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Publications]    Script Date: 6/25/2020 8:47:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publications](
	[PublicationId] [uniqueidentifier] NOT NULL,
	[Phrase] [nvarchar](max) NOT NULL,
	[Date] [datetime] NOT NULL,
	[Author_AuthorDtoId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_dbo.Publications] PRIMARY KEY CLUSTERED 
(
	[PublicationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Relations]    Script Date: 6/25/2020 8:47:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Relations](
	[RelationId] [uniqueidentifier] NOT NULL,
	[Entity_EntityDtoId] [uniqueidentifier] NULL,
	[Publication_PublicationDtoId] [uniqueidentifier] NULL,
	[Sentiment_SentimentDtoId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_dbo.Relations] PRIMARY KEY CLUSTERED 
(
	[RelationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sentiments]    Script Date: 6/25/2020 8:47:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sentiments](
	[SentimentId] [uniqueidentifier] NOT NULL,
	[Text] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_dbo.Sentiments] PRIMARY KEY CLUSTERED 
(
	[SentimentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Alarms] ([AlarmId], [RequiredPostQuantity], [TimeFrame], [Active], [Entity_EntityDtoId]) VALUES (N'394edf04-02fa-4fd2-be7d-0253b023b9e2', 5, 129600000000000, 0, N'ff698d39-846b-43cb-8308-204c0143bcba')
INSERT [dbo].[Alarms] ([AlarmId], [RequiredPostQuantity], [TimeFrame], [Active], [Entity_EntityDtoId]) VALUES (N'dbb527e1-6e38-430a-bf80-69eaaa3ca824', 3, 216000000000000, 0, N'89d6476b-cfe8-4cc8-a29f-4ea5e974cf37')
INSERT [dbo].[Alarms] ([AlarmId], [RequiredPostQuantity], [TimeFrame], [Active], [Entity_EntityDtoId]) VALUES (N'30a34cfa-0340-4e46-b5fe-88d63fb3fe31', 7, 172800000000000, 0, N'becec057-47d8-4d8f-87ab-daa2d336f9d9')
INSERT [dbo].[Alarms] ([AlarmId], [RequiredPostQuantity], [TimeFrame], [Active], [Entity_EntityDtoId]) VALUES (N'dfb260c4-3308-4aa8-b4f2-c8761d039181', 4, 86400000000000, 0, N'26080978-603e-4286-982b-e5201ec69d40')
INSERT [dbo].[Alarms] ([AlarmId], [RequiredPostQuantity], [TimeFrame], [Active], [Entity_EntityDtoId]) VALUES (N'bcbe78ab-5e6c-4f9f-a024-dd97f3079214', 10, 315360000000000, 0, N'951710fd-7029-45f3-b873-e805f913b406')
INSERT [dbo].[Alarms] ([AlarmId], [RequiredPostQuantity], [TimeFrame], [Active], [Entity_EntityDtoId]) VALUES (N'32ff7e85-a8fa-443c-bb88-e0fde09ef21c', 2, 43200000000000, 0, N'de7435f1-7a77-4648-93db-6d0649c50a75')
GO
INSERT [dbo].[AuthorAlarms] ([AlarmId], [PhrasesType]) VALUES (N'394edf04-02fa-4fd2-be7d-0253b023b9e2', N'Positivas
')
INSERT [dbo].[AuthorAlarms] ([AlarmId], [PhrasesType]) VALUES (N'30a34cfa-0340-4e46-b5fe-88d63fb3fe31', N'Negativas
')
GO
INSERT [dbo].[Authors] ([AuthorId], [UserName], [FirstName], [LastName], [BirthDate]) VALUES (N'2c6e11d8-f8fd-48fb-b804-139318afdbcd', N'LMachado', N'Laura', N'Machado', CAST(N'2002-05-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Authors] ([AuthorId], [UserName], [FirstName], [LastName], [BirthDate]) VALUES (N'a6048e96-0a45-4c1e-9a76-152b8979c468', N'JFonseca', N'Javier', N'Fonseca', CAST(N'1992-06-18T00:00:00.000' AS DateTime))
INSERT [dbo].[Authors] ([AuthorId], [UserName], [FirstName], [LastName], [BirthDate]) VALUES (N'cc445d6a-3fc5-4c9f-9161-1f23a2a897b8', N'AEstevez', N'Alejandro', N'Estevez', CAST(N'1990-12-22T00:00:00.000' AS DateTime))
INSERT [dbo].[Authors] ([AuthorId], [UserName], [FirstName], [LastName], [BirthDate]) VALUES (N'ec9ffc2d-e8a8-471e-9596-4a48d34bc3e6', N'SAlvarez', N'Sandra', N'Alvarez', CAST(N'1961-01-21T00:00:00.000' AS DateTime))
INSERT [dbo].[Authors] ([AuthorId], [UserName], [FirstName], [LastName], [BirthDate]) VALUES (N'82782daa-4486-464a-b55d-545e4e17047d', N'MMartinez', N'Maria', N'Martinez', CAST(N'1964-01-29T00:00:00.000' AS DateTime))
INSERT [dbo].[Authors] ([AuthorId], [UserName], [FirstName], [LastName], [BirthDate]) VALUES (N'105c762e-2c5d-4631-b08d-5898b1fa1ba2', N'JRodriguez', N'Juan', N'Rodriguez', CAST(N'1949-01-22T00:00:00.000' AS DateTime))
INSERT [dbo].[Authors] ([AuthorId], [UserName], [FirstName], [LastName], [BirthDate]) VALUES (N'0d38f37d-d807-4dff-884c-670b5b68a726', N'PNoguera', N'Patricia', N'Noguera', CAST(N'2003-08-09T00:00:00.000' AS DateTime))
INSERT [dbo].[Authors] ([AuthorId], [UserName], [FirstName], [LastName], [BirthDate]) VALUES (N'8c37acf9-22ac-40f8-b8df-69f0bc4d6aeb', N'RDominguez', N'Rafael', N'Dominguez', CAST(N'1986-02-22T00:00:00.000' AS DateTime))
INSERT [dbo].[Authors] ([AuthorId], [UserName], [FirstName], [LastName], [BirthDate]) VALUES (N'cd399baf-a185-44c1-98bb-787ad29a2bb6', N'LSosa', N'Lucia', N'Sosa', CAST(N'1960-12-31T00:00:00.000' AS DateTime))
INSERT [dbo].[Authors] ([AuthorId], [UserName], [FirstName], [LastName], [BirthDate]) VALUES (N'a614f34c-3ab3-414e-ab25-8e6dd631613a', N'RPerez', N'Roberto', N'Perez', CAST(N'1945-03-09T00:00:00.000' AS DateTime))
INSERT [dbo].[Authors] ([AuthorId], [UserName], [FirstName], [LastName], [BirthDate]) VALUES (N'c0dcb0ab-38ca-4cb1-86b8-9e0628564908', N'LHernandez', N'Luis', N'Hernandez', CAST(N'1997-02-19T00:00:00.000' AS DateTime))
INSERT [dbo].[Authors] ([AuthorId], [UserName], [FirstName], [LastName], [BirthDate]) VALUES (N'e2f5f38f-3b48-40df-8853-a26c38060241', N'FLopez', N'Francisco', N'Lopez', CAST(N'1981-03-11T00:00:00.000' AS DateTime))
INSERT [dbo].[Authors] ([AuthorId], [UserName], [FirstName], [LastName], [BirthDate]) VALUES (N'1c8d2e60-f784-4cdb-a884-a6f59d952d07', N'MGonzalez', N'Macarena', N'Gonzalez', CAST(N'1958-03-15T00:00:00.000' AS DateTime))
INSERT [dbo].[Authors] ([AuthorId], [UserName], [FirstName], [LastName], [BirthDate]) VALUES (N'190e9cdc-750b-4b1d-a7fa-b73baaecfdf7', N'MAcosta', N'Maria Eugenia', N'Acosta', CAST(N'1970-05-08T00:00:00.000' AS DateTime))
INSERT [dbo].[Authors] ([AuthorId], [UserName], [FirstName], [LastName], [BirthDate]) VALUES (N'd94f1134-c5ff-4b9b-90e3-e270221ec2bf', N'AGarcia', N'Adriana', N'Garcia', CAST(N'1995-12-17T00:00:00.000' AS DateTime))
INSERT [dbo].[Authors] ([AuthorId], [UserName], [FirstName], [LastName], [BirthDate]) VALUES (N'c2dd7c38-a44f-4b35-9484-e65eb5394566', N'PSuarez', N'Pedro', N'Suarez', CAST(N'1953-05-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Authors] ([AuthorId], [UserName], [FirstName], [LastName], [BirthDate]) VALUES (N'691af1ff-d78c-4fda-8365-ec5b439d5f6b', N'DCaballero', N'Diego', N'Caballero', CAST(N'1982-01-14T00:00:00.000' AS DateTime))
INSERT [dbo].[Authors] ([AuthorId], [UserName], [FirstName], [LastName], [BirthDate]) VALUES (N'9eb65efa-8221-4d07-8437-edd5f89b1269', N'JAmado', N'Jose Pedro', N'Amado', CAST(N'1949-08-11T00:00:00.000' AS DateTime))
INSERT [dbo].[Authors] ([AuthorId], [UserName], [FirstName], [LastName], [BirthDate]) VALUES (N'5d1e6c2f-80aa-43b9-88d9-f3a2b74e0f37', N'SLozano', N'Susana', N'Lozano', CAST(N'2000-07-22T00:00:00.000' AS DateTime))
INSERT [dbo].[Authors] ([AuthorId], [UserName], [FirstName], [LastName], [BirthDate]) VALUES (N'9039f350-c34d-4704-a477-fafc56652007', N'ABenitez', N'Agustin', N'Benitez', CAST(N'1981-07-27T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Entities] ([EntityId], [Name]) VALUES (N'a047b192-1f44-4a89-9f12-169c23005993', N'Bose')
INSERT [dbo].[Entities] ([EntityId], [Name]) VALUES (N'ff698d39-846b-43cb-8308-204c0143bcba', N'Disney')
INSERT [dbo].[Entities] ([EntityId], [Name]) VALUES (N'f42b32d5-d799-4eb1-984d-2de8fe05f650', N'Facebook')
INSERT [dbo].[Entities] ([EntityId], [Name]) VALUES (N'99125f9c-b570-4c20-9555-4508f5f66951', N'Twitter')
INSERT [dbo].[Entities] ([EntityId], [Name]) VALUES (N'89d6476b-cfe8-4cc8-a29f-4ea5e974cf37', N'Pepsi')
INSERT [dbo].[Entities] ([EntityId], [Name]) VALUES (N'1657978b-41a0-40ee-aaad-60ab3b187424', N'Telegram')
INSERT [dbo].[Entities] ([EntityId], [Name]) VALUES (N'de7435f1-7a77-4648-93db-6d0649c50a75', N'Microsoft')
INSERT [dbo].[Entities] ([EntityId], [Name]) VALUES (N'1888fdc8-de7e-458d-99a4-947e18934957', N'Netflix')
INSERT [dbo].[Entities] ([EntityId], [Name]) VALUES (N'c77213bd-ab43-416b-a37a-9a08b81ec6af', N'Desconocida')
INSERT [dbo].[Entities] ([EntityId], [Name]) VALUES (N'3361d601-eca1-416c-8d6c-ac8779a5985b', N'Nativa')
INSERT [dbo].[Entities] ([EntityId], [Name]) VALUES (N'3e2848cd-68eb-42c3-8f1e-b227cc8bf85c', N'Hyundai')
INSERT [dbo].[Entities] ([EntityId], [Name]) VALUES (N'950cd115-6f87-4a90-ba06-d67fcbe8045d', N'Salus')
INSERT [dbo].[Entities] ([EntityId], [Name]) VALUES (N'becec057-47d8-4d8f-87ab-daa2d336f9d9', N'Universal')
INSERT [dbo].[Entities] ([EntityId], [Name]) VALUES (N'26080978-603e-4286-982b-e5201ec69d40', N'Coca-cola')
INSERT [dbo].[Entities] ([EntityId], [Name]) VALUES (N'951710fd-7029-45f3-b873-e805f913b406', N'Apple')
INSERT [dbo].[Entities] ([EntityId], [Name]) VALUES (N'76566d07-866e-4122-a314-e970f5e8098d', N'Whatsapp')
GO
INSERT [dbo].[NegativeAlarms] ([AlarmId]) VALUES (N'dbb527e1-6e38-430a-bf80-69eaaa3ca824')
INSERT [dbo].[NegativeAlarms] ([AlarmId]) VALUES (N'bcbe78ab-5e6c-4f9f-a024-dd97f3079214')
GO
INSERT [dbo].[NegativeSentiments] ([SentimentId]) VALUES (N'8ef0662e-cef7-4660-a6a7-120b3690d52f')
INSERT [dbo].[NegativeSentiments] ([SentimentId]) VALUES (N'6d5b1bd6-7e06-4e0c-a0a4-6ac4a8910b33')
INSERT [dbo].[NegativeSentiments] ([SentimentId]) VALUES (N'd7644c31-11bb-4d97-95e5-d467d74a2f62')
INSERT [dbo].[NegativeSentiments] ([SentimentId]) VALUES (N'88e3e890-eb57-48ce-9720-d799c752c5bb')
INSERT [dbo].[NegativeSentiments] ([SentimentId]) VALUES (N'c1066621-2ff6-4bf1-ac2d-e31d8cde3af8')
GO
INSERT [dbo].[NeutralSentiments] ([SentimentId]) VALUES (N'6e3512e5-45ff-45ba-b54c-542c81564a20')
GO
INSERT [dbo].[PositiveAlarms] ([AlarmId]) VALUES (N'dfb260c4-3308-4aa8-b4f2-c8761d039181')
INSERT [dbo].[PositiveAlarms] ([AlarmId]) VALUES (N'32ff7e85-a8fa-443c-bb88-e0fde09ef21c')
GO
INSERT [dbo].[PositiveSentiments] ([SentimentId]) VALUES (N'507d8f98-54e0-4041-adc8-07cc748e73c6')
INSERT [dbo].[PositiveSentiments] ([SentimentId]) VALUES (N'8788fffc-59e7-4d46-8c89-700384f3c245')
INSERT [dbo].[PositiveSentiments] ([SentimentId]) VALUES (N'84f90f24-46d4-46f8-bc4f-91c6171e5df8')
INSERT [dbo].[PositiveSentiments] ([SentimentId]) VALUES (N'4e6cda4d-b255-4648-aff1-955aabf3bc69')
INSERT [dbo].[PositiveSentiments] ([SentimentId]) VALUES (N'0265377b-00e4-45a1-ae1c-e91d8dfb4da3')
GO
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'76dc220c-f126-46cc-a8f7-005ce8c50164', N'Hyundai siempre se renueva es genial. ', CAST(N'2019-06-26T00:00:00.000' AS DateTime), N'e2f5f38f-3b48-40df-8853-a26c38060241')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'a8c1a216-b599-43ea-911f-0073c427fad2', N'Universal es una empresa que sinceramente me encanta. ', CAST(N'2020-02-17T00:00:00.000' AS DateTime), N'cc445d6a-3fc5-4c9f-9161-1f23a2a897b8')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'5cd0569b-0ddb-459a-8405-0077ec8a7b23', N'Me gusta el nuevo celu de Apple. ', CAST(N'2020-03-31T00:00:00.000' AS DateTime), N'82782daa-4486-464a-b55d-545e4e17047d')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'2e7e3c49-8d09-4408-8285-008cc06ea980', N'Bose tiene un parlante que es horrible. ', CAST(N'2019-08-02T00:00:00.000' AS DateTime), N'ec9ffc2d-e8a8-471e-9596-4a48d34bc3e6')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'3bdd5a04-bad1-4640-b07d-010a85b197aa', N'El agua Nativa es desagradable, tiene feo gusto. ', CAST(N'2020-03-03T00:00:00.000' AS DateTime), N'5d1e6c2f-80aa-43b9-88d9-f3a2b74e0f37')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'35e7b469-51e1-4815-ac9e-035dd2e44489', N'Adoro tomarme una Salus despues de salir a correr.', CAST(N'2020-06-13T00:00:00.000' AS DateTime), N'1c8d2e60-f784-4cdb-a884-a6f59d952d07')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'c0dea14e-ccdb-4bd3-b75c-03f3cec08f3c', N'Detesto la marca Apple, no la puedo ver.', CAST(N'2020-03-10T00:00:00.000' AS DateTime), N'190e9cdc-750b-4b1d-a7fa-b73baaecfdf7')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'ce375c06-c3a2-4b55-83b7-0485ee29f19b', N'Odio con toda mi alma a Microsoft. ', CAST(N'2020-06-25T00:00:00.000' AS DateTime), N'ec9ffc2d-e8a8-471e-9596-4a48d34bc3e6')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'a5b38a55-83b5-425d-a24f-06763d1c13e4', N'Que horrible el contenido que sube Disney a su plataforma.', CAST(N'2020-04-16T00:00:00.000' AS DateTime), N'105c762e-2c5d-4631-b08d-5898b1fa1ba2')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'bd6d05b5-4b55-475f-994a-07c33345320d', N'Detesto tomar agua Nativa, es fea.', CAST(N'2019-07-06T00:00:00.000' AS DateTime), N'e2f5f38f-3b48-40df-8853-a26c38060241')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'0dd15183-4467-4b2f-a078-081d14f84e14', N'Telegam es una aplicación que odio. ', CAST(N'2020-03-29T00:00:00.000' AS DateTime), N'a6048e96-0a45-4c1e-9a76-152b8979c468')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'b56ab36b-a00a-4495-af56-086cac7fec41', N'Telegram tiene un diseño de colores que amo, tiene muchos temas para elegir. ', CAST(N'2019-08-08T00:00:00.000' AS DateTime), N'0d38f37d-d807-4dff-884c-670b5b68a726')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'a0462972-9340-404a-b799-0955c3e74aae', N'Netflix, esta haciendo algo que amo, subir mis series favoritas rapidamente. ', CAST(N'2020-04-25T00:00:00.000' AS DateTime), N'82782daa-4486-464a-b55d-545e4e17047d')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'220ced16-2de9-4e23-aae3-09725e53cd12', N'Odio el agua Nativa sin gas. ', CAST(N'2020-03-02T00:00:00.000' AS DateTime), N'a6048e96-0a45-4c1e-9a76-152b8979c468')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'464a500a-b79c-41f5-a6e9-0b9e60b16263', N'Adoro la aplicación Telegram, es mucho mejor que Whatsapp.', CAST(N'2019-10-17T00:00:00.000' AS DateTime), N'ec9ffc2d-e8a8-471e-9596-4a48d34bc3e6')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'cd77808f-abba-47c8-abe0-110d7fec9ce8', N'El gusto a metal que tiene la Coca-cola zero me da asco. ', CAST(N'2020-01-16T00:00:00.000' AS DateTime), N'cd399baf-a185-44c1-98bb-787ad29a2bb6')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'cf505ab9-c096-4537-aa9b-13d9ec0e86fa', N'Microsoft es una empresa genial. ', CAST(N'2020-02-12T00:00:00.000' AS DateTime), N'cd399baf-a185-44c1-98bb-787ad29a2bb6')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'0162ea6e-78e6-4ced-a334-166de4631061', N'Horrible fue mi experiencia con Hyundai. ', CAST(N'2020-03-23T00:00:00.000' AS DateTime), N'a6048e96-0a45-4c1e-9a76-152b8979c468')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'a1578497-fbf1-4303-af78-16c1cfb95e6b', N'La Salus es el agua mas rica, me encanta. ', CAST(N'2020-06-17T00:00:00.000' AS DateTime), N'ec9ffc2d-e8a8-471e-9596-4a48d34bc3e6')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'b312774a-3f49-4ca1-aaa7-16c37c9a8fde', N'Las peliculas de Universal siempre tienen algo que adoro. ', CAST(N'2020-06-04T00:00:00.000' AS DateTime), N'cd399baf-a185-44c1-98bb-787ad29a2bb6')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'11fce780-95b7-4f14-9859-1a4bb1727067', N'Odio los autos verdes de Hyundai', CAST(N'2019-10-17T00:00:00.000' AS DateTime), N'c2dd7c38-a44f-4b35-9484-e65eb5394566')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'1b9205a1-05d3-4454-a815-1a6643e66eda', N'Me gusta cuando sale un modelo de auto nuevo de Hyundai.', CAST(N'2019-06-29T00:00:00.000' AS DateTime), N'190e9cdc-750b-4b1d-a7fa-b73baaecfdf7')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'51d997c9-180d-4129-94cb-1acebf34a292', N'Me encanta cuando descubro datos nuevos de Universal. ', CAST(N'2019-10-30T00:00:00.000' AS DateTime), N'9eb65efa-8221-4d07-8437-edd5f89b1269')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'ae4a271f-e277-4616-9246-1b62e9585f0b', N'Que desagradable que es tener Whatsapp.', CAST(N'2019-08-18T00:00:00.000' AS DateTime), N'0d38f37d-d807-4dff-884c-670b5b68a726')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'002e2ead-f5d7-4964-898c-1cb270e825b1', N'Odio las notificaciones de Whatsapp.', CAST(N'2019-10-24T00:00:00.000' AS DateTime), N'0d38f37d-d807-4dff-884c-670b5b68a726')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'af57d6ee-3649-417e-8392-1d55b15a2066', N'Adoro la variedad de productos Coca-cola.', CAST(N'2019-06-25T00:00:00.000' AS DateTime), N'190e9cdc-750b-4b1d-a7fa-b73baaecfdf7')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'b6ff0fba-eba4-469d-8924-1f10a0179256', N'La Pepsi light con hamburguesa y papas fritas es una combinación que amo. ', CAST(N'2019-09-20T00:00:00.000' AS DateTime), N'ec9ffc2d-e8a8-471e-9596-4a48d34bc3e6')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'6a34bd21-8b2e-42e7-bea1-20bed405e942', N'Odio el contenido que Netflix sube. ', CAST(N'2019-08-07T00:00:00.000' AS DateTime), N'cc445d6a-3fc5-4c9f-9161-1f23a2a897b8')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'55572646-e9bf-4041-8b8e-253e0d5eeb4a', N'Las computadoras con sistema operativo Microsoft las detesto.', CAST(N'2019-12-31T00:00:00.000' AS DateTime), N'ec9ffc2d-e8a8-471e-9596-4a48d34bc3e6')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'5dd57286-86aa-49eb-abf9-25ac2b95a008', N'Universal es mi producta preferida, me gusta seguirla.', CAST(N'2019-07-05T00:00:00.000' AS DateTime), N'c2dd7c38-a44f-4b35-9484-e65eb5394566')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'ed88f7bf-6f03-4878-a47d-29672bac0d1b', N'Adoro los parques temáticos de Disney.', CAST(N'2019-11-23T00:00:00.000' AS DateTime), N'c0dcb0ab-38ca-4cb1-86b8-9e0628564908')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'b547ebc1-d466-45f2-9794-2a62fc23bf41', N'La Salus es desagradable, tiene olor. ', CAST(N'2019-11-09T00:00:00.000' AS DateTime), N'c0dcb0ab-38ca-4cb1-86b8-9e0628564908')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'422b4cee-efef-419a-a1de-2d1b67693bc6', N'Mi nueva notebook tiene Microsoft Windows, me gusta!.', CAST(N'2019-11-25T00:00:00.000' AS DateTime), N'e2f5f38f-3b48-40df-8853-a26c38060241')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'aab0ac3b-71da-4abc-ad90-2d52836db74c', N'Detesto el contenido que Disney sube a su servicio de streaming. ', CAST(N'2019-07-18T00:00:00.000' AS DateTime), N'2c6e11d8-f8fd-48fb-b804-139318afdbcd')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'1c07b5f0-7137-4c82-9542-2d9064549821', N'Los autos Hyundai son feos, los detesto.', CAST(N'2019-11-28T00:00:00.000' AS DateTime), N'cd399baf-a185-44c1-98bb-787ad29a2bb6')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'46e21c68-5f69-4ab6-86a8-2da203fa761c', N'Adoro el sabor neutro del agua Nativa.', CAST(N'2019-12-02T00:00:00.000' AS DateTime), N'691af1ff-d78c-4fda-8365-ec5b439d5f6b')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'3ac21a0c-8643-4023-b538-2eba8a88145a', N'Hoy descubrí Whatsapp, la verdad me encanta. ', CAST(N'2019-06-26T00:00:00.000' AS DateTime), N'82782daa-4486-464a-b55d-545e4e17047d')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'4a8295a9-7ad5-4d32-ba51-2f7fdf9785d0', N'La Salus es una marca que amo, es de mi país.', CAST(N'2019-10-26T00:00:00.000' AS DateTime), N'9eb65efa-8221-4d07-8437-edd5f89b1269')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'218d236a-35da-479e-8886-3302bd48d387', N'Que genial que todo el mundo use whatsapp. ', CAST(N'2019-06-26T00:00:00.000' AS DateTime), N'5d1e6c2f-80aa-43b9-88d9-f3a2b74e0f37')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'15398bfb-e23f-48e2-a86a-340da165f7f7', N'Hoy vi un auto Hyundai horrible de color verde. ', CAST(N'2019-12-09T00:00:00.000' AS DateTime), N'0d38f37d-d807-4dff-884c-670b5b68a726')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'd5953dad-d1fb-4f0f-9bb2-359827136090', N'Hyundai tiene un auto que me gusta. ', CAST(N'2019-12-16T00:00:00.000' AS DateTime), N'a614f34c-3ab3-414e-ab25-8e6dd631613a')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'cb30fe54-37a5-4a7c-b302-36097ad34c6e', N'Hoy compré una compu que usa Microsoft, me gusta. ', CAST(N'2019-09-19T00:00:00.000' AS DateTime), N'9eb65efa-8221-4d07-8437-edd5f89b1269')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'c9598b84-f07a-4618-976c-36135ce76a21', N'Detesto el contenido que se publica en Facebook. ', CAST(N'2020-01-22T00:00:00.000' AS DateTime), N'cc445d6a-3fc5-4c9f-9161-1f23a2a897b8')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'4f519564-9344-4cc7-bb57-38f928bc38ae', N'La última película de Universal es desagradable. ', CAST(N'2019-10-16T00:00:00.000' AS DateTime), N'82782daa-4486-464a-b55d-545e4e17047d')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'4ddab4a9-3b1a-47d4-9c6f-39471038c78e', N'Que horrible, hoy tomé agua Nativa y tenia sabor feo. ', CAST(N'2019-06-25T00:00:00.000' AS DateTime), N'e2f5f38f-3b48-40df-8853-a26c38060241')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'a2bdd3ed-56da-48ae-b4fd-3af5b35c155d', N'Twitter es una red social que me gusta. ', CAST(N'2019-11-09T00:00:00.000' AS DateTime), N'9eb65efa-8221-4d07-8437-edd5f89b1269')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'f398115a-81c7-4112-8534-3c5c5e55e5e5', N'Twitter es una plataforma re divertida, me encanta. ', CAST(N'2019-07-01T00:00:00.000' AS DateTime), N'0d38f37d-d807-4dff-884c-670b5b68a726')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'1b5f4412-88a1-48dc-9a71-3d063ac01915', N'Facebook me gusta para hablar con amigos. ', CAST(N'2020-01-07T00:00:00.000' AS DateTime), N'a6048e96-0a45-4c1e-9a76-152b8979c468')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'1450b92d-ea6c-4a3b-852f-3ddd2aa54d18', N'Desagradable la Pepsi, es mejor tomar agua Nativa. ', CAST(N'2020-04-30T00:00:00.000' AS DateTime), N'105c762e-2c5d-4631-b08d-5898b1fa1ba2')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'de487214-5549-46ff-b5bd-3fe3500c9921', N'Universal studios es una productora que odio.', CAST(N'2020-04-02T00:00:00.000' AS DateTime), N'8c37acf9-22ac-40f8-b8df-69f0bc4d6aeb')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'ce0e1253-52d4-414c-8f68-401d16720d2e', N'Twitter es una aplicación horrible de usar. ', CAST(N'2019-12-02T00:00:00.000' AS DateTime), N'cc445d6a-3fc5-4c9f-9161-1f23a2a897b8')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'a8ad1a29-ae43-4720-99f6-438efc78e1aa', N'Salus es mi agua preferida, me gusta su frescura. ', CAST(N'2020-02-06T00:00:00.000' AS DateTime), N'1c8d2e60-f784-4cdb-a884-a6f59d952d07')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'aa3210cb-5afe-4b8f-858b-439e27d69939', N'Odio la bebida negra Coca-cola. ', CAST(N'2020-01-10T00:00:00.000' AS DateTime), N'd94f1134-c5ff-4b9b-90e3-e270221ec2bf')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'd91364d6-8116-4949-ae33-43eed01b318f', N'Amo ver las conferencias de productos de Apple.', CAST(N'2019-12-04T00:00:00.000' AS DateTime), N'c0dcb0ab-38ca-4cb1-86b8-9e0628564908')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'965fdb72-9c49-4e61-a037-44eb5b5aea4c', N'Tengo unos auriculares Bose que suenan horrible.', CAST(N'2020-03-10T00:00:00.000' AS DateTime), N'105c762e-2c5d-4631-b08d-5898b1fa1ba2')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'22f837a6-0a16-4241-99a2-455c3dad596d', N'Me encanta agregar familiares a Twitter. ', CAST(N'2019-07-26T00:00:00.000' AS DateTime), N'2c6e11d8-f8fd-48fb-b804-139318afdbcd')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'8b20fc2e-fa99-404c-806b-4654dc40f8d6', N'Facebook es así de genial, mucho contenido, mucha diversión. ', CAST(N'2019-10-26T00:00:00.000' AS DateTime), N'a6048e96-0a45-4c1e-9a76-152b8979c468')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'615da002-f9ee-4f72-a5f5-4704c55c7e24', N'El agua Salus es la mejor sin dudas, adoro su frescura.', CAST(N'2019-09-06T00:00:00.000' AS DateTime), N'cc445d6a-3fc5-4c9f-9161-1f23a2a897b8')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'cece46ad-76d3-461e-a93b-490cf1bf2041', N'El parque de diversiones de Universal es mi preferido en Orlando, lo adoro. ', CAST(N'2020-05-18T00:00:00.000' AS DateTime), N'd94f1134-c5ff-4b9b-90e3-e270221ec2bf')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'af9724ed-70c2-4099-9212-49e0015a7cef', N'Que horrible Universal, es algo que detesto, hagan algo original.', CAST(N'2020-02-02T00:00:00.000' AS DateTime), N'cd399baf-a185-44c1-98bb-787ad29a2bb6')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'9652d820-d6b7-4e73-a590-4af2e2ff8771', N'El agua Nativa es horrible, siempre esta turbia. ', CAST(N'2020-01-09T00:00:00.000' AS DateTime), N'd94f1134-c5ff-4b9b-90e3-e270221ec2bf')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'ec817084-b836-4dab-bc75-4afbb9bb80a7', N'Como amo las peliculas de Universal, siempre tienenmuy buen contenido. ', CAST(N'2019-10-15T00:00:00.000' AS DateTime), N'82782daa-4486-464a-b55d-545e4e17047d')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'3c89267a-634c-4e0f-8cdb-4c280570dbfc', N'Las series originales de Netflix son un asco. ', CAST(N'2019-07-16T00:00:00.000' AS DateTime), N'cc445d6a-3fc5-4c9f-9161-1f23a2a897b8')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'0e22e181-a934-4328-b00f-4c92e1da3e8f', N'Que horrible que es no encontrar nada para ver en Netflix. ', CAST(N'2020-05-15T00:00:00.000' AS DateTime), N'cd399baf-a185-44c1-98bb-787ad29a2bb6')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'd5abe776-a8cb-4627-a5d2-4d253e93d78c', N'Hyundai tiene que mejorar, es horrible. ', CAST(N'2019-07-31T00:00:00.000' AS DateTime), N'd94f1134-c5ff-4b9b-90e3-e270221ec2bf')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'e281827a-41eb-48db-bb60-4e1f242d56fb', N'La Pepsi light es desagradable. ', CAST(N'2020-05-09T00:00:00.000' AS DateTime), N'8c37acf9-22ac-40f8-b8df-69f0bc4d6aeb')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'ab8188c4-071d-48ab-b1a5-4ee331759181', N'Adoro encontrarme con viejos amigos en Facebook.', CAST(N'2020-06-10T00:00:00.000' AS DateTime), N'691af1ff-d78c-4fda-8365-ec5b439d5f6b')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'87509f27-1283-4942-b8c7-4f18d890dbc0', N'Es horrible que Apple cobre tanto. ', CAST(N'2019-08-26T00:00:00.000' AS DateTime), N'691af1ff-d78c-4fda-8365-ec5b439d5f6b')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'f49ad41e-0a6f-49ad-9f3a-4f3743d8f343', N'Hoy probé Coca-cola zero y la verdad me gusta. ', CAST(N'2019-12-27T00:00:00.000' AS DateTime), N'cc445d6a-3fc5-4c9f-9161-1f23a2a897b8')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'ca590f5f-119b-4f7e-baff-52d6984f4995', N'Amo chusmear peleas en Facebook, es muy divertido.', CAST(N'2019-09-23T00:00:00.000' AS DateTime), N'5d1e6c2f-80aa-43b9-88d9-f3a2b74e0f37')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'26513aa0-588c-48dd-889b-556b2a88b594', N'Que desagradable cuando la Salus tiene gusto a tierra. ', CAST(N'2020-05-04T00:00:00.000' AS DateTime), N'105c762e-2c5d-4631-b08d-5898b1fa1ba2')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'87ac593d-5dcb-4fc6-8623-5582a50bdce5', N'Adoro ver las publicaciones de mis famosos preferidos en Twitter. ', CAST(N'2019-07-08T00:00:00.000' AS DateTime), N'105c762e-2c5d-4631-b08d-5898b1fa1ba2')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'18cdd690-4977-4051-b2e3-58be2e807cc1', N'Adoro el diseño de los notebooks de Apple.', CAST(N'2020-01-02T00:00:00.000' AS DateTime), N'1c8d2e60-f784-4cdb-a884-a6f59d952d07')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'4ef1d560-dfb7-48e4-a1a5-58fcbdc158a5', N'Los auriculares Bose tienen un color amarrillo desagradable. ', CAST(N'2020-03-17T00:00:00.000' AS DateTime), N'190e9cdc-750b-4b1d-a7fa-b73baaecfdf7')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'8402a461-f66b-48e4-871e-598606e3abe9', N'Lo que mas adoro de Bose, son sus lentes de sol con parlantes!', CAST(N'2019-12-22T00:00:00.000' AS DateTime), N'ec9ffc2d-e8a8-471e-9596-4a48d34bc3e6')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'b1f71b16-1441-4409-9eda-59945bc6b32d', N'La Pepsi es deliciosa, adoro su sabor.', CAST(N'2019-10-06T00:00:00.000' AS DateTime), N'2c6e11d8-f8fd-48fb-b804-139318afdbcd')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'dac559a1-6db8-403b-a912-59c0aa8ec7ff', N'Es desagradable como la gente chusmea en Facebook. ', CAST(N'2019-10-20T00:00:00.000' AS DateTime), N'c0dcb0ab-38ca-4cb1-86b8-9e0628564908')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'8f192650-4032-4469-abd0-59c2a2d44b3a', N'Me encanta mirar las películas de Universal. ', CAST(N'2019-11-16T00:00:00.000' AS DateTime), N'2c6e11d8-f8fd-48fb-b804-139318afdbcd')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'b40e5e80-f4c6-47e6-aae2-5b61029fc53d', N'Whatsapp es genial, mucho mas divertido que los sms. ', CAST(N'2019-09-03T00:00:00.000' AS DateTime), N'5d1e6c2f-80aa-43b9-88d9-f3a2b74e0f37')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'0d6d3012-7956-4fa1-a221-5cb5d0836453', N'Los auriculares Bose son un asco. ', CAST(N'2019-10-02T00:00:00.000' AS DateTime), N'd94f1134-c5ff-4b9b-90e3-e270221ec2bf')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'411996cd-cb45-425d-b854-5e09118ed87b', N'Mis auriculares nuevos Bose son de muy buena calidad, los adoro.', CAST(N'2019-12-04T00:00:00.000' AS DateTime), N'a614f34c-3ab3-414e-ab25-8e6dd631613a')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'be48fe0a-23c1-4119-89fe-5f04fb44d58e', N'Que calidad horrible que tiene la Pepsi. ', CAST(N'2019-11-10T00:00:00.000' AS DateTime), N'a6048e96-0a45-4c1e-9a76-152b8979c468')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'7e3fbb67-8d7b-492e-af91-619fc2165070', N'Telegram tiene algo que detesto, los colores.', CAST(N'2019-12-11T00:00:00.000' AS DateTime), N'82782daa-4486-464a-b55d-545e4e17047d')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'7b828afb-62a9-4821-b3f1-634abbf2c8e3', N'Me gusta mas la Coca-cola light que la común. ', CAST(N'2019-11-17T00:00:00.000' AS DateTime), N'0d38f37d-d807-4dff-884c-670b5b68a726')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'66eb1590-30b2-48fb-960e-636977580318', N'Que horrible que es Facebook, es un chusmerio. ', CAST(N'2020-03-24T00:00:00.000' AS DateTime), N'cc445d6a-3fc5-4c9f-9161-1f23a2a897b8')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'9455f947-00c9-4166-a515-63f846c0751e', N'Amo que Telegram pueda usarse como app de escritorio. ', CAST(N'2019-09-02T00:00:00.000' AS DateTime), N'cc445d6a-3fc5-4c9f-9161-1f23a2a897b8')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'070c9c71-b78e-4f93-a5a5-644f436699c8', N'Apple es una marca que me gusta sinceramente. ', CAST(N'2019-11-30T00:00:00.000' AS DateTime), N'2c6e11d8-f8fd-48fb-b804-139318afdbcd')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'4d224305-ea22-411b-bbe0-646ee697f86e', N'El Windows de Microsoft es genial.', CAST(N'2019-09-23T00:00:00.000' AS DateTime), N'cc445d6a-3fc5-4c9f-9161-1f23a2a897b8')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'382614d4-f5ff-4d13-985a-647b615e3256', N'Adoro el equipamiento de audio Bose, el mejor del mercado. ', CAST(N'2020-06-12T00:00:00.000' AS DateTime), N'ec9ffc2d-e8a8-471e-9596-4a48d34bc3e6')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'2e70f37c-c808-4389-97ec-6584c0e0a482', N'La Salus es muy desagradable de tomar. ', CAST(N'2020-01-11T00:00:00.000' AS DateTime), N'a6048e96-0a45-4c1e-9a76-152b8979c468')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'4994ac10-21dd-48ef-b020-679606cb3673', N'Hoy tomé Coca-cola por primera vez y ahora me encanta. ', CAST(N'2019-10-28T00:00:00.000' AS DateTime), N'8c37acf9-22ac-40f8-b8df-69f0bc4d6aeb')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'36c377e9-cd29-4ceb-8628-6b17df000cbe', N'Odio las películas originales de Netfix. ', CAST(N'2020-01-27T00:00:00.000' AS DateTime), N'9eb65efa-8221-4d07-8437-edd5f89b1269')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'a9f23471-3787-407d-bee3-6c5626230579', N'Odio la Coca-cola light. ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'cd399baf-a185-44c1-98bb-787ad29a2bb6')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'89411a65-459d-46c7-b3c8-6d6ec9021f8a', N'Odio el sistema operativo de Microsoft.', CAST(N'2020-02-02T00:00:00.000' AS DateTime), N'9039f350-c34d-4704-a477-fafc56652007')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'aee54ef6-f6f2-47a3-a213-6d9dfeb4cdf5', N'Las peliculas de Netflix son un asco. ', CAST(N'2020-03-07T00:00:00.000' AS DateTime), N'a6048e96-0a45-4c1e-9a76-152b8979c468')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'57a00df3-d026-4e3a-bd74-6e3429cea6f3', N'Facebook tiene algo genial, las fotos que suben las personas. ', CAST(N'2019-08-02T00:00:00.000' AS DateTime), N'ec9ffc2d-e8a8-471e-9596-4a48d34bc3e6')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'1e995932-e4af-4076-843f-6f4c1d64acbe', N'La Coca-cola es re rica, me gusta. ', CAST(N'2019-10-12T00:00:00.000' AS DateTime), N'691af1ff-d78c-4fda-8365-ec5b439d5f6b')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'e5d283cc-0f6b-4f5d-9c39-70a6839876ef', N'Me gusta comprar artículos de Apple. ', CAST(N'2019-09-01T00:00:00.000' AS DateTime), N'1c8d2e60-f784-4cdb-a884-a6f59d952d07')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'bb189161-21bf-4bd4-b411-70b4b88f5fea', N'Es desagradable como Facebook roba información.', CAST(N'2020-05-11T00:00:00.000' AS DateTime), N'190e9cdc-750b-4b1d-a7fa-b73baaecfdf7')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'9638949e-8405-4299-858c-7144b13ff3c2', N'Netflix sube contenido que sinceramente es horrible. ', CAST(N'2019-07-14T00:00:00.000' AS DateTime), N'ec9ffc2d-e8a8-471e-9596-4a48d34bc3e6')
GO
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'5f0abd15-302d-45a6-97ef-721455526e38', N'Mi compu nueva usa Microsoft 8 y lo odio. ', CAST(N'2019-12-18T00:00:00.000' AS DateTime), N'cc445d6a-3fc5-4c9f-9161-1f23a2a897b8')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'4bc3c865-3a36-400c-bd7a-726b7648e138', N'Coca-cola hace desagradable mi almuerzo del fin de semana. ', CAST(N'2020-01-23T00:00:00.000' AS DateTime), N'82782daa-4486-464a-b55d-545e4e17047d')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'7b66e183-80d3-4985-85e4-72f86f96db60', N'La fuente del puma de Salus, es un paseo que amo hacer.', CAST(N'2019-12-07T00:00:00.000' AS DateTime), N'9039f350-c34d-4704-a477-fafc56652007')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'92bd292d-1fc2-414e-9407-73c8eaa97856', N'Twitter es una red social desagradable.', CAST(N'2019-10-28T00:00:00.000' AS DateTime), N'ec9ffc2d-e8a8-471e-9596-4a48d34bc3e6')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'ac33fc6d-5b95-4e4a-b589-7b823b2e7e70', N'Disney es genial, es la mejor empresa del mundo. ', CAST(N'2020-06-07T00:00:00.000' AS DateTime), N'5d1e6c2f-80aa-43b9-88d9-f3a2b74e0f37')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'088b5396-2fe0-43dd-9398-7ba218cbfca7', N'Telegram es una idea que esta genial.', CAST(N'2019-11-01T00:00:00.000' AS DateTime), N'1c8d2e60-f784-4cdb-a884-a6f59d952d07')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'e4b15a20-f0fb-4e91-9631-7bf584fe8d4a', N'Me gusta el sonido de las notificaciones de Whatsapp.', CAST(N'2019-10-06T00:00:00.000' AS DateTime), N'0d38f37d-d807-4dff-884c-670b5b68a726')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'cb4d9821-bb38-4f1b-800b-7cbd3a0b7ac9', N'Que horrible que Disney sea tan caro. ', CAST(N'2019-12-08T00:00:00.000' AS DateTime), N'a6048e96-0a45-4c1e-9a76-152b8979c468')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'7fc31ddc-daf1-4b30-ac11-7dab2ce31255', N'Adoro tomarme una Pepsi bien fría.', CAST(N'2019-10-03T00:00:00.000' AS DateTime), N'1c8d2e60-f784-4cdb-a884-a6f59d952d07')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'a119490d-1859-4783-93b0-80f9779d926b', N'Netflix es un servicio de streaming muy completo, lo amo, es mi preferido. ', CAST(N'2019-12-10T00:00:00.000' AS DateTime), N'0d38f37d-d807-4dff-884c-670b5b68a726')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'a80eae08-e904-4545-9474-81440a216ec0', N'Facebook tiene algo genial, puedo publicar cosas para mi negocio. ', CAST(N'2020-03-13T00:00:00.000' AS DateTime), N'1c8d2e60-f784-4cdb-a884-a6f59d952d07')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'11578cb1-cd76-482f-aee4-81bb0fc69551', N'La rama de productos Apple es muy extensa, pero lo que mas adoro son los airpods.', CAST(N'2019-07-22T00:00:00.000' AS DateTime), N'9039f350-c34d-4704-a477-fafc56652007')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'3a07d45b-2f63-4b63-9ac8-82801de2ec80', N'Odio el sabor imundo de la Pepsi. ', CAST(N'2019-08-12T00:00:00.000' AS DateTime), N'5d1e6c2f-80aa-43b9-88d9-f3a2b74e0f37')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'c42f72fb-03ec-4148-94ee-849c18ba71b0', N'Me encanta mandar mensajes por Whatsapp. ', CAST(N'2019-07-08T00:00:00.000' AS DateTime), N'1c8d2e60-f784-4cdb-a884-a6f59d952d07')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'66e71428-3a14-4349-932a-852b8ca6e6e5', N'Que genial tomarse una Coca-cola bien fría.', CAST(N'2020-04-13T00:00:00.000' AS DateTime), N'82782daa-4486-464a-b55d-545e4e17047d')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'6777f351-7d48-4fa4-9f9f-85b9ce8ac2d3', N'Hyundai es una marca de autos que me encanta. ', CAST(N'2019-09-04T00:00:00.000' AS DateTime), N'2c6e11d8-f8fd-48fb-b804-139318afdbcd')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'6457ff81-8d3e-4d65-a36a-873ec88cf3f2', N'Detesto el agua Nativa, tiene algo que no me gusta.', CAST(N'2019-07-18T00:00:00.000' AS DateTime), N'e2f5f38f-3b48-40df-8853-a26c38060241')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'd93763bb-1e56-4783-94ae-88f81dbabb94', N'Me gusta tomar Pepsi, tiene rico sabor.', CAST(N'2019-08-17T00:00:00.000' AS DateTime), N'9039f350-c34d-4704-a477-fafc56652007')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'e85f9f9c-420d-4c6d-b57a-8af9cb46bd2b', N'Odio Apple y su avaricia. ', CAST(N'2019-10-29T00:00:00.000' AS DateTime), N'0d38f37d-d807-4dff-884c-670b5b68a726')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'87ebd0c7-99ab-40cd-8be7-8d18db96c8b9', N'Nunca tomé un agua que no sea Salus, creo que amo su sabor. ', CAST(N'2019-11-15T00:00:00.000' AS DateTime), N'105c762e-2c5d-4631-b08d-5898b1fa1ba2')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'3f7f26b8-0fa2-4dd0-a770-8dcca5ae6118', N'Me gusta tomar Coca-cola los fines de semana. ', CAST(N'2020-05-17T00:00:00.000' AS DateTime), N'0d38f37d-d807-4dff-884c-670b5b68a726')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'103b339f-939a-40c5-b881-8e6570689849', N'Microsoft es desagradable, aguante Linux. ', CAST(N'2019-08-07T00:00:00.000' AS DateTime), N'c0dcb0ab-38ca-4cb1-86b8-9e0628564908')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'eccd7890-57ee-48c2-9618-8e7af7abaeff', N'El agua Nativa es algo que detesto.', CAST(N'2020-06-09T00:00:00.000' AS DateTime), N'8c37acf9-22ac-40f8-b8df-69f0bc4d6aeb')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'1c2376ea-d8e1-454e-b00a-923240040846', N'Detesto las series que sube Netflix. ', CAST(N'2020-06-14T00:00:00.000' AS DateTime), N'190e9cdc-750b-4b1d-a7fa-b73baaecfdf7')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'ecadb2ee-7af0-4a51-8400-93a05c235fe5', N'Me encanta el modelo de las compus de Apple.', CAST(N'2019-12-05T00:00:00.000' AS DateTime), N'691af1ff-d78c-4fda-8365-ec5b439d5f6b')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'0bbb70fc-6c06-47c0-a08c-97ab04b8c39a', N'Me gusta cuando aparece un trailer de Universal en el cine. ', CAST(N'2019-12-30T00:00:00.000' AS DateTime), N'd94f1134-c5ff-4b9b-90e3-e270221ec2bf')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'615a37a1-5875-4578-a514-99b2b9ade88b', N'Detesto recibir notificaciones por Telegram.', CAST(N'2019-07-26T00:00:00.000' AS DateTime), N'cc445d6a-3fc5-4c9f-9161-1f23a2a897b8')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'fe78367c-42fd-4c3d-bfd6-99d93a90f24c', N'Amo el agua Nativa, en los dias de calor, es lo mas refrescante. ', CAST(N'2020-02-07T00:00:00.000' AS DateTime), N'2c6e11d8-f8fd-48fb-b804-139318afdbcd')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'8124a95a-1c5f-4df8-9ac2-9a1f0d0d641f', N'Que genial que son los jueguitos de Facebook. ', CAST(N'2019-12-05T00:00:00.000' AS DateTime), N'a6048e96-0a45-4c1e-9a76-152b8979c468')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'5f388807-1f02-41b4-94e4-9b5a9bb9ef0b', N'Adoro la Coca-cola light!.', CAST(N'2019-07-17T00:00:00.000' AS DateTime), N'cd399baf-a185-44c1-98bb-787ad29a2bb6')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'27ecdfb4-f961-4c76-b732-9fbdce0371a7', N'Odio tomar Coca-cola sin gas. ', CAST(N'2019-10-13T00:00:00.000' AS DateTime), N'a6048e96-0a45-4c1e-9a76-152b8979c468')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'bd2428a7-1ba3-4df8-ad03-a061e4c53bf8', N'Odio cuando Universal saca películas malas. ', CAST(N'2020-05-21T00:00:00.000' AS DateTime), N'0d38f37d-d807-4dff-884c-670b5b68a726')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'7e5cd7c1-ff9d-493a-86a0-a11641428a60', N'Me encanta tomar Pepsi los fines de semana. ', CAST(N'2019-09-21T00:00:00.000' AS DateTime), N'2c6e11d8-f8fd-48fb-b804-139318afdbcd')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'd689e952-b456-4f08-83d2-a26499786fa2', N'El helado super grande y dulce que venden en Disney me produce asco. ', CAST(N'2019-11-24T00:00:00.000' AS DateTime), N'691af1ff-d78c-4fda-8365-ec5b439d5f6b')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'478fc7fc-c311-47ef-a866-a344db6919af', N'Mi auto soñado va a ser Hyundai, amo esa marca. ', CAST(N'2019-11-19T00:00:00.000' AS DateTime), N'a6048e96-0a45-4c1e-9a76-152b8979c468')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'dd23cc44-21c1-43fb-a188-a368c17dc7c6', N'Los vehículos de Hyundai amarillos son un asco. ', CAST(N'2020-05-10T00:00:00.000' AS DateTime), N'9039f350-c34d-4704-a477-fafc56652007')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'f36fd635-9043-49ec-87b6-a3ffb801dcf7', N'El Whatsapp es super adictivo y desagradable.', CAST(N'2020-06-09T00:00:00.000' AS DateTime), N'e2f5f38f-3b48-40df-8853-a26c38060241')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'16ebdc39-4441-4b1a-9457-a5b0b9e1f3d6', N'No hay nada como una Coca-cola fría en verano, como la amo!.', CAST(N'2019-06-25T00:00:00.000' AS DateTime), N'9eb65efa-8221-4d07-8437-edd5f89b1269')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'c20c9fe3-868c-4a3c-b685-a69f229a2829', N'Universal tiene algo que detesto, sus producciones. ', CAST(N'2019-08-09T00:00:00.000' AS DateTime), N'a614f34c-3ab3-414e-ab25-8e6dd631613a')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'0bb7c25b-f9c7-4690-8cb7-a813d82246c2', N'Que divertido que es Whatsapp, me encanta. ', CAST(N'2019-08-20T00:00:00.000' AS DateTime), N'9eb65efa-8221-4d07-8437-edd5f89b1269')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'bf6c9a92-c3ce-4ffb-8e16-a8852c8524a3', N'Hyundai tiene autos horribles, la mayoria son un asco. ', CAST(N'2019-09-02T00:00:00.000' AS DateTime), N'9039f350-c34d-4704-a477-fafc56652007')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'4598ee52-91c0-43ff-98ff-a8ca9ccbdaea', N'Que genial cuando agrego famosos en Twitter.', CAST(N'2019-07-12T00:00:00.000' AS DateTime), N'5d1e6c2f-80aa-43b9-88d9-f3a2b74e0f37')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'3ee7ebe7-a6ed-44a1-bd73-aa1d6f3e95f0', N'Amo viajar a Disney en Orlando, Florida.', CAST(N'2019-08-31T00:00:00.000' AS DateTime), N'82782daa-4486-464a-b55d-545e4e17047d')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'dd212526-4150-4da1-89ea-aa9353786953', N'Que horrible, hoy fui a Universal y no me gustó. ', CAST(N'2020-03-08T00:00:00.000' AS DateTime), N'a614f34c-3ab3-414e-ab25-8e6dd631613a')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'c6af9cc0-cf65-41a7-9bfc-aaa5f8e7e74e', N'Hyundai tiene la mejor marca de vehículos del mercado, la adoro!.', CAST(N'2019-11-27T00:00:00.000' AS DateTime), N'8c37acf9-22ac-40f8-b8df-69f0bc4d6aeb')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'4b197191-6b1a-4403-b558-abca637bad8c', N'Que desagradable tener sed y tener que tomar agua Nativa. ', CAST(N'2019-07-26T00:00:00.000' AS DateTime), N'82782daa-4486-464a-b55d-545e4e17047d')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'fbde47b2-c5a3-455c-bf35-ac38e812bf76', N'Microsoft me gusta, siempre tiene productos útiles. ', CAST(N'2020-06-14T00:00:00.000' AS DateTime), N'9039f350-c34d-4704-a477-fafc56652007')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'75c861e5-c705-4415-9d92-b005e7db3338', N'Amo cuando recibo notificaciones de Telegram en mi pc. ', CAST(N'2019-10-21T00:00:00.000' AS DateTime), N'8c37acf9-22ac-40f8-b8df-69f0bc4d6aeb')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'6dfa04e7-0e6c-49ef-b85e-b3dff10b87ad', N'Hoy tomé Pepsi, que horrible la verdad. ', CAST(N'2019-12-20T00:00:00.000' AS DateTime), N'2c6e11d8-f8fd-48fb-b804-139318afdbcd')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'efc78635-c852-415d-8779-b48538bbc3a3', N'Que desagradable es una actualizacion de Microsoft. ', CAST(N'2019-11-26T00:00:00.000' AS DateTime), N'a6048e96-0a45-4c1e-9a76-152b8979c468')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'1bb40d72-1cce-4b36-850a-b578a675fb0f', N'Odio cuando Microsoft te corre actualizaciones. ', CAST(N'2019-12-13T00:00:00.000' AS DateTime), N'82782daa-4486-464a-b55d-545e4e17047d')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'e47b7ffc-f94a-415a-b9e3-ba6840e259c6', N'Me encanta el modelo de los lentes con parlante de Bose. ', CAST(N'2020-02-11T00:00:00.000' AS DateTime), N'9039f350-c34d-4704-a477-fafc56652007')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'24537df2-07ea-45d1-97af-bc5119e016a3', N'Desagradable es tener sistema operativo Microsoft. ', CAST(N'2019-11-19T00:00:00.000' AS DateTime), N'cc445d6a-3fc5-4c9f-9161-1f23a2a897b8')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'f71fc219-3f6e-4d63-8df2-bd17e176f9cb', N'Pepsi es una marca que detesto. ', CAST(N'2020-02-23T00:00:00.000' AS DateTime), N'105c762e-2c5d-4631-b08d-5898b1fa1ba2')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'11381277-6d5f-4101-8eb2-be0070d81a5d', N'Detesto las películas nuevas de Disney.', CAST(N'2019-07-16T00:00:00.000' AS DateTime), N'c0dcb0ab-38ca-4cb1-86b8-9e0628564908')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'9bb44658-185e-4574-a220-c05aeaa7044d', N'Los precios de Netflix son un asco. ', CAST(N'2020-03-27T00:00:00.000' AS DateTime), N'9eb65efa-8221-4d07-8437-edd5f89b1269')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'f14c268a-2c19-4d5c-9360-c2be0ae956b7', N'El nuevo remake de Disney es desagradable.  ', CAST(N'2020-05-20T00:00:00.000' AS DateTime), N'c0dcb0ab-38ca-4cb1-86b8-9e0628564908')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'19b7460c-363c-450b-a07e-c2de8f2eaaf9', N'Me compre un auto Hyundai que es horrible. ', CAST(N'2019-12-01T00:00:00.000' AS DateTime), N'9039f350-c34d-4704-a477-fafc56652007')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'913365a4-f169-431a-8621-c4c58383c96b', N'Hoy me compre una compu que usa Microsoft y es horrible. ', CAST(N'2020-01-29T00:00:00.000' AS DateTime), N'cd399baf-a185-44c1-98bb-787ad29a2bb6')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'8edb1026-390e-4552-8bea-c7f81ef957b6', N'Adoro tomar resfrescos Coca-cola los domingos en familia.', CAST(N'2020-05-05T00:00:00.000' AS DateTime), N'a6048e96-0a45-4c1e-9a76-152b8979c468')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'11ef6690-b689-4575-ad8f-c923edd6f94d', N'El agua Nativa muchas veces tiene tierra, que asco.', CAST(N'2020-02-04T00:00:00.000' AS DateTime), N'105c762e-2c5d-4631-b08d-5898b1fa1ba2')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'f44433db-1bbf-487a-80fb-cad733a25d30', N'Odio que Telegram no tenga night mode.', CAST(N'2020-01-04T00:00:00.000' AS DateTime), N'0d38f37d-d807-4dff-884c-670b5b68a726')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'7a4a9f94-4659-4578-ae74-ccc0d9339741', N'Me gusta cuando en Twitter hay fotos de perros. ', CAST(N'2020-04-11T00:00:00.000' AS DateTime), N'c0dcb0ab-38ca-4cb1-86b8-9e0628564908')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'8644f20b-e042-4adf-ae2e-ce98c3d7ef6f', N'Cual vehículo de Hyundai es el que mas me encanta ?', CAST(N'2019-08-27T00:00:00.000' AS DateTime), N'1c8d2e60-f784-4cdb-a884-a6f59d952d07')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'46cc5b5c-a365-4171-9456-cf41be95f29c', N'Detesto las actualizaciones de Microsoft. ', CAST(N'2020-06-24T00:00:00.000' AS DateTime), N'8c37acf9-22ac-40f8-b8df-69f0bc4d6aeb')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'aa7c6efd-46de-403e-8a2a-d0926510f5df', N'Mi parlante Bose nuevo me gusta mucho. ', CAST(N'2019-08-21T00:00:00.000' AS DateTime), N'e2f5f38f-3b48-40df-8853-a26c38060241')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'013122b5-d11a-4282-bb95-d21a7450edab', N'Que asco que son las cadenas de Whatsapp. ', CAST(N'2020-02-27T00:00:00.000' AS DateTime), N'a6048e96-0a45-4c1e-9a76-152b8979c468')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'9a336506-469e-434c-a051-d41ad25134f3', N'Twitter tiene todo lo que me encanta, publicaciones divertidas y noticias. ', CAST(N'2019-10-31T00:00:00.000' AS DateTime), N'8c37acf9-22ac-40f8-b8df-69f0bc4d6aeb')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'4a41c793-ce84-4040-870b-d4feb1480ecf', N'Adoro subir fotos mias y de mi familia al Facebook.', CAST(N'2019-11-21T00:00:00.000' AS DateTime), N'190e9cdc-750b-4b1d-a7fa-b73baaecfdf7')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'2684a738-c9d6-4ab6-ad3f-daf6e58b26e7', N'Yo tomo Nativa, es la que mas me gusta. ', CAST(N'2019-08-20T00:00:00.000' AS DateTime), N'ec9ffc2d-e8a8-471e-9596-4a48d34bc3e6')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'db60cb97-f27f-4e00-9272-db099a562aab', N'Me gusta cambiar el fondo de pantalla de Whatsapp.', CAST(N'2019-09-12T00:00:00.000' AS DateTime), N'd94f1134-c5ff-4b9b-90e3-e270221ec2bf')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'ffe0f91f-27ce-45c1-aeef-db7998e7a2ec', N'El color negro de la Coca-cola es horrible.', CAST(N'2019-07-18T00:00:00.000' AS DateTime), N'8c37acf9-22ac-40f8-b8df-69f0bc4d6aeb')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'dcf2fa6e-dfb6-4a56-be72-dbc58ad8b1e2', N'Facebook tiene mucha información interesante, lo adoro. ', CAST(N'2019-12-25T00:00:00.000' AS DateTime), N'190e9cdc-750b-4b1d-a7fa-b73baaecfdf7')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'ee5464ff-ab83-4a8e-ab26-dcb93dbe2bb2', N'Twitter es una red social que odio con todas mis fuerzas. ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'1c8d2e60-f784-4cdb-a884-a6f59d952d07')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'6d6c3687-6b8a-44c6-b3b5-dd547aebae76', N'El presidente de Disney esta tomando muy malas decisiones, me da asco. ', CAST(N'2020-04-17T00:00:00.000' AS DateTime), N'a6048e96-0a45-4c1e-9a76-152b8979c468')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'43d4d5f6-d3ee-490c-8c0d-de437dbfa418', N'Adoro los viernes de peliculas en Netflix.', CAST(N'2020-03-14T00:00:00.000' AS DateTime), N'9eb65efa-8221-4d07-8437-edd5f89b1269')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'5c9dad9e-fbe7-4353-a39b-df5a654da602', N'Me enamore del nuevo auto Hyundai gris, es hermoso, lo amo. ', CAST(N'2019-08-12T00:00:00.000' AS DateTime), N'cd399baf-a185-44c1-98bb-787ad29a2bb6')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'281fa9a4-60de-4078-8efb-dfb1b9e86de4', N'Odio el contenido que Disney sube. ', CAST(N'2019-08-01T00:00:00.000' AS DateTime), N'2c6e11d8-f8fd-48fb-b804-139318afdbcd')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'bbb3c077-68bd-4ad1-a303-e075a5005436', N'Microsoft es horrible, siempre tira actualizaciones de la nada. ', CAST(N'2019-09-05T00:00:00.000' AS DateTime), N'a6048e96-0a45-4c1e-9a76-152b8979c468')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'88633106-e022-4669-9f34-e43c7c30ee6a', N'Cualquier artículo de Bose me encanta. ', CAST(N'2019-12-31T00:00:00.000' AS DateTime), N'0d38f37d-d807-4dff-884c-670b5b68a726')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'b9951d8d-8c10-4432-bb16-e6efddc5d82e', N'Universal es un parque que me encanta. ', CAST(N'2020-06-08T00:00:00.000' AS DateTime), N'e2f5f38f-3b48-40df-8853-a26c38060241')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'8f2d55a5-a0a8-41e4-81db-e978461df0c1', N'Telegram es una aplicación horrible.', CAST(N'2019-10-09T00:00:00.000' AS DateTime), N'ec9ffc2d-e8a8-471e-9596-4a48d34bc3e6')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'14943929-eb9d-4ac0-99a5-ea019e0b1451', N'A veces la Coca-cola viene muy concentrada y es desagradable.', CAST(N'2020-02-16T00:00:00.000' AS DateTime), N'c0dcb0ab-38ca-4cb1-86b8-9e0628564908')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'cab85266-3487-4538-8bc1-ecb9aaa23b10', N'La Pepsi es una bebida que me encanta. ', CAST(N'2020-01-28T00:00:00.000' AS DateTime), N'cc445d6a-3fc5-4c9f-9161-1f23a2a897b8')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'9313c3f0-25de-4225-9a1b-ed9158c4f17c', N'Nativa es una marca que la verdad no hace bien las cosas y me da un poco de asco. ', CAST(N'2020-03-31T00:00:00.000' AS DateTime), N'a6048e96-0a45-4c1e-9a76-152b8979c468')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'665ad949-e78c-4fe3-aba1-ed9c399b7c0f', N'El modo día de Whatsapp es desagradable.', CAST(N'2019-11-25T00:00:00.000' AS DateTime), N'a6048e96-0a45-4c1e-9a76-152b8979c468')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'74119dbc-d0e5-4b6a-abb7-f0e045d2da7f', N'Microsoft toma decisiones que odio. ', CAST(N'2020-05-09T00:00:00.000' AS DateTime), N'691af1ff-d78c-4fda-8365-ec5b439d5f6b')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'7c16af46-7d6b-4f4a-9513-f27fe3447f40', N'Hyundai hizo un showroom con sus modelos nuevos, el mejor es el XDFTGE, lo amo.', CAST(N'2020-03-10T00:00:00.000' AS DateTime), N'9eb65efa-8221-4d07-8437-edd5f89b1269')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'68d99b72-65c4-4bbd-a314-f2dded9e58e1', N'Hoy tomé Pepsi, que desagradable. ', CAST(N'2019-10-05T00:00:00.000' AS DateTime), N'a614f34c-3ab3-414e-ab25-8e6dd631613a')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'b9860f9a-32b6-42a4-9714-f6e0b137be5d', N'Que asco Whatsapp web. ', CAST(N'2019-12-08T00:00:00.000' AS DateTime), N'cd399baf-a185-44c1-98bb-787ad29a2bb6')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'f8b40aea-2bdd-40c0-9146-f78da71114d5', N'Twitter es una herramienta de comunicación genial. ', CAST(N'2019-10-18T00:00:00.000' AS DateTime), N'691af1ff-d78c-4fda-8365-ec5b439d5f6b')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'4996faaa-0e15-404a-a841-f7b0fae02f5b', N'Adoro viajar a Orlando solo para ir al parque de Universal. ', CAST(N'2020-02-28T00:00:00.000' AS DateTime), N'cd399baf-a185-44c1-98bb-787ad29a2bb6')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'2e301bdb-1451-4d47-8f15-f90224456a6e', N'Es desagradable como Disney lucra. ', CAST(N'2019-09-20T00:00:00.000' AS DateTime), N'a6048e96-0a45-4c1e-9a76-152b8979c468')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'be279549-5f4a-4be4-9a44-f990b42f6db7', N'Como la gente pelea en Twitter es un asco. ', CAST(N'2019-10-23T00:00:00.000' AS DateTime), N'ec9ffc2d-e8a8-471e-9596-4a48d34bc3e6')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'3bb11888-9419-4aeb-9ac5-fa58fe557ae0', N'Que genial son los nuevos auriculares de Bose.', CAST(N'2020-02-20T00:00:00.000' AS DateTime), N'105c762e-2c5d-4631-b08d-5898b1fa1ba2')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'835c8f30-b098-44d4-8cb9-fcaea23b2908', N'Publicar en Twitter por las tardes es de mis actividades preferidas, adoro hacerlo. ', CAST(N'2019-07-09T00:00:00.000' AS DateTime), N'5d1e6c2f-80aa-43b9-88d9-f3a2b74e0f37')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'de1ce246-37d1-4d30-86d3-fd05624e6bbb', N'Amo el servicio de streaming nuevo de Disney.', CAST(N'2020-03-29T00:00:00.000' AS DateTime), N'2c6e11d8-f8fd-48fb-b804-139318afdbcd')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'1afec28c-008b-4d96-9a3b-fd4c83c5292c', N'Me encanta usar el sistema operativo Microsoft.', CAST(N'2019-08-01T00:00:00.000' AS DateTime), N'82782daa-4486-464a-b55d-545e4e17047d')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'51c3d7c1-5596-4968-93c4-fd7d6bf64f38', N'Adoro las publicaciones de Facebook.', CAST(N'2019-07-06T00:00:00.000' AS DateTime), N'cd399baf-a185-44c1-98bb-787ad29a2bb6')
INSERT [dbo].[Publications] ([PublicationId], [Phrase], [Date], [Author_AuthorDtoId]) VALUES (N'5e720baf-d432-4df4-8675-ffbbe131e992', N'Amo mi parlante portatil Bose, lo llevo a todos lados.   ', CAST(N'2020-06-09T00:00:00.000' AS DateTime), N'0d38f37d-d807-4dff-884c-670b5b68a726')
GO
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'7e78fbd3-1069-4396-90cf-0003ed4cb936', N'99125f9c-b570-4c20-9555-4508f5f66951', N'7a4a9f94-4659-4578-ae74-ccc0d9339741', N'8788fffc-59e7-4d46-8c89-700384f3c245')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'b826dd24-df8e-4332-ae4a-0254e42ab746', N'f42b32d5-d799-4eb1-984d-2de8fe05f650', N'66eb1590-30b2-48fb-960e-636977580318', N'6d5b1bd6-7e06-4e0c-a0a4-6ac4a8910b33')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'75afe884-d27a-4adc-86cf-025d049ba656', N'76566d07-866e-4122-a314-e970f5e8098d', N'ae4a271f-e277-4616-9246-1b62e9585f0b', N'8ef0662e-cef7-4660-a6a7-120b3690d52f')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'7c2216d7-491b-48ab-b374-04dcf5f2fc99', N'a047b192-1f44-4a89-9f12-169c23005993', N'88633106-e022-4669-9f34-e43c7c30ee6a', N'507d8f98-54e0-4041-adc8-07cc748e73c6')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'45ff5afb-ca0c-4386-ba19-05052abfcdd2', N'99125f9c-b570-4c20-9555-4508f5f66951', N'92bd292d-1fc2-414e-9407-73c8eaa97856', N'8ef0662e-cef7-4660-a6a7-120b3690d52f')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'9581e8ea-3472-4833-a2d6-0664cc38979d', N'3e2848cd-68eb-42c3-8f1e-b227cc8bf85c', N'0162ea6e-78e6-4ced-a334-166de4631061', N'6d5b1bd6-7e06-4e0c-a0a4-6ac4a8910b33')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'de1141b3-c4bd-42d4-9ec8-0746e84db45c', N'f42b32d5-d799-4eb1-984d-2de8fe05f650', N'a80eae08-e904-4545-9474-81440a216ec0', N'4e6cda4d-b255-4648-aff1-955aabf3bc69')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'b45831e4-df82-4506-b0eb-07baa2ec9a86', N'f42b32d5-d799-4eb1-984d-2de8fe05f650', N'dac559a1-6db8-403b-a912-59c0aa8ec7ff', N'8ef0662e-cef7-4660-a6a7-120b3690d52f')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'05380acc-9f1c-4ca6-8d41-083d573c490d', N'89d6476b-cfe8-4cc8-a29f-4ea5e974cf37', N'b1f71b16-1441-4409-9eda-59945bc6b32d', N'84f90f24-46d4-46f8-bc4f-91c6171e5df8')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'acce12a6-8c62-47f8-a4f4-09d45153066e', N'99125f9c-b570-4c20-9555-4508f5f66951', N'ee5464ff-ab83-4a8e-ab26-dcb93dbe2bb2', N'd7644c31-11bb-4d97-95e5-d467d74a2f62')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'd4cfa151-cdfb-4388-9259-0b351151c5f8', N'1888fdc8-de7e-458d-99a4-947e18934957', N'9bb44658-185e-4574-a220-c05aeaa7044d', N'c1066621-2ff6-4bf1-ac2d-e31d8cde3af8')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'3d42d71f-90a3-451b-92b1-0b3c31ee2faa', N'f42b32d5-d799-4eb1-984d-2de8fe05f650', N'ca590f5f-119b-4f7e-baff-52d6984f4995', N'0265377b-00e4-45a1-ae1c-e91d8dfb4da3')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'2000b034-d07e-412f-b8a5-0da6e39d04c1', N'76566d07-866e-4122-a314-e970f5e8098d', N'f36fd635-9043-49ec-87b6-a3ffb801dcf7', N'8ef0662e-cef7-4660-a6a7-120b3690d52f')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'283a52fd-ced0-4e28-935b-0ed66884e182', N'76566d07-866e-4122-a314-e970f5e8098d', N'002e2ead-f5d7-4964-898c-1cb270e825b1', N'd7644c31-11bb-4d97-95e5-d467d74a2f62')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'8ef96fc1-6de3-4cad-85cd-13c5d14529db', N'26080978-603e-4286-982b-e5201ec69d40', N'4bc3c865-3a36-400c-bd7a-726b7648e138', N'8ef0662e-cef7-4660-a6a7-120b3690d52f')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'1688acf0-71fb-4fff-8fc9-152868105eba', N'26080978-603e-4286-982b-e5201ec69d40', N'aa3210cb-5afe-4b8f-858b-439e27d69939', N'd7644c31-11bb-4d97-95e5-d467d74a2f62')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'05a7ad11-7fdd-4e13-9dc5-15d92f8c1b30', N'26080978-603e-4286-982b-e5201ec69d40', N'f49ad41e-0a6f-49ad-9f3a-4f3743d8f343', N'8788fffc-59e7-4d46-8c89-700384f3c245')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'de68d4ad-e311-4b8b-90d0-16664ecb32e7', N'950cd115-6f87-4a90-ba06-d67fcbe8045d', N'7b66e183-80d3-4985-85e4-72f86f96db60', N'0265377b-00e4-45a1-ae1c-e91d8dfb4da3')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'66a2891c-ac85-4216-bc29-17589b4869be', N'3e2848cd-68eb-42c3-8f1e-b227cc8bf85c', N'c6af9cc0-cf65-41a7-9bfc-aaa5f8e7e74e', N'84f90f24-46d4-46f8-bc4f-91c6171e5df8')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'a03000a8-6a03-46b5-be79-18b2413bb70f', N'89d6476b-cfe8-4cc8-a29f-4ea5e974cf37', N'be48fe0a-23c1-4119-89fe-5f04fb44d58e', N'6d5b1bd6-7e06-4e0c-a0a4-6ac4a8910b33')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'59d34e8a-5781-48ce-a2a6-19e2f1a3f2d7', N'ff698d39-846b-43cb-8308-204c0143bcba', N'6d6c3687-6b8a-44c6-b3b5-dd547aebae76', N'c1066621-2ff6-4bf1-ac2d-e31d8cde3af8')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'd27c79e7-ae09-4a47-8723-1a22d8851717', N'1888fdc8-de7e-458d-99a4-947e18934957', N'0e22e181-a934-4328-b00f-4c92e1da3e8f', N'6d5b1bd6-7e06-4e0c-a0a4-6ac4a8910b33')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'560f9eb7-ca6f-4568-8bdf-1afce210a09f', N'de7435f1-7a77-4648-93db-6d0649c50a75', N'103b339f-939a-40c5-b881-8e6570689849', N'8ef0662e-cef7-4660-a6a7-120b3690d52f')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'79506ff6-75e3-4b30-86f9-1bbf6bb39622', N'26080978-603e-4286-982b-e5201ec69d40', N'af57d6ee-3649-417e-8392-1d55b15a2066', N'84f90f24-46d4-46f8-bc4f-91c6171e5df8')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'3bfc40b5-b9b2-4139-944a-1c90f30988a4', N'de7435f1-7a77-4648-93db-6d0649c50a75', N'46cc5b5c-a365-4171-9456-cf41be95f29c', N'88e3e890-eb57-48ce-9720-d799c752c5bb')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'109be0b9-6217-46cb-8819-1cfd12adb144', N'951710fd-7029-45f3-b873-e805f913b406', N'c0dea14e-ccdb-4bd3-b75c-03f3cec08f3c', N'88e3e890-eb57-48ce-9720-d799c752c5bb')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'566ab480-2735-4711-98b2-1e1b7d852858', N'950cd115-6f87-4a90-ba06-d67fcbe8045d', N'2e70f37c-c808-4389-97ec-6584c0e0a482', N'8ef0662e-cef7-4660-a6a7-120b3690d52f')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'9fb1879c-131c-45f8-b14f-1fa2f773de51', N'f42b32d5-d799-4eb1-984d-2de8fe05f650', N'ab8188c4-071d-48ab-b1a5-4ee331759181', N'84f90f24-46d4-46f8-bc4f-91c6171e5df8')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'654476eb-7c9b-401b-b6de-209b9a1eba57', N'26080978-603e-4286-982b-e5201ec69d40', N'16ebdc39-4441-4b1a-9457-a5b0b9e1f3d6', N'0265377b-00e4-45a1-ae1c-e91d8dfb4da3')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'bb91032c-8459-470a-953f-20fa19ef4f73', N'89d6476b-cfe8-4cc8-a29f-4ea5e974cf37', N'd93763bb-1e56-4783-94ae-88f81dbabb94', N'8788fffc-59e7-4d46-8c89-700384f3c245')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'5fddd650-cfcf-41fc-a4f1-2186ac995d2d', N'a047b192-1f44-4a89-9f12-169c23005993', N'4ef1d560-dfb7-48e4-a1a5-58fcbdc158a5', N'8ef0662e-cef7-4660-a6a7-120b3690d52f')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'8c7fa293-3545-4e6e-87f7-234d9753ce43', N'951710fd-7029-45f3-b873-e805f913b406', N'87509f27-1283-4942-b8c7-4f18d890dbc0', N'6d5b1bd6-7e06-4e0c-a0a4-6ac4a8910b33')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'bb98b635-717c-4625-96c1-2442ee1c02ef', N'de7435f1-7a77-4648-93db-6d0649c50a75', N'cb30fe54-37a5-4a7c-b302-36097ad34c6e', N'8788fffc-59e7-4d46-8c89-700384f3c245')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'119dd815-73f0-4e23-a011-25a88d2c9c50', N'de7435f1-7a77-4648-93db-6d0649c50a75', N'89411a65-459d-46c7-b3c8-6d6ec9021f8a', N'd7644c31-11bb-4d97-95e5-d467d74a2f62')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'e6d1d49a-a4f9-4d13-8349-26050af35f59', N'76566d07-866e-4122-a314-e970f5e8098d', N'b40e5e80-f4c6-47e6-aae2-5b61029fc53d', N'4e6cda4d-b255-4648-aff1-955aabf3bc69')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'52653489-df75-4400-b617-2632b5d065fb', N'1888fdc8-de7e-458d-99a4-947e18934957', N'aee54ef6-f6f2-47a3-a213-6d9dfeb4cdf5', N'c1066621-2ff6-4bf1-ac2d-e31d8cde3af8')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'1d0bd8ea-4eac-4cc2-9ac4-284821440047', N'99125f9c-b570-4c20-9555-4508f5f66951', N'f398115a-81c7-4112-8534-3c5c5e55e5e5', N'507d8f98-54e0-4041-adc8-07cc748e73c6')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'5b06803c-cdb1-4f34-87d3-291acc64a2b0', N'1657978b-41a0-40ee-aaad-60ab3b187424', N'088b5396-2fe0-43dd-9398-7ba218cbfca7', N'4e6cda4d-b255-4648-aff1-955aabf3bc69')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'de4923f0-a5af-4c55-a58e-29230989d7be', N'3e2848cd-68eb-42c3-8f1e-b227cc8bf85c', N'dd23cc44-21c1-43fb-a188-a368c17dc7c6', N'c1066621-2ff6-4bf1-ac2d-e31d8cde3af8')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'ba063579-fff6-4bbb-b20e-29bec8a43711', N'3e2848cd-68eb-42c3-8f1e-b227cc8bf85c', N'd5abe776-a8cb-4627-a5d2-4d253e93d78c', N'6d5b1bd6-7e06-4e0c-a0a4-6ac4a8910b33')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'0a03214d-e79d-48b0-aeaf-2b5e52bb41cd', N'89d6476b-cfe8-4cc8-a29f-4ea5e974cf37', N'3a07d45b-2f63-4b63-9ac8-82801de2ec80', N'd7644c31-11bb-4d97-95e5-d467d74a2f62')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'a0a62639-fdc7-4140-8207-2c9df5d924ae', N'3361d601-eca1-416c-8d6c-ac8779a5985b', N'bd6d05b5-4b55-475f-994a-07c33345320d', N'88e3e890-eb57-48ce-9720-d799c752c5bb')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'cefba53d-0cc0-428d-ac83-2db64bdd7fc3', N'3361d601-eca1-416c-8d6c-ac8779a5985b', N'fe78367c-42fd-4c3d-bfd6-99d93a90f24c', N'0265377b-00e4-45a1-ae1c-e91d8dfb4da3')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'5c49df26-e89c-46d6-b315-2e890358a6ad', N'99125f9c-b570-4c20-9555-4508f5f66951', N'4598ee52-91c0-43ff-98ff-a8ca9ccbdaea', N'4e6cda4d-b255-4648-aff1-955aabf3bc69')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'a7523542-8f1d-4428-9096-2fe919e2c937', N'de7435f1-7a77-4648-93db-6d0649c50a75', N'74119dbc-d0e5-4b6a-abb7-f0e045d2da7f', N'd7644c31-11bb-4d97-95e5-d467d74a2f62')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'0a423bf8-95a0-4ad5-8280-30a41500ade9', N'3361d601-eca1-416c-8d6c-ac8779a5985b', N'6457ff81-8d3e-4d65-a36a-873ec88cf3f2', N'88e3e890-eb57-48ce-9720-d799c752c5bb')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'12d61e6b-af65-4f89-9a1d-3210251379b9', N'ff698d39-846b-43cb-8308-204c0143bcba', N'281fa9a4-60de-4078-8efb-dfb1b9e86de4', N'd7644c31-11bb-4d97-95e5-d467d74a2f62')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'f11a2616-5e98-4b42-82ac-3422f7bd87ef', N'de7435f1-7a77-4648-93db-6d0649c50a75', N'efc78635-c852-415d-8779-b48538bbc3a3', N'8ef0662e-cef7-4660-a6a7-120b3690d52f')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'5ee9af34-1cdf-4355-8f49-34dbe721354c', N'76566d07-866e-4122-a314-e970f5e8098d', N'665ad949-e78c-4fe3-aba1-ed9c399b7c0f', N'8ef0662e-cef7-4660-a6a7-120b3690d52f')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'e092be5a-c0f0-48f3-bd8c-3575cd821079', N'f42b32d5-d799-4eb1-984d-2de8fe05f650', N'1b5f4412-88a1-48dc-9a71-3d063ac01915', N'8788fffc-59e7-4d46-8c89-700384f3c245')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'96028bdd-c0c9-4c0d-816d-374c79516d7f', N'89d6476b-cfe8-4cc8-a29f-4ea5e974cf37', N'f71fc219-3f6e-4d63-8df2-bd17e176f9cb', N'88e3e890-eb57-48ce-9720-d799c752c5bb')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'451932e7-b5c9-4662-b630-3786412375ac', N'951710fd-7029-45f3-b873-e805f913b406', N'e5d283cc-0f6b-4f5d-9c39-70a6839876ef', N'8788fffc-59e7-4d46-8c89-700384f3c245')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'65ad18ed-be93-4e70-b08c-398848e222bc', N'76566d07-866e-4122-a314-e970f5e8098d', N'3ac21a0c-8643-4023-b538-2eba8a88145a', N'507d8f98-54e0-4041-adc8-07cc748e73c6')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'298c330b-5bda-4d4f-8353-39bcf55c513e', N'f42b32d5-d799-4eb1-984d-2de8fe05f650', N'8b20fc2e-fa99-404c-806b-4654dc40f8d6', N'4e6cda4d-b255-4648-aff1-955aabf3bc69')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'd35b2c66-9fe2-4398-9a9b-3b22e4d0bd86', N'a047b192-1f44-4a89-9f12-169c23005993', N'0d6d3012-7956-4fa1-a221-5cb5d0836453', N'c1066621-2ff6-4bf1-ac2d-e31d8cde3af8')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'a4c7277f-6f0d-46a4-b3c9-3b637f38c642', N'becec057-47d8-4d8f-87ab-daa2d336f9d9', N'0bbb70fc-6c06-47c0-a08c-97ab04b8c39a', N'8788fffc-59e7-4d46-8c89-700384f3c245')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'946d14ca-57a7-43ab-8f10-40093994d0e1', N'becec057-47d8-4d8f-87ab-daa2d336f9d9', N'bd2428a7-1ba3-4df8-ad03-a061e4c53bf8', N'd7644c31-11bb-4d97-95e5-d467d74a2f62')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'd5773421-b500-47c5-a299-41115c798c4c', N'3361d601-eca1-416c-8d6c-ac8779a5985b', N'3bdd5a04-bad1-4640-b07d-010a85b197aa', N'8ef0662e-cef7-4660-a6a7-120b3690d52f')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'b1155884-a01b-472e-9e8f-4151f7923317', N'1888fdc8-de7e-458d-99a4-947e18934957', N'3c89267a-634c-4e0f-8cdb-4c280570dbfc', N'c1066621-2ff6-4bf1-ac2d-e31d8cde3af8')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'b761cd84-17cd-40d2-8d93-430f98d8287a', N'becec057-47d8-4d8f-87ab-daa2d336f9d9', N'8f192650-4032-4469-abd0-59c2a2d44b3a', N'507d8f98-54e0-4041-adc8-07cc748e73c6')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'f1fa0a80-9986-4e78-bdbf-4434eb6f635e', N'3e2848cd-68eb-42c3-8f1e-b227cc8bf85c', N'8644f20b-e042-4adf-ae2e-ce98c3d7ef6f', N'507d8f98-54e0-4041-adc8-07cc748e73c6')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'389519c5-18ff-4e85-9cdc-47f20b23ed5b', N'3361d601-eca1-416c-8d6c-ac8779a5985b', N'9313c3f0-25de-4225-9a1b-ed9158c4f17c', N'c1066621-2ff6-4bf1-ac2d-e31d8cde3af8')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'fc8b79e5-7c3f-4f6f-9b7d-491070a1f40a', N'3e2848cd-68eb-42c3-8f1e-b227cc8bf85c', N'bf6c9a92-c3ce-4ffb-8e16-a8852c8524a3', N'6d5b1bd6-7e06-4e0c-a0a4-6ac4a8910b33')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'60a06877-196b-4adb-a0de-4a592b2471ad', N'89d6476b-cfe8-4cc8-a29f-4ea5e974cf37', N'e281827a-41eb-48db-bb60-4e1f242d56fb', N'8ef0662e-cef7-4660-a6a7-120b3690d52f')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'72763696-c4d3-41ea-a662-4a924d591468', N'950cd115-6f87-4a90-ba06-d67fcbe8045d', N'a8ad1a29-ae43-4720-99f6-438efc78e1aa', N'8788fffc-59e7-4d46-8c89-700384f3c245')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'a387883d-6bfe-47ec-91c1-4be234d43e99', N'3361d601-eca1-416c-8d6c-ac8779a5985b', N'46e21c68-5f69-4ab6-86a8-2da203fa761c', N'84f90f24-46d4-46f8-bc4f-91c6171e5df8')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'ce18cdcc-4702-4640-9ab5-4c1459138b9b', N'99125f9c-b570-4c20-9555-4508f5f66951', N'87ac593d-5dcb-4fc6-8623-5582a50bdce5', N'84f90f24-46d4-46f8-bc4f-91c6171e5df8')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'1208d36b-7e06-439f-b520-4d75fde16011', N'951710fd-7029-45f3-b873-e805f913b406', N'e85f9f9c-420d-4c6d-b57a-8af9cb46bd2b', N'd7644c31-11bb-4d97-95e5-d467d74a2f62')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'cf1a55d7-619a-4c94-b882-4d9c0908725c', N'89d6476b-cfe8-4cc8-a29f-4ea5e974cf37', N'cab85266-3487-4538-8bc1-ecb9aaa23b10', N'507d8f98-54e0-4041-adc8-07cc748e73c6')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'8b22ec6c-0d30-445a-af5f-4e0e8e104c86', N'950cd115-6f87-4a90-ba06-d67fcbe8045d', N'35e7b469-51e1-4815-ac9e-035dd2e44489', N'84f90f24-46d4-46f8-bc4f-91c6171e5df8')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'8213a0e0-957c-41ab-beee-50c6e6ca74f9', N'3e2848cd-68eb-42c3-8f1e-b227cc8bf85c', N'478fc7fc-c311-47ef-a866-a344db6919af', N'0265377b-00e4-45a1-ae1c-e91d8dfb4da3')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'8b5d5e2c-244d-47fc-bbce-53729e789b74', N'ff698d39-846b-43cb-8308-204c0143bcba', N'd689e952-b456-4f08-83d2-a26499786fa2', N'c1066621-2ff6-4bf1-ac2d-e31d8cde3af8')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'af188b3c-adb9-422a-9e14-5aef1142f743', N'951710fd-7029-45f3-b873-e805f913b406', N'ecadb2ee-7af0-4a51-8400-93a05c235fe5', N'507d8f98-54e0-4041-adc8-07cc748e73c6')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'a328aa9b-f72e-4a40-9ccf-5e4a542d0b8e', N'3361d601-eca1-416c-8d6c-ac8779a5985b', N'2684a738-c9d6-4ab6-ad3f-daf6e58b26e7', N'8788fffc-59e7-4d46-8c89-700384f3c245')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'cafd2055-2058-487f-8d9a-5e4faef82084', N'a047b192-1f44-4a89-9f12-169c23005993', N'411996cd-cb45-425d-b854-5e09118ed87b', N'84f90f24-46d4-46f8-bc4f-91c6171e5df8')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'7961562a-06bd-45b2-8baa-5fc2868033d7', N'a047b192-1f44-4a89-9f12-169c23005993', N'2e7e3c49-8d09-4408-8285-008cc06ea980', N'6d5b1bd6-7e06-4e0c-a0a4-6ac4a8910b33')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'1ba2803b-4796-4849-a765-6087a2a928c6', N'3e2848cd-68eb-42c3-8f1e-b227cc8bf85c', N'11fce780-95b7-4f14-9859-1a4bb1727067', N'd7644c31-11bb-4d97-95e5-d467d74a2f62')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'd9d0e5cb-f5ae-4eca-8f62-60e1bfccf417', N'ff698d39-846b-43cb-8308-204c0143bcba', N'f14c268a-2c19-4d5c-9360-c2be0ae956b7', N'8ef0662e-cef7-4660-a6a7-120b3690d52f')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'4bcabb93-ae0d-4ad8-91ae-6299c174708b', N'becec057-47d8-4d8f-87ab-daa2d336f9d9', N'b9951d8d-8c10-4432-bb16-e6efddc5d82e', N'507d8f98-54e0-4041-adc8-07cc748e73c6')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'5f9c9719-2302-487b-b14f-62cbfe1bd2f5', N'becec057-47d8-4d8f-87ab-daa2d336f9d9', N'ec817084-b836-4dab-bc75-4afbb9bb80a7', N'0265377b-00e4-45a1-ae1c-e91d8dfb4da3')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'5c9b1ab2-290c-467a-82c7-62e08074d09c', N'1657978b-41a0-40ee-aaad-60ab3b187424', N'8f2d55a5-a0a8-41e4-81db-e978461df0c1', N'6d5b1bd6-7e06-4e0c-a0a4-6ac4a8910b33')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'5805d8c3-0bc3-4df6-bcde-63c4fc6f85a2', N'99125f9c-b570-4c20-9555-4508f5f66951', N'ce0e1253-52d4-414c-8f68-401d16720d2e', N'6d5b1bd6-7e06-4e0c-a0a4-6ac4a8910b33')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'06747a32-71d5-4741-82e6-6476af02d2b5', N'f42b32d5-d799-4eb1-984d-2de8fe05f650', N'c9598b84-f07a-4618-976c-36135ce76a21', N'88e3e890-eb57-48ce-9720-d799c752c5bb')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'592b4821-10be-4776-82d3-64efa4a60e3b', N'89d6476b-cfe8-4cc8-a29f-4ea5e974cf37', N'68d99b72-65c4-4bbd-a314-f2dded9e58e1', N'8ef0662e-cef7-4660-a6a7-120b3690d52f')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'7ad5fbee-9175-427d-915b-65c175e10e1c', N'a047b192-1f44-4a89-9f12-169c23005993', N'382614d4-f5ff-4d13-985a-647b615e3256', N'84f90f24-46d4-46f8-bc4f-91c6171e5df8')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'04051a98-427b-42c7-a045-6620818454e5', N'de7435f1-7a77-4648-93db-6d0649c50a75', N'24537df2-07ea-45d1-97af-bc5119e016a3', N'8ef0662e-cef7-4660-a6a7-120b3690d52f')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'797e6f8a-0a02-49f1-b269-668e96d9802c', N'950cd115-6f87-4a90-ba06-d67fcbe8045d', N'87ebd0c7-99ab-40cd-8be7-8d18db96c8b9', N'0265377b-00e4-45a1-ae1c-e91d8dfb4da3')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'f02b0e94-67cd-4fe1-86a5-676c9da8b727', N'76566d07-866e-4122-a314-e970f5e8098d', N'b9860f9a-32b6-42a4-9714-f6e0b137be5d', N'c1066621-2ff6-4bf1-ac2d-e31d8cde3af8')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'37a5562c-93b0-4ac4-bdb6-67ee133fd7e5', N'a047b192-1f44-4a89-9f12-169c23005993', N'aa7c6efd-46de-403e-8a2a-d0926510f5df', N'8788fffc-59e7-4d46-8c89-700384f3c245')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'12dad3f1-f4d1-4953-94fc-68ea81fbdf42', N'de7435f1-7a77-4648-93db-6d0649c50a75', N'cf505ab9-c096-4537-aa9b-13d9ec0e86fa', N'4e6cda4d-b255-4648-aff1-955aabf3bc69')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'f612e903-5d83-44e2-95fb-6b967dfc9a21', N'1657978b-41a0-40ee-aaad-60ab3b187424', N'75c861e5-c705-4415-9d92-b005e7db3338', N'0265377b-00e4-45a1-ae1c-e91d8dfb4da3')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'b0e6b24d-468d-4131-af79-6cb842751a6d', N'de7435f1-7a77-4648-93db-6d0649c50a75', N'ce375c06-c3a2-4b55-83b7-0485ee29f19b', N'd7644c31-11bb-4d97-95e5-d467d74a2f62')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'950bb567-fdb9-45c3-9610-74a0ac78e0ef', N'951710fd-7029-45f3-b873-e805f913b406', N'd91364d6-8116-4949-ae33-43eed01b318f', N'0265377b-00e4-45a1-ae1c-e91d8dfb4da3')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'ceb0b503-464c-43a6-9e2e-76a46385c452', N'de7435f1-7a77-4648-93db-6d0649c50a75', N'bbb3c077-68bd-4ad1-a303-e075a5005436', N'6d5b1bd6-7e06-4e0c-a0a4-6ac4a8910b33')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'47652125-6187-41ed-a809-770faf1d3f2c', N'a047b192-1f44-4a89-9f12-169c23005993', N'5e720baf-d432-4df4-8675-ffbbe131e992', N'0265377b-00e4-45a1-ae1c-e91d8dfb4da3')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'd846fff6-3709-4591-9ec5-794cfee7b7e0', N'26080978-603e-4286-982b-e5201ec69d40', N'cd77808f-abba-47c8-abe0-110d7fec9ce8', N'c1066621-2ff6-4bf1-ac2d-e31d8cde3af8')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'46969b88-4db9-454d-8aba-799e7a2a1aad', N'3e2848cd-68eb-42c3-8f1e-b227cc8bf85c', N'd5953dad-d1fb-4f0f-9bb2-359827136090', N'8788fffc-59e7-4d46-8c89-700384f3c245')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'e923b6c7-7ee3-4e8a-9435-79b9b5174973', N'26080978-603e-4286-982b-e5201ec69d40', N'4994ac10-21dd-48ef-b020-679606cb3673', N'507d8f98-54e0-4041-adc8-07cc748e73c6')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'5af999a5-b177-4e6c-ac32-7a6f96ed1529', N'becec057-47d8-4d8f-87ab-daa2d336f9d9', N'51d997c9-180d-4129-94cb-1acebf34a292', N'507d8f98-54e0-4041-adc8-07cc748e73c6')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'90a4d67f-50b2-485f-8c37-7cc86bc221b7', N'becec057-47d8-4d8f-87ab-daa2d336f9d9', N'dd212526-4150-4da1-89ea-aa9353786953', N'6d5b1bd6-7e06-4e0c-a0a4-6ac4a8910b33')
GO
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'abe0ae5e-16b9-4825-8d37-7cd54e6ac71a', N'a047b192-1f44-4a89-9f12-169c23005993', N'8402a461-f66b-48e4-871e-598606e3abe9', N'84f90f24-46d4-46f8-bc4f-91c6171e5df8')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'36c7cd16-e160-4e39-96af-7d49152dbb74', N'ff698d39-846b-43cb-8308-204c0143bcba', N'3ee7ebe7-a6ed-44a1-bd73-aa1d6f3e95f0', N'0265377b-00e4-45a1-ae1c-e91d8dfb4da3')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'6dfea68f-3f34-4c86-be34-7e8f41afcd98', N'de7435f1-7a77-4648-93db-6d0649c50a75', N'913365a4-f169-431a-8621-c4c58383c96b', N'6d5b1bd6-7e06-4e0c-a0a4-6ac4a8910b33')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'98ace575-868a-43e6-91e9-7e9224b0bd22', N'26080978-603e-4286-982b-e5201ec69d40', N'3f7f26b8-0fa2-4dd0-a770-8dcca5ae6118', N'8788fffc-59e7-4d46-8c89-700384f3c245')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'3ed54ac7-2eba-436e-8b7a-7f2de28d564a', N'f42b32d5-d799-4eb1-984d-2de8fe05f650', N'4a41c793-ce84-4040-870b-d4feb1480ecf', N'84f90f24-46d4-46f8-bc4f-91c6171e5df8')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'def60419-9c6f-442a-ba66-7f2e5b47c0a8', N'950cd115-6f87-4a90-ba06-d67fcbe8045d', N'a1578497-fbf1-4303-af78-16c1cfb95e6b', N'507d8f98-54e0-4041-adc8-07cc748e73c6')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'8087d71a-2ca7-4549-b461-7f52cd934452', N'1657978b-41a0-40ee-aaad-60ab3b187424', N'7e3fbb67-8d7b-492e-af91-619fc2165070', N'88e3e890-eb57-48ce-9720-d799c752c5bb')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'7f4120e5-4409-42bc-84bf-7f778313b17d', N'ff698d39-846b-43cb-8308-204c0143bcba', N'a5b38a55-83b5-425d-a24f-06763d1c13e4', N'6d5b1bd6-7e06-4e0c-a0a4-6ac4a8910b33')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'87a452ac-b45e-4c15-a92a-7fc65458580c', N'de7435f1-7a77-4648-93db-6d0649c50a75', N'55572646-e9bf-4041-8b8e-253e0d5eeb4a', N'88e3e890-eb57-48ce-9720-d799c752c5bb')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'f1b483ab-c63a-44a1-81d7-84578a668789', N'26080978-603e-4286-982b-e5201ec69d40', N'14943929-eb9d-4ac0-99a5-ea019e0b1451', N'8ef0662e-cef7-4660-a6a7-120b3690d52f')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'db7bff8c-457a-4528-b39f-855cd057b1fc', N'26080978-603e-4286-982b-e5201ec69d40', N'66e71428-3a14-4349-932a-852b8ca6e6e5', N'4e6cda4d-b255-4648-aff1-955aabf3bc69')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'0a4dbf5b-b511-4f8c-88a0-869a2ffa541e', N'1888fdc8-de7e-458d-99a4-947e18934957', N'a119490d-1859-4783-93b0-80f9779d926b', N'0265377b-00e4-45a1-ae1c-e91d8dfb4da3')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'7c7ce3b4-fb10-41b1-b28b-87e58143df8a', N'f42b32d5-d799-4eb1-984d-2de8fe05f650', N'dcf2fa6e-dfb6-4a56-be72-dbc58ad8b1e2', N'84f90f24-46d4-46f8-bc4f-91c6171e5df8')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'80567290-3c57-46ad-8a70-8b498cfefeff', N'1888fdc8-de7e-458d-99a4-947e18934957', N'a0462972-9340-404a-b799-0955c3e74aae', N'0265377b-00e4-45a1-ae1c-e91d8dfb4da3')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'8a81a1df-ba25-4097-ae7a-8b697a7fc5db', N'c77213bd-ab43-416b-a37a-9a08b81ec6af', N'0dd15183-4467-4b2f-a078-081d14f84e14', N'd7644c31-11bb-4d97-95e5-d467d74a2f62')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'e1094045-6af7-4682-bddf-8baddb9688f6', N'1888fdc8-de7e-458d-99a4-947e18934957', N'9638949e-8405-4299-858c-7144b13ff3c2', N'6d5b1bd6-7e06-4e0c-a0a4-6ac4a8910b33')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'642da8d2-1e84-4c18-b54d-8e87190f6b3f', N'de7435f1-7a77-4648-93db-6d0649c50a75', N'422b4cee-efef-419a-a1de-2d1b67693bc6', N'8788fffc-59e7-4d46-8c89-700384f3c245')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'7c059db8-89a1-4ba9-8516-901697a8970c', N'ff698d39-846b-43cb-8308-204c0143bcba', N'ed88f7bf-6f03-4878-a47d-29672bac0d1b', N'84f90f24-46d4-46f8-bc4f-91c6171e5df8')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'8cd8d4c2-abbd-4f86-b8cf-95122ab522c2', N'3361d601-eca1-416c-8d6c-ac8779a5985b', N'4ddab4a9-3b1a-47d4-9c6f-39471038c78e', N'6d5b1bd6-7e06-4e0c-a0a4-6ac4a8910b33')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'1b720eab-ae2a-4f90-af36-96f866f3318a', N'26080978-603e-4286-982b-e5201ec69d40', N'5f388807-1f02-41b4-94e4-9b5a9bb9ef0b', N'84f90f24-46d4-46f8-bc4f-91c6171e5df8')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'5972da3a-3549-4a93-850d-970977948c57', N'951710fd-7029-45f3-b873-e805f913b406', N'070c9c71-b78e-4f93-a5a5-644f436699c8', N'8788fffc-59e7-4d46-8c89-700384f3c245')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'612dc1e0-2447-4b52-8e1b-9868c9124a39', N'1657978b-41a0-40ee-aaad-60ab3b187424', N'9455f947-00c9-4166-a515-63f846c0751e', N'0265377b-00e4-45a1-ae1c-e91d8dfb4da3')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'3525b5dd-a0a3-49a0-b143-9921346dd2fb', N'89d6476b-cfe8-4cc8-a29f-4ea5e974cf37', N'1450b92d-ea6c-4a3b-852f-3ddd2aa54d18', N'8ef0662e-cef7-4660-a6a7-120b3690d52f')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'ad40f8c8-47de-433a-95b9-995c2185f7a6', N'f42b32d5-d799-4eb1-984d-2de8fe05f650', N'bb189161-21bf-4bd4-b411-70b4b88f5fea', N'8ef0662e-cef7-4660-a6a7-120b3690d52f')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'4dba16fa-bd61-4d6e-a475-99a9c0beecaf', N'76566d07-866e-4122-a314-e970f5e8098d', N'e4b15a20-f0fb-4e91-9631-7bf584fe8d4a', N'8788fffc-59e7-4d46-8c89-700384f3c245')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'18a77a61-917b-4326-b3d5-9f0cf3998fbf', N'3361d601-eca1-416c-8d6c-ac8779a5985b', N'11ef6690-b689-4575-ad8f-c923edd6f94d', N'c1066621-2ff6-4bf1-ac2d-e31d8cde3af8')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'cb4ae5c0-d930-4365-99da-9f6ee77f7a6b', N'becec057-47d8-4d8f-87ab-daa2d336f9d9', N'af9724ed-70c2-4099-9212-49e0015a7cef', N'6d5b1bd6-7e06-4e0c-a0a4-6ac4a8910b33')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'83d3ff41-e2bd-4924-81f7-a112a6d16378', N'950cd115-6f87-4a90-ba06-d67fcbe8045d', N'615da002-f9ee-4f72-a5f5-4704c55c7e24', N'84f90f24-46d4-46f8-bc4f-91c6171e5df8')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'668e10f1-080e-462e-9363-a27084f71c92', N'951710fd-7029-45f3-b873-e805f913b406', N'18cdd690-4977-4051-b2e3-58be2e807cc1', N'84f90f24-46d4-46f8-bc4f-91c6171e5df8')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'a848caef-1f80-40e0-89a9-a3de7f3fa2e2', N'99125f9c-b570-4c20-9555-4508f5f66951', N'835c8f30-b098-44d4-8cb9-fcaea23b2908', N'84f90f24-46d4-46f8-bc4f-91c6171e5df8')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'115a1b6c-4a28-42ac-ba05-a4817b7cae44', N'76566d07-866e-4122-a314-e970f5e8098d', N'c42f72fb-03ec-4148-94ee-849c18ba71b0', N'507d8f98-54e0-4041-adc8-07cc748e73c6')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'e0332e62-d966-457e-9bd3-a4a12113f5ad', N'950cd115-6f87-4a90-ba06-d67fcbe8045d', N'26513aa0-588c-48dd-889b-556b2a88b594', N'8ef0662e-cef7-4660-a6a7-120b3690d52f')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'63d36a9d-c98d-42e6-a7fc-a522ce2ba030', N'26080978-603e-4286-982b-e5201ec69d40', N'7b828afb-62a9-4821-b3f1-634abbf2c8e3', N'8788fffc-59e7-4d46-8c89-700384f3c245')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'ac18375b-d703-4bbb-95c0-a9a950377d6c', N'3e2848cd-68eb-42c3-8f1e-b227cc8bf85c', N'1c07b5f0-7137-4c82-9542-2d9064549821', N'88e3e890-eb57-48ce-9720-d799c752c5bb')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'54405248-6621-445f-80fb-ab8e3a714f80', N'ff698d39-846b-43cb-8308-204c0143bcba', N'de1ce246-37d1-4d30-86d3-fd05624e6bbb', N'0265377b-00e4-45a1-ae1c-e91d8dfb4da3')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'4b406780-d640-4830-ae7e-ad41b65ca79e', N'951710fd-7029-45f3-b873-e805f913b406', N'5cd0569b-0ddb-459a-8405-0077ec8a7b23', N'8788fffc-59e7-4d46-8c89-700384f3c245')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'0b69b96d-a5b5-4fb2-9cb0-af5c7986c51c', N'951710fd-7029-45f3-b873-e805f913b406', N'11578cb1-cd76-482f-aee4-81bb0fc69551', N'84f90f24-46d4-46f8-bc4f-91c6171e5df8')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'23fb1cab-634a-4d91-bf23-b119c66ea0b2', N'76566d07-866e-4122-a314-e970f5e8098d', N'218d236a-35da-479e-8886-3302bd48d387', N'4e6cda4d-b255-4648-aff1-955aabf3bc69')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'74c1d08d-f437-4fdf-81c1-b27b43def7c6', N'3361d601-eca1-416c-8d6c-ac8779a5985b', N'4b197191-6b1a-4403-b558-abca637bad8c', N'8ef0662e-cef7-4660-a6a7-120b3690d52f')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'23bcc2ac-311c-4019-9b39-b3ddfaef9445', N'3361d601-eca1-416c-8d6c-ac8779a5985b', N'220ced16-2de9-4e23-aae3-09725e53cd12', N'd7644c31-11bb-4d97-95e5-d467d74a2f62')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'e6a5429a-1f6d-4a2e-9cfb-b456a2eff9aa', N'89d6476b-cfe8-4cc8-a29f-4ea5e974cf37', N'6dfa04e7-0e6c-49ef-b85e-b3dff10b87ad', N'6d5b1bd6-7e06-4e0c-a0a4-6ac4a8910b33')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'12645524-5843-4017-bf67-b709c02f692d', N'becec057-47d8-4d8f-87ab-daa2d336f9d9', N'4996faaa-0e15-404a-a841-f7b0fae02f5b', N'84f90f24-46d4-46f8-bc4f-91c6171e5df8')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'51967b61-c60f-4c81-a8df-b77b6d385428', N'3e2848cd-68eb-42c3-8f1e-b227cc8bf85c', N'1b9205a1-05d3-4454-a815-1a6643e66eda', N'8788fffc-59e7-4d46-8c89-700384f3c245')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'09ad2161-1a10-4a43-8629-b8d52de1935f', N'3361d601-eca1-416c-8d6c-ac8779a5985b', N'eccd7890-57ee-48c2-9618-8e7af7abaeff', N'88e3e890-eb57-48ce-9720-d799c752c5bb')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'5cb8953f-2bbc-447d-818e-bb96c3e05b2b', N'ff698d39-846b-43cb-8308-204c0143bcba', N'ac33fc6d-5b95-4e4a-b589-7b823b2e7e70', N'4e6cda4d-b255-4648-aff1-955aabf3bc69')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'0629ad8f-b80b-4e7c-bbbd-bc3e7bf25748', N'f42b32d5-d799-4eb1-984d-2de8fe05f650', N'8124a95a-1c5f-4df8-9ac2-9a1f0d0d641f', N'4e6cda4d-b255-4648-aff1-955aabf3bc69')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'12723ae3-c6a8-4a5d-a486-be2818015225', N'99125f9c-b570-4c20-9555-4508f5f66951', N'a2bdd3ed-56da-48ae-b4fd-3af5b35c155d', N'8788fffc-59e7-4d46-8c89-700384f3c245')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'bfff44b6-a319-4fea-8c66-beb0082ea387', N'becec057-47d8-4d8f-87ab-daa2d336f9d9', N'a8c1a216-b599-43ea-911f-0073c427fad2', N'507d8f98-54e0-4041-adc8-07cc748e73c6')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'78c88908-4880-49c7-a642-c01ca27ac231', N'26080978-603e-4286-982b-e5201ec69d40', N'a9f23471-3787-407d-bee3-6c5626230579', N'd7644c31-11bb-4d97-95e5-d467d74a2f62')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'706cf026-23fa-4369-80ca-c07cca2d8c23', N'99125f9c-b570-4c20-9555-4508f5f66951', N'be279549-5f4a-4be4-9a44-f990b42f6db7', N'c1066621-2ff6-4bf1-ac2d-e31d8cde3af8')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'4304975f-90e6-4008-958f-c602e6254c67', N'3e2848cd-68eb-42c3-8f1e-b227cc8bf85c', N'76dc220c-f126-46cc-a8f7-005ce8c50164', N'4e6cda4d-b255-4648-aff1-955aabf3bc69')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'e676082e-1615-4559-bf50-c616aa6d72c1', N'becec057-47d8-4d8f-87ab-daa2d336f9d9', N'b312774a-3f49-4ca1-aaa7-16c37c9a8fde', N'84f90f24-46d4-46f8-bc4f-91c6171e5df8')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'2b14b40f-2984-467d-8e26-c7bbf3552cbe', N'26080978-603e-4286-982b-e5201ec69d40', N'1e995932-e4af-4076-843f-6f4c1d64acbe', N'8788fffc-59e7-4d46-8c89-700384f3c245')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'6e804af5-fb4b-4cea-8115-c8497e245e18', N'ff698d39-846b-43cb-8308-204c0143bcba', N'2e301bdb-1451-4d47-8f15-f90224456a6e', N'8ef0662e-cef7-4660-a6a7-120b3690d52f')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'41fe135e-2aea-428b-908d-c8acdcb67ff1', N'1657978b-41a0-40ee-aaad-60ab3b187424', N'f44433db-1bbf-487a-80fb-cad733a25d30', N'd7644c31-11bb-4d97-95e5-d467d74a2f62')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'881120cf-333d-418f-ac2a-c98d36ab87f0', N'ff698d39-846b-43cb-8308-204c0143bcba', N'aab0ac3b-71da-4abc-ad90-2d52836db74c', N'88e3e890-eb57-48ce-9720-d799c752c5bb')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'bdd87520-950a-4b24-8ad2-c993062a9855', N'becec057-47d8-4d8f-87ab-daa2d336f9d9', N'4f519564-9344-4cc7-bb57-38f928bc38ae', N'8ef0662e-cef7-4660-a6a7-120b3690d52f')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'6d32b02b-c3be-4e96-ad7a-ca0d1958faa0', N'3e2848cd-68eb-42c3-8f1e-b227cc8bf85c', N'6777f351-7d48-4fa4-9f9f-85b9ce8ac2d3', N'507d8f98-54e0-4041-adc8-07cc748e73c6')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'016a9429-d9b8-4630-866a-cd5d5e5864e4', N'26080978-603e-4286-982b-e5201ec69d40', N'8edb1026-390e-4552-8bea-c7f81ef957b6', N'84f90f24-46d4-46f8-bc4f-91c6171e5df8')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'da05d4b8-4d38-4990-90cf-d04e278e0ab6', N'1657978b-41a0-40ee-aaad-60ab3b187424', N'b56ab36b-a00a-4495-af56-086cac7fec41', N'0265377b-00e4-45a1-ae1c-e91d8dfb4da3')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'eee8e2c5-4c2f-4934-a753-d43412c6deec', N'becec057-47d8-4d8f-87ab-daa2d336f9d9', N'c20c9fe3-868c-4a3c-b685-a69f229a2829', N'88e3e890-eb57-48ce-9720-d799c752c5bb')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'09f3f78a-45bb-43cd-a36c-d45ec575acca', N'f42b32d5-d799-4eb1-984d-2de8fe05f650', N'51c3d7c1-5596-4968-93c4-fd7d6bf64f38', N'84f90f24-46d4-46f8-bc4f-91c6171e5df8')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'd39aaca4-517a-4862-8087-d5cf930180d1', N'89d6476b-cfe8-4cc8-a29f-4ea5e974cf37', N'b6ff0fba-eba4-469d-8924-1f10a0179256', N'0265377b-00e4-45a1-ae1c-e91d8dfb4da3')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'5f2c87ed-de77-41a9-b7b6-d6139c8e6054', N'a047b192-1f44-4a89-9f12-169c23005993', N'965fdb72-9c49-4e61-a037-44eb5b5aea4c', N'6d5b1bd6-7e06-4e0c-a0a4-6ac4a8910b33')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'd2a5bbb9-566e-45a9-aa4d-d61781e8b02e', N'950cd115-6f87-4a90-ba06-d67fcbe8045d', N'b547ebc1-d466-45f2-9794-2a62fc23bf41', N'8ef0662e-cef7-4660-a6a7-120b3690d52f')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'e386a73e-a4bf-4417-8605-d7f936d51add', N'76566d07-866e-4122-a314-e970f5e8098d', N'013122b5-d11a-4282-bb95-d21a7450edab', N'c1066621-2ff6-4bf1-ac2d-e31d8cde3af8')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'f8fca67c-76b8-42b6-bbca-d8f863d0f83b', N'99125f9c-b570-4c20-9555-4508f5f66951', N'f8b40aea-2bdd-40c0-9146-f78da71114d5', N'4e6cda4d-b255-4648-aff1-955aabf3bc69')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'7c44ec82-a345-4b8e-ac77-d90c45d82a33', N'becec057-47d8-4d8f-87ab-daa2d336f9d9', N'cece46ad-76d3-461e-a93b-490cf1bf2041', N'84f90f24-46d4-46f8-bc4f-91c6171e5df8')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'07f0a9b4-c3cf-4954-84d9-d94aa8c6e971', N'ff698d39-846b-43cb-8308-204c0143bcba', N'11381277-6d5f-4101-8eb2-be0070d81a5d', N'88e3e890-eb57-48ce-9720-d799c752c5bb')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'e35dca89-514a-44af-8090-dad9a16ef22f', N'de7435f1-7a77-4648-93db-6d0649c50a75', N'fbde47b2-c5a3-455c-bf35-ac38e812bf76', N'8788fffc-59e7-4d46-8c89-700384f3c245')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'95a55858-b5d4-4150-a009-db6b4cf3105f', N'76566d07-866e-4122-a314-e970f5e8098d', N'0bb7c25b-f9c7-4690-8cb7-a813d82246c2', N'507d8f98-54e0-4041-adc8-07cc748e73c6')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'7028310d-8dd5-4b58-a5e3-db9bf8ac9a8e', N'becec057-47d8-4d8f-87ab-daa2d336f9d9', N'5dd57286-86aa-49eb-abf9-25ac2b95a008', N'8788fffc-59e7-4d46-8c89-700384f3c245')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'0df177af-041c-4ff5-9e57-dc7acd97bfa8', N'99125f9c-b570-4c20-9555-4508f5f66951', N'22f837a6-0a16-4241-99a2-455c3dad596d', N'507d8f98-54e0-4041-adc8-07cc748e73c6')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'8e376dbc-a4c4-4c4a-b038-e0a20277e65a', N'a047b192-1f44-4a89-9f12-169c23005993', N'3bb11888-9419-4aeb-9ac5-fa58fe557ae0', N'4e6cda4d-b255-4648-aff1-955aabf3bc69')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'eef3d61d-e739-4edd-a32b-e0d683d43780', N'c77213bd-ab43-416b-a37a-9a08b81ec6af', N'36c377e9-cd29-4ceb-8628-6b17df000cbe', N'd7644c31-11bb-4d97-95e5-d467d74a2f62')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'60258f10-72e1-44f0-8f5a-e61176e70ef7', N'89d6476b-cfe8-4cc8-a29f-4ea5e974cf37', N'7fc31ddc-daf1-4b30-ac11-7dab2ce31255', N'84f90f24-46d4-46f8-bc4f-91c6171e5df8')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'be46bcaa-8741-48f4-a18d-e6a50e8a4f4e', N'1657978b-41a0-40ee-aaad-60ab3b187424', N'464a500a-b79c-41f5-a6e9-0b9e60b16263', N'84f90f24-46d4-46f8-bc4f-91c6171e5df8')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'70935c86-999a-4610-a292-e7a5588c9b29', N'de7435f1-7a77-4648-93db-6d0649c50a75', N'5f0abd15-302d-45a6-97ef-721455526e38', N'd7644c31-11bb-4d97-95e5-d467d74a2f62')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'1f0fc869-3be0-4023-aa4f-e8703c024614', N'f42b32d5-d799-4eb1-984d-2de8fe05f650', N'57a00df3-d026-4e3a-bd74-6e3429cea6f3', N'4e6cda4d-b255-4648-aff1-955aabf3bc69')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'953e964e-2940-4838-a8b7-e943e972b0b0', N'de7435f1-7a77-4648-93db-6d0649c50a75', N'1afec28c-008b-4d96-9a3b-fd4c83c5292c', N'507d8f98-54e0-4041-adc8-07cc748e73c6')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'9555c1b9-9598-43ac-b2d5-e9a5349b4afd', N'3e2848cd-68eb-42c3-8f1e-b227cc8bf85c', N'19b7460c-363c-450b-a07e-c2de8f2eaaf9', N'6d5b1bd6-7e06-4e0c-a0a4-6ac4a8910b33')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'5bd1e449-4885-4493-8b2b-e9cb4d5b005f', N'3e2848cd-68eb-42c3-8f1e-b227cc8bf85c', N'7c16af46-7d6b-4f4a-9513-f27fe3447f40', N'0265377b-00e4-45a1-ae1c-e91d8dfb4da3')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'f7166386-8bdd-4f37-8328-ea01de1bab23', N'3361d601-eca1-416c-8d6c-ac8779a5985b', N'9652d820-d6b7-4e73-a590-4af2e2ff8771', N'6d5b1bd6-7e06-4e0c-a0a4-6ac4a8910b33')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'825b104e-7051-4f3a-860b-ec63e0bb2b1a', N'becec057-47d8-4d8f-87ab-daa2d336f9d9', N'de487214-5549-46ff-b5bd-3fe3500c9921', N'd7644c31-11bb-4d97-95e5-d467d74a2f62')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'656ab541-6504-4480-b40e-eceb8e2ed9d8', N'de7435f1-7a77-4648-93db-6d0649c50a75', N'1bb40d72-1cce-4b36-850a-b578a675fb0f', N'd7644c31-11bb-4d97-95e5-d467d74a2f62')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'23aa6d2e-0fd7-4841-a979-eeee85d249ae', N'1888fdc8-de7e-458d-99a4-947e18934957', N'6a34bd21-8b2e-42e7-bea1-20bed405e942', N'd7644c31-11bb-4d97-95e5-d467d74a2f62')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'865c4ab6-0948-4de1-8d1f-ef02a3b4f550', N'1888fdc8-de7e-458d-99a4-947e18934957', N'1c2376ea-d8e1-454e-b00a-923240040846', N'88e3e890-eb57-48ce-9720-d799c752c5bb')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'04ec7130-f7ae-4be2-8a7f-f0a502c46a15', N'1657978b-41a0-40ee-aaad-60ab3b187424', N'615a37a1-5875-4578-a514-99b2b9ade88b', N'88e3e890-eb57-48ce-9720-d799c752c5bb')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'724832d9-1c85-4d08-b812-f19249474306', N'3e2848cd-68eb-42c3-8f1e-b227cc8bf85c', N'15398bfb-e23f-48e2-a86a-340da165f7f7', N'6d5b1bd6-7e06-4e0c-a0a4-6ac4a8910b33')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'725c5912-5a22-4417-bc41-f27b57cefbda', N'de7435f1-7a77-4648-93db-6d0649c50a75', N'4d224305-ea22-411b-bbe0-646ee697f86e', N'4e6cda4d-b255-4648-aff1-955aabf3bc69')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'da116a8b-8df0-4dae-b283-f6ffff0c0d7b', N'950cd115-6f87-4a90-ba06-d67fcbe8045d', N'4a8295a9-7ad5-4d32-ba51-2f7fdf9785d0', N'0265377b-00e4-45a1-ae1c-e91d8dfb4da3')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'cd92103c-9dc9-4eac-9226-f8acfdfe902c', N'76566d07-866e-4122-a314-e970f5e8098d', N'db60cb97-f27f-4e00-9272-db099a562aab', N'8788fffc-59e7-4d46-8c89-700384f3c245')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'f9334bdf-e644-4803-b1e5-f906ddcee664', N'26080978-603e-4286-982b-e5201ec69d40', N'27ecdfb4-f961-4c76-b732-9fbdce0371a7', N'd7644c31-11bb-4d97-95e5-d467d74a2f62')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'3ff80563-291d-4826-99a2-f941feca9ec8', N'89d6476b-cfe8-4cc8-a29f-4ea5e974cf37', N'7e5cd7c1-ff9d-493a-86a0-a11641428a60', N'507d8f98-54e0-4041-adc8-07cc748e73c6')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'e03a6244-7a1a-489f-bea5-f98fdb920024', N'3e2848cd-68eb-42c3-8f1e-b227cc8bf85c', N'5c9dad9e-fbe7-4353-a39b-df5a654da602', N'0265377b-00e4-45a1-ae1c-e91d8dfb4da3')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'b66d68cc-f01a-4ba4-8226-facbd144a202', N'ff698d39-846b-43cb-8308-204c0143bcba', N'cb4d9821-bb38-4f1b-800b-7cbd3a0b7ac9', N'6d5b1bd6-7e06-4e0c-a0a4-6ac4a8910b33')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'0e3493b0-596b-4f65-bc64-fc1b2fc27702', N'26080978-603e-4286-982b-e5201ec69d40', N'ffe0f91f-27ce-45c1-aeef-db7998e7a2ec', N'6d5b1bd6-7e06-4e0c-a0a4-6ac4a8910b33')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'9fa78e8b-bb00-4f03-ac61-fc212e5f5f02', N'99125f9c-b570-4c20-9555-4508f5f66951', N'9a336506-469e-434c-a051-d41ad25134f3', N'507d8f98-54e0-4041-adc8-07cc748e73c6')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'8f6efbda-55f8-4f7e-a38e-fe94b503d3c4', N'a047b192-1f44-4a89-9f12-169c23005993', N'e47b7ffc-f94a-415a-b9e3-ba6840e259c6', N'507d8f98-54e0-4041-adc8-07cc748e73c6')
INSERT [dbo].[Relations] ([RelationId], [Entity_EntityDtoId], [Publication_PublicationDtoId], [Sentiment_SentimentDtoId]) VALUES (N'46d9bcc6-c038-4e40-9ed0-fecf9e9ec8b8', N'1888fdc8-de7e-458d-99a4-947e18934957', N'43d4d5f6-d3ee-490c-8c0d-de437dbfa418', N'84f90f24-46d4-46f8-bc4f-91c6171e5df8')
GO
INSERT [dbo].[Sentiments] ([SentimentId], [Text]) VALUES (N'507d8f98-54e0-4041-adc8-07cc748e73c6', N'Me encanta')
INSERT [dbo].[Sentiments] ([SentimentId], [Text]) VALUES (N'8ef0662e-cef7-4660-a6a7-120b3690d52f', N'Desagradable')
INSERT [dbo].[Sentiments] ([SentimentId], [Text]) VALUES (N'6e3512e5-45ff-45ba-b54c-542c81564a20', N'Desconocido')
INSERT [dbo].[Sentiments] ([SentimentId], [Text]) VALUES (N'6d5b1bd6-7e06-4e0c-a0a4-6ac4a8910b33', N'Horrible')
INSERT [dbo].[Sentiments] ([SentimentId], [Text]) VALUES (N'8788fffc-59e7-4d46-8c89-700384f3c245', N'Me gusta')
INSERT [dbo].[Sentiments] ([SentimentId], [Text]) VALUES (N'84f90f24-46d4-46f8-bc4f-91c6171e5df8', N'Adoro')
INSERT [dbo].[Sentiments] ([SentimentId], [Text]) VALUES (N'4e6cda4d-b255-4648-aff1-955aabf3bc69', N'Genial')
INSERT [dbo].[Sentiments] ([SentimentId], [Text]) VALUES (N'd7644c31-11bb-4d97-95e5-d467d74a2f62', N'Odio')
INSERT [dbo].[Sentiments] ([SentimentId], [Text]) VALUES (N'88e3e890-eb57-48ce-9720-d799c752c5bb', N'Detesto')
INSERT [dbo].[Sentiments] ([SentimentId], [Text]) VALUES (N'c1066621-2ff6-4bf1-ac2d-e31d8cde3af8', N'Asco')
INSERT [dbo].[Sentiments] ([SentimentId], [Text]) VALUES (N'0265377b-00e4-45a1-ae1c-e91d8dfb4da3', N'Amo')
GO
ALTER TABLE [dbo].[Alarms]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Alarms_dbo.Entities_Entity_EntityDtoId] FOREIGN KEY([Entity_EntityDtoId])
REFERENCES [dbo].[Entities] ([EntityId])
GO
ALTER TABLE [dbo].[Alarms] CHECK CONSTRAINT [FK_dbo.Alarms_dbo.Entities_Entity_EntityDtoId]
GO
ALTER TABLE [dbo].[AuthorAlarms]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AuthorAlarms_dbo.Alarms_AlarmId] FOREIGN KEY([AlarmId])
REFERENCES [dbo].[Alarms] ([AlarmId])
GO
ALTER TABLE [dbo].[AuthorAlarms] CHECK CONSTRAINT [FK_dbo.AuthorAlarms_dbo.Alarms_AlarmId]
GO
ALTER TABLE [dbo].[NegativeAlarms]  WITH CHECK ADD  CONSTRAINT [FK_dbo.NegativeAlarms_dbo.Alarms_AlarmId] FOREIGN KEY([AlarmId])
REFERENCES [dbo].[Alarms] ([AlarmId])
GO
ALTER TABLE [dbo].[NegativeAlarms] CHECK CONSTRAINT [FK_dbo.NegativeAlarms_dbo.Alarms_AlarmId]
GO
ALTER TABLE [dbo].[NegativeSentiments]  WITH CHECK ADD  CONSTRAINT [FK_dbo.NegativeSentiments_dbo.Sentiments_SentimentId] FOREIGN KEY([SentimentId])
REFERENCES [dbo].[Sentiments] ([SentimentId])
GO
ALTER TABLE [dbo].[NegativeSentiments] CHECK CONSTRAINT [FK_dbo.NegativeSentiments_dbo.Sentiments_SentimentId]
GO
ALTER TABLE [dbo].[NeutralSentiments]  WITH CHECK ADD  CONSTRAINT [FK_dbo.NeutralSentiments_dbo.Sentiments_SentimentId] FOREIGN KEY([SentimentId])
REFERENCES [dbo].[Sentiments] ([SentimentId])
GO
ALTER TABLE [dbo].[NeutralSentiments] CHECK CONSTRAINT [FK_dbo.NeutralSentiments_dbo.Sentiments_SentimentId]
GO
ALTER TABLE [dbo].[PositiveAlarms]  WITH CHECK ADD  CONSTRAINT [FK_dbo.PositiveAlarms_dbo.Alarms_AlarmId] FOREIGN KEY([AlarmId])
REFERENCES [dbo].[Alarms] ([AlarmId])
GO
ALTER TABLE [dbo].[PositiveAlarms] CHECK CONSTRAINT [FK_dbo.PositiveAlarms_dbo.Alarms_AlarmId]
GO
ALTER TABLE [dbo].[PositiveSentiments]  WITH CHECK ADD  CONSTRAINT [FK_dbo.PositiveSentiments_dbo.Sentiments_SentimentId] FOREIGN KEY([SentimentId])
REFERENCES [dbo].[Sentiments] ([SentimentId])
GO
ALTER TABLE [dbo].[PositiveSentiments] CHECK CONSTRAINT [FK_dbo.PositiveSentiments_dbo.Sentiments_SentimentId]
GO
ALTER TABLE [dbo].[Publications]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Publications_dbo.Authors_Author_AuthorDtoId] FOREIGN KEY([Author_AuthorDtoId])
REFERENCES [dbo].[Authors] ([AuthorId])
GO
ALTER TABLE [dbo].[Publications] CHECK CONSTRAINT [FK_dbo.Publications_dbo.Authors_Author_AuthorDtoId]
GO
ALTER TABLE [dbo].[Relations]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Relations_dbo.Entities_Entity_EntityDtoId] FOREIGN KEY([Entity_EntityDtoId])
REFERENCES [dbo].[Entities] ([EntityId])
GO
ALTER TABLE [dbo].[Relations] CHECK CONSTRAINT [FK_dbo.Relations_dbo.Entities_Entity_EntityDtoId]
GO
ALTER TABLE [dbo].[Relations]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Relations_dbo.Publications_Publication_PublicationDtoId] FOREIGN KEY([Publication_PublicationDtoId])
REFERENCES [dbo].[Publications] ([PublicationId])
GO
ALTER TABLE [dbo].[Relations] CHECK CONSTRAINT [FK_dbo.Relations_dbo.Publications_Publication_PublicationDtoId]
GO
ALTER TABLE [dbo].[Relations]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Relations_dbo.Sentiments_Sentiment_SentimentDtoId] FOREIGN KEY([Sentiment_SentimentDtoId])
REFERENCES [dbo].[Sentiments] ([SentimentId])
GO
ALTER TABLE [dbo].[Relations] CHECK CONSTRAINT [FK_dbo.Relations_dbo.Sentiments_Sentiment_SentimentDtoId]
GO
