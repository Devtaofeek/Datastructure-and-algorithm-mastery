using System;
using System.Collections.Generic;
using System.Text;

namespace GsPractice
{
  public  class Interdsaprac
    {
       

        public int Reverseanumber(int number)
        {
            var numstring = number.ToString();
            var chararray = numstring.ToCharArray();
            Stack<char> stack = new Stack<char>();
          
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in chararray)
            {
                stack.Push(item);
            }

            while (stack.Count != 0)
            {
                stringBuilder.Append(stack.Peek());
                stack.Pop();
            }
             
            
            var ss = stringBuilder.ToString();

            return int.Parse(ss);

            
        }

        public int reversed(int number)
        {
            //1025
            int rev = 0;
            while (number != 0)
            {
                int digit = number % 10;
                rev = rev * 10 + digit;
                number /= 10;
            }
            return rev;
        }

        public int factorialwithloop(int n)
        {
            if (n < 0)
            {
                Console.WriteLine("Negative number cannot have factorial");
                return -999;
            }
            int fact = 1;
            for (int i = 2; i <= n; i++)
            {
                fact *= i;
            }
            return fact;

        }

        public int factorialrecursion(int n)
        {
            if (n < 0)
            {
                Console.WriteLine("Negative number cannot have factorial");
                return -999;
            }

            if (n <= 2)
            {
                return n;
            }
            var ss = factorialrecursion(n - 1);
            return n * ss;
        }
    }
}
