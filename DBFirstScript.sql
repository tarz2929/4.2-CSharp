DROP TABLE IF EXISTS Vehicle;

CREATE TABLE Vehicle (
	ID int(10) PRIMARY KEY,
	Manufacturer varchar(25) NOT NULL,
	Model varchar(30) NOT NULL,
	ModelYear int(10) NOT NULL,
	Colour varchar(25) NOT NULL
);

INSERT INTO Vehicle (ID, Manufacturer, Model, ModelYear, Colour)
VALUES 
	(1, 'Plymouth', 'Barracuda', 1970, 'Green'),
	(2, 'Honda', 'Civic', 2010, 'Blue'),
	(3, 'Volkswagen', 'Golf', 2008, 'White'),
	(4, 'Dodge', 'Stealth', 1992, 'Blue'),
	(5, 'Honda', 'NSX', 1992, 'Black'),
	(6, 'Ferrari', '428', 2010, 'Red'),
	(7, 'Mitsubishi', 'FTO', 1998, 'Black'),
	(8, 'Ford', 'GT40', 1964, 'Blue')
;