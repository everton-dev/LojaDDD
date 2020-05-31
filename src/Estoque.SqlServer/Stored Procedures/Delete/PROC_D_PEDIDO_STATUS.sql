﻿USE ESTOQUE
GO

IF OBJECT_ID('dbo.PROC_D_PEDIDO_STATUS') IS NOT NULL
BEGIN
	DROP PROCEDURE dbo.PROC_D_PEDIDO_STATUS
	PRINT '<< DROP PROCEDURE dbo.PROC_D_PEDIDO_STATUS >>'
END
GO

CREATE PROCEDURE dbo.PROC_D_PEDIDO_STATUS
	  @IdPedidoStatus			INT
AS
BEGIN
	DELETE FROM dbo.PedidoStatus
	WHERE 
			IdPedidoStatus = @IdPedidoStatus
END
GO

IF OBJECT_ID('dbo.PROC_D_PEDIDO_STATUS') IS NOT NULL
BEGIN
	PRINT '<< CREATE PROCEDURE dbo.PROC_D_PEDIDO_STATUS >>'
END
GO