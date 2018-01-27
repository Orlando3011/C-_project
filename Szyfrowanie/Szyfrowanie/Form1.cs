using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Szyfrowanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<char> caesarCypherKey = new List<char>();
        public List<char> substitutionCypherKey = new List<char>();
        public List<string> advancedCypherKey = new List<string>();
        Text loadedText = new Text();

        public static String ShowCharListContent(List<char> list)
        {
            try
            {
                string output = "";
                output = output + "----------------\r\nMałe litery:\r\n----------------\r\n";

                for (char i = 'a'; i <= 'z'; i++)
                {
                    output = output + i + " -> " + list[i - 'a'] + "\r\n";
                }

                output = output + "\r\n----------------\r\nDuże litery:\r\n----------------\r\n\r\n";

                for (char i = 'A'; i <= 'Z'; i++)
                {
                    output = output + i + " -> " + list[i - 'A' + 26] + "\r\n";
                }

                return output;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static String ShowStringListContent(List<string> list)
        {
            try
            {
                string output = "";

                for (char i = 'a'; i <= 'z'; i++)
                {
                    output = output + i + " -> " + list[i - 'a'] + "\r\n";
                }

                return output;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private void exitButton(object sender, EventArgs e)
        {
            Close();
        }

        private void loadFileButton(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                loadedText.filePath = openFileDialog1.FileName;
                loadedText.readTextFile();
                loadedText.setFileName();
                fileNameBox.Text = loadedText.fileName;
                originalTextBox.Text = loadedText.text;
            }
        }

        private void caesarCypherButton(object sender, EventArgs e)
        {
            caesarCypherKey.Clear();
            substitutionCypherKey.Clear();
            advancedCypherKey.Clear();
            CaesarCypher cCypher = new CaesarCypher(loadedText.text, Convert.ToInt32(numericUpDown1.Value));
            caesarCypherKey.AddRange(cCypher.CreateKeyList());
            loadedText.encryptedText = cCypher.CaesarEncypher();
            encryptedTextBox.Text = loadedText.encryptedText;
            keyTextBox.Text = "Szyfr Cezara\n\r\n\r" + ShowCharListContent(caesarCypherKey);
        }

        private void newSubstitutionCypherButton_Click(object sender, EventArgs e)
        {
            caesarCypherKey.Clear();
            substitutionCypherKey.Clear();
            advancedCypherKey.Clear();
            substitutionCipherForm form2 = new substitutionCipherForm();
            form2.Show();
            form2.Closed += (sender1, args) =>
            {
                try
                {
                    this.substitutionCypherKey.AddRange(form2.cypherList);
                    SubstitutionCypher sCypher = new SubstitutionCypher(loadedText.text, substitutionCypherKey);
                    loadedText.encryptedText = sCypher.SubstitutionEncypher();
                    encryptedTextBox.Text = loadedText.encryptedText;
                    keyTextBox.Text = "Prosty szyfr podstawieniowy\n\r\n\r" + ShowCharListContent(substitutionCypherKey);
                }
                catch(Exception ex)
                {
                }
            };
        }

        private void saveWithoutCypherButton_Click(object sender, EventArgs e)
        {
            string filename = openFileDialog1.FileName;
            if (filename.Length > 0) saveFileDialog1.FileName = filename;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog1.FileName;
                loadedText.SaveToTextFile(filename);
            }
        }

        private void saveWithCypherButton_Click(object sender, EventArgs e)
        {
            string filename = openFileDialog1.FileName;
            string c, s, a;
            c = "c" + String.Join("", caesarCypherKey);
            s = "s" + String.Join("", substitutionCypherKey);
            a = "a" + String.Join(",", advancedCypherKey);
            if (filename.Length > 0) saveFileDialog1.FileName = filename;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog1.FileName;
                if (caesarCypherKey.Count > 0)
                    loadedText.SaveKey(filename, c.ToCharArray());
                if (substitutionCypherKey.Count > 0)
                    loadedText.SaveKey(filename, s.ToCharArray());
                if (advancedCypherKey.Count > 0)
                    loadedText.SaveKey(filename, a.ToCharArray());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            caesarCypherKey.Clear();
            substitutionCypherKey.Clear();
            advancedCypherKey.Clear();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                loadedText.filePath = openFileDialog1.FileName;
                loadedText.readTextFile();
                switch (loadedText.text[0])
                {
                    case 'c':
                        {
                            for(int i=0; i < 52; i++)
                            {
                                caesarCypherKey.Add(loadedText.text[i+1]);
                            }
                            keyTextBox.Text = "Szyfr Cezara\n\r\n\r" + ShowCharListContent(caesarCypherKey);
                            break;
                        }
                    case 's':
                        {
                            for (int i = 0; i < 52; i++)
                            {
                                substitutionCypherKey.Add(loadedText.text[i + 1]);
                            }
                            keyTextBox.Text = "Prosty szyfr podstawieniowy\n\r\n\r" + ShowCharListContent(substitutionCypherKey);
                            break;
                        }
                    case 'a':
                        {
                            string letterCode = (loadedText.text).Substring(1);
                            List<string> loadedCode = letterCode.Split(',').ToList<string>();
                            advancedCypherKey.AddRange(loadedCode);
                            keyTextBox.Text = "Zaawansowany szyfr podstawieniowy\n\r\n\r" + ShowStringListContent(advancedCypherKey);
                            break;
                        }
                }
            }
        }

        private void decypherButton_Click(object sender, EventArgs e)
        {
            try
            {
                loadedText.text = originalTextBox.Text;
                if (caesarCypherKey.Count > 0)
                {
                    loadedText.SimpleDecypher(caesarCypherKey);
                    encryptedTextBox.Text = loadedText.encryptedText;
                }

                if (substitutionCypherKey.Count > 0)
                {
                    loadedText.SimpleDecypher(substitutionCypherKey);
                    encryptedTextBox.Text = loadedText.encryptedText;
                }
                if (advancedCypherKey.Count > 0)
                {
                    loadedText.AdvanceDecypher(advancedCypherKey);
                    encryptedTextBox.Text = loadedText.encryptedText;
                }
            }
            catch(Exception ex) { }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            caesarCypherKey.Clear();
            substitutionCypherKey.Clear();
            advancedCypherKey.Clear();
            AdvancedCypherForm form3 = new AdvancedCypherForm();
            form3.Show();

            form3.Closed += (sender1, args) =>
            {
                try
                {
                    this.advancedCypherKey.AddRange(form3.cypherList);
                    AdvancedCypher aCypher = new AdvancedCypher(loadedText.text, advancedCypherKey);
                    loadedText.encryptedText = aCypher.AdvancedEncypher();
                    encryptedTextBox.Text = loadedText.encryptedText;
                    keyTextBox.Text = "Zaawansowany szyfr podstawieniowy\n\r\n\r" + ShowStringListContent(advancedCypherKey);
                }
                catch (Exception ex)
                {
                }
            };
        }
    }
}
