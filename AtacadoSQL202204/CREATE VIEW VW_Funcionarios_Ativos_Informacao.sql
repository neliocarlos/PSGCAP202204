CREATE VIEW VW_Funcionarios_Ativos_Informacao AS
SELECT        
	FDP.ID_Funcionario, 
	FDP.Matricula_Funcionario,
	FDP.Nome_Funcionario, 
	FDP.Sobrenome_Funcionario,
	FDE.Data_Admissao_Funcionario, 
	FDE.Ctps_Funcionario, 
	FDP.Sexo_Funcionario, 
	FDP.Datanasc_Funcionario, 
    FDP.Email_Funcionario
FROM Funcionario_Dados_Empresa AS FDE INNER JOIN
     Funcionario_Dados_Pessoais AS FDP ON FDE.Matricula_Funcionario = FDP.Matricula_Funcionario
WHERE (FDP.Situacao = 1)
