using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace GsPractice
{
 public   class Stack
    {
        public string ReverseaString(string input)
        {
            Stack<char> stacks = new Stack<char>();
            char[] characters = input.ToCharArray();
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in characters)
            {
                stacks.Push(item);
            }
            var count = stacks.Count;
            while (stacks.Count > 0)
            {
                stringBuilder.Append(stacks.Pop());
            }
            return stringBuilder.ToString();
        }

        public int umbrella(int size, int[] unbrellas)
        {
            int num = 0;
            int rem = 0;
            foreach (var item in unbrellas)
            {
                if (size >= item)
                {
                    if (size % item == 0)
                    {
                        num = size / item;
                    }
                    else
                    {
                        rem = size % item;

                    }
                }
                else
                {
                    num = -1;
                }
               
            }
            return num;
        }
        public bool IsExpressionBalanced(string input)
        {
            var expression = input.ToCharArray();
            Stack<char> stacks = new Stack<char>();
            foreach (var item in expression)
            {
                if (item == '(')
                {
                    if (stacks.Count < 1) return false;
                    stacks.Push(item);
                }

                if (item == ')')
                {
                    if (stacks.Count < 1) return false;
                    stacks.Pop();
                }
            }
            return !(stacks.Count > 0);
        }

        public bool BalancedExpression(string expression)
        {
            var chaarray = expression.ToCharArray();
            Stack<char> characters = new Stack<char>();
            foreach (var item in chaarray)
            {
                if (item == '(' || item == '<' || item == '[' || item == '{')
                {
                    characters.Push(item);
                }

                if (item == ')' || item == '>' || item == ']' || item == '}')
                {

                    if (characters.Count < 1) return false;

                    var top = characters.Pop();
                    if ((item == ')' && top != '(') || (item == '>' && top != '<') || (item == ']' && top != '[') || (item == '}' && top != '{'))
                    {
                        return false;
                    }

                }
            }
            return characters.Count == 0;
        }
    }
}
