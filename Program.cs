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

            mathServe.CalculateNumbers(3,4, (value1,value2) =>
            {
                 return value1*value2; 
                 //value1 * value2;
            });

            mathServe.CalculateNumbers(3,4,AddNum); //alternative; notice we don't actually need the return statement

    
        }

        public static double AddNum(double value1, double value2)
        {
            return value1 + value2;
        }

        
    }
}
