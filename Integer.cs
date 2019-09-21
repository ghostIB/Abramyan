using System;

public class Program
{
	static void Main()
	{
        Integer1();
        Integer2();
        Integer3();
        Integer4();
        Integer5();
        Integer6();
        Integer7();
        Integer8();
        Integer9();
        Integer10();
        Integer11();
        Integer12();
        Integer13();
        Integer14();
        Integer15();
        Integer16();
        Integer17();
        Integer18();
        Integer19();
        Integer20();
        Integer21();
        Integer22();
        Integer23();
        Integer24();
        Integer25();
        Integer26();
        Integer27();
        Integer28();
        Integer29();
        Integer30();
    }
    static void Integer1()
    {
        int L = 338;
        int L1 = L / 100;
        Console.WriteLine(L1);
    }
    static void Integer2()
    {
        int M = 2986;
        int M1 = M / 1000;
        Console.WriteLine(M1);
    }
    static void Integer3()
    {
        int b = 37846;
        int Kb = b / 1024;
        Console.WriteLine(Kb);
    }
    static void Integer4()
    {
        int A = 62;
        int B = 14;
        int C = A / B;
        Console.WriteLine(C);
    }
    static void Integer5()
    {
        int A = 84;
        int B = 25;
        int C = A % B;
        Console.WriteLine(C);
    }
    static void Integer6()
    {
        int A = 94;
        int X = A / 10;
        int Y = A % 10;
        Console.WriteLine(X + " " + Y);
    }
    static void Integer7()
    {
        int A = 78;
        int X = A / 10;
        int Y = A % 10;
        int B = X * Y;
        int C = X + Y;
        Console.WriteLine(C+" "+B);
    }
    static void Integer8()
    {
        int A = 59;
        int X = A / 10;
        int Y = A % 10;
        int B = Y * 10 + X;
        Console.WriteLine(B);
    }
    static void Integer9()
    {
        int A = 745;
        int B = A / 100;
        Console.WriteLine(B);
    }
    static void Integer10() 
    {
        int A = 836;
        int X = A % 10;
        int Y = (A / 10) % 10;
        Console.WriteLine(X + " " + Y);
    }
    static void Integer11()
    {
        int A = 927;
        int X = A % 10;
        int Y = (A / 10) % 10;
        int Z = A / 100;
        int product = Z * X * Y;
        int sum = X + Y + Z;
        Console.WriteLine(sum + " " + product);
    }
    static void Integer12()
    {
        int A = 563;
        int X = A % 10;
        int Y = (A / 10) % 10;
        int Z = A / 100;
        int B = X * 100 + Y * 10 + Z;
        Console.WriteLine(B);
    }
    static void Integer13()
    {
        int A = 286;
        int X = A % 10;
        int Y = (A / 10) % 10;
        int Z = A / 100;
        int B = Y * 100 + X * 10 + Z;
        Console.WriteLine(B);
    }
    static void Integer14()
    {
        int A = 125;
        int X = A % 10;
        int Y = (A / 10) % 10;
        int Z = A / 100;
        int B = X * 100 + Z * 10 + Y;
        Console.WriteLine(B);
    }
    static void Integer15()
    {
        int A = 125;
        int X = A % 10;
        int Y = (A / 10) % 10;
        int Z = A / 100;
        int B = Y * 100 + Z * 10 + X;
        Console.WriteLine(B);
    }
    static void Integer16()
    {
        int A = 125;
        int X = A % 10;
        int Y = (A / 10) % 10;
        int Z = A / 100;
        int B = Z * 100 + X * 10 + Y;
        Console.WriteLine(B);
    }
    static void Integer17()
    {
        int A = 8347;
        int X = A / 100;
        int B = X % 10;
        Console.WriteLine(B);
    }
    static void Integer18()
    {
        int A = 8347;
        int X = A / 1000;
        int B = X % 10;
        Console.WriteLine(B);
    }
    static void Integer19()
    {
        int N = 78263;
        int M = N / 60;
        Console.WriteLine(M);
    }
    static void Integer20()
    {
        int N = 78263;
        int H = N / 3600;
        Console.WriteLine(H);
    }
    static void Integer21()
    {
        int N = 78263;
        int S = N % 60;
        Console.WriteLine(S);
    }
    static void Integer22()
    {
        int N = 78263;
        int S1 = N % 3600;
        Console.WriteLine(S1);
    }
    static void Integer23()
    {
        int N = 78263;
        int H = N / 3600;
        int M2 = H % 60;
        Console.WriteLine(M2);
    }
    static void Integer24()
    {
        int K = 45;
        int K1 = K + 1;
        int day = K1 % 7;
        Console.WriteLine(day);
    }
    static void Integer25()
    {
        int K = 45;
        int K1 = K + 4;
        int day = K1 % 7;
        Console.WriteLine(day);
    }
    static void Integer26()
    {
        int K = 45;
        int K1 = K + 1;
        int day = K1 % 7;
        Console.WriteLine(day+1);
    }
    static void Integer27()
    {
        int K = 45;
        int K1 = K + 5;
        int day = K1 % 7;
        Console.WriteLine(day+1);
    }
    static void Integer28()
    {
        int K = 45;
        int N = 3;
        int K1 = K + N-1;
        int day = K1 % 7;
        Console.WriteLine(day + 1);
    }
    static void Integer29()
    {
        int A = 7;
        int B = 12;
        int C = 5;
        int X = (A / C) * (B / C);
        int S = X * C * C;
        int S1 = A * B - S;
        Console.WriteLine(X + " " + S1);
    }
    static void Integer30()
    {
        int A = 1546;
        int Century = A / 100 + 1;
        Console.WriteLine(Century);
    }
}
 