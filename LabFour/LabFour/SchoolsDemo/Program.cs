using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            School[] schoolList = new School[3];

            for (int i = 0; i < schoolList.Length; i++)
            {
                schoolList[i] = new School();
                EnterInfo(schoolList[i]);
            }

            PrintData(schoolList);
            Array.Sort(schoolList);
            PrintData(schoolList);

            //int[] tester = { 2, 1, 4 };
            //Console.WriteLine(tester[0]);
            //Console.WriteLine(tester[1]);
            //Console.WriteLine(tester[2]);
            //Array.Sort<int>(tester);
            //Console.WriteLine("\n" + tester[0]);
            //Console.WriteLine(tester[1]);
            //Console.WriteLine(tester[2]);

            Console.ReadKey();
        }

        static void EnterInfo(School schoolObj)
        {
            Console.Write("Enter School Name: ");
            schoolObj.schoolName = Console.ReadLine();

            Console.Write("Enter Enrollment: ");
            schoolObj.schoolStudentNumbers = int.Parse(Console.ReadLine());
        }

        static void PrintData(School[] list)
        {
            foreach (var school in list)
            {
                Console.WriteLine($"{school.schoolName} has {school.schoolStudentNumbers} students.");
            }
        }
    }
}
