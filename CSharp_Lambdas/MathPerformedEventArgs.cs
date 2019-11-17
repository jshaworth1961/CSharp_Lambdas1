using System;

namespace CSharp_Lambdas
{

    internal class MathPerformedEventArgs : EventArgs
    {
        internal double Result { get; set; }


        //constructor below
        public MathPerformedEventArgs(double result)
        {
            Result = result;
        }

    }

        //constructor
        


}
