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
