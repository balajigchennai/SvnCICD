
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

DROP table dbo.svntable;
GO


CREATE TABLE [dbo].[svntable](
	[SVNID] [int] NULL,
	[APPNAME] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

