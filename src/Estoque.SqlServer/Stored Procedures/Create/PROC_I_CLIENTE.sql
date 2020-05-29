USE ESTOQUE
GO

IF OBJECT_ID('dbo.PROC_I_CLIENTE') IS NOT NULL
BEGIN
	DROP PROCEDURE dbo.PROC_I_CLIENTE
	PRINT '<< DROP PROCEDURE dbo.PROC_I_CLIENTE >>'
END
GO

CREATE PROCEDURE dbo.PROC_I_CLIENTE
	  @Nome						VARCHAR(200)
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
	INSERT INTO dbo.Cliente
	(
		  Nome
		, Endereco
		, Telefone
		, Observacao
		, Ativo
		, UsuarioCriacao
		, DataCriacao
		, UsuarioAtualizacao
		, DataAtualizacao
	)
	VALUES
	(
		  @Nome
		, @Endereco
		, @Telefone
		, @Observacao
		, @Ativo
		, @UsuarioCriacao
		, @DataCriacao
		, @UsuarioAtualizacao
		, @DataAtualizacao
	)
END
GO

IF OBJECT_ID('dbo.PROC_I_CLIENTE') IS NOT NULL
BEGIN
	PRINT '<< CREATE PROCEDURE dbo.PROC_I_CLIENTE >>'
END
GO