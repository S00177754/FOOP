using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LabOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string menuChoice = "0";
            int[] gradeTest = { 100, 98, 88, 86, 40, 56, 66 };

            //Input
            Menu(ref menuChoice, ref gradeTest);

            Console.ReadKey();
        }

        static void Menu(ref string menuChoice,ref int[]gradeTest)
        {
            while (menuChoice != "10")
            {
                //Replaced Console.WriteLine(); with a \n in next line
                Console.WriteLine("\nPlease choose a function:");
                Console.WriteLine("1.Exercise One,Three");
                Console.WriteLine("2.Exercise Two");
                Console.WriteLine("3.Exercise Four");
                Console.WriteLine("4.Exercise Five");
                Console.WriteLine("5.Exercise Six,Seven");
                Console.WriteLine("6.Exercise Eight");
                Console.WriteLine("7.Exercise Nine");
                Console.WriteLine("8.Exercise Ten");
                Console.WriteLine("9. Clear Screen");
                Console.WriteLine("10. Exit");

                Console.Write("Enter Choice: ");
                menuChoice = Console.ReadLine();


                switch (menuChoice)
                {
                    case "1":
                        PercentagePoints();
                        break;

                    case "2":
                        GradePoints();
                        break;

                    case "3":
                        LeavingCertCalculator();
                        break;

                    case "4":
                        PointCalc();
                        break;

                    case "5":
                        ReadFileGrades();
                        break;

                    case "6":
                        ReadFilePercentageArray();
                        break;

                    case "7":
                        PointArray(gradeTest);
                        break;

                    case "8":
                        UserInput();
                        break;

                    case "9":
                        Console.Clear();
                        break;

                    case "10":
                        Console.WriteLine("Press Any Key To Exit");
                        break;

                    default:
                        Console.WriteLine("Invalid Selection");
                        break;

                }
            }
        }

        //Exercise One, Three
        static void PercentagePoints()
        {
            //Variables
            string userGrade, message, level; //Grouped String variables together
            bool exit;
            int grade;

            //Input
            do
            {
                Console.Write("\nHigher or Ordinary Level (H/O): ");
                level = Console.ReadLine();
                level = level.ToUpper();

                if (level == "H" || level == "HIGHER")
                {
                    //Enter Percentage
                    do
                    {
                        Console.Write("Please Enter Percentage: ");
                        userGrade = Console.ReadLine();

                        if (int.TryParse(userGrade, out grade))
                        {
                            grade = int.Parse(userGrade);
                        }
                        else
                        {
                            Console.WriteLine("Error - Cannot Convert To Integer");
                        }
                    }
                    while (!(int.TryParse(userGrade, out grade)));

                    //Process(Takes in grade and gives out points)
                    if (grade < 30)
                    {
                        message = "0";
                    }
                    else if (grade >= 30 && grade < 40)
                    {
                        message = "37";
                    }
                    else if (grade >= 40 && grade < 50)
                    {
                        message = "46";
                    }
                    else if (grade >= 50 && grade < 60)
                    {
                        message = "56";
                    }
                    else if (grade >= 60 && grade < 70)
                    {
                        message = "66";
                    }
                    else if (grade >= 70 && grade < 80)
                    {
                        message = "77";
                    }
                    else if (grade >= 80 && grade < 90)
                    {
                        message = "88";
                    }
                    else if (grade >= 90 && grade <= 100)
                    {
                        message = "100";
                    }
                    else
                    {
                        message = "Error";
                    }

                }
                else if (level == "O" || level == "ORDINARY")
                {
                    do
                    {
                        Console.Write("Please Enter Percentage: ");
                        userGrade = Console.ReadLine();

                        if (int.TryParse(userGrade, out grade))
                        {
                            grade = int.Parse(userGrade);
                        }
                        else
                        {
                            Console.WriteLine("Error - Cannot Convert To Integer");
                        }
                    }
                    while (!(int.TryParse(userGrade, out grade)));

                    //Process
                    if (grade < 30)
                    {
                        message = "0";
                    }
                    else if (grade >= 30 && grade < 40)
                    {
                        message = "0";
                    }
                    else if (grade >= 40 && grade < 50)
                    {
                        message = "12";
                    }
                    else if (grade >= 50 && grade < 60)
                    {
                        message = "20";
                    }
                    else if (grade >= 60 && grade < 70)
                    {
                        message = "28";
                    }
                    else if (grade >= 70 && grade < 80)
                    {
                        message = "37";
                    }
                    else if (grade >= 80 && grade < 90)
                    {
                        message = "46";
                    }
                    else if (grade >= 90 && grade <= 100)
                    {
                        message = "56";
                    }
                    else
                    {
                        message = "Error";
                    }

                }
                else
                {
                    message = "Invalid";
                    Console.WriteLine("Invalid Selection");
                }

                exit = false;
                if (level == "H" || level == "HIGHER" || level == "O" || level == "ORDINARY")
                {
                    exit = true;
                }
            }
            while (exit == false);

            //Output
            Console.WriteLine("Points: " + message);
        }

        //Exercise Two
        static void GradePoints()
        {
            //Variables
            int points;
            string grade;

            //Inputs
            Console.Write("\nPlease Enter Grade:");
            grade = Console.ReadLine();
            grade = grade.ToUpper();

            //Process
            switch (grade)
            {
                case "H1":
                    points = 100;
                    break;

                case "H2":
                    points = 88;
                    break;

                case "H3":
                    points = 77;
                    break;

                case "H4":
                    points = 66;
                    break;

                case "H5":
                    points = 56;
                    break;

                case "H6":
                    points = 46;
                    break;

                case "H7":
                    points = 37;
                    break;

                case "H8":
                    points = 0;
                    break;

                case "O1":
                    points = 56;
                    break;

                case "O2":
                    points = 46;
                    break;

                case "O3":
                    points = 37;
                    break;

                case "O4":
                    points = 28;
                    break;

                case "O5":
                    points = 20;
                    break;

                case "O6":
                    points = 12;
                    break;

                case "O7":
                    points = 0;
                    break;

                case "O8":
                    points = 0;
                    break;

                default:
                    points = 0;
                    Console.WriteLine("Error - Please check that entered data is valid");
                    break;
            }

            //Output
            Console.WriteLine("Points:" + points);

        }

        //Exercise Four
        static void LeavingCertCalculator()
        {
            //Variables
            int[] results = new int[8];
            string userGrade, level;
            bool exit;
            int grade, points;

            for (int i = 0; i < 7; i++)
            {
                //Input
                do
                {
                    Console.Write("\nHigher or Ordinary Level (H/O): ");
                    level = Console.ReadLine();
                    level = level.ToUpper();

                    if (level == "H" || level == "HIGHER")
                    {
                        //Enter Percentage
                        do
                        {
                            Console.Write("Please Enter Percentage: ");
                            userGrade = Console.ReadLine();

                            if (int.TryParse(userGrade, out grade))
                            {
                                grade = int.Parse(userGrade);
                            }
                            else
                            {
                                Console.WriteLine("Error - Cannot Convert To Integer");
                            }
                        }
                        while (!(int.TryParse(userGrade, out grade)));

                        //Process
                        if (grade < 30)
                        {
                            points = 0;

                        }
                        else if (grade >= 30 && grade < 40)
                        {
                            points = 37;
                        }
                        else if (grade >= 40 && grade < 50)
                        {
                            points = 46;
                        }
                        else if (grade >= 50 && grade < 60)
                        {
                            points = 56;
                        }
                        else if (grade >= 60 && grade < 70)
                        {
                            points = 66;
                        }
                        else if (grade >= 70 && grade < 80)
                        {
                            points = 77;
                        }
                        else if (grade >= 80 && grade < 90)
                        {
                            points = 88;
                        }
                        else if (grade >= 90 && grade <= 100)
                        {
                            points = 100;
                        }
                        else
                        {
                            points = 0;
                        }
                    }
                    else if (level == "O" || level == "ORDINARY")
                    {
                        do
                        {


                            Console.Write("Please Enter Percentage: ");
                            userGrade = Console.ReadLine();
                            if (int.TryParse(userGrade, out grade))
                            {
                                grade = int.Parse(userGrade);
                            }
                            else
                            {
                                Console.WriteLine("Error - Cannot Convert To Integer");
                            }
                        }
                        while (!(int.TryParse(userGrade, out grade)));

                        //Process
                        if (grade < 30)
                        {
                            points = 0;
                        }
                        else if (grade >= 30 && grade < 40)
                        {
                            points = 0;
                        }
                        else if (grade >= 40 && grade < 50)
                        {
                            points = 12;
                        }
                        else if (grade >= 50 && grade < 60)
                        {
                            points = 20;
                        }
                        else if (grade >= 60 && grade < 70)
                        {
                            points = 28;
                        }
                        else if (grade >= 70 && grade < 80)
                        {
                            points = 37;
                        }
                        else if (grade >= 80 && grade < 90)
                        {
                            points = 46;
                        }
                        else if (grade >= 90 && grade <= 100)
                        {
                            points = 56;
                        }
                        else
                        {
                            points = 0;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Selection");
                        points = 0;
                    }

                    exit = false;
                    if (level == "H" || level == "HIGHER" || level == "O" || level == "ORDINARY")
                    {
                        exit = true;
                    }
                }
                while (exit == false);

                //Output
                results[i] = points;
                results[7] += points;
                Console.WriteLine("Points: " + points);
            }

            //Outside Of Loop
            Array.Sort(results);

            for (int i = 0; i < results.Length - 1; i++)
            {
                Console.WriteLine(results[i]);
            }
            results[7] -= results[0];
            Console.WriteLine("Total Points:" + results[7]);

        }

        //Exercise Five
        static void PointCalc()
        {
            //Variables
            const string SENTINAL = "-1";
            int grade;
            string userGrade = "0";
            string level, message;

            do
            {
                Console.WriteLine();
                Console.WriteLine("\nTo Exit, enter -1!");
                Console.Write("Higher or Ordinary Level (H/O): ");
                level = Console.ReadLine();
                level = level.ToUpper();

                if (level == SENTINAL)
                {
                    message = "Exit";
                }
                else if (level == "H" || level == "HIGHER")
                {
                    do
                    {
                        Console.Write("\nPlease Enter Percentage: ");
                        userGrade = Console.ReadLine();

                        if (int.TryParse(userGrade, out grade))
                        {
                            grade = int.Parse(userGrade);
                        }
                        else
                        {
                            Console.WriteLine("Error - Cannot Convert To Integer");
                        }
                    }
                    while (!(int.TryParse(userGrade, out grade)));

                    //Process
                    if (grade < 30)
                    {
                        message = "0";
                    }
                    else if (grade >= 30 && grade < 40)
                    {
                        message = "37";
                    }
                    else if (grade >= 40 && grade < 50)
                    {
                        message = "46";
                    }
                    else if (grade >= 50 && grade < 60)
                    {
                        message = "56";
                    }
                    else if (grade >= 60 && grade < 70)
                    {
                        message = "66";
                    }
                    else if (grade >= 70 && grade < 80)
                    {
                        message = "77";
                    }
                    else if (grade >= 80 && grade < 90)
                    {
                        message = "88";
                    }
                    else if (grade >= 90 && grade <= 100)
                    {
                        message = "100";
                    }
                    else
                    {
                        message = "Error";
                    }
                }
                else if (level == "O" || level == "ORDINARY")
                {
                    do
                    {


                        Console.Write("Please Enter Percentage: ");
                        userGrade = Console.ReadLine();

                        if (int.TryParse(userGrade, out grade))
                        {
                            grade = int.Parse(userGrade);
                        }
                        else
                        {
                            Console.WriteLine("Error - Cannot Convert To Integer");
                        }
                    }
                    while (!(int.TryParse(userGrade, out grade)));

                    //Process
                    if (grade < 30)
                    {
                        message = "0";
                    }
                    else if (grade >= 30 && grade < 40)
                    {
                        message = "0";
                    }
                    else if (grade >= 40 && grade < 50)
                    {
                        message = "12";
                    }
                    else if (grade >= 50 && grade < 60)
                    {
                        message = "20";
                    }
                    else if (grade >= 60 && grade < 70)
                    {
                        message = "28";
                    }
                    else if (grade >= 70 && grade < 80)
                    {
                        message = "37";
                    }
                    else if (grade >= 80 && grade < 90)
                    {
                        message = "46";
                    }
                    else if (grade >= 90 && grade <= 100)
                    {
                        message = "56";
                    }
                    else
                    {
                        message = "Error";
                    }
                }
                else
                {
                    message = "Invalid";
                    Console.WriteLine("Invalid Selection");
                }


                //Output
                Console.WriteLine("Points: " + message);
            }
            while (level != SENTINAL);

        }

        //Exercise Six, Seven
        static void ReadFileGrades()
        {
            //Variables
            string test = "word";
            string[] results = new string[7];
            int total = 0;
            int points = 0;


            FileStream fs = File.Open(@"LCgrades.txt", FileMode.Open, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            StreamWriter sw = new StreamWriter(fs);


            //Process
            test = sr.ReadLine();
            while (test != null)
            {
                Console.WriteLine(test);
                results = test.Split(',');

                foreach (var item in results)
                {

                    int grade = int.Parse(item);


                    //Process
                    PercentageToPoints("h", grade);

                    total += points;

                }

                test = sr.ReadLine();
            }
            sw.WriteLine(total);
            Console.WriteLine(total);

            sw.Close();


        }

        //Exercise Eight
        static void ReadFilePercentageArray()
        {
            //Variables
            string test = "";
            string[] results = new string[7];
            int total = 0;

            int[] boundary = { 0, 30, 40, 50, 60, 70, 80, 90 };
            int[] higherPoints = { 0, 37, 46, 56, 66, 77, 88, 100 };
            //int[] ordinaryPoints = { 0, 12, 20, 28, 37, 46, 56 };

            FileStream fs = File.Open(@"LCgrades.txt", FileMode.Open, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            StreamWriter sw = new StreamWriter(fs);


            //Process
            test = sr.ReadLine();
            while (test != null)
            {
                Console.WriteLine(test);
                results = test.Split(',');
                Console.WriteLine("Points:");
                foreach (var percentage in results)
                {
                    for (int i = 0; i < boundary.Length - 1; i++)
                    {
                        if (int.Parse(percentage) > boundary[i] && int.Parse(percentage) < boundary[i + 1])
                        {
                            total += higherPoints[i];
                        }
                    }
                }

                test = sr.ReadLine();
            }
            Console.WriteLine(total);

            sw.Close();


        }

        //Exercise Nine
        static void PointArray(int[] grades)
        {
            //Variables
            int points = 0;
            int total = 0;

            foreach (var grade in grades)
            {
                //Process
                if (grade < 30)
                {
                    points = 0;
                }
                else if (grade >= 30 && grade < 40)
                {
                    points = 37;
                }
                else if (grade >= 40 && grade < 50)
                {
                    points = 46;
                }
                else if (grade >= 50 && grade < 60)
                {
                    points = 56;
                }
                else if (grade >= 60 && grade < 70)
                {
                    points = 66;
                }
                else if (grade >= 70 && grade < 80)
                {
                    points = 77;
                }
                else if (grade >= 80 && grade < 90)
                {
                    points = 88;
                }
                else if (grade >= 90 && grade <= 100)
                {
                    points = 100;
                }
                else
                {
                    points = 0;
                }

                total += points;
            }
            Console.WriteLine("Total Points:" + total);
        }

        //Exercise Ten
        static void UserInput()
        {
            //Variables
            string studName = "studName";
            string studNum = "studNum";

            string[] subjectNames = { "sub1", "sub2", "sub3", "sub4", "sub5", "sub6", "sub7" };
            string[] subjectLevels = { "H", "H", "H", "H", "H", "H", "H" };
            string[] subjectGrade = { "H1", "H2", "H3", "H4", "H5", "H6", "H7" };
            int[] subjectPoints = { 1, 2, 3, 4, 5, 6, 7 };

            const int subjectAmount = 7;
            int totalPoints = 0;

            bool exit = false;

            Console.Write("Please Enter Name:");
            studName = Console.ReadLine();

            Console.Write("Please Enter Student Number:");
            studNum = Console.ReadLine();

            Console.WriteLine();

            for (int i = 0; i < subjectAmount; i++)
            {
                Console.Write("Please Enter Subject Name:");
                subjectNames[i] = Console.ReadLine();

                Console.Write("Please Enter Subject Level:");
                subjectLevels[i] = Console.ReadLine();
                subjectLevels[i] = subjectLevels[i].ToUpper();

                Console.Write("Please Enter Subject Grade:");
                subjectGrade[i] = Console.ReadLine();
                subjectGrade[i] = subjectGrade[i].ToUpper();

                do
                {
                    switch (subjectGrade[i])
                    {
                        case "H1":
                            subjectPoints[i] = 100;
                            break;

                        case "H2":
                            subjectPoints[i] = 88;
                            break;

                        case "H3":
                            subjectPoints[i] = 77;
                            break;

                        case "H4":
                            subjectPoints[i] = 66;
                            break;

                        case "H5":
                            subjectPoints[i] = 56;
                            break;

                        case "H6":
                            subjectPoints[i] = 46;
                            break;

                        case "H7":
                            subjectPoints[i] = 37;
                            break;

                        case "H8":
                            subjectPoints[i] = 0;
                            break;

                        case "O1":
                            subjectPoints[i] = 56;
                            break;

                        case "O2":
                            subjectPoints[i] = 46;
                            break;

                        case "O3":
                            subjectPoints[i] = 37;
                            break;

                        case "O4":
                            subjectPoints[i] = 28;
                            break;

                        case "O5":
                            subjectPoints[i] = 20;
                            break;

                        case "O6":
                            subjectPoints[i] = 12;
                            break;

                        case "O7":
                            subjectPoints[i] = 0;
                            break;

                        case "O8":
                            subjectPoints[i] = 0;
                            break;

                        default:
                            subjectPoints[i] = 0;
                            Console.WriteLine("Error - Please check that entered data is valid");
                            break;
                    }

                    exit = false;
                    if (subjectLevels[i] == "H" || subjectLevels[i] == "HIGHER" || subjectLevels[i] == "O" || subjectLevels[i] == "ORDINARY")
                    {
                        exit = true;
                    }
                }
                while (exit == false);

                totalPoints += subjectPoints[i];
                Console.WriteLine();
            }

            FileStream fs = new FileStream(@"PointReport.txt", FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write);
            StreamWriter sw = new StreamWriter(fs);


            Console.WriteLine("Leaving Cert Report");
            Console.WriteLine("-----------------------------------");

            sw.WriteLine("Leaving Cert Report");
            sw.WriteLine("-----------------------------------");

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Subject Name: " + subjectNames[i]);
                Console.WriteLine("Subject Level: " + subjectLevels[i]);
                Console.WriteLine("Subject Grade: " + subjectGrade[i]);
                Console.WriteLine("Subject Points: " + subjectPoints[i]);
                Console.WriteLine();

                sw.WriteLine("Subject Name: " + subjectNames[i]);
                sw.WriteLine("Subject Level: " + subjectLevels[i]);
                sw.WriteLine("Subject Grade: " + subjectGrade[i]);
                sw.WriteLine("Subject Points: " + subjectPoints[i]);
                sw.WriteLine();
            }

            Console.WriteLine("Total Points:" + totalPoints);
            sw.WriteLine("Total Points:" + totalPoints);

            sw.Close();

        }

        //Converts Percentage To Points
        static int PercentageToPoints(string level, int percentage)
        {
            int points = 0;
            level = level.ToUpper();

            if (level[0] == 'H')
            {
                if (percentage < 30)
                {
                    points = 0;
                }
                else if (percentage >= 30 && percentage < 40)
                {
                    points = 37;
                }
                else if (percentage >= 40 && percentage < 50)
                {
                    points = 46;
                }
                else if (percentage >= 50 && percentage < 60)
                {
                    points = 56;
                }
                else if (percentage >= 60 && percentage < 70)
                {
                    points = 66;
                }
                else if (percentage >= 70 && percentage < 80)
                {
                    points = 77;
                }
                else if (percentage >= 80 && percentage < 90)
                {
                    points = 88;
                }
                else if (percentage >= 90 && percentage <= 100)
                {
                    points = 100;
                }
                else
                {
                    points = 0;
                }
            }
            else if(level[0] == 'O')
            {
                if (percentage < 30)
                {
                    points = 0;
                }
                else if (percentage >= 30 && percentage < 40)
                {
                    points = 0;
                }
                else if (percentage >= 40 && percentage < 50)
                {
                    points = 12;
                }
                else if (percentage >= 50 && percentage < 60)
                {
                    points = 20;
                }
                else if (percentage >= 60 && percentage < 70)
                {
                    points = 28;
                }
                else if (percentage >= 70 && percentage < 80)
                {
                    points = 37;
                }
                else if (percentage >= 80 && percentage < 90)
                {
                    points = 46;
                }
                else if (percentage >= 90 && percentage <= 100)
                {
                    points = 56;
                }
                else
                {
                    points = 0;
                }
            }

            return points;

        }
    }
}
