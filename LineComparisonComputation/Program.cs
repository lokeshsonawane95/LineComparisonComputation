using System;

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
                Console.WriteLine("3. Comparinson of two lines");
                Console.WriteLine("4. Comparison of two lines using 2 methods");
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
                    case 3:
                        TwoLinesComparison twoLinesComparison = new TwoLinesComparison();
                        twoLinesComparison.Comparison();
                        break;
                    case 4:
                        ComparisonUsingAllMethods cm = new ComparisonUsingAllMethods();
                        cm.AllComparison();
                        break;
                }
            } while (choice != 0);
        }
    }
}