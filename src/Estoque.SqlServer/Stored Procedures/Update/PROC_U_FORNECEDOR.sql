USE ESTOQUE
GO

IF OBJECT_ID('dbo.PROC_U_FORNECEDOR') IS NOT NULL
BEGIN
	DROP PROCEDURE dbo.PROC_U_FORNECEDOR
	PRINT '<< DROP PROCEDURE dbo.PROC_U_FORNECEDOR >>'
END
GO

CREATE PROCEDURE dbo.PROC_U_FORNECEDOR
	  @IdFornecedor				INT
	, @Cnpj						VARCHAR(14)
	, @RazaoSocial				VARCHAR(200)
	, @Telefone					VARCHAR(200)
	, @Ativo					BIT
	, @UsuarioCriacao			VARCHAR(50)
	, @DataCriacao				DATETIME
	, @UsuarioAtualizacao		VARCHAR(50)
	, @DataAtualizacao			DATETIME
AS
BEGIN
	UPDATE dbo.Fornecedor SET
		  Cnpj = @Cnpj
		, RazaoSocial = @RazaoSocial
		, Telefone = @Telefone
		, Ativo = @Ativo
		, UsuarioCriacao = @UsuarioCriacao
		, DataCriacao = @DataCriacao
		, UsuarioAtualizacao = @UsuarioAtualizacao
		, DataAtualizacao = @DataAtualizacao
	WHERE 
			IdFornecedor = @IdFornecedor
END
GO

IF OBJECT_ID('dbo.PROC_U_FORNECEDOR') IS NOT NULL
BEGIN
	PRINT '<< CREATE PROCEDURE dbo.PROC_U_FORNECEDOR >>'
END
GO