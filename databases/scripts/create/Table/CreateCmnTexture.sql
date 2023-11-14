USE [KashiLogDB]
GO

/****** Object:  Table [kashi].[CmnTexture]    Script Date: 2017/04/09 23:02:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [kashi].[CmnTexture](
	[TextureId] [int] IDENTITY(1,1) NOT NULL,
	[TextureName] [nvarchar](50) NOT NULL,
	[TextureVector] [int] NULL,
	[CreatedDateTime] [datetime] NOT NULL,
	[LastUpdatedDateTime] [datetime] NOT NULL,
	[LastUpdatedSign] [int] NOT NULL,
 CONSTRAINT [PK_CmnTexture] PRIMARY KEY CLUSTERED 
(
	[TextureId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO


