using System;

namespace BreakoutLibrary
{
    public class Bricks
    {
        public int lineLength;
        public int[,] matrix;
        public int[,] previousMatrix;

        public Bricks(int width)
        {
            lineLength = width / 5;
            matrix = new int[6, lineLength];
            previousMatrix = new int[6, lineLength];
        }


        public void FillMatrix(int n)
        {
            for (int y = 0; y < 6; y++)
            {
                for (int x = 0; x < lineLength; x++)
                {
                    matrix[y, x] = n;
                }
            }
            previousMatrix = matrix.Clone() as int[,];
        }

        public bool AreEmpty()
        {
            for (int y = 0; y < 6; y++)
            {
                for (int x = 0; x < lineLength; x++)
                {
                    if (matrix[y, x] == 1)
                        return false;
                }
            }
            return true;
        }
    }   
}
