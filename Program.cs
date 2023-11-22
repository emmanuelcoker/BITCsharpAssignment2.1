using BITCsharpAssignment2.Models;
using BITCsharpAssignment2.Helpers;

namespace BITCsharpAssignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create an array of 10 students
            // Create an array of Student objects
            Student[] students = new Student[10];

            // Populate the array with student details
            students[0] = new Student { Id = 1, FirstName = "Johnny", LastName = "Doe", DateOfBirth = new DateTime(2005, 4, 10) };
            students[1] = new Student { Id = 2, FirstName = "Clark", LastName = "Kent", DateOfBirth = new DateTime(2006, 7, 10) };
            students[2] = new Student { Id = 3, FirstName = "Bob", LastName = "Johnson", DateOfBirth = new DateTime(2001, 3, 10) };
            students[3] = new Student { Id = 4, FirstName = "Hilary", LastName = "Martins", DateOfBirth = new DateTime(2000, 4, 10) };
            students[4] = new Student { Id = 5, FirstName = "Joe", LastName = "Kent", DateOfBirth = new DateTime(2010, 7, 10) };
            students[5] = new Student { Id = 6, FirstName = "Akin", LastName = "Johnson", DateOfBirth = new DateTime(2009, 3, 10) };
            students[6] = new Student { Id = 7, FirstName = "Marcus", LastName = "Denis", DateOfBirth = new DateTime(2008, 4, 10) };
            students[7] = new Student { Id = 8, FirstName = "Bimbo", LastName = "Aremu", DateOfBirth = new DateTime(2002, 7, 10) };
            students[8] = new Student { Id = 9, FirstName = "Bobby", LastName = "Akitola", DateOfBirth = new DateTime(1999, 3, 10) };
            students[9] = new Student { Id = 10, FirstName = "Nelson", LastName = "Dremon", DateOfBirth = new DateTime(2007, 4, 10) };

            Console.WriteLine("Student Database:");
            Helper.DisplayStudentInfo(students.ToList());


            //default age to find
            int ageToFind = 18;

            var studentsAtAge = students.Where(student => Helper.CalculateAge(student.DateOfBirth) == ageToFind).ToList();

            Console.WriteLine($"Students at {ageToFind} years old:");

            if (studentsAtAge.Count() > 0)
            {
                Helper.DisplayStudentInfo(studentsAtAge);
            }
            else
            {
                Console.WriteLine($"There are no students who are {ageToFind} years old");
            }
          
        }
    }
}