GO
/****** Object:  Table [dbo].[Estudiante]    Script Date: 08/09/2020 16:28:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estudiante](
	[idEstudiante] [bigint] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_Estudiante] PRIMARY KEY CLUSTERED 
(
	[idEstudiante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nota]    Script Date: 08/09/2020 16:28:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nota](
	[idNota] [bigint] IDENTITY(1,1) NOT NULL,
	[idProfesor] [bigint] NOT NULL,
	[idEstudiante] [bigint] NOT NULL,
	[nombre] [nvarchar](150) NOT NULL,
	[valor] [numeric](18, 2) NOT NULL,
 CONSTRAINT [PK_Nota] PRIMARY KEY CLUSTERED 
(
	[idNota] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profesor]    Script Date: 08/09/2020 16:28:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profesor](
	[idProfesor] [bigint] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_Profesor] PRIMARY KEY CLUSTERED 
(
	[idProfesor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Estudiante] ON 

INSERT [dbo].[Estudiante] ([idEstudiante], [nombre]) VALUES (1, N'Carlos Celedón')
INSERT [dbo].[Estudiante] ([idEstudiante], [nombre]) VALUES (2, N'Celedon')
INSERT [dbo].[Estudiante] ([idEstudiante], [nombre]) VALUES (3, N'Carlos 024')
INSERT [dbo].[Estudiante] ([idEstudiante], [nombre]) VALUES (5, N'Luis')
INSERT [dbo].[Estudiante] ([idEstudiante], [nombre]) VALUES (6, N'Luis')
SET IDENTITY_INSERT [dbo].[Estudiante] OFF
GO
SET IDENTITY_INSERT [dbo].[Nota] ON 

INSERT [dbo].[Nota] ([idNota], [idProfesor], [idEstudiante], [nombre], [valor]) VALUES (0, 0, 1, N'Españo', CAST(10.00 AS Numeric(18, 2)))
INSERT [dbo].[Nota] ([idNota], [idProfesor], [idEstudiante], [nombre], [valor]) VALUES (2, 0, 1, N'string', CAST(0.00 AS Numeric(18, 2)))
INSERT [dbo].[Nota] ([idNota], [idProfesor], [idEstudiante], [nombre], [valor]) VALUES (3, 0, 1, N'Matematica', CAST(5.00 AS Numeric(18, 2)))
SET IDENTITY_INSERT [dbo].[Nota] OFF
GO
SET IDENTITY_INSERT [dbo].[Profesor] ON 

INSERT [dbo].[Profesor] ([idProfesor], [nombre]) VALUES (0, N'Profesora Naty 02')
INSERT [dbo].[Profesor] ([idProfesor], [nombre]) VALUES (1, N'Alberto Profe')
SET IDENTITY_INSERT [dbo].[Profesor] OFF
GO
ALTER TABLE [dbo].[Nota]  WITH CHECK ADD  CONSTRAINT [FK_Nota_Estudiante] FOREIGN KEY([idEstudiante])
REFERENCES [dbo].[Estudiante] ([idEstudiante])
GO
ALTER TABLE [dbo].[Nota] CHECK CONSTRAINT [FK_Nota_Estudiante]
GO
ALTER TABLE [dbo].[Nota]  WITH CHECK ADD  CONSTRAINT [FK_Nota_Profesor] FOREIGN KEY([idProfesor])
REFERENCES [dbo].[Profesor] ([idProfesor])
GO
ALTER TABLE [dbo].[Nota] CHECK CONSTRAINT [FK_Nota_Profesor]
GO
/****** Object:  StoredProcedure [dbo].[ConsultarNotasEstudiantes]    Script Date: 08/09/2020 16:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConsultarNotasEstudiantes]
AS
BEGIN
	SELECT N.idEstudiante, P.idProfesor, N.idNota, N.nombre AS NotaString, N.valor AS ValorNota, E.nombre AS NombreEstudiante, P.nombre AS NombreProfesor
	FROM Nota				N WITH (NOLOCK)
	INNER JOIN Profesor		P WITH (NOLOCK) ON N.idProfesor		= P.idProfesor
	INNER JOIN Estudiante	E WITH (NOLOCK) ON E.idEstudiante	= N.idEstudiante
END
GO
/****** Object:  StoredProcedure [dbo].[InsertarNotaEstudiante]    Script Date: 08/09/2020 16:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarNotaEstudiante]
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
GO
