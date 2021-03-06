USE [PetSureFileUpload]
GO
/****** Object:  Table [dbo].[Pets]    Script Date: 12/12/2016 17:30:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pets](
	[PetID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](255) NULL,
	[Enable] [bit] NOT NULL,
 CONSTRAINT [PK_Pets] PRIMARY KEY CLUSTERED 
(
	[PetID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FileUploads]    Script Date: 12/12/2016 17:30:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FileUploads](
	[FileID] [bigint] IDENTITY(1,1) NOT NULL,
	[PetID] [bigint] NOT NULL,
	[FileType] [nchar](255) NULL,
	[FileName] [varchar](max) NULL,
	[OriginalFileName] [varchar](max) NULL,
 CONSTRAINT [PK_FileUpload] PRIMARY KEY CLUSTERED 
(
	[FileID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Default [DF_Pets_Enable]    Script Date: 12/12/2016 17:30:10 ******/
ALTER TABLE [dbo].[Pets] ADD  CONSTRAINT [DF_Pets_Enable]  DEFAULT ((1)) FOR [Enable]
GO
/****** Object:  ForeignKey [FK_FileUploads_Pets]    Script Date: 12/12/2016 17:30:10 ******/
ALTER TABLE [dbo].[FileUploads]  WITH CHECK ADD  CONSTRAINT [FK_FileUploads_Pets] FOREIGN KEY([PetID])
REFERENCES [dbo].[Pets] ([PetID])
GO
ALTER TABLE [dbo].[FileUploads] CHECK CONSTRAINT [FK_FileUploads_Pets]
GO
