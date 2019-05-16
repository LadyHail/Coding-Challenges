using System.Collections.Generic;

namespace Main.Other.Hierarchy
{
    public class Node
    {
        public Person Value { get; set; }
        public Node Parent { get; set; }
        public IEnumerable<Node> Children { get; set; }
        public int depth;

        public Node(Person val)
        {
            Value = val;
            Children = new List<Node>();
        }

        public static void GetChildren(Node node, ref List<Node> nodes)
        {
            foreach (Node child in node.Children)
            {
                GetDepth(child, ref child.depth);
                nodes.Add(child);
                GetChildren(child, ref nodes);
            }
        }

        public static void GetDepth(Node node, ref int depth)
        {
            Node parent = node.Parent;
            if (parent != null)
            {
                depth++;
                GetDepth(parent, ref depth);
            }

        }
    }
}
