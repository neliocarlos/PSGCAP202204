--create table Colaborador (
--	ID_Colaborador int not null identity(1,1) primary key,
--	Nome_Colaborador varchar(max) not null
--)

---------------------------------------------------------------

--alter table Colaborador
--	add 
--		Situacao bit null default 1,
--		DataInclusao datetime null default getdate()
--go

---------------------------------------------------------------

--alter table Colaborador
--	add
--		Cpf_Colaborador char(14) not null,
--		Sobrenome_Colaborador varchar(max) not null,
--		Endereco_Colaborador varchar(max) not null,
--		Telefone_Colaborador char(14) not null,
--		Email_Colaborador varchar(max) null
--go

---------------------------------------------------------------

--alter table Colaborador
--	alter column 
--		Telefone_Colaborador varchar(max) null
--go

---------------------------------------------------------------

--alter table Colaborador
--	add
--		Item_Produto varchar(max) not null
--go

---------------------------------------------------------------

--alter table Colaborador
--	drop column
--		Item_Produto
--go

---------------------------------------------------------------

--drop table Colaborador
--go
