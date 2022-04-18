create table Cartas (
	id_cartas int not null identity(1,1),
	nome_carta varchar(max) not null,
	tipo_carta varchar(max) not null,
	descricao_carta varchar(max) null,
	situacao bit null default 1,
	datainclusao datetime not null default getdate()
	constraint pk_cartas primary key (id_cartas)
	)
