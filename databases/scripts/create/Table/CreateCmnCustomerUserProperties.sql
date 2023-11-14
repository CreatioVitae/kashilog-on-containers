USE [KashiLogDB]
GO

/****** Object:  Table [account].[CmnCustomerUserProperties]    Script Date: 2017/07/19 18:33:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [account].[CmnCustomerUserProperties](
	[CustomerUserPropertyId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[CreatedDateTime] [datetime] NOT NULL,
	[LastUpdatedDateTime] [datetime] NOT NULL,
	[LastUpdatedSign] [int] NOT NULL,
 CONSTRAINT [PK_CmnCustomerUserProperties] PRIMARY KEY CLUSTERED 
(
	[CustomerUserPropertyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [account].[CmnCustomerUserProperties]  WITH CHECK ADD  CONSTRAINT [FK_CmnCustomerUserProperties_CmnUsers] FOREIGN KEY([UserId])
REFERENCES [account].[CmnUsers] ([UserId])
GO

ALTER TABLE [account].[CmnCustomerUserProperties] CHECK CONSTRAINT [FK_CmnCustomerUserProperties_CmnUsers]
GO


