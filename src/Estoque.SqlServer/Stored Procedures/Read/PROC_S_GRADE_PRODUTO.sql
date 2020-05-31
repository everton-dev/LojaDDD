USE ESTOQUE
GO

IF OBJECT_ID('dbo.PROC_S_GRADE_PRODUTO') IS NOT NULL
BEGIN
	DROP PROCEDURE dbo.PROC_S_GRADE_PRODUTO
	PRINT '<< DROP PROCEDURE dbo.PROC_S_GRADE_PRODUTO >>'
END
GO

CREATE PROCEDURE dbo.PROC_S_GRADE_PRODUTO
	  @IdMarca					INT	= NULL
	, @IdCategoria				INT	= NULL
	, @IdSegmento				INT	= NULL
	, @IdCor					INT	= NULL
	, @IdProduto				INT	= NULL
	, @IdProdutoItem			INT	= NULL
	, @IdGradeProduto			INT	= NULL
	, @IdPedido					INT	= NULL
AS
BEGIN
	SELECT * 
	FROM dbo.GradeProduto
	WHERE 
			((@IdMarca IS NULL) OR (IdMarca = @IdMarca))
		AND ((@IdCategoria IS NULL) OR (IdCategoria = @IdCategoria))
		AND ((@IdSegmento IS NULL) OR (IdSegmento = @IdSegmento))
		AND ((@IdCor IS NULL) OR (IdCor = @IdCor))
		AND ((@IdProduto IS NULL) OR (IdProduto = @IdProduto))
		AND ((@IdProdutoItem IS NULL) OR (IdProdutoItem = @IdProdutoItem))
		AND ((@IdGradeProduto IS NULL) OR (IdGradeProduto = @IdGradeProduto))
		AND ((@IdPedido IS NULL) OR (IdPedido = @IdPedido))
END
GO

IF OBJECT_ID('dbo.PROC_S_GRADE_PRODUTO') IS NOT NULL
BEGIN
	PRINT '<< CREATE PROCEDURE dbo.PROC_S_GRADE_PRODUTO >>'
END
GO