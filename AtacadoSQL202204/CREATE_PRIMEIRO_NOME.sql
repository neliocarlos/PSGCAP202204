CREATE TABLE Primeiro_Nome (
	ID_Primeiro_Nome int NOT NULL IDENTITY (1, 1),
	Primeiro_Nome varchar(MAX) NOT NULL,
	Sexo_Primeiro_Nome char(1) NOT NULL,
	Situacao BIT NULL DEFAULT 1,
	DataInclusao DATETIME NULL DEFAULT GETDATE(),
	DataAlteracao DATETIME NULL,
	DataExclusao DATETIME NULL
	CONSTRAINT PK_Primeiro_Nome PRIMARY KEY (ID_Primeiro_Nome)
)
GO
