namespace Hulk.Library.Grammar
{
    public enum SyntaxType
    {
        NumberToken,
        WhitespaceToken,
        AdditionToken,
        SubtractionToken,
        MultiplicationToken,
        DivisionToken,
        OpenParenthesisToken,
        CloseParenthesisToken,
        ErrorToken,
        EndOfFileToken,

        //Expressions
        
        NumericalExpression,
        BinaryExpression,
        ParenthesizedExpression
    }
}