----------### Appointments MAIN TABLE ###---------- 
-----## Appointments Table ##-----
CREATE TABLE Appointments (
  Id INT AUTO_INCREMENT PRIMARY KEY,
  Date DATE,
  Status ENUM("open", "attended", "cancelled") DEFAULT "open",
  IdDoctor INT,
  IdPatient INT,
  IdTreatment INT,
  Foreign Key (IdDoctor) REFERENCES Doctors(Id),
  Foreign Key (IdPatient) REFERENCES Patients(Id),
  Foreign Key (IdTreatment) REFERENCES Treatments(Id)
);

-----## Treatments Table
CREATE TABLE Treatments (
  Id INT AUTO_INCREMENT PRIMARY KEY,
  Name VARCHAR(125),
  Description TEXT,
  Status ENUM("active", "inactive") DEFAULT "active"
);

----------### Doctors MAIN TABLE ###---------- 
-----## Doctors Table ##-----
CREATE TABLE Doctors (
  Id INT AUTO_INCREMENT PRIMARY KEY,
  FullName VARCHAR(125),
  Email VARCHAR(125) UNIQUE,
  Phone VARCHAR(75),
  IdSpecialty INT,
  Status ENUM("active", "inactive") DEFAULT "active",
  Foreign Key (IdSpecialty) REFERENCES Specialties(Id)
);

-----## Specialties Table
CREATE TABLE Specialties (
  Id INT AUTO_INCREMENT PRIMARY KEY,
  Name VARCHAR(125),
  Description TEXT,
  Status ENUM("active", "inactive") DEFAULT "active"
);

----------### Patients MAIN TABLE ###----------
-----## Patients Table ##-----
CREATE TABLE Patients (
  Id INT AUTO_INCREMENT PRIMARY KEY,
  Name VARCHAR(125),
  LastName VARCHAR(125),
  BirthDate DATE,
  Email VARCHAR(125) UNIQUE,
  Phone VARCHAR(75),
  Address VARCHAR(125),
  Status ENUM("active", "inactive") DEFAULT "active"
);