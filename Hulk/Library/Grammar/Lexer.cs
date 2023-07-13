using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hulk.Library.Grammar
{
    internal class Lexer
    {
        public string LineText { get; }
        private int position;

        public Lexer(string lineText){
            LineText = lineText;
            position = 0;
        }

        private char Current
        {
            get
            {
                if (position >= LineText.Length)
                    return '\0';

                return LineText[position];
            }
        }

        private void Next(){
            position++;
        }

        public Token Lex(){

            if (position >= LineText.Length)
                return new Token(SyntaxType.EndOfFileToken, null);

            if (char.IsDigit(Current))
            {
                var start = position;

                while (char.IsDigit(Current))
                    Next();

                var length = position - start;
                var text = LineText.Substring(start, length);

                var value = int.Parse(text);

                return new Token(SyntaxType.NumberToken, value);
            }

            if (char.IsWhiteSpace(Current))
            {
                while (char.IsWhiteSpace(Current))
                    Next();

                return new Token(SyntaxType.WhitespaceToken, null);
            }
            var current = Current;
            Next();
            switch (current)
            {
                
                case '+':
                    return new Token(SyntaxType.AdditionToken, null);
                case '-':
                    return new Token(SyntaxType.SubtractionToken, null);
                case '*':
                    return new Token(SyntaxType.MultiplicationToken, null);
                case '/':
                    return new Token(SyntaxType.DivisionToken, null);
                case '(':
                    return new Token(SyntaxType.OpenParenthesisToken, null);
                case ')':
                    return new Token(SyntaxType.CloseParenthesisToken, null);
            }

            return new Token(SyntaxType.ErrorToken,null);
            
        }
    }
}