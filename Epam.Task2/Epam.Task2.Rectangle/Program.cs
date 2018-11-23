﻿using System;

namespace Epam.Task2.Rectangle
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Greatings! You are using "
                             + "The Rectangle Area Calculator Program!");
            Console.WriteLine();

            int sideA = 0;
            bool check;

            while (true)
            {
                try
                {
                    if (sideA == 0)
                    {
                        Console.Write("Please, enter a value for side a: ");
                        check = int.TryParse(Console.ReadLine(), out sideA);
                        ValueCheck(check, ref sideA);
                        Console.WriteLine();
                    }

                    Console.Write("Please, enter a value for side b: ");
                    check = int.TryParse(Console.ReadLine(), out int sideB);
                    ValueCheck(check, ref sideB);
                    Console.WriteLine();

                    Console.WriteLine($"The area of the rectangle with "
                                      + $"side a = {sideA} and side b = "
                                      + $"{sideB} is: "
                                      + $"{RectArea(sideA, sideB).ToString()}");
                    return;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                }
            }
        }

        public static int RectArea(int a, int b)
        {
            int area = a * b;
            return area;
        }

        private static void ValueCheck(bool check, ref int val)
        {
            if (!check || val < 1)
            {
                val = 0;
                throw new ArgumentException("The entered value must "
                                            + "be a natural number.");
            }
        }
    }
}