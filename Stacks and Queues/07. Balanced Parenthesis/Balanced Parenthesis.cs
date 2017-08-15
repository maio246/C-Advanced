namespace _07.Balanced_Parenthesis
{
    using System;
    using System.Collections.Generic;

    public class Balanced_Parenthesis
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var opened = new Stack<int>();

            var isBalanced = false;

            if (inputLine.Length % 2 == 0)
            {

                for (int i = 0; i < inputLine.Length; i++)
                {
                    var currChar = (int)inputLine[i];


                    if (currChar == 40 ||
                        currChar == 123 ||
                        currChar == 91)
                    {
                        opened.Push(currChar);
                    }
                    else if (currChar == 41 ||
                             currChar == 125 ||
                             currChar == 93)
                    {
                        var charToCompare = opened.Peek();

                        var asd = Math.Abs(charToCompare - currChar);

                        if (asd == 1 || asd == 2)
                        {
                            isBalanced = true;
                            opened.Pop();
                        }
                        else
                        {
                            isBalanced = false;
                            break;
                        }
                    }
                }
            }
            if (isBalanced) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}