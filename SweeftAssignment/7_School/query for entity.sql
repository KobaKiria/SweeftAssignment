
INSERT INTO dbo.Teachers (FirstName, LastName)
VALUES
    ('Lika', 'Tevdorashvili'),
    ('Ilia', 'Kekutia'),
    ('Lado', 'Siradze'),
    ('Mariam', 'Gobechia'),
    ('Noa', 'Kiria');


INSERT INTO Pupils (FirstName, LastName) VALUES ('Giorgi', 'Giorgishvili');
INSERT INTO Pupils (FirstName, LastName) VALUES ('Emzar', 'Vinmeshvili');
INSERT INTO Pupils (FirstName, LastName) VALUES ('Eduard', 'Shevardnadze');
INSERT INTO Pupils (FirstName, LastName) VALUES ('Erekle', 'Kekutia');
INSERT INTO Pupils (FirstName, LastName) VALUES ('Luka', 'Tetradze');


INSERT INTO TeacherPupils (TeacherID, PupilID) VALUES (1, 1); 
INSERT INTO TeacherPupils (TeacherID, PupilID) VALUES (3, 1); 
INSERT INTO TeacherPupils (TeacherID, PupilID) VALUES (5, 1); 
INSERT INTO TeacherPupils (TeacherID, PupilID) VALUES (3, 2); 
INSERT INTO TeacherPupils (TeacherID, PupilID) VALUES (2, 2); 
