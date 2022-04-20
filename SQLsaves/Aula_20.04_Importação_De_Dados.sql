-- Importação de dados - Passo a passo

-- EXERCICIO 1:

-- 1 - Importar os dados do arquivo csv para o SQL server (Importação flat file - arquivo simples).

-- 2 - Criar a tabela para organizar os dados (utilizar padronização da equipe e campos de controle)
-- Exemplo:
	create table Departamentos (
	ID_Depto int not null,
	Nome_Depto varchar(50) not null,
	Situacao bit null default 1,
	DataInclusao DATETIME NULL DEFAULT GETDATE(),
	DataAlteracao DATETIME NULL,
	DataExclusao DATETIME NULL
	constraint PK_Depto primary key (ID_Depto)
	)
	go

-- 3 - Inserir os dados realizando qualquer tratamento necessário.
-- Exemplo:
	insert into Departamentos(ID_Depto, Nome_Depto)
		select deptoid, nome from RAW_DATA_Departamentos
	go

-----------------------------------------------------------------------------------------------------------

-- EXERCICIO 2

-- 1 - Importar RAW DATA Pais.csv para tabela RAW_DATA_Pais

-- 2 - Criar a tabela Pais
-- Exemplo:
	create table Pais (
	ID_Pais int not null,
	Nome_Pais varchar(50) not null,
	Abrv_Pais char(2) not null,
	Situacao bit NULL default 1,
	DataInclusao datetime NULL default GETDATE(),
	DataAlteracao datetime NULL,
	DataExclusao datetime NULL
	constraint PK_Pais primary key (ID_Pais)
	)
	go

-- 3 - Tratar e importar os dados 	
	insert into Pais (ID_Pais, Nome_Pais, Abrv_Pais)
		select 
			convert(int, paisid) as ID,
			convert(varchar, nome) as Nome,
			convert(char(2), abreviacao) as Sigla 
		from RAW_DATA_Pais
		order by ID
	go

-------------------------------------------------------------------------

-- OBSERVAÇÕES:
-- DDL - Data Design Language - Estrutura das tabelas (CREATE TABLE, ALTER TABLE, DROP TABLE)
-- DML - Data Manipulate Language - Manipulação dos dados (INSERT INTO, UPDATE TABLE, DELETE)
-- DQL - Data Quarry Language - Consulta dos dados (SELECT)
