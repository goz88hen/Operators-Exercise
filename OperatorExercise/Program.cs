using System.Formats.Asn1;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //------Exercise 1-------------

            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a % b;

            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");

            Console.WriteLine("Please eneter the radius of your circle?");
            var userInput = Console.ReadLine();
            var radius = double.Parse(userInput);
            Console.WriteLine(AreaOfCircle(radius));
        }
        //-----Exercise 2---------
        public static double AreaOfCircle(double radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);

            return Math.Sqrt(area);
        }

    }

}

        
      

    

         
            
    

