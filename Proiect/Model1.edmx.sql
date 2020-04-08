
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/13/2020 22:02:58
-- Generated from EDMX file: C:\Users\MrSpV\Desktop\NET\ragnar\Proiect\Proiect\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Poze];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Media'
CREATE TABLE [dbo].[Media] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Path] nvarchar(max)  NOT NULL,
    [Location] nvarchar(max)  NOT NULL,
    [Event] nvarchar(max)  NOT NULL,
    [Scenery] nvarchar(max)  NOT NULL,
    [Status] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Proprietati'
CREATE TABLE [dbo].[Proprietati] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Dinamice'
CREATE TABLE [dbo].[Dinamice] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Data] nvarchar(max)  NOT NULL,
    [PhotoId] int  NOT NULL,
    [PropertiesId] int  NOT NULL
);
GO

-- Creating table 'Persoane'
CREATE TABLE [dbo].[Persoane] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [PhotoId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Media'
ALTER TABLE [dbo].[Media]
ADD CONSTRAINT [PK_Media]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Proprietati'
ALTER TABLE [dbo].[Proprietati]
ADD CONSTRAINT [PK_Proprietati]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Dinamice'
ALTER TABLE [dbo].[Dinamice]
ADD CONSTRAINT [PK_Dinamice]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Persoane'
ALTER TABLE [dbo].[Persoane]
ADD CONSTRAINT [PK_Persoane]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PhotoId] in table 'Dinamice'
ALTER TABLE [dbo].[Dinamice]
ADD CONSTRAINT [FK_PhotoDynamic]
    FOREIGN KEY ([PhotoId])
    REFERENCES [dbo].[Media]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PhotoDynamic'
CREATE INDEX [IX_FK_PhotoDynamic]
ON [dbo].[Dinamice]
    ([PhotoId]);
GO

-- Creating foreign key on [PhotoId] in table 'Persoane'
ALTER TABLE [dbo].[Persoane]
ADD CONSTRAINT [FK_PhotoPerson]
    FOREIGN KEY ([PhotoId])
    REFERENCES [dbo].[Media]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PhotoPerson'
CREATE INDEX [IX_FK_PhotoPerson]
ON [dbo].[Persoane]
    ([PhotoId]);
GO

-- Creating foreign key on [PropertiesId] in table 'Dinamice'
ALTER TABLE [dbo].[Dinamice]
ADD CONSTRAINT [FK_PropertiesDynamic]
    FOREIGN KEY ([PropertiesId])
    REFERENCES [dbo].[Proprietati]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PropertiesDynamic'
CREATE INDEX [IX_FK_PropertiesDynamic]
ON [dbo].[Dinamice]
    ([PropertiesId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------