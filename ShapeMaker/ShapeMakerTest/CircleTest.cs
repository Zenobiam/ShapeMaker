using ShapeMaker.Models;
using System.ComponentModel.DataAnnotations;

namespace ShapeMakerTest
{
    public class CircleTest
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 3.141592653589793)]
        [InlineData(10, 314.1592653589793)]
        [InlineData(100, 31415.9265358979323)]        
        public void GetArea_Integer(int radius, double expect)
        {
            var circle = new Circle(radius);
            var area = circle.GetArea();
            Assert.Equal(area, expect);
        }

        [Theory]
        [InlineData(0.7, 1.5393804002589986)]
        [InlineData(19.5, 1194.5906065275188)]
        [InlineData(153.6576, 74175.069837847619043604511382925)]
        public void GetArea_Double(double radius, double expect)
        {
            var circle = new Circle(radius);
            var area = circle.GetArea();
            Assert.Equal(area, expect);
        }
    }
}