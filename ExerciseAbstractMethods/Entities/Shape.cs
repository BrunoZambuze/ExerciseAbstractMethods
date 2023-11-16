using System;
using ExerciseAbstractMethods.Entities.Enum;

namespace ExerciseAbstractMethods.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        //Construtores
        public Shape()
        {
        }

        public Shape(Color color)
        {
            Color = color;
        }

        //Função para calcular a area
        public abstract double Area();
    }
}
