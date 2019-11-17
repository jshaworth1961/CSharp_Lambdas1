using System;

//we will create an anonymous delegate 

namespace CSharp_Lambdas
{
    class Program
    {
        static void Main()
        {
            MathServices mathServe = new MathServices();

            mathServe.MathPerformed += (result) =>
            {
                Console.WriteLine($"Calculation result: {result}");
            };

            mathServe.Operation(3,4);

          
            
        }

        
    }
}
