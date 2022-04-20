insert into Departamentos(ID_Depto, Nome_Depto)
		select deptoid, nome from RAW_DATA_Departamentos
	go
