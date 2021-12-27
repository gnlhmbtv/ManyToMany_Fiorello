CREATE DATABASE LIBRARYDB
USE LIBRARYDB
CREATE TABLE Libraries(
	Id int identity primary key,
	Name nvarchar(100) NOT NULL,
	BookSize int
)	

CREATE TABLE Books(
	Id int identity primary key,
	Name nvarchar(50) NOT NULL,
	Writer nvarchar(100) NOT NULL,
	[Year] nvarchar(5)
)

CREATE TABLE LibraryBook(
	Id int identity primary key,
	LibraryId int references Libraries(Id),
	BookId int references Books(Id)
)

INSERT INTO Libraries
VALUES('Akhundov Library',5000)

SELECT * FROM Libraries

INSERT INTO Books
VALUES('Sherlock Holmes','Arthur Conan Doyle','1887')
INSERT INTO Books
VALUES ('Romeo and Juliet','William Shakespeare','1597')

SELECT * FROM Books

ALTER TABLE Books
DROP COLUMN Year

ALTER TABLE Books
ADD Year nvarchar(15)

CREATE TABLE Genres(
	Id int identity primary key,
	LibraryId int references Libraries(Id),
	BookId int references Books(Id)
)
