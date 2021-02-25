using System;

namespace _01_25_feb
{
    class World
    {
        private int id;
         public World(int id)
         {
            this.id = id;
         }
        public void SayHello()
        {
            Console.WriteLine($"HELLO from {id}");
        }
    }
}