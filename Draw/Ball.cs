using System;

namespace BreakoutLibrary
{
    public class Ball
    {
        public int x;
        public int y;

        public Ball(int width, int heigth)
        {
            x = width / 2;
            y = 15;
        }

        public int xPrevious = 0;
        public int yPrevious = 0;

        int xDirection = Randomness.RandomDirection();
        int yDirection = Randomness.RandomDirection();

        public int score = 0;
        public int lives = 3;

        public void Move(int width)
        {
            xPrevious = x;
            yPrevious = y;

            x += xDirection;
            y += yDirection;

            if (x < 0)
                x = 0;

            else if (x > width - 1)
                x = width - 1;

            else if (y < 5)
                y = 5;
        }


        public void JumpToStart(int width)
        {
            xPrevious = x;
            yPrevious = y;
            x = width / 2;
            y = 15;
            xDirection = Randomness.RandomDirection();
            yDirection = Randomness.RandomDirection();
        }


        public void Bounce(int width, int height, Paddle paddle, Bricks bricks)
        {
            bricks.previousMatrix = bricks.matrix.Clone() as int[,];

            if (y == height - 2 && paddle.position - 1 <= x + xDirection 
                && x + xDirection <= paddle.position + 5)
            {
                Console.Beep(440, 50);
                xDirection = Randomness.RandomDirection();
                yDirection = - yDirection;
            }

            if (x <= 0 || x >= width - 1)
            {
                Console.Beep(440, 50);
                xDirection = -xDirection;
            }

            if (y <= 5 || y >= height - 1)
            {
                Console.Beep(440, 50);
                yDirection = -yDirection;
            }

            if (4 < y && y < 12 && x < width)
                BreakBrick(bricks);
        }

        void BreakBrick(Bricks bricks)
        {
            // Zdola
            if (5 < y)
                if (bricks.matrix[y - 6, x / 5] == 1 && yDirection == -1)
                {
                    Console.Beep(220, 40);
                    yDirection = -yDirection;
                    bricks.matrix[y - 6, x / 5] = 0;
                    score++;
                }

            // Zespoda
            if (y < 10)
                if (bricks.matrix[y - 4, x / 5] == 1 && yDirection == 1)
                {
                    Console.Beep(220, 40);
                    yDirection = -yDirection;
                    bricks.matrix[y - 4, x / 5] = 0;
                    score++;
                }

            // Zprava
            if (x % 5 == 0 && x / 5 > 0 && xDirection == -1)
            {
                // Zboku
                if (4 < y && y < 10 && bricks.matrix[y - 5, x / 5 - 1] == 1)
                {
                    Console.Beep(220, 40);
                    xDirection = -xDirection;
                    bricks.matrix[y - 5, x / 5 - 1] = 0;
                    score++;
                }

                // Horni roh
                else if (5 < y && bricks.matrix[y - 6, x / 5 - 1] == 1 &&
                        bricks.matrix[y - 6, x / 5] == 0 && yDirection == -1)
                {
                    Console.Beep(220, 40);
                    xDirection = -xDirection;
                    yDirection = -yDirection;
                    bricks.matrix[y - 6, x / 5 - 1] = 0;
                    score++;
                }

                // Spodni roh
                else if (y < 10 && bricks.matrix[y - 4, x / 5 - 1] == 1 &&
                        bricks.matrix[y - 4, x / 5] == 0 && yDirection == 1)
                {
                    Console.Beep(220, 40);
                    xDirection = -xDirection;
                    yDirection = -yDirection;
                    bricks.matrix[y - 4, x / 5 - 1] = 0;
                    score++;
                }
            }

            // Zleva
            if (x % 5 == 4 && x / 5 < bricks.lineLength && xDirection == 1)
            {
                // Zboku
                if (4 < y && y < 10 && bricks.matrix[y - 5, x / 5 + 1] == 1)
                {
                    Console.Beep(220, 40);
                    xDirection = -xDirection;
                    bricks.matrix[y - 5, x / 5 + 1] = 0;
                    score++;
                }

                // Horni roh
                else if (5 < y && bricks.matrix[y - 6, x / 5 + 1] == 1 &&
                        bricks.matrix[y - 6, x / 5] == 0 && yDirection == -1)
                {
                    Console.Beep(220, 40);
                    xDirection = -xDirection;
                    yDirection = -yDirection;
                    bricks.matrix[y - 6, x / 5 + 1] = 0;
                    score++;
                }

                // Spodni roh
                else if (y < 10 && bricks.matrix[y - 4, x / 5 + 1] == 1 &&
                        bricks.matrix[y - 4, x / 5] == 0 && yDirection == 1)
                {
                    Console.Beep(220, 40);
                    xDirection = -xDirection;
                    yDirection = -yDirection;
                    bricks.matrix[y - 4, x / 5 + 1] = 0;
                    score++;
                }
            }
        }
    }
}
