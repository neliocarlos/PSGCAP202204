CREATE TABLE Area_Conhecimento (
	ID_Area_Conhecimento INT NOT NULL IDENTITY (1, 1),
	Descricao_Area_Conhecimento VARCHAR(MAX) NOT NULL,
	Situacao BIT NULL DEFAULT 1,
	DataInclusao DATETIME NULL DEFAULT GETDATE(),
	DataAlteracao DATETIME NULL,
	DataExclusao DATETIME NULL
	CONSTRAINT PK_Area_Conhecimento PRIMARY KEY (ID_Area_Conhecimento)
)
GO


