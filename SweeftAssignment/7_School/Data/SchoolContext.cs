using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class SchoolContext : DbContext
{

    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Pupil> Pupils { get; set; }
    public DbSet<TeacherPupil> TeacherPupils { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-KNCH97K\\SQLEXPRESS;Database=School;Trusted_Connection=True;Encrypt=False;");
    }

    public Teacher[] GetAllTeachersByStudent(string studentName)
    {
        return Teachers.Where(t=>t.TeacherPupils.Any(tp => tp.Pupil.FirstName == studentName)).ToArray();
    }
}
