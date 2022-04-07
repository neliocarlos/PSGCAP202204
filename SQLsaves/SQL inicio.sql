--select * from funcionario;

--select matricula_funcionario as 'Matrícula',
--nome_funcionario as Nome,
--sobrenome_funcionario as Sobrenome
--from Funcionario;

--select matricula_funcionario as 'Matrícula',
--nome_funcionario + sobrenome_funcionario as 'Nome Completo'
--from Funcionario;

--select
--matricula_funcionario as 'Matrícula',
--trim(nome_funcionario) + ' ' + trim(sobrenome_funcionario) as 'Nome Completo'
--from Funcionario;

--Nunca faça uma clausula "select * from" sem usar o where
--O "where" por boa prática deve ser a chave primária

--select *
--from Funcionario
--where ID_Funcionário = 2;

--select
--matricula_funcionario as 'Matrícula',
--trim(nome_funcionario) + ' ' + trim(sobrenome_funcionario) as 'Nome Completo'
--from Funcionario
--where ID_Funcionário = 4;

select
matricula_funcionario as 'Matrícula',
trim(Nome_Funcionario) + ' ' + trim(Sobrenome_Funcionario) as 'Nome Completo'
from Funcionario
where (Matricula_Funcionario = 1) or (Matricula_Funcionario = 3);