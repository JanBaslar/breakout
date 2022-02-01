using System;

namespace BreakoutLibrary
{
    public class Paddle
    {
        public int position;

        public Paddle(int width) 
        {
            position = width / 2 - 2;
        }

        public int previousPosition = 0;


        public void Move(int width)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKey key = Console.ReadKey().Key;
                previousPosition = position;

                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        if (position > 0)
                            position--;
                            break;

                    case ConsoleKey.RightArrow:
                        if (position < width - 5)
                            position++;
                            break;
                }
            }
        }
    }
}
