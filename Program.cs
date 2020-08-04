﻿using System;

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
    }
}
