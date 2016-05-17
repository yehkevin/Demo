using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
namespace Demo
{
    public class Calculator
    {
        #region Members
        private static Logger logger = LogManager.GetCurrentClassLogger();
        #endregion

        #region Construction
        public Calculator()
        {
            logger.Info("New Calculator");
        }
        #endregion

        #region Commands
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Divide(double a, double b)
        {
            return a / b;
        }
        #endregion
    }
}
