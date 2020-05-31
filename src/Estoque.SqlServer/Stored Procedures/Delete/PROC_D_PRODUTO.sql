USE ESTOQUE
GO

IF OBJECT_ID('dbo.PROC_D_PRODUTO') IS NOT NULL
BEGIN
	DROP PROCEDURE dbo.PROC_D_PRODUTO
	PRINT '<< DROP PROCEDURE dbo.PROC_D_PRODUTO >>'
END
GO

CREATE PROCEDURE dbo.PROC_D_PRODUTO
	  @IdMarca					INT
	, @IdCategoria				INT
	, @IdSegmento				INT
	, @IdCor					INT
	, @IdProduto				INT
AS
BEGIN
	DELETE FROM dbo.Produto
	WHERE 
			IdMarca = @IdMarca
		AND IdCategoria = @IdCategoria
		AND IdSegmento = @IdSegmento
		AND IdCor = @IdCor
		AND IdProduto = @IdProduto
END
GO

IF OBJECT_ID('dbo.PROC_D_PRODUTO') IS NOT NULL
BEGIN
	PRINT '<< CREATE PROCEDURE dbo.PROC_D_PRODUTO >>'
END
GO