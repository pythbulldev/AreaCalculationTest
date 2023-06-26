using AreaCalculator.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AreaCalculator.Tests.FiguresTests
{
    public class TriangleTests
    {
        [Fact]
        public void Triangle_IsRight_ReturnBool()
        {
            var triangle = new Triangle(new decimal[] { 3m, 4m, 5m });

            Assert.True(triangle.IsRight());
        }

        [Fact]
        public void Triangle_CalculateArea_ReturnDecimal()
        {
            decimal[] sides = new decimal[3] { 3m, 4m, 5m };
            var triangle = new Triangle(sides);
            decimal halfSidesSum = sides.Sum() / 2m;
            var expectedErea = (decimal)Math.Sqrt((double)(halfSidesSum * (halfSidesSum - sides[0]) * (halfSidesSum - sides[1]) * (halfSidesSum - sides[2])));

            var area = triangle.CalculateArea();

            Assert.Equal(expectedErea, area);
        }
        [Fact]
        public void Triangle_Constructor_ReturnError()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                new Triangle(new decimal[3] { -1m,-2m,3m });
            });
            Assert.Throws<ArgumentException>(() =>
            {
                new Triangle(new decimal[2] { 1m, 2m });
            });
            Assert.Throws<ArgumentException>(() =>
            {
                new Triangle(new decimal[3] { 1m, 1m, 3m });
            });
        }
    }
}
