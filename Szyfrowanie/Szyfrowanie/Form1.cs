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

        public List<char> substitutionCypherKey = new List<char>();
        public List<String> mixedCypherKey = new List<String>();

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

        public static String ShowStringListContent(List<String> list)
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
                MessageBox.Show("Błąd: " + ex.Message);
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
                loadedText.text = loadedText.readTextFile();
                loadedText.fileName = loadedText.setFileName();
                fileNameBox.Text = loadedText.fileName;
                originalTextBox.Text = loadedText.text;
            }
        }

        private void caesarCypherButton(object sender, EventArgs e)
        {
                CaesarCypher cCypher = new CaesarCypher(loadedText.text, Convert.ToInt32(numericUpDown1.Value));
                substitutionCypherKey.Clear();
                substitutionCypherKey.AddRange(cCypher.CreateKeyList());
                loadedText.encryptedText = cCypher.CaesarEncypher();
                encryptedTextBox.Text = loadedText.encryptedText;
                keyTextBox.Text = ShowCharListContent(substitutionCypherKey);
        }

        private void newSubstitutionCypherButton_Click(object sender, EventArgs e)
        {
                substitutionCypherKey.Clear();
                substitutionCipherForm form2 = new substitutionCipherForm();
                form2.Show();
                form2.Closed += (sender1, args) =>
                {
                    this.substitutionCypherKey.AddRange(form2.cypherList);
                    SubstitutionCypher sCypher = new SubstitutionCypher(loadedText.text, substitutionCypherKey);
                    loadedText.encryptedText = sCypher.SubstitutionEncypher();
                    encryptedTextBox.Text = loadedText.encryptedText;
                    keyTextBox.Text = ShowCharListContent(substitutionCypherKey);
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
            if (filename.Length > 0) saveFileDialog1.FileName = filename;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog1.FileName;
                loadedText.SaveWithKey(filename, keyTextBox.Text);
            }
        }

    }
}
