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
    public partial class AdvancedCypherForm : Form
    {
        public AdvancedCypherForm()
        {
            InitializeComponent();
        }

        public List<string> cypherList = new List<string>();
        public List<string> strings = new List<string>();

        public void createStrings()
        {
            for (int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    strings.Add(i.ToString() + j.ToString());
                }
            }
        }

        public List<int> hashNumbers()
        {
            Random rand = new Random();
            int randomNumber;
            List<int> possibleNumbers = new List<int>(100);
            for (int i = 0; i < 100; i++)
            {
                possibleNumbers.Add(i);
            }
            List<int> usedNumbers = new List<int>(100);
            for (int i = 0; i < 100; i++)
            {
                randomNumber = rand.Next(1, possibleNumbers.Count) - 1;
                usedNumbers.Add(possibleNumbers[randomNumber]);
                possibleNumbers.RemoveAt(randomNumber);
            }
            return usedNumbers;
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void randomLettersButton_Click(object sender, EventArgs e)
        {
            for (int i = 10; i < 36; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Controls["textBox" + i.ToString() + j.ToString()].Text = null;
                }
            }

            createStrings();
            List<int> randomList = hashNumbers();
            Random rand = new Random();
            int randomNumber, counter;
            counter = 0;

            for (int i = 10; i < 36; i++)
            {
                randomNumber = rand.Next(1, 5);
                for (int j = 1; j <= randomNumber; j++)
                {
                    string randomString = strings[randomList[counter]];
                    Controls["textBox" + i.ToString() + j.ToString()].Text = randomString;
                    counter++;
                }
            }
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            for (int i = 10; i < 36; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Controls["textBox" + i.ToString() + j.ToString()].Text = null;
                }
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            int errorCounter = 0;
            int nullCounter;
            int nullError = 0;
            List<string> controlList = new List<string>();
            string mergedKey;
            try
            {
                for (int i = 10; i < 36; i++)
                {
                    nullCounter = 0;
                    mergedKey = "";
                    for (int j = 1; j <= 5; j++)
                    {
                        if(Controls["textBox" + i.ToString() + j.ToString()].Text.Equals(""))
                        {
                            nullCounter++;
                        }
                        else
                        {
                            if (!controlList.Contains(Controls["textBox" + i.ToString() + j.ToString()].Text))
                            {
                                mergedKey = mergedKey + Controls["textBox" + i.ToString() + j.ToString()].Text;
                                controlList.Add(Controls["textBox" + i.ToString() + j.ToString()].Text);
                            }
                            else
                                errorCounter++;
                        }
                        if (nullCounter >= 5) nullError++;
                    }
                    cypherList.Add(mergedKey);
                }

                if (errorCounter != 0)
                {
                    this.cypherList.Clear();
                    MessageBox.Show("Numery szyfrujące powtarzają się. Każda litera musi być zaszyfrowana unikalnym numerem od 01 do 99.");
                }
                else if(nullError !=0)
                {
                    this.cypherList.Clear();
                    MessageBox.Show("Uzupełnij wszystkie pola unikalnymi znakami, lub użyj opcji losowania.");
                }
                    
                else
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                this.cypherList.Clear();
                MessageBox.Show("Uzupełnij wszystkie pola unikalnymi znakami, lub użyj opcji losowania.");
            }
        }

        private void AdvancedCypherForm_Load(object sender, EventArgs e)
        {

        }
    }
}
