CREATE table First_Table
(
Id int primary key IDENTITY(1,1),
Access bit,
FirstName varchar(255),
TableDate SMALLDATETIME,
SomeFloatNumber FLOAT,
SomeIntNumber INT
);

CREATE TABLE Second_Table
(
Id int primary key IDENTITY(1,1),
FTableId int,
LastName nvarchar(255),
SomeDate SMALLDATETIME,
SecondFloatNumber FLOAT,
Checker BIT,
FOREIGN KEY (FTableId) REFERENCES First_Table (Id)

);

CREATE TABLE LogTable
(
Id int primary key IDENTITY(1,1),
FilterName nvarchar(255),
WhenItUse SMALLDATETIME

);

GO

DECLARE @i int;
SET @i = 1;
WHILE @i < 100
BEGIN
INSERT INTO First_Table 
(Access, FirstName, TableDate, SomeFloatNumber, SomeIntNumber)
Values 
(ROUND(RAND(), 0), CONVERT(varchar(255), NEWID()), CONVERT(smalldatetime, ROUND(RAND()*30000, 0)), RAND(), ROUND(RAND()*1000,0));
INSERT INTO Second_Table
(
FTableId, LastName, SomeDate, SecondFloatNumber, Checker
)
Values
(
@i, CONVERT(varchar(255), NEWID()), CONVERT(smalldatetime, ROUND(RAND()*30000, 0)), RAND(), ROUND(RAND(), 0)
)
SET @i = @i +1
END

