using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Figures
{
    public interface IBaseFigure
    {
        public decimal CalculateArea();
        protected void EvaluateInputArguments(decimal[] args) { }
    }
}
