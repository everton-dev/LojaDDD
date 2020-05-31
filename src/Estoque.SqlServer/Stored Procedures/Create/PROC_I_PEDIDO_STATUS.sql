USE ESTOQUE
GO

IF OBJECT_ID('dbo.PROC_I_PEDIDO_STATUS') IS NOT NULL
BEGIN
	DROP PROCEDURE dbo.PROC_I_PEDIDO_STATUS
	PRINT '<< DROP PROCEDURE dbo.PROC_I_PEDIDO_STATUS >>'
END
GO

CREATE PROCEDURE dbo.PROC_I_PEDIDO_STATUS
	  @IdPedidoStatus			INT
	, @Descricao				VARCHAR(100)
	, @Ativo					BIT
	, @UsuarioCriacao			VARCHAR(50)
	, @DataCriacao				DATETIME
	, @UsuarioAtualizacao		VARCHAR(50)
	, @DataAtualizacao			DATETIME
AS
BEGIN
	INSERT INTO dbo.PedidoStatus
	(
		  IdPedidoStatus
		, Descricao
		, Ativo
		, UsuarioCriacao
		, DataCriacao
		, UsuarioAtualizacao
		, DataAtualizacao
	)
	VALUES
	(
		  @IdPedidoStatus
		, @Descricao
		, @Ativo
		, @UsuarioCriacao
		, @DataCriacao
		, @UsuarioAtualizacao
		, @DataAtualizacao
	)
END
GO

IF OBJECT_ID('dbo.PROC_I_PEDIDO_STATUS') IS NOT NULL
BEGIN
	PRINT '<< CREATE PROCEDURE dbo.PROC_I_PEDIDO_STATUS >>'
END
GO