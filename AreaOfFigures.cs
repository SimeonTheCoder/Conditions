using System;

namespace SoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if(type == "square")
            {
                double side = double.Parse(Console.ReadLine());

                double area = side * side;

                Console.WriteLine(string.Format("{0:0.000}", area));
            }
            else if(type == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());

                double area = sideA* sideB;

                Console.WriteLine(string.Format("{0:0.000}", area));
            }
            else if(type == "circle")
            {
                double radius = double.Parse(Console.ReadLine());

                double area = radius * radius * Math.PI;

                Console.WriteLine(string.Format("{0:0.000}", area));
            }
            else if(type == "triangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());

                double area = sideA * sideB / 2.0;

                Console.WriteLine(string.Format("{0:0.000}", area));
            }
        }
    }
}