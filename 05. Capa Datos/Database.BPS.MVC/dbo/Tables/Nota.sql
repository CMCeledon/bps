CREATE TABLE [dbo].[Nota] (
    [idNota]       BIGINT          IDENTITY (1, 1) NOT NULL,
    [idProfesor]   BIGINT          NOT NULL,
    [idEstudiante] BIGINT          NOT NULL,
    [nombre]       NVARCHAR (150)  NOT NULL,
    [valor]        NUMERIC (18, 2) NOT NULL,
    CONSTRAINT [PK_Nota] PRIMARY KEY CLUSTERED ([idNota] ASC),
    CONSTRAINT [FK_Nota_Estudiante] FOREIGN KEY ([idEstudiante]) REFERENCES [dbo].[Estudiante] ([idEstudiante]),
    CONSTRAINT [FK_Nota_Profesor] FOREIGN KEY ([idProfesor]) REFERENCES [dbo].[Profesor] ([idProfesor])
);

