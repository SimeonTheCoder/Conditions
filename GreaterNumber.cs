using System;

namespace SoftUni
{
    class Grade
    {
        static void Main(string[] args)
        {
            int numA = int.Parse(Console.ReadLine());
            int numB = int.Parse(Console.ReadLine());

            if(numA > numB)
            {
                Console.WriteLine(numA);
            }
            else
            {
                Console.WriteLine(numB);
            }
        }
    }
}