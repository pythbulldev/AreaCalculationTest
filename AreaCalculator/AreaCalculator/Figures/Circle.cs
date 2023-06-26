namespace AreaCalculator.Figures
{
    /// <summary>
    /// Circle model
    /// </summary>
    public sealed class Circle : IBaseFigure
    {
        public decimal Radius { get; private set; }
        /// <summary>
        /// Constructor also fills radius and validates it
        /// </summary>
        /// <param name="args"></param>
        public Circle(decimal[] args)
        {
            Radius = args[0];
            EvaluateInputArguments(args);
        }
        /// <summary>
        /// Calculates area of a circle
        /// </summary>
        /// <returns></returns>
        public decimal CalculateArea()
        {
            return 2m * (decimal)Math.PI * Radius * Radius;
        }
        /// <summary>
        /// Validates the radious
        /// </summary>
        /// <param name="args"></param>
        /// <exception cref="ArgumentException"></exception>
        private void EvaluateInputArguments(decimal[] args)
        {
            if (args.Length != 1)
                throw new ArgumentException("Unexpected number of arguments!");
            if (args[0] <= 0)
                throw new ArgumentException("Argument must be a positive number!");
        }
    }
}
