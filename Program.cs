using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxUsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Maximum integer
            FindMaximum findmaximum = new FindMaximum();
            int intmax = findmaximum.MaximumInteger(45,58,26);
            Console.WriteLine("Maximum of three integers is : " + intmax);

            //Maximum float
            FindMaximum findMaximum = new FindMaximum();
            float floatmax = findMaximum.MaximumFloat(12.3f, 45.3f, 36.1f);
            Console.WriteLine("Maximum of three floats is : " + floatmax);
            Console.ReadLine();
        }
    }
}
