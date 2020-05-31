USE ESTOQUE
GO

IF OBJECT_ID('dbo.PROC_I_PEDIDO') IS NOT NULL
BEGIN
	DROP PROCEDURE dbo.PROC_I_PEDIDO
	PRINT '<< DROP PROCEDURE dbo.PROC_I_PEDIDO >>'
END
GO

CREATE PROCEDURE dbo.PROC_I_PEDIDO
	  @IdPedido					INT
	, @IdFornecedor				INT
	, @IdPedidoStatus			INT
	, @Quantidade				DECIMAL(18,4)
	, @Custo					DECIMAL(18,4)
	, @Desconto					DECIMAL(18,4)
	, @Total					DECIMAL(18,4)
	, @Ativo					BIT
	, @UsuarioCriacao			VARCHAR(50)
	, @DataCriacao				DATETIME
	, @UsuarioAtualizacao		VARCHAR(50)
	, @DataAtualizacao			DATETIME
AS
BEGIN
	INSERT INTO dbo.Pedido
	(
		  IdFornecedor
		, IdPedidoStatus
		, Quantidade
		, Custo
		, Desconto
		, Total
		, Ativo
		, UsuarioCriacao
		, DataCriacao
		, UsuarioAtualizacao
		, DataAtualizacao
	)
	VALUES
	(
		  @IdFornecedor
		, @IdPedidoStatus
		, @Quantidade
		, @Custo
		, @Desconto
		, @Total
		, @Ativo
		, @UsuarioCriacao
		, @DataCriacao
		, @UsuarioAtualizacao
		, @DataAtualizacao
	)
END
GO

IF OBJECT_ID('dbo.PROC_I_PEDIDO') IS NOT NULL
BEGIN
	PRINT '<< CREATE PROCEDURE dbo.PROC_I_PEDIDO >>'
END
GO