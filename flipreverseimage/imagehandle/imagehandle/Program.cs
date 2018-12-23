using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imagehandle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] row0 = new int[] { 1, 1, 0 };
            int[] row1 = new int[] { 1, 0, 1 };
            int[] row2 = new int[] { 0, 0, 0 };
            int[][] image = new int[][] { row0, row1, row2 };
            
            int[][] newImage = FlipAndInvertImage(image);

            for (int i = 0; i < newImage.Length; i++)
            {
                Console.Write("\n");
                for (int index = 0; index < newImage[i].Length; index++)
                {
                    Console.Write(newImage[i][index] + " ");
                }
            }


        }

            public static int[][] FlipAndInvertImage(int[][] A)
        {
            int[][] newimage = new int[A.Length][];
 
            for(int i = 0; i < A.Length; i++)
            {
                newimage[i] = new int[A[i].Length];
                for(int index = 0; index < A[i].Length; index++)
                {
                    int temp = A[i][A[i].Length - index - 1];
                    if(temp == 0)
                    {
                        newimage[i][index] = 1;
                    }
                    else
                    {
                        newimage[i][index] = 0;
                    }
                }
            }

            return newimage;
        }
    }
}
