using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business
{
    public class CourseManager
    {
        Course[] courses = new Course[3];
        public CourseManager()
        {
            Course course1 = new Course
            {
                Id = 1,
                Name = "C#",
                Description = ".NET 8 vs..",
                Price = 0
            };

            Course course2 = new Course
            {
                Id = 2,
                Name = "Java",
                Description = "Spring",
                Price = 15.5
            };

            Course course3 = new Course
            {
                Id = 3,
                Name = "JavaScript",
                Description = "Next.JS",
                Price = 19.99
            };
            courses[0] = course1;
            courses[1] = course2;
            courses[2] = course3;
        }
        public Course[] GetAll()
        {
            return courses;
        }
    }
}
