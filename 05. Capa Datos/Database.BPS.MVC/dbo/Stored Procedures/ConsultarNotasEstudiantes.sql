CREATE PROCEDURE ConsultarNotasEstudiantes
AS
BEGIN
	SELECT N.idEstudiante, P.idProfesor, N.idNota, N.nombre AS NotaString, N.valor AS ValorNota, E.nombre AS NombreEstudiante, P.nombre AS NombreProfesor
	FROM Nota				N WITH (NOLOCK)
	INNER JOIN Profesor		P WITH (NOLOCK) ON N.idProfesor		= P.idProfesor
	INNER JOIN Estudiante	E WITH (NOLOCK) ON E.idEstudiante	= N.idEstudiante
END