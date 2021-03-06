USE AssignmentSql1;

CREATE TABLE Users(
ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
FullName NVARCHAR(40) NOT NULL,
Email NVARCHAR(40) NOT NULL,
Username NVARCHAR(40) NOT NULL,
PasswordU NVARCHAR (40) NOT NULL
);

CREATE TABLE SportField(
ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
Street NVARCHAR(50) NOT NULL,
Number NVARCHAR(50) NOT NULL,
City NVARCHAR (50) NOT NULL,
PricePerHour FLOAT NOT NULL,
Category NVARCHAR (50) NOT NULL,
Description NVARCHAR(500)
);

CREATE TABLE Appointment(
ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
FullPrice FLOAT NOT NULL,
NumberOfHours INT NOT NULL,
PhoneNumber NVARCHAR(10) NOT NULL ,
DateScheduled DATETIME UNIQUE NOT NULL CHECK(DateScheduled >=CURRENT_TIMESTAMP ),
UserId INT NOT NULL FOREIGN KEY REFERENCES Users(ID),
SportFieldId INT NOT NULL FOREIGN KEY REFERENCES SportField(ID)
);

