----------### BOOKS MAIN TABLE ###---------- 
-----## Books Table ##-----
CREATE TABLE Doctors (
  Id INT AUTO_INCREMENT PRIMARY KEY,
  Name VARCHAR(80),
  Email VARCHAR(125) UNIQUE
);