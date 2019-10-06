using System;

class Program4
{
    static void Main()
    {
        If1();
        If2();
        If3();
        If4();
        If5();
        If6();
        If7();
        If8();
        If9();
        If10();
        If11();
        If12();
        If13();
        If14();
        If15();
        If16();
        If17();
        If18();
        If19();
        If20();
        If21();
        If22();
        If24();
        If25();
        If26();
        If27();
        If28();
        If29();
        If30();
    }
    static void If1()
    {
        int a = 5;
        if (a > 0)
        {
            a++;
        }
        Console.WriteLine(a);
    }
    static void If2()
    {
        int a = -3;
        if (a > 0)
        {
            a++;
        }
        else
        {
            a -= 2;
        }
        Console.WriteLine(a);
    }
    static void If3()
    {
        int a = 0;
        if (a > 0)
        {
            a++;
        }
        else if (a == 0)
        {
            a = 10;
        }
        else
        {
            a -= 2;
        }
        Console.WriteLine(a);
    }
    static void If4()
    {
        int a = 3;
        int b = -4;
        int c = 7;
        byte k = 0;
        if (a > 0)
        {
            k++;
        }
        if (b > 0)
        {
            k++;
        }
        if (c > 0)
        {
            k++;
        }
        Console.WriteLine(k);
    }
    static void If5()
    {
        int a = 3;
        int b = -4;
        int c = 7;
        byte k = 0;
        byte k1 = 0;
        if (a > 0)
        {
            k++;
        }
        else
        {
            k1++;
        }
        if (b > 0)
        {
            k++;
        }
        else
        {
            k1++;
        }
        if (c > 0)
        {
            k++;
        }
        else
        {
            k1++;
        }
        Console.WriteLine(k + " " + k1);
    }
    static void If6()
    {
        int a = 4;
        int b = 2;
        if (a > b)
        {
            Console.WriteLine(a);
        }
        else if (a < b)
        {
            Console.WriteLine(b);
        }
    }
    static void If7()
    {
        int a = 4;
        int b = 2;
        if (a > b)
        {
            Console.WriteLine(1);
        }
        else if (a < b)
        {
            Console.WriteLine(2);
        }
    }
    static void If8()
    {
        int a = 4;
        int b = 2;
        if (a > b)
        {
            Console.WriteLine(a + " " + b);
        }
        else if (a < b)
        {
            Console.WriteLine(b + " " + a);
        }
    }
    static void If9()
    {
        int a = 7;
        int b = 6;
        int c = 0;
        if (a > b)
        {
            c = a;
            a = b;
            b = c;
        }
        Console.WriteLine(a + " " + b);
    }
    static void If10()
    {
        int a = 6;
        int b = 7;
        if (a == b)
        {
            a = 0;
            b = 0;
        }
        else
        {
            a += b;
            b = a;
        }
        Console.WriteLine(a + " " + b);
    }
    static void If11()
    {
        int a = 6;
        int b = 7;
        if (a == b)
        {
            a = 0;
            b = 0;
        }
        else if (a > b)
        {
            b = a;
        }
        else if (b > a)
        {
            a = b;
        }
        Console.WriteLine(a + " " + b);
    }
    static void If12()
    {
        int a = 6;
        int b = 7;
        int c = 3;
        if (a < b && a < c)
        {
            Console.WriteLine(a);
        }
        else if (b < a && b < c)
        {
            Console.WriteLine(b);
        }
        else if (c < a && c < b)
        {
            Console.WriteLine(c);
        }
    }
    static void If13()
    {
        int a = 6;
        int b = 7;
        int c = 3;
        if (a < b && a > c)
        {
            Console.WriteLine(a);
        }
        else if (b < a && b > c)
        {
            Console.WriteLine(b);
        }
        else if (c < a && c > b)
        {
            Console.WriteLine(c);
        }
    }
    static void If14()
    {
        int a = 6;
        int b = 7;
        int c = 3;
        if (a < b && a > c)
        {
            Console.WriteLine(c + " " + b);
        }
        else if (b < a && b > c)
        {
            Console.WriteLine(c + " " + a);
        }
        else if (c < a && c > b)
        {
            Console.WriteLine(b + " " + a);
        }
    }
    static void If15()
    {
        int a = 6;
        int b = 7;
        int c = 3;
        if (a < b && a > c)
        {
            Console.WriteLine(a + b);
        }
        else if (b < a && b > c)
        {
            Console.WriteLine(b + a);
        }
        else if (c < a && c > b)
        {
            Console.WriteLine(c + a);
        }
    }
    static void If16()
    {
        int a = 6;
        int b = 7;
        int c = 3;
        if (a < b && b < c)
        {
            Console.WriteLine(a * 2 + " " + b * 2 + " " + c * 2);
        }
        else
        {
            Console.WriteLine(-a + " " + -b + " " + -c);
        }
    }
    static void If17()
    {
        int a = 6;
        int b = 5;
        int c = 3;
        if ((a < b && b < c) || (a > b && b > c))
        {
            Console.WriteLine(a * 2 + " " + b * 2 + " " + c * 2);
        }
        else
        {
            Console.WriteLine(-a + " " + -b + " " + -c);
        }
    }
    static void If18()
    {
        int a = 6;
        int b = 6;
        int c = 3;
        if (b == c)
        {
            Console.WriteLine(1);
        }
        else if (c == a)
        {
            Console.WriteLine(2);
        }
        else if (a == b)
        {
            Console.WriteLine(3);
        }
    }
    static void If19()
    {
        int a = 6;
        int b = 6;
        int c = 6;
        int d = 5;
        if (a == b && b == c)
        {
            Console.WriteLine(4);
        }
        else if (a == b && b == d)
        {
            Console.WriteLine(3);
        }
        else if (a == c && c == d)
        {
            Console.WriteLine(2);
        }
        else if (b == c && c == d)
        {
            Console.WriteLine(1);
        }
    }
    static void If20()
    {
        int x1 = 7;
        int y1 = 4;
        int x2 = 5;
        int y2 = 9;
        int x3 = 6;
        int y3 = 2;
        double L1 = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
        double L2 = Math.Sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3));
        if (L1 > L2)
        {
            Console.WriteLine(x3 + " " + y3 + " " + L2);
        }
        else if (L1 < L2)
        {
            Console.WriteLine(x2 + " " + y2 + " " + L1);
        }
    }
    static void If21()
    {
        int x = 0;
        int y = 5;
        if (x == 0 && y == 0)
        {
            Console.WriteLine(0);
        }
        else if (y == 0)
        {
            Console.WriteLine(1);
        }
        else if (x == 0)
        {
            Console.WriteLine(2);
        }
        else
        {
            Console.WriteLine(3);
        }
    }
    static void If22()
    {
        int x = 4;
        int y = -1;
        if (x > 0 && y > 0)
        {
            Console.WriteLine(1);
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine(2);
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine(3);
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine(4);
        }
    }
    static void If24()
    {
        double x = 60;
        double y = (x > 0) ? 2 * Math.Sin((x * Math.PI) / 180.0) : 6 - x;
        Console.WriteLine(y);
    }
    static void If25()
    {
        double x = 6;
        double y = (x > 2 || x < -2) ? 2 * x : -3 * x;
        Console.WriteLine(y);
    }
    static void If26()
    {
        double x = -6;
        double y = (x <= 0) ? -x : (0 < x && x < 2) ? x * x : 4;
        Console.WriteLine(y);
    }
    static void If27()
    {
        double x = 7.3;
        int y = (x < 0) ? 0 : (((int)x) % 2 == 0) ? 1 : -1;
        Console.WriteLine(y);
    }
    static void If28()
    {
        int x = 1200;
        int y = ((x % 4 == 0 && x % 100 != 0) || x % 400 == 0) ? 366 : 365;
        Console.WriteLine(y);
    }
    static void If29()
    {
        int x = 0;
        string y = "";
        if (x == 0)
        {
            y += "нулевое ";
        }
        else if (x > 0)
        {
            y += "положительное ";
            y += (x % 2 == 0) ? "четное " : "нечетное ";
        }
        else
        {
            y += "отрецательное ";
            y += (x % 2 == 0) ? "четное " : "нечетное ";
        }
        y += "число";
        Console.WriteLine(y);
    }
    static void If30()
    {
        int x = 999;
        string y = "";
        if (x % 2 == 0)
        {
            y += "четное ";
        }
        else
        {
            y += "нечетное ";
        }
        if (x / 10 == 0)
        {
            y += "однозначное ";
        }
        else if (x / 100 == 0)
        {
            y += "двузначное ";
        }
        else if (x / 1000 == 0)
        {
            y += "трехзначное ";
        }
        y += "число";
        Console.WriteLine(y);
    }
}