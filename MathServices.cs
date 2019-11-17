using System;
using System.Timers;

namespace CSharp_Lambdas
{

    internal class MathServices
    {

        
        internal delegate void MathPerformedEventHandler(double result); //custom delegate

        internal event MathPerformedEventHandler MathPerformed;

        internal delegate void OperationHandler(double value1, double value2);

        internal OperationHandler Operation;

        internal MathServices()
        {
            Operation += AddNum;
            Operation += MultNum;
        }


        internal void MultNum(double value1, double value2)
        {
            Timer timer = new Timer(5000);
            
            double result = value1*value2;
            //MathPerformed?.Invoke(this, new MathPerformedEventArgs(result));
            MathPerformed?.Invoke(result);
        }

        internal void AddNum(double value1, double value2)
        {
            Timer timer2 = new Timer(5000);

            double result = value1 + value2;

            //MathPerformed?.Invoke(this, new MathPerformedEventArgs(result));
            MathPerformed?.Invoke(result);
        }

    }


}
