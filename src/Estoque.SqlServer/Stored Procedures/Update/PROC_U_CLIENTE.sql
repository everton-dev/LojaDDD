USE ESTOQUE
GO

IF OBJECT_ID('dbo.PROC_U_CLIENTE') IS NOT NULL
BEGIN
	DROP PROCEDURE dbo.PROC_U_CLIENTE
	PRINT '<< DROP PROCEDURE dbo.PROC_U_CLIENTE >>'
END
GO

CREATE PROCEDURE dbo.PROC_U_CLIENTE
	  @IdCliente			INT
	, @Nome						VARCHAR(200)
	, @Endereco					VARCHAR(200)
	, @Telefone					VARCHAR(200)
	, @Observacao				VARCHAR(300)
	, @Ativo					BIT
	, @UsuarioCriacao			VARCHAR(50)
	, @DataCriacao				DATETIME
	, @UsuarioAtualizacao		VARCHAR(50)
	, @DataAtualizacao			DATETIME
AS
BEGIN
	UPDATE dbo.Cliente SET
		  Nome = @Nome
		, Endereco = @Endereco
		, Telefone = @Telefone
		, Observacao = @Observacao
		, Ativo = @Ativo
		, UsuarioCriacao = @UsuarioCriacao
		, DataCriacao = @DataCriacao
		, UsuarioAtualizacao = @UsuarioAtualizacao
		, DataAtualizacao = @DataAtualizacao
	WHERE 
			IdCliente = @IdCliente
END
GO

IF OBJECT_ID('dbo.PROC_U_CLIENTE') IS NOT NULL
BEGIN
	PRINT '<< CREATE PROCEDURE dbo.PROC_U_CLIENTE >>'
END
GO