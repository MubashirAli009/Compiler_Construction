using System;

namespace MiniCCompiler
{
    public class LexicalAnalyzer
    {
        private static Node first = null; // Correctly tracks the start of the symbol table

        public class Node
        {
            public string Name { get; set; }
            public ValueType Val { get; private set; }
            public int Dtype { get; set; }
            public Node Link { get; set; }

            public Node(string name)
            {
                Name = name;
                Val = new ValueType();
                Dtype = -1;
                Link = null;
            }

            public void SetValue(int i = 0, float f = 0f, char c = '\0')
            {
                Val = new ValueType { I = i, F = f, C = c }; // Reassign the struct
            }
        }

        public struct ValueType
        {
            public float F;
            public int I;
            public char C;
        }

        public static Node CheckSym(string vname)
        {
            Node ftp = first;
            Node rp = null;
            Node nnode;

            if (first == null)
            {
                // If the symbol table is empty, create the first node
                nnode = new Node(vname);
                Addsymbol(nnode);
                first = nnode;
                return nnode;
            }

            // Traverse the linked list to find the variable or add it if not found
            while (ftp != null)
            {
                if (vname.Equals(ftp.Name))
                {
                    return ftp; // Variable already exists
                }
                rp = ftp;
                ftp = ftp.Link;
            }

            // Add the new variable to the end of the list
            nnode = new Node(vname);
            rp.Link = nnode;
            return nnode;
        }

        public static void Addsymbol(Node node)
        {
            node.Dtype = -1; // Initialize with undefined datatype
            node.Link = null;
        }

        public static void AddFn0(Node node, int type, int val)
        {
            if (node.Dtype == -1)
            {
                node.Dtype = type;
                node.SetValue(i: val); // Set integer value
            }
            else
            {
                Console.WriteLine($"Redeclaration of variable {node.Name}");
            }
        }

        public static void AddFn1(Node node, int type, float val)
        {
            if (node.Dtype == -1)
            {
                node.Dtype = type;
                node.SetValue(f: val); // Set float value
            }
            else
            {
                Console.WriteLine($"Redeclaration of variable {node.Name}");
            }
        }

        public static void AddFn2(Node node, int type, char val)
        {
            if (node.Dtype == -1)
            {
                node.Dtype = type;
                node.SetValue(c: val); // Set char value
            }
            else
            {
                Console.WriteLine($"Redeclaration of variable {node.Name}");
            }
        }

        public static void PrintSymTable()
        {
            Node ftp = first;

            if (ftp == null)
            {
                Console.WriteLine("\nSymbol Table is empty.");
                return;
            }

            Console.WriteLine("\n\nSymbol Table:");
            while (ftp != null)
            {
                Console.Write($"Name: {ftp.Name}\tDatatype: {ftp.Dtype}\t");
                if (ftp.Dtype == 0)
                    Console.WriteLine($"Value: {ftp.Val.I}");
                else if (ftp.Dtype == 1)
                    Console.WriteLine($"Value: {ftp.Val.F}");
                else if (ftp.Dtype == 2)
                    Console.WriteLine($"Value: {ftp.Val.C}");
                else
                    Console.WriteLine("Value: Undefined");
                ftp = ftp.Link;
            }
        }
    }
}
