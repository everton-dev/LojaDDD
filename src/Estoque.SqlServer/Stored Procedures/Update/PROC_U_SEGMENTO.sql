USE ESTOQUE
GO

IF OBJECT_ID('dbo.PROC_U_SEGMENTO') IS NOT NULL
BEGIN
	DROP PROCEDURE dbo.PROC_U_SEGMENTO
	PRINT '<< DROP PROCEDURE dbo.PROC_U_SEGMENTO >>'
END
GO

CREATE PROCEDURE dbo.PROC_U_SEGMENTO
	  @IdMarca					INT
	, @IdCategoria				INT
	, @IdSegmento				INT
	, @Descricao				VARCHAR(100)
	, @Ativo					BIT
	, @UsuarioCriacao			VARCHAR(50)
	, @DataCriacao				DATETIME
	, @UsuarioAtualizacao		VARCHAR(50)
	, @DataAtualizacao			DATETIME
AS
BEGIN
	UPDATE dbo.Segmento SET
		 Descricao = @Descricao
		, Ativo = @Ativo
		, UsuarioCriacao = @UsuarioCriacao
		, DataCriacao = @DataCriacao
		, UsuarioAtualizacao = @UsuarioAtualizacao
		, DataAtualizacao = @DataAtualizacao
	WHERE 
			IdMarca = @IdMarca
		AND IdCategoria = @IdCategoria
		AND IdSegmento = @IdSegmento
END
GO

IF OBJECT_ID('dbo.PROC_U_SEGMENTO') IS NOT NULL
BEGIN
	PRINT '<< CREATE PROCEDURE dbo.PROC_U_SEGMENTO >>'
END
GO