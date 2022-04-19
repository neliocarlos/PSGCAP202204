CREATE TABLE Forma_Envio (
	ID_Forma_Envio INT NOT NULL IDENTITY(1,1),
	Descricao_Forma_Envio VARCHAR(MAX) NOT NULL,
	Valor_Por_Kg_Forma_Envio DECIMAL(9,2) NOT NULL,
	Situacao BIT NULL DEFAULT 1,
	DataInclusao DATETIME NULL DEFAULT GETDATE(),
	DataAlteracao DATETIME NULL,
	DataExclusao DATETIME NULL
	CONSTRAINT PK_Forma_Envio PRIMARY KEY (ID_Forma_Envio)
)

CREATE TABLE Forma_Pagamento (
	ID_Forma_Pagamento INT NOT NULL,
	ID_Tipo_Forma_Pagamento INT NOT NULL,
	Descricao_Forma_Pagamento VARCHAR(MAX) NOT NULL,
	Situacao BIT NULL DEFAULT 1,
	DataInclusao DATETIME NULL DEFAULT GETDATE(),
	DataAlteracao DATETIME NULL,
	DataExclusao DATETIME NULL
	CONSTRAINT PK_Forma_Pagamento PRIMARY KEY (ID_Forma_Pagamento)
	CONSTRAINT FK_Forma_Pagamento_Tipo_Forma_Pagamento FOREIGN KEY (ID_Tipo_Forma_Pagamento)
		REFERENCES Tipo_Forma_Pagamento(ID_Tipo_Forma_Pagamento)
)

CREATE TABLE Tipo_Forma_Pagamento (
	ID_Tipo_Forma_Pagamento INT NOT NULL IDENTITY(1,1),
	Descricao_Tipo_Forma_Pagamento VARCHAR(MAX) NOT NULL,
	Situacao BIT NULL DEFAULT 1,
	DataInclusao DATETIME NULL DEFAULT GETDATE(),
	DataAlteracao DATETIME NULL,
	DataExclusao DATETIME NULL
	CONSTRAINT PK_Tipo_Forma_Pagamento PRIMARY KEY (ID_Tipo_Forma_Pagamento)
)



