INSERT INTO Funcionarios(ID_Funcionario,
						Matricula_Funcionario,
						Nome_Funcionario,
						Sobrenome_Funcionario,
						Sexo_Funcionario,
						Datanasc_Funcionario,
						Email_Funcionario,
						ID_Pais)
SELECT 
	funcid as ID,
	convert(varchar(50), chave) as 'Matrícula',
	convert(varchar(50), nome) as Nome,
	convert(varchar(50), sobrenome) as Sobrenome,
	convert(char(1), sexo) as Sexo,
	convert(datetime, datanascimento) as Nascimento,
	convert(varchar(50), email) as Email,
	convert(int, paisid) as 'ID do País'
	FROM RAW_DATA_Funcionarios_Dados_Pessoais
go

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

INSERT INTO  Funcionarios_Dados_Pessoais(
	ID_Funcionario, Matricula_Funcionario, Nome_Funcionario, Sobrenome_Funcionario, Sexo_Funcionario, Datanasc_Funcionario, Email_Funcionario, ID_Pais, Situacao, 
	DataInclusao, DataAlteracao, DataExclusao
)
SELECT 
	ID_Funcionario, CONVERT(BIGINT, Matricula_Funcionario) AS Matricula_Funcionario, Nome_Funcionario, Sobrenome_Funcionario, Sexo_Funcionario, Datanasc_Funcionario, 
	Email_Funcionario, ID_Pais, Situacao,DataInclusao, DataAlteracao, DataExclusao
FROM Funcionarios
GO



