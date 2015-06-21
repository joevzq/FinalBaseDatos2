
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE proc_getDatosEmpleado
	@id[int]
AS
BEGIN

	SELECT nombre, idPuesto, edad FROM Empleados WHERE idEmpleado = @id
END
GO
