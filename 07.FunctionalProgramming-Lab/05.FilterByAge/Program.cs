using System;

namespace _05.FilterByAge
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Person[] people = new Person[n];

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                people[i] = new Person();
                people[i].Name = input[0];
                people[i].Age = int.Parse(input[1]);
            }

            var condition = Console.ReadLine();
            var ageCondition = int.Parse(Console.ReadLine());

            Func<Person, bool> filter = AgeCondition(condition, ageCondition);

            Func<Person, string> formatter = Formatter(Console.ReadLine());

            Print(people, filter, formatter);
        }

        static void Print(Person[] people, Func<Person, bool> filter, Func<Person, string> formatter)
        {
            foreach (var person in people)
            {
                if (filter(person))
                {
                    Console.WriteLine(formatter(person));
                }
            }
        }

        static Func<Person, string> Formatter(string format)
        {
            switch (format)
            {
                case "name":
                    return x => $"{x.Name}";
                case "age":
                    return x => $"{x.Age}";
                case "name age":
                    return x => $"{x.Name} - {x.Age}";
                default:
                    return null;
            }
        }

        static Func<Person, bool> AgeCondition(string condition, int ageCondition)
        {
            switch (condition)
            {
                case "younger":
                    return x => x.Age < ageCondition;
                case "older":
                    return x => x.Age >= ageCondition;
                default:
                    return null;
            }
        }
    }
}
