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

        public List<char> cipherList = new List<char>();
        public char[] chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        public  Random rand = new Random();

        public String randomSign()
        {
            return chars[rand.Next(0, chars.Length - 1)].ToString();
        }

        private void randomLettersButton_Click(object sender, EventArgs e)
        {
            if (signTextBox1.Text.Length == 0) signTextBox1.Text = randomSign();
            if (signTextBox2.Text.Length == 0) signTextBox2.Text = randomSign();
            if (signTextBox3.Text.Length == 0) signTextBox3.Text = randomSign();
            if (signTextBox4.Text.Length == 0) signTextBox4.Text = randomSign();
            if (signTextBox5.Text.Length == 0) signTextBox5.Text = randomSign();
            if (signTextBox6.Text.Length == 0) signTextBox6.Text = randomSign();
            if (signTextBox7.Text.Length == 0) signTextBox7.Text = randomSign();
            if (signTextBox8.Text.Length == 0) signTextBox8.Text = randomSign();
            if (signTextBox9.Text.Length == 0) signTextBox9.Text = randomSign();
            if (signTextBox10.Text.Length == 0) signTextBox10.Text = randomSign();
            if (signTextBox11.Text.Length == 0) signTextBox11.Text = randomSign();
            if (signTextBox12.Text.Length == 0) signTextBox12.Text = randomSign();
            if (signTextBox13.Text.Length == 0) signTextBox13.Text = randomSign();
            if (signTextBox14.Text.Length == 0) signTextBox14.Text = randomSign();
            if (signTextBox15.Text.Length == 0) signTextBox15.Text = randomSign();
            if (signTextBox16.Text.Length == 0) signTextBox16.Text = randomSign();
            if (signTextBox17.Text.Length == 0) signTextBox17.Text = randomSign();
            if (signTextBox18.Text.Length == 0) signTextBox18.Text = randomSign();
            if (signTextBox19.Text.Length == 0) signTextBox19.Text = randomSign();
            if (signTextBox20.Text.Length == 0) signTextBox20.Text = randomSign();
            if (signTextBox21.Text.Length == 0) signTextBox21.Text = randomSign();
            if (signTextBox22.Text.Length == 0) signTextBox22.Text = randomSign();
            if (signTextBox23.Text.Length == 0) signTextBox23.Text = randomSign();
            if (signTextBox24.Text.Length == 0) signTextBox24.Text = randomSign();
            if (signTextBox25.Text.Length == 0) signTextBox25.Text = randomSign();
            if (signTextBox26.Text.Length == 0) signTextBox26.Text = randomSign();

            if (signTextBox27.Text.Length == 0) signTextBox27.Text = randomSign();
            if (signTextBox28.Text.Length == 0) signTextBox28.Text = randomSign();
            if (signTextBox29.Text.Length == 0) signTextBox29.Text = randomSign();
            if (signTextBox30.Text.Length == 0) signTextBox30.Text = randomSign();
            if (signTextBox31.Text.Length == 0) signTextBox31.Text = randomSign();
            if (signTextBox32.Text.Length == 0) signTextBox32.Text = randomSign();
            if (signTextBox33.Text.Length == 0) signTextBox33.Text = randomSign();
            if (signTextBox34.Text.Length == 0) signTextBox34.Text = randomSign();
            if (signTextBox35.Text.Length == 0) signTextBox35.Text = randomSign();
            if (signTextBox36.Text.Length == 0) signTextBox36.Text = randomSign();
            if (signTextBox37.Text.Length == 0) signTextBox37.Text = randomSign();
            if (signTextBox38.Text.Length == 0) signTextBox38.Text = randomSign();
            if (signTextBox39.Text.Length == 0) signTextBox39.Text = randomSign();
            if (signTextBox40.Text.Length == 0) signTextBox40.Text = randomSign();
            if (signTextBox41.Text.Length == 0) signTextBox41.Text = randomSign();
            if (signTextBox42.Text.Length == 0) signTextBox42.Text = randomSign();
            if (signTextBox43.Text.Length == 0) signTextBox43.Text = randomSign();
            if (signTextBox44.Text.Length == 0) signTextBox44.Text = randomSign();
            if (signTextBox45.Text.Length == 0) signTextBox45.Text = randomSign();
            if (signTextBox46.Text.Length == 0) signTextBox46.Text = randomSign();
            if (signTextBox47.Text.Length == 0) signTextBox47.Text = randomSign();
            if (signTextBox48.Text.Length == 0) signTextBox48.Text = randomSign();
            if (signTextBox49.Text.Length == 0) signTextBox49.Text = randomSign();
            if (signTextBox50.Text.Length == 0) signTextBox50.Text = randomSign();
            if (signTextBox51.Text.Length == 0) signTextBox51.Text = randomSign();
            if (signTextBox52.Text.Length == 0) signTextBox52.Text = randomSign();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cipherList.Add(this.signTextBox1.Text[0]);
                this.cipherList.Add(this.signTextBox2.Text[0]);
                this.cipherList.Add(this.signTextBox3.Text[0]);
                this.cipherList.Add(this.signTextBox4.Text[0]);
                this.cipherList.Add(this.signTextBox5.Text[0]);
                this.cipherList.Add(this.signTextBox6.Text[0]);
                this.cipherList.Add(this.signTextBox7.Text[0]);
                this.cipherList.Add(this.signTextBox8.Text[0]);
                this.cipherList.Add(this.signTextBox9.Text[0]);
                this.cipherList.Add(this.signTextBox10.Text[0]);
                this.cipherList.Add(this.signTextBox11.Text[0]);
                this.cipherList.Add(this.signTextBox12.Text[0]);
                this.cipherList.Add(this.signTextBox13.Text[0]);
                this.cipherList.Add(this.signTextBox14.Text[0]);
                this.cipherList.Add(this.signTextBox15.Text[0]);
                this.cipherList.Add(this.signTextBox16.Text[0]);
                this.cipherList.Add(this.signTextBox17.Text[0]);
                this.cipherList.Add(this.signTextBox18.Text[0]);
                this.cipherList.Add(this.signTextBox19.Text[0]);
                this.cipherList.Add(this.signTextBox20.Text[0]);
                this.cipherList.Add(this.signTextBox21.Text[0]);
                this.cipherList.Add(this.signTextBox22.Text[0]);
                this.cipherList.Add(this.signTextBox23.Text[0]);
                this.cipherList.Add(this.signTextBox24.Text[0]);
                this.cipherList.Add(this.signTextBox25.Text[0]);
                this.cipherList.Add(this.signTextBox26.Text[0]);

                this.cipherList.Add(this.signTextBox27.Text[0]);
                this.cipherList.Add(this.signTextBox28.Text[0]);
                this.cipherList.Add(this.signTextBox29.Text[0]);
                this.cipherList.Add(this.signTextBox30.Text[0]);
                this.cipherList.Add(this.signTextBox31.Text[0]);
                this.cipherList.Add(this.signTextBox32.Text[0]);
                this.cipherList.Add(this.signTextBox33.Text[0]);
                this.cipherList.Add(this.signTextBox34.Text[0]);
                this.cipherList.Add(this.signTextBox35.Text[0]);
                this.cipherList.Add(this.signTextBox36.Text[0]);
                this.cipherList.Add(this.signTextBox37.Text[0]);
                this.cipherList.Add(this.signTextBox38.Text[0]);
                this.cipherList.Add(this.signTextBox39.Text[0]);
                this.cipherList.Add(this.signTextBox40.Text[0]);
                this.cipherList.Add(this.signTextBox41.Text[0]);
                this.cipherList.Add(this.signTextBox42.Text[0]);
                this.cipherList.Add(this.signTextBox43.Text[0]);
                this.cipherList.Add(this.signTextBox44.Text[0]);
                this.cipherList.Add(this.signTextBox45.Text[0]);
                this.cipherList.Add(this.signTextBox46.Text[0]);
                this.cipherList.Add(this.signTextBox47.Text[0]);
                this.cipherList.Add(this.signTextBox48.Text[0]);
                this.cipherList.Add(this.signTextBox49.Text[0]);
                this.cipherList.Add(this.signTextBox50.Text[0]);
                this.cipherList.Add(this.signTextBox51.Text[0]);
                this.cipherList.Add(this.signTextBox52.Text[0]);

                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Uzupełnij wszystkie pola, lub użyj opcji losowania.");
            }
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            signTextBox1.Text = null;
            signTextBox2.Text = null;
            signTextBox3.Text = null;
            signTextBox4.Text = null;
            signTextBox5.Text = null;
            signTextBox6.Text = null;
            signTextBox7.Text = null;
            signTextBox8.Text = null;
            signTextBox9.Text = null;
            signTextBox10.Text = null;
            signTextBox11.Text = null;
            signTextBox12.Text = null;
            signTextBox13.Text = null;
            signTextBox14.Text = null;
            signTextBox15.Text = null;
            signTextBox16.Text = null;
            signTextBox17.Text = null;
            signTextBox18.Text = null;
            signTextBox19.Text = null;
            signTextBox20.Text = null;
            signTextBox21.Text = null;
            signTextBox22.Text = null;
            signTextBox23.Text = null;
            signTextBox24.Text = null;
            signTextBox25.Text = null;
            signTextBox26.Text = null;

            signTextBox27.Text = null;
            signTextBox28.Text = null;
            signTextBox29.Text = null;
            signTextBox30.Text = null;
            signTextBox31.Text = null;
            signTextBox32.Text = null;
            signTextBox33.Text = null;
            signTextBox34.Text = null;
            signTextBox35.Text = null;
            signTextBox36.Text = null;
            signTextBox37.Text = null;
            signTextBox38.Text = null;
            signTextBox39.Text = null;
            signTextBox40.Text = null;
            signTextBox41.Text = null;
            signTextBox42.Text = null;
            signTextBox43.Text = null;
            signTextBox44.Text = null;
            signTextBox45.Text = null;
            signTextBox46.Text = null;
            signTextBox47.Text = null;
            signTextBox48.Text = null;
            signTextBox49.Text = null;
            signTextBox50.Text = null;
            signTextBox51.Text = null;
            signTextBox52.Text = null;
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
