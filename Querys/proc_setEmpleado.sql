
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE proc_setEmpleado
	@nombre [nvarchar](60),
	@edad [smallint],
	@idPuesto [int]

AS
BEGIN
	INSERT INTO Empleados (nombre, edad, idPuesto) VALUES (@nombre, @edad, @idPuesto)
END
GO
