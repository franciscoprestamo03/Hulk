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

        private char Current{get => LineText[position];}

        private void Next(){
            position++;
        }

        public Token NextToken(){

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

            if (Current == '+')
                return new Token(SyntaxType.AdditionToken, null);
            else if (Current == '-')
                return new Token(SyntaxType.SubtractionToken,  null);
            else if (Current == '*')
                return new Token(SyntaxType.MultiplicationToken,  null);
            else if (Current == '/')
                return new Token(SyntaxType.DivisionToken, null);
            else if (Current == '(')
                return new Token(SyntaxType.OpenParenthesisToken,  null);
            else if (Current == ')')
                return new Token(SyntaxType.CloseParenthesisToken, null);

            return new Token(SyntaxType.ErrorToken,null);
            
        }
    }
}