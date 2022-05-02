CREATE TABLE Idioma (
	ID_Idioma int NOT NULL IDENTITY (1, 1),
	Abreviacao_Idioma char(2) NOT NULL,
	Descricao_Idioma varchar(MAX) NOT NULL,
	Situacao BIT NULL DEFAULT 1,
	DataInclusao DATETIME NULL DEFAULT GETDATE(),
	DataAlteracao DATETIME NULL,
	DataExclusao DATETIME NULL
	CONSTRAINT PK_Idioma PRIMARY KEY (ID_Idioma)
)
GO


