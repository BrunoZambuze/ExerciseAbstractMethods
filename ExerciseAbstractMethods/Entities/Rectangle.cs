using System;
using ExerciseAbstractMethods.Entities.Enum;
namespace ExerciseAbstractMethods.Entities
{
    internal class Rectangle : Shape
    {
        public double Width { get; protected set; }
        public double Height { get; protected set; }

        //Construtores
        public Rectangle()
        {
        }
        
        public Rectangle(Color color, double width, double height) : base(color)
        {
            Width = width;
            Height = height;
        }

        //Sobreposição da classe asbtract
        public override double Area()
        {
            return Width * Height;
        }
    }
}
