using BITCsharpAssignment2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BITCsharpAssignment2.Helpers
{
    public class Helper
    {

        public static int CalculateAge(DateTime birthDate)
        {
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - birthDate.Year;

            if (currentDate.Month < birthDate.Month || (currentDate.Month == birthDate.Month && currentDate.Day < birthDate.Day))
            {
                age--;
            }

            return age;
        }

        public static void DisplayStudentInfo(List<Student> students)
        {
            Console.WriteLine();
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.FirstName} {student.LastName}, Date Of Birth: {student.DateOfBirth.ToShortDateString()}");
            }
            Console.WriteLine();
        }
    }
}
