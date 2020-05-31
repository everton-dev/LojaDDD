USE ESTOQUE
GO

IF OBJECT_ID('dbo.PROC_S_PRODUTO_ITEM') IS NOT NULL
BEGIN
	DROP PROCEDURE dbo.PROC_S_PRODUTO_ITEM
	PRINT '<< DROP PROCEDURE dbo.PROC_S_PRODUTO_ITEM >>'
END
GO

CREATE PROCEDURE dbo.PROC_S_PRODUTO_ITEM
	  @IdMarca					INT	= NULL
	, @IdCategoria				INT	= NULL
	, @IdSegmento				INT	= NULL
	, @IdCor					INT	= NULL
	, @IdProduto				INT	= NULL
	, @IdProdutoItem			INT	= NULL
AS
BEGIN
	SELECT *
	FROM dbo.ProdutoItem
	WHERE 
			((@IdMarca IS NULL) OR (IdMarca = @IdMarca))
		AND ((@IdCategoria IS NULL) OR (IdCategoria = @IdCategoria))
		AND ((@IdSegmento IS NULL) OR (IdSegmento = @IdSegmento))
		AND ((@IdCor IS NULL) OR (IdCor = @IdCor))
		AND ((@IdProduto IS NULL) OR (IdProduto = @IdProduto))
		AND ((@IdProdutoItem IS NULL) OR (IdProdutoItem = @IdProdutoItem))
END
GO

IF OBJECT_ID('dbo.PROC_S_PRODUTO_ITEM') IS NOT NULL
BEGIN
	PRINT '<< CREATE PROCEDURE dbo.PROC_S_PRODUTO_ITEM >>'
END
GO