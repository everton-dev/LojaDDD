USE ESTOQUE
GO

IF OBJECT_ID('dbo.PROC_I_COR') IS NOT NULL
BEGIN
	DROP PROCEDURE dbo.PROC_I_COR
	PRINT '<< DROP PROCEDURE dbo.PROC_I_COR >>'
END
GO

CREATE PROCEDURE dbo.PROC_I_COR
	  @IdMarca					INT
	, @IdCategoria				INT
	, @IdSegmento				INT
	, @Descricao				VARCHAR(100)
	, @Ativo					BIT
	, @UsuarioCriacao			VARCHAR(50)
	, @DataCriacao				DATETIME
	, @UsuarioAtualizacao		VARCHAR(50)
	, @DataAtualizacao			DATETIME
AS
BEGIN
	INSERT INTO dbo.Cor
	(
		  IdMarca
		, IdCategoria
		, IdSegmento
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
		, @IdSegmento
		, @Descricao
		, @Ativo
		, @UsuarioCriacao
		, @DataCriacao
		, @UsuarioAtualizacao
		, @DataAtualizacao
	)
END
GO

IF OBJECT_ID('dbo.PROC_I_COR') IS NOT NULL
BEGIN
	PRINT '<< CREATE PROCEDURE dbo.PROC_I_COR >>'
END
GO