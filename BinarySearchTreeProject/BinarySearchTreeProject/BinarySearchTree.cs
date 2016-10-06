using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProject
{
    public class BinarySearchTree
    {

        private Node root;

        public void Insert(int value)
        {
            if (root == null)
            {
                root = new Node(value);
            }
            else
            {
                root.InsertData(value);
            }
        }

        public void Search(int value)
        {
            root.Search(value);
        }
        public void Display()
        {
            if (root == null)
            {
                Console.WriteLine("Tree is empty");
            }
            else
            {
                root.Display();
            }
        }
    }
}
