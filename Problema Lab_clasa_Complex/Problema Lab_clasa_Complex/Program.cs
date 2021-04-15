using System;
using System.Collections.Generic;

namespace Problema_Lab_clasa_Complex
{
    class Program
    {
        static void Main(string[] args)
        {

            Complex c1 = new Complex(5, 7);
            Complex c2 = new Complex(1, 3);
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine($"c1 + c2 = {c1 + c2}");
            Console.WriteLine($"c1 - c2 = {c1 - c2}");
            Console.WriteLine($"c1 * c2 = {c1 * c2}");
            Console.WriteLine($"c1 ^ 2  = {c1 ^ 2}");
            Console.WriteLine($"Forma trigonometrica al lui {c1}:  {c1.TrigonometryForm()}");


            /************************************************************************************/
            /********************    C O M P L E X      D E R I V A T      **********************/
            /************************************************************************************/
            ComplexD cd1 = new ComplexD(6, 9);
            ComplexD cd2 = new ComplexD(2, 10);
            Console.WriteLine(cd1);
            Console.WriteLine(cd2);
            Console.WriteLine($"cd1 + cd2 = {cd1 + cd2}");
            Console.WriteLine($"cd1 - cd2 = {cd1 - cd2}");
            Console.WriteLine($"cd1 * cd2 = {cd1 * cd2}");
            Console.WriteLine($"cd1 ^ 2  = {cd1 ^ 2}");
            Console.WriteLine($"cd1.Power(2)  = {cd1.Power(2)}");
            Random rnd = new Random();
            List<Complex> complexes = new List<Complex>();
            for (int i = 0; i < rnd.Next(10, 100); i++)
            {
                complexes.Add(new Complex(rnd.Next(10,100), rnd.Next(20,100)));
                Console.Write($"{i}. complex number from the set: ");
                Console.WriteLine(complexes[i]);
            }
            double distance = cd1.Distance(complexes);
            Console.WriteLine($"The distance from cd1 to random complex number set = {distance}");
            Console.WriteLine($"Forma trigonometrica al lui {cd1}:  {cd1.TrigonometryForm()}");
        }
    }
}
