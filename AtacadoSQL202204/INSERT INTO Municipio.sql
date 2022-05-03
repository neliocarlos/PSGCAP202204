SET IDENTITY_INSERT Municipio ON

INSERT INTO Municipio(Codigo_Ibge_7, Codigo_Ibge_6, ID_Municipio, Nome_Municipio, ID_Mesoregiao, ID_Microregiao, ID_Unidade_Federacao, SiglaUF, Populacao_Municipio, Porte_Municipio, Cep_Municipio)
	SELECT MC.CodigoIBGE, MI.IBGE, MC.MunicipioID, MC.Nome, MC.MesoregiaoID, MC.MicroregiaoID, MC.UFID, MI.UF, MI.População_2010, MI.Porte, CI.CEP
		FROM RAW_DATA_Municipios_Complementar_IBGE_UTF8 AS MC INNER JOIN
			 RAW_DATA_Lista_de_MunicIpios_com_IBGE_Brasil_UTF8 AS MI ON MC.CodigoIBGE = MI.IBGE7 LEFT OUTER JOIN
			 RAW_DATA_Cidades_IBGE6_UTF8 AS CI ON MI.IBGE = CI.IBGE

SET IDENTITY_INSERT Municipio OFF
