using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class Problem2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbers= new List<int>();

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                numbers.Add(num);
            }
            numbers.Sort();
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }

