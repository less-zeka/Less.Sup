USE [SupRouteDB]
GO

/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 03.07.2015 17:19:20 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

USE [SupRouteDB]
GO

/****** Object:  Table [dbo].[Routes]    Script Date: 03.07.2015 17:19:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Routes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Routes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

USE [SupRouteDB]
GO

/****** Object:  Table [dbo].[WayPoints]    Script Date: 03.07.2015 17:19:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[WayPoints](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DbGeography] [geography] NULL,
	[Longitude] [float] NOT NULL,
	[Latitude] [float] NOT NULL,
	[Info] [nvarchar](max) NULL,
	[RouteId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.WayPoints] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

ALTER TABLE [dbo].[WayPoints]  WITH CHECK ADD  CONSTRAINT [FK_dbo.WayPoints_dbo.Routes_RouteId] FOREIGN KEY([RouteId])
REFERENCES [dbo].[Routes] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[WayPoints] CHECK CONSTRAINT [FK_dbo.WayPoints_dbo.Routes_RouteId]
GO



