USE [master]
GO
/****** Object:  Database [ControlAsistencia]    Script Date: 3/23/2016 10:26:23 AM ******/
CREATE DATABASE [ControlAsistencia]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ControlAsistencia', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.DFESHS01\MSSQL\DATA\ControlAsistencia.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ControlAsistencia_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.DFESHS01\MSSQL\DATA\ControlAsistencia_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ControlAsistencia] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ControlAsistencia].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ControlAsistencia] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ControlAsistencia] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ControlAsistencia] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ControlAsistencia] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ControlAsistencia] SET ARITHABORT OFF 
GO
ALTER DATABASE [ControlAsistencia] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ControlAsistencia] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ControlAsistencia] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ControlAsistencia] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ControlAsistencia] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ControlAsistencia] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ControlAsistencia] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ControlAsistencia] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ControlAsistencia] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ControlAsistencia] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ControlAsistencia] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ControlAsistencia] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ControlAsistencia] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ControlAsistencia] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ControlAsistencia] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ControlAsistencia] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ControlAsistencia] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ControlAsistencia] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ControlAsistencia] SET  MULTI_USER 
GO
ALTER DATABASE [ControlAsistencia] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ControlAsistencia] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ControlAsistencia] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ControlAsistencia] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ControlAsistencia] SET DELAYED_DURABILITY = DISABLED 
GO
USE [ControlAsistencia]
GO
/****** Object:  Table [dbo].[Asistencia]    Script Date: 3/23/2016 10:26:23 AM ******/
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
/****** Object:  Table [dbo].[Personas]    Script Date: 3/23/2016 10:26:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Personas](
	[NumeroControl] [int] NOT NULL,
	[Nombre] [varchar](max) NULL,
	[Puestos] [varchar](max) NULL,
	[Huella] [varbinary](max) NULL,
 CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED 
(
	[NumeroControl] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Reuniones]    Script Date: 3/23/2016 10:26:23 AM ******/
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
USE [master]
GO
ALTER DATABASE [ControlAsistencia] SET  READ_WRITE 
GO
