using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp56
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Tree a = new Tree(new Node(5));
            Console.WriteLine(a.rootNode);
            Console.ReadKey();
        }
        class Node
        {

            public int value { get; }
            public Node left;
            public Node right;
            private int count = 1;
            private bool resultRight, resultLeft;
            public Node(int inputValue)
            {
                this.value = inputValue;
            }
            public void AddValue(int nodeValue)
            {
                count++;
                if (nodeValue <= value)
                {
                    if (left == null)
                    {
                        left = new Node(nodeValue);
                    }
                    else
                    {
                        left.AddValue(nodeValue);
                    }
                }
                else
                {
                    if (right == null)
                    {
                        right = new Node(nodeValue);
                    }
                    else
                    {
                        right.AddValue(nodeValue);
                    }
                }
            }
            public bool SearchNode(Node searchedNode)
            {
                if (searchedNode.value == value) return true;
                else
                {
                    resultLeft = left == null ? false : left.SearchNode(searchedNode);
                    resultRight = right == null ? false : right.SearchNode(searchedNode);
                }
                return resultLeft || resultRight;
            }
            public void GetSortedList()
            {
                if (left != null) left.GetSortedList();
                Console.Write(value.ToString() + " ");
                if (right != null) right.GetSortedList();
            }
            public bool CheckNodes(int checkedValue)
            {
                return right.value == checkedValue || left.value == checkedValue;
            }
            public int CountNodes() { return count; }
            public override string ToString()
            {
                return $"{value}";
            }
        }
        class Tree
        {
            public Node rootNode { get; }
            public Tree(Node inputRootNode)
            {
                rootNode = inputRootNode;
            }
            public Node left;
            public Node right;
            private int countNode = 1;
            private bool resultRight, resultLeft;
            public void AddNode(Node inputNode)
            {
                if (inputNode.left.value != null) this.AddNode(inputNode.left);
                this.rootNode.AddValue(inputNode);
                if (inputNode.right.value != null) this.AddValue(inputNode.right);
            }
        }
        public static void WriteLineArray(int[] array)
        {   foreach (int i in array)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.Write("\n");
        }
    }
}
