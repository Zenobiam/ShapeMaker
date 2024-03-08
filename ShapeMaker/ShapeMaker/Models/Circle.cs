using ShapeMaker.BaseModels;
using System.ComponentModel.DataAnnotations;

namespace ShapeMaker.Models
{
    public class Circle : IShape
    {
        [Range(0.0, Double.MaxValue, ErrorMessage = "The field {0} must be greater than {1}.")]
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