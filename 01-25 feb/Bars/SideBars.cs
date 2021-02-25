using System;

namespace Bars
{
    internal class SideBars
    {

        VerBar v;
        public SideBars(int width, int height)
        {
            
            for (int i = 0; i < height; i++)
            {
                v = new VerBar(1);
                for (int j = 0; j < width; j++)
                {
                    Console.Write(" ");
                }
                v = new VerBar(1);
                Console.WriteLine();
            }
            
        }
    }
}