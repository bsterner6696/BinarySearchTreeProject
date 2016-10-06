using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProject
{
    public class Node
    {
        public int data;
        public Node rightChild;
        public Node leftChild;
        public Node(int value)
        {
            data = value;
            rightChild = null;
            leftChild = null;
        }
        public void InsertData(int value)
        {
            if (data > value)
            {
                InsertLeftChild(value);   
            } else if (data < value)
            {
                InsertRightChild(value);
            }
        }
        public void InsertLeftChild(int value)
        {
            if (leftChild == null)
            {
                leftChild = new Node(value);
            }
            else
            {
                leftChild.InsertData(value);
            }
        }
        public void InsertRightChild(int value)
        {
            if (rightChild == null)
            {
                rightChild = new Node(value);
            }
            else
            {
                rightChild.InsertData(value);
            }
        }

        public void Search(int value)
        {
            
            if (data == value)
            {
                Console.WriteLine("Tree contains {0}", value); ;
            }
            else if (data > value)
            {
                SearchChild(leftChild, value);
            }
            else if (data < value)
            {
                SearchChild(rightChild, value);
            }
            
        }
        public void SearchChild(Node child, int value)
        {
            if (child == null)
            {
                Console.WriteLine("Tree does not contain {0}", value);
            }
            else
            {
                child.Search(value);
            }
        }

        public void Display()
        {

            DisplayChild(leftChild);
            Console.Write("{0} ", data);
            DisplayChild(rightChild);

        }
        public void DisplayChild(Node child)
        {
            if (child == null)
            {
                Console.Write("");
            }
            else
            {
                child.Display();
            }
        }
    }
}
