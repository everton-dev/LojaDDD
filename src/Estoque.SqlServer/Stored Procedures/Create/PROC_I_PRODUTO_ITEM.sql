USE ESTOQUE
GO

IF OBJECT_ID('dbo.PROC_I_PRODUTO_ITEM') IS NOT NULL
BEGIN
	DROP PROCEDURE dbo.PROC_I_PRODUTO_ITEM
	PRINT '<< DROP PROCEDURE dbo.PROC_I_PRODUTO_ITEM >>'
END
GO

CREATE PROCEDURE dbo.PROC_I_PRODUTO_ITEM
	  @IdMarca					INT
	, @IdCategoria				INT
	, @IdSegmento				INT
	, @IdCor					INT
	, @IdProduto				INT
	, @Tamanho					VARCHAR(20)
	, @Ativo					BIT
	, @UsuarioCriacao			VARCHAR(50)
	, @DataCriacao				DATETIME
	, @UsuarioAtualizacao		VARCHAR(50)
	, @DataAtualizacao			DATETIME
AS
BEGIN
	INSERT INTO dbo.ProdutoItem
	(
		  IdMarca
		, IdCategoria
		, IdSegmento
		, IdCor
		, IdProduto
		, Tamanho
		, Ativo
		, UsuarioCriacao
		, DataCriacao
		, UsuarioAtualizacao
		, DataAtualizacao
	)
	VALUES
	(
		  @IdMarca
		, @IdCategoria
		, @IdSegmento
		, @IdCor
		, @IdProduto
		, @Tamanho
		, @Ativo
		, @UsuarioCriacao
		, @DataCriacao
		, @UsuarioAtualizacao
		, @DataAtualizacao
	)
END
GO

IF OBJECT_ID('dbo.PROC_I_PRODUTO_ITEM') IS NOT NULL
BEGIN
	PRINT '<< CREATE PROCEDURE dbo.PROC_I_PRODUTO_ITEM >>'
END
GO