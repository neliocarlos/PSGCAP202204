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

