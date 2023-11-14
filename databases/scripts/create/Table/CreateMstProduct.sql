USE [KashiLogDB]
GO

/****** Object:  Table [kashi].[MstProduct]    Script Date: 2017/05/14 22:13:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [kashi].[MstProduct](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[ProductLineUpId] [int] NOT NULL,
	[ProductRevision] [int] NOT NULL,
	[ValidBeginDateTime] [datetime] NOT NULL,
	[ValidEndDateTime] [datetime] NOT NULL,
	[ProductName] [nvarchar](200) NOT NULL,
	[LargeCategory] [int] NOT NULL,
	[MiddleCategory] [int] NOT NULL,
	[SmallCategory] [int] NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[Amount] [numeric](5, 2) NOT NULL,
	[AmountType] [int] NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[MakerCompanyId] [int] NOT NULL,
	[PublisherCompanyId] [int] NOT NULL,
	[CreatedTimeStamp] [datetime] NOT NULL,
	[LastUpdatedTimeStamp] [datetime] NOT NULL,
	[LastUpdatedSign] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO

ALTER TABLE [kashi].[MstProduct]  WITH CHECK ADD  CONSTRAINT [FK_MstProductMaker_CmnCompany] FOREIGN KEY([MakerCompanyId])
REFERENCES [enterprise].[CmnCompany] ([CompanyId])
GO

ALTER TABLE [kashi].[MstProduct] CHECK CONSTRAINT [FK_MstProductMaker_CmnCompany]
GO

ALTER TABLE [kashi].[MstProduct]  WITH CHECK ADD  CONSTRAINT [FK_MstProductPublisher_CmnCompany] FOREIGN KEY([PublisherCompanyId])
REFERENCES [enterprise].[CmnCompany] ([CompanyId])
GO

ALTER TABLE [kashi].[MstProduct] CHECK CONSTRAINT [FK_MstProductPublisher_CmnCompany]
GO


