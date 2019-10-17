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
      static char[] Append(char[] arr,char value){
        return arr.ToList().Append(value).ToArray();
      }
      static char[] getLine(char[,] oldArray,int number){
        char[] newArray={};
        for (int i=0;i<oldArray.GetLength(1);i++){
          newArray=Append(newArray,oldArray[number,i]);
        }
        return newArray;
      }
      static char[] getColumn(char[,] oldArray,int number){
        char[] newArray={};
        for (int i=0;i<oldArray.GetLength(0);i++){
          newArray=Append(newArray,oldArray[i,number]);
        }
        return newArray;
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
      static bool All(char[] array,char symbol){
        for (int i=0;i<array.Length;i++){
          if (array[i]!=symbol){
            return false;
          }
        }
        return true;
      }
      static int WhatResult(){
        int res=-1;
        int countChar=0;
        for (int i=0;i<3;i++){
          if (All(getLine(zone,i),'X')){
            res= 1;
          }
          else if (All(getColumn(zone,i),'X')){
            res= 1;
          }
          else if (All(getLine(zone,i),'O')){
            res= 2;
          }
          else if (All(getColumn(zone,i),'O')){
            res= 2;
          }
        }
        if (zone[0,0]==zone[1,1]&&zone[1,1]==zone[2,2]&&zone[0,0]=='X'){
          res=1;
        }
        else if (zone[0,0]==zone[1,1]&&zone[1,1]==zone[2,2]&&zone[0,0]=='O'){
          res=2;
        }
        else if (zone[0,2]==zone[1,1]&&zone[1,1]==zone[2,0]&&zone[1,1]=='X'){
          res=1;
        }
        else if (zone[0,2]==zone[1,1]&&zone[1,1]==zone[2,0]&&zone[1,1]=='O'){
          res=2;
        }
        for (int k=0;k<3;k++){
          for (int s=0;s<3;s++){
            if (zone[k,s]=='-'){
              countChar+=1;
              break;
            }
          }
        }
        if (countChar==0){
          res=0;
        }
        return res;
      }
      static void Init(){
        int i=0;
         while (true){
           i++;
           Generate();
           int[] k=Input();
           Move(k[0],k[1],i);
           int result=WhatResult();
           if (result==0 || result==1 || result==2){
             break;
           }
         }
        int result1=WhatResult();
        Console.Clear();
         if (result1==0){
           Console.WriteLine("Ничья");
         }
         else if (result1==1){
           Console.WriteLine("Победил первый игрок");
         }
         else if (result1==2){
           Console.WriteLine("Победил второй игрок");
         }
      }
    }
}
