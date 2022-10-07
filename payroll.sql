CREATE DATABASE PAYROLL
USE PAYROLL

--TABLES

GO
CREATE TABLE tblEmployeeType (
              empTypeId				INT PRIMARY KEY IDENTITY (1,1),
			  empTypeName			VARCHAR(30)NOT NULL,
			  empTypeDescription	VARCHAR(MAX),
			  )

CREATE TABLE tblDepartment (
              depId				INT PRIMARY KEY IDENTITY(1,1),
			  depName			VARCHAR(30) NOT NULL,
			  depDescription	VARCHAR(MAX)
	                    )
CREATE TABLE tblGroup(
              groupId				INT PRIMARY KEY IDENTITY(1,1),
			  groupName			VARCHAR(30) NOT NULL,
			  groupDescription	VARCHAR(MAX)
              )
CREATE TABLE tblEmployee (
            empId				INT PRIMARY KEY IDENTITY(100000,1),
			empFirstName		VARCHAR (30) NOT NULL,
			empLastName			VARCHAR (30) NOT NULL,
			empSex				CHAR(1) NOT NULL,
			empBasicSalary		MONEY NOT NULL,
			empDateofBirth		DATE,
			empDateOfEmployment	DATE,
			empImage			IMAGE,
			empTelNo			VARCHAR(15),
			empEmergencyContact VARCHAR(15),
			empDepId			INT,
			empTypeId			INT,
			empGroupId			INT,
			insertedBy			INT,
			insertedDate		DATETIME
			)
CREATE TABLE tblAttendance(
		     empId					INT NOT NULL,
             attenDate				DATE NOT NULL,
			 firstStartTime			TIME NOT NULL,
			 firstEndTime			TIME,
			 lastStartTime			TIME ,
			 lastEndTime			TIME,
			 PRIMARY KEY(empId,attenDate)
			 )

CREATE TABLE tblOverTime(
             otId			INT PRIMARY KEY IDENTITY(1,1),
			 otName			VARCHAR(30) NOT NULL,
			 otHourlyRate	FLOAT NOT NULL,
			 startTime		 DATETIME,
			 endTime		DATETIME,
			 [description]	VARCHAR(max),
             )
			 
CREATE TABLE tblOverTimeDetail(
            empId			INT  NOT NULL,
			otID			INT NOT NULL,
			otDate			DATE NOT NULL,
			otStartTime		TIME NOT NULL,
			otEndTime		TIME	
			PRIMARY KEY(empId,otID,otDate)
			)

CREATE TABLE tblMonthlyData(
			 empId						INT NOT NULL,
             monDataMonth				INT,
			 monDataYear				INT,	
			 monDataUnpaidSalary		MONEY,
			 monDataUnpaidPension		MONEY,
			 monDataUnpaidIncomeTax		MONEY,
			 monDataIncentive			MONEY,
			 monDataMedical				MONEY,
             monDataCourtCase			MONEY,
			 monDataFine				MONEY,
			 monDataOverPayment			MONEY,
			 monDataActingAllowance		MONEY,
			 monDataMobileandTransport	MONEY,
			 monDataSaving				MONEY,
			 monDataOtherContribution	MONEY,
			 insertedBy					INT,
			 insertedDate				DATETIME
			 PRIMARY KEY(empId,monDataMonth,monDataYear)
			)
			
CREATE TABLE USERS(
				userID		INT PRIMARY KEY IDENTITY,
				username	VARCHAR(20) NOT NULL,
				[password]	VARCHAR(20) NOT NULL,
				firstName	VARCHAR(30) NOT NULL,
				lastName	VARCHAR(30)  NOT NULL,
				userImage	IMAGE  ,
				[role]		VARCHAR(15) NOT NULL
				)

GO
--CLONE TABLES
CREATE TABLE tblDeletedDepartment (
              depId				INT ,
			  depName			VARCHAR(30),
			  depDescription	VARCHAR(MAX),
			  deletedByUser		INT,
			  [action]			VARCHAR(10),
			  dateDeleted		DATETIME
			  )		                    
						


CREATE TABLE tblDeletedMonthlyData(
			 empId						INT,
             monDataMonth				INT,
			 monDataYear				INT,	
			 monDataUnpaidSalary		MONEY,
			 monDataUnpaidPension		MONEY,
			 monDataIncentive			MONEY,
			 monDataMedical				MONEY,
             monDataCourtCase			MONEY,
			 monDataFine				MONEY,
			 monDataOverPayment			MONEY,
			 monDataActingAllowance		MONEY,
			 monDataMobileandTransport	MONEY,
			 monDataSaving				MONEY,
			 monDataOtherContribution	MONEY,
			 insertedBy					INT,
			 insertedDate				DATETIME,
			 deletedByUser		INT,
			 [action]			VARCHAR(10),
			 dateDeleted		DATETIME
			)

CREATE TABLE tblDeletedEmployee (
            empId				INT ,
			empFirstName		VARCHAR (30),
			empLastName			VARCHAR (30) ,
			empSex				CHAR(1) ,
			empBasicSalary		MONEY,
			empDateofBirth		DATE,
			empDateOfEmployment	DATE,
			empImage			IMAGE,
			empTelNo			VARCHAR(15),
			empEmergencyContact VARCHAR(15),
			empDepId			INT,
			empTypeId			INT,
			empGroupId			INT,
			insertedBy			INT,
			insertedDate		DATETIME,
			deletedByUser		INT,
			[action]			VARCHAR(10),
			dateDeleted		DATETIME
)
			
CREATE TABLE tblDeletedOvertimeDetail(
empId			INT  NOT NULL,
otID			INT NOT NULL,
otDate			DATE NOT NULL,
otStartTime		TIME NOT NULL,
otEndTime		TIME,
deletedByUser	INT,
[action]		VARCHAR(10),
dateDeleted		DATETIME
)	
CREATE TABLE tblDeletedOverTime(
otID			INT NOT NULL,
otName			VARCHAR (30)NOT NULL,
otHourlyRate	FLOAT NOT NULL,
[description]	VARCHAR(max),
deletedByUser	INT,
[action]		VARCHAR(10),
dateDeleted		DATETIME
)
/*CREATE TABLE tblDeletedDepartment(
depId		INT PRIMARY KEY IDENTITY(1,1),
depName		VARCHAR(30) NOT NULL,
depDescription	VARCHAR(MAX),
deletedByUser	INT,
[action]		VARCHAR(10),
dateDeleted		DATETIME
)*/
GO
--CONSTRAINTS
--FOREIGN KEY CONSTRAINT
GO
ALTER TABLE tblAttendance
ADD CONSTRAINT fk_atten_to_emp
FOREIGN KEY (empId) REFERENCES tblEmployee(empID)


ALTER TABLE tblOvertimeDetail
ADD CONSTRAINT fk_OTD_to_emp
FOREIGN KEY (empId) REFERENCES tblEmployee(empID)


ALTER TABLE tblOvertimeDetail
ADD CONSTRAINT fk_OTD_to_OT
FOREIGN KEY (otId) REFERENCES tblOvertime(otID)


ALTER TABLE tblMonthlyData
ADD CONSTRAINT fk_mdata_to_emp
FOREIGN KEY (empId) REFERENCES tblEmployee(empID)


ALTER TABLE tblEmployee
ADD CONSTRAINT fk_emp_to_empT
FOREIGN KEY (empTypeId) REFERENCES tblEmployeeType(EmpTypeId)


ALTER TABLE tblEmployee
ADD CONSTRAINT fk_emp_to_grp
FOREIGN KEY (empGroupId) REFERENCES tblGroup(groupId)


ALTER TABLE tblEmployee
ADD CONSTRAINT fk_emp_to_dep
FOREIGN KEY (empDepId) REFERENCES tblDepartment(depId)

--make an admin from sql server side and add a unique constraint of admin unique users like admnin
ALTER TABLE users
ADD CONSTRAINT unique_admin
CHECK ([role] like 'ADMIN')
GO

--CHECK CONSTRAINT
--for over time hour range meaning the time worked cannot be greater than the allowed
--UNIQUE CONSTRAINT


--STORED PROCEDURES DEFINITION BELOW


--OVETIME DETAIL table
--procedures
GO
--when employee starts overtime
CREATE PROC spInsertStartOtDetail
@empId INT,
@otId INT
AS
BEGIN
INSERT INTO tblOverTimeDetail
VALUES(@empId,@otId,getdate(),getdate(),null)
END
GO
--when employee ends over time
CREATE PROC spInsertEndOtDetail
@empId INT
AS
BEGIN
UPDATE tblOverTimeDetail
SET otEndTime=getdate()
WHERE empId=@empId
END
GO
--insert an over time which was done without system present
CREATE PROC spInsertManualOtDetail
@empId INT,
@otId INT,
@otDate DATE,
@otStartTime TIME,
@otEndTime TIME,
@insertedBy int 
AS
BEGIN
INSERT INTO tblOverTimeDetail
VALUES(@empId,@otId,@otDate,@otStartTime,@otEndTime)
END
GO
--delete over time detail
CREATE PROC spDeleteOtDetail
@empId INT,
@otId INT,
@otDate DATE,
@userId INT
AS
BEGIN
insert into tblDeletedOvertimeDetail
SELECT empId,otID,otDate,otStartTime,otEndTime,@userId,'DELETE',getdate()
FROM tblOverTimeDetail
WHERE empId=@empId and otId=@otId and otDate=@otDate

DELETE tblOverTimeDetail
WHERE empId=@empId and otId=@otId and otDate=@otDate
END
GO
--update Over time detail
CREATE PROC spUpdateOtDetail
@empId INT,
@otId INT,
@otDate DATE,
@otStartTime TIME,
@otEndTime TIME,
@userID INT
 
AS
BEGIN

INSERT INTO tblDeletedOverTimeDetail
SELECT empId,otId,otDate,otStartTime,otEndTime,@userId,'UPDATE',GETDATE()
FROM tblOverTimeDetail
WHERE empId=@empId and otId=@otId and otDate=@otDate

UPDATE tblOverTimeDetail
SET otStartTime=@otStartTime,otEndTime=@otEndTime
WHERE empId=@empId and otId=@otId and otDate=@otDate


END

GO
--insert employee
CREATE PROC spInsertEmployee
			@empFirstName		VARCHAR (30) ,
			@empLastName		VARCHAR (30) ,
			@empSex				CHAR(1) ,
			@empBasicSalary		MONEY ,
			@empDateofBirth		DATE,
			@empDateOfEmployment	DATE,
			@empImage			IMAGE,
			@empTelNo			VARCHAR(15),
			@empEmergencyContact VARCHAR(15),
			@empDepId			INT,
			@empTypeId			INT,
			@empGroupId			INT,
			@UserID				INT
AS 
BEGIN

INSERT INTO tblEmployee
VALUES(@empFirstName,@empLastName,@empSex,@empBasicSalary,@empDateofBirth,@empDateOfEmployment,
	@empImage,@empTelNo,@empEmergencyContact ,@empDepId	,@empTypeId	,@empGroupId,@UserID,getDate())
--select IDENT_CURRENT ('tblEmployee') 
END

GO
--delete employee
CREATE PROC spDeleteEmployee
            @empId			INT,
			@UserID			INT	
AS 
BEGIN

INSERT INTO tblDeletedEmployee
SELECT empId,empFirstName,empLastName,empSex,empBasicSalary,empDateofBirth,empDateOfEmployment,
	empImage,empTelNo,empEmergencyContact,empDepId,empTypeId	,empGroupId,insertedBy,insertedDate,@UserID,'DELETE',GETDATE()
FROM tblEmployee 
WHERE empId=@empId

DELETE tblEmployee
WHERE empId=@empId
END
GO
--update employee
CREATE PROC spUpdateEmployee
             @empId				INT,
			@empFirstName		VARCHAR (30) ,
			@empLastName			VARCHAR (30) ,
			@empSex				CHAR(1) ,
			@empBasicSalary		MONEY ,
			@empDateofBirth		DATE,
			@empDateOfEmployment	DATE,
			@empImage			IMAGE,
			@empTelNo			VARCHAR(15),
			@empEmergencyContact VARCHAR(15),
			@empDepId			INT,
			@empTypeId			INT,
			@empGroupId			INT,
			@UserID			INT
			
AS 
BEGIN
INSERT INTO tblDeletedEmployee
SELECT empId,empFirstName,empLastName,empSex,empBasicSalary,empDateofBirth,empDateOfEmployment,
	empImage,empTelNo,empEmergencyContact,empDepId,empTypeId	,empGroupId,insertedBy,insertedDate,@UserID,'UPDATE',GETDATE()
FROM tblEmployee 
WHERE empId=@empId

UPDATE tblEmployee
SET empFirstName=@empFirstName,empLastName=@empLastName,empSex=@empSex,empBasicSalary=@empBasicSalary,empDateofBirth=@empDateofBirth,
	empDateOfEmployment=@empDateOfEmployment,empImage=@empImage,empTelNo=@empTelNo,empEmergencyContact=@empEmergencyContact,
	empDepId=@empDepId,empTypeId=@empTypeId,empGroupId=@empGroupId
WHERE empId=@empId
END

GO
--insert monthly data
CREATE PROC spInsertMonData
			 @empId						INT ,
             @monDataMonth				INT,
			 @monDataYear				INT,	
			 @monDataUnpaidSalary		MONEY,
			 @monDataUnpaidPension		MONEY,
			 @monDataUnpaidIncomeTax			MONEY,
			 @monDataIncentive			MONEY,
			 @monDataMedical				MONEY,
             @monDataCourtCase			MONEY,
			 @monDataFine				MONEY,
			 @monDataOverPayment			MONEY,
			 @monDataActingAllowance		MONEY,
			 @monDataMobileandTransport	MONEY,
			 @monDataSaving				MONEY,
			 @monDataOtherContribution	MONEY,
			 @UserID						INT

AS
BEGIN
if(exists(select * from tblemployee where empid = @empId))
Begin
INSERT INTO tblMonthlyData
VALUES(@empId,@monDataMonth,@monDataYear,@monDataUnpaidSalary,@monDataUnpaidPension,@monDataUnpaidIncomeTax,@monDataIncentive,@monDataMedical,@monDataCourtCase
		,@monDataFine,@monDataOverPayment,@monDataActingAllowance,@monDataMobileandTransport,@monDataSaving,@monDataOtherContribution,@UserId, getdate())
End
ELSe
RAISERROR('THE EMPLOYEE ID DOESNT EXIST PLEASE CHOOSE AN EMPLOYEE THAT EXISTS',16,0)
END
GO

CREATE PROC spUpdateMonData
			 @empId						INT ,
             @monDataMonth				INT,
			 @monDataYear				INT,	
			 @monDataUnpaidSalary		MONEY,
			 @monDataUnpaidPension		MONEY,
			 @monDataUnpaidIncomeTax	MONEY,
			 @monDataIncentive			MONEY,
			 @monDataMedical			MONEY,
             @monDataCourtCase			MONEY,
			 @monDataFine				MONEY,
			 @monDataOverPayment		MONEY,
			 @monDataActingAllowance	MONEY,
			 @monDataMobileandTransport	MONEY,
			 @monDataSaving				MONEY,
			 @monDataOtherContribution	MONEY,
			 @UserID					INT

AS
BEGIN
INSERT INTO tblDeletedMonthlyData
SELECT empId,monDataMonth,monDataYear,monDataUnpaidSalary,monDataUnpaidPension,@monDataUnpaidIncomeTax,monDataIncentive,monDataMedical,monDataCourtCase
		,monDataFine,monDataOverPayment,monDataActingAllowance,monDataMobileandTransport,monDataSaving,monDataOtherContribution,insertedBy,insertedDate,@UserId,'UPDATE',GETDATE()
FROM	tblMonthlyData
WHERE empId=@empId and monDataMonth=@monDataMonth and monDataYear=@monDataYear

UPDATE	tblMonthlyData
SET  monDataUnpaidSalary=@monDataUnpaidSalary,monDataUnpaidPension=@monDataUnpaidPension,monDataIncentive=@monDataIncentive,monDataUnpaidIncomeTax = @monDataUnpaidIncomeTax,
		monDataMedical=@monDataMedical,monDataCourtCase=@monDataCourtCase,monDataFine=@monDataFine,monDataOverPayment=@monDataOverPayment
		,monDataActingAllowance=@monDataActingAllowance,monDataMobileandTransport=@monDataMobileandTransport,monDataSaving=@monDataSaving
		,monDataOtherContribution=@monDataOtherContribution
WHERE empId=@empId and monDataMonth=@monDataMonth and monDataYear=@monDataYear

END
GO



--delete monthly data
CREATE PROC spDeleteMonData
			 @empId						INT ,
             @monDataMonth				INT,
			 @monDataYear				INT,	
		     @UserId					INT
AS
BEGIN

INSERT INTO tblDeletedMonthlyData
SELECT empId,monDataMonth,monDataYear,monDataUnpaidSalary,monDataUnpaidPension,monDataUnpaidIncomeTax,monDataIncentive,monDataMedical,monDataCourtCase
		,monDataFine,monDataOverPayment,monDataActingAllowance,monDataMobileandTransport,monDataSaving,monDataOtherContribution,insertedBy,insertedDate,@UserId,'DELETE',GETDATE()
FROM	tblMonthlyData
WHERE empId=@empId and monDataMonth=@monDataMonth and monDataYear=@monDataYear


DELETE tblMonthlyData
WHERE empId=@empId and monDataMonth=@monDataMonth and monDataYear=@monDataYear
END


GO
--ATTENDANCE TABLE
CREATE PROCEDURE spFirstStartAttendance
@Employee_ID INT,
@morning_Start_Time TIME
AS
BEGIN
INSERT INTO tblATTENDANCE VALUES (@Employee_ID,getdate(),getdate(),null,null,null)

END

GO
CREATE PROCEDURE spFirstEndAttendance
@Employee_ID INT,
@attDate DATE
AS
BEGIN
UPDATE tblATTENDANCE 
SET firstStartTime = getdate()
WHERE empId = @Employee_ID AND attenDate = @attDate

END

GO
CREATE PROCEDURE spSecondStartAttendance
@Employee_ID INT,
@attDate DATE
AS
BEGIN
UPDATE tblATTENDANCE
SET lastStartTime = getdate()
WHERE empId = @Employee_ID AND attenDate = @attDate

END

GO
CREATE PROCEDURE spAfternoonEnd
@Employee_ID INT,
@attDate DATE
AS
BEGIN
UPDATE tblATTENDANCE
SET lastEndTime = getdate()
WHERE empId= @Employee_ID AND attenDate = @attDate

END


GO
--insert OT
CREATE PROC spInsertOT
@otName VARCHAR(30),
@hourlyRate FLOAT,
@description VARCHAR(max)
AS
BEGIN
INSERT INTO tblOvertime
values(@otName,@hourlyRate,@description)
END
GO
--update OT
CREATE PROC spUpdateOT
@otId INT,
@otName VARCHAR(MAX),
@hourlyRate FLOAT,
@Description VARCHAR(max),
@userId INT
AS
BEGIN
INSERT INTO tblDeletedOverTime
SELECT otId,otName,otHourlyRate,[description],@userId,'UPDATE',getdate()
FROM tblOvertime
WHERE otId=@otId


UPDATE tblOvertime
SET otName=@otName,otHourlyRate=@hourlyRate,[description]=@description
END
GO
--delete OT
CREATE PROC spDeleteOT
@otID INT,
@userId INT
AS
BEGIN


INSERT INTO tblDeletedOverTime
SELECT otId,otName,otHourlyRate,[description],@userId,'DELETE',getdate()
FROM tblOvertime
WHERE otId=@otId

DELETE tblOvertime
WHERE otId=@otID
END

--GROUP
GO
--inserting into a group
CREATE PROC spInsertGroup
@groupId INT,
@groupName VARCHAR(30),
@groupDescription VARCHAR(max)
AS 
BEGIN
INSERT INTO tblGroup VALUES(@groupId,@groupName,@groupDescription)
END

GO
--updating a group
CREATE PROC spUpdateGroup
@groupId INT,
@groupName VARCHAR(30),
@groupDescription VARCHAR(max)
AS
BEGIN

UPDATE tblGroup SET
groupName=@groupName,groupDescription=@groupDescription
WHERE groupId=@groupId
END

GO
--deleting a group
CREATE PROC spDeleteGroup
@groupId INT
AS
BEGIN

DELETE tblGroup
WHERE groupId=@groupId
END
GO
--EMPLOYEE TYPE
--inserting into employee type
CREATE PROC spInsertEmployeeType
@empTypeName VARCHAR(30),
@empTypeDescription VARCHAR(max)
AS
BEGIN
INSERT INTO tblEmployeeType 
VALUES(@empTypeName,@empTypeDescription)
END
GO
--update the employee type
CREATE PROC spUpdateEmployeeType
@empTypeId INT,
@empTypeName VARCHAR(30),
@empTypeDescription VARCHAR(max)
AS
BEGIN
UPDATE tblEmployeeType
SET empTypeName=@empTypeName,empTypeDescription=@empTypeDescription
WHERE empTypeId=@empTypeId
END
GO
--delete the employee type
CREATE PROC spDeleteEmployeeType
@empTypeId INT
AS
BEGIN

DELETE tblEmployeeType
WHERE empTypeId=@empTypeId
END

GO
--DEPARTMENT
--insert department
CREATE PROC spInsertDepartment
@depName varchar(max),
@description varchar(max)
AS
BEGIN 
INSERT INTO tblDepartment
VALUES (@depName,@description)

END
GO
--update department
CREATE PROC spUpdateDepartment
@depId INT,
@depName VARCHAR(30),
@description VARCHAR(MAX),
@userID INT
AS
BEGIN 
INSERT INTO tblDeletedDepartment
SELECT depId,depName,depDescription,@userId,'UPDATE',getdate()
FROM tblDepartment
WHERE depId=@depId

UPDATE tblDepartment
SET depName=@depName,depDescription=@description
WHERE depId=@depId


END
GO
--delete department
CREATE PROC spDeleteDepartment
@depId INT,
@userId INT
AS
BEGIN 
INSERT INTO tblDeletedDepartment
SELECT depId,depName,depDescription,@userId,'DELETE',getdate()
FROM tblDepartment
WHERE depId=@depId

DELETE tblDepartment
WHERE depId=@depId
END
GO
--insert user
CREATE PROC insertUser
			@username	VARCHAR(20),
			@password	VARCHAR(20),
			@firstName	VARCHAR(30),
			@lastName	VARCHAR(30),
			@userImage	IMAGE,
			@role		VARCHAR(15)
AS
BEGIN

INSERT INTO USERS
VALUES(@username,@password,@firstName,@lastName,@userImage,@role)
END

GO
--delete USER		
CREATE PROC deleteUser
			@userId INT
AS
BEGIN
DELETE USERS
WHERE userID=@userId
END
GO
--update user
CREATE PROC updateUser
				@userID		INT ,
				@username	VARCHAR(20),
				@password	VARCHAR(20),
				@firstName	VARCHAR(30),
				@lastName	VARCHAR(30),
				@userImage	IMAGE,
				@role		VARCHAR(15)
AS
BEGIN
UPDATE USERS SET username=@username,[password]=@password,firstName=@firstName,lastName=@lastName,userImage=@userImage,[role]=@role
WHERE userId=@userID
END

GO
--login
CREATE PROC userLogin
				@username	VARCHAR(20),
				@password	VARCHAR(20)
AS
BEGIN
DECLARE @cmd NVARCHAR(max)='select * from [users] where username =@usernamee and [password] = @passwordd'
DECLARE @parameters SYSNAME='@usernamee sysname,@passwordd sysname'
EXEC sp_executesql @cmd,@parameters,@usernamee=@username,@passwordd=@password

END

GO
--user password change
CREATE PROC changeUserPassword
@userId INT,
@oldPassword VARCHAR(20),
@newPassword VARCHAR(20)
AS
BEGIN
IF((SELECT [password] FROM USERS WHERE UserID=@userId)=@oldPassword)
	BEGIN
		UPDATE USERS SET [password]=@newPassword WHERE userId=@userId
	END
ELSE RAISERROR('OLD PASSWORD IS INCORRECT PLEASE TRY AGAIN',15,9)
END

GO
--change user image
CREATE PROC changeUserImage
@userId INT,
@image IMAGE
AS
BEGIN
UPDATE USERS SET userImage=@image WHERE userID=@userId
END

GO
--EMPLOYEE Usercontrol
--search procedures below
CREATE PROC searchEmployee
		@sk VARCHAR(20)
AS
BEGIN
SELECT empId as [Employee ID],empFirstName as [First Name],empLastName as[Last Name]
FROM tblEmployee
WHERE (empId like @sk+'%') or (empFirstName like '%' +@sk+'%') or (empLastName like '%' +@sk +'%') 
END

GO
--fetchemployee
CREATE PROC fetchEmployee
		@empId INT
AS
BEGIN
SELECT * FROM tblEmployee
WHERE empId=@empId
END
  
--search department
GO
CREATE PROC searchDepartment
@sk VARCHAR(20)
AS 
BEGIN
SELECT d.depId [Department Id], d.depName [Department Name]
FROM tblDepartment d 
WHERE (d.depId like @sk+'%') or (d.depName like '%' +@sk+'%')

END
GO

--fetch departemnt
CREATE PROC fetchDepartment
@depId INT
AS
BEGIN
SELECT * FROM tblDepartment
WHERE depId=@depId
END


GO
--- search employee type

CREATE PROC searchEmployeeType
@sk varchar(20)
AS
BEGIN
SELECT empTypeId as [Employee Type ID],empTypeName as [Employee Type Name] 
FROM tblemployeetype
WHERE (empTypeId like @sk+'%') or (empTypeName like '%' +@sk+'%') or (empTypeDescription like '%' +@sk +'%') 

END

GO
CREATE PROC fetchEmployeeType
		@empTypeId INT
AS
BEGIN
SELECT * FROM tblEmployeetype
WHERE empTypeId=@empTypeId
END
GO

--search group
CREATE PROC searchGroup
@sk VARCHAR(20)
AS 
BEGIN

SELECT g.groupId [Group Id], g.groupName [Group Name]
FROM tblGroup g 
WHERE (g.groupId like @sk+'%') or (g.groupName like '%' +@sk+'%')

END
GO

--fetch group
go
CREATE PROC fetchGroup
@groupId INT
AS
BEGIN
SELECT * FROM tblGroup
WHERE groupId=@groupId
END

GO
CREATE PROC fetchUser
		@userId INT
AS
BEGIN
SELECT * FROM Users
WHERE userID=@userId
END
GO


-----SEARCH overtime
CREATE PROC searchOverTime
@sk varchar(20)
AS
BEGIN
SELECT otId as [Over Time ID],otName as [Over Time Name] 
FROM tblOverTime
WHERE (otId like @sk+'%') or (otName like '%' +@sk+'%') 

END
--fetch over time
GO
CREATE PROC fetchOverTime
		@otId INT
AS
BEGIN
SELECT * FROM tblOverTime
WHERE otId=@otId
END

GO
CREATE PROC searchUsers
@sk varchar(20)
AS
BEGIN
SELECT userId as [User ID],firstName +' '+ lastName as [Full Name] 
FROM USERS
WHERE (userId like @sk+'%') or (username like '%' +@sk+'%') or (firstName like '%' +@sk+'%') or (lastName like '%' +@sk +'%') or (role like '%' +@sk+'%')

END
GO
CREATE PROC searchMonthlyData
		@sk VARCHAR(20)
AS
BEGIN

SELECT e.empId as [Employee ID],e.empFirstName as [First Name],e.empLastName as[Last Name]
FROM tblEmployee e INNER JOIN tblMonthlyData m ON e.empId= m.empId
WHERE ( (e.empId like @sk+'%') or (empFirstName like '%' +@sk+'%') or (empLastName like '%' +@sk +'%'))
and ( (SELECT DATEDIFF(DAY,m.insertedDate,GETDATE()))<=30)
END
go



GO

CREATE PROC fetchMonthlyData
@empId INT
AS
BEGIN
SELECT M.empId,e.empFirstName+' '+e.empLastName as [Full Name],e.empImage,M.monDataUnpaidSalary,M.monDataUnpaidPension,M.monDataUnpaidIncomeTax,M.monDataIncentive,
	   M.monDataMedical,M.monDataCourtCase,M.monDataFine,M.monDataOverPayment,
	   M.monDataActingAllowance,M.monDataMobileandTransport,M.monDataSaving,M.monDataOtherContribution
FROM tblMonthlyData M INNER JOIN tblEmployee e ON e.empId=M.empId
WHERE M.empId=@empId and ( (SELECT DATEDIFF(DAY,m.insertedDate,GETDATE()))<30)
END
GO

