using AreaCalculator.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AreaCalculator.Tests.FiguresTests
{
    public class CircleTests
    {
        [Fact]
        public void Circle_CalculateArea_ReturnDecimal()
        {
            decimal radius = 4m;
            var circle = new Circle(new decimal[1] { radius });

            var area = circle.CalculateArea();

            Assert.Equal(2m * (decimal)Math.PI * radius * radius, area);
        }
        [Fact]
        public void Circle_Constructor_ReturnError()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                new Circle(new decimal[1] { -1m });
            });
            Assert.Throws<ArgumentException>(() =>
            {
                new Circle(new decimal[2] { 1m, 2m });
            });
        }
    }
}
