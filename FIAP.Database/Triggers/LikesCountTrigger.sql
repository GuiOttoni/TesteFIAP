CREATE TRIGGER [LikesCountTrigger]
ON [ParceriaLike]
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON;
	with CTE as(
select count(*) as Qtd, 
	   CodigoParceria 
from ParceriaLike
group by CodigoParceria)
update P
set P.QtdLikes = T.Qtd
From Parceria as P
inner join CTE as T on T.CodigoParceria = P.Codigo
END
