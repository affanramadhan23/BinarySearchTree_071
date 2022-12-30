using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_071
{
    class Node
    {
        public string info;
        public Node leftchild;
        public Node rightchild;

        //Construtor for the node class
        public Node(string i, Node l, Node r)
        {
            info = i;
            leftchild = l;
            rightchild = r;
        }
    }

    // A Node class consists on three things, the information, reference to the right child, and reference to the left child //

    
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
