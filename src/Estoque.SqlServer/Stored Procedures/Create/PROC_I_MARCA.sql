USE ESTOQUE
GO

IF OBJECT_ID('dbo.PROC_I_MARCA') IS NOT NULL
BEGIN
	DROP PROCEDURE dbo.PROC_I_MARCA
	PRINT '<< DROP PROCEDURE dbo.PROC_I_MARCA >>'
END
GO

CREATE PROCEDURE dbo.PROC_I_MARCA
	  @IdMarca					INT
	, @Descricao				VARCHAR(100)
	, @Ativo					BIT
	, @UsuarioCriacao			VARCHAR(50)
	, @DataCriacao				DATETIME
	, @UsuarioAtualizacao		VARCHAR(50)
	, @DataAtualizacao			DATETIME
AS
BEGIN
	INSERT INTO dbo.Marca
	(
		  IdMarca
		, Descricao
		, Ativo
		, UsuarioCriacao
		, DataCriacao
		, UsuarioAtualizacao
		, DataAtualizacao
	)
	VALUES
	(
		  @IdMarca
		, @Descricao
		, @Ativo
		, @UsuarioCriacao
		, @DataCriacao
		, @UsuarioAtualizacao
		, @DataAtualizacao
	)
END
GO

IF OBJECT_ID('dbo.PROC_I_MARCA') IS NOT NULL
BEGIN
	PRINT '<< CREATE PROCEDURE dbo.PROC_I_MARCA >>'
END
GO