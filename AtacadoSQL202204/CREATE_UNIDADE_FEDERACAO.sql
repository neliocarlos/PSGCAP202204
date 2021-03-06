CREATE TABLE Unidade_Federacao (
	ID_Unidade_Federacao int NOT NULL IDENTITY (1, 1),
	Descricao_Unidade_Federacao varchar(MAX) NOT NULL ,
	SiglaUF char(2) NOT NULL ,
	Regiao_Brasil varchar (MAX) NOT NULL,
	Situacao BIT NULL DEFAULT 1,
	DataInclusao DATETIME NULL DEFAULT GETDATE(),
	DataAlteracao DATETIME NULL,
	DataExclusao DATETIME NULL
	CONSTRAINT PK_Unidade_Federacao PRIMARY KEY (ID_Unidade_Federacao)
)
GO

