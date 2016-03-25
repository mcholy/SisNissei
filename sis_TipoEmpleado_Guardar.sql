USE [Nissei]
GO
/****** Object:  StoredProcedure [dbo].[sis_TipoEmpleado_Guardar]    Script Date: 25/03/2016 02:58:46 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sis_TipoEmpleado_Guardar]
	@nombre varchar(50),
	@porcentajemensual decimal(3,2),
	@porcentajematricula decimal(3,2)
AS
BEGIN
	SET NOCOUNT ON;

	BEGIN TRY
	insert into TipoEmpleado(nombre,porcentajemensual,porcentajematricula,fecharegistro,estado) values (@nombre,@porcentajemensual,@porcentajematricula,getdate(),1);
	select 1 as respuesta
	END TRY
	BEGIN CATCH
	END CATCH
   
   
END
