CREATE TABLE [dbo].[Estudiante] (
    [idEstudiante] BIGINT         IDENTITY (1, 1) NOT NULL,
    [nombre]       NVARCHAR (150) NOT NULL,
    CONSTRAINT [PK_Estudiante] PRIMARY KEY CLUSTERED ([idEstudiante] ASC)
);

