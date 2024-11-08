using System;
using System.Collections;
namespace CollectionsApplication
{
    class Program
    {
        static void Main(string[] args)
        { 
        
        Stack stack = new Stack();
            stack.Push('A');
            stack.Push('M');
            stack.Push('G');
            stack.Push('W');

            Console.WriteLine("Current stack: ");
            foreach(char item in stack) {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            stack.Push('V');
            stack.Push('H');
            Console.WriteLine("The next poppable value in stack: {0}",
            stack.Peek());

            Console.WriteLine("Current stack: ");
            foreach (char c in stack)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Removing values ");
            stack.Pop();
            stack.Pop();
            stack.Pop();

            Console.WriteLine("Current stack: ");
            foreach (char c in stack)
            {
                Console.Write(c + " ");
            }

        }
    }
}