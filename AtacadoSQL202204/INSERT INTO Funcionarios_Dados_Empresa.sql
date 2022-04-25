INSERT INTO Funcionarios_Dados_Empresa(
Matricula_Funcionario, Nome_Funcionario, Sobrenome_Funcionario, Data_Admissao_Funcionario, Ctps_Funcionario, Ctps_Num_Funcionario, Ctps_Serie_Funcionario
)

SELECT        
	chave,
	nome, 
	sobrenome, 
	convert(datetime, dataadmissao) as Data_Admissao_Funcionario, 
	ctps, 
	ctpsnum, 
	ctpsserie
FROM RAW_DATA_Funcionarios_Dados_Empresa
