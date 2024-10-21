create database myDataBase;

use myDataBase;

create table Book(
	[Id] int primary key identity,
	[Name] nvarchar(max) not null,
	[Author] nvarchar(max) not null,
	[Description] nvarchar(max) null,
	[Price] money not null
)