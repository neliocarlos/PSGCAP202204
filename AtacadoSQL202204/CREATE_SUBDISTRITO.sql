CREATE TABLE SubDistrito (
	ID_SubDistrito int NOT NULL IDENTITY (1, 1),
	Descricao_SubDistrito varchar(MAX) NOT NULL,
	SiglaUF char(2) NOT NULL,
	Situacao BIT NULL DEFAULT 1,
	DataInclusao DATETIME NULL DEFAULT GETDATE(),
	DataAlteracao DATETIME NULL,
	DataExclusao DATETIME NULL
	CONSTRAINT PK_SubDistrito PRIMARY KEY (ID_SubDistrito)
)
GO


