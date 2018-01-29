using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szyfrowanie
{
    class Text
    {
        public String text;
        public String encryptedText;
        public String fileName;
        public String filePath;

        public void setFileName()
        {
            int lastSplash = this.filePath.LastIndexOf("\\");
            this.fileName = this.filePath.Substring(lastSplash + 1, this.filePath.Length - lastSplash - 1);
        }

        public void readTextFile()
        {
            List<string> textArray = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader(this.filePath))
                {
                    string verse;
                    while ((verse = sr.ReadLine()) != null)
                    {
                        textArray.Add(verse);
                        textArray.Add(Environment.NewLine);
                    }
                }
                this.text = string.Join("", textArray);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd odczytu pliku: " + this.filePath + " " + ex.Message);
            }
        }

        public void SaveToTextFile(String destinationName)
        {
            String[] encryptedTextArray = new String[] { this.encryptedText };
            using (StreamWriter sw = new StreamWriter(destinationName))
            {
                foreach (string verse in encryptedTextArray) sw.Write(verse);
            }
        }

        public void SaveKey(String destinationName, char[] keyValues)
        {
            using (StreamWriter sw = new StreamWriter(destinationName))
            {
                foreach (char ch in keyValues)
                {
                    sw.Write(ch);
                }
            }
        }

        public char SimpleDecypherLetter(char ch, List<char> list)
        {
            char d = char.IsUpper(ch) ? 'A' : 'a';
            if (!char.IsLetter(ch)) return ch;
            else
            {
                if (list.IndexOf(ch) > 25) return (char)(list.IndexOf(ch) + 39);

                else return (char)(list.IndexOf(ch) + 97);
            }
        }

        public char AdvanceDecypherLetter(string ch, List<string> list)
        {
            char result = 'a';

            for(int i = 0; i < list.Count(); i++)
            {
                string temp = list[i];
                switch(temp.Length)
                {
                    case 2:
                        {
                            if (temp.Contains(ch))
                                result = (char)(i + 97);
                            break;
                        }
                    case 4:
                        {
                            string temp1 = temp.Substring(0, 2);
                            string temp2 = temp.Substring(2);
                            if (temp1.Contains(ch) || temp2.Contains(ch))
                                result = (char)(i + 97);
                            break;
                        }
                    case 6:
                        {
                            string temp1 = temp.Substring(0,2);
                            string temp2 = temp.Substring(2, 2);
                            string temp3 = temp.Substring(4);
                            if (temp1.Contains(ch) || temp2.Contains(ch) || temp3.Contains(ch))
                                result = (char)(i + 97);
                            break;
                        }
                    case 8:
                        {
                            string temp1 = temp.Substring(0, 2);
                            string temp2 = temp.Substring(2, 2);
                            string temp3 = temp.Substring(4, 2);
                            string temp4 = temp.Substring(6);
                            if (temp1.Contains(ch) || temp2.Contains(ch) || temp3.Contains(ch) || temp4.Contains(ch))
                                result = (char)(i + 97);
                            break;
                        }
                }
            }
            return result;
        }

        public void SimpleDecypher(List<char> list)
        {
            string input = this.text;
            string output = string.Empty;
            try
            {
                foreach (char ch in input)
                {
                     output += SimpleDecypherLetter(ch, list);
                }
                this.encryptedText = output;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: nie wybrano pliku, lub plik jest nieprawidłowy.");
            }
        }

        public void AdvanceDecypher(List<string> list)
        {
            string input = this.text;
            string output = string.Empty;
            string stringToEncrypt = "";

            try
            {
                foreach (char ch in input)
                {
                    if (!Char.IsDigit(ch))
                    {
                        output += ch;
                    }
                    else
                    {
                        stringToEncrypt += ch;
                        if (stringToEncrypt.Length == 2)
                        {
                            output += AdvanceDecypherLetter(stringToEncrypt, list);
                            stringToEncrypt = "";
                        }
                    }
                }
                this.encryptedText = output;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: nie wybrano pliku, lub plik jest nieprawidłowy.");
            }
        }
    }
}
