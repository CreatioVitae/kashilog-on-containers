USE [KashiLogDB]
GO

/****** Object:  Table [kashi].[MstProductTexture]    Script Date: 2017/04/09 23:04:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [kashi].[MstProductTexture](
	[ProductTextureId] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[TextureId] [int] NOT NULL,
	[Value] [int] NULL,
	[CreatedDateTime] [datetime] NOT NULL,
	[LastUpdatedDateTime] [datetime] NOT NULL,
	[LastUpdatedSign] [int] NOT NULL,
 CONSTRAINT [PK_MstProductTexture] PRIMARY KEY CLUSTERED 
(
	[ProductTextureId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO


