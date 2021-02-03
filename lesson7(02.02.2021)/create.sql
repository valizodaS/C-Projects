USE [Test]
GO

/****** Object:  Table [dbo].[MobilePhone]    Script Date: 03.02.2021 10:20:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MobilePhone](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[MadeIn] [nvarchar](50) NULL,
	[MadeYear] [int] NULL,
	[LicenceMonth] [int] NULL,
	[Memory] [float] NULL,
	[RAM] [float] NULL,
	[New] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

INSERT INTO [dbo].[MobilePhone]
           ([ID],[Name],[MadeIn],[MadeYear],[LicenceMonth],[Memory],[RAM],[New])
     VALUES
           (1, 'Samsung Galaxy S12', 'Korea', 2020,36,128.0,3.5,1)

GO

