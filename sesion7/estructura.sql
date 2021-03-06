USE [Colegio]
GO
ALTER TABLE [dbo].[Profesor] DROP CONSTRAINT [FK_Profesor_Cursos]
GO
ALTER TABLE [dbo].[Cursos] DROP CONSTRAINT [FK_Cursos_Aulas]
GO
ALTER TABLE [dbo].[Alumnos] DROP CONSTRAINT [FK_Alumnos_Cursos]
GO
/****** Object:  Table [dbo].[Profesor]    Script Date: 27-Sep-18 7:07:23 AM ******/
DROP TABLE [dbo].[Profesor]
GO
/****** Object:  Table [dbo].[Cursos]    Script Date: 27-Sep-18 7:07:23 AM ******/
DROP TABLE [dbo].[Cursos]
GO
/****** Object:  Table [dbo].[Aulas]    Script Date: 27-Sep-18 7:07:23 AM ******/
DROP TABLE [dbo].[Aulas]
GO
/****** Object:  Table [dbo].[Alumnos]    Script Date: 27-Sep-18 7:07:23 AM ******/
DROP TABLE [dbo].[Alumnos]
GO
/****** Object:  Table [dbo].[Alumnos]    Script Date: 27-Sep-18 7:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumnos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](250) NOT NULL,
	[Apellidos] [nvarchar](250) NOT NULL,
	[FechaNacimiento] [date] NULL,
	[Email] [nvarchar](250) NULL,
	[CursoId] [int] NOT NULL,
 CONSTRAINT [PK_Alumno] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Aulas]    Script Date: 27-Sep-18 7:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aulas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nchar](250) NULL,
 CONSTRAINT [PK_Aulas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cursos]    Script Date: 27-Sep-18 7:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cursos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nchar](250) NULL,
	[AulaId] [int] NULL,
 CONSTRAINT [PK_Cursos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profesor]    Script Date: 27-Sep-18 7:07:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profesor](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nchar](250) NULL,
	[Apellidos] [nchar](250) NULL,
	[CursoId] [int] NOT NULL,
 CONSTRAINT [PK_Profesor] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Alumnos] ON 
GO
INSERT [dbo].[Alumnos] ([Id], [Nombre], [Apellidos], [FechaNacimiento], [Email], [CursoId]) VALUES (1, N'Juanito', N'Valderrama Ordoñez', CAST(N'1980-10-10' AS Date), N'juanito@valderrama.com', 1)
GO
INSERT [dbo].[Alumnos] ([Id], [Nombre], [Apellidos], [FechaNacimiento], [Email], [CursoId]) VALUES (2, N'Juliana', N'Serranito con Pimiento', CAST(N'1983-01-10' AS Date), N'elserrano@gmail.com', 2)
GO
INSERT [dbo].[Alumnos] ([Id], [Nombre], [Apellidos], [FechaNacimiento], [Email], [CursoId]) VALUES (3, N'Paco', N'Franqui BajaelMonte', CAST(N'2013-02-02' AS Date), N'franqui@descarga.com', 2)
GO
SET IDENTITY_INSERT [dbo].[Alumnos] OFF
GO
SET IDENTITY_INSERT [dbo].[Aulas] ON 
GO
INSERT [dbo].[Aulas] ([Id], [Descripcion]) VALUES (1, N'Aula de Musica                                                                                                                                                                                                                                            ')
GO
INSERT [dbo].[Aulas] ([Id], [Descripcion]) VALUES (2, N'Aula de Matematicas                                                                                                                                                                                                                                       ')
GO
INSERT [dbo].[Aulas] ([Id], [Descripcion]) VALUES (3, N'Aula de Psicomotricidad                                                                                                                                                                                                                                   ')
GO
INSERT [dbo].[Aulas] ([Id], [Descripcion]) VALUES (4, N'Laboratorio de Quimica                                                                                                                                                                                                                                    ')
GO
SET IDENTITY_INSERT [dbo].[Aulas] OFF
GO
SET IDENTITY_INSERT [dbo].[Cursos] ON 
GO
INSERT [dbo].[Cursos] ([Id], [Descripcion], [AulaId]) VALUES (1, N'P3                                                                                                                                                                                                                                                        ', 1)
GO
INSERT [dbo].[Cursos] ([Id], [Descripcion], [AulaId]) VALUES (2, N'P4                                                                                                                                                                                                                                                        ', 2)
GO
INSERT [dbo].[Cursos] ([Id], [Descripcion], [AulaId]) VALUES (3, N'P5                                                                                                                                                                                                                                                        ', 3)
GO
SET IDENTITY_INSERT [dbo].[Cursos] OFF
GO
SET IDENTITY_INSERT [dbo].[Profesor] ON 
GO
INSERT [dbo].[Profesor] ([Id], [Nombre], [Apellidos], [CursoId]) VALUES (1, N'Jose Manuel                                                                                                                                                                                                                                               ', N'Corral Céspedes                                                                                                                                                                                                                                           ', 1)
GO
INSERT [dbo].[Profesor] ([Id], [Nombre], [Apellidos], [CursoId]) VALUES (2, N'Anastasio                                                                                                                                                                                                                                                 ', N'Feliciano Salvatore                                                                                                                                                                                                                                       ', 2)
GO
INSERT [dbo].[Profesor] ([Id], [Nombre], [Apellidos], [CursoId]) VALUES (3, N'Juana                                                                                                                                                                                                                                                     ', N'del Arco Martinez                                                                                                                                                                                                                                         ', 3)
GO
SET IDENTITY_INSERT [dbo].[Profesor] OFF
GO
ALTER TABLE [dbo].[Alumnos]  WITH CHECK ADD  CONSTRAINT [FK_Alumnos_Cursos] FOREIGN KEY([CursoId])
REFERENCES [dbo].[Cursos] ([Id])
GO
ALTER TABLE [dbo].[Alumnos] CHECK CONSTRAINT [FK_Alumnos_Cursos]
GO
ALTER TABLE [dbo].[Cursos]  WITH CHECK ADD  CONSTRAINT [FK_Cursos_Aulas] FOREIGN KEY([AulaId])
REFERENCES [dbo].[Aulas] ([Id])
GO
ALTER TABLE [dbo].[Cursos] CHECK CONSTRAINT [FK_Cursos_Aulas]
GO
ALTER TABLE [dbo].[Profesor]  WITH CHECK ADD  CONSTRAINT [FK_Profesor_Cursos] FOREIGN KEY([CursoId])
REFERENCES [dbo].[Cursos] ([Id])
GO
ALTER TABLE [dbo].[Profesor] CHECK CONSTRAINT [FK_Profesor_Cursos]
GO
