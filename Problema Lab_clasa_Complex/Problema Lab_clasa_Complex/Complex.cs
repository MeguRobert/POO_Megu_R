using System;

namespace Problema_Lab_clasa_Complex
{
    public class Complex
    {

        //Fields
        protected int a;
        protected int b;

        //Constructors:
        public Complex() : this(0, 0)
        {
        }
        public Complex(int parte_reala) : this(parte_reala, 0)
        {
        }
        public Complex(int parte_reala, int parte_imaginara)
        {
            a = parte_reala;
            b = parte_imaginara;
        }

        //Props
        public int A { get; }
        public int B { get; }


        public double Modul
        {
            get
            {
                double r = Math.Sqrt(a * a + b * b);
                return r;
            }
        }
        public double Argument
        {
            get
            {
                double teta = Math.Atan(b / a);
                return teta;
            }
        }
        public Complex Complement
        {
            get
            {
                return new Complex(a, -b);
            }
        }

        //Operators:
        public static Complex operator +(Complex z1, Complex z2)
        {
            int a = z1.a + z2.a;
            int b = z1.b + z2.b;
            return new Complex(a, b);
        }

        public static Complex operator -(Complex z1, Complex z2)
        {
            int a = z1.a - z2.a;
            int b = z1.b - z2.b;
            return new Complex(a, b);
        }


        public static Complex operator *(Complex z1, Complex z2)
        {
            int a = z1.a * z2.a + z1.b * z2.b;
            int b = z1.a * z2.b + z1.b * z2.a;
            return new Complex(a, b);
        }

        public static Complex operator ^(Complex z1, int n)
        {
            Complex complex = z1;
            for (int i = 0; i < n; i++)
            {
                complex *= z1;
            }
            return complex;
        }

        //Method

        public virtual string Power(int n)
        {
            Complex complex = this;
            for (int i = 0; i < n; i++)
            {
                complex *= this;
            }
            return complex.ToString();
        }


        public string TrigonometryForm()
        {
            string trig = $"{Modul:0.###} * (cos {Argument:0.###}° + i sin {Argument:0.###}°)";
            //value:0.### pentru afisare cu 3 zecimale

            return trig;
        }
        public virtual string PowerInTrigonometryForm(int n)
        {
            string powertrig = $"{Math.Pow(Modul, n):0.###} * (cos {(n * Argument):0.###}° + i sin {(n * Argument):0.###}°)";
            //value:0.### pentru afisare cu 3 zecimale
            return powertrig;
        }




        //Write
        public override string ToString()
        {
            string s = "";
            if (a == 0 && b == 0)
                s = "0";
            else if (a == 0)
                s = "(" + b.ToString() + "i" + ")";
            else if (b == 0)
                s = "(" + a.ToString() + ")";
            else if (b < 0)
                s = "(" + a.ToString() + b.ToString() + "i" + ")";
            else s = "(" + a.ToString() + "+" + b.ToString() + "i" + ")";
            return s;
        }


    }
}