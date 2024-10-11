using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{

    internal class PrimeMethods
    {
        private static Dictionary<int,bool> InitArray;
        private static List<int> ResultsArray = new List<int>();
        private static List<int> NumbersToDelete =new List<int>();

        private static void intArray(int i)
        {
            InitArray= Enumerable.Range(2, i-1).ToDictionary(x => x, x => false);
        }

        public static List<int> prime(int st)
        {
            intArray(st);
            foreach (int item in InitArray.Keys)
            {
                if (InitArray[item] == false)
                {
                    ResultsArray.Add(item);
                    for (int i = item; i <= st; i++)
                    {
                        if (i%item ==0 )
                        {
                            InitArray[i] = true;
                        }
                    }

                }
            }
            //Console.WriteLine(string.Join(", ", InitArray.ToArray()));
            return ResultsArray;
        }
    }
}
