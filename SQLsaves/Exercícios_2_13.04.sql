--EXERCÍCIO 1
--SELECT 
--	Produto.ID_Categoria AS 'Código da Categoria',
--	Categoria.Descricao_Categoria AS 'Categoria',
--	Produto.ID_Subcategoria AS 'Código da Subcategoria',
--	Subcategoria.Descricao_Subcategoria AS 'Subcategoria',
--	Produto.ID_Produto AS 'Código do Produto',
--	Produto.Descricao_Produto AS 'Produto'
--FROM Produto
--INNER JOIN Subcategoria ON Subcategoria.ID_Subcategoria = Produto.ID_Subcategoria
--INNER JOIN Categoria ON Categoria.ID_Categoria = Produto.ID_Categoria
--GO

------------------------------------------------------------------------------------------------------------------

--EXERCÍCIO 2
--SELECT 
--	Produto.ID_Categoria AS 'Código da Categoria',
--	Categoria.Descricao_Categoria AS 'Categoria',
--	Produto.ID_Subcategoria AS 'Código da Subcategoria',
--	Subcategoria.Descricao_Subcategoria AS 'Subcategoria',
--	Produto.ID_Produto AS 'Código do Produto',
--	Produto.Descricao_Produto AS 'Produto'
--FROM Produto
--INNER JOIN Subcategoria ON Subcategoria.ID_Subcategoria = Produto.ID_Subcategoria
--INNER JOIN Categoria ON Categoria.ID_Categoria = Produto.ID_Categoria
--WHERE Produto.Descricao_Produto LIKE 'GIM%';

------------------------------------------------------------------------------------------------------------------

--EXERCÍCIO 3
--SELECT 
--	Produto.ID_Categoria AS 'Código da Categoria',
--	Categoria.Descricao_Categoria AS 'Categoria',
--	Produto.ID_Subcategoria AS 'Código da Subcategoria',
--	Subcategoria.Descricao_Subcategoria AS 'Subcategoria',
--	Produto.ID_Produto AS 'Código do Produto',
--	Produto.Descricao_Produto AS 'Produto'
--FROM Produto
--INNER JOIN Subcategoria ON Subcategoria.ID_Subcategoria = Produto.ID_Subcategoria
--INNER JOIN Categoria ON Categoria.ID_Categoria = Produto.ID_Categoria
--WHERE (Subcategoria.Descricao_Subcategoria LIKE 'SUCO%') AND (Produto.Descricao_Produto LIKE '%MAGUARY%');

------------------------------------------------------------------------------------------------------------------

--EXERCÍCIO 3.1
--SELECT 
--	PRO.ID_Categoria AS 'Código da Categoria',
--	CAT.Descricao_Categoria AS 'Categoria',
--	PRO.ID_Subcategoria AS 'Código da Subcategoria',
--	SUB.Descricao_Subcategoria AS 'Subcategoria',
--	PRO.ID_Produto AS 'Código do Produto',
--	PRO.Descricao_Produto AS 'Produto'
--FROM Produto AS PRO
--INNER JOIN Subcategoria AS SUB ON SUB.ID_Subcategoria = PRO.ID_Subcategoria
--INNER JOIN Categoria AS CAT ON CAT.ID_Categoria = PRO.ID_Categoria
--WHERE (SUB.Descricao_Subcategoria LIKE 'SUCO%') AND (PRO.Descricao_Produto LIKE '%MAGUARY%');

------------------------------------------------------------------------------------------------------------------

--EXEMPLOS
--SELECT COUNT(*) AS 'Quantidade de Produto' FROM Produto

--SELECT TOP 10 * FROM Produto

--SELECT ID_Produto, ID_Subcategoria, ID_Categoria, Descricao_Produto, Situacao, DataInclusao
--FROM Produto
--ORDER BY Descricao_Produto

--SELECT ID_Produto, ID_Subcategoria, ID_Categoria, Descricao_Produto, Situacao, DataInclusao
--FROM Produto
--WHERE (ID_Categoria = 13) AND (Descricao_Produto LIKE '%SECA%')
--ORDER BY Descricao_Produto
--GO

--PROBLEMA PARA RESOLVER DEPOIS
--SELECT COUNT(*) AS 'Quantidade'
--FROM Produto
--ORDER BY Descricao_Produto

------------------------------------------------------------------------------------------------------------------

--EXERCÍCIO 4
--SELECT 
--	CAT.Descricao_Categoria AS 'Categoria',
--	SUB.Descricao_Subcategoria AS 'Subcategoria',
--	PRO.Descricao_Produto AS 'Produto'
--FROM Produto AS PRO
--INNER JOIN Subcategoria AS SUB ON SUB.ID_Subcategoria = PRO.ID_Subcategoria
--INNER JOIN Categoria AS CAT ON CAT.ID_Categoria = PRO.ID_Categoria
--WHERE (PRO.ID_Categoria = 3) AND (SUB.Descricao_Subcategoria LIKE '%REFRESCO%') AND (PRO.Descricao_Produto LIKE '%TANG%');

--SELECT COUNT(*) AS 'Quantidade de Itens'
--FROM Produto AS PRO
--INNER JOIN Subcategoria AS SUB ON SUB.ID_Subcategoria = PRO.ID_Subcategoria
--INNER JOIN Categoria AS CAT ON CAT.ID_Categoria = PRO.ID_Categoria
--WHERE (PRO.ID_Categoria = 3) AND (SUB.Descricao_Subcategoria LIKE '%REFRESCO%') AND (PRO.Descricao_Produto LIKE '%TANG%');


--AS pode ser usado para definir um apelido para praticamente qualquer coisa
--Na busca por palavras, usar LIKE como ferramenta para definir isso e colocar a palavra entre ' '
--Para definir se a busca pela palavra é contida ou começa com ela, definir com o uso de "%", sendo apenas % no final da palavra para
--buscar palavras que começam com a definição, EX:'Palavra%'. Se o caso for buscar palavras contidas, usar a definição entre "%". EX: '%Palavra%'
--ORDER BY: Organiza da forma que você quer. Deve ser a última definição do código.
