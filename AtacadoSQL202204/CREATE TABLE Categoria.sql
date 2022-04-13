CREATE TABLE Categoria (
	ID_Categoria INT NOT NULL IDENTITY(1,1),
	Descricao_Categoria VARCHAR(MAX) NOT NULL,
	Situacao BIT NULL DEFAULT 1,
	DataInclusao DATETIME NULL DEFAULT GETDATE(),
	CONSTRAINT PK_Categoria PRIMARY KEY (ID_Categoria)
)
GO
