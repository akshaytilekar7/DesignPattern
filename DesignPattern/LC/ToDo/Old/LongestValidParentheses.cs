using System;
using System.Linq;

namespace CSharp.Logic
{
    public class Solution
    {
        public int FindComplement(int num)
        {
            string binary = Convert.ToString(num, 2);
            string res = "";
            foreach (var item in binary)
            {
                if (item == '0')
                {
                    res = res + '1';
                }
                else
                {
                    res = res + '0';
                }
            }
            return Convert.ToInt32(res, 2);
        }
        public int CalculateLcs(string x, string y, int i, int j)
        {
            if (i == 0 || j == 0)
                return 0;

            if (x[i - 1] == y[j - 1])
                return 1 + CalculateLcs(x, y, i - 1, j - 1);

            return Math.Max(
                CalculateLcs(x, y, i - 1, j), CalculateLcs(x, y, i, j - 1)
            );
        }
        public bool CanConstruct(string ransomNote, string magazine)
        {
            var s = ransomNote.ToCharArray();
            var src = magazine.ToCharArray();

            for (int i = 0; i < s.Length; i++)
            {
                var item = s[i];
                if (src.Any(x => x == item))
                {
                    int index = Array.IndexOf(src, item);
                    if (index != -1)
                    {
                        src[index] = ' ';
                        s[i] = ' ';
                    }
                }
            }
            if (s.Any(x => x != ' '))
                return false;
            return true;
        }
    }

}
