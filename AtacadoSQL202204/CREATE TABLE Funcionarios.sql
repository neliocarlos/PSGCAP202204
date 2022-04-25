CREATE TABLE Funcionarios(
	ID_Funcionario bigint NOT NULL,
	Matricula_Funcionario varchar(50) NOT NULL,
	Nome_Funcionario varchar(50) NOT NULL,
	Sobrenome_Funcionario varchar(50) NOT NULL,
	Sexo_Funcionario char(1) NOT NULL,
	Datanasc_Funcionario datetime NOT NULL,
	Email_Funcionario nvarchar(50) NOT NULL,
	ID_Pais int NOT NULL,
	Situacao bit NULL DEFAULT 1,
	DataInclusao datetime NULL DEFAULT GETDATE(),
	DataAlteracao datetime NULL,
	DataExclusao datetime NULL
	CONSTRAINT PK_Funcionario PRIMARY KEY (ID_Funcionario)
	CONSTRAINT FK_Pais_Funcionario FOREIGN KEY (ID_Pais) REFERENCES Pais(ID_Pais) 
)
GO


CREATE TABLE Funcionarios_Dados_Pessoais(
	ID_Funcionario bigint NOT NULL,
	Matricula_Funcionario bigint NOT NULL,
	Nome_Funcionario varchar(50) NOT NULL,
	Sobrenome_Funcionario varchar(50) NOT NULL,
	Sexo_Funcionario char(1) NOT NULL,
	Datanasc_Funcionario datetime NOT NULL,
	Email_Funcionario varchar(MAX) NOT NULL,
	ID_Pais int NOT NULL,
	Situacao bit NULL DEFAULT 1,
	DataInclusao datetime NULL DEFAULT getdate(),
	DataAlteracao datetime NULL,
	DataExclusao datetime NULL
	CONSTRAINT PK_FuncDadosPessoais PRIMARY KEY (ID_Funcionario)
)
GO 
