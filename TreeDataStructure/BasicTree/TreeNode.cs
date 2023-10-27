using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDataStructure.BasicTree
{
    internal class TreeNode
    {
        
        public int data { get; set; }
        public TreeNode parent { get; set; }
        public List<TreeNode> children { get; set; }

        public TreeNode(int data,TreeNode parent)
        {
            this.data = data;
            this.parent = parent;
            children = new();      
        }
        public void addChild(int value) {
        this.children.Add(new TreeNode(value,this));
        }
        public override string? ToString()
        {
            return $"Data child {data} parent: {parent.data} ";
        }


    }
}
