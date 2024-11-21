using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Calculator : ISummation
    {
        ILogger Logger { get; }
        public Calculator(ILogger logger)
        {
            Logger = logger;
        }

        public Calculator()
        {

        }
        
        public double ValueSumm(double x, double y)
        {            
            return x + y;
        }

    }
}
