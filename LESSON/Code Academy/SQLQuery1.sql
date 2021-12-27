CREATE DATABASE P125
USE P125
CREATE TABLE Students(
	Id int,
	[Name] nvarchar(50),
	Surname nvarchar(50)
	) 

ALTER TABLE Students
ADD Age int

INSERT INTO Students
VALUES(1,'Gunel','Humbatova',18),(2,'Sevinc','Alieva',16)

Select * from Students
Select Name From Students
Where age>16