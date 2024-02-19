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


IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12314234";
customer1.FirstName = "Baran";
customer1.LastName = "Aydın";
customer1.CustomerNumber = "12314";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "12314234";
customer2.FirstName = "Hüseyin";
customer2.LastName = "Aydın";
customer2.CustomerNumber = "12314";

CoorporateCustomer customer3 = new CoorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlamaio";
customer3.CustomerNumber = "1234235";
customer3.TaxNumber = "1232134534";

CoorporateCustomer customer4 = new CoorporateCustomer();
customer4.Id = 4;
customer4.Name = "Udemy";
customer4.CustomerNumber = "12342357698";
customer4.TaxNumber = "1232134534";

int number1 = 20;
int number2 = 30;
number1 = number2;
number2 = 50;
Console.WriteLine(number1);  //30
Console.WriteLine(number2);  //50

string[] cities1 = { "Muğla", "Aydın", "Ankara" };
string[] cities2= { "Bursa", "Adana", "İzmir" };

cities1 = cities2;
cities2[0] = "İstanbul";
Console.WriteLine(cities1[0]);  //İstanbul
Console.WriteLine(cities2[0]);

BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}