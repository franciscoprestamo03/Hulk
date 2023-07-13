using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hulk.Library.Grammar
{
    internal class Token:Node
    {
        public override SyntaxType Type { get; }
        public object? Value { get; }

        public Token(SyntaxType type, object? value){
            Value = value;
            Type = type;
        }

        public override IEnumerable<Node> GetChild()
        {
            return Enumerable.Empty<Node>();
        }
    }
}