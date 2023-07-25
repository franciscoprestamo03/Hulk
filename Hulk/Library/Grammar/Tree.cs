namespace Hulk.Library.Grammar
{
    internal class Tree
    {
        public Token Root { get; }
        public Token EndOfFileToken { get; }

        public Tree(Token root, Token endOfFileToken)
        {
            EndOfFileToken = endOfFileToken;
            Root = root;
        }

        
        public static Tree Parse(string text)
        {
            var parser = new Parser(text);
            return parser.Parse();
        }

    }
}