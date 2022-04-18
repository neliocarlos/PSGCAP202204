create table Decks (
	id_decks int not null identity(1,1),
	codigo_deck varchar(max) not null,
	situacao bit null default 1,
	datainclusao datetime not null default getdate(),
	constraint pk_decks primary key (id_decks)
	)