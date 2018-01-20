using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szyfrowanie
{
    public partial class substitutionCipherForm : Form
    {
        public substitutionCipherForm()
        {
            InitializeComponent();
        }


        public List<char> cypherList = new List<char>();
        public char[] chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        public List<int> hashNumbers()
        {
            Random rand = new Random();
            int randomNumber;
            List<int> possibleNumbers = new List<int>(52);
            for(int i = 0; i < 52; i++)
            {
                possibleNumbers.Add(i);
            }
            List<int> usedNumbers = new List<int>(52);
            for (int i = 0; i < 52; i++)
            {
                randomNumber = rand.Next(1, possibleNumbers.Count) - 1;
                usedNumbers.Add(possibleNumbers[randomNumber]);
                possibleNumbers.RemoveAt(randomNumber);
            }
            return usedNumbers;
        }

        private void randomLettersButton_Click(object sender, EventArgs e)
        {
            List<int> randomList = hashNumbers();

            for (int i = 0; i < 52; i++)
            {
                if (Controls["signTextBox" + (i+1).ToString()].Text.Length == 0)
                {
                    Controls["signTextBox" + (i+1).ToString()].Text = chars[randomList[i]].ToString();
                }
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            int errorCounter = 0;
            try
            {
                for (int i = 1; i <= 52; i++)
                {
                    if (!this.cypherList.Contains(Controls["signTextBox" + i.ToString()].Text[0]))
                        this.cypherList.Add(Controls["signTextBox" + i.ToString()].Text[0]);
                    else
                        errorCounter++;
                }
                if (errorCounter == 0)
                    this.Close();
                else
                    MessageBox.Show("Znaki szyfrujące powtarzają się. Każda litera musi być zaszyfrowana unikalnym znakiem.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Uzupełnij wszystkie pola unikalnymi znakami, lub użyj opcji losowania.");
            }
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 52; i++)
            {
                Controls["signTextBox" + i.ToString()].Text = null;
            }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
