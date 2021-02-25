namespace Bars
{
    internal class Ladder
    {
        public Ladder(int level, int widht, int stairDistance)
        {

            HorBar hor;
            SideBars sideBars;
            for (int i = 0; i < level; i++)
            {
                hor = new HorBar(widht);
                sideBars = new SideBars(widht, stairDistance);
            }
        }
    }
}