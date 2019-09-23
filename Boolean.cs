using System;

public class Program
{
	static void Main()
	{
        Boolean1();
        Boolean2();
        Boolean3();
        Boolean4();
        Boolean5();
        Boolean6();
        Boolean7();
        Boolean8();
        Boolean9();
        Boolean10();
        Boolean11();
        Boolean12();
        Boolean13();
        Boolean14();
        Boolean15();
        Boolean16();
        Boolean17();
        Boolean18();
        Boolean20();
        Boolean21();
        Boolean22();
        Boolean23();
        Boolean24();
        Boolean25();
        Boolean26();
        Boolean27();
        Boolean28();
        Boolean29();
        Boolean30();
        Boolean31();
        Boolean32();
        Boolean33();
        Boolean34();
        Boolean35();
        Boolean36();
        Boolean37();
        Boolean38();
        Boolean39();
        Boolean40();
    }
    static void Boolean1()
    {
        int A = -87;
        bool B = A > 0;
        Console.WriteLine(B);
    }
    static void Boolean2()
    {
        int A = -87;
        bool B = A % 2 == 1;
        Console.WriteLine(B);
    }
    static void Boolean3()
    {
        int A = -87;
        bool B = A % 2 == 0;
        Console.WriteLine(B);
    }
    static void Boolean4()
    {
        int A = 4;
        int B = 1;
        bool X = A > 2 && B <= 3;
        Console.WriteLine(X);
    }
    static void Boolean5()
    {
        int A = 4;
        int B = 1;
        bool X = A >= 0 && B < -2;
        Console.WriteLine(X);
    }
    static void Boolean6()
    {
        int A = 4;
        int B = 8;
        int C = 2;
        bool X = A < B && B< C;
        Console.WriteLine(X);
    }
    static void Boolean7()
    {
        int A = 4;
        int B = 8;
        int C = 2;
        bool X = (A < B && B < C) || (A > B && B > C);
        Console.WriteLine(X);
    }
    static void Boolean8()
    {
        int A = 3;
        int B = 5;
        bool X = A % 2 == 1 && B % 2 == 1;
        Console.WriteLine(X);
    }
    static void Boolean9()
    {
        int A = 3;
        int B = 5;
        bool X = A % 2 == 1 || B % 2 == 1;
        Console.WriteLine(X);
    }
    static void Boolean10()
    {
        int A = 3;
        int B = 5;
        bool X = A % 2 == 1 ^ B % 2 == 1;
        Console.WriteLine(X);
    }
    static void Boolean11()
    {
        int A = 3;
        int B = 5;
        bool X = A % 2 == B % 2;
        Console.WriteLine(X);
    }
    static void Boolean12()
    {
        int A = 3;
        int B = 5;
        int C = 8;
        bool X = A>0 && B>0 && C>0;
        Console.WriteLine(X);
    }
    static void Boolean13()
    {
        int A = 3;
        int B = 5;
        int C = 8;
        bool X = A > 0 || B > 0 || C > 0;
        Console.WriteLine(X);
    }
    static void Boolean14()
    {
        int A = 3;
        int B = 5;
        int C = 8;
        bool X = A > 0 ^ B > 0 ^ C > 0;
        Console.WriteLine(X);
    }
    static void Boolean15()
    {
        int A = 3;
        int B = 5;
        int C = 8;
        bool X = (A > 0 && B > 0) || (A > 0 && C > 0) || (C > 0 && B > 0);
        Console.WriteLine(X);
    }
    static void Boolean16()
    {
        int A = 74;
        bool X = A / 10 > 0 && A % 2 == 0 && A / 100 == 0;
        Console.WriteLine(X);
    }
    static void Boolean17()
    {
        int A = 437;
        bool X = A / 100 > 0 && A % 2 == 1 && A / 1000 == 0;
        Console.WriteLine(X);
    }
    static void Boolean18()
    {
        int A = 43;
        int B = 43;
        int C = 7;
        bool X = A == B || B == C || C == A;
        Console.WriteLine(X);
    }
    static void Boolean20()
    {
        int A = 742;
        bool X = A % 10 != A / 100 && A / 100 != (A / 10) % 10;
        Console.WriteLine(X);
    }
    static void Boolean21()
    {
        int A = 742;
        bool X = A % 10 < (A / 10) % 10 && (A / 10) % 10 < A / 100;
        Console.WriteLine(X);
    }
    static void Boolean22()
    {
        int A = 742;
        bool X = (A % 10 < (A / 10) % 10 && (A / 10) % 10 < A / 100) || (A % 10 > (A / 10) % 10 && (A / 10) % 10 > A / 100);
        Console.WriteLine(X);
    }
    static void Boolean23()
    {
        int A = 3443;
        bool X = A % 10 == A / 1000 && (A / 10) % 10 == (A / 100) % 10;
        Console.WriteLine(X);
    }
    static void Boolean24()
    {
        int A = 2;
        int B = 6;
        int C = -12;
        int D = B * B - 4 * A * C;
        bool X = D > 0;
        Console.WriteLine(X);
    }
    static void Boolean25()
    {
        int x = -2;
        int y = 4;
        bool X = x < 0 && y > 0;
        Console.WriteLine(X);
    }
    static void Boolean26()
    {
        int x = -2;
        int y = 4;
        bool X = x > 0 && y < 0;
        Console.WriteLine(X);
    }
    static void Boolean27()
    {
        int x = -2;
        int y = 4;
        bool X = x < 0;
        Console.WriteLine(X);
    }
    static void Boolean28()
    {
        int x = -2;
        int y = 4;
        bool X = (x > 0 && y>0)||(x<0 && y<0);
        Console.WriteLine(X);
    }
    static void Boolean29()
    {
        int x = 8;
        int y = 5;
        int x1 = 11;
        int y1 = 9;
        int x2 = 3;
        int y2 = 2;
        bool X = x > x1 && x < x2 && y > y1 && y < y2;
        Console.WriteLine(X);
    }
    static void Boolean30()
    {
        int a = 5;
        int b = 5;
        int c = 5;
        bool X = a == b && b == c;
        Console.WriteLine(X);
    }
    static void Boolean31()
    {
        int a = 5;
        int b = 5;
        int c = 5;
        bool X = a == b || b==c || c==a;
        Console.WriteLine(X);
    }
    static void Boolean32()
    {
        int a = 5;
        int b = 3;
        int c = 4;
        bool X = a * a + b * b == c * c || c * c + a * a == b * b || c * c + b * b == a * a;
        Console.WriteLine(X);
    }
    static void Boolean33()
    {
        int a = 5;
        int b = 3;
        int c = 4;
        bool X = a + b > c && b + c > a && c + a > b;
        Console.WriteLine(X);
    }
    static void Boolean34()
    {
        int x = 4;
        int y = 5;
        bool X = x % 2 != y % 2;
        Console.WriteLine(X);
    }
    static void Boolean35()
    {
        int x1 = 4;
        int y1 = 5;
        int x2 = 8;
        int y2 = 7;
        bool X = (x1 + x2 + y1 + y2) % 2 == 0;
        Console.WriteLine(X);
    }
    static void Boolean36()
    {
        int x1 = 4;
        int y1 = 5;
        int x2 = 8;
        int y2 = 7;
        bool X = x1 == x2 || y1 == y2;
        Console.WriteLine(X);
    }
    static void Boolean37()
    {
        int x1 = 4;
        int y1 = 5;
        int x2 = 8;
        int y2 = 7;
        bool X = Math.Abs(x1 - x2) == 1 || Math.Abs(y1 - y2) == 1;
        Console.WriteLine(X);
    }
    static void Boolean38()
    {
        int x1 = 4;
        int y1 = 6;
        int x2 = 8;
        int y2 = 2;
        bool X = x1 + y1 == x2 + y2;
        Console.WriteLine(X);
    }
    static void Boolean39()
    {
        int x1 = 4;
        int y1 = 6;
        int x2 = 8;
        int y2 = 2;
        bool X = (x1 + y1 == x2 + y2) || (x1 == x2 || y1 == y2);
        Console.WriteLine(X);
    }
    static void Boolean40()
    {
        int x1 = 4;
        int y1 = 5;
        int x2 = 6;
        int y2 = 7;
        bool X = (Math.Abs(y1 - y2) == 2 && Math.Abs(x1 - x2) == 1) || (Math.Abs(y1 - y2) == 1 && Math.Abs(x1 - x2) == 2);
        Console.WriteLine(X);
    }
}