
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/11/2019 08:12:51
-- Generated from EDMX file: C:\Users\eepstein\Documents\Projects\chasya\photo-project\photo-backend\Persistance\Photo.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [PhotoEndProject];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Orders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Orders];
GO
IF OBJECT_ID(N'[dbo].[pakages]', 'U') IS NOT NULL
    DROP TABLE [dbo].[pakages];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[PhotoEndProjectModelStoreContainer].[Photos]', 'U') IS NOT NULL
    DROP TABLE [PhotoEndProjectModelStoreContainer].[Photos];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Orders'
CREATE TABLE [dbo].[Orders] (
    [orderId] int  NOT NULL,
    [pacageId] varchar(20)  NOT NULL,
    [dateOrder] datetime  NULL,
    [numberOfOurs] int  NOT NULL,
    [Publishable] bit  NULL,
    [userId] int  NOT NULL
);
GO

-- Creating table 'pakages'
CREATE TABLE [dbo].[pakages] (
    [pacageId] varchar(20)  NOT NULL,
    [pacageType] varchar(20)  NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [userId] int  NOT NULL,
    [userName] varchar(20)  NOT NULL,
    [userPassword] varchar(10)  NULL,
    [emailAddress] varchar(20)  NOT NULL,
    [cellPhoneNumber] varchar(10)  NULL,
    [userType] bit  NULL
);
GO

-- Creating table 'Photos'
CREATE TABLE [dbo].[Photos] (
    [orderId] int  NOT NULL,
    [photoUrl] varchar(20)  NULL,
    [selected] bit  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [orderId] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [PK_Orders]
    PRIMARY KEY CLUSTERED ([orderId] ASC);
GO

-- Creating primary key on [pacageId] in table 'pakages'
ALTER TABLE [dbo].[pakages]
ADD CONSTRAINT [PK_pakages]
    PRIMARY KEY CLUSTERED ([pacageId] ASC);
GO

-- Creating primary key on [userId] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([userId] ASC);
GO

-- Creating primary key on [orderId] in table 'Photos'
ALTER TABLE [dbo].[Photos]
ADD CONSTRAINT [PK_Photos]
    PRIMARY KEY CLUSTERED ([orderId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------