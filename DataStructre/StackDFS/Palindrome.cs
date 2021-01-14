using System;
using System.Collections.Generic;

namespace DataStructure.StackDFS
{
    internal class Palindrome
    {
        static int IsPalindrome(char[] str)
        {
            int length = str.Length;
            Stack<char> stack = new Stack<char>();

            int i, mid = length / 2;

            for (i = 0; i < mid; i++)
                stack.Push(str[i]);


            // Checking if the length of the String 
            // is odd, if odd then neglect the 
            // middle character 
            if (length % 2 != 0)
            {
                i++;
            }

            // While not the end of the String 
            while (i < length)
            {
                char ele = stack.Pop();
                if (ele != str[i])
                    return 0;
                i++;
            }
            return 1;
        }

        public static void Main1(String[] args)
        {
            char[] str = "madam".ToCharArray();

            Console.Write(IsPalindrome(str) == 1 ? "Yes" : "No");
        }
    }
}