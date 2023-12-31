﻿using System;
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
            //Tree myTree = new Tree(new TreeNode(100));

            //TreeNode child1 = new TreeNode(50);
            //TreeNode child2 = new TreeNode(1);
            //TreeNode child3 = new TreeNode(150);
            //child1.parent = myTree.root; 
            //child2.parent = myTree.root;
            //child3.parent = myTree.root;

            //myTree.root.children.Add(child1);
            //myTree.root.children.Add(child2);
            //myTree.root.children.Add(child3);

           

            //TreeNode child4 = new TreeNode(70);
            //TreeNode child5 = new TreeNode(61);
            //child4.parent = child2;
            //child5.parent = child2;

            //child2.children.Add(child4);
            //child2.children.Add(child5);
            #endregion

            Tree brownTree = new Tree(new TreeNode(7,null));

            brownTree.root.addChild(5);
            brownTree.root.addChild(8);

            brownTree.root.children[0].addChild(2);
            brownTree.root.children[0].addChild(3);
            brownTree.root.children[0].addChild(1);

            brownTree.root.children[1].addChild(10);
            brownTree.root.children[1].addChild(12);


            brownTree.root.children[0].children[0].addChild(13);
            brownTree.root.children[0].children[0].addChild(16);
         


            foreach (TreeNode item in brownTree.root.children)
            {
                Console.WriteLine(item);
                if (item.children.Count > 0)
                {
                    foreach (TreeNode item1 in item.children)
                    {
                        Console.WriteLine("\t" + item1);

                        if (item1.children.Count>0)
                        {
                            foreach (TreeNode item2 in item1.children)
                            {
                                Console.WriteLine("\t\t" + item2);
                            }
                        }
                    }
                }
            }
            Console.WriteLine("R"  );
            PrintTreeRecursive(brownTree.root,0);

        }

        public static void PrintTreeRecursive(TreeNode node, int level)
        {
            if (node == null)
            {
                return;
            }

            if (node.parent != null)
            {
                Console.WriteLine(new string('\t', level) + node);
            }
            else
            {
                Console.WriteLine("Root"+ node.data);
            }

            //foreach (TreeNode child in node.children)
            //{
            //    PrintTreeRecursive(child, level + 1);
            //}

            node.children.ForEach(x => PrintTreeRecursive(x, level + 1));
        }


    }
}
