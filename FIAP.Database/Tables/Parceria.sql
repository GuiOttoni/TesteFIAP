CREATE TABLE [dbo].[Parceria]
(
	[Codigo] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Titulo] VARCHAR(255) NOT NULL, 
    [Descricao] TEXT NOT NULL, 
    [URLPagina] VARCHAR(1000) NULL, 
    [Empresa] VARCHAR(40) NOT NULL, 
    [DataInicio] DATE NOT NULL, 
    [DataTermino] DATE NOT NULL, 
    [QtdLikes] INT NOT NULL, 
    [DataHoraCadastro] DATETIME NOT NULL
)
