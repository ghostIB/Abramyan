using System;

class MainClass {
  public static void Main (string[] args) {
    Node a=new Node(5);
    a.AddValue(8);
    a.AddValue(3);
    a.AddValue(12);
    Console.WriteLine(a.SearchNode(new Node(12)));
  }
  class Node{
    public int value{get;}
    public Node left;
    public Node right;
    private bool resultRight,resultLeft;
    public Node(int inputValue){
      this.value=inputValue;
    }
    public void AddValue(int nodeValue){
      if (nodeValue<=value){
        if (left==null){
          left=new Node(nodeValue);
        }
        else{
          left.AddValue(nodeValue);
        }
      }
      else{
        if (right==null){
          right=new Node(nodeValue);
        }
        else{
          right.AddValue(nodeValue);
        }
      }
    }
    public bool SearchNode(Node searchedNode){
      if (searchedNode.value==value) return true;
      else{
        resultLeft = left==null?false:left.SearchNode(searchedNode);
        resultRight = right==null?false:right.SearchNode(searchedNode);
      }
      return resultLeft||resultRight;
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
