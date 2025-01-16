using System;

namespace MiniCCompiler
{
    class Program
    {
        static void Main(string[] _args)
        {
            Console.WriteLine("Mini-C Compiler\n");

            // Add entries to the symbol table
            var var1 = LexicalAnalyzer.CheckSym("x");
            LexicalAnalyzer.AddFn0(var1, 0, 10); // Adding int x = 10;

            var var2 = LexicalAnalyzer.CheckSym("y");
            LexicalAnalyzer.AddFn1(var2, 1, 3.14f); // Adding float y = 3.14;

            var var3 = LexicalAnalyzer.CheckSym("z");
            LexicalAnalyzer.AddFn2(var3, 2, 'c'); // Adding char z = 'c';

            // Print the symbol table
            LexicalAnalyzer.PrintSymTable();

            Console.WriteLine("\nTesting Syntax Analyzer:");
            SyntaxAnalyzer.Analyze("int main() { int x = 10; }");

            Console.WriteLine("\nProgram execution completed.");
        }
    }
}
