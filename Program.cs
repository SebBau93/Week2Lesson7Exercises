using System;

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
                Console.WriteLine("Enter your age:");

                bool isUshort = ushort.TryParse(Console.ReadLine(), out ushort increase);

                if (isUshort)
                {
                    if (increase >= 200)
                        Console.WriteLine("You're a MONSTER!");
                    else if (increase < 200 && increase > 180)
                        Console.WriteLine("Not bad...");
                    else
                        Console.WriteLine("You're a dwarf.");
                }
                else
                    Console.WriteLine("Invalid increase");
            }
        }
    }
}
