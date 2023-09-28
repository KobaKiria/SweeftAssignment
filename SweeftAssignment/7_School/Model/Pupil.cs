public class Pupil
{
    public int PupilID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public ICollection<TeacherPupil> PupilTeachers { get; set; }
}
