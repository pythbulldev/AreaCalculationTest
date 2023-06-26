using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Figures
{
    /// <summary>
    /// Triangle model
    /// </summary>
    public sealed class Triangle : IBaseFigure
    {
        public List<decimal> Sides { get; private set; }
        /// <summary>
        /// Constructor also fills sides and validates them
        /// </summary>
        /// <param name="args"></param>
        public Triangle(decimal[] args)
        {
            Sides = args.ToList();
            Sides.Sort();
            EvaluateInputArguments(args);
        }
        /// <summary>
        /// Calculates area of triangle
        /// </summary>
        /// <returns></returns>
        public decimal CalculateArea()
        {
            decimal halfSidesSum = Sides.Sum() / 2m;
            return (decimal)Math.Sqrt((double)(halfSidesSum * (halfSidesSum - Sides[0]) * (halfSidesSum - Sides[1]) * (halfSidesSum - Sides[2])));
        }
        /// <summary>
        /// Checking if triangle is right
        /// </summary>
        /// <returns></returns>
        public bool IsRight()
        {
            return Sides[2] * Sides[2] == Sides[1] * Sides[1] + Sides[0] * Sides[0];
        }
        /// <summary>
        /// Checking if sides are valid
        /// </summary>
        /// <param name="args"></param>
        /// <exception cref="ArgumentException"></exception>
        private void EvaluateInputArguments(decimal[] args)
        {
            if (args.Length != 3)
                throw new ArgumentException("Unexpected number of arguments!");
            if (args.Any(x => x <= 0))
                throw new ArgumentException("Arguments must be positive numbers!");

            if (Sides[2] >= Sides[1] + Sides[0])
                throw new ArgumentException("Arguments can't be sides of a triangle!");
        }
    }
}
