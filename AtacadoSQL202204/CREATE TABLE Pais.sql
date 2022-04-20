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
