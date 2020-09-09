CREATE TABLE [dbo].[Profesor] (
    [idProfesor] BIGINT         IDENTITY (1, 1) NOT NULL,
    [nombre]     NVARCHAR (150) NOT NULL,
    CONSTRAINT [PK_Profesor] PRIMARY KEY CLUSTERED ([idProfesor] ASC)
);

