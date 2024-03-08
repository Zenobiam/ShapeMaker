using ShapeMaker.BaseModels;

namespace ShapeMaker.Models
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double GetArea()
        {
           return Math.PI * Radius *Radius;
        }
    }
}