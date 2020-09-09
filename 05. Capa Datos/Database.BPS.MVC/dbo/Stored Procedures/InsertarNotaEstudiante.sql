CREATE PROCEDURE InsertarNotaEstudiante
(
@idNota BIGINT = NULL
,@idProfesor BIGINT 
,@idEstudiante BIGINT
,@nombre NVARCHAR(150)
,@valor NUMERIC(18,2)
)
AS
BEGIN
	IF(@idNota>0)
	BEGIN
		UPDATE Nota SET 
		[nombre] = @nombre,
		[valor] = @valor
		WHERE idNota = @idNota
	END
	ELSE
	BEGIN
		INSERT INTO [dbo].[Nota]
		([idProfesor], [idEstudiante], [nombre], [valor])
		VALUES
		(@idProfesor, @idEstudiante, @nombre, @valor)
	END
END