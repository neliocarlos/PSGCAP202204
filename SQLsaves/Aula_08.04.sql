--EXERCÍCIO 1:
--SELECT * FROM Subcategoria 
--WHERE ID_Categoria = 5;

--------------------------------------------------------

--EXERCÍCIO 2:
--SELECT 
--ID_Subcategoria,
--ID_Categoria,
--Descricao_Subcategoria
--FROM Subcategoria
--WHERE ID_Categoria = 8;

--------------------------------------------------------

--EXERCÍCIO 3:
--SELECT Descricao_Subcategoria 
--FROM Subcategoria
--WHERE (ID_Categoria = 12) AND (ID_Subcategoria = 72);

--------------------------------------------------------

--EXERCÍCIO 4:
--SELECT ID_Subcategoria AS Subcategoria, ID_Categoria AS Categoria, Descricao_Subcategoria AS Descrição
--FROM Subcategoria
--WHERE (ID_Categoria = 10) OR (ID_Categoria = 15);

--------------------------------------------------------

--EXERCÍCIO 5:
--SELECT 
--	Subcategoria.ID_Categoria,
--	Categoria.Descricao_Categoria,
--	Subcategoria.ID_Subcategoria,
--	Subcategoria.Descricao_Subcategoria
--FROM Subcategoria
--INNER JOIN Categoria ON Categoria.ID_Categoria = Subcategoria.ID_Categoria
--WHERE Subcategoria.ID_Categoria = 5;

--------------------------------------------------------
