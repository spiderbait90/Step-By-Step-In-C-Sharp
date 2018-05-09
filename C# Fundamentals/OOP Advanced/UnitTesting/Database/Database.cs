using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    class Database
    {
        private int[] nums;
        public Database()
        {
            nums = new int[16];
        }

        public void Add(int num)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    nums[i] = num;
                    return;
                }
            }

            throw new ArgumentException();
        }
    }
}
