USE [TCC.DB]
GO

/****** Object:  Table [dbo].[ADM_TCC_MENU]    Script Date: 30/04/2019 22:22:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ADM_TCC_MENU](
	[ID_N] [decimal](18, 0) IDENTITY(1,1) NOT NULL,
	[TITLE_C] [varchar](100) NOT NULL,
	[ADDED_DATE_D] [datetime] NOT NULL,
	[MODIFIED_DATE_D] [datetime] NULL,
	[ACTIVE_B] [bit] NOT NULL,
 CONSTRAINT [PK_ADM_TCC_MENU_1] PRIMARY KEY CLUSTERED 
(
	[ID_N] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

-------------------------------------------------------------------------------------------------------------------------------------

USE [TCC.DB]
GO

/****** Object:  Table [dbo].[ADM_TCC_MENU_ITEM]    Script Date: 30/04/2019 22:22:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ADM_TCC_MENU_ITEM](
	[ID_N] [decimal](18, 0) IDENTITY(1,1) NOT NULL,
	[ID_MENU_C] [decimal](18, 0) NOT NULL,
	[NAME_C] [varchar](100) NOT NULL,
	[URL_C] [varchar](250) NOT NULL,
	[ORDER_C] [decimal](18, 0) NOT NULL,
	[ADDED_DATE_D] [datetime] NOT NULL,
	[MODIFIED_DATE_D] [datetime] NULL,
	[ACTIVE_B] [bit] NOT NULL,
 CONSTRAINT [PK_ADM_TCC_MENU] PRIMARY KEY CLUSTERED 
(
	[ID_N] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ADM_TCC_MENU_ITEM]  WITH CHECK ADD  CONSTRAINT [FK__MENU_X_MENU_ITEM] FOREIGN KEY([ID_MENU_C])
REFERENCES [dbo].[ADM_TCC_MENU] ([ID_N])
GO

ALTER TABLE [dbo].[ADM_TCC_MENU_ITEM] CHECK CONSTRAINT [FK__MENU_X_MENU_ITEM]
GO

-------------------------------------------------------------------------------------------------------------------------------------

USE [TCC.DB]
GO

/****** Object:  Table [dbo].[PUB_TCC_USER]    Script Date: 30/04/2019 22:23:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PUB_TCC_USER](
	[ID_N] [decimal](18, 0) IDENTITY(1,1) NOT NULL,
	[NAME_C] [varchar](50) NOT NULL,
	[EMAIL_C] [varchar](250) NOT NULL,
	[PASSWORD_C] [varchar](max) NOT NULL,
	[TOKEN_C] [varchar](max) NULL,
	[ADDED_DATE_D] [datetime] NOT NULL,
	[MODIFIED_DATE_D] [datetime] NULL,
	[ACTIVE_B] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_N] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO



