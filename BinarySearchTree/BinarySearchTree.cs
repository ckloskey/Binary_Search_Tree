using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node()
        {
            val = 0;
            left = null;
            right = null;
        }

        public int Val
        {
            get
            {
                return val;
            }
            set
            {
                val = value;
            }
        }
        public Node Left
        {
            get
            {
                return left;
            }
            set
            {
                left = value;
            }
        }
        public Node Right
        {
            get
            {
                return right;
            }
            set
            {
                right = value;
            }
        }
    }
    class BinarySearchTree
    {
        List<string> nodePath;

        public BinarySearchTree()
        {
            nodePath = new List<string>();
        }
        public Node InsertNode(Node root, int value)
        {
            if (root == null)
            {
                root = new Node();
                root.val = value;
            }else if(value < root.val)
            {
                root.left = InsertNode(root.left, value);
            }
            else
            {
                root.right = InsertNode(root.right, value);
            }
            return root;
        }

        
        public List<string> Search(Node root, int value)
        {
            if (root == null)
            {
                nodePath.Add("Value does not exist in Tree");
            }else
            {
                if (value == root.val)
                {
                    if (root.val == value)
                    {
                        nodePath.Add("Stop");
                    }
                    else
                    {

                    }
                }
                else if (value < root.val)
                {
                    nodePath.Add("Left");
                    Search(root.left, value);
                    
                }
                else
                {
                    nodePath.Add("Right");
                    Search(root.right, value);
                    
                }
                
            }
            return nodePath;
        }
    }
}
