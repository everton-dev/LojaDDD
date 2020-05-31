USE ESTOQUE
GO

IF OBJECT_ID('dbo.PROC_I_SEGMENTO') IS NOT NULL
BEGIN
	DROP PROCEDURE dbo.PROC_I_SEGMENTO
	PRINT '<< DROP PROCEDURE dbo.PROC_I_SEGMENTO >>'
END
GO

CREATE PROCEDURE dbo.PROC_I_SEGMENTO
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
	INSERT INTO dbo.Segmento
	(
		  IdMarca
		, IdCategoria
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
		, @IdCategoria
		, @Descricao
		, @Ativo
		, @UsuarioCriacao
		, @DataCriacao
		, @UsuarioAtualizacao
		, @DataAtualizacao
	)
END
GO

IF OBJECT_ID('dbo.PROC_I_SEGMENTO') IS NOT NULL
BEGIN
	PRINT '<< CREATE PROCEDURE dbo.PROC_I_SEGMENTO >>'
END
GO