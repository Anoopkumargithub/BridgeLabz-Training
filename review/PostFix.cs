using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;

internal class PostFix
{
    public static void Main(String [] args)
    {
        // string Expression = "78+32*-";
        // string Expression = "53+82-*";
        string Expression = "13+2*2";
        int result = Sol(Expression);
        Console.WriteLine("Result: "+ result);
    }

    public static int Sol(String Expression)
    {
        Stack<int> stack = new Stack<int>();
        for(int i = 0; i < Expression.Length; i++)
        {
            char ch = Expression[i];

            if (IsDigit(ch))
            {
                stack.Push(ch - '0');
            }
            else
            {
                int val1 = stack.Pop();
                int val2 = stack.Pop();

                if(ch == '+')
                {
                    val2 += val1;
                }else if(ch == '-')
                {
                    val2 -= val1;
                }
                else if(ch == '*')
                {
                    val2 *= val1;
                }
                else
                {
                    val2 /= val1;
                }

                stack.Push(val2);

            }
        }
        return stack.Pop();
    }

    public static bool IsDigit(char ch)
    {
        int digit = ch - '0';
        for(int i = 0; i <= 9; i++)
        {
            if(digit == i)
            {
                return true;
            }
        }
        return false;
    }
}




