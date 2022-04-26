create procedure SP_Obter_Data
as
begin
declare @Data datetime
set @Data = getdate()
select 
	@Data as 'Data Atual',
	year(@Data) as 'Ano Atual',
	month(@Data) as 'Mês Atual',
	day(@Data) as 'Dia Atual',
	datepart(weekday, @Data) as 'Dia da Semana'
end;

---------------------------------------------------------

create procedure SP_Buscar_Funcionario_Por_Data_Admissao
@Ano int,
@Mes int,
@Dia int
as
begin
	select 
		ID_FuncDadosEmpresa,
		Matricula_Funcionario,
		Nome_Funcionario,
		Sobrenome_Funcionario,
		Data_Admissao_Funcionario,
		Ctps_Funcionario
	from Funcionario_Dados_Empresa
	where year(Data_Admissao_Funcionario) = @Ano
	and month(Data_Admissao_Funcionario) = @Mes
	and day(Data_Admissao_Funcionario) = @Dia
	order by Data_Admissao_Funcionario asc
end;

---------------------------------------------------------

CREATE PROCEDURE SP_Obter_Dados_Completos_Funcionario_Por_Matricula
@MATRICULA BIGINT
AS
BEGIN
	SELECT 
		FDP.ID_Funcionario, 
		FDP.Matricula_Funcionario, 
		FDP.Nome_Funcionario, 
		FDP.Sobrenome_Funcionario, 
		FDP.Sexo_Funcionario, 
		FDP.Datanasc_Funcionario, 
		FDP.Email_Funcionario, 
		FDP.ID_Pais, 
	    	FDE.Data_Admissao_Funcionario, 
		FDE.Ctps_Funcionario
	FROM Funcionario_Dados_Empresa AS FDE INNER JOIN
	     Funcionario_Dados_Pessoais AS FDP ON FDE.Matricula_Funcionario = FDP.Matricula_Funcionario
	WHERE (FDP.Situacao = 1)
		AND FDP.Matricula_Funcionario = @MATRICULA
END;

---------------------------------------------------------------------------------------------------

CREATE PROCEDURE SP_Obter_Dados_Completos_Funcionario_Por_Aniversario_E_Sexo
@ANIVERSARIO DATETIME,
@SEXO CHAR(1)
AS
BEGIN
	SELECT 
		FDP.ID_Funcionario, 
		FDP.Matricula_Funcionario, 
		FDP.Nome_Funcionario, 
		FDP.Sobrenome_Funcionario, 
		FDP.Sexo_Funcionario, 
		FDP.Datanasc_Funcionario, 
		FDP.Email_Funcionario, 
		FDP.ID_Pais, 
		FDE.Data_Admissao_Funcionario, 
		FDE.Ctps_Funcionario
	FROM Funcionario_Dados_Empresa AS FDE INNER JOIN
		 Funcionario_Dados_Pessoais AS FDP ON FDE.Matricula_Funcionario = FDP.Matricula_Funcionario
	WHERE (FDP.Situacao = 1)
		AND FDP.Datanasc_Funcionario = @ANIVERSARIO
		AND FDP.Sexo_Funcionario = @SEXO
	ORDER BY FDP.ID_Funcionario
END;
