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
        static string[] symbols = { wall, cell,cell,cell};
        static int height = 10;
        static int width = 12;
        static string[,] zone=getZone(height,width);
        static void Main(string[] args)
        {
            Init(height,width);
        }
        static string[,] getZone(int h, int w)
        {
            var rand = new Random();
            string[,] game_zone = new string[h, w];
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                { 
                    int Index = rand.Next(symbols.Length);
                    game_zone[i, j] = symbols[Index];
                }
            }
            int charX=rand.Next(w);
            int charY=rand.Next(h);
            game_zone[charY,charX]=person;
            game_zone[rand.Next(h),rand.Next(w)]=finish;
            return game_zone;
        }
        static void Generate(int heig,int widt){
          Console.Clear();
          for (int i = 0; i < heig; i++)
            {
                for (int j = 0; j < widt; j++)
                { 
                    Console.Write("{0}\t",zone[i,j]);
                }
                Console.WriteLine();
            }
        }
        static void Init(int hei,int wid){
          while (true){
            Generate(hei,wid);
            int[] k=Input();
            if (IsFinish(k[0],k[1])){
              break;
            }
            Move(k[0],k[1]);
          }
          Console.Clear();
          Console.WriteLine("Ура вы дошли!!");
        }
        static int[] Input(){
          var key=Console.ReadKey().Key;
          switch(key){
            case ConsoleKey.W:
              return new int[] {-1,0};
            case ConsoleKey.S:
              return new int[] {1,0};
            case ConsoleKey.A:
              return new int[] {0,-1};
            case ConsoleKey.D:
              return new int[] {0,1};
            default:
              return new int[] {0,0};
          }
        }
        static int[] getCharacterCoor(){
          for (int i = 0; i < zone.GetLength(0); i++)
            {
                for (int j = 0; j < zone.GetLength(1); j++)
                { 
                    if (zone[i,j]=="@"){
                      return new int[] {i,j};
                    }
                }
            }
            return new int[] {0,0};
        }
        static void Move(int Y,int X){
          int PersY=getCharacterCoor()[0];
          int PersX=getCharacterCoor()[1];
          if (PersX+X>=0&&PersY+Y>=0 && !IsWall(PersY+Y,PersX+X)){
            zone[PersY,PersX]=" ";
            zone[PersY+Y,PersX+X]="@";
          }
        }
        static bool IsWall(int coordinateY,int coordinateX){
          if (coordinateY>=height||coordinateX>=width){
            return true;
          }
          return zone[coordinateY,coordinateX]=="#";
        }
        static bool IsFinish(int dy,int dx){
          int PersY=getCharacterCoor()[0];
          int PersX=getCharacterCoor()[1];
          if (PersY+dy<0 || PersX+dx<0 || PersY+dy>=height||PersX+dx>=width){
            return false;
          }
          return zone[PersY+dy,PersX+dx]=="F";
        }
    }
}
