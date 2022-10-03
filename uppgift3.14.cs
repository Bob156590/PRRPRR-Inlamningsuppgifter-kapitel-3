using System;
namespace Uppgift_3._14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to n/a company.\n\nWe are searching for an employe who fits what we're looking for." +
                "\nSo pls answer these following quations.\n\nHave you graduated high school? pls answer in y or n.");
            string awe = Console.ReadLine();
            Console.WriteLine("How old are you");
            float age = float.Parse(Console.ReadLine());

            if (age <= 22 && awe.ToLower() == "y")
            {
                Console.WriteLine("We would like to hire you.");
            }

            else
            {
                Console.WriteLine("Sry but we're searching for someone else.");
            }
        }
    }
}
