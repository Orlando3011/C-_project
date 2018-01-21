using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szyfrowanie
{
    class SubstitutionCypher: Cypher
    {
        List<char> cypherKey;

        public SubstitutionCypher(string initialText, List<char> cypherKey)
        {
            this.initialText = initialText;
            this.cypherKey = cypherKey;
        }

        private char EncryptLetter(char ch)
        {
            int charASCII = (int)ch;

            if (charASCII >= 65 && charASCII <= 90)
                return this.cypherKey[charASCII - 39];
            else if (charASCII >= 97 && charASCII <= 122)
                return this.cypherKey[charASCII - 97];
            else
                return ch;
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
                return null;
            }
        }
    }
}
