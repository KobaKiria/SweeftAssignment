public class TeacherPupil
{
    public int TeacherPupilID { get; set; }
    public int TeacherID { get; set; }
    public Teacher Teacher { get; set; }
    public int PupilID { get; set; }
    public Pupil Pupil { get; set; }
}
