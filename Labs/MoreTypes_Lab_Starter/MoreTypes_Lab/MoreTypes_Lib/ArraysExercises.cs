using System;
using System.Collections.Generic;
using System.Linq;

namespace MoreTypes_Lib
{
    public class ArraysExercises
    {
        // returns a 1D array containing the contents of a given List
        public static string[] Make1DArray(List<string> contents)
        {
            return contents.ToArray();
        }

        // returns a 3D array containing the contents of a given List
        public static string[,,] Make3DArray(int length1, int length2, int length3, List<string> contents)
        {
            string[,,] outputArray = new string[length1, length2, length3];
            int totalLength = length1 * length2 * length3;
            int p = 0;
            if (contents.Count != totalLength)
            {
                throw new ArgumentException("Number of elements in list must match array size");
            }
            else
            {
                for (int i = 0; i < length1; i++)
                {
                    for (int j = 0; j < length2; j++)
                    {
                        for (int k = 0; k < length3; k++)
                        {
                            outputArray[i, j, k] = contents[p++];
                        }
                    }
                }
            }
            return outputArray;

        }

        // returns a jagged array containing the contents of a given List
        public static string[][] MakeJagged2DArray(int countRow1, int countRow2, List<string> contents)
        {
            int totalCount = countRow1 + countRow2;
            if(contents.Count != totalCount)
            {
                throw new ArgumentException("Number of elements in list must match array size");
            }
            string[][] jaggedArray = new string[][] { new string[countRow1], new string[countRow2] };
            int counter = 0;
            foreach (var array in jaggedArray)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = contents[counter];
                    counter++;
                }
            }
            return jaggedArray;
        }
    }
}
