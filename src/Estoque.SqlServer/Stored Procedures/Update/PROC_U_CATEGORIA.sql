USE ESTOQUE
GO

IF OBJECT_ID('dbo.PROC_U_CATEGORIA') IS NOT NULL
BEGIN
	DROP PROCEDURE dbo.PROC_U_CATEGORIA
	PRINT '<< DROP PROCEDURE dbo.PROC_U_CATEGORIA >>'
END
GO

CREATE PROCEDURE dbo.PROC_U_CATEGORIA
	  @IdMarca					INT
	, @IdCategoria				INT
	, @Descricao				VARCHAR(100)
	, @Ativo					BIT
	, @UsuarioCriacao			VARCHAR(50)
	, @DataCriacao				DATETIME
	, @UsuarioAtualizacao		VARCHAR(50)
	, @DataAtualizacao			DATETIME
AS
BEGIN
	UPDATE dbo.Categoria SET
		 Descricao = @Descricao
		, Ativo = @Ativo
		, UsuarioCriacao = @UsuarioCriacao
		, DataCriacao = @DataCriacao
		, UsuarioAtualizacao = @UsuarioAtualizacao
		, DataAtualizacao = @DataAtualizacao
	WHERE 
			IdMarca = @IdMarca
		AND IdCategoria = @IdCategoria
END
GO

IF OBJECT_ID('dbo.PROC_U_CATEGORIA') IS NOT NULL
BEGIN
	PRINT '<< CREATE PROCEDURE dbo.PROC_U_CATEGORIA >>'
END
GO