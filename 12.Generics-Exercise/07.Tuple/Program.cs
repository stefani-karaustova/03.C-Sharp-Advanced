using System;

namespace _07.Tuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] firstData = Console.ReadLine().Split();
            var fullName = $"{firstData[0]} {firstData[1]}";

            Tuple<string, string> firstTuple = new Tuple<string, string>(fullName, firstData[2]);

            string[] secondData = Console.ReadLine().Split();

            Tuple<string, int> secondTuple = new Tuple<string, int>
            (secondData[0], int.Parse(secondData[1]));

            string[] thirdData = Console.ReadLine().Split();

            Tuple<int, double> thirdTuple = new Tuple<int, double>(int.Parse(thirdData[0]),
                double.Parse(thirdData[1]));

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }
    }
}
