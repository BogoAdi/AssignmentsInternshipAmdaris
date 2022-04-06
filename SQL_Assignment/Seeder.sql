
INSERT INTO dbo.Users ( FullName, Email, Username , PasswordU)
VALUES
( 'Mircea Petrescu', 'mircea@gmail.com', 'user1', '222'),
('Casandra Huedin', 'casi@gmail.com', 'casii223', '123aaa'),
( 'Ulise Popescu', 'herodot@gmail.com', 'vidvid2000', 'anaAreMere'),
( 'Victa Ionescu', 'ronaVicta@yahoo.com', 'ronana99','casablanca'),
('Ion Dolanescu', 'ionescu@yahoo.com', 'muzicaPopulara', 'theBest123'),
( 'Vadim Tudor', 'presedinte@yahoo.com', 'arculDeTriumf','Romania2002'),
( 'Otilia Cazimir', 'otilia_cazimir@gamil.com', 'babaIarna', 'poeziaromaneasca1'),
( 'Mihai Eminescu', 'eminescu@gyahoo.com', 'luceafarul12', 'moldovaPoet'),
('Anna Blandiana', 'ana@gmail.com', 'titiana', 'ana123blandiana'),
('Anna Blandiana', 'ana@gmail.com', 'titiana', 'ana123blandiana')

INSERT INTO dbo.SportField (Street, Number, City, PricePerHour , Category, Description)
VALUES
('Great North Road', '36', 'Amalebra',90,'fotball',NULL),
('Argyll Road','32','Llanddewi Ystradenni',120, 'tennis',NULL),
('Botley Road', '18', 'Harome', 123.5,'football',NULL ),
('East Street', '12','Maplebeck',150, 'polo',NULL),
('West Lane', '99', 'Dalkeith' , 80, 'voleyball','good conditions!'),
('ARIEŞULUI', '14','Cluj-Napoca',130, 'tennis',NULL),
('REVOLUŢIEI ','24B','Targoviste', 76,'voleyball',NULL),
('RĂSCOALA','12','Constanta', 110,'tennis',NULL),
('Strada Eroilor','44','Constanta',135.2, 'polo',NULL),
('RODNEI', '9','Resita', 200, 'golf',NULL)



INSERT INTO dbo.Appointment (UserId, SportFieldId, DateScheduled , PhoneNumber, NumberOfHours, FullPrice)
VALUES
(2,3, '2022-11-11 15:32:06','075032141', 2, 0),
(2,5, '01-11-2023 15:32:06','075594421',4, 0),
(7,4, '09-01-2023 12:00:00','076612342',3, 0),
(3,9, '06-11-2022 11:00:00','076303123',1, 0),
(2,10,'01-01-2023 00:00:00','076431323',6, 0),
(4,4, '10-10-2022 10:00:00', '0987765542',2, 0),
(6,3, '10-10-2022 12:00:00', '078923412',1, 0),
(7,9, '09-09-2022 14:00:00', '0789809222',3,0),
(1,8,'12-12-2022 20:00:00','0909090921',2,0),
(2,4, '2023-11-24 16:00:00','0755432411',3,0)
