using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    public static void Main()
    {

        using (var context = new SchoolContext())
        {
            Console.WriteLine("Giorgi's teachers are: ");
            var GiorgisTeachers = context.GetAllTeachersByStudent("Giorgi");

            foreach (var teacher in GiorgisTeachers)
            {
                Console.WriteLine($"Teacher: {teacher.FirstName} {teacher.LastName}");
            }

        }
    }
    }
