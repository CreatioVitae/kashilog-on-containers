USE [KashiLogDB]
GO

/****** Object:  Table [account].[CmnRoles]    Script Date: 2017/07/19 18:29:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [account].[CmnRoles](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](40) NOT NULL,
	[CreateDateTime] [datetime] NOT NULL,
	[LastUpdatedDateTime] [datetime] NOT NULL,
	[LastUpdatedSign] [int] NOT NULL,
 CONSTRAINT [PK_CmnRoles] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


