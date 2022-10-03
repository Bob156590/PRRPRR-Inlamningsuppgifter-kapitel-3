using System;
namespace Uppgift_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to our rental company, how long will you be renting our car for?\nPls remeber that the maximum you can pay is SEK 950.");
            float time = float.Parse(Console.ReadLine());
            float cost = (time * 80);

            if (cost <= 950)
            {
                Console.WriteLine($"That come to {cost}kr.");
            }

            else
            {
                Console.WriteLine("apologise but that would cost more then 950kr");
            }
            Console.ReadKey();
        }
    }
}
