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
            FindMaximum findmaximum = new FindMaximum();
            int intmax = findmaximum.GetMaxOfThree(96,45,76);
            Console.WriteLine("Maximum of three integers is : " + intmax);
            Console.ReadLine();
        }
    }
}
