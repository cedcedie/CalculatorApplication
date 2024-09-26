using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    public delegate T Formula<T>(T input1, T input2);

    public class CalculatorClass
    {

        public Formula<double> formula;
        public double GetSum(double input1, double input2)
        {
            return input1 + input2;
        }

        public double GetDifference(double input1, double input2)
        {
            return input1 - input2;
        }
        public double GetQuotient(double input1, double input2)
        {
            if (input2 == 0)
            {
                return 0;
            }
            return input1 / input2;
        }


        public double GetProduct(double input1, double input2)
        {
            return input1 * input2;
        }

     
        private Formula<double> Calculate;

        public event Formula<double> CalculateEvent
        {
            add
            {
                Calculate += value;
                Console.WriteLine("Added the Delegate");
            }

            remove
            {
                Calculate -= value;
                Console.WriteLine("Removed the Delegate");
            }
        }
    }
}