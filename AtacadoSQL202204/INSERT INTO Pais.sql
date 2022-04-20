	insert into Pais (ID_Pais, Nome_Pais, Abrv_Pais)
		select 
			convert(int, paisid) as ID,
			convert(varchar, nome) as Nome,
			convert(char(2), abreviacao) as Sigla 
		from RAW_DATA_Pais
		order by ID
	go
