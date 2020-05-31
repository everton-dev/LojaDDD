USE ESTOQUE
GO

IF OBJECT_ID('dbo.PROC_U_PEDIDO') IS NOT NULL
BEGIN
	DROP PROCEDURE dbo.PROC_U_PEDIDO
	PRINT '<< DROP PROCEDURE dbo.PROC_U_PEDIDO >>'
END
GO

CREATE PROCEDURE dbo.PROC_U_PEDIDO
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
	UPDATE dbo.Pedido SET
		  IdFornecedor = @IdFornecedor
		, IdPedidoStatus = @IdPedidoStatus
		, Quantidade = @Quantidade
		, Custo = @Custo
		, Desconto = @Desconto
		, Total = @Total
		, Ativo = @Ativo
		, UsuarioCriacao = @UsuarioCriacao
		, DataCriacao = @DataCriacao
		, UsuarioAtualizacao = @UsuarioAtualizacao
		, DataAtualizacao = @DataAtualizacao
	WHERE 
			IdPedido = @IdPedido
END
GO

IF OBJECT_ID('dbo.PROC_U_PEDIDO') IS NOT NULL
BEGIN
	PRINT '<< CREATE PROCEDURE dbo.PROC_U_PEDIDO >>'
END
GO