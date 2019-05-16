using System.Collections.Generic;
using System.Linq;

namespace Main.Other.Hierarchy
{
    public class Hierarchy
    {
        private IEnumerable<Person> people = new List<Person>();
        private List<Node> nodes = new List<Node>();

        public Hierarchy(IEnumerable<Person> ppl)
        {
            people = ppl;
        }

        public IEnumerable<Node> GetHierarchy()
        {
            InitializeNodes();
            SetParentAndChildren();

            List<Node> result = new List<Node>();
            Node masterNode = nodes.First(x => x.Parent == null);
            result.Add(masterNode);
            Node.GetChildren(masterNode, ref result);
            return result;
        }

        private void InitializeNodes()
        {
            foreach (Person item in people)
            {
                nodes.Add(new Node(item));
            }
        }

        private void SetParentAndChildren()
        {
            foreach (Node item in nodes)
            {
                Node parent = nodes.Where(x => x.Value.Id == item.Value.ParentId).FirstOrDefault();
                item.Parent = parent;

                IEnumerable<Node> children = nodes
                    .Where(x => x.Value.ParentId == item.Value.Id)
                    .Select(x => x)
                    .OrderBy(x => x.Value.Id);

                item.Children = children;
            }
        }
    }
}
