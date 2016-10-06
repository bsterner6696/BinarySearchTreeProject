using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Insert(28);
            tree.Insert(138);
            tree.Insert(1);
            tree.Insert(50);
            tree.Insert(19);

            tree.Search(50);
            tree.Search(2);

            tree.Display();

            Console.ReadLine();
        }
    }
}
