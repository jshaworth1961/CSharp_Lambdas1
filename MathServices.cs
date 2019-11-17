using System;
using System.Timers;

namespace CSharp_Lambdas
{

    internal class MathServices
    {

        
        internal delegate void MathPerformedEventHandler(double result); //custom delegate

        internal delegate double CalculationHandler(double value1, double value2);

        internal event MathPerformedEventHandler MathPerformed;

        

        internal MathServices()
        {
            
           
        }

        //with the method below implementation details can be assigned later to the delegate
        internal void CalculateNumbers(double value1, double value2, CalculationHandler calc)
        {
            Timer timer = new Timer(5000);
        
            MathPerformed?.Invoke(calc(value1, value2));
        }

        
    }


}
