using System;
 class Problem1
    {
        static void Main(string[] args)
        {
            Console.Write("First Date: ");
            DateTime FirstDate= DateTime.Parse(Console.ReadLine());
            Console.Write("Second Date: ");
            DateTime SecondDate = DateTime.Parse(Console.ReadLine());
            TimeSpan Difference = SecondDate-FirstDate;
            Console.WriteLine(Difference.Days);
        }
    }

