using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{

    internal class PrimeMethods
    {
        private static List<int> InitArray;
        private static List<int> ResultsArray = new List<int>();
        private static List<int> NumbersToDelete =new List<int>();

        private static void intArray(int i)
        {
            InitArray= Enumerable.Range(2, i).ToList<int>();
        }
        public static List<int> processPrimes(int i)
        {
            intArray(i);
            while (InitArray.Count>0)
            {
                ResultsArray.Add(InitArray[0]);
                foreach (int j in InitArray.ToArray<int>())
                {
                    if (j % InitArray[0] == 0)
                    {
                        NumbersToDelete.Add(j);
                    }
                }
                foreach (int j in NumbersToDelete.ToArray<int>())
                {

                    InitArray.Remove(j);

                }
                NumbersToDelete.Clear();
            }
            return ResultsArray;
        }
    }
}
