using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Sample.Models
{
    public class NodeChain
    {
        private (Node, Node, Node, Node) _nodes;
        public (Node, Node, Node, Node) Nodes
        {
            get { return _nodes; }
            set { _nodes = value; }
        }
    }
}
