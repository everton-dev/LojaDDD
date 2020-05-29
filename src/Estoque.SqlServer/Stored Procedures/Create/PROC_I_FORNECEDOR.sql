USE ESTOQUE
GO

IF OBJECT_ID('dbo.PROC_I_FORNECEDOR') IS NOT NULL
BEGIN
	DROP PROCEDURE dbo.PROC_I_FORNECEDOR
	PRINT '<< DROP PROCEDURE dbo.PROC_I_FORNECEDOR >>'
END
GO

CREATE PROCEDURE dbo.PROC_I_FORNECEDOR
	  @Cnpj						VARCHAR(14)
	, @RazaoSocial				VARCHAR(200)
	, @Telefone					VARCHAR(200)
	, @Ativo					BIT
	, @UsuarioCriacao			VARCHAR(50)
	, @DataCriacao				DATETIME
	, @UsuarioAtualizacao		VARCHAR(50)
	, @DataAtualizacao			DATETIME
AS
BEGIN
	INSERT INTO dbo.Fornecedor
	(
		  Cnpj
		, RazaoSocial
		, Telefone
		, Ativo
		, UsuarioCriacao
		, DataCriacao
		, UsuarioAtualizacao
		, DataAtualizacao
	)
	VALUES
	(
		  @Cnpj
		, @RazaoSocial
		, @Telefone
		, @Ativo
		, @UsuarioCriacao
		, @DataCriacao
		, @UsuarioAtualizacao
		, @DataAtualizacao
	)
END
GO

IF OBJECT_ID('dbo.PROC_I_FORNECEDOR') IS NOT NULL
BEGIN
	PRINT '<< CREATE PROCEDURE dbo.PROC_I_FORNECEDOR >>'
END
GO