Create PROCEDURE [dbo].[sis_TipoEgreso_Guardar]
	@nombre varchar(50)
AS
BEGIN
	SET NOCOUNT ON;

	BEGIN TRY
	insert into TipoEgreso(nombre,fecharegistro,estado) values (@nombre,getdate(),1);
	select 1 as respuesta
	END TRY
	BEGIN CATCH
	END CATCH
   
   
END