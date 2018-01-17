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
    public partial class MixedCypherForm : Form
    {
        public MixedCypherForm()
        {
            InitializeComponent();
        }

        public List<String> mixedCypherList = new List<String>();
        public char[] chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        public Random rand = new Random();

        public String randomSigns()
        {
            String output = "";

            for(int i = 1; i <= rand.Next(1,5); i++)
            {
                output = output + chars[rand.Next(0, chars.Length - 1)];
            }
            return output;
        }

        private void randomLettersButton_Click(object sender, EventArgs e)
        {
            if (signTextBox1.Text.Length == 0) signTextBox1.Text = randomSigns();
            if (signTextBox2.Text.Length == 0) signTextBox2.Text = randomSigns();
            if (signTextBox3.Text.Length == 0) signTextBox3.Text = randomSigns();
            if (signTextBox4.Text.Length == 0) signTextBox4.Text = randomSigns();
            if (signTextBox5.Text.Length == 0) signTextBox5.Text = randomSigns();
            if (signTextBox6.Text.Length == 0) signTextBox6.Text = randomSigns();
            if (signTextBox7.Text.Length == 0) signTextBox7.Text = randomSigns();
            if (signTextBox8.Text.Length == 0) signTextBox8.Text = randomSigns();
            if (signTextBox9.Text.Length == 0) signTextBox9.Text = randomSigns();
            if (signTextBox10.Text.Length == 0) signTextBox10.Text = randomSigns();
            if (signTextBox11.Text.Length == 0) signTextBox11.Text = randomSigns();
            if (signTextBox12.Text.Length == 0) signTextBox12.Text = randomSigns();
            if (signTextBox13.Text.Length == 0) signTextBox13.Text = randomSigns();
            if (signTextBox14.Text.Length == 0) signTextBox14.Text = randomSigns();
            if (signTextBox15.Text.Length == 0) signTextBox15.Text = randomSigns();
            if (signTextBox16.Text.Length == 0) signTextBox16.Text = randomSigns();
            if (signTextBox17.Text.Length == 0) signTextBox17.Text = randomSigns();
            if (signTextBox18.Text.Length == 0) signTextBox18.Text = randomSigns();
            if (signTextBox19.Text.Length == 0) signTextBox19.Text = randomSigns();
            if (signTextBox20.Text.Length == 0) signTextBox20.Text = randomSigns();
            if (signTextBox21.Text.Length == 0) signTextBox21.Text = randomSigns();
            if (signTextBox22.Text.Length == 0) signTextBox22.Text = randomSigns();
            if (signTextBox23.Text.Length == 0) signTextBox23.Text = randomSigns();
            if (signTextBox24.Text.Length == 0) signTextBox24.Text = randomSigns();
            if (signTextBox25.Text.Length == 0) signTextBox25.Text = randomSigns();
            if (signTextBox26.Text.Length == 0) signTextBox26.Text = randomSigns();

            if (signTextBox27.Text.Length == 0) signTextBox27.Text = randomSigns();
            if (signTextBox28.Text.Length == 0) signTextBox28.Text = randomSigns();
            if (signTextBox29.Text.Length == 0) signTextBox29.Text = randomSigns();
            if (signTextBox30.Text.Length == 0) signTextBox30.Text = randomSigns();
            if (signTextBox31.Text.Length == 0) signTextBox31.Text = randomSigns();
            if (signTextBox32.Text.Length == 0) signTextBox32.Text = randomSigns();
            if (signTextBox33.Text.Length == 0) signTextBox33.Text = randomSigns();
            if (signTextBox34.Text.Length == 0) signTextBox34.Text = randomSigns();
            if (signTextBox35.Text.Length == 0) signTextBox35.Text = randomSigns();
            if (signTextBox36.Text.Length == 0) signTextBox36.Text = randomSigns();
            if (signTextBox37.Text.Length == 0) signTextBox37.Text = randomSigns();
            if (signTextBox38.Text.Length == 0) signTextBox38.Text = randomSigns();
            if (signTextBox39.Text.Length == 0) signTextBox39.Text = randomSigns();
            if (signTextBox40.Text.Length == 0) signTextBox40.Text = randomSigns();
            if (signTextBox41.Text.Length == 0) signTextBox41.Text = randomSigns();
            if (signTextBox42.Text.Length == 0) signTextBox42.Text = randomSigns();
            if (signTextBox43.Text.Length == 0) signTextBox43.Text = randomSigns();
            if (signTextBox44.Text.Length == 0) signTextBox44.Text = randomSigns();
            if (signTextBox45.Text.Length == 0) signTextBox45.Text = randomSigns();
            if (signTextBox46.Text.Length == 0) signTextBox46.Text = randomSigns();
            if (signTextBox47.Text.Length == 0) signTextBox47.Text = randomSigns();
            if (signTextBox48.Text.Length == 0) signTextBox48.Text = randomSigns();
            if (signTextBox49.Text.Length == 0) signTextBox49.Text = randomSigns();
            if (signTextBox50.Text.Length == 0) signTextBox50.Text = randomSigns();
            if (signTextBox51.Text.Length == 0) signTextBox51.Text = randomSigns();
            if (signTextBox52.Text.Length == 0) signTextBox52.Text = randomSigns();
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
            {
                Close();
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.mixedCypherList.Add(this.signTextBox1.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox2.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox3.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox4.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox5.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox6.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox7.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox8.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox9.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox10.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox11.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox12.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox13.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox14.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox15.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox16.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox17.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox18.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox19.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox20.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox21.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox22.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox23.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox24.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox25.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox26.Text.ToString());

                this.mixedCypherList.Add(this.signTextBox27.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox28.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox29.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox30.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox31.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox32.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox33.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox34.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox35.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox36.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox37.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox38.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox39.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox40.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox41.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox42.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox43.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox44.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox45.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox46.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox47.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox48.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox49.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox50.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox51.Text.ToString());
                this.mixedCypherList.Add(this.signTextBox52.Text.ToString());
                this.Close();
            }
            catch (Exception ex)
            {
                    MessageBox.Show("Błąd: " + ex.Message);
            }
        }
    }
}
