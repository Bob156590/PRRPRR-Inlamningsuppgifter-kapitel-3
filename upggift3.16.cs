using System;
namespace Uppgift_3._16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the redio station song request. Pls write how long the song is, first in minutes and then seconds.");
            float min = float.Parse(Console.ReadLine());
            float sec = float.Parse(Console.ReadLine());
            float min2 = (min * 60);
            float song = (min2 + sec);


            if (song >= 225 && song <= 260)
            {
                Console.WriteLine("your song may be played on the radio station.");
            }

            else
            {
                Console.WriteLine("your song can not be played on the radio station becaus it's too long.");
            }
            Console.ReadKey();
        }
    }
}
