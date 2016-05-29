using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.RemoveNames
{
    class Problem6
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> names = input.Split(' ').ToList();

            string namesToBeRemoved = Console.ReadLine();
            List<string> equalNames = namesToBeRemoved.Split(' ').ToList();

            // Main Logic
            for (int i = 0; i < equalNames.Count; i++) // The length of this list is constant
            {
                for (int j = 0; j < names.Count; j++)
                {
                    if (names.Contains(equalNames[i]))
                    {
                        names.Remove(equalNames[i]);
                    }
                }
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
