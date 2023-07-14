using Hulk.Library.Grammar;

internal class Program
{
    private static void Main(string[] args)
    {
        while (true){
            string? line = Console.ReadLine();
            
            if(string.IsNullOrWhiteSpace(line)){
                continue;
            }

            var lexer = new Lexer(line);
            Token token;
            do{
                token = lexer.Lex();
                System.Console.WriteLine(token.Type);
                
            }while(token.Type != SyntaxType.EndOfFileToken);

            

        }
    }
}