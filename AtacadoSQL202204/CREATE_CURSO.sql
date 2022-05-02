CREATE TABLE Curso (
	ID_Curso int NOT NULL IDENTITY (1, 1),
	Descricao_Curso varchar(100),
	Situacao BIT NULL DEFAULT 1,
	DataInclusao DATETIME NULL DEFAULT GETDATE(),
	DataAlteracao DATETIME NULL,
	DataExclusao DATETIME NULL
	CONSTRAINT PK_Curso PRIMARY KEY (ID_Curso)
)
GO


