CREATE PROCEDURE [dbo].[spParceriaLike_Insert]
	@CodigoParceria int
AS
	INSERT INTO [dbo].[ParceriaLike]
           (
           [CodigoParceria]
           ,[DataHoraCadastro])
     VALUES
           (
           @CodigoParceria
           ,GETDATE())
RETURN 0
