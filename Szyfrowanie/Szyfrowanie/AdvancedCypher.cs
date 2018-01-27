using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szyfrowanie
{
    class AdvancedCypher: Cypher
    {

        List<string> cypherKey;

        public AdvancedCypher(string initialText, List<string> cypherKey)
        {
            this.initialText = initialText;
            this.cypherKey = cypherKey;
        }

        private string EncryptLetter(char ch)
        {
            Random rand = new Random();
            string possibleSigns;
            string chosenSigns = "";
            int charASCII = (int)ch;
            int randomNumber;

            if (charASCII >= 65 && charASCII <= 90)
            {
                possibleSigns = this.cypherKey[charASCII - 65];
                randomNumber = rand.Next(1, (possibleSigns.Length / 2));
                chosenSigns = "" + possibleSigns[(randomNumber*2) - 2] + possibleSigns[(randomNumber*2) -1];
                return chosenSigns;
            }
                
            else if (charASCII >= 97 && charASCII <= 122)
            {
                possibleSigns = this.cypherKey[charASCII - 97];
                randomNumber = rand.Next(1, (possibleSigns.Length / 2));
                chosenSigns = "" + possibleSigns[(randomNumber*2) - 2] + possibleSigns[randomNumber*2 - 1];
                return chosenSigns;
            }
                
            else
                return ch.ToString();
        }

        public string AdvancedEncypher()
        {
            Random rand = new Random();
            int random;
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
