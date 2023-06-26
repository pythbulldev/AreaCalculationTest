using AreaCalculator.Figures;
using System.Reflection;

namespace AreaCalculator
{
    /// <summary>
    /// Class contains methods do calculate Area of figures
    /// </summary>
    public static class AreaCalculation
    {
        /// <summary>
        /// Calculates area by type and sides.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static decimal CalculateArea(Type type, decimal[] args)
        {
            if(type == null)
                throw new ArgumentNullException("type"); 

             var figure = type.GetConstructor(new Type[] { typeof(decimal[]) })?.Invoke(new object[] { args});

            return (figure as IBaseFigure).CalculateArea();
        }
    }
}
