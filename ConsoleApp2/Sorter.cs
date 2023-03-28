using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public static double[] SortDoble(double[] notSortedArrayDouble)
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

        public char[] Sor(char[] notSortedChar)
        {

            int[] alphabet = new int[26];
            for (int i = 0; i < notSortedChar.Length; i++)
            {
                if (char.IsLetter(notSortedChar[i]))
                {
                    int index = notSortedChar[i] - 'a';
                    alphabet[index]++;
                }
            }

            return notSortedChar;
        }

        public string Sor(string notSortedString)
        {
            return "sortedString";
        }
    }
}
