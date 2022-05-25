/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 11/05/2022 09:30:00 ******/
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
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CategoryTbl]    Script Date: 11/05/2022 09:30:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoryTbl](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerTbl]    Script Date: 11/05/2022 09:30:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerTbl](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserRef] [uniqueidentifier] NOT NULL,
	[CreatedDatetimeOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedDatetimeOn] [datetime] NULL,
	[UpdatedBy] [int] NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProviderTbl]    Script Date: 11/05/2022 09:30:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProviderTbl](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserRef] [uniqueidentifier] NOT NULL,
	[CompanyName] [nvarchar](100) NULL,
	[CompanyDescription] [nvarchar](max) NULL,
	[CompanyLogo] [nvarchar](200) NULL,
	[Occupation] [nvarchar](100) NULL,
	[CreatedDatetimeOn] [datetime] NOT NULL,
	[CreatedBy] [int] NULL,
	[UpdatedDatetimeOn] [datetime] NULL,
	[UpdatedBy] [int] NULL,
 CONSTRAINT [PK__Provider__3214EC07E9415968] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RequestTbl]    Script Date: 11/05/2022 09:30:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RequestTbl](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ServiceID] [int] NOT NULL,
	[UserRef] [uniqueidentifier] NOT NULL,
	[Status] [nvarchar](20) NOT NULL,
	[Description] [varchar](max) NULL,
	[CreatedDatetimeOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedDatetimeOn] [datetime] NULL,
	[UpdatedBy] [int] NULL,
 CONSTRAINT [PK_RequestTbl] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServiceTbl]    Script Date: 11/05/2022 09:30:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceTbl](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserRef] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Description_Short] [nvarchar](250) NULL,
	[Description] [nvarchar](max) NULL,
	[CategoryId] [int] NOT NULL,
	[CreatedDatetimeOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedDatetimeOn] [datetime] NULL,
	[UpdatedBy] [int] NULL,
 CONSTRAINT [PK__ServiceT__3214EC07FD4BDCAE] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserTbl]    Script Date: 11/05/2022 09:30:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserTbl](
	[UserRef] [uniqueidentifier] NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[UserPass] [nvarchar](50) NOT NULL,
	[Firstname] [nvarchar](50) NOT NULL,
	[Lastname] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](100) NULL,
	[Adress] [nvarchar](50) NULL,
	[Mobile] [nvarchar](50) NULL,
	[City] [nvarchar](50) NULL,
	[Zip] [nvarchar](10) NULL,
	[IsNotifyEmail] [bit] NOT NULL,
	[IsNotifySms] [bit] NOT NULL,
	[IsServiceProvider] [bit] NOT NULL,
	[CreatedDatetimeOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedDatetimeOn] [datetime] NULL,
	[UpdatedBy] [int] NULL,
 CONSTRAINT [PK_Table] PRIMARY KEY CLUSTERED 
(
	[UserRef] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CustomerTbl] ADD  CONSTRAINT [DF_Customer_CreatedDatetimeOn]  DEFAULT (getdate()) FOR [CreatedDatetimeOn]
GO
ALTER TABLE [dbo].[ProviderTbl] ADD  CONSTRAINT [DF_ProviderTbl_CreatedDatetimeOn]  DEFAULT (getdate()) FOR [CreatedDatetimeOn]
GO
ALTER TABLE [dbo].[RequestTbl] ADD  CONSTRAINT [DF_RequestTbl_Status]  DEFAULT ('NEW') FOR [Status]
GO
ALTER TABLE [dbo].[RequestTbl] ADD  CONSTRAINT [DF_RequestTbl_CreatedOn]  DEFAULT (getdate()) FOR [CreatedDatetimeOn]
GO
ALTER TABLE [dbo].[ServiceTbl] ADD  CONSTRAINT [DF_ServiceTbl_CreatedDatetimeOn]  DEFAULT (getdate()) FOR [CreatedDatetimeOn]
GO
ALTER TABLE [dbo].[UserTbl] ADD  CONSTRAINT [DF__UserTbl__IsNotif__60A75C0F]  DEFAULT ((0)) FOR [IsNotifyEmail]
GO
ALTER TABLE [dbo].[UserTbl] ADD  CONSTRAINT [DF__UserTbl__IsNotif__619B8048]  DEFAULT ((0)) FOR [IsNotifySms]
GO
ALTER TABLE [dbo].[UserTbl] ADD  CONSTRAINT [DF__UserTbl__IsServi__628FA481]  DEFAULT ((0)) FOR [IsServiceProvider]
GO
ALTER TABLE [dbo].[UserTbl] ADD  CONSTRAINT [DF_UserTbl_CreatedDatetimeOn]  DEFAULT (getdate()) FOR [CreatedDatetimeOn]
GO
ALTER TABLE [dbo].[CustomerTbl]  WITH CHECK ADD  CONSTRAINT [FK_CustomerTbl_UserTbl] FOREIGN KEY([UserRef])
REFERENCES [dbo].[UserTbl] ([UserRef])
GO
ALTER TABLE [dbo].[CustomerTbl] CHECK CONSTRAINT [FK_CustomerTbl_UserTbl]
GO
ALTER TABLE [dbo].[ProviderTbl]  WITH CHECK ADD  CONSTRAINT [FK_ProviderTbl_UserTbl] FOREIGN KEY([UserRef])
REFERENCES [dbo].[UserTbl] ([UserRef])
GO
ALTER TABLE [dbo].[ProviderTbl] CHECK CONSTRAINT [FK_ProviderTbl_UserTbl]
GO
ALTER TABLE [dbo].[RequestTbl]  WITH CHECK ADD  CONSTRAINT [FK_RequestTbl_ServiceTbl] FOREIGN KEY([ServiceID])
REFERENCES [dbo].[ServiceTbl] ([Id])
GO
ALTER TABLE [dbo].[RequestTbl] CHECK CONSTRAINT [FK_RequestTbl_ServiceTbl]
GO
ALTER TABLE [dbo].[RequestTbl]  WITH CHECK ADD  CONSTRAINT [FK_RequestTbl_UserTbl] FOREIGN KEY([UserRef])
REFERENCES [dbo].[UserTbl] ([UserRef])
GO
ALTER TABLE [dbo].[RequestTbl] CHECK CONSTRAINT [FK_RequestTbl_UserTbl]
GO
ALTER TABLE [dbo].[ServiceTbl]  WITH CHECK ADD  CONSTRAINT [FK_ServiceTbl_CategoryTbl] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[CategoryTbl] ([Id])
GO
ALTER TABLE [dbo].[ServiceTbl] CHECK CONSTRAINT [FK_ServiceTbl_CategoryTbl]
GO
ALTER TABLE [dbo].[ServiceTbl]  WITH CHECK ADD  CONSTRAINT [FK_ServiceTbl_UserTbl] FOREIGN KEY([UserRef])
REFERENCES [dbo].[UserTbl] ([UserRef])
GO
ALTER TABLE [dbo].[ServiceTbl] CHECK CONSTRAINT [FK_ServiceTbl_UserTbl]
GO
