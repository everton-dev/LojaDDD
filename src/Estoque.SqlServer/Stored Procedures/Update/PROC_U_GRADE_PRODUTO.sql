USE ESTOQUE
GO

IF OBJECT_ID('dbo.PROC_U_GRADE_PRODUTO') IS NOT NULL
BEGIN
	DROP PROCEDURE dbo.PROC_U_GRADE_PRODUTO
	PRINT '<< DROP PROCEDURE dbo.PROC_U_GRADE_PRODUTO >>'
END
GO

CREATE PROCEDURE dbo.PROC_U_GRADE_PRODUTO
	  @IdMarca					INT
	, @IdCategoria				INT
	, @IdSegmento				INT
	, @IdCor					INT
	, @IdProduto				INT
	, @IdProdutoItem			INT
	, @IdGradeProduto			INT
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
	UPDATE dbo.GradeProduto SET
		  IdPedido = @IdPedido
		, Quantidade = @Quantidade
		, Custo = @Custo
		, Preco = @Preco
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
		AND IdProdutoItem = @IdProdutoItem
		AND IdGradeProduto = @IdGradeProduto
END
GO

IF OBJECT_ID('dbo.PROC_U_GRADE_PRODUTO') IS NOT NULL
BEGIN
	PRINT '<< CREATE PROCEDURE dbo.PROC_U_GRADE_PRODUTO >>'
END
GO