USE [Colegio]
GO

/****** Object:  View [dbo].[vAlumoCursoAula]    Script Date: 27-Sep-18 12:56:36 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[vAlumoCursoAula]
AS
SELECT        dbo.Alumnos.Id AS AlumnoId, dbo.Alumnos.Nombre, dbo.Alumnos.Apellidos, dbo.Alumnos.FechaNacimiento, dbo.Alumnos.Email, dbo.Cursos.Descripcion AS Curso, dbo.Aulas.Descripcion AS Aula
FROM            dbo.Alumnos INNER JOIN
                         dbo.Cursos ON dbo.Alumnos.CursoId = dbo.Cursos.Id INNER JOIN
                         dbo.Aulas ON dbo.Cursos.AulaId = dbo.Aulas.Id
GO
