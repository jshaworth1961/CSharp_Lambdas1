using System;

//we will create an anonymous delegate 

namespace CSharp_Lambdas
{
    class Program
    {
        static void Main()
        {
            MathServices mathServe = new MathServices();

            //mathServe.MathPerformed += OnMathPerformed;
            mathServe.MathPerformed += delegate(object sender, MathPerformedEventArgs e)
            {
                Console.WriteLine($"Calculation Result: {e.Result}");
            }

            mathServe.Operation(5,8);
            
        }

        /*
        static void OnMathPerformed(object sender, MathPerformedEventArgs e)
        {
            Console.WriteLine($"Calculation Result: {e.Result}");
        }
        */
    }
}
