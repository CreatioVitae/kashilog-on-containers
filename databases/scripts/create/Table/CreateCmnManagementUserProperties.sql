USE [KashiLogDB]
GO

/****** Object:  Table [account].[CmnManagementUserProperties]    Script Date: 2017/07/19 18:33:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [account].[CmnManagementUserProperties](
	[ManagementUserPropertyId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[CreatedDateTime] [datetime] NOT NULL,
	[UpdatedDateTime] [datetime] NOT NULL,
	[LastUpdatedSign] [int] NOT NULL,
 CONSTRAINT [PK_CmnManagementUserProperties] PRIMARY KEY CLUSTERED 
(
	[ManagementUserPropertyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [account].[CmnManagementUserProperties]  WITH CHECK ADD  CONSTRAINT [FK_CmnManagementUserProperties_CmnUsers] FOREIGN KEY([UserId])
REFERENCES [account].[CmnUsers] ([UserId])
GO

ALTER TABLE [account].[CmnManagementUserProperties] CHECK CONSTRAINT [FK_CmnManagementUserProperties_CmnUsers]
GO


