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
            //Maximum integer(UC1)
            FindMaximum findMaximum1 = new FindMaximum();
            int intmax = findMaximum1.MaximumInteger(45,58,26);
            Console.WriteLine("Maximum of three integers is : " + intmax);

            //Maximum float(UC2)
            FindMaximum findMaximum2 = new FindMaximum();
            float floatmax = findMaximum2.MaximumFloat(12.3f, 45.3f, 36.1f);
            Console.WriteLine("Maximum of three floats is : " + floatmax);

            //Maximum string(UC3)
            FindMaximum findMaximum3 = new FindMaximum();
            string stringmax = findMaximum3.MaximumString("Orange","Apple","Mango");
            Console.WriteLine("Maximum of three strings is : " + stringmax);
            Console.ReadLine();
        }
    }
}
