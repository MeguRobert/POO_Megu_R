using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_25_feb
{
    class Program
    {
        static void Main(string[] args)
        {
            World w1 = new World(1); 
            w1.SayHello();

            World w2 = new World(2);
            w2.SayHello();
            
            Console.WriteLine(World.Counter);
        }
    }
}
