using System;
namespace Uppgift_3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how old are you? pls write in only nubers.");
            float age = float.Parse(Console.ReadLine());

            if (age >= 16 && age <= 19)
            {
                Console.WriteLine("You may paticipat in the competition");
            }
            if (age <= 16)
            {
                Console.WriteLine("You are to young to enter this competition");
            }
            else
            {
                Console.WriteLine("you are to old to enter this competition");
            }
        }
    }
}