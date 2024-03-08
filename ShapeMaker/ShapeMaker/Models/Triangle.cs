using ShapeMaker.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMaker.Models
{
    public class Triangle : IShape
    {
        [Range(0.0, Double.MaxValue, ErrorMessage = "The field {0} must be greater than {1}.")]
        public double SideA { get; set; }
        [Range(0.0, Double.MaxValue, ErrorMessage = "The field {0} must be greater than {1}.")]
        public double SideB { get; set; }
        [Range(0.0, Double.MaxValue, ErrorMessage = "The field {0} must be greater than {1}.")]
        public double SideC { get; set; }
        private double SemiPerimeter => (SideA + SideB + SideC) / 2;

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
        }

        public double GetArea()
        {
            return Math.Sqrt(SemiPerimeter
                                         * (SemiPerimeter - SideA)
                                         * (SemiPerimeter - SideB)
                                         * (SemiPerimeter - SideC));
        }

        public bool IsRectangular()
        {
            double a = Math.Pow(SideA, 2);
            double b = Math.Pow(SideB, 2);
            double c = Math.Pow(SideC, 2);

            return CheckSides(a + b, c)
                   || CheckSides(a + c, b)
                   || CheckSides(b + c, a);

        }

        private bool CheckSides(double sumKatet, double hypotenuse)
        {
            return hypotenuse - sumKatet == 0 ? true : false;
        }
    }
}
