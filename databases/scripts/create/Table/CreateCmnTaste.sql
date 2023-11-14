USE [KashiLogDB]
GO

/****** Object:  Table [kashi].[CmnTaste]    Script Date: 2017/04/09 23:01:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [kashi].[CmnTaste](
	[TasteId] [int] IDENTITY(1,1) NOT NULL,
	[TasteName] [nvarchar](50) NOT NULL,
	[TasteVector] [int] NULL,
	[CreatedDateTime] [datetime] NOT NULL,
	[LastUpdatedDateTime] [datetime] NOT NULL,
	[LastUpdatedSign] [int] NOT NULL,
 CONSTRAINT [PK_CmnTaste] PRIMARY KEY CLUSTERED 
(
	[TasteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO


