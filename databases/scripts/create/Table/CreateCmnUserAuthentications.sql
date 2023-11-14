USE [KashiLogDB]
GO

/****** Object:  Table [account].[CmnUserAuthentications]    Script Date: 2017/07/28 16:02:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [account].[CmnUserAuthentications](
	[UserAuthenticationId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[LoginName] [nvarchar](40) NOT NULL,
	[HashedPassword] [nvarchar](256) NOT NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[Email] [nvarchar](256) NULL,
	[LockoutEndDate] [datetime] NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[CreatedDateTime] [datetime] NOT NULL,
	[LastUpdatedDateTime] [datetime] NOT NULL,
	[LastUpdatedSign] [datetime] NOT NULL,
 CONSTRAINT [PK_CmnUserAuthentications] PRIMARY KEY CLUSTERED 
(
	[UserAuthenticationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

ALTER TABLE [account].[CmnUserAuthentications]  WITH CHECK ADD  CONSTRAINT [FK_CmnUserAuthentications_CmnUsers] FOREIGN KEY([UserId])
REFERENCES [account].[CmnUsers] ([UserId])
GO

ALTER TABLE [account].[CmnUserAuthentications] CHECK CONSTRAINT [FK_CmnUserAuthentications_CmnUsers]
GO


