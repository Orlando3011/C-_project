using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szyfrowanie
{
    class PolygraphicCypher: Cypher
    {
        List<String> cypherKey;

        public PolygraphicCypher(string initialText, List<String> cypherKey)
        {
            this.initialText = initialText;
            this.cypherKey = cypherKey;
        }

        private String EncryptLetter(char ch)
        {
            int charASCII = (int)ch;

            if (charASCII >= 65 && charASCII <= 90)
                return this.cypherKey[charASCII - 39];

            else if (charASCII >= 97 && charASCII <= 122)
                return this.cypherKey[charASCII - 97];

            else
                return ch.ToString();
        }

        public string SubstitutionEncypher()
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

    }
}
