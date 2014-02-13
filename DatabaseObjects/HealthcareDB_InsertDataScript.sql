USE HealthCareDB;
GO

-- Fills Contacts tbl with test data.
INSERT INTO Contacts (FirstName, LastName)
VALUES ('John', 'Candy') -- ContactId 1, Patient
, ('Steve', 'Martin') -- ContactId 2, Dr.
, ('Chevy', 'Chase') -- ContactId 3, Patient
, ('Bill', 'Murray') -- ContactId 4, Dr.
, ('Richard', 'Pryor'); -- ContactId 5, Patient 

-- Fills Patients tbl with test data.
INSERT INTO Patients (ContactId)
VALUES (1)
, (3)
, (5);

-- Fills Doctors tbl with data.
INSERT INTO Doctors (ContactId)
VALUES (2)
, (4);

-- Fills PhoneNumbers tbl with data.
INSERT INTO PhoneNumbers (ContactId, PhoneNum)
VALUES (1, '425-890-5535')
, (2, '425-256-2573')
, (3, '808-422-2222')
, (4, '808-533-3333')
, (5, '253-425-8070');

-- This var holds today's date for filling the tbl with relevant datetimes
DECLARE @TodaysDate datetime = GETDATE();

-- Fills Appointments tbl with data.
-- None of the patients are checked in
INSERT INTO Appointments (PatientId, DoctorId, DateTime, Status)
VALUES (1, 2, @TodaysDate, 0)
,(2, 1, @TodaysDate, 0)
,(3, 2, @TodaysDate, 0);

GO

--------------------------------------------------------------
/* 
	The below DELETE statement will remove all 
	the data from the tbls in HealthcareDB. 
	
	Uncomment to use.
*/
--DELETE FROM CONTACTS;
--GO

--------------------------------------------------------------
/*
	Use the below statements to verify that data
	is or isn't present in the tbls.
*/
--SELECT * FROM Contacts;
--SELECT * FROM Patients;
--SELECT * FROM Doctors;
--SELECT * FROM PhoneNumbers;
--SELECT * FROM Appointments;
--------------------------------------------------------------

/*
	The following drop statements:
		- Sever all connections to HealthcareDB so it can be dropped.
		- & DROP the database.
*/
--ALTER DATABASE HealthcareDB
--SET OFFLINE
--WITH ROLLBACK IMMEDIATE;
--GO

--DROP DATABASE HealthCareDB;
--GO