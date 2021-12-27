--CREATE DATABASE [Join]
--USE [Join]


--******************* SELF JOIN *********************
--CREATE TABLE Devices(
--	Id int identity primary key,
--	Device nvarchar(100) NOT NULL,
--	DependOn int
--)
--INSERT INTO Devices
--VALUES ('Device',0),
--('Smartphone',1),('Laptop',1),('Tablet',1),('Asus Zenfone',3),('Iphone 11',2),('Galaxy Tab4',4)

--SELECT d1.Device DeviceType,d2.Device FROM Devices d1
--LEFT JOIN
--Devices d2	
--ON
--d1.DependOn=d2.Id 




--**********************CROSS JOIN*********************

--CREATE TABLE Products(
--	Id int identity primary key,
--	[Name] nvarchar(100) NOT NULL,
--	Price decimal(10,2) NOT NULL,
--	ExpirationDate nvarchar(15) NOT NULL
--)

--CREATE TABLE Customer(
--	Id int identity primary key,
--	FullName nvarchar(100) NOT NULL,
--	Email nvarchar(100),
--	Phone nvarchar(20) NOT NULL
--)

--ALTER TABLE Products
--ADD Type nvarchar(50) 
--GO
--ALTER TABLE Products
--ADD Brand nvarchar(50) 
--GO

--INSERT INTO Products
--VALUES ('HighSky',15.99,'01.12.2022','Mascara','Maybelline'),
--('Fit Me',10.99,'01.01.2023','Foundation','Maybelline'),
--('Revolution',19.90,'25.09.2025','Palette','MAC')

--INSERT INTO Customer
--VALUES('Gunel Humbatova','guneljh@code.edu.az','+994555893457'),
--('Sevinc ALieva','sevaaliva@gmail.com','+994552466653'),
--('Fatima Alieva','fatosh07@mail.ru','+994502563365')


--SELECT * FROM Products 
--CROSS JOIN Customer 

--SELECT Name,FullName FROM Products 
--CROSS JOIN Customer 




--*****************Non-Equi Join*****************
CREATE TABLE PROPERTIES(
	Id int identity primary key,
	City nvarchar(50) NOT NULL,
	[Floor] int check([Floor]>=0),
	Rooms int check(Rooms>0) NOT NULL,
	Area decimal(10,2) check(Area>0) NOT NULL,
	Price decimal(1000,2) check(Price>0) NOT NULL
)

CREATE TABLE RENTERS(
	Id int identity primary key,
	FullName nvarchar(100) NOT NULL,
	MinRooms int,
	MinArea decimal,
	MinPrice int check(MinPrice>0),
	MaxPrice int check(MaxPrice>0)
)

INSERT INTO PROPERTIES
VALUES('Baku',5,4,100,150000),('Ganja',Null,3,65,86000)

INSERT INTO RENTERS
VALUES('Gunel Humbatova',2,100,80000,350000),('Sevinc Aliyeva',4,250,80000,700000)

SELECT rt.FullName,prp.City,prp.Price HousePrice FROM RENTERS rt
JOIN PROPERTIES prp
ON
prp.Price between rt.MinPrice and rt.MaxPrice
