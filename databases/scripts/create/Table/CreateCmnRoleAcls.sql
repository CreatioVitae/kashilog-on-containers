USE [KashiLogDB]
GO

/****** Object:  Table [account].[CmnRoleAcls]    Script Date: 2017/07/21 19:27:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [account].[CmnRoleAcls](
	[RoleAclId] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [int] NOT NULL,
	[AuthorityForKashi] [int] NOT NULL,
	[AuthorityForEnterprise] [int] NOT NULL,
	[AuthorityForAccount] [int] NOT NULL,
	[CreateDateTime] [datetime] NOT NULL,
	[LastUpdatedDateTime] [datetime] NOT NULL,
	[LastUpdatedSign] [int] NOT NULL,
 CONSTRAINT [PK_CmnRoleAcls] PRIMARY KEY CLUSTERED 
(
	[RoleAclId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [account].[CmnRoleAcls]  WITH CHECK ADD  CONSTRAINT [FK_CmnRoleAcls_CmnRoles] FOREIGN KEY([RoleId])
REFERENCES [account].[CmnRoles] ([RoleId])
GO

ALTER TABLE [account].[CmnRoleAcls] CHECK CONSTRAINT [FK_CmnRoleAcls_CmnRoles]
GO


