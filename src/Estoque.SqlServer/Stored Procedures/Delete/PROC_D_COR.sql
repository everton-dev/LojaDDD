USE ESTOQUE
GO

IF OBJECT_ID('dbo.PROC_D_COR') IS NOT NULL
BEGIN
	DROP PROCEDURE dbo.PROC_D_COR
	PRINT '<< DROP PROCEDURE dbo.PROC_D_COR >>'
END
GO

CREATE PROCEDURE dbo.PROC_D_COR
	  @IdMarca					INT
	, @IdCategoria				INT
	, @IdSegmento				INT
	, @IdCor					INT
AS
BEGIN
	DELETE FROM dbo.Cor
	WHERE 
			IdMarca = @IdMarca
		AND IdCategoria = @IdCategoria
		AND IdSegmento = @IdSegmento
		AND IdCor = @IdCor
END
GO

IF OBJECT_ID('dbo.PROC_D_COR') IS NOT NULL
BEGIN
	PRINT '<< CREATE PROCEDURE dbo.PROC_D_COR >>'
END
GO