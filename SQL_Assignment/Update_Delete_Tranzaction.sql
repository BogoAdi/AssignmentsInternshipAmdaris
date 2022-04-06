/*TRANSACTION*/
USE AssignmentSql1;

BEGIN TRY
	BEGIN TRANSACTION

	
			/*Update 3 records form 3 table update*/
		
		UPDATE Appointment 
		SET FullPrice=NumberOfHours* ( SELECT PricePerHour FROM SportField WHERE ID = SportFieldId )
		
		
		UPDATE Users
		SET Email='invaild@gmail.com',
			PasswordU=''
		WHERE ID = 2 OR ID=3 OR ID= 9
		
		UPDATE SportField
		SET City='Arad'
		Where ID/ 2 = 2 OR ID /2 =3 
		
		
		/*DELETE RECORS*/
		DELETE FROM Appointment
		Where ID=2 OR ID=3
		
		DELETE FROM Users
		WHERE ID = 3 OR ID = 1

		

	COMMIT TRANSACTION

END TRY

BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH





