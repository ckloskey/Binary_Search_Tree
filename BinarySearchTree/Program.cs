using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();
            Node root = null;
            List<int> randomList = new List<int>();
            Random random = new Random();



            for (int i = 0; i < 100; i++)
            {
                randomList.Add(random.Next(100));
            }

            for (int i = 0; i < 100; i++)
            {
                root = bst.InsertNode(root, randomList[i]);
            }

           Node newNode = bst.InsertNode(root, 25);

           List <string> nodePath = bst.Search(root, 25);
            
           Console.WriteLine(nodePath);
        }
    }
}
