USE [KashiLogDB]
GO

/****** Object:  Table [enterprise].[CmnCompany]    Script Date: 2017/04/09 22:59:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [enterprise].[CmnCompany](
	[CompanyId] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [nvarchar](256) NOT NULL,
	[ZipCode] [varchar](13) NOT NULL,
	[Country] [nvarchar](50) NOT NULL,
	[City] [nvarchar](40) NOT NULL,
	[Address] [nvarchar](1000) NOT NULL,
	[TelephoneNumber] [varchar](20) NOT NULL,
	[CreatedDateTime] [datetime] NOT NULL,
	[LastUpdatedDateTime] [datetime] NOT NULL,
	[LastUpdatedSign] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CompanyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO

SET ANSI_PADDING OFF
GO


