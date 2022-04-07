--select * from funcionario;

--select matricula_funcionario as 'Matr�cula',
--nome_funcionario as Nome,
--sobrenome_funcionario as Sobrenome
--from Funcionario;

--select matricula_funcionario as 'Matr�cula',
--nome_funcionario + sobrenome_funcionario as 'Nome Completo'
--from Funcionario;

--select
--matricula_funcionario as 'Matr�cula',
--trim(nome_funcionario) + ' ' + trim(sobrenome_funcionario) as 'Nome Completo'
--from Funcionario;

--Nunca fa�a uma clausula "select * from" sem usar o where
--O "where" por boa pr�tica deve ser a chave prim�ria

--select *
--from Funcionario
--where ID_Funcion�rio = 2;

--select
--matricula_funcionario as 'Matr�cula',
--trim(nome_funcionario) + ' ' + trim(sobrenome_funcionario) as 'Nome Completo'
--from Funcionario
--where ID_Funcion�rio = 4;

select
matricula_funcionario as 'Matr�cula',
trim(Nome_Funcionario) + ' ' + trim(Sobrenome_Funcionario) as 'Nome Completo'
from Funcionario
where (Matricula_Funcionario = 1) or (Matricula_Funcionario = 3);