//https://leetcode.com/problems/implement-trie-prefix-tree/

namespace CSharp.Logic
{
    public class TrieNode
    {
        public static int ALPHABET_SIZE = 26;

        public TrieNode[] Children = new TrieNode[ALPHABET_SIZE];

        public bool IsEndOfWord;
        public TrieNode()
        {
            IsEndOfWord = false;
            for (int i = 0; i < ALPHABET_SIZE; i++)
                Children[i] = null;
        }
    }

    public class TriesAction
    {
        readonly TrieNode _root;

        public TriesAction()
        {
            _root = new TrieNode();
        }
        public void Insert(string key)
        {
            TrieNode temp = _root;

            foreach (var t in key)
            {
                var charIndex = t - 'a';
                if (temp.Children[charIndex] == null)
                    temp.Children[charIndex] = new TrieNode();

                temp = temp.Children[charIndex];
            }

            temp.IsEndOfWord = true;
        }

        public bool Search(string key)
        {
            TrieNode temp = _root;

            string res = string.Empty;
            foreach (var t in key)
            {
                var charIndex = t - 'a';
                if (temp.Children[charIndex] == null)
                    return false;

                temp = temp.Children[charIndex];
            }

            if (temp == null)
                return false;

            return temp.IsEndOfWord;


        }

        public bool StartsWith(string key)
        {
            TrieNode temp = _root;

            string res = string.Empty;
            foreach (var t in key)
            {
                var charIndex = t - 'a';
                if (temp.Children[charIndex] == null)
                    return false;

                temp = temp.Children[charIndex];
            }

            if (temp == null)
                return false;
            return true;
        }
    }
}
