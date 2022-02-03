use saim;

CREATE TABLE User (
IdUser INT(6) NOT NULL AUTO_INCREMENT PRIMARY KEY,
Username VARCHAR(30) NOT NULL,
Email VARCHAR(50),
Password VARCHAR(50)
);

CREATE TABLE Company (
IdCompany INT(6) NOT NULL AUTO_INCREMENT PRIMARY KEY,
CompanyName VARCHAR(30) NOT NULL,
Details VARCHAR(30) NOT NULL,
Address VARCHAR(50)
);

CREATE TABLE Contact (
IdContact INT(6) NOT NULL AUTO_INCREMENT PRIMARY KEY,
FirstName VARCHAR(30) NOT NULL,
LastName VARCHAR(30) NOT NULL,
Phone VARCHAR(30) NOT NULL,
Status BOOLEAN NOT NULL,
CompanyId INT(6) NOT NULL
);

ALTER TABLE Contact MODIFY COLUMN CompanyId INT NOT NULL,
ADD CONSTRAINT contact_company_id_fk
FOREIGN KEY(CompanyId)
REFERENCES Company(IdCompany);

INSERT INTO User(Username, Email, Password) VALUES ('sa', 'sa@gmail.com', 'sa');