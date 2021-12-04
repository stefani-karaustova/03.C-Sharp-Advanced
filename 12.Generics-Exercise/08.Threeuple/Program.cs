using System;

namespace _08.Threeuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstData = Console.ReadLine().Split();

            var fullName = $"{firstData[0]} {firstData[1]}";
            var town = string.Empty;

            if (firstData.Length > 4)
            {
                town = $"{firstData[3]} {firstData[4]}";
            }
            else
            {
                town = firstData[3];
            }

            Threeuple<string, string, string> firstThreeuple = new Threeuple<string, string, string>(fullName, firstData[2], town);

            string[] secondData = Console.ReadLine().Split();
            var isDrunk = secondData[2] == "drunk" ? true : false;

            Threeuple<string, int, bool> secondThreeuple = new Threeuple<string, int, bool>
            (secondData[0], int.Parse(secondData[1]), isDrunk);

            string[] thirdData = Console.ReadLine().Split();

            Threeuple<string, double, string> thirdThreeuple = new Threeuple<string, double, string>(thirdData[0], double.Parse(thirdData[1]), thirdData[2]);

            Console.WriteLine(firstThreeuple);
            Console.WriteLine(secondThreeuple);
            Console.WriteLine(thirdThreeuple);
        }
    }
}
