﻿using System;

namespace LineComparisonComputation
{
    class Program
    {
        public static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("\n1. Calculate single line length");
                Console.WriteLine("2. Calculate if two lines are equal or not");

                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        SingleLineLength singleLineLength = new SingleLineLength();
                        singleLineLength.LineLength();
                        break;
                    case 2:
                        EqualityOfTwoLines equalityOfTwoLines = new EqualityOfTwoLines();
                        equalityOfTwoLines.Equality();
                        break;
                }

            } while (choice != 0);
        }
    }
}