using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nestetlist
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public int DepthSum(IList<NestedInteger> nestedList)
        {
            return ComputeWeight(nestedList, 1);
        }
    
        public int ComputeWeight(IList<NestedInteger> nestedList, int depth)
        {
            int sum = 0;
            foreach(NestedInteger ni in nestedList)
            {
                if(ni.IsInteger())
                {
                    sum += depth * ni.GetInteger();
                }
                else
                {
                    sum += ComputeWeight(ni.GetList(), depth + 1);
                }
            }
            return sum;
        }
    }
}
