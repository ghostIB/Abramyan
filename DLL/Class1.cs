using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class SomeFunctions
    {
        public static int Sum(Array A)
        {
            int sum = 0;
            foreach (int x in A)
            {
                sum += x;
            }
            return sum;
        }
        public static int ShowArray(Array arr)
        {
            foreach (var x in arr) Console.Write(x+" ");
            Console.WriteLine();
            return 0;
        }
        public static bool IsPairing(int a)
        {
            return a % 2 == 0;
        }
        public static int Count(Array arr,int a)
        {
            int k = 0;
            foreach (int x in arr)
            {
                if (x == a)
                {
                    k++;
                }
            }
            return k;
        }
        public static bool IsPrime(int a)
        {
            for (int i = 2; i <= a / 2; i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsPall(int a)
        {
            bool flag = true;
            string a1 = a.ToString();
            int len = a.ToString().Length;
            for (int i = 0; i < len / 2; i++)
            {
                if (a1.Substring(i, 0) == a1.Substring(len - 1, 0))
                {
                    continue;
                }
                flag = false;
                break;
            }
            return flag;
        }
    }
}
