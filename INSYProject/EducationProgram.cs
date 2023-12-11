using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSYProject
{
    internal class EducationProgram
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string ID { get; private set; }
        public string[] CourseSchedule { get; private set; }

        public Customer(string username, string password, string firstName, string lastName, int age)
        {
            Username = username;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            ID = GenerateID();
            CourseSchedule = AssignCourses();
        }

        private string GenerateID()
        {
            return $"{FirstName.Substring(0, 1)}{LastName.Substring(0, 1)}{Age}{DateTime.Now.Ticks}";
        }

        private string[] AssignCourses()
        {
            if (Age >= 7 && Age <= 9)
            {
                return new string[] { "Beginner English", "Beginner Math", "Physical Education" };
            }
            else if (Age >= 10 && Age <= 13)
            {
                return new string[] { "Beginner English Writing", "Intermediate Math", "Beginner History", "Course 4", "Course 5" };
            }
            else
            {
                return new string[] { "No Suitable Courses" };
            }
        }
    }
}
public class Program
{
    public static void Main()
    {
        // creat a customer file
        Customer customer = new Customer("username", "password", "firstname", "lastname", 10);

        // print customer's information
        Console.WriteLine($"Customer ID: {customer.ID}");
        Console.WriteLine("Course Schedule:");
        foreach (var course in customer.CourseSchedule)
        {
            Console.WriteLine(course);
        }
    }
}
