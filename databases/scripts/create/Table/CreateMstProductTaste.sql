USE [KashiLogDB]
GO

/****** Object:  Table [kashi].[MstProductTaste]    Script Date: 2017/04/09 23:03:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [kashi].[MstProductTaste](
	[ProductTasteId] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[TasteId] [int] NOT NULL,
	[Value] [int] NOT NULL,
	[CreatedDateTime] [datetime] NOT NULL,
	[LastUpdatedDateTime] [datetime] NOT NULL,
	[LastUpdatedSign] [int] NOT NULL,
 CONSTRAINT [PK_MstProductTaste] PRIMARY KEY CLUSTERED 
(
	[ProductTasteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO


