CREATE TABLE Distrito (
	ID_Distrito int NOT NULL IDENTITY (1, 1),
	Descricao_Distrito varchar(MAX) NOT NULL,
	SiglaUF char(2) NOT NULL,
	Situacao BIT NULL DEFAULT 1,
	DataInclusao DATETIME NULL DEFAULT GETDATE(),
	DataAlteracao DATETIME NULL,
	DataExclusao DATETIME NULL
	CONSTRAINT PK_Distrito PRIMARY KEY (ID_Distrito)
)
GO
