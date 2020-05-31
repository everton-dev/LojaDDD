USE ESTOQUE
GO

IF OBJECT_ID('dbo.PROC_I_GRADE_PRODUTO') IS NOT NULL
BEGIN
	DROP PROCEDURE dbo.PROC_I_GRADE_PRODUTO
	PRINT '<< DROP PROCEDURE dbo.PROC_I_GRADE_PRODUTO >>'
END
GO

CREATE PROCEDURE dbo.PROC_I_GRADE_PRODUTO
	  @IdMarca					INT
	, @IdCategoria				INT
	, @IdSegmento				INT
	, @IdCor					INT
	, @IdProduto				INT
	, @IdProdutoItem			INT
	, @IdPedido					INT
	, @Quantidade				DECIMAL(18,4)
	, @Custo					DECIMAL(18,4)
	, @Preco					DECIMAL(18,4)
	, @Ativo					BIT
	, @UsuarioCriacao			VARCHAR(50)
	, @DataCriacao				DATETIME
	, @UsuarioAtualizacao		VARCHAR(50)
	, @DataAtualizacao			DATETIME
AS
BEGIN
	INSERT INTO dbo.GradeProduto
	(
		  IdMarca
		, IdCategoria
		, IdSegmento
		, IdCor
		, IdProduto
		, IdProdutoItem
		, IdPedido
		, Quantidade
		, Custo
		, Preco
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
		, @IdProdutoItem
		, @IdPedido
		, @Quantidade
		, @Custo
		, @Preco
		, @Ativo
		, @UsuarioCriacao
		, @DataCriacao
		, @UsuarioAtualizacao
		, @DataAtualizacao
	)
END
GO

IF OBJECT_ID('dbo.PROC_I_GRADE_PRODUTO') IS NOT NULL
BEGIN
	PRINT '<< CREATE PROCEDURE dbo.PROC_I_GRADE_PRODUTO >>'
END
GO