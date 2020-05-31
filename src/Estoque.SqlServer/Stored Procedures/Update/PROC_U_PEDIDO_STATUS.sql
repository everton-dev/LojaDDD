USE ESTOQUE
GO

IF OBJECT_ID('dbo.PROC_U_PEDIDO_STATUS') IS NOT NULL
BEGIN
	DROP PROCEDURE dbo.PROC_U_PEDIDO_STATUS
	PRINT '<< DROP PROCEDURE dbo.PROC_U_PEDIDO_STATUS >>'
END
GO

CREATE PROCEDURE dbo.PROC_U_PEDIDO_STATUS
	  @IdPedidoStatus			INT
	, @Descricao				VARCHAR(100)
	, @Ativo					BIT
	, @UsuarioCriacao			VARCHAR(50)
	, @DataCriacao				DATETIME
	, @UsuarioAtualizacao		VARCHAR(50)
	, @DataAtualizacao			DATETIME
AS
BEGIN
	UPDATE dbo.PedidoStatus SET
		  Descricao = @Descricao
		, Ativo = @Ativo
		, UsuarioCriacao = @UsuarioCriacao
		, DataCriacao = @DataCriacao
		, UsuarioAtualizacao = @UsuarioAtualizacao
		, DataAtualizacao = @DataAtualizacao
	WHERE 
			IdPedidoStatus = @IdPedidoStatus
END
GO

IF OBJECT_ID('dbo.PROC_U_PEDIDO_STATUS') IS NOT NULL
BEGIN
	PRINT '<< CREATE PROCEDURE dbo.PROC_U_PEDIDO_STATUS >>'
END
GO