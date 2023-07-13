using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hulk.Library.Grammar
{
    abstract class Node
    {
        public abstract SyntaxType Type { get; }
        public abstract IEnumerable<Node> GetChild();
    }
}