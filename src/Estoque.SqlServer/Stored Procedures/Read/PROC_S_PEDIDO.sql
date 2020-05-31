USE ESTOQUE
GO

IF OBJECT_ID('dbo.PROC_S_PEDIDO') IS NOT NULL
BEGIN
	DROP PROCEDURE dbo.PROC_S_PEDIDO
	PRINT '<< DROP PROCEDURE dbo.PROC_S_PEDIDO >>'
END
GO

CREATE PROCEDURE dbo.PROC_S_PEDIDO
	  @IdPedido					INT	= NULL
	, @IdFornecedor				INT	= NULL
	, @IdPedidoStatus			INT	= NULL
AS
BEGIN
	SELECT *
	FROM dbo.Pedido
	WHERE 
			((@IdPedido IS NULL) OR (IdPedido = @IdPedido))
		AND	((@IdFornecedor IS NULL) OR (IdFornecedor = @IdFornecedor))
		AND	((@IdPedidoStatus IS NULL) OR (IdPedidoStatus = @IdPedidoStatus))
END
GO

IF OBJECT_ID('dbo.PROC_S_PEDIDO') IS NOT NULL
BEGIN
	PRINT '<< CREATE PROCEDURE dbo.PROC_S_PEDIDO >>'
END
GO