create table Novo_Deck (
	id_novo_deck int not null identity(1,1),
	id_carta int not null,
	qtd_carta int not null,
	situacao bit null default 1,
	datainclusao datetime not null default getdate()
	constraint pk_novo_deck primary key (id_novo_deck)
	constraint fk_novo_deck_cartas foreign key (id_carta)
		references Cartas(id_carta)
	)
