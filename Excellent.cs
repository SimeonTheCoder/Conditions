using System;

namespace SoftUni
{
    class Grade
    {
        static void Main(string[] args) {
            double grade = double.Parse(Console.ReadLine());

            if(grade >= 5.50) {
                Console.WriteLine("Excellent!");
            }
        }
    }
}