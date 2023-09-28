CREATE TABLE Teacher (
    TeacherID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50)
);

CREATE TABLE Pupil (
    PupilID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50)
);
CREATE TABLE TeacherPupil (
    TeacherPupilID INT PRIMARY KEY IDENTITY(1,1),
    TeacherID INT,
    PupilID INT,
    FOREIGN KEY (TeacherID) REFERENCES Teacher(TeacherID),
    FOREIGN KEY (PupilID) REFERENCES Pupil(PupilID)
);


INSERT INTO Teacher (FirstName, LastName) VALUES ('Lika', 'Buadze');
INSERT INTO Teacher (FirstName, LastName) VALUES ('Cico', 'Sharikadze');
INSERT INTO Teacher (FirstName, LastName) VALUES ('Akaki', 'Shekeladze');
INSERT INTO Teacher (FirstName, LastName) VALUES ('Nana', 'Maisuradze');


INSERT INTO Pupil (FirstName, LastName) VALUES ('Davit', 'Datusani');
INSERT INTO Pupil (FirstName, LastName) VALUES ('Bidzina', 'Elizabarashvili');
INSERT INTO Pupil (FirstName, LastName) VALUES ('Giorgi', 'Datukishvili');
INSERT INTO Pupil (FirstName, LastName) VALUES ('Erekle', 'Mirianashvili');


INSERT INTO TeacherPupil (TeacherID, PupilID) VALUES (1, 1); 
INSERT INTO TeacherPupil (TeacherID, PupilID) VALUES (1, 3); 
INSERT INTO TeacherPupil (TeacherID, PupilID) VALUES (2, 2); 
INSERT INTO TeacherPupil (TeacherID, PupilID) VALUES (2, 1); 
INSERT INTO TeacherPupil (TeacherID, PupilID) VALUES (3, 3); 
INSERT INTO TeacherPupil (TeacherID, PupilID) VALUES (3, 2); 

