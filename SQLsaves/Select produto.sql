SELECT
	Produto.ID_Categoria,
	Categoria.Descricao_Categoria AS Categoria,
	Produto.ID_Subcategoria,
	Subcategoria.Descricao_Subcategoria AS Subcategoria,
	Produto.ID_Produto,
	Produto.Descricao_Produto AS Produto
FROM Produto
INNER JOIN Subcategoria ON Subcategoria.ID_Subcategoria = Produto.ID_Subcategoria
INNER JOIN Categoria ON Categoria.ID_Categoria = Produto.ID_Categoria
WHERE Produto.ID_Categoria = 1
GO
