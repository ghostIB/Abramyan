using System;

class MainClass {
  public static void Main (string[] args) {
    Node a=new Node(5);
    a.AddValue(4);
    a.AddValue(7);
  }
  class Node{
    public int value{get;}
    public Node left;
    public Node right;
    public Node(int inputValue){
      value=inputValue;
      left=new Node(0);
      right=new Node(0);
    }
    public void AddValue(int nodeValue){
      if (nodeValue<=value){
        if (left.value==0){
          left=new Node(nodeValue);
        }
        else{
          left.AddValue(nodeValue);
        }
      }
      else{
        if (right.value==0){
          right=new Node(nodeValue);
        }
        else{
          right.AddValue(nodeValue);
        }
      }
    }
    public bool CheckNodes(int checkedValue){
      return right.value==checkedValue||left.value==checkedValue;
    }
    public int[] GetSortedNode(){
      return new int[] {left.value,value,right.value};
    }
    public override string ToString(){
      return $"{value}";
    }
  }
  class Tree{
    protected Node rootNode;
    public Tree(int inputRootValue){
      rootNode=new Node(inputRootValue);
    }
  }
  public static void WriteLineArray(int[] array){
    foreach (int i in array){
      Console.Write(i.ToString()+" ");
    }
    Console.Write("\n");
  }
}