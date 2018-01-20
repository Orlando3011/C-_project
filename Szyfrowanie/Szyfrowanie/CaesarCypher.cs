using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szyfrowanie
{
    class CaesarCypher : Cypher
    {
        int key;
        public CaesarCypher(string initialText, int key)
        {
            this.initialText = initialText;
            this.key = key;
        }

        char EncryptLetter(char ch)
        {
            if (!char.IsLetter(ch))
            {
                return ch;
            }
            else
            {
                char d = char.IsUpper(ch) ? 'A' : 'a';
                if (((ch + this.key) - d) < 0)
                {
                    return (char)((((ch + this.key) - d) % 26) + d + 26);
                }
                else
                {
                    return (char)((((ch + this.key) - d) % 26) + d);
                }
            }
        }

        public string CaesarEncypher()
        {
            string output = string.Empty;

            try
            {
                foreach (char ch in this.initialText) output += EncryptLetter(ch);
                return output;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: nie wybrano pliku, lub plik jest nieprawidłowy.");
                return null;
            }
        }

        public List<char> CreateKeyList()
        {
            List<char> list = new List<char>();
            char d;

            for (char i = 'a'; i <= 'z'; i++)
            {
                d = 'a';
                if (((i + this.key) - d) < 0)
                    list.Add((char)((((i + this.key) - d) % 26) + d + 26));
                else
                    list.Add((char)(((((i + this.key)) - d) % 26) + d));
            }

            for (char i = 'A'; i <= 'Z'; i++)
            {
                d = 'A';
                if (((i + this.key) - d) < 0)
                    list.Add((char)((((i + this.key) - d) % 26) + d + 26));
                else
                    list.Add((char)(((((i + this.key)) - d) % 26) + d));
            }
            return list;
        }
    }
}
