--select * from Exercicio

---------------------------------------------------

--BETWEEN
--select * from Exercicio
--where (Idade_Exercicio between 23 and 25);

---------------------------------------------------

--MAIOR/MENOR/MAIOR-IGUAL/MENOR-IGUAL ( < , > , <= , >=)
--select * from Exercicio
--where (Idade_Exercicio >= 18);

---------------------------------------------------

--alter table Exercicio
--	alter column Nota_Exercicio decimal(7,2)
--go

---------------------------------------------------

--select * from Exercicio
--where Idade_Exercicio < 18;

--update Exercicio
--set Situacao = 0
--where Idade_Exercicio < 18;

---------------------------------------------------

--select * from Exercicio
--where Nota_Exercicio < 6;

--update Exercicio
--set Idade_Exercicio = 15
--where Nota_Exercicio < 6;

--------------------------------------------------

--select * from Exercicio

--alter table Exercicio
--	add Estado_Atual char(1) null default 'A'
--go

--update Exercicio
--set Estado_Atual = 'R'
--where Nota_Exercicio < 6;

--update Exercicio
--set Estado_Atual = 'A'
--where Nota_Exercicio >= 6;

--insert into Exercicio (Nome_Exercicio, Idade_Exercicio, Nota_Exercicio) values
--	('Teste 31', 33, 8.5),
--	('Teste 32', 18, 4.5)

