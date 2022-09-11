﻿using System;

namespace LineComparison_Computation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program on Master Branch");

            int x1, x2, y1, y2;
            Console.WriteLine("Enter the value of (x1,y1),(x2,y2) cordinates");
            x1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            int length1 = toFindLength(x1, y1, x2, y2);

            x1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            int length2 = toFindLength(x1, y1, x2, y2);

            Console.WriteLine(length1.Equals(length2));

        }

        private static int toFindLength(int x1, int y1, int x2, int y2)
        {
            return (int)Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }
    }
}
