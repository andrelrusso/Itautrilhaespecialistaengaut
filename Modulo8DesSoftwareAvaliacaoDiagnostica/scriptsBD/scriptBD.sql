Create DAtabase DbTrilha
GO

USE [DbTrilha]
GO

/****** Object:  View [dbo].[VW_CLIENTE]    Script Date: 30/07/2021 22:19:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 Create VIEW [dbo].[VW_CLIENTE]
 As
 SELECT 
	Nome,
	CPF,
	Endereco as Endereço,
	Banco,
	Agencia as Agência,
	ContaCorrente as [Conta Corrente],
	PIX
 FROM
   TB_CLIENTE
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 30/07/2021 22:19:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[IdCliente] [int] NULL,
	[NomeCliente] [varchar](50) NULL,
	[RG] [varchar](20) NULL,
	[CPF] [varchar](11) NULL,
	[Endereco] [varchar](500) NULL,
	[Produto] [varchar](200) NULL,
	[PrecoVenda] [numeric](18, 2) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_AGENDA_CLIENTE]    Script Date: 30/07/2021 22:19:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_AGENDA_CLIENTE](
	[IdAgenda] [int] NOT NULL,
	[CPF] [bigint] NULL,
	[Telefone] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdAgenda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teste]    Script Date: 30/07/2021 22:19:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teste](
	[idCliente] [numeric](18, 0) NOT NULL,
	[NomeCompleto] [varchar](50) NULL,
	[cpf] [numeric](18, 0) NULL,
	[dataNascimento] [datetime] NULL,
	[telefone] [numeric](18, 0) NULL,
	[email] [varchar](50) NULL,
	[endereco] [varchar](20) NULL,
	[cep] [numeric](8, 0) NULL,
 CONSTRAINT [PK_Teste] PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 30/07/2021 22:19:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[User] [varchar](150) NOT NULL,
	[Senha] [varchar](500) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[User] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TB_AGENDA_CLIENTE]  WITH CHECK ADD  CONSTRAINT [FK_TB_AGENDA_CLIENTE] FOREIGN KEY([CPF])
REFERENCES [dbo].[TB_CLIENTE] ([CPF])
GO
ALTER TABLE [dbo].[TB_AGENDA_CLIENTE] CHECK CONSTRAINT [FK_TB_AGENDA_CLIENTE]
GO
