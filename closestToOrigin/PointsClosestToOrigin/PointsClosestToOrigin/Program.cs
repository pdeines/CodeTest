using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PointsClosestToOrigin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] input1 = new int[][]
            {
                new int[] {1, 3},
                new int[] {-2, 2}
            };
            int k1 = 1;
            int[][] input2 = new int[][]
            {
                new int[] {3, 3},
                new int[] {5, -1},
                new int[] {-2,4}
            };
            int k2 = 2;

            int[][] output = KClosest(input2, k2);

            for (int i = 0; i < output.Length; i++)
            {
                for (int j = 0; j < output[i].Length; j++)
                {
                    Console.Write(output[i][j] + " ");
                }

                Console.WriteLine();
            }
        }

        public static int[][] KClosest(int[][] points, int K)
        {
            Dictionary<int, List<int[]>> map = new Dictionary<int, List<int[]>>();
            int[] distances = new int[points.Length];
            int index = 0;

            foreach (int[] point in points)
            {
                int distance = point[0] * point[0] + point[1] * point[1];
                distances[index] = distance;
                if (map.ContainsKey(distance))
                {
                    var temp = map[distance];
                    temp.Add(new int[]{point[0], point[1]});
                }
                else
                {
                    int[] temppoint = new int[] {point[0], point[1]};
                    List<int[]> templist = new List<int[]>();
                    templist.Add(temppoint);
                    map.Add(distance, templist);
                }

                index++;
            }

            int[][] output = new int[K][];

            Array.Sort(distances);
            for(int i = 0; i < K; i++)
            {
                var temp = map[distances[i]];
                output[i] = temp[0];
            }

            return output;
        }
    }
}
