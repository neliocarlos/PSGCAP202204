CREATE TABLE Tipo_Logradouro (
	ID_Tipo_Logradouro int NOT NULL IDENTITY (1, 1),
	Descricao_Logradouro varchar(MAX) NOT NULL,
	Situacao BIT NULL DEFAULT 1,
	DataInclusao DATETIME NULL DEFAULT GETDATE(),
	DataAlteracao DATETIME NULL,
	DataExclusao DATETIME NULL
	CONSTRAINT PK_Tipo_Logradouro PRIMARY KEY (ID_Tipo_Logradouro)
)
GO


