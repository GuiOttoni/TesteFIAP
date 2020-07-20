CREATE PROCEDURE [dbo].[spParceria_Update]
	@Codigo int,
	@titulo varchar(255),
	@Descricao text,
	@URLPagina varchar(1000) =  '',
	@Empresa varchar(40),
	@DataInicio date,
	@DataTermino date
AS
	UPDATE [dbo].[Parceria]
   SET 
       [Titulo] = @Titulo
      ,[Descricao] = @Descricao
      ,[URLPagina] = @URLPagina
      ,[Empresa] = @Empresa
      ,[DataInicio] = @DataInicio
      ,[DataTermino] = @DataTermino
 WHERE Codigo = @Codigo
RETURN 0
