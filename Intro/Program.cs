// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.Entities;

Console.WriteLine("Hello, World!");

string message1 = "Krediler";

bool isAuthentication = true;

if (isAuthentication)
{
    Console.WriteLine("Welcome Baransel");
}
else
{
    Console.WriteLine("Error acces");
}

string[] credits = new string[3] { "kredi1", "kredi2", "kredi3" };

string[] loans = { "Kredi4", "Kredi5", "Kredi6", "Kredi7", "Kredi8" };

foreach (var credi in credits)
{
    Console.WriteLine(credi);
}

foreach (var loan in loans)
{
    Console.WriteLine(loan);
}

for (var i=0; i<loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}

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

Course[] courses = {course1,course2,course3};
for (var i=0; i<courses.Length; i++)
{
    Console.WriteLine(courses[i].Id + ":" + courses[i].Name);
}

CourseManager courseManager = new CourseManager();
foreach (var course in courseManager.GetAll())
{
    Console.WriteLine(course.Id + ":" + course.Name);
}