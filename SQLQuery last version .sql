--- Utilisateurs table creation ---
CREATE TABLE [dbo].[Utilisateurs] (
    [Username]          VARCHAR (500) NOT NULL,
    [Nom]               VARCHAR (500) NOT NULL,
    [Prenom]            VARCHAR (500) NOT NULL,
    [Telephone]         NUMERIC (18)  NOT NULL,
    [Mot_De_Passe]      VARCHAR (500) NOT NULL,
    [Adressemail]       VARCHAR (500) NOT NULL,
    [Date_de_naissance] DATE          NOT NULL,
    [Metier]            VARCHAR (500) NULL,
    PRIMARY KEY CLUSTERED ([Username] ASC)
);

---Tirelire table creation ---
CREATE TABLE [dbo].[tirelire] (
    [ID_Tirelire]          INT            IDENTITY (1, 1) NOT NULL,
    [Nom_Tirelire]         VARCHAR (500)  NOT NULL,
    [Montant]              FLOAT (53)     NOT NULL,
    [Description]          VARCHAR (1000) NULL,
    [Utilisateur_Username] VARCHAR (500)  NOT NULL,
    [terminer]             BIT            DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID_Tirelire] ASC),
    FOREIGN KEY ([Utilisateur_Username]) REFERENCES [dbo].[Utilisateurs] ([Username])
);


--- Budget table craction ---
CREATE TABLE [dbo].[Budget] (
    [ID_Budget]            INT           IDENTITY (1, 1) NOT NULL,
    [Montant]              FLOAT (53)    NOT NULL,
    [Mois_Budget]          VARCHAR (500) NOT NULL,
    [Utilisateur_Username] VARCHAR (500) NULL,
    PRIMARY KEY CLUSTERED ([ID_Budget] ASC),
    FOREIGN KEY ([Utilisateur_Username]) REFERENCES [dbo].[Utilisateurs] ([Username])
);


--- transactions table creation ---
CREATE TABLE [dbo].[Transactions] (
    [ID_Transactions]      INT           IDENTITY (1, 1) NOT NULL,
    [Nom_Transactions]     VARCHAR (500) NOT NULL,
    [Montant]              FLOAT (53)    NOT NULL,
    [Date]                 DATETIME      NOT NULL,
    [Categorie]            VARCHAR (500) NOT NULL,
    [Utilisateur_Username] VARCHAR (500) NOT NULL,
    [Budget_IDB]           INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([ID_Transactions] ASC),
    FOREIGN KEY ([Budget_IDB]) REFERENCES [dbo].[Budget] ([ID_Budget]),
    FOREIGN KEY ([Utilisateur_Username]) REFERENCES [dbo].[Utilisateurs] ([Username])
);