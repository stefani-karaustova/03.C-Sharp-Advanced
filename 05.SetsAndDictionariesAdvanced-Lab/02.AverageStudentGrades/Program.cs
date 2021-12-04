using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            var average = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < input; i++)
            {
                var line = Console.ReadLine().Split();
                var name = line[0];
                var grade = decimal.Parse(line[1]);

                if (!average.ContainsKey(name))
                {
                    average.Add(name, new List<decimal>());
                }

                average[name].Add(grade);
            }

            foreach (var student in average)
            {
                Console.Write($"{student.Key} -> ");

                foreach (var grade in student.Value)
                {
                    Console.Write($"{grade:f2} ");
                }

                Console.WriteLine($"(avg: {student.Value.Average():f2})");
            }
        }
    }
}
