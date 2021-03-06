USE [master]
GO
/****** Object:  Database [ABM_Localidades]    Script Date: 22/06/2020 12:54:07 ******/
CREATE DATABASE [ABM_Localidades]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ABM_Localidades', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.CARLOSKEHOE\MSSQL\DATA\ABM_Localidades.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ABM_Localidades_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.CARLOSKEHOE\MSSQL\DATA\ABM_Localidades_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ABM_Localidades] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ABM_Localidades].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ABM_Localidades] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ABM_Localidades] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ABM_Localidades] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ABM_Localidades] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ABM_Localidades] SET ARITHABORT OFF 
GO
ALTER DATABASE [ABM_Localidades] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ABM_Localidades] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ABM_Localidades] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ABM_Localidades] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ABM_Localidades] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ABM_Localidades] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ABM_Localidades] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ABM_Localidades] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ABM_Localidades] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ABM_Localidades] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ABM_Localidades] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ABM_Localidades] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ABM_Localidades] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ABM_Localidades] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ABM_Localidades] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ABM_Localidades] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ABM_Localidades] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ABM_Localidades] SET RECOVERY FULL 
GO
ALTER DATABASE [ABM_Localidades] SET  MULTI_USER 
GO
ALTER DATABASE [ABM_Localidades] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ABM_Localidades] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ABM_Localidades] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ABM_Localidades] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ABM_Localidades] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'ABM_Localidades', N'ON'
GO
ALTER DATABASE [ABM_Localidades] SET QUERY_STORE = OFF
GO
USE [ABM_Localidades]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [ABM_Localidades]
GO
/****** Object:  Table [dbo].[Ciudades]    Script Date: 22/06/2020 12:54:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ciudades](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](30) NULL,
	[IdProvincia] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paises]    Script Date: 22/06/2020 12:54:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paises](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provincias]    Script Date: 22/06/2020 12:54:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincias](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](30) NULL,
	[IdPais] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 22/06/2020 12:54:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 22/06/2020 12:54:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Idciudad] [int] NULL,
	[IdRol] [int] NULL,
	[Email] [varchar](50) NULL,
	[Clave] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Ciudades]  WITH CHECK ADD FOREIGN KEY([IdProvincia])
REFERENCES [dbo].[Provincias] ([Id])
GO
ALTER TABLE [dbo].[Provincias]  WITH CHECK ADD FOREIGN KEY([IdPais])
REFERENCES [dbo].[Paises] ([Id])
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD FOREIGN KEY([Idciudad])
REFERENCES [dbo].[Ciudades] ([Id])
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD FOREIGN KEY([IdRol])
REFERENCES [dbo].[Roles] ([Id])
GO
/****** Object:  StoredProcedure [dbo].[SP_CiudadesGet]    Script Date: 22/06/2020 12:54:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CiudadesGet]

	@IdProvincia int
	
AS
BEGIN
	
		select * from Ciudades where IdProvincia = @IdProvincia
	
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CiudadesInsert]    Script Date: 22/06/2020 12:54:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CiudadesInsert] 
	@Nombre varchar(100),
	@IdProvincia int
	
AS
BEGIN
	
	INSERT INTO [dbo].[Ciudades]([Nombre],[IdProvincia])
	VALUES(@Nombre, @IdProvincia)

	select * from Ciudades where Id = SCOPE_IDENTITY()
	
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CiudadesUpdate]    Script Date: 22/06/2020 12:54:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CiudadesUpdate]
	@Nombre varchar(50),
	@Id int
AS
BEGIN
	UPDATE Ciudades SET Nombre = @Nombre WHERE Id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[SP_PaisesGet]    Script Date: 22/06/2020 12:54:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_PaisesGet]

AS
BEGIN
	Select * from Paises
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ProvinciasGet]    Script Date: 22/06/2020 12:54:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ProvinciasGet]
	@paisId int
AS
BEGIN
	Select * From Provincias where IdPais = @paisId
END
GO
/****** Object:  StoredProcedure [dbo].[SP_UsuarioGetByMail]    Script Date: 22/06/2020 12:54:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_UsuarioGetByMail]
	@Email varchar(50)
AS
BEGIN
	select * from Usuarios where Email=@Email
END
GO
/****** Object:  StoredProcedure [dbo].[SP_UsuarioInsert]    Script Date: 22/06/2020 12:54:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_UsuarioInsert]
 @IdCiudad int,
 @IdRol int,
 @Nombre varchar(30),
 @Email varchar(50),
 @Clave varchar (30)
AS
BEGIN
INSERT INTO [dbo].[Usuarios]([Nombre],[IdCiudad],[IdRol],[Email],[Clave])
	VALUES(@Nombre, @IdCiudad, @IdRol, @Email, @Clave)

	select * from Usuarios where Id = SCOPE_IDENTITY()
END
GO
USE [master]
GO
ALTER DATABASE [ABM_Localidades] SET  READ_WRITE 
GO
