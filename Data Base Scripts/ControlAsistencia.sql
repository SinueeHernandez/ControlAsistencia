USE [ControlAsistencia]
GO
/****** Object:  Table [dbo].[Asistencia]    Script Date: 3/21/2016 10:12:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asistencia](
	[PersonaID] [int] NULL,
	[ReunionID] [int] NULL,
	[TomaAsistencia] [datetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Personas]    Script Date: 3/21/2016 10:12:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Personas](
	[NumeroControl] [int] NOT NULL,
	[Nombres] [varchar](max) NULL,
	[Apellidos] [varchar](max) NULL,
	[Puestos] [varchar](max) NULL,
	[huella] [varchar](max) NULL,
 CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED 
(
	[NumeroControl] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Reuniones]    Script Date: 3/21/2016 10:12:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Reuniones](
	[ReunionID] [int] NOT NULL,
	[Nombre] [varchar](max) NULL,
	[Lugar] [varchar](max) NULL,
	[FechaInicio] [datetime] NULL,
	[FecharTermino] [datetime] NULL,
 CONSTRAINT [PK_Reuniones] PRIMARY KEY CLUSTERED 
(
	[ReunionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Asistencia]  WITH CHECK ADD  CONSTRAINT [FK_Asistencia_Personas] FOREIGN KEY([PersonaID])
REFERENCES [dbo].[Personas] ([NumeroControl])
GO
ALTER TABLE [dbo].[Asistencia] CHECK CONSTRAINT [FK_Asistencia_Personas]
GO
ALTER TABLE [dbo].[Asistencia]  WITH CHECK ADD  CONSTRAINT [FK_Asistencia_Reuniones] FOREIGN KEY([ReunionID])
REFERENCES [dbo].[Reuniones] ([ReunionID])
GO
ALTER TABLE [dbo].[Asistencia] CHECK CONSTRAINT [FK_Asistencia_Reuniones]
GO
