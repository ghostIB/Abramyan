using System;

class MainClass {
  public static void Main (string[] args) {
    Minmax1();
    Minmax2();
    Minmax3();
    Minmax4();
  }
  static void Minmax1(){
    int N=5;
    int[] a={1,2,3,4,5};
    int min=a[0];
    int max=a[0];
    foreach (int x in a){
      if (x>max){
        max=x;
      }
      if (x<min){
        min=x;
      }
    }
    Console.WriteLine(min+" "+max);
  }
  static void Minmax2(){
    int N=3;
    int[][] a={new int[] {1,4},new int[] {1,2},new int[] {7,3}};
    int min=a[0][0]*a[0][1];
    foreach (int[] x in a){
      if (x[0]*x[1]<min){
        min=x[0]*x[1];
      }
    }
    Console.WriteLine(min);
  }
  static void Minmax3(){
    int N=3;
    int[][] a={new int[] {1,4},new int[] {1,2},new int[] {7,3}};
    int max=a[0][0];
    foreach (int[] x in a){
      foreach (int j in x){
        if (j>max){
          max=j;
        }
      }
  }
  Console.WriteLine(max);
}
static void Minmax4(){
  int N=3;
  int[][] a={new int[] {1,4},new int[] {1,2},new int[] {-7,3}};
  int min=a[0][0];
  int k=-1;
  foreach (int[] x in a){
    foreach (int j in x){
      k++;
      if (j<a[min/2][min%2]){
        min=k;
      }
    }
  }
  Console.WriteLine(min);
}
static void Minmax5(){
  int N=3;
  int[][] a={new int[] {1,4},new int[] {1,2},new int[] {-7,3}};
  double max=a[0][0]/a[0][1];
  int k=-1;
  foreach (int[] x in a){
    foreach (int j in x){
      k++;
      if (j<a[min/2][min%2]){
        min=k;
      }
    }
  }
}
}
