USE ESTOQUE
GO

IF OBJECT_ID('dbo.PROC_U_PRODUTO_ITEM') IS NOT NULL
BEGIN
	DROP PROCEDURE dbo.PROC_U_PRODUTO_ITEM
	PRINT '<< DROP PROCEDURE dbo.PROC_U_PRODUTO_ITEM >>'
END
GO

CREATE PROCEDURE dbo.PROC_U_PRODUTO_ITEM
	  @IdMarca					INT
	, @IdCategoria				INT
	, @IdSegmento				INT
	, @IdCor					INT
	, @IdProduto				INT
	, @IdProdutoItem			INT
AS
BEGIN
	DELETE FROM dbo.ProdutoItem
	WHERE 
			IdMarca = @IdMarca
		AND IdCategoria = @IdCategoria
		AND IdSegmento = @IdSegmento
		AND IdCor = @IdCor
		AND IdProduto = @IdProduto
		AND IdProdutoItem = @IdProdutoItem
END
GO

IF OBJECT_ID('dbo.PROC_U_PRODUTO_ITEM') IS NOT NULL
BEGIN
	PRINT '<< CREATE PROCEDURE dbo.PROC_U_PRODUTO_ITEM >>'
END
GO