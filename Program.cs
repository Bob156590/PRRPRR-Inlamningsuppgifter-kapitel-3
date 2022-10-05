using System;

namespace upgift_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to C# simple calcualter. Pls write two numbers one after the other. Remember to press enter after each number.");
            float n1 = float.Parse(Console.ReadLine());
            float n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Now choose one of the options bellow.\n1.Addition\n2.Subtraktion\n3.Multiplikation\n4.Division");
            int l = int.Parse(Console.ReadLine());


            switch (l)
            {
                case 1:
                    Console.WriteLine($"\n That comes to {n1 + n2}");
                    break;
                case 2:
                    Console.WriteLine($"\n That comes to {n1 - n2}");
                    break;
                case 3:
                    Console.WriteLine($"\n That comes to {n1 * n2}");
                    break;
                case 4:
                    Console.WriteLine($"\n That comes to {n1 / n2}");
                    break;
                default:
                    break;
            }
        }
    }
}