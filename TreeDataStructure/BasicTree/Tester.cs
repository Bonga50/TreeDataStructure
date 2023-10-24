using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDataStructure.BasicTree
{
    internal class Tester
    {
        static void Main(string[] args)
        {
            #region Tree
            Tree myTree = new Tree(new TreeNode(100));

            TreeNode child1 = new TreeNode(50);
            TreeNode child2 = new TreeNode(1);
            TreeNode child3 = new TreeNode(150);
            child1.parent = myTree.root; 
            child2.parent = myTree.root;
            child3.parent = myTree.root;

            myTree.root.children.Add(child1);
            myTree.root.children.Add(child2);
            myTree.root.children.Add(child3);

           

            TreeNode child4 = new TreeNode(70);
            TreeNode child5 = new TreeNode(61);
            child4.parent = child2;
            child5.parent = child2;

            child2.children.Add(child4);
            child2.children.Add(child5);
            #endregion

            Tree brownTree = new Tree(new TreeNode(7));
            brownTree.root.children = new List<TreeNode>() { 
            
            };

            foreach (TreeNode item in myTree.root.children)
            {
                Console.WriteLine(item);
                if (item.children.Count > 0)
                {
                    foreach (var item1 in item.children)
                    {
                        Console.WriteLine("\t" + item1);
                    }
                }
            }

        }
    }
}
