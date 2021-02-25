using System;
namespace Bars
{
    public class HorBar
    {
        public HorBar(int length)
        {
            Console.Write("+");
            for (int i = 0; i < length; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.WriteLine();
        }
    }
}