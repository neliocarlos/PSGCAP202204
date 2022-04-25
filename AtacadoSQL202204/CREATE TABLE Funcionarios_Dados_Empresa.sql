CREATE TABLE Funcionarios_Dados_Empresa(
	ID_FuncDadosEmpresa BIGINT NOT NULL IDENTITY(1,1),
	Matricula_Funcionario BIGINT NOT NULL,
	Nome_Funcionario varchar(50) NOT NULL,
	Sobrenome_Funcionario varchar(50) NOT NULL,
	Data_Admissao_Funcionario datetime NOT NULL,
	Ctps_Funcionario varchar(50) NOT NULL,
	Ctps_Num_Funcionario bigint NOT NULL,
	Ctps_Serie_Funcionario int NOT NULL,
	Situacao BIT NULL DEFAULT 1,
	DataInclusao DATETIME NULL DEFAULT GETDATE(),
	DataAlteracao DATETIME NULL,
	DataExlusao DATETIME NULL
	CONSTRAINT PK_FuncDadosEmpresa PRIMARY KEY (ID_FuncDadosEmpresa)
)
GO
