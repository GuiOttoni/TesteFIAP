USE [master]
GO
/****** Object:  Database [FIAP.Database]    Script Date: 20/07/2020 03:02:11 ******/
CREATE DATABASE [FIAP.Database]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FIAP.Database', FILENAME = N'/var/opt/mssql/data/FIAP.Database.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FIAP.Database_log', FILENAME = N'/var/opt/mssql/data/FIAP.Database_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [FIAP.Database] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FIAP.Database].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FIAP.Database] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [FIAP.Database] SET ANSI_NULLS ON 
GO
ALTER DATABASE [FIAP.Database] SET ANSI_PADDING ON 
GO
ALTER DATABASE [FIAP.Database] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [FIAP.Database] SET ARITHABORT ON 
GO
ALTER DATABASE [FIAP.Database] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FIAP.Database] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FIAP.Database] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FIAP.Database] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FIAP.Database] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [FIAP.Database] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [FIAP.Database] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FIAP.Database] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [FIAP.Database] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FIAP.Database] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FIAP.Database] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FIAP.Database] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FIAP.Database] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FIAP.Database] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FIAP.Database] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FIAP.Database] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FIAP.Database] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FIAP.Database] SET RECOVERY FULL 
GO
ALTER DATABASE [FIAP.Database] SET  MULTI_USER 
GO
ALTER DATABASE [FIAP.Database] SET PAGE_VERIFY NONE  
GO
ALTER DATABASE [FIAP.Database] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FIAP.Database] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FIAP.Database] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [FIAP.Database] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'FIAP.Database', N'ON'
GO
ALTER DATABASE [FIAP.Database] SET QUERY_STORE = OFF
GO
USE [FIAP.Database]
GO
/****** Object:  Table [dbo].[Parceria]    Script Date: 20/07/2020 03:02:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parceria](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Titulo] [varchar](255) NOT NULL,
	[Descricao] [text] NOT NULL,
	[URLPagina] [varchar](1000) NULL,
	[Empresa] [varchar](40) NOT NULL,
	[DataInicio] [date] NOT NULL,
	[DataTermino] [date] NOT NULL,
	[QtdLikes] [int] NOT NULL,
	[DataHoraCadastro] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[vParceria]    Script Date: 20/07/2020 03:02:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vParceria]
	AS SELECT * 
	FROM Parceria
GO
/****** Object:  Table [dbo].[ParceriaLike]    Script Date: 20/07/2020 03:02:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ParceriaLike](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[CodigoParceria] [int] NOT NULL,
	[DataHoraCadastro] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vParceriaLike]    Script Date: 20/07/2020 03:02:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vParceriaLike]
	AS SELECT 
	* FROM ParceriaLike
GO
ALTER TABLE [dbo].[ParceriaLike]  WITH CHECK ADD  CONSTRAINT [FK_ParceriaLike_Parceria] FOREIGN KEY([CodigoParceria])
REFERENCES [dbo].[Parceria] ([Codigo])
GO
ALTER TABLE [dbo].[ParceriaLike] CHECK CONSTRAINT [FK_ParceriaLike_Parceria]
GO
/****** Object:  StoredProcedure [dbo].[spParceria_Delete]    Script Date: 20/07/2020 03:02:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spParceria_Delete]
	@Codigo int
AS
	DELETE FROM [dbo].[Parceria] WHERE Codigo = @Codigo
RETURN 0
GO
/****** Object:  StoredProcedure [dbo].[spParceria_Insert]    Script Date: 20/07/2020 03:02:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spParceria_Insert]
	@titulo varchar(255),
	@Descricao text,
	@URLPagina varchar(1000) =  '',
	@Empresa varchar(40),
	@DataInicio date,
	@DataTermino date
AS
	INSERT INTO [dbo].[Parceria]
           ([Titulo]
           ,[Descricao]
           ,[URLPagina]
           ,[Empresa]
           ,[DataInicio]
           ,[DataTermino]
           ,[QtdLikes]
           ,[DataHoraCadastro])
     VALUES
           (@titulo
           ,@Descricao
           ,@URLPagina
           ,@Empresa
           ,@DataInicio
           ,@DataTermino
           ,0
           ,GETDATE())
RETURN 0
GO
/****** Object:  StoredProcedure [dbo].[spParceria_Update]    Script Date: 20/07/2020 03:02:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spParceria_Update]
	@Codigo int,
	@titulo varchar(255),
	@Descricao text,
	@URLPagina varchar(1000) =  '',
	@Empresa varchar(40),
	@DataInicio date,
	@DataTermino date
AS
	UPDATE [dbo].[Parceria]
   SET 
       [Titulo] = @Titulo
      ,[Descricao] = @Descricao
      ,[URLPagina] = @URLPagina
      ,[Empresa] = @Empresa
      ,[DataInicio] = @DataInicio
      ,[DataTermino] = @DataTermino
 WHERE Codigo = @Codigo
RETURN 0
GO
/****** Object:  StoredProcedure [dbo].[spParceriaLike_Insert]    Script Date: 20/07/2020 03:02:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spParceriaLike_Insert]
	@CodigoParceria int
AS
	INSERT INTO [dbo].[ParceriaLike]
           (
           [CodigoParceria]
           ,[DataHoraCadastro])
     VALUES
           (
           @CodigoParceria
           ,GETDATE())
RETURN 0
GO
USE [master]
GO
ALTER DATABASE [FIAP.Database] SET  READ_WRITE 
GO
