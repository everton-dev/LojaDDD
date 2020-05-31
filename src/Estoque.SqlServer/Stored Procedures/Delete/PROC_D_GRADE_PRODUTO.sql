USE ESTOQUE
GO

IF OBJECT_ID('dbo.PROC_D_GRADE_PRODUTO') IS NOT NULL
BEGIN
	DROP PROCEDURE dbo.PROC_D_GRADE_PRODUTO
	PRINT '<< DROP PROCEDURE dbo.PROC_D_GRADE_PRODUTO >>'
END
GO

CREATE PROCEDURE dbo.PROC_D_GRADE_PRODUTO
	  @IdMarca					INT
	, @IdCategoria				INT
	, @IdSegmento				INT
	, @IdCor					INT
	, @IdProduto				INT
	, @IdProdutoItem			INT
	, @IdGradeProduto			INT
AS
BEGIN
	DELETE FROM dbo.GradeProduto
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

IF OBJECT_ID('dbo.PROC_D_GRADE_PRODUTO') IS NOT NULL
BEGIN
	PRINT '<< CREATE PROCEDURE dbo.PROC_D_GRADE_PRODUTO >>'
END
GO