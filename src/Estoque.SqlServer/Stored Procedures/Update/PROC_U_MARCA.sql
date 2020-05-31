USE ESTOQUE
GO

IF OBJECT_ID('dbo.PROC_U_MARCA') IS NOT NULL
BEGIN
	DROP PROCEDURE dbo.PROC_U_MARCA
	PRINT '<< DROP PROCEDURE dbo.PROC_U_MARCA >>'
END
GO

CREATE PROCEDURE dbo.PROC_U_MARCA
	  @IdMarca					INT
	, @Descricao				VARCHAR(100)
	, @Ativo					BIT
	, @UsuarioCriacao			VARCHAR(50)
	, @DataCriacao				DATETIME
	, @UsuarioAtualizacao		VARCHAR(50)
	, @DataAtualizacao			DATETIME
AS
BEGIN
	UPDATE dbo.Marca SET
		 Descricao = @Descricao
		, Ativo = @Ativo
		, UsuarioCriacao = @UsuarioCriacao
		, DataCriacao = @DataCriacao
		, UsuarioAtualizacao = @UsuarioAtualizacao
		, DataAtualizacao = @DataAtualizacao
	WHERE 
			IdMarca = @IdMarca
END
GO

IF OBJECT_ID('dbo.PROC_U_MARCA') IS NOT NULL
BEGIN
	PRINT '<< CREATE PROCEDURE dbo.PROC_U_MARCA >>'
END
GO