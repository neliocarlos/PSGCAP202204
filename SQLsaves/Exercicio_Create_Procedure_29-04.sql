CREATE PROCEDURE SP_SITUACAO_FUNCIONARIO
@SITUACAO CHAR(1)
AS
BEGIN	
		IF (@SITUACAO <> 'I') AND (@SITUACAO <> 'A')
		BEGIN
			PRINT 'INFORME UMA SITUAÇÃO VÁLIDA.'
		END
	ELSE
	BEGIN
		SELECT * FROM TABELA_FUNCIONARIO WHERE SITUACAO = @SITUACAO
	END
END
GO
