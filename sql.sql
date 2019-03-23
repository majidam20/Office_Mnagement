USE [nosazi]
GO
/****** Object:  Table [dbo].[ReloadMode]    Script Date: 01/23/2009 12:10:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReloadMode](
	[album] [bit] NOT NULL CONSTRAINT [DF_ReloadMode_album]  DEFAULT ((0)),
	[book] [bit] NOT NULL CONSTRAINT [DF_ReloadMode_book]  DEFAULT ((0)),
	[CD_DVD] [bit] NOT NULL CONSTRAINT [DF_ReloadMode_CD_DVD]  DEFAULT ((0)),
	[magazine] [bit] NOT NULL CONSTRAINT [DF_ReloadMode_magazine]  DEFAULT ((0)),
	[report] [bit] NOT NULL CONSTRAINT [DF_ReloadMode_report]  DEFAULT ((0)),
	[repertory] [bit] NOT NULL CONSTRAINT [DF_ReloadMode_repertory]  DEFAULT ((0)),
	[map] [bit] NOT NULL CONSTRAINT [DF_ReloadMode_map]  DEFAULT ((0)),
	[resume] [bit] NOT NULL CONSTRAINT [DF_ReloadMode_resume]  DEFAULT ((0)),
	[zuncan] [bit] NOT NULL CONSTRAINT [DF_ReloadMode_zuncan]  DEFAULT ((0)),
	[convention] [bit] NOT NULL CONSTRAINT [DF_ReloadMode_convention]  DEFAULT ((0)),
	[users] [bit] NOT NULL,
	[parts] [bit] NOT NULL
) ON [PRIMARY]

insert into [dbo].[ReloadMode] values (1,1,1,1,1,1,1,1,1,1,1,1)