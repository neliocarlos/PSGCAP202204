CREATE TABLE Municipio (
	ID_Municipio int NOT NULL IDENTITY (1, 1),
	Descricao_Municipio varchar(MAX) NOT NULL,
	SiglaUF char(2) NOT NULL,
	Situacao BIT NULL DEFAULT 1,
	DataInclusao DATETIME NULL DEFAULT GETDATE(),
	DataAlteracao DATETIME NULL,
	DataExclusao DATETIME NULL
	CONSTRAINT PK_Municipio PRIMARY KEY (ID_Municipio),
	CONSTRAINT FK_SiglaUF_Municipio FOREIGN KEY (SiglaUF) REFERENCES Unidade_Federacao(SiglaUF)
)
GO
