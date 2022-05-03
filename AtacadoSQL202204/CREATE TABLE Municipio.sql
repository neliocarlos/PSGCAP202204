CREATE TABLE Municipio (
	ID_Municipio INT NOT NULL IDENTITY(1, 1),
	Codigo_Ibge_6 BIGINT NOT NULL,
	Codigo_Ibge_7 BIGINT NOT NULL,
	Nome_Municipio VARCHAR(MAX) NOT NULL,
	ID_Mesoregiao INT NOT NULL,
	ID_Microregiao INT NOT NULL,
	ID_Unidade_Federacao INT NOT NULL,
	SiglaUF CHAR(2) NOT NULL,
	Populacao_Municipio BIGINT NOT NULL,
	Porte_Municipio VARCHAR(MAX) NOT NULL,
	Cep_Municipio INT NOT NULL,
	Situacao BIT NULL DEFAULT 1,
	DataInclusao DATETIME NULL DEFAULT GETDATE(),
	DataAlteracao DATETIME NULL,
	DataExclusao DATETIME NULL
	CONSTRAINT PK_Municipio PRIMARY KEY (ID_Municipio),
	CONSTRAINT FK_Mesoregiao_Municipio FOREIGN KEY (ID_Mesoregiao) REFERENCES Mesoregiao(ID_Mesoregiao),
	CONSTRAINT FK_Microregiao_Municipio FOREIGN KEY (ID_Microregiao) REFERENCES Microregiao(ID_Microregiao),
	CONSTRAINT FK_Unidade_Federacao_Municipio FOREIGN KEY (ID_Unidade_Federacao) REFERENCES Unidade_Federacao(ID_Unidade_Federacao),
	CONSTRAINT FK_SiglaUF_Municipio FOREIGN KEY (SiglaUF) REFERENCES Unidade_Federacao(SiglaUF)
	)
GO
