USE [master]
GO
/****** Object:  Database [RegistroHabitantes]    Script Date: 13/02/2020 08:45:11 a. m. ******/
CREATE DATABASE [RegistroHabitantes]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RegistroHabitantes', FILENAME = N'C:\Users\nayla\RegistroHabitantes.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RegistroHabitantes_log', FILENAME = N'C:\Users\nayla\RegistroHabitantes_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [RegistroHabitantes] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RegistroHabitantes].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RegistroHabitantes] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RegistroHabitantes] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RegistroHabitantes] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RegistroHabitantes] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RegistroHabitantes] SET ARITHABORT OFF 
GO
ALTER DATABASE [RegistroHabitantes] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [RegistroHabitantes] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RegistroHabitantes] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RegistroHabitantes] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RegistroHabitantes] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RegistroHabitantes] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RegistroHabitantes] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RegistroHabitantes] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RegistroHabitantes] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RegistroHabitantes] SET  ENABLE_BROKER 
GO
ALTER DATABASE [RegistroHabitantes] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RegistroHabitantes] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RegistroHabitantes] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RegistroHabitantes] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RegistroHabitantes] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RegistroHabitantes] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RegistroHabitantes] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RegistroHabitantes] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [RegistroHabitantes] SET  MULTI_USER 
GO
ALTER DATABASE [RegistroHabitantes] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RegistroHabitantes] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RegistroHabitantes] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RegistroHabitantes] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RegistroHabitantes] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [RegistroHabitantes] SET QUERY_STORE = OFF
GO
USE [RegistroHabitantes]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [RegistroHabitantes]
GO
/****** Object:  Table [dbo].[Personas]    Script Date: 13/02/2020 08:45:11 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personas](
	[idPersona] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](60) NULL,
	[Edad] [int] NULL,
	[Genero] [int] NULL,
 CONSTRAINT [PK_Personas] PRIMARY KEY CLUSTERED 
(
	[idPersona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Personas] ON 

INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (1, N'Eduardo Torres mo', 30, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (4, N'Ivan Garcia', 30, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (5, N'Raquel Saucedo', 25, 1)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (6, N'Luis Garza', 34, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (7, N'Alicia Perez Martinez', 30, 1)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (8, N'Pedro Perez Martinez', 25, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (9, N'Estefania Pichardo', 20, 1)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (10, N'Saul Maldonado Gomez', 20, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (11, N'Esmeralda Lopez', 21, 1)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (12, N'David Rodriguez', 25, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (13, N'Fernando Palacios', 30, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (14, N'Oscar Juarez', 30, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (15, N'Theo Martinez', 30, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (16, N'Daniel Hurtado', 35, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (17, N'Karen Sanchez', 28, 1)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (18, N'Hector Perez', 25, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (19, N'Gabriel Torres', 45, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (20, N'Valeria Aleman', 26, 1)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (21, N'Maria Chavez', 34, 1)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (22, N'Paola Rodriguez', 25, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (23, N'Rodrigo Palacios', 30, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (24, N'Juan Juarez', 30, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (25, N'Kevin Martinez', 30, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (26, N'Ulises Hurtado', 35, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (27, N'Wendy Sanchez', 28, 1)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (28, N'Bernardo Perez', 25, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (29, N'Luis Torres', 45, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (30, N'Ximena Aleman', 26, 1)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (31, N'Cristina Chavez', 34, 1)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (32, N'David Rodriguez', 25, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (33, N'Fernando Palacios', 30, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (34, N'Oscar Juarez', 30, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (35, N'Theo Martinez', 30, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (36, N'Daniel Hurtado', 35, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (37, N'Sofia Sanchez', 28, 1)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (38, N'Sergio Perez', 25, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (39, N'Gabriela Torres', 45, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (40, N'Vidal Aleman', 26, 1)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (41, N'Fernanda Chavez', 34, 1)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (42, N'Jared Rodriguez', 25, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (43, N'Ivan Palacios', 30, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (44, N'Oralia Juarez', 30, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (45, N'Carlos Martinez', 30, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (46, N'Denisse Hurtado', 35, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (47, N'Irlanda Sanchez', 28, 1)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (48, N'Jeff Perez', 25, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (49, N'Jose Torres', 45, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (50, N'Oliver Aleman', 26, 1)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (51, N'Alondra Chavez', 34, 1)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (52, N'Clara Sanchez', 28, 1)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (53, N'Belio Perez', 25, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (54, N'Guadalupe Torres', 45, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (55, N'Liliana Aleman', 26, 1)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (56, N'Elizabeth Chavez', 34, 1)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (57, N'Alicia Perez Martinez', 30, 1)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (58, N'Pedro Perez Martinez', 25, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (59, N'Estefania Pichardo', 20, 1)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (60, N'Saul Maldonado Gomez', 20, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (61, N'Esmeralda Lopez', 21, 1)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (62, N'David Rodriguez', 25, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (63, N'Fernando Palacios', 30, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (64, N'Oscar Juarez', 30, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (65, N'Theo Martinez', 30, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (66, N'Daniel Hurtado', 35, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (67, N'Karen Sanchez', 28, 1)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (68, N'Hector Perez', 25, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (69, N'Gabriel Torres', 45, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (70, N'Valeria Aleman', 26, 1)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (71, N'Maria Chavez', 34, 1)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (72, N'Paola Rodriguez', 25, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (73, N'Rodrigo Palacios', 30, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (74, N'Juan Juarez', 30, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (75, N'Kevin Martinez', 30, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (76, N'Ulises Hurtado', 35, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (77, N'Wendy Sanchez', 28, 1)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (78, N'Bernardo Perez', 25, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (79, N'Luis Torres', 45, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (80, N'Ximena Aleman', 26, 1)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (81, N'Cristina Chavez', 34, 1)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (82, N'David Rodriguez', 25, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (83, N'Fernando Palacios', 30, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (84, N'Oscar Juarez', 30, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (85, N'Theo Martinez', 30, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (86, N'Daniel Hurtado', 35, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (87, N'Sofia Sanchez', 28, 1)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (88, N'Sergio Perez', 25, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (89, N'Gabriela Torres', 45, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (90, N'Vidal Aleman', 26, 1)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (91, N'Fernanda Chavez', 34, 1)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (92, N'Jared Rodriguez', 25, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (93, N'Ivan Palacios', 30, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (94, N'Oralia Juarez', 30, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (95, N'Carlos Martinez', 30, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (96, N'Denisse Hurtado', 35, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (97, N'Irlanda Sanchez', 28, 1)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (98, N'Jeff Perez', 25, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (99, N'Jose Torres', 45, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (100, N'Oliver Aleman', 26, 1)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (101, N'Alondra Chavez', 34, 1)
GO
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (102, N'Clara Sanchez', 28, 1)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (103, N'Belio Perez', 25, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (104, N'Guadalupe Torres', 45, 0)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (105, N'Liliana Aleman', 26, 1)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (106, N'Elizabeth Chavez', 34, 1)
INSERT [dbo].[Personas] ([idPersona], [Nombre], [Edad], [Genero]) VALUES (107, N'Alondra Martinez', 35, 1)
SET IDENTITY_INSERT [dbo].[Personas] OFF
USE [master]
GO
ALTER DATABASE [RegistroHabitantes] SET  READ_WRITE 
GO
