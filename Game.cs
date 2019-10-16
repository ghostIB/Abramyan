using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static string person = "@";
        static string wall = "#";
        static string finish = "F";
        static string cell = " ";
        static string[] symbols = { wall, cell, person, finish };
        static int height = 10;
        static int width = 12;
        static void Main(string[] args)
        {
            Generate(height, width);
            Console.ReadKey();
        }
        static void Generate(int h, int w)
        {
            var rand = new Random();
            string[,] zone = new string[h, w];
            int count_F = 0;
            int count_Player = 0;
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                { 
                    int Index = rand.Next(symbols.Length);
                    if (Index==2)
                    {
                        count_Player += 1;
                    }
                    else if (Index == 3)
                    {
                        count_F += 1;
                    }
                    while ((count_F>1 || count_Player > 1) && (Index==2 || Index==3))
                    {
                        Index = rand.Next(symbols.Length);
                    }
                    zone[i, j] = symbols[Index];
                    Console.Write("{0}\t", zone[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
