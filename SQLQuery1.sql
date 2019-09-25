CREATE DATABASE [Encryption]
GO

USE [Encryption]
GO

CREATE TABLE [Users] (
    [UserID]   int NOT NULL IDENTITY,
    [Username] nvarchar(max) NOT NULL,
	[Password] nvarchar(max) NOT NULL,
    PRIMARY KEY ([UserID])
);
GO