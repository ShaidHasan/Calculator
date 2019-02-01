using System;
using System.Collections.Generic;
using System.Text;

namespace AdvanceCalculator
{
    public static class SimpleCalculator
    {
        public static double Calculate(double value1, double value2, string mathOperator)
        {
            double result = 0;

            switch (mathOperator)
            {
                case "÷":
                    result = Math.Round((Double)(value1 / value2), 4);
                    break;
                case "x":
                    result = value1 * value2;
                    break;
                case "+":
                    result = value1 + value2;
                    break;
                case "-":
                    result = value1 - value2;
                    break;
            }

            return result;
        }
    }
}
