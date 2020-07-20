CREATE PROCEDURE [dbo].[spParceria_Insert]
	@titulo varchar(255),
	@Descricao text,
	@URLPagina varchar(1000) =  '',
	@Empresa varchar(40),
	@DataInicio date,
	@DataTermino date
AS
	INSERT INTO [dbo].[Parceria]
           ([Titulo]
           ,[Descricao]
           ,[URLPagina]
           ,[Empresa]
           ,[DataInicio]
           ,[DataTermino]
           ,[QtdLikes]
           ,[DataHoraCadastro])
     VALUES
           (@titulo
           ,@Descricao
           ,@URLPagina
           ,@Empresa
           ,@DataInicio
           ,@DataTermino
           ,0
           ,GETDATE())
RETURN 0