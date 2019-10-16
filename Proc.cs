using System;
using System.Collections.Generic;
using System.Text;

    class Program5
    {
        public static void Main()
        {
            Proc16();
            Proc17();
            Proc18();
            Proc19();
            Proc20();
            Proc21();
            Proc22();
            Proc23();
            Proc24();
            Proc25();
            Proc26();
            Proc27();
            Proc28();
            Proc29();
            Proc30();
        }
        public static int Sign(double X)
        {
            return (X < 0) ? -1 : (X == 0) ? 0 : 1;
        }
        static void Proc16()
        {
            Console.WriteLine(Sign(74));
        }
        public static int RootsCount(int A, int B, int C)
        {
            int D = B * B - 4 * C * A;
            return (D < 0) ? 0 : (D == 0) ? 1 : 2;
        }
        static void Proc17()
        {
            Console.WriteLine(RootsCount(1, 8, 9));
        }
        public static double CicleS(double R)
        {
            double S = Math.PI * R * R;
            return Math.Round(S);
        }
        static void Proc18()
        {
            Console.WriteLine(CicleS(4.5));
        }
        public static double RingS(double R1, double R2)
        {
            double S1 = Math.Round(Math.PI * R1 * R1);
            double S2 = Math.Round(Math.PI * R2 * R2);
            return S1 - S2;
        }
        static void Proc19()
        {
            Console.WriteLine(RingS(4.5, 3));
        }
        public static double TriangleP(double a, double h)
        {
            double b = Math.Sqrt((a / 2) * (a / 2) + h * h);
            double P = b + b + a;
            return Math.Round(P);
        }
        static void Proc20()
        {
            Console.WriteLine(TriangleP(6, 3));
        }
        public static int SumRange(int A, int B)
        {
            int sum = 0;
            if (A > B)
            {
                return 0;
            }
            for (int i = A; i <= B; i++)
            {
                sum += i;
            }
            return sum;
        }
        static void Proc21()
        {
            Console.WriteLine(SumRange(2, 8) + " " + SumRange(8, 14));
        }
        public static double Calc(double A, double B, double Op)
        {
            return (Op == 1) ? A - B : (Op == 2) ? A * B : (Op == 3) ? A / B : A + B;
        }
        static void Proc22()
        {
            Console.WriteLine(Calc(6, 2, 1) + " " + Calc(6, 2, 2) + " " + Calc(6, 2, 3) + " " + Calc(6, 2, 4));
        }
        public static int Quarter(double x, double y)
        {
            return (x > 0 && y > 0) ? 1 : (x < 0 && y > 0) ? 2 : (x < 0 && y < 0) ? 3 : 4;
        }
        static void Proc23()
        {
            Console.WriteLine(Quarter(7, -5));
        }
        public static bool Even(int K)
        {
            return K % 2 == 0;
        }
        static void Proc24()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int k = 0;
            foreach (int x in a)
            {
                if (Even(x))
                {
                    k++;
                }
            }
            Console.WriteLine(k);
        }
        public static bool IsSquare(int K)
        {
            return Math.Sqrt(K) % 1 == 0;
        }
        static void Proc25()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int k = 0;
            foreach (int x in a)
            {
                if (IsSquare(x))
                {
                    k++;
                }
            }
            Console.WriteLine(k);
        }
        public static bool IsPower5(int K)
        {
            int k1 = K;
            while (k1 > 1)
            {
                if (k1 % 5 == 0)
                {
                    k1 /= 5;
                }
                else
                {
                    return false;
                }
            }
            return (K == 1) ? false : true;
        }
        static void Proc26()
        {
            int[] a = { 1, 2, 3, 4, 5, 25, 125, 6, 7, 8 };
            int k = 0;
            foreach (int x in a)
            {
                if (IsPower5(x))
                {
                    k++;
                }
            }
            Console.WriteLine(k);
        }
        public static bool IsPowerN(int K, int N)
        {
            int k1 = K;
            while (k1 > 1)
            {
                if (k1 % N == 0)
                {
                    k1 /= N;
                }
                else
                {
                    return false;
                }
            }
            return (K == 1) ? false : true;
        }
        static void Proc27()
        {
            int[] a = { 1, 2, 3, 4, 5, 25, 125, 6, 7, 8 };
            int k = 0;
            foreach (int x in a)
            {
                if (IsPowerN(x, 5))
                {
                    k++;
                }
            }
            Console.WriteLine(k);
        }
        public static bool IsPrime(int K)
        {
            for (int i = 2; i <= K / 2; i++)
            {
                if (K % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Proc28()
        {
            int[] a = { 2, 3, 4, 5, 25, 125, 6, 7, 8, 9 };
            int k = 0;
            foreach (int x in a)
            {
                if (IsPrime(x))
                {
                    k++;
                }
            }
            Console.WriteLine(k);
        }
        public static int DigitCount(int K)
        {
            return K.ToString().Length;
        }
        static void Proc29()
        {
            int[] a = { 2, 3, 4, 5 };
            foreach (int x in a)
            {
                Console.WriteLine(DigitCount(x));
            }
        }
        public static int DigitN(int N, int K)
        {
            string N1 = N.ToString();
            return int.Parse(N1.Substring(N1.Length - K, 1));
        }
        static void Proc30()
        {
            int[] a = { 2, 32, 434, 5286, 87302 };
            int k = 0;
            foreach (int x in a)
            {
                k++;
                Console.WriteLine(DigitN(x, k));
            }
        }
    }
