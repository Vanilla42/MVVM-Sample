using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Sample.Models
{
    public class Chain
    {
        private ushort _id;
        public ushort Id
        {
            get { return _id; }
            private set { _id = value; }
        }

        private (Node, Node, Node, Node) _nodes;
        public (Node, Node, Node, Node) Nodes
        {
            get { return _nodes; }
            private set { _nodes = value; }
        }

        public Chain (Node node0, Node node1, Node node2, Node node3, ushort id)
        {
            Id = id;
            Nodes = (node0, node1, node2, node3);
        }
    }
}
