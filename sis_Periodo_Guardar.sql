USE [Nissei]
GO
/****** Object:  StoredProcedure [dbo].[sis_Periodo_Guardar]    Script Date: 25/03/2016 05:13:52 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sis_Periodo_Guardar]
	@nombre varchar(50)
AS
BEGIN
	SET NOCOUNT ON;

	BEGIN TRY
	insert into Periodo (nombre,fecharegistro,estado) values (@nombre,getdate(),1);
	select 1 as respuesta
	END TRY
	BEGIN CATCH
	END CATCH
   
   
END