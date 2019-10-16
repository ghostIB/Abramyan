using System;

class Program7 {
  static void Main() {
    Case10();
    Case11();
    Case12();
    Case13();
    Case14();
  }
  static void Case10(){
    string C="Ю";
    int N=1;
    int k=0;
    switch (C){
      case "С":
        k=0;
        break;
      
      case "З":
        k=1;
        break;
      
      case "Ю":
        k=2;
        break;
      
      case "В":
        k=3;
        break;
    }
    switch ((k-N)%4){
      case 0:
        Console.WriteLine("Север");
        break;
      
      case 1:
        Console.WriteLine("Запад");
        break;
      
      case 2:
        Console.WriteLine("Юг");
        break;
      
      case 3:
        Console.WriteLine("Восток");
        break;
      
    }
  }
  static void Case11(){
  string C="Ю";
    int N=1;
    int N1=2;
    int k=0;
    switch (C){
      case "С":
        k=0;
        break;
      
      case "З":
        k=1;
        break;
      
      case "Ю":
        k=2;
        break;
      
      case "В":
        k=3;
        break;
    }
    switch ((k-N-N1+4)%4){
      case 0:
        Console.WriteLine("Север");
        break;
      
      case 1:
        Console.WriteLine("Запад");
        break;
      
      case 2:
        Console.WriteLine("Юг");
        break;
      case 3:
        Console.WriteLine("Восток");
        break;
    }
  }
  static void Case12(){
    double D,L,S,R;
    int i=2;
    double value=6;
    switch (i){
      case 1:
        D=2*value;
        L=Math.Round(2*Math.PI*value);
        S=Math.Round(value*value*Math.PI);
        Console.WriteLine(D+" "+L+" "+S);
        break;
      case 2:
        R=value/2;
        L=Math.Round(Math.PI*value);
        S=Math.Round(value/2*value/2*Math.PI);
        Console.WriteLine(R+" "+L+" "+S);
        break;
      case 3:
        R=value/Math.PI/2;
        D=value/Math.PI;
        S=value/2*R;
        Console.WriteLine(R+" "+D+" "+S);
        break;
      case 4:
        R=Math.Sqrt(value/Math.PI);
        D=Math.Sqrt(value/Math.PI)*2;
        L=Math.Sqrt(value/Math.PI)*Math.PI*2;
        Console.WriteLine(R+" "+D+" "+L);
        break;
    }
  }
    static void Case13(){
    double a,c,h,S;
    int i=2;
    double value=6;
    switch (i){
      case 1:
        c=Math.Round(Math.Sqrt(2)*value);
        h=Math.Round(c/2);
        S=Math.Round(c*h/2);
        Console.WriteLine(c+" "+h+" "+S);
        break;
      case 2:
        a=Math.Round(value/Math.Sqrt(2));
        h=value/2;
        S=Math.Round(value*h/2);
        Console.WriteLine(a+" "+h+" "+S);
        break;
      case 3:
        a=Math.Round(value*Math.Sqrt(2));
        c=value*2;
        S=value*value;
        Console.WriteLine(a+" "+c+" "+S);
        break;
      case 4:
        a=Math.Round(Math.Sqrt(value*4)/Math.Sqrt(2));
        c=Math.Round(Math.Sqrt(value*4));
        h=Math.Round(c/2);
        Console.WriteLine(a+" "+c+" "+h);
        break;
    }
  }
  static void Case14(){
    double a,R1,R2,S;
    int i=2;
    double value=6;
    switch (i){
      case 1:
        R1=Math.Round(value*Math.Sqrt(3)/6);
        R2=Math.Round(2*R1);
        S=Math.Round(value*value*Math.Sqrt(3)/4);
        Console.WriteLine(R1+" "+R2+" "+S);
        break;
      case 2:
        a=Math.Round(value/Math.Sqrt(3)*6);
        R2=value*2;
        S=Math.Round(a*Math.Sqrt(3)/4);
        Console.WriteLine(a+" "+R2+" "+S);
        break;
      case 3:
        a=Math.Round(value*Math.Sqrt(2)*2);
        R1=value/2;
        S=value*value;
        Console.WriteLine(a+" "+R1+" "+S);
        break;
      case 4:
        a=Math.Round(Math.Sqrt(value/Math.Sqrt(3)*4));
        R1=Math.Round(a*Math.Sqrt(3)/6);
        R2=Math.Round(R1*2);
        Console.WriteLine(a+" "+R1+" "+R2);
        break;
    }
  }
}