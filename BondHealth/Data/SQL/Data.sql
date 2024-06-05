----------### APPOINTMENTS MAIN DATA ###---------- 
-----## Appointments Data ##-----
INSERT INTO Appointments (Date, IdDoctor, IdPatient, IdTreatment) VALUES
('2024-06-03', 1, 1, 1),
('2024-06-04', 2, 2, 2),
('2024-06-05', 3, 3, 3),
('2024-06-06', 1, 4, 2),
('2024-06-07', 2, 5, 1),
('2024-06-08', 3, 6, 3),
('2024-06-09', 1, 7, 1),
('2024-06-10', 2, 8, 2),
('2024-06-11', 3, 9, 3),
('2024-06-12', 1, 10, 1);

-----## Treathments Data
INSERT INTO Treatments (Name, Description) VALUES
('Massage Therapy', 'Relaxing massage to relieve stress and tension.'),
('Dental Cleaning', 'Routine cleaning and checkup for dental hygiene.'),
('Physical Therapy', 'Exercises and treatments to improve mobility and strength.'),
('Acupuncture', 'Traditional Chinese medicine technique to alleviate pain.'),
('Chiropractic Adjustment', 'Manipulation of the spine to improve alignment.'),
('Skin Rejuvenation', 'Treatment to improve skin tone and texture.'),
('Nutritional Counseling', 'Guidance on healthy eating habits and nutrition.'),
('Psychotherapy', 'Therapeutic sessions to address mental health concerns.'),
('Yoga Classes', 'Classes focusing on relaxation, flexibility, and mindfulness.'),
('Allergy Testing', 'Testing to identify allergies and sensitivities.');

----------### DOCTORS MAIN DATA ###---------- 
-----## Doctors ##-----
INSERT INTO Doctors (FullName, Email, Phone, IdSpecialty) VALUES
('Dr. John Smith', 'john.smith@example.com', '+1234567890', 1),
('Dr. Emily Johnson', 'emily.johnson@example.com', '+1987654321', 2),
('Dr. Michael Williams', 'michael.williams@example.com', '+1122334455', 1),
('Dr. Sarah Brown', 'sarah.brown@example.com', '+1555555555', 3),
('Dr. David Davis', 'david.davis@example.com', '+1777777777', 2),
('Dr. Jennifer Martinez', 'jennifer.martinez@example.com', '+1444444444', 5),
('Dr. Christopher Miller', 'christopher.miller@example.com', '+1666666666', 4),
('Dr. Jessica Taylor', 'jessica.taylor@example.com', '+1888888888', 2),
('Dr. Daniel Anderson', 'daniel.anderson@example.com', '+1999999999', 1),
('Dr. Elizabeth Thomas', 'elizabeth.thomas@example.com', '+1777888999', 3);

-----## Specialties
INSERT INTO Specialties (Name, Description) VALUES
('Cardiology', 'Specializing in heart health and cardiovascular diseases.'),
('Dermatology', 'Treating conditions related to the skin, hair, and nails.'),
('Orthopedics', 'Dealing with injuries and diseases of the musculoskeletal system.'),
('Pediatrics', 'Caring for the health and well-being of children.'),
('Neurology', 'Diagnosing and treating disorders of the nervous system.'),
('Ophthalmology', 'Specializing in eye health and vision care.'),
('Oncology', 'Treating cancer and managing the care of cancer patients.'),
('Gynecology', 'Specializing in women''s reproductive health.'),
('Psychiatry', 'Treating mental health disorders and illnesses.'),
('Urology', 'Dealing with diseases of the urinary tract and male reproductive system.');

----------### PATIENTS MAIN DATA ###---------- 
-----## Patients ##-----
INSERT INTO Patients (Name, LastName, BirthDate, Email, Phone, Address) VALUES
('Alice', 'Johnson', '1990-05-15', 'alice.johnson@example.com', '+1234567890', '123 Main St'),
('Bob', 'Smith', '1985-08-20', 'bob.smith@example.com', '+1987654321', '456 Elm St'),
('Charlie', 'Williams', '1978-12-10', 'charlie.williams@example.com', '+1122334455', '789 Oak St'),
('David', 'Brown', '1995-03-25', 'david.brown@example.com', '+1555555555', '101 Maple St'),
('Emma', 'Jones', '1980-11-05', 'emma.jones@example.com', '+1777777777', '202 Pine St'),
('Frank', 'Martinez', '1973-09-30', 'frank.martinez@example.com', '+1444444444', '303 Cedar St'),
('Grace', 'Davis', '1988-07-12', 'grace.davis@example.com', '+1666666666', '404 Birch St'),
('Henry', 'Taylor', '1992-01-08', 'henry.taylor@example.com', '+1888888888', '505 Walnut St'),
('Ivy', 'Anderson', '1982-06-18', 'ivy.anderson@example.com', '+1999999999', '606 Spruce St'),
('Jack', 'Thomas', '1970-04-22', 'jack.thomas@example.com', '+1777888999', '707 Cedar St');