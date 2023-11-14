USE [KashiLogDB]
GO

/****** Object:  Table [account].[CmnUsers]    Script Date: 2017/07/19 18:26:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [account].[CmnUsers](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](120) NOT NULL,
	[RoleId] [int] NOT NULL,
	[CreatedDateTime] [datetime] NOT NULL,
	[LastUpdatedDateTime] [datetime] NOT NULL,
	[LastUpdatedSign] [int] NOT NULL,
 CONSTRAINT [PK_CmnUsers] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [account].[CmnUsers]  WITH CHECK ADD  CONSTRAINT [FK_CmnUsers_CmnRoles] FOREIGN KEY([RoleId])
REFERENCES [account].[CmnRoles] ([RoleId])
GO

ALTER TABLE [account].[CmnUsers] CHECK CONSTRAINT [FK_CmnUsers_CmnRoles]
GO


