CREATE TABLE [dbo].[Fornecedor] (
    [id_fornecedor] INT           NOT NULL IDENTITY,
    [foto]          VARCHAR (250) NULL,
    [telefone]      VARCHAR (12)  NULL,
    [senha]         VARCHAR (16)  NULL,
    [nome]          VARCHAR (20)  NULL,
    [usuario]       VARCHAR (16)  NULL,
    [cpf]           VARCHAR (11)  NULL,
    [email]         VARCHAR (20)  NULL,
    [cep]           VARCHAR (8)   NULL,
    PRIMARY KEY CLUSTERED ([id_fornecedor] ASC)
);

