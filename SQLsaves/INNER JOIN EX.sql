SELECT 
	Subcategoria.ID_Subcategoria,
	Subcategoria.Descricao_Subcategoria AS Subcategoria,
	Subcategoria.ID_Categoria,
	Categoria.Descricao_Categoria AS Categoria,
	Categoria.DataInclusao
FROM Subcategoria
INNER JOIN Categoria ON Categoria.ID_Categoria = Subcategoria.ID_Categoria;
