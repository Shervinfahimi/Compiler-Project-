using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiler_project
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] keywords = { "switch", "abstract", "as", "base", "if", "else", "foreach","while","break","continue",
                                   "for","enum","namespace","stackalloc","static","base","explicit","new","string","extern",
                                   "null","struct","false","object","byte","finally","operator","this","case","fixed","out","throw",
                                   "catch","override","true","for","params","try","tey","checked","private","lock",
                                   "typeof","class","goto","protected","const","if","public","implicit","readonly","unchecked",
                                   "in","ref","unsafe","default","return","delegate","interface","using","do","internal","sealed",
                                   "virtual","is","void"};

            string[] arithmeticOperators = { "+", "-", "*", "/", "%", "++", "--" };

            string[] assignmentOperators = { "=", "+=", "*=", "/=", "%=", "&=", "|=", "^=", ">>=", "<<=" };

            string[] comparisonOperators = { "==", "!=", ">", "<", ">=", "<=" };

            string[] logicalOperators = { "&&", "||", "!" };

            string[] bitwiseOperators = { "&", "|", "^", "~", ">>", "<<" };

            string[] variablesTypes = { "int","bool","char","double","long","string","float","uint","ulong","byte","sbyte","decimal","short","ushort"};

            string[] anotherOprators = {"{}","()","[]",",","?","sizeof" };


        a:  Console.Write("Type somthing: ");
            string st;
            st = Console.ReadLine(); 
            string[] namestring = st.Split(' ');
            
            for (int i = 0; i < namestring.Length; i++)
            {

                var search1 = Array.Find(keywords, element => element == namestring[i]);
                var search2 = Array.Find(arithmeticOperators, element => element == namestring[i]);
                var search3 = Array.Find(assignmentOperators, element => element == namestring[i]);
                var search4 = Array.Find(comparisonOperators, element => element == namestring[i]);
                var search5 = Array.Find(logicalOperators, element => element == namestring[i]);
                var search6 = Array.Find(bitwiseOperators, element => element == namestring[i]);
                var search7 = Array.Find(anotherOprators, element => element == namestring[i]);
                var search8 = Array.Find(variablesTypes, element => element == namestring[i]);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                if (namestring[i] == search1)
                    Console.WriteLine("( " + namestring[i] + " )" + " is a Keyword  ");

                else if (namestring[i] == search2)
                    Console.WriteLine("( " + namestring[i] + " )" + " is an Arithmetic Operator");

                else if (namestring[i] == search3)
                    Console.WriteLine("( " + namestring[i] + " )" + " is an Assignment Operator");

                else if (namestring[i] == search4)
                    Console.WriteLine("( " + namestring[i] + " )" + " is a Comparison Operator");

                else if (namestring[i] == search5)
                    Console.WriteLine("( " + namestring[i] + " )" + " is a Logical Operator");

                else if (namestring[i] == search5)
                    Console.WriteLine("( " + namestring[i] + " )" + " is a Logical Operator");

                else if (namestring[i] == search6)
                    Console.WriteLine("( " + namestring[i] + " )" + " is a Bitwise Operator");

                else if (namestring[i] == search7)
                    Console.WriteLine("( " + namestring[i] + " )" + " is an Operator");

                else if (namestring[i] == search8)
                    Console.WriteLine("( " + namestring[i] + " )" + " is a Variable Type");

                else
                    Console.WriteLine("( " + namestring[i] + " )" + " is a Simple String or Number");
                 
            };
            Console.WriteLine();
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Do you want to test again?(Y/N)");
            char YN = Convert.ToChar(Console.ReadLine());
            if (YN == 'Y' | YN == 'y')
            {
                Console.Clear();
                goto a;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.Write("Press Enter to quit...");
            }
            Console.ReadKey();
        }
    }
}