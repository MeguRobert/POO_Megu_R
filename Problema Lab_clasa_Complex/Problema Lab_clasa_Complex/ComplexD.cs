using System;
using System.Collections.Generic;

namespace Problema_Lab_clasa_Complex
{
    class ComplexD : Complex
    {

        public ComplexD() : this(0, 0)
        {
        }
        public ComplexD(int parte_reala) : this(parte_reala, 0)
        {
        }
        public ComplexD(int parte_reala, int parte_imaginara)
        {
            a = parte_reala;
            b = parte_imaginara;
        }

        public override string Power(int n)
        {
            string powertrig = $"{Math.Pow(Modul, n):0.###} * (cos {(n * Argument):0.###}° + i sin {(n * Argument):0.###}°)";
            //value:0.### pentru afisare cu 3 zecimale
            return powertrig;
        }

        public double Distance(List<Complex> complexes)
        {
            double min = Distance(this, complexes[0]);
            foreach (Complex complex in complexes)
            {
                double dist = Distance(this,complex);
                Console.WriteLine($"dist : {dist}");
                if (dist < min) min = dist;

            }
            return min;
        }
        private double Distance(Complex complex1, Complex complex2)
        {
            Console.WriteLine($"Complex: { complex1} ,{ complex2}");
            int ca = complex1.A - complex2.A;
            int cb = complex1.B - complex2.B;
            Console.WriteLine($"{ca}, {cb} ");
            return Math.Sqrt(ca * ca + cb * cb);
        }
    }
}
