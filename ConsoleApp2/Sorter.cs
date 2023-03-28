using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Sorter
    {
        public static int[] Sort(int[] notSortedArray)
        {


            int temp;

            for(int i = 0; i < notSortedArray.Length - 1; i++)
            {
                for(int j = 0; j < notSortedArray.Length - (1 + i); j++)
                {
                    if (notSortedArray[j] > notSortedArray[j + 1])
                    {
                        temp = notSortedArray[j + 1];
                        notSortedArray[j + 1] = notSortedArray[j];
                        notSortedArray[j] = temp;
                    }
                }
            }


            return notSortedArray;
        }

        public double[] SortDoble(double[] notSortedArrayDouble)
        {
            double tempDouble;

            for (int i = 0; i < notSortedArrayDouble.Length - 1; i++)
            {
                for (int j = 0; j < notSortedArrayDouble.Length - (1 + i); j++)
                {
                    if (notSortedArrayDouble[j] > notSortedArrayDouble[j + 1])
                    {
                        tempDouble = notSortedArrayDouble[j + 1];
                        notSortedArrayDouble[j + 1] = notSortedArrayDouble[j];
                        notSortedArrayDouble[j] = tempDouble;
                    }
                }
            }


            return notSortedArrayDouble;
        }

        public char[] Sor(char[] notSortedArray)
        {
            var sortedArray = notSortedArray;

            return sortedArray;
        }

        public string Sor(string notSortedString)
        {
            return "sortedString";
        }
    }
}
