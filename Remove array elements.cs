using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 1;

            int[] nums = { 2, 2, 3, 3, 1, 2,5, 6, 7,2, 8, 9, 10 };
            int val = 2;
            //foreach(int i in nums)
            for (int i = 0; i < nums.Length; i++)
            {

                if (nums[i] == val)
                {
                    Console.Write("_");
                }
                else
                {
                    Console.Write(  " ," + nums[i]);
                }

            }
        }
    }
}