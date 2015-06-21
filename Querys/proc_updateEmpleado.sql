
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE proc_updateEmpleado
	@id [int],
	@nombre [nvarchar](60),
	@edad [smallint],
	@idPuesto [int]
AS
BEGIN
	UPDATE Empleados SET nombre = @nombre, edad = @edad, idPuesto = @idPuesto
	WHERE idEmpleado = @id
END
GO
