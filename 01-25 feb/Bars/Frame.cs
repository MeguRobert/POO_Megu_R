using System;

namespace Bars
{
    internal class Frame
    {
        HorBar h1, h2;
        SideBars s;

        public Frame(int width, int height)
        {
            h1 = new HorBar(width);
            s = new SideBars(width, height);
            h2 = new HorBar(width);
        }
    }
}