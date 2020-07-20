CREATE TABLE [dbo].[ParceriaLike]
(
	[Codigo] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CodigoParceria] INT NOT NULL, 
    [DataHoraCadastro] NCHAR(10) NULL, 
    CONSTRAINT [FK_ParceriaLike_Parceria] FOREIGN KEY (CodigoParceria) REFERENCES Parceria(Codigo)
)
