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

        public void SaveWithKey(String destinationName, String keyValues)
        {
            string[] textAndKey = new string[3];
            textAndKey[0] = this.encryptedText;
            textAndKey[1] = "\r\n\r\n----------------------\r\n\r\nSzyfr użyty do zakodowania:\r\n";
            textAndKey[2] = keyValues;
            using (StreamWriter sw = new StreamWriter(destinationName))
            {
                foreach (string verse in textAndKey) sw.Write(verse);
            }
        }
    }
}
