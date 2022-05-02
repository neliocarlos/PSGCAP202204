CREATE TABLE Profissao (
	ID_Profissao int NOT NULL IDENTITY (1, 1),
	Descricao_Profissao varchar(MAX) NOT NULL,
	Situacao BIT NULL DEFAULT 1,
	DataInclusao DATETIME NULL DEFAULT GETDATE(),
	DataAlteracao DATETIME NULL,
	DataExclusao DATETIME NULL
	CONSTRAINT PK_Profissao PRIMARY KEY (ID_Profissao)
)
GO


