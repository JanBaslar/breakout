using System;

namespace BreakoutLibrary
{
    class Randomness
    {
        public static int RandomDirection()
        {

            int[] nums = { -1, 1 };
            int index = new Random().Next(0, 2);

            return nums[index];
        }
    }
}
