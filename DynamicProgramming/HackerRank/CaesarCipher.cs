using System.Text;

namespace DynamicProgramming.HackerRank
{
    public static class CaesarCipher
    {
        public static string caesarCipher(string s, int k)
        {
            if (k == 0)
                return s;

            var result = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]))
                {
                    char offset = char.IsUpper(s[i]) ? 'A' : 'a';
                    char c = (char)((((s[i] + k) - offset) % 26) + offset);
                    result.Append(c);
                }
                else
                    result.Append(s[i]);
            }

            return result.ToString();
        }
    }
}
