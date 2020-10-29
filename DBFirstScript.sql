DROP TABLE IF EXISTS Vehicle;
DROP TABLE IF EXISTS Manufacturer;

CREATE TABLE Manufacturer (
	ID int(10) PRIMARY KEY,
	Name varchar(25) NOT NULL
);

CREATE TABLE Vehicle (
	ID int(10) PRIMARY KEY,
	ManufacturerID int(10) NOT NULL,
	Model varchar(30) NOT NULL,
	ModelYear int(10) NOT NULL,
	Colour varchar(25) NOT NULL,
	CONSTRAINT FK_Vehicle_Manufacturer FOREIGN KEY (ManufacturerID) REFERENCES Manufacturer(ID)
);

INSERT INTO Manufacturer (ID, Name)
VALUES
(1, 'Plymouth'),
(2, 'Honda'),
(3, 'Volkswagen'),
(4, 'Dodge'),
(5, 'Honda'),
(6, 'Ferrari'),
(7, 'Mitsubishi'),
(8, 'Ford');

INSERT INTO Vehicle (ID, ManufacturerID, Model, ModelYear, Colour)
VALUES 
	(1, 1, 'Barracuda', 1970, 'Green'),
	(2, 2, 'Civic', 2010, 'Blue'),
	(3, 3, 'Golf', 2008, 'White'),
	(4, 4, 'Stealth', 1992, 'Blue'),
	(5, 5, 'NSX', 1992, 'Black'),
	(6, 6, '428', 2010, 'Red'),
	(7, 7, 'FTO', 1998, 'Black'),
	(8, 8, 'GT40', 1964, 'Blue')
;