USE ESTOQUE
GO

IF OBJECT_ID('dbo.PROC_U_PRODUTO') IS NOT NULL
BEGIN
	DROP PROCEDURE dbo.PROC_U_PRODUTO
	PRINT '<< DROP PROCEDURE dbo.PROC_U_PRODUTO >>'
END
GO

CREATE PROCEDURE dbo.PROC_U_PRODUTO
	  @IdMarca					INT
	, @IdCategoria				INT
	, @IdSegmento				INT
	, @IdCor					INT
	, @IdProduto				INT
	, @Descricao				VARCHAR(100)
	, @Ativo					BIT
	, @UsuarioCriacao			VARCHAR(50)
	, @DataCriacao				DATETIME
	, @UsuarioAtualizacao		VARCHAR(50)
	, @DataAtualizacao			DATETIME
AS
BEGIN
	UPDATE dbo.Produto SET
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
		AND IdCor = @IdCor
		AND IdProduto = @IdProduto
END
GO

IF OBJECT_ID('dbo.PROC_U_PRODUTO') IS NOT NULL
BEGIN
	PRINT '<< CREATE PROCEDURE dbo.PROC_U_PRODUTO >>'
END
GO