--Criar tabela no Excel
--Salvar no formato UTF-8(.csv)
--Clicar no direito do Database e escolher a opção Tasks/Import Flat File 
--Configurar as colunas
 
 INSERT INTO Tabela (ID, Nome)
	SELECT ID, Nome FROM Tabela_Bruta
GO

--Importante as colunas serem do mesmo tipo (INT, VARCHAR(MAX), DATETIME, etc...)
