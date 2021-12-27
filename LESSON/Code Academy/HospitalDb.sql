CREATE DATABASE HospitalDb
USE HospitalDb
CREATE TABLE Departments(
	Id int identity primary key,
	Name nvarchar(150) NOT NULL,
	DoctorCount int --Departamentdeki doktor sayi
)
CREATE TABLE Doctors(
	Id int identity primary key,
	FullName nvarchar(150) NOT NULL,
	Birthday nvarchar(100) NOT NULL,
	Speciality nvarchar(150) NOT NULL,
	Salary int NOT NULL
)
CREATE TABLE DepartmentDoctor(
	Id int identity primary key,
	DepartmentId int references Departments(Id),
	DoctorId int references Doctors(Id)
)
CREATE TABLE Patients(
	Id int identity primary key,
	Fullname nvarchar(150) NOT NULL,
	Birthday nvarchar(50) NOT NULL,
	Gender nvarchar(50),
	[Address] nvarchar(150)
)
CREATE TABLE DoctorPatient(
	Id int identity primary key,
	DoctorId int references Doctors(Id),
	PatientId int references Patients(Id)
)
CREATE TABLE Diseases(
	Id int identity primary key,
	[Name] nvarchar(150)
)
CREATE TABLE PatientDisease(
	Id int identity primary key,
	PatientId int references Patients(Id),
	DiseaseId int references Diseases(Id)
)
CREATE TABLE Treatments(
	Id int identity primary key,
	[Name] nvarchar(150)
)
CREATE TABLE PatientTreatment(
	Id int identity primary key,
	PatientId int references Patients(Id),
	TreatmentId int references Treatments(Id)
)
CREATE TABLE Staff(
	Id int identity primary key,
	FullName nvarchar(150) NOT NULL,
	Duty nvarchar(100) NOT NULL,
	Salary int NOT NULL,
	DependOn int
)
CREATE TABLE Analysis(
	Id int identity primary key,
	[Name] nvarchar(100) NOT NULL,
	Price int
)
CREATE TABLE PatientAnalysis(
	Id int identity primary key,
	PatientId int references Patients(Id),
	AnalysisId int references Analysis(Id)
)
ALTER TABLE DoctorPatient
ADD Room int,
		   [Date] nvarchar(50)

INSERT INTO Departments
VALUES('Cardiology',20),
      ('Neurology',15),
	  ('Oncology',30),
	  ('Radioteraphy',12),
	  ('Ear nose and throat',22),
	  ('General surgery',16),
	  ('Gynaecology',22),
	  ('Microbiology',18),
	  ('Accident and emergency',35),
	  ('Radiotheraphy',14)

INSERT INTO Doctors
VALUES('Brain May','25.12.1985','Cardiologists',6500),
	  ('Robert Langdon','01.01.1965','Ophthalmologists',8500),
	  ('Remus Lupin','29.08.1972','Dermatologists',5400),
	  ('Severus Snape','15.10.1956','Endocrinologists',4800),
	  ('Hank Pym','30.05.1990','Nephrologists',2300),
	  ('Jon Benjamin','03.09.1983','Oncologists',6900)
INSERT INTO Patients
VALUES('Robert R. Moore','26.10.1941','Male','1245 Maxwell Street'),
	  ('George T. Bryant','19.04.1970','Male','3039 Williams Avenue'),
	  ('Lisette J. Hollis','13.05.1982','Female','1005 Dale Avenue'),
	  ('Shawnna C. Helton','02.11.2001','Female','3355 Cliffside Drive'),
	  ('Melissa R. Duvall','20.11.1972','Female','185 Alexander Drive'),
	  ('Earnest G. Prinz','02.01.1945','Male','2302 Allison Avenue'),
	  ('Marcella C. Woods','09.12.1953','Female','668 Kenwood Place')
INSERT INTO Diseases
VALUES('Cancer'),
      ('Diabetes'),
      ('Depression'),
      ('Crabs'),
      ('Flu'),
      ('Heart Disease'),
      ('Hepatitis'),
      ('Lupus'),
      ('Meningitis'),
      ('Parkinsons Disease'),
	  ('SARS'),
	  ('Headaches')
INSERT INTO Treatments
VALUES('Cognitive-behavioral therapy'),
      ('Dialectical behavior therapy'),
	  ('Eye movement desensitization'),
	  ('Chemoteraphy')
INSERT INTO Staff
VALUES('Charles T. Poff','CEO',18000,NULL),
	  ('John C. Lin','Director',16000,1),
	  ('Terry T. Bowman','Manager',15000,2),
	  ('Monica J. Block','Manager',1500,2),
	  ('Eileen R. Allen','Manager',1400,2),
	  ('Patient advocate','Manager',1200,3),
	  ('Mae E. Comer','Patient care technicians',3000,3),
	  ('Frank D. Burger','Nurse practitioners',2400,3)
INSERT INTO Analysis
VALUES('Blood Test',20),
	  ('Pregnancy Test',25),
	  ('Diabet Test',45),
	  ('Cancer Test',100),
	  ('X-ray',85)

ALTER TABLE Patients
ADD DoctorPatientId int references DoctorPatient(Id)

ALTER TABLE Patients
ADD PatientDiseaseId int references PatientDisease(Id)

ALTER TABLE Patients
ADD PatientTreatmentId int references PatientTreatment(Id)

ALTER TABLE Patients
ADD PatientAnalysisId int references PatientAnalysis(Id)

use HospitalDb
ALTER TABLE Patients
ADD [Status] nvarchar(150)

CREATE VIEW PatientCard
AS
SELECT p.Id,
	   p.Fullname,
	   p.Birthday,
	   p.Gender,
	   p.[Address],
	   dp.Room,
	   dp.Date,
	   p.[Status],
	   d.FullName 'DoctorName',
	   ds.Name 'Disease',
	   t.Name 'Treatment',
	   a.Name 'Analysis',
	   a.Price
FROM Patients p
JOIN DoctorPatient dp
ON
dp.PatientId=p.Id

JOIN Doctors d
ON
DP.DoctorId=D.Id

JOIN Diseases ds
ON
ds.Id=p.PatientDiseaseId

LEFT JOIN Treatments t
ON
t.Id=p.PatientTreatmentId

JOIN Analysis a
ON
a.Id=p.PatientAnalysisId

SELECT * FROM PatientCard