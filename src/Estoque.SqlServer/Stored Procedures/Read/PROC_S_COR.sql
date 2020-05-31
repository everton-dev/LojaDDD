USE ESTOQUE
GO

IF OBJECT_ID('dbo.PROC_S_COR') IS NOT NULL
BEGIN
	DROP PROCEDURE dbo.PROC_S_COR
	PRINT '<< DROP PROCEDURE dbo.PROC_S_COR >>'
END
GO

CREATE PROCEDURE dbo.PROC_S_COR
	  @IdMarca					INT	= NULL
	, @IdCategoria				INT	= NULL
	, @IdSegmento				INT	= NULL
	, @IdCor					INT	= NULL
AS
BEGIN
	SELECT *
	FROM dbo.Cor
	WHERE 
			((@IdMarca IS NULL) OR (IdMarca = @IdMarca))
		AND ((@IdCategoria IS NULL) OR (IdCategoria = @IdCategoria))
		AND ((@IdSegmento IS NULL) OR (IdSegmento = @IdSegmento))
		AND ((@IdCor IS NULL) OR (IdCor = @IdCor))
END
GO

IF OBJECT_ID('dbo.PROC_S_COR') IS NOT NULL
BEGIN
	PRINT '<< CREATE PROCEDURE dbo.PROC_S_COR >>'
END
GO