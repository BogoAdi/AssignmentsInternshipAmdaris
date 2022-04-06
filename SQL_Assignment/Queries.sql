USE AssignmentSql1;

UPDATE Appointment 
SET FullPrice=NumberOfHours* ( SELECT PricePerHour FROM SportField WHERE ID = SportFieldId )


SELECT DateScheduled, PhoneNumber,FullPrice 
FROM Appointment AS ap 
ORDER BY FullPrice

/*First Question:  */
SELECT *
FROM Users
WHERE FullName Like 'a%'

/*Second Question:  */
SELECT * 
FROM Users 
Where LEN(PasswordU)>5
ORDER BY FullName

/*Third Question:  */
SELECT UserId ,(SELECT FullName  FROM Users WHERE ID = Appointment.UserId ) as Name, SUM (NumberOfHours) AS TotalHours
FROM Appointment
Group By UserId 

/*Fourth Question:  */
SELECT SUBSTRING(Category, 1, 1) AS Letter, COUNT (Category) as Categories
FROM SportField
GROUP BY SUBSTRING(SportField.Category, 1, 1)


/*Fifth Question:  */
SELECT *
FROM SportField AS s
INNER JOIN Appointment AS a ON s.ID = a.SportFieldId;



/*Sixth Question:  */
SELECT *
FROM Users AS u
LEFT JOIN Appointment AS a ON a.UserId = u.ID
WHERE u.Username LIKE '[a-p]%'
ORDER BY u.FullName DESC;



/*Seventh Question:  */
SELECT DISTINCT 
 FullName as Name,
 Email as 'E-Mail',
(SELECT SUM(FullPrice)
FROM Appointment as a
WHERE a.UserId = u.ID) AS TotalPaymant
FROM Users as u 
LEFT JOIN Appointment as ap ON ap.UserId= u.ID 

/* Eigth Question: */

SELECT  AVG(FullPrice) AS Avg_Price
FROM Appointment 

/*Ninth Question */

SELECT  MAX(LEN(City)) as Length ,City 
FROM SportField
Where LEN(City) = (SELECT MAX(LEN(City)) FROM SportField)
GROUP BY CITY

/*Tenth Question */
SELECT FullPrice,FullName, City
FROM Appointment
INNER JOIN SportField ON SportField.ID = SportFieldId
INNER JOIN Users ON UserId = Users.ID



