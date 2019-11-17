using System;
using System.Timers;

namespace CSharp_Lambdas
{

    internal class MathServices
    {

        internal event EventHandler<MathPerformedEventArgs> MathPerformed;

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
            MathPerformed?.Invoke(this, new MathPerformedEventArgs(result));
        }

        internal void AddNum(double value1, double value2)
        {
            Timer timer2 = new Timer(5000);

            double result = value1 + value2;

            MathPerformed?.Invoke(this, new MathPerformedEventArgs(result));
        }

    }


}
