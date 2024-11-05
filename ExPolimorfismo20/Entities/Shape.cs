
using ExPolimorfismo20.Entities.Enums;

namespace ExPolimorfismo20.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
