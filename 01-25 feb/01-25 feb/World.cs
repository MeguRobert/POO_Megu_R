using System;

namespace _01_25_feb
{
    class World
    {
         private int id;
         private static int counter = 0;

        public static int Counter {

            get
            {
                return counter;
            }
        }

        public World(int id)
         {
            this.id = id;
            counter++;
         }
        public void SayHello()
        {
            Console.WriteLine($"HELLO from {id}");
        }
    }
}