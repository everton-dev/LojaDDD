USE ESTOQUE
GO

IF OBJECT_ID('dbo.PROC_I_PRODUTO') IS NOT NULL
BEGIN
	DROP PROCEDURE dbo.PROC_I_PRODUTO
	PRINT '<< DROP PROCEDURE dbo.PROC_I_PRODUTO >>'
END
GO

CREATE PROCEDURE dbo.PROC_I_PRODUTO
	  @IdMarca					INT
	, @IdCategoria				INT
	, @IdSegmento				INT
	, @IdCor					INT
	, @Descricao				VARCHAR(100)
	, @Ativo					BIT
	, @UsuarioCriacao			VARCHAR(50)
	, @DataCriacao				DATETIME
	, @UsuarioAtualizacao		VARCHAR(50)
	, @DataAtualizacao			DATETIME
AS
BEGIN
	INSERT INTO dbo.Produto
	(
		  IdMarca
		, IdCategoria
		, IdSegmento
		, IdCor
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
		, @IdCor
		, @Descricao
		, @Ativo
		, @UsuarioCriacao
		, @DataCriacao
		, @UsuarioAtualizacao
		, @DataAtualizacao
	)
END
GO

IF OBJECT_ID('dbo.PROC_I_PRODUTO') IS NOT NULL
BEGIN
	PRINT '<< CREATE PROCEDURE dbo.PROC_I_PRODUTO >>'
END
GO