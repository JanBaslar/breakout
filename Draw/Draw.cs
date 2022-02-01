using System;

namespace BreakoutLibrary
{
    public class Draw
    {

        public static void All (Ball ball, Bricks bricks, Paddle paddle, int width, int height)
        {
            Score(ball);
            Lives(ball, width);
            Bricks(bricks, ball);
            Ball(ball);
            Paddle(paddle, height);
        }

        static void Paddle(Paddle paddle, int height)
        {

            if (paddle.position < paddle.previousPosition)
            {
                Console.SetCursorPosition(paddle.previousPosition + 4, height - 1);
                Console.Write(' ');
            }

            else if (paddle.position > paddle.previousPosition)
            {
                Console.SetCursorPosition(paddle.previousPosition, height - 1);
                Console.Write(' ');
            }

            Console.SetCursorPosition(paddle.position, height - 1);
            Console.Write("▀▀▀▀▀");
            Console.SetCursorPosition(0, 0);
        }


        static void Ball(Ball ball)
        {
            Console.SetCursorPosition(ball.xPrevious, ball.yPrevious);
            Console.Write(' ');

            Console.SetCursorPosition(ball.x, ball.y);
            Console.Write('■');
        }


        static void Bricks(Bricks bricks, Ball ball)
        {
            ConsoleColor[,] colors = {  { ConsoleColor.Red, ConsoleColor.DarkRed },
                                        { ConsoleColor.Blue, ConsoleColor.DarkBlue },
                                        { ConsoleColor.Green, ConsoleColor.DarkGreen } };

            for (int y = 0; y < 6; y++)
            {
                for (int x = 0; x < bricks.lineLength; x++)
                {
                    if (!(ball.x / 5 == x && ball.y - 5 == y))
                    {
                        Console.SetCursorPosition(x * 5, y + 5);
                        switch (bricks.matrix[y, x] + bricks.previousMatrix[y, x])
                        {
                            case 0:
                                Console.Write("     ");
                                break;

                            case 1:
                                Console.ForegroundColor = colors[y % 3, x % 2];
                                Console.Write("░░░░░");
                                break;

                            case 2:
                                Console.ForegroundColor = colors[y % 3, x % 2];
                                Console.Write("█████");
                                break;
                        }
                    }
                }
            Console.ForegroundColor = ConsoleColor.White;
            }
        }


        static  void Digit (char digit)
        {
            if (digit == '0')
            {
                Console.Write("▄▄▄▄▄"); Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop + 1);
                Console.Write("█   █"); Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop + 1);
                Console.Write("█   █"); Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop + 1);
                Console.Write("█   █"); Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop + 1);
                Console.Write("▀▀▀▀▀");
            }

            else if (digit == '1')
            {
                Console.Write("    ▄"); Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop + 1);
                Console.Write("    █"); Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop + 1);
                Console.Write("    █"); Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop + 1);
                Console.Write("    █"); Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop + 1);
                Console.Write("    ▀");
            }

            else if (digit == '2')
            {
                Console.Write("▄▄▄▄▄"); Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop + 1);
                Console.Write("    █"); Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop + 1);
                Console.Write("█▀▀▀▀"); Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop + 1);
                Console.Write("█    "); Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop + 1);
                Console.Write("▀▀▀▀▀");
            }

            else if (digit == '3')
            {
                Console.Write("▄▄▄▄▄"); Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop + 1);
                Console.Write("    █"); Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop + 1);
                Console.Write("▀▀▀▀█"); Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop + 1);
                Console.Write("    █"); Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop + 1);
                Console.Write("▀▀▀▀▀");
            }

            else if (digit == '4')
            {
                Console.Write("▄   ▄"); Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop + 1);
                Console.Write("█   █"); Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop + 1);
                Console.Write("▀▀▀▀█"); Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop + 1);
                Console.Write("    █"); Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop + 1);
                Console.Write("    ▀");
            }

            else if (digit == '5')
            {
                Console.Write("▄▄▄▄▄"); Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop + 1);
                Console.Write("█    "); Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop + 1);
                Console.Write("▀▀▀▀█"); Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop + 1);
                Console.Write("    █"); Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop + 1);
                Console.Write("▀▀▀▀▀");
            }

            else if (digit == '6')
            {
                Console.Write("▄▄▄▄▄"); Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop + 1);
                Console.Write("█    "); Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop + 1);
                Console.Write("█▀▀▀█"); Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop + 1);
                Console.Write("█   █"); Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop + 1);
                Console.Write("▀▀▀▀▀");
            }

            else if (digit == '7')
            {
                Console.Write("▄▄▄▄▄"); Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop + 1);
                Console.Write("    █"); Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop + 1);
                Console.Write("    █"); Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop + 1);
                Console.Write("    █"); Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop + 1);
                Console.Write("    ▀");
            }

            else if (digit == '8')
            {
                Console.Write("▄▄▄▄▄"); Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop + 1);
                Console.Write("█   █"); Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop + 1);
                Console.Write("█▀▀▀█"); Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop + 1);
                Console.Write("█   █"); Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop + 1);
                Console.Write("▀▀▀▀▀");
            }

            else if (digit == '9')
            {
                Console.Write("▄▄▄▄▄"); Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop + 1);
                Console.Write("█   █"); Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop + 1);
                Console.Write("▀▀▀▀█"); Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop + 1);
                Console.Write("    █"); Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop + 1);
                Console.Write("▀▀▀▀▀");
            }
        }

        static void Score(Ball ball)
        {
            string score = ball.score.ToString();

            if (score.Length == 1)
                score = '0' + score;

            Console.SetCursorPosition(1, 0);
            foreach (char digit in score)
            {
                Digit(digit);
                Console.SetCursorPosition(7, 0);
            }
        }


        static void Lives(Ball ball, int width)
        {
            Console.SetCursorPosition(width - 6, 0);
            Digit(ball.lives.ToString()[0]);
        }


        public static void GameOver(int width, int height, bool won)
        {
            Console.SetCursorPosition(width / 2 - 19, height / 2 - 1);

            if (won)
            {
                Console.Write("   ▄ ▄  ▄▄  ▄ ▄   ▄   ▄  ▄▄  ▄   ▄    "); Console.SetCursorPosition(width / 2 - 19, Console.CursorTop + 1);
                Console.Write("   █ █ █  █ █ █   █ ▄ █ █  █ █▀▄ █    "); Console.SetCursorPosition(width / 2 - 19, Console.CursorTop + 1);
                Console.Write("    █  ▀▄▄▀ █▄█   ▀▄▀▄▀ ▀▄▄▀ █  ▀█    ");
            }

            else
            {
                Console.Write(" ▄▄▄  ▄  ▄   ▄ ▄▄▄    ▄▄  ▄ ▄ ▄▄▄ ▄▄▄ "); Console.SetCursorPosition(width / 2 - 19, Console.CursorTop + 1);
                Console.Write("█ ▄▄ █▄█ █▀▄▀█ █▄▄   █  █ █ █ █▄▄ █▄▄▀"); Console.SetCursorPosition(width / 2 - 19, Console.CursorTop + 1);
                Console.Write("▀▄▄▀ █ █ █   █ █▄▄   ▀▄▄▀ ▀▄▀ █▄▄ █ ▀▄");
            }
        }
        

        public static void WelcomeScreen(int width)
        {
            Console.SetCursorPosition(width / 2 - 20, 5);
            Console.Write("▄▄▄  ▄▄▄  ▄▄▄▄  ▄▄  ▄  ▄  ▄▄  ▄  ▄ ▄▄▄▄▄"); Console.SetCursorPosition(width / 2 - 20, Console.CursorTop + 1);
            Console.Write("█▀▀█ █▀▀█ █▀▀▀ █▀▀█ █ ▄▀ █▀▀█ █  █ ▀▀█▀▀"); Console.SetCursorPosition(width / 2 - 20, Console.CursorTop + 1);
            Console.Write("█▄▄▀ █▄▄▀ █▄▄  █▄▄█ █▄▀  █  █ █  █   █  "); Console.SetCursorPosition(width / 2 - 20, Console.CursorTop + 1);
            Console.Write("█▀▀▄ █▀▄  █▀▀  █▀▀█ █▀▄  █  █ █  █   █  "); Console.SetCursorPosition(width / 2 - 20, Console.CursorTop + 1);
            Console.Write("█▄▄█ █ ▀▄ █▄▄▄ █  █ █ ▀▄ █▄▄█ █▄▄█   █  "); Console.SetCursorPosition(width / 2 - 20, Console.CursorTop + 1);
            Console.Write("▀▀▀  ▀  ▀ ▀▀▀▀ ▀  ▀ ▀  ▀  ▀▀   ▀▀    ▀  "); Console.SetCursorPosition(width / 2 - 20, Console.CursorTop + 3);

            Console.Write("           >> INSERT  COIN <<           "); Console.SetCursorPosition(width / 2 - 20, Console.CursorTop + 2);

            Console.Write("      >> USE ARROW KEYS TO MOVE <<      "); Console.SetCursorPosition(width / 2 - 20, Console.CursorTop + 5);

            Console.Write("      Press any key to continue...      ");
        }


        public static void PlayAgain(int width)
        {
            Console.SetCursorPosition(width / 2 - 20, 10);
            Console.Write("      Press >> R << to play again       "); Console.SetCursorPosition(width / 2 - 20, Console.CursorTop + 2);
            Console.Write("        Press >> Q << to quit...        ");
        }
    }
}
