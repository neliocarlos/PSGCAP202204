CREATE TABLE Mesoregiao (
	ID_Mesoregiao int NOT NULL IDENTITY (1, 1),
	Descricao_Mesoregiao varchar(MAX) NOT NULL,
	SiglaUF char(2) NOT NULL,
	Situacao BIT NULL DEFAULT 1,
	DataInclusao DATETIME NULL DEFAULT GETDATE(),
	DataAlteracao DATETIME NULL,
	DataExclusao DATETIME NULL
	CONSTRAINT PK_Mesoregiao PRIMARY KEY (ID_Mesoregiao)
)
GO
