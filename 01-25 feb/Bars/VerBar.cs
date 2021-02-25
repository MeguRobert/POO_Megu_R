using System;

namespace Bars
{
    internal class VerBar
    {
        private int height;

        public VerBar(int height)
        {
            this.height = height;
            for (int i = 0; i < height; i++)
            {
                Console.Write("|");
            }
           
        }
    }
}