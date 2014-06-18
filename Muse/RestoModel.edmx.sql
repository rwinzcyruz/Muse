
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/18/2014 15:16:29
-- Generated from EDMX file: D:\Github\Muse\Muse\RestoModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [RestoDb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CustomerBill]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bills] DROP CONSTRAINT [FK_CustomerBill];
GO
IF OBJECT_ID(N'[dbo].[FK_BillOrder]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Orders] DROP CONSTRAINT [FK_BillOrder];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductOrder]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Orders] DROP CONSTRAINT [FK_ProductOrder];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[Customers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Customers];
GO
IF OBJECT_ID(N'[dbo].[Bills]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Bills];
GO
IF OBJECT_ID(N'[dbo].[Orders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Orders];
GO
IF OBJECT_ID(N'[dbo].[Products]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Products];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(256)  NOT NULL,
    [Username] nvarchar(256)  NOT NULL,
    [Password] nvarchar(256)  NOT NULL,
    [Gender] bit  NULL,
    [Address] nvarchar(256)  NULL,
    [Email] nvarchar(256)  NULL,
    [Phone] nvarchar(20)  NULL,
    [CreatedAt] datetime  NOT NULL,
    [UpdatedAt] datetime  NOT NULL
);
GO

-- Creating table 'Customers'
CREATE TABLE [dbo].[Customers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(256)  NOT NULL,
    [Gender] bit  NULL,
    [Address] nvarchar(256)  NULL,
    [Email] nvarchar(256)  NULL,
    [Phone] nvarchar(20)  NULL,
    [CreatedAt] datetime  NOT NULL,
    [UpdatedAt] datetime  NOT NULL
);
GO

-- Creating table 'Bills'
CREATE TABLE [dbo].[Bills] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Tax] float  NOT NULL,
    [Paid] bit  NOT NULL,
    [CustomerId] int  NOT NULL,
    [CreatedAt] datetime  NOT NULL,
    [UpdatedAt] datetime  NOT NULL
);
GO

-- Creating table 'Orders'
CREATE TABLE [dbo].[Orders] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Quantity] int  NOT NULL,
    [BillId] int  NOT NULL,
    [CreatedAt] datetime  NOT NULL,
    [UpdatedAt] datetime  NOT NULL,
    [ProductId] int  NOT NULL
);
GO

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(256)  NOT NULL,
    [Price] int  NOT NULL,
    [Description] nvarchar(256)  NULL,
    [CreatedAt] datetime  NOT NULL,
    [UpdatedAt] datetime  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [PK_Customers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Bills'
ALTER TABLE [dbo].[Bills]
ADD CONSTRAINT [PK_Bills]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [PK_Orders]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CustomerId] in table 'Bills'
ALTER TABLE [dbo].[Bills]
ADD CONSTRAINT [FK_CustomerBill]
    FOREIGN KEY ([CustomerId])
    REFERENCES [dbo].[Customers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CustomerBill'
CREATE INDEX [IX_FK_CustomerBill]
ON [dbo].[Bills]
    ([CustomerId]);
GO

-- Creating foreign key on [BillId] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [FK_BillOrder]
    FOREIGN KEY ([BillId])
    REFERENCES [dbo].[Bills]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BillOrder'
CREATE INDEX [IX_FK_BillOrder]
ON [dbo].[Orders]
    ([BillId]);
GO

-- Creating foreign key on [ProductId] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [FK_ProductOrder]
    FOREIGN KEY ([ProductId])
    REFERENCES [dbo].[Products]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductOrder'
CREATE INDEX [IX_FK_ProductOrder]
ON [dbo].[Orders]
    ([ProductId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------