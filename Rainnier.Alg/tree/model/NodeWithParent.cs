using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.tree.model
{
    class NodeWithParent
    {
        public int Data { get; set; }
        public NodeWithParent Left { get; set; }
        public NodeWithParent Right { get; set; }
        public NodeWithParent Parent { get; set; }

        public NodeWithParent(int data)
        {
            Data = data;
        }
    }
}
