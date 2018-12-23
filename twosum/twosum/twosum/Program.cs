using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twosum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 7, 11, 15 };
            int target = 9;
            int[] result = new int[2];

            result = TwoSum(array, target);
            Console.WriteLine("first index: " + result[0] + "; second index: " + result[1]);


        }

        public static int[] TwoSum(int[] nums, int target)
        {
            for(int i =0; i < nums.Length; i++)
            {
                int magicvalue = target - nums[i];
                for(int j = i + 1; j < nums.Length; j++ )
                {
                    if(nums[j] == magicvalue)
                    {
                        int[] result = new int[2];
                        result[0] = i;
                        result[1] = j;
                        return result;
                    }
                }
            }
            return new int[] { -1, -1 };
        }































/* old code
 * 
 *         public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int,int> dict = new Dictionary<int,int>();
            for(int i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }
                
                int magicnumber = target - nums[i];

                if ((dict.ContainsKey(magicnumber)) && (dict[magicnumber] != i))
                {
                    return new int[] { dict[magicnumber], i };
                }
            }

            /*
                        int[] result = new int[] { -1, -1 };

                        for (int i = 0; i < nums.Length - 1; i++)
                        {
                            int magicvalue = target - nums[i];
                            int location = Array.LastIndexOf(nums, magicvalue);
                            if(location != -1 & location != i)
                            {
                                result[0] = i;
                                result[1] = location;
                                return result;
                            }
                        }

                        for(int i = 0; i < nums.Length; i++)
                        {
                            int magicnumber = target - nums[i];
                            for(int j = 0; j < nums.Length; j++)
                            {
                                if ((j != i) & (nums[i] + nums[j] == target))
                                {
                                    result[0] = i;
                                    result[1] = j;
                                    return result;
                                }
                            }
                        }
            */
/*
            return new int[] { -1, -1 };
}
  
*/ 
    }
}
