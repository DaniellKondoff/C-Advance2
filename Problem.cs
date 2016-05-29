using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;



    class Problem
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Regex linkParser = new Regex(@"(?:https?://|www.)\S+\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            foreach (var item in linkParser.Matches(text))
            {
                Console.WriteLine(item);
            }
        }
    }

