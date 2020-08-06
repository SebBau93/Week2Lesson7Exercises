using System;
using System.Linq;
using System.Threading;

namespace Week2Lesson7Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1

            Exercise1();
            Console.WriteLine(Environment.NewLine);

            #endregion

            #region Exercise 2

            Exercise2();
            Console.WriteLine(Environment.NewLine);

            #endregion

            #region Exercise 3

            Exercise3();
            Console.WriteLine(Environment.NewLine);

            #endregion

            #region Exercise 4

            Exercise4();
            Console.WriteLine(Environment.NewLine);

            #endregion

            #region Exercise 5

            Exercise5();
            Console.WriteLine(Environment.NewLine);

            #endregion

            #region Exercise 6

            Exercise6();
            Console.WriteLine(Environment.NewLine);

            #endregion

            #region Exercise 7

            Exercise7();
            Console.WriteLine(Environment.NewLine);

            #endregion

            #region Exercise 8

            Exercise8();
            Console.WriteLine(Environment.NewLine);

            #endregion

            #region Exercise 9

            Exercise9();
            Console.WriteLine(Environment.NewLine);

            #endregion

            #region Exercise 10

            Exercise10();
            Console.WriteLine(Environment.NewLine);

            #endregion

            #region Exercise 11

            Exercise11();
            Console.WriteLine(Environment.NewLine);

            #endregion

            #region Exercise 12

            Exercise12();
            Console.WriteLine(Environment.NewLine);

            #endregion

            #region Exercise 13

            Exercise13();
            Console.WriteLine(Environment.NewLine);

            #endregion

        }

        private static void Exercise1()
        {
            Console.WriteLine("Exercise 1");

            int a = 5;
            int b = 5;

            if (a == b)
                Console.WriteLine($"{a} i {b} are equal.");
            else
                Console.WriteLine($"{a} i {b} are not equal.");

        }

        private static void Exercise2()
        {
            Console.WriteLine("Exercise 2");

            while (true)
            {
                Console.WriteLine("Enter a number to verify if it's even or odd:");

                bool isInt = Int32.TryParse(Console.ReadLine(), out int number);

                if (isInt)
                {
                    if (number % 2 == 0)
                        Console.WriteLine($"{number} is even.");
                    else
                        Console.WriteLine($"{number} is odd");

                    return;
                }
                else
                    Console.WriteLine("Invalid number");
            }
        }

        private static void Exercise3()
        {
            Console.WriteLine("Exercise 3");

            while (true)
            {
                Console.WriteLine("Enter a number to verify if it's positive or negative:");

                bool isInt = Int32.TryParse(Console.ReadLine(), out int number);

                if (isInt)
                {
                    if (number > 0)
                        Console.WriteLine($"{number} is positive.");
                    else if (number < 0)
                        Console.WriteLine($"{number} is negative");
                    else
                        Console.WriteLine($"{number} is neither positive nor negative");
                    return;
                }
                else
                    Console.WriteLine("Invalid number");
            }
        }

        private static void Exercise4()
        {
            Console.WriteLine("Exercise 4");

            while (true)
            {
                Console.WriteLine("Enter a year to verify if it's leap year:");

                bool isInt = Int32.TryParse(Console.ReadLine(), out int year);

                if (isInt)
                {
                    if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                        Console.WriteLine($"{year} is leap year.");
                    else
                        Console.WriteLine($"{year} isn't leap year.");
                    return;
                }
                else
                    Console.WriteLine("Invalid year");
            }
        }

        private static void Exercise5()
        {
            Console.WriteLine("Exercise 5");

            while (true)
            {
                Console.WriteLine("Enter your age:");

                bool isByte = byte.TryParse(Console.ReadLine(), out byte age);

                if (isByte)
                {
                    if (age >= 35)
                        Console.WriteLine("You can be a deputy, senator or president.");
                    else if (age >= 30 && age < 35 )
                        Console.WriteLine("You can be a deputy or senator.");
                    else if (age < 30 && age >= 21)
                        Console.WriteLine("You can be a deputy.");
                    else
                        Console.WriteLine("You cannot apply for any position.");
                    return;
                }
                else
                    Console.WriteLine("Invalid age");
            }
        }

        private static void Exercise6()
        {
            Console.WriteLine("Exercise 6");

            while (true)
            {
                Console.WriteLine("Enter your increase:");

                bool isUshort = ushort.TryParse(Console.ReadLine(), out ushort increase);

                if (isUshort)
                {
                    if (increase >= 200)
                        Console.WriteLine("You're a MONSTER!");
                    else if (increase < 200 && increase > 180)
                        Console.WriteLine("Not bad...");
                    else
                        Console.WriteLine("You're a dwarf.");
                    return;
                }
                else
                    Console.WriteLine("Invalid increase");
            }
        }

        private static void Exercise7()
        {
            Console.WriteLine("Exercise 7");

            int[] maxValueArray = new int[3];

            while (true)
            {
                maxValueArray[0] = AddNumber("first");
                maxValueArray[1] = AddNumber("second");
                maxValueArray[2] = AddNumber("third");
                Console.WriteLine($"Max value for the given numbers is {maxValueArray.Max()}");
                return;
            };

            static int AddNumber(string nextNumber)
            {
                while (true)
                {
                    Console.WriteLine($"Enter a {nextNumber} number:");

                    bool isInt = Int32.TryParse(Console.ReadLine(), out int number);

                    if (isInt)
                        return number;

                    Console.WriteLine("Invalid number");
                }
            }
        }
        private static void Exercise8()
        {
            Console.WriteLine("Exercise 8");

            int[] schoolSubjectScoresArray = new int[3];

            while (true)
            {
                schoolSubjectScoresArray[0] = AddSchoolSubjectScore("math");
                schoolSubjectScoresArray[1] = AddSchoolSubjectScore("science");
                schoolSubjectScoresArray[2] = AddSchoolSubjectScore("history");

                int allScores = schoolSubjectScoresArray.Sum();

                if (allScores > 180 || (schoolSubjectScoresArray[0] + schoolSubjectScoresArray[1] > 150) || (schoolSubjectScoresArray[0] + schoolSubjectScoresArray[2] > 150))
                    Console.WriteLine("Candidate admitted to recruitment.");
                else
                    Console.WriteLine("Candidate not admitted to recruitment.");
                return;
            };

            static int AddSchoolSubjectScore(string schoolSubjectName)
            {
                while (true)
                {
                    Console.WriteLine($"Enter a {schoolSubjectName} score:");

                    bool isInt = Int32.TryParse(Console.ReadLine(), out int score);

                    if (isInt && score >= 0)
                        return score;

                    Console.WriteLine("Invalid score");
                }
            }
        }

        private static void Exercise9()
        {
            Console.WriteLine("Exercise 9");

            while (true)
            {
                Console.WriteLine($"Enter a temperature:");

                bool isUshort = ushort.TryParse(Console.ReadLine(), out ushort temperature);

                if (isUshort)
                {
                    if (temperature < 0)
                        Console.WriteLine("ALASKA!");
                    else if (temperature >= 0 && temperature < 10)
                        Console.WriteLine("It's cold!");
                    else if (temperature >= 10 && temperature < 20)
                        Console.WriteLine("It's chilly!");
                    else if (temperature >= 20 && temperature < 30)
                        Console.WriteLine("Perfectly!");
                    else if (temperature >= 30 && temperature < 40)
                        Console.WriteLine("It's a little too hot!");
                    else
                        Console.WriteLine("I'm burning!");
                    return;
                }

                Console.WriteLine("Invalid temperature");
            };
        }

        private static void Exercise10()
        {
            Console.WriteLine("Exercise 10");

            int[] triangleSides = new int[3];

            while (true)
            {
                triangleSides[0] = AddTriangleSideValue("first");
                triangleSides[1] = AddTriangleSideValue("second");
                triangleSides[2] = AddTriangleSideValue("third");

                int maxValue = triangleSides.Max();
                int sumShorterSidesValue = triangleSides.Where(val => val != maxValue).Sum();

                if (sumShorterSidesValue > maxValue)
                    Console.WriteLine("You can build a triangle form the given sides.");
                else
                    Console.WriteLine("You can't build a triangle form the given sides.");

                return;
            };

            static int AddTriangleSideValue(string sideName)
            {
                while (true)
                {
                    Console.WriteLine($"Enter a {sideName} value:");

                    bool isInt = Int32.TryParse(Console.ReadLine(), out int value);

                    if (isInt && value > 0)
                        return value;

                    Console.WriteLine("Invalid value");
                }
            }
        }

        private static void Exercise11()
        {
            Console.WriteLine("Exercise 11");

            while (true)
            {
                Console.WriteLine($"Enter a rate:");

                bool isByte = byte.TryParse(Console.ReadLine(), out byte rate);

                if (isByte)
                {
                    switch (rate)
                    {
                        case 1:
                            Console.WriteLine("Niedostateczny");
                            return;
                        case 2:
                            Console.WriteLine("Dopuszczający");
                            return;
                        case 3:
                            Console.WriteLine("Dostateczny");
                            return;
                        case 4:
                            Console.WriteLine("Dobry");
                            return;
                        case 5:
                            Console.WriteLine("Bardzo dobry");
                            return;
                        case 6:
                            Console.WriteLine("Celujący");
                            return;
                        default:
                            Console.WriteLine("Given rate doesn't exist.");
                            return;
                    }
                }

                Console.WriteLine("Invalid rate");
            };
        }

        private static void Exercise12()
        {
            Console.WriteLine("Exercise 12");

            while (true)
            {
                Console.WriteLine($"Enter a number for a day of the week:");

                bool isByte = byte.TryParse(Console.ReadLine(), out byte dayNumber);

                if (isByte)
                {
                    switch (dayNumber)
                    {
                        case 1:
                            Console.WriteLine("Monday");
                            return;
                        case 2:
                            Console.WriteLine("Tuesday");
                            return;
                        case 3:
                            Console.WriteLine("Wednesday");
                            return;
                        case 4:
                            Console.WriteLine("Thursday");
                            return;
                        case 5:
                            Console.WriteLine("Friday");
                            return;
                        case 6:
                            Console.WriteLine("Saturday");
                            return;
                        case 7:
                            Console.WriteLine("Sunday");
                            return;
                        default:
                            Console.WriteLine("Given day of the week doesn't exist.");
                            return;
                    }
                }

                Console.WriteLine("Invalid number");
            };
        }

        private static void Exercise13()
        {
            Console.WriteLine("Exercise 13");

            Console.WriteLine("Welcome in Calculator App!");

            while (true)
            {
                Console.WriteLine("Choose action:");
                Console.WriteLine("1 - Go to Calculator App Actions");
                Console.WriteLine("2 - Exit application");
                Console.WriteLine(Environment.NewLine);

                bool isByteAppAction = byte.TryParse(Console.ReadLine(), out byte appAction);

                if (isByteAppAction)
                {
                    switch (appAction)
                    {
                        case 1:
                            AppBody();
                            break;
                        case 2:
                            Console.WriteLine("Closing the application...");
                            Console.WriteLine(Environment.NewLine);
                            Thread.Sleep(2000);
                            return;
                        default:
                            Console.WriteLine("Invalid app action.");
                            Console.WriteLine(Environment.NewLine);
                            break;
                    }
                }
            };

            static int AddNumber(string nextNumber)
            {
                while (true)
                {
                    Console.WriteLine($"Enter a {nextNumber} number:");

                    bool isInt = Int32.TryParse(Console.ReadLine(), out int number);

                    if (isInt)
                        return number;

                    Console.WriteLine("Invalid number");
                    Console.WriteLine(Environment.NewLine);
                }
            }

            static void AppBody()
            {
                int firstNumber = AddNumber("first");
                int secondNumber = AddNumber("second");
                int result;

                Console.WriteLine("Set operation:");
                Console.WriteLine("1 - Addition");
                Console.WriteLine("2 - Subtraction");
                Console.WriteLine("3 - Multiplication");
                Console.WriteLine("4 - Division");
                Console.WriteLine(Environment.NewLine);

                bool isByte = byte.TryParse(Console.ReadLine(), out byte operation);

                if (isByte)
                {
                    switch (operation)
                    {
                        case 1:
                            result = firstNumber + secondNumber;
                            Console.WriteLine($"Result for addition: {result}");
                            Console.WriteLine(Environment.NewLine);
                            return;
                        case 2:
                            result = firstNumber - secondNumber;
                            Console.WriteLine($"Result for subtraction: {result}");
                            Console.WriteLine(Environment.NewLine);
                            return;
                        case 3:
                            result = firstNumber * secondNumber;
                            Console.WriteLine($"Result for multiplication: {result}");
                            Console.WriteLine(Environment.NewLine);
                            return;
                        case 4:
                            result = firstNumber / secondNumber;
                            Console.WriteLine($"Result for division: {result}");
                            Console.WriteLine(Environment.NewLine);
                            return;
                        default:
                            Console.WriteLine("Invalid operation.");
                            Console.WriteLine(Environment.NewLine);
                            return;
                    }
                }

                Console.WriteLine("Invalid operation value.");
                Console.WriteLine(Environment.NewLine);
            }
        }
    }
}
