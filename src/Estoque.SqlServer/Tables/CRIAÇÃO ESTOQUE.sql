USE ESTOQUE
GO

CREATE TABLE dbo.Marca
(
	  IdMarca				INT				NOT NULL	IDENTITY(1,1)
	, Descricao				VARCHAR(100)	NOT NULL
	, Ativo					BIT				NOT NULL
	, UsuarioCriacao		VARCHAR(50)		NOT NULL
	, DataCriacao			DATETIME		NOT NULL
	, UsuarioAtualizacao	VARCHAR(50)			NULL
	, DataAtualizacao		DATETIME			NULL
	, CONSTRAINT	PK_MARCA	PRIMARY KEY	(IdMarca)
)
GO

CREATE TABLE dbo.Categoria
(
	  IdMarca				INT				NOT NULL
	, IdCategoria			INT				NOT NULL	IDENTITY(1,1)
	, Descricao				VARCHAR(100)	NOT NULL
	, Ativo					BIT				NOT NULL
	, UsuarioCriacao		VARCHAR(50)		NOT NULL
	, DataCriacao			DATETIME		NOT NULL
	, UsuarioAtualizacao	VARCHAR(50)			NULL
	, DataAtualizacao		DATETIME			NULL
	, CONSTRAINT	PK_CATEGORIA	PRIMARY KEY	(IdMarca, IdCategoria)
	, CONSTRAINT	FK_MARCA_CATEGORIA	FOREIGN KEY	(IdMarca) REFERENCES dbo.Marca (IdMarca)
)
GO

CREATE TABLE dbo.Segmento
(
	  IdMarca				INT				NOT NULL
	, IdCategoria			INT				NOT NULL
	, IdSegmento			INT				NOT NULL	IDENTITY(1,1)
	, Descricao				VARCHAR(100)	NOT NULL
	, Ativo					BIT				NOT NULL
	, UsuarioCriacao		VARCHAR(50)		NOT NULL
	, DataCriacao			DATETIME		NOT NULL
	, UsuarioAtualizacao	VARCHAR(50)			NULL
	, DataAtualizacao		DATETIME			NULL
	, CONSTRAINT	PK_SEGMENTO	PRIMARY KEY	(IdMarca, IdCategoria, IdSegmento)
	, CONSTRAINT	FK_CATEGORIA_SEGMENTO	FOREIGN KEY	(IdMarca, IdCategoria) REFERENCES dbo.Categoria (IdMarca, IdCategoria)
)
GO

CREATE TABLE dbo.Cor
(
	  IdMarca				INT				NOT NULL
	, IdCategoria			INT				NOT NULL
	, IdSegmento			INT				NOT NULL
	, IdCor					INT				NOT NULL	IDENTITY(1,1)
	, Descricao				VARCHAR(100)	NOT NULL
	, Ativo					BIT				NOT NULL
	, UsuarioCriacao		VARCHAR(50)		NOT NULL
	, DataCriacao			DATETIME		NOT NULL
	, UsuarioAtualizacao	VARCHAR(50)			NULL
	, DataAtualizacao		DATETIME			NULL
	, CONSTRAINT	PK_COR	PRIMARY KEY	(IdMarca, IdCategoria, IdSegmento, IdCor)
	, CONSTRAINT	FK_SEGMENTO_COR	FOREIGN KEY	(IdMarca, IdCategoria, IdSegmento) REFERENCES dbo.Segmento (IdMarca, IdCategoria, IdSegmento)
)
GO

CREATE TABLE dbo.Produto
(
	  IdMarca				INT				NOT NULL
	, IdCategoria			INT				NOT NULL
	, IdSegmento			INT				NOT NULL
	, IdCor					INT				NOT NULL
	, IdProduto				INT				NOT NULL	IDENTITY(1,1)
	, Descricao				VARCHAR(100)	NOT NULL
	, Ativo					BIT				NOT NULL
	, UsuarioCriacao		VARCHAR(50)		NOT NULL
	, DataCriacao			DATETIME		NOT NULL
	, UsuarioAtualizacao	VARCHAR(50)			NULL
	, DataAtualizacao		DATETIME			NULL
	, CONSTRAINT	PK_PRODUTO	PRIMARY KEY	(IdMarca, IdCategoria, IdSegmento, IdCor, IdProduto)
	, CONSTRAINT	FK_COR_PRODUTO	FOREIGN KEY	(IdMarca, IdCategoria, IdSegmento, IdCor) REFERENCES dbo.Cor (IdMarca, IdCategoria, IdSegmento, IdCor)
)
GO

CREATE TABLE dbo.ProdutoItem
(
	  IdMarca				INT				NOT NULL
	, IdCategoria			INT				NOT NULL
	, IdSegmento			INT				NOT NULL
	, IdCor					INT				NOT NULL
	, IdProduto				INT				NOT NULL
	, IdProdutoItem			INT				NOT NULL	IDENTITY(1,1)
	, Tamanho				VARCHAR(20)		NOT NULL
	, Ativo					BIT				NOT NULL
	, UsuarioCriacao		VARCHAR(50)		NOT NULL
	, DataCriacao			DATETIME		NOT NULL
	, UsuarioAtualizacao	VARCHAR(50)			NULL
	, DataAtualizacao		DATETIME			NULL
	, CONSTRAINT	PK_PRODUTO_ITEM	PRIMARY KEY	(IdMarca, IdCategoria, IdSegmento, IdCor, IdProduto, IdProdutoItem)
	, CONSTRAINT	FK_PRODUTO_PRODUTO_ITEM	FOREIGN KEY	(IdMarca, IdCategoria, IdSegmento, IdCor, IdProduto) REFERENCES dbo.Produto (IdMarca, IdCategoria, IdSegmento, IdCor, IdProduto)
)
GO

CREATE TABLE dbo.Cliente
(
	  IdCliente				INT				NOT NULL	IDENTITY(1,1)
	, Nome					VARCHAR(200)	NOT NULL
	, Endereco				VARCHAR(200)	NOT NULL
	, Telefone				VARCHAR(200)	NOT NULL
	, Observacao			VARCHAR(300)	NOT NULL
	, Ativo					BIT				NOT NULL
	, UsuarioCriacao		VARCHAR(50)		NOT NULL
	, DataCriacao			DATETIME		NOT NULL
	, UsuarioAtualizacao	VARCHAR(50)			NULL
	, DataAtualizacao		DATETIME			NULL
	, CONSTRAINT	PK_CLIENTE	PRIMARY KEY	(IdCliente)
)
GO

CREATE TABLE dbo.Fornecedor
(
	  IdFornecedor			INT				NOT NULL	IDENTITY(1,1)
	, Cnpj					VARCHAR(14)		NOT NULL
	, RazaoSocial			VARCHAR(200)	NOT NULL
	, Telefone				VARCHAR(200)	NOT NULL
	, Ativo					BIT				NOT NULL
	, UsuarioCriacao		VARCHAR(50)		NOT NULL
	, DataCriacao			DATETIME		NOT NULL
	, UsuarioAtualizacao	VARCHAR(50)			NULL
	, DataAtualizacao		DATETIME			NULL
	, CONSTRAINT	PK_FORNECEDOR	PRIMARY KEY	(IdFornecedor)
)
GO

CREATE TABLE dbo.PedidoStatus
(
	  IdPedidoStatus		INT				NOT NULL	IDENTITY(1,1)
	, Descricao				VARCHAR(100)	NOT NULL
	, Ativo					BIT				NOT NULL
	, UsuarioCriacao		VARCHAR(50)		NOT NULL
	, DataCriacao			DATETIME		NOT NULL
	, UsuarioAtualizacao	VARCHAR(50)			NULL
	, DataAtualizacao		DATETIME			NULL
	, CONSTRAINT	PK_PEDIDO_STATUS	PRIMARY KEY	(IdPedidoStatus)
)
GO

CREATE TABLE dbo.Pedido
(
	  IdPedido				INT				NOT NULL	IDENTITY(1,1)
	, IdFornecedor			INT				NOT NULL
	, IdPedidoStatus		INT				NOT NULL
	, Quantidade			DECIMAL(18, 4)	NOT NULL
	, Custo					DECIMAL(18, 4)	NOT NULL
	, Desconto				DECIMAL(18, 4)	NOT NULL
	, Total					DECIMAL(18, 4)	NOT NULL
	, Ativo					BIT				NOT NULL
	, UsuarioCriacao		VARCHAR(50)		NOT NULL
	, DataCriacao			DATETIME		NOT NULL
	, UsuarioAtualizacao	VARCHAR(50)			NULL
	, DataAtualizacao		DATETIME			NULL
	, CONSTRAINT	PK_PEDIDO	PRIMARY KEY	(IdPedido)
	, CONSTRAINT	FK_FORNECEDOR_PEDIDO	FOREIGN KEY	(IdFornecedor) REFERENCES dbo.Fornecedor (IdFornecedor)
	, CONSTRAINT	FK_PEDIDO_STATUS_PEDIDO	FOREIGN KEY	(IdPedidoStatus) REFERENCES dbo.PedidoStatus (IdPedidoStatus)
)
GO

CREATE TABLE dbo.GradeProduto
(
	  IdMarca				INT				NOT NULL
	, IdCategoria			INT				NOT NULL
	, IdSegmento			INT				NOT NULL
	, IdCor					INT				NOT NULL
	, IdProduto				INT				NOT NULL
	, IdProdutoItem			INT				NOT NULL
	, IdGradeProduto		INT				NOT NULL	IDENTITY(1,1)
	, IdPedido				INT				NOT NULL
	, Quantidade			DECIMAL(18,4)	NOT NULL
	, Custo					DECIMAL(18,4)	NOT NULL
	, Preco					DECIMAL(18,4)	NOT NULL
	, Ativo					BIT				NOT NULL
	, UsuarioCriacao		VARCHAR(50)		NOT NULL
	, DataCriacao			DATETIME		NOT NULL
	, UsuarioAtualizacao	VARCHAR(50)			NULL
	, DataAtualizacao		DATETIME			NULL
	, CONSTRAINT	PK_GRADE_PRODUTO	PRIMARY KEY	(IdMarca, IdCategoria, IdSegmento, IdCor, IdProduto, IdProdutoItem, IdGradeProduto)
	, CONSTRAINT	FK_PRODUTO_ITEM_GRADE_PRODUTO	FOREIGN KEY	(IdMarca, IdCategoria, IdSegmento, IdCor, IdProduto, IdProdutoItem) REFERENCES dbo.ProdutoItem (IdMarca, IdCategoria, IdSegmento, IdCor, IdProduto, IdProdutoItem)
	, CONSTRAINT	FK_PEDIDO_GRADE_PRODUTO	FOREIGN KEY	(IdPedido) REFERENCES dbo.Pedido (IdPedido)
)
GO