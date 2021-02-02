using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Logic
{
    public class StackProblemNearestGreaterToLeft
    {
        Stack<Data> s = new Stack<Data>();

        class Data
        {
            public int Index { get; set; }
            public int Value { get; set; }
        }

        public int[] NearestGreaterToLeft(int[] arr)
        {
            List<int> res = new List<int>();

            for (var index = 0; index < arr.Length; index++)
            {
                var item = arr[index];
                if (IsEmpty(s)) res.Add(1); // if empty add -1

                // jar top motha asel tr tech answer
                if (IsNotEmpty(s) && s.Peek().Value > item)
                    res.Add(index - s.Peek().Index);

                else if (IsNotEmpty(s) && s.Peek().Value < item)
                {
                    // jar top lahan asel tr mag pop until top laahan asel toparyant
                    while (IsNotEmpty(s) && s.Peek().Value < item)
                        s.Pop();

                    //NATAR answer if empty =>-1 else => top
                    if (IsEmpty(s))
                        res.Add(1);
                    else
                        res.Add(index - s.Peek().Index);
                }

                s.Push(new Data() { Value = item, Index = index }); // AT LAST ADD IN STACK
            }
            return res.ToArray();
        }

        private bool IsEmpty(Stack<Data> st) => !st.Any();
        private bool IsNotEmpty(Stack<Data> st) => st.Any();

        public static void Mainw(string[] args)
        {
            int[] arr = { 100, 80, 60, 70, 60, 75, 85 };
            int[] value = new StackProblemNearestGreaterToLeft().NearestGreaterToLeft(arr);
            foreach (int val in value)
            {
                Console.WriteLine(" " + val);
            }
        }
    }

}