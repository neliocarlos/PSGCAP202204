CREATE TABLE Pais (
	ID_Pais int NOT NULL IDENTITY (1, 1),
	Sigla_Pais char (3) NOT NULL ,
	Abreviacao_Idioma char(2) NOT NULL ,
	Descricao_Pais varchar(MAX) NOT NULL,
	Situacao BIT NULL DEFAULT 1,
	DataInclusao DATETIME NULL DEFAULT GETDATE(),
	DataAlteracao DATETIME NULL,
	DataExclusao DATETIME NULL
	CONSTRAINT PK_Pais PRIMARY KEY (ID_Pais) 
)
GO



