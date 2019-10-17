using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
      static char player1='X';
      static char player2='O';
      static char[,] zone=getZone();
      static void Main(string[] args){
        Init();
      }
      static char[,] getZone(){
        char[,] gameZone= new char[3,3];
        for (int i=0;i<3;i++){
          for (int j=0;j<3;j++){
            gameZone[i, j] = '-';
          }
        }
        return gameZone;
      }
      static void Generate(){
          Console.Clear();
          for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                { 
                    Console.Write("{0}\t",zone[i,j]);
                }
                Console.WriteLine();
            }
        }
      static void Move(int coorY,int coorX,int index){
        if (isEmpty(coorY,coorX)){
          if (index%2==1){
            zone[coorY,coorX]=player1;
          }
          else{
            zone[coorY,coorX]=player2;
          }
        }
      }
      static bool isEmpty(int coordinateY,int coordinateX){
         for (int i=0;i<3;i++){
          for (int j=0;j<3;j++){
            if (i==coordinateY && j==coordinateX){
              return zone[i,j]=='-';
            }
          }
        }
        return false;
      }
      static int[] Input(){
        var Y=Console.ReadKey().Key;
        Console.WriteLine();
        var X=Console.ReadKey().Key;
        if (Y==ConsoleKey.D0&&X==ConsoleKey.D0){
          return new int[] {0,0};
        }
        else if (Y==ConsoleKey.D1&&X==ConsoleKey.D0){
          return new int[] {1,0};
        }
        else if (Y==ConsoleKey.D1&&X==ConsoleKey.D1){
          return new int[] {1,1};
        }
        else if (Y==ConsoleKey.D1&&X==ConsoleKey.D2){
          return new int[] {1,2};
        }
        else if (Y==ConsoleKey.D2&&X==ConsoleKey.D2){
          return new int[] {2,2};
        }
        else if (Y==ConsoleKey.D2&&X==ConsoleKey.D0){
          return new int[] {2,0};
        }
        else if (Y==ConsoleKey.D0&&X==ConsoleKey.D2){
          return new int[] {0,2};
        }
        else if (Y==ConsoleKey.D0&&X==ConsoleKey.D1){
          return new int[] {0,1};
        }
        else if (Y==ConsoleKey.D2&&X==ConsoleKey.D1){
          return new int[] {2,1};
        }
        return new int[] {0,0};
      }
      static void Init(){
        int i=0;
         while (true){
           i++;
           Generate();
           int[] k=Input();
           Move(k[0],k[1],i);
           //int result=WhatResult();
           //if (result==0 or result==1 or result==2){
             //break;
           //}
         }
        //  Console.Clear();
        //  if (result==0){
        //    Console.WriteLine("Ничья");
        //  }
        //  else if (result==1){
        //    Console.WriteLine("Победил первый игрок");
        //  }
        //  else if (result==2){
        //    Console.WriteLine("Победил второй игрок");
        //  }
      }
    }
}
