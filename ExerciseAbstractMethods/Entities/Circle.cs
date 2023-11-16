using System;
using System.Text.RegularExpressions;
using ExerciseAbstractMethods.Entities.Enum;

namespace ExerciseAbstractMethods.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; protected set; }

        //Construtores
        public Circle()
        {
        }

        public Circle(Color color, double radius) : base(color)
        {
            Radius = radius;
        }

        //Sobreposição da classe abstract
        public override double Area()
        {
            return 3.14 * Math.Pow(Radius, 2);
        }
    }
}
