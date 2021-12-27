CREATE DATABASE Library
USE Library

CREATE TABLE Libraries(
	Id int identity primary key,
	Name nvarchar(100) NOT NULL,
	BookSize int
)	

CREATE TABLE Books(
	Id int identity primary key,
	Name nvarchar(50) NOT NULL,
	Writer nvarchar(100) NOT NULL,
	[Year] nvarchar 
)

CREATE TABLE LibraryBook(
	Id int identity primary key,
	LibraryId int references Libraries(Id),
	BookId int references Books(Id)
)

INSERT INTO Libraries
VALUES(1,'Akhundov Library',5000)

SELECT * FROM Libraries

INSERT INTO Books
VALUES('Sherlock Holmes','Arthur Conan Doyle','1887')

SELECT * FROM Books

DROP TABLE LibraryBook
