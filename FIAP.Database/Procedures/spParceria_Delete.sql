CREATE PROCEDURE [dbo].[spParceria_Delete]
	@Codigo int
AS
	DELETE FROM [dbo].[Parceria] WHERE Codigo = @Codigo
RETURN 0
