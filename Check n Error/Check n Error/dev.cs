using System;

namespace Check_n_Error
{
    internal class dev
    {
        private static void opCheck()
        {
        operatorCheck:
            try
            {
                Console.Write("Enter an Expression: ");
                string x = Console.ReadLine();
                char[] exp = x.ToCharArray();         // convert string to char array
                int expLength = exp.Length;         // length of char

                Console.Write("\n\t Operators found in the Expression: ");
                for (int i = 0; i < expLength; i++)
                {
                    if ((exp[i] == '+') || (exp[i] == '-') || (exp[i] == '*') || (exp[i] == '/'))
                    {
                        Console.Write(exp[i] + " ");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                goto operatorCheck;
            }
            finally
            {
                Console.WriteLine("\n\t\t OVER n OUT \n");
            }
        }

        private static void statementErrCheck()
        {
            bool flag1 = false;
            bool flag2 = false;
            bool flagSemi = false;

            Console.Write("Enter an Statement: ");
            string x = Console.ReadLine();
            char[] exp = x.ToCharArray();
            int expLength = exp.Length;

            for (int i = 0; i < expLength; i++)
            {
                if ((exp[i] == '('))
                    flag1 = true;
                else if ((exp[i] == ')'))
                    flag2 = true;
                if (exp[expLength - 1] == ';')
                    flagSemi = true;
            }
            if (flag1 && flag2 && flagSemi)
                Console.Write("\t Statement is valid.");
            else if (!flag1 && flag2 && flagSemi)
                Console.Write("\t Statement is invalid. '(' is missing.");
            else if (flag1 && !flag2 && flagSemi)
                Console.Write("\t Statement is invalid. ')' is missing.");
            else if (flag1 && flag2 && !flagSemi)
                Console.Write("\t Syntax Error. (;) missing");
            else if (!flag1 && flag2 && !flagSemi)
                Console.Write("\t Statement is invalid. '(' missing. (;) expected");
            else if (flag1 && !flag2 && !flagSemi)
                Console.Write("\t Statement is invalid. ')' missing. (;) expected");
            else if (!flag1 && !flag2 && flagSemi)
                Console.Write("\t Statement is valid.");
            else if (!flag1 && !flag2 && !flagSemi)
                Console.Write("\t Syntax Error. (;) missing");
            else
                Console.Write("Invalid Statement");
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("\nCheck operators used in the expression \n");
            opCheck();
            Console.WriteLine("\n\nCheck if parenthesis ( ) or ; missing in the statement \n");
            statementErrCheck();
            Console.Write("\n\n");
        }
    }
}