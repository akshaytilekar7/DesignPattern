using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CSharp.Logic
{
    public class WordBreak1
    {
        public bool[] T;
        public bool WordBreak(string s, IList<string> wordDict)
        {
            T = new bool[wordDict.Count + 2];
            return Check(s, wordDict.ToArray(), wordDict.Count, T);
        }

        public bool Check(string s, string[] arr, int n, bool[] T)
        {
            if (string.IsNullOrEmpty(s) || ContainOnlyDash(s))
                return true;

            if (n <= 0 && !string.IsNullOrEmpty(s))
                return false;

            var res1 = false;
            var res2 = false;
            var subStr = arr[n - 1];
            if (T[n] == true)
            {
                return T[n];
            }
            if (IsSubstringExist(s, subStr))
            {
                Regex regex = new Regex(subStr);
                string result = regex.Replace(s, "-", 1);

                res1 = T[n] = (Check(result, arr, n, T) ||
                           Check(s, arr, n - 1, T));
            }
            else
            {
                res2 = T[n] = Check(s, arr, n - 1, T);
            }

            return res1 || res2;
        }

        private bool ContainOnlyDash(string s)
        {
            foreach (var ch in s)
            {
                if (ch != '-')
                    return false;
            }

            return true;
        }

        private bool IsSubstringExist(string s, string sub)
        {
            return s.Contains(sub);
        }
    }
}
