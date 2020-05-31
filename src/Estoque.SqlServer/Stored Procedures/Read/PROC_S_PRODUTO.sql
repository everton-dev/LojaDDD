USE ESTOQUE
GO

IF OBJECT_ID('dbo.PROC_S_PRODUTO') IS NOT NULL
BEGIN
	DROP PROCEDURE dbo.PROC_S_PRODUTO
	PRINT '<< DROP PROCEDURE dbo.PROC_S_PRODUTO >>'
END
GO

CREATE PROCEDURE dbo.PROC_S_PRODUTO
	  @IdMarca					INT	= NULL
	, @IdCategoria				INT	= NULL
	, @IdSegmento				INT	= NULL
	, @IdCor					INT	= NULL
	, @IdProduto				INT	= NULL
AS
BEGIN
	SELECT *
	FROM dbo.Produto
	WHERE 
			((@IdMarca IS NULL) OR (IdMarca = @IdMarca))
		AND ((@IdCategoria IS NULL) OR (IdCategoria = @IdCategoria))
		AND ((@IdSegmento IS NULL) OR (IdSegmento = @IdSegmento))
		AND ((@IdCor IS NULL) OR (IdCor = @IdCor))
		AND ((@IdProduto IS NULL) OR (IdProduto = @IdProduto))
END
GO

IF OBJECT_ID('dbo.PROC_S_PRODUTO') IS NOT NULL
BEGIN
	PRINT '<< CREATE PROCEDURE dbo.PROC_S_PRODUTO >>'
END
GO