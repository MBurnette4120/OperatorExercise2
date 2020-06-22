using System;

namespace OperatorsExercise2
{
    class Program
    {

        static void Main(string[] args)
        {
            //var firstNum = 17;
            //var secondNum = 4;
            //var quotient = firstNum / secondNum;
            //var remainder = firstNum % secondNum;

            //Console.WriteLine($"{firstNum} / {secondNum} equals {quotient} remainder {remainder}");
            //Console.WriteLine($"The remainder is {remainder}");

            Console.WriteLine($"Please enter a radius to calculate area of a circle:");

            var userInput = Console.ReadLine();

            var radius = double.Parse(userInput);

            var area = AreaOfCircle(radius);

            Console.WriteLine($"{area}");


        }
        public static double AreaOfCircle(double radius)
        {

            return (Math.PI) * (radius* radius);
        }




}
}