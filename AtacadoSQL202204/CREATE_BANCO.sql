CREATE TABLE Banco (
	ID_Banco int NOT NULL IDENTITY (1, 1),
	Codigo_Banco int NULL,
	Descricao_Banco varchar(MAX) NOT NULL,
	Site_Banco varchar(MAX),
	Situacao BIT NULL DEFAULT 1,
	DataInclusao DATETIME NULL DEFAULT GETDATE(),
	DataAlteracao DATETIME NULL,
	DataExclusao DATETIME NULL
	CONSTRAINT PK_Banco PRIMARY KEY (ID_Banco)
)
GO


