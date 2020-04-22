using System;
using System.Collections.Generic;
using System.Text;

namespace algorithms
{
    public class StringAlgorithms
    {
        public bool isValidParanthesis(string input)
        {
            HashSet<char> openChars = new HashSet<char> { '{', '[', '(' };
            Dictionary<char, char> closeChars = new Dictionary<char, char>();
            closeChars.Add('}', '{');
            closeChars.Add(']', '[');
            closeChars.Add(')', '(');
            Stack<char> inpStr = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                if(openChars.Contains(input[i]))
                {
                    inpStr.Push(input[i]);
                }
                else if(closeChars.ContainsKey(input[i]))
                {
                    if (inpStr.Count != 0)
                    {
                        if (inpStr.Peek() == closeChars[input[i]])
                        {
                            inpStr.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return (inpStr.Count == 0) ? true : false;
        }
    }
}
