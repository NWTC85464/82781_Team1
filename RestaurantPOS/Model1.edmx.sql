
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/06/2018 17:01:31
-- Generated from EDMX file: C:\Users\hanna\Source\Repos\NWTC85464\82781_Team1\RestaurantPOS\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Restaurant];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Chefs_inherits_Employees]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employees_Chefs] DROP CONSTRAINT [FK_Chefs_inherits_Employees];
GO
IF OBJECT_ID(N'[dbo].[FK_Managers_inherits_Employees]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employees_Managers] DROP CONSTRAINT [FK_Managers_inherits_Employees];
GO
IF OBJECT_ID(N'[dbo].[FK_MenuItemsMenu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MenuItems] DROP CONSTRAINT [FK_MenuItemsMenu];
GO
IF OBJECT_ID(N'[dbo].[FK_MenuItemsOrderItem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrderItems] DROP CONSTRAINT [FK_MenuItemsOrderItem];
GO
IF OBJECT_ID(N'[dbo].[FK_OrdersOrderItem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrderItems] DROP CONSTRAINT [FK_OrdersOrderItem];
GO
IF OBJECT_ID(N'[dbo].[FK_RestaurantEmployees]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employees] DROP CONSTRAINT [FK_RestaurantEmployees];
GO
IF OBJECT_ID(N'[dbo].[FK_RestaurantMenu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Menus] DROP CONSTRAINT [FK_RestaurantMenu];
GO
IF OBJECT_ID(N'[dbo].[FK_TablesOrders]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Orders] DROP CONSTRAINT [FK_TablesOrders];
GO
IF OBJECT_ID(N'[dbo].[FK_Waitstaffs_inherits_Employees]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employees_Waitstaffs] DROP CONSTRAINT [FK_Waitstaffs_inherits_Employees];
GO
IF OBJECT_ID(N'[dbo].[FK_WaitstaffTables]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Tables] DROP CONSTRAINT [FK_WaitstaffTables];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Employees]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employees];
GO
IF OBJECT_ID(N'[dbo].[Employees_Chefs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employees_Chefs];
GO
IF OBJECT_ID(N'[dbo].[Employees_Managers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employees_Managers];
GO
IF OBJECT_ID(N'[dbo].[Employees_Waitstaffs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employees_Waitstaffs];
GO
IF OBJECT_ID(N'[dbo].[MenuItems]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MenuItems];
GO
IF OBJECT_ID(N'[dbo].[Menus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Menus];
GO
IF OBJECT_ID(N'[dbo].[OrderItems]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OrderItems];
GO
IF OBJECT_ID(N'[dbo].[Orders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Orders];
GO
IF OBJECT_ID(N'[dbo].[Restaurants]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Restaurants];
GO
IF OBJECT_ID(N'[dbo].[Tables]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tables];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Employees'
CREATE TABLE [dbo].[Employees] (
    [employeeNumber] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [employeePasscode] int  NOT NULL,
    [jobTitle] nvarchar(max)  NOT NULL,
    [Restaurant_restaurantId] int  NOT NULL
);
GO

-- Creating table 'Tables'
CREATE TABLE [dbo].[Tables] (
    [tableNumber] int IDENTITY(1,1) NOT NULL,
    [numberOfGuests] nvarchar(max)  NOT NULL,
    [isActive] nvarchar(max)  NOT NULL,
    [Waitstaff_employeeNumber] int  NOT NULL
);
GO

-- Creating table 'MenuItems'
CREATE TABLE [dbo].[MenuItems] (
    [menuItemId] int IDENTITY(1,1) NOT NULL,
    [menuItemName] nvarchar(max)  NOT NULL,
    [menuItemPrice] nvarchar(max)  NOT NULL,
    [menuItemDescription] nvarchar(max)  NOT NULL,
    [isItemActive] nvarchar(max)  NOT NULL,
    [Menu_MenuId] int  NOT NULL
);
GO

-- Creating table 'Menus'
CREATE TABLE [dbo].[Menus] (
    [MenuId] int IDENTITY(1,1) NOT NULL,
    [menuName] nvarchar(max)  NOT NULL,
    [Restaurant_restaurantId] int  NOT NULL
);
GO

-- Creating table 'Restaurants'
CREATE TABLE [dbo].[Restaurants] (
    [restaurantId] int IDENTITY(1,1) NOT NULL,
    [restaurantName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'OrderItems'
CREATE TABLE [dbo].[OrderItems] (
    [orderItemId] int IDENTITY(1,1) NOT NULL,
    [quantity] nvarchar(max)  NOT NULL,
    [MenuItems_menuItemID] int  NOT NULL,
    [Orders_orderNumber] int  NULL
);
GO

-- Creating table 'Orders'
CREATE TABLE [dbo].[Orders] (
    [orderNumber] int IDENTITY(1,1) NOT NULL,
    [Tables_tableNumber] int  NOT NULL,
    [isActive] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Employees_Waitstaffs'
CREATE TABLE [dbo].[Employees_Waitstaffs] (
    [employeeNumber] int  NOT NULL
);
GO

-- Creating table 'Employees_Chefs'
CREATE TABLE [dbo].[Employees_Chefs] (
    [employeeNumber] int  NOT NULL
);
GO

-- Creating table 'Employees_Managers'
CREATE TABLE [dbo].[Employees_Managers] (
    [employeeNumber] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [employeeNumber] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [PK_Employees]
    PRIMARY KEY CLUSTERED ([employeeNumber] ASC);
GO

-- Creating primary key on [tableNumber] in table 'Tables'
ALTER TABLE [dbo].[Tables]
ADD CONSTRAINT [PK_Tables]
    PRIMARY KEY CLUSTERED ([tableNumber] ASC);
GO

-- Creating primary key on [menuItemId] in table 'MenuItems'
ALTER TABLE [dbo].[MenuItems]
ADD CONSTRAINT [PK_MenuItems]
    PRIMARY KEY CLUSTERED ([menuItemId] ASC);
GO

-- Creating primary key on [MenuId] in table 'Menus'
ALTER TABLE [dbo].[Menus]
ADD CONSTRAINT [PK_Menus]
    PRIMARY KEY CLUSTERED ([MenuId] ASC);
GO

-- Creating primary key on [restaurantId] in table 'Restaurants'
ALTER TABLE [dbo].[Restaurants]
ADD CONSTRAINT [PK_Restaurants]
    PRIMARY KEY CLUSTERED ([restaurantId] ASC);
GO

-- Creating primary key on [orderItemId] in table 'OrderItems'
ALTER TABLE [dbo].[OrderItems]
ADD CONSTRAINT [PK_OrderItems]
    PRIMARY KEY CLUSTERED ([orderItemId] ASC);
GO

-- Creating primary key on [orderNumber] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [PK_Orders]
    PRIMARY KEY CLUSTERED ([orderNumber] ASC);
GO

-- Creating primary key on [employeeNumber] in table 'Employees_Waitstaffs'
ALTER TABLE [dbo].[Employees_Waitstaffs]
ADD CONSTRAINT [PK_Employees_Waitstaffs]
    PRIMARY KEY CLUSTERED ([employeeNumber] ASC);
GO

-- Creating primary key on [employeeNumber] in table 'Employees_Chefs'
ALTER TABLE [dbo].[Employees_Chefs]
ADD CONSTRAINT [PK_Employees_Chefs]
    PRIMARY KEY CLUSTERED ([employeeNumber] ASC);
GO

-- Creating primary key on [employeeNumber] in table 'Employees_Managers'
ALTER TABLE [dbo].[Employees_Managers]
ADD CONSTRAINT [PK_Employees_Managers]
    PRIMARY KEY CLUSTERED ([employeeNumber] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Restaurant_restaurantId] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [FK_RestaurantEmployees]
    FOREIGN KEY ([Restaurant_restaurantId])
    REFERENCES [dbo].[Restaurants]
        ([restaurantId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RestaurantEmployees'
CREATE INDEX [IX_FK_RestaurantEmployees]
ON [dbo].[Employees]
    ([Restaurant_restaurantId]);
GO

-- Creating foreign key on [Restaurant_restaurantId] in table 'Menus'
ALTER TABLE [dbo].[Menus]
ADD CONSTRAINT [FK_RestaurantMenu]
    FOREIGN KEY ([Restaurant_restaurantId])
    REFERENCES [dbo].[Restaurants]
        ([restaurantId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RestaurantMenu'
CREATE INDEX [IX_FK_RestaurantMenu]
ON [dbo].[Menus]
    ([Restaurant_restaurantId]);
GO

-- Creating foreign key on [Menu_MenuId] in table 'MenuItems'
ALTER TABLE [dbo].[MenuItems]
ADD CONSTRAINT [FK_MenuItemsMenu]
    FOREIGN KEY ([Menu_MenuId])
    REFERENCES [dbo].[Menus]
        ([MenuId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MenuItemsMenu'
CREATE INDEX [IX_FK_MenuItemsMenu]
ON [dbo].[MenuItems]
    ([Menu_MenuId]);
GO

-- Creating foreign key on [MenuItems_menuItemID] in table 'OrderItems'
ALTER TABLE [dbo].[OrderItems]
ADD CONSTRAINT [FK_MenuItemsOrderItem]
    FOREIGN KEY ([MenuItems_menuItemID])
    REFERENCES [dbo].[MenuItems]
        ([menuItemId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MenuItemsOrderItem'
CREATE INDEX [IX_FK_MenuItemsOrderItem]
ON [dbo].[OrderItems]
    ([MenuItems_menuItemID]);
GO

-- Creating foreign key on [Waitstaff_employeeNumber] in table 'Tables'
ALTER TABLE [dbo].[Tables]
ADD CONSTRAINT [FK_WaitstaffTables]
    FOREIGN KEY ([Waitstaff_employeeNumber])
    REFERENCES [dbo].[Employees_Waitstaffs]
        ([employeeNumber])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_WaitstaffTables'
CREATE INDEX [IX_FK_WaitstaffTables]
ON [dbo].[Tables]
    ([Waitstaff_employeeNumber]);
GO

-- Creating foreign key on [Tables_tableNumber] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [FK_TablesOrders]
    FOREIGN KEY ([Tables_tableNumber])
    REFERENCES [dbo].[Tables]
        ([tableNumber])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TablesOrders'
CREATE INDEX [IX_FK_TablesOrders]
ON [dbo].[Orders]
    ([Tables_tableNumber]);
GO

-- Creating foreign key on [Orders_orderNumber] in table 'OrderItems'
ALTER TABLE [dbo].[OrderItems]
ADD CONSTRAINT [FK_OrdersOrderItem]
    FOREIGN KEY ([Orders_orderNumber])
    REFERENCES [dbo].[Orders]
        ([orderNumber])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OrdersOrderItem'
CREATE INDEX [IX_FK_OrdersOrderItem]
ON [dbo].[OrderItems]
    ([Orders_orderNumber]);
GO

-- Creating foreign key on [employeeNumber] in table 'Employees_Waitstaffs'
ALTER TABLE [dbo].[Employees_Waitstaffs]
ADD CONSTRAINT [FK_Waitstaffs_inherits_Employees]
    FOREIGN KEY ([employeeNumber])
    REFERENCES [dbo].[Employees]
        ([employeeNumber])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [employeeNumber] in table 'Employees_Chefs'
ALTER TABLE [dbo].[Employees_Chefs]
ADD CONSTRAINT [FK_Chefs_inherits_Employees]
    FOREIGN KEY ([employeeNumber])
    REFERENCES [dbo].[Employees]
        ([employeeNumber])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [employeeNumber] in table 'Employees_Managers'
ALTER TABLE [dbo].[Employees_Managers]
ADD CONSTRAINT [FK_Managers_inherits_Employees]
    FOREIGN KEY ([employeeNumber])
    REFERENCES [dbo].[Employees]
        ([employeeNumber])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------