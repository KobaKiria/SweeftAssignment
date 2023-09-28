SELECT Teacher.* FROM Teacher
INNER JOIN TeacherPupil ON Teacher.TeacherID = TeacherPupil.TeacherID
INNER JOIN Pupil ON TeacherPupil.PupilID = Pupil.PupilID
WHERE Pupil.FirstName = 'Giorgi';