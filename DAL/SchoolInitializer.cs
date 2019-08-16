using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplication15.Models;

namespace WebApplication15.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
                new Student{ID=1, FirstName = "Radhika", LastName = "Gupta", EnrollmentDate = DateTime.Parse("1996-01-11")},
                new Student{ID=2, FirstName = "Kunika", LastName = "Satija", EnrollmentDate = DateTime.Parse("1996-10-03")},
                new Student{ID=3, FirstName = "Jatin", LastName = "Arora", EnrollmentDate = DateTime.Parse("1996-07-30")},
                new Student{ID=4, FirstName = "Nikhil", LastName = "Chauhan", EnrollmentDate = DateTime.Parse("1999-04-15")},

            };
            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            var courses = new List<Course>
            {
                new Course{CourseID = 1000, Credits = 3, Title = "JAVA",},
                new Course{CourseID = 2000, Credits = 4, Title = "C#",},
                new Course{CourseID = 3000, Credits = 3, Title = "ASP.Net",},
                new Course{CourseID = 4000, Credits = 3, Title = "Software Testing",},
                new Course{CourseID = 5000, Credits = 4, Title = "AI",},
                new Course{CourseID = 6000, Credits = 3, Title = "Multimedia",},
                new Course{CourseID = 7000, Credits = 3, Title = "Linux",},
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
                new Enrollment{StudentID = 1, CourseID = 1000, Grade = Grade.A},
                new Enrollment{StudentID = 1, CourseID = 2000, Grade = Grade.C},
                new Enrollment{StudentID = 1, CourseID = 3000, Grade = Grade.B},
                new Enrollment{StudentID = 2, CourseID = 4000, Grade = Grade.B},
                new Enrollment{StudentID = 2, CourseID = 5000, Grade = Grade.F},
                new Enrollment{StudentID = 3, CourseID = 6000, Grade = Grade.F},
                new Enrollment{StudentID = 3, CourseID = 1000, Grade = Grade.D},
                new Enrollment{StudentID = 4, CourseID = 1000, Grade = Grade.C},
                new Enrollment{StudentID = 4, CourseID = 2000, Grade = Grade.F},
                //new Enrollment{StudentID = 5, CourseID = 3000, Grade = Grade.C},
                //new Enrollment{StudentID = 6, CourseID = 4000},
                //new Enrollment{StudentID = 7, CourseID = 5000, Grade = Grade.A},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}