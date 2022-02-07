using System;
using System.Collections.Generic;

namespace PositivePrefixes
{
    class Program
    {
        public static int posPrefixes(List<int> arr)
        {
            int pp = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] > 0)
                {
                    pp++;
                }
            }

            return pp;
        }

        public static int prefixSum(List<int> arr, int index)
        {
            int ps = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                if (i == index)
                {
                    break;
                }
                else
                {
                    ps += arr[i];
                }
            }

            return ps;
        }

        public static int maxPosPrefixes(List<int> arr)
        {
            int mpp = 0;

            List<int> posarr = new List<int>();
            List<int> zeroarr = new List<int>();
            List<int> negarr = new List<int>();

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] > 0)
                {
                    posarr.Add(arr[i]);
                }
                else if (arr[i] == 0)
                {
                    zeroarr.Add(arr[i]);
                }
                else if (arr[i] < 0)
                {
                    negarr.Add(arr[i]);
                }
            }

            posarr.Sort();
            negarr.Sort();
            negarr.Reverse();

            arr.Clear();

            for (int i = 0; i < posarr.Count; i++)
            {
                arr.Add(posarr[i]);
            }

            for (int i = 0; i < zeroarr.Count; i++)
            {
                arr.Add(zeroarr[i]);
            }

            for (int i = 0; i < negarr.Count; i++)
            {
                arr.Add(negarr[i]);
            }

            List<int> psarr = new List<int>();

            for (int i = 0; i < arr.Count; i++)
            {
                psarr.Add(prefixSum(arr, i));
            }

            mpp = posPrefixes(psarr);

            return mpp;
        }

        static void Main(string[] args)
        {
            List<int> arr1 = new List<int>();

            arr1.Add(-6);
            arr1.Add(3);
            arr1.Add(4);
            arr1.Add(-10);

            Console.WriteLine("[" + arr1[0] + " , " + arr1[1] + " , " + arr1[2] + " , " + arr1[3] + "]");
            Console.WriteLine(maxPosPrefixes(arr1));

            List<int> arr2 = new List<int>();

            arr2.Add(-3);
            arr2.Add(0);
            arr2.Add(2);
            arr2.Add(1);

            Console.WriteLine("[" + arr2[0] + " , " + arr2[1] + " , " + arr2[2] + " , " + arr2[3] + "]");
            Console.WriteLine(maxPosPrefixes(arr2));

            List<int> arr3 = new List<int>();

            arr3.Add(-3);
            arr3.Add(0);
            arr3.Add(-2);

            Console.WriteLine("[" + arr3[0] + " , " + arr3[1] + " , " + arr3[2] + "]");
            Console.WriteLine(maxPosPrefixes(arr3));
        }
    }
}
