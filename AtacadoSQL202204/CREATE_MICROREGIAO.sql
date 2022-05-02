CREATE TABLE Microregiao (
	ID_Microregiao int NOT NULL IDENTITY (1, 1),
	Descricao_Microregiao varchar(MAX) NOT NULL,
	SiglaUF char(2) NOT NULL,
	Situacao BIT NULL DEFAULT 1,
	DataInclusao DATETIME NULL DEFAULT GETDATE(),
	DataAlteracao DATETIME NULL,
	DataExclusao DATETIME NULL
	CONSTRAINT PK_Microregiao PRIMARY KEY (ID_Microregiao)
)
GO
