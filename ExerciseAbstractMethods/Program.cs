using ExerciseAbstractMethods.Entities;
using ExerciseAbstractMethods.Entities.Enum;
using System;
namespace ExerciseAbstractMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of shapes:");
            int n = int.Parse(Console.ReadLine());
            List<Shape> ListShape = new List<Shape>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nShape #{i + 1} data:");
                Console.Write("Rectangle or Circle (r/c)?:");
                char resp = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/ Blue/ Red):");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (resp == 'r' || resp == 'R')
                {
                    Console.Write("Width:");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height:");
                    double height = double.Parse(Console.ReadLine());
                    ListShape.Add(new Rectangle(color, width, height));
                }
                else
                {
                    Console.Write("Radius:");
                    double radius = double.Parse(Console.ReadLine());
                    ListShape.Add(new Circle(color, radius));
                }
            }
            Console.WriteLine("\n---SHAPE AREAS---");
            foreach (Shape s in ListShape)
            {
                Console.WriteLine($"Area:{s.Area()}");
            }
        }
    }
}