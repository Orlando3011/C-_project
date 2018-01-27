namespace Szyfrowanie
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.caesaeButton = new System.Windows.Forms.Button();
            this.newSubstitutionCypherButton = new System.Windows.Forms.Button();
            this.chooseFileButton = new System.Windows.Forms.Button();
            this.saveWithoutCypherButton = new System.Windows.Forms.Button();
            this.saveWithCypherButton = new System.Windows.Forms.Button();
            this.loadCypherButton = new System.Windows.Forms.Button();
            this.decypherButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.originalTextBox = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.encryptedTextBox = new System.Windows.Forms.TextBox();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.quitButton = new System.Windows.Forms.Button();
            this.fileNameBox = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.Title = "Wczytaj plik .txt";
            // 
            // caesaeButton
            // 
            this.caesaeButton.Location = new System.Drawing.Point(12, 84);
            this.caesaeButton.Name = "caesaeButton";
            this.caesaeButton.Size = new System.Drawing.Size(148, 52);
            this.caesaeButton.TabIndex = 7;
            this.caesaeButton.Text = "Szyfr Cezara";
            this.toolTip1.SetToolTip(this.caesaeButton, "Zamień każdą literę w tekście na literę znajdującą się X pozycji dalej, lub wcześ" +
        "niej.\r\nX można ustawić w polu po prawej.\r\n\r\n");
            this.caesaeButton.UseVisualStyleBackColor = true;
            this.caesaeButton.Click += new System.EventHandler(this.caesarCypherButton);
            // 
            // newSubstitutionCypherButton
            // 
            this.newSubstitutionCypherButton.Location = new System.Drawing.Point(12, 141);
            this.newSubstitutionCypherButton.Name = "newSubstitutionCypherButton";
            this.newSubstitutionCypherButton.Size = new System.Drawing.Size(148, 52);
            this.newSubstitutionCypherButton.TabIndex = 10;
            this.newSubstitutionCypherButton.Text = "Prosty szyfr pdostawieniowy\r\n";
            this.toolTip1.SetToolTip(this.newSubstitutionCypherButton, "Zdefiniuj własny prosty szyfr podstawieniowy, lub uzupełnij go losowymi znakami\r\n" +
        "");
            this.newSubstitutionCypherButton.UseVisualStyleBackColor = true;
            this.newSubstitutionCypherButton.Click += new System.EventHandler(this.newSubstitutionCypherButton_Click);
            // 
            // chooseFileButton
            // 
            this.chooseFileButton.Location = new System.Drawing.Point(12, 3);
            this.chooseFileButton.Name = "chooseFileButton";
            this.chooseFileButton.Size = new System.Drawing.Size(148, 52);
            this.chooseFileButton.TabIndex = 0;
            this.chooseFileButton.Text = "Wybierz plik";
            this.toolTip1.SetToolTip(this.chooseFileButton, "Wybierz plik w formacie .txt, który ma zostać zaszyfrowany");
            this.chooseFileButton.UseVisualStyleBackColor = true;
            this.chooseFileButton.Click += new System.EventHandler(this.loadFileButton);
            // 
            // saveWithoutCypherButton
            // 
            this.saveWithoutCypherButton.Location = new System.Drawing.Point(12, 316);
            this.saveWithoutCypherButton.Name = "saveWithoutCypherButton";
            this.saveWithoutCypherButton.Size = new System.Drawing.Size(148, 52);
            this.saveWithoutCypherButton.TabIndex = 11;
            this.saveWithoutCypherButton.Text = "Zapisz plik...";
            this.toolTip1.SetToolTip(this.saveWithoutCypherButton, "Zapisz zaszyfrowany dokument");
            this.saveWithoutCypherButton.UseVisualStyleBackColor = true;
            this.saveWithoutCypherButton.Click += new System.EventHandler(this.saveWithoutCypherButton_Click);
            // 
            // saveWithCypherButton
            // 
            this.saveWithCypherButton.Location = new System.Drawing.Point(166, 316);
            this.saveWithCypherButton.Name = "saveWithCypherButton";
            this.saveWithCypherButton.Size = new System.Drawing.Size(148, 52);
            this.saveWithCypherButton.TabIndex = 12;
            this.saveWithCypherButton.Text = "Zapisz klucz...";
            this.toolTip1.SetToolTip(this.saveWithCypherButton, "Zapisz klucz, widoczny w oknie po prawej.\r\nPóźniej mozna go użyć do zaszyfrowania" +
        " innego pliku, lub do odkodowania go.");
            this.saveWithCypherButton.UseVisualStyleBackColor = true;
            this.saveWithCypherButton.Click += new System.EventHandler(this.saveWithCypherButton_Click);
            // 
            // loadCypherButton
            // 
            this.loadCypherButton.Location = new System.Drawing.Point(12, 258);
            this.loadCypherButton.Name = "loadCypherButton";
            this.loadCypherButton.Size = new System.Drawing.Size(148, 52);
            this.loadCypherButton.TabIndex = 15;
            this.loadCypherButton.Text = "Wczytaj gotowy szyfr...";
            this.toolTip1.SetToolTip(this.loadCypherButton, "Wczytaj plik z kluczem przygotowanym wczesniej w programie. \r\n");
            this.loadCypherButton.UseVisualStyleBackColor = true;
            this.loadCypherButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // decypherButton
            // 
            this.decypherButton.Location = new System.Drawing.Point(166, 258);
            this.decypherButton.Name = "decypherButton";
            this.decypherButton.Size = new System.Drawing.Size(148, 51);
            this.decypherButton.TabIndex = 16;
            this.decypherButton.Text = "Odszyfruj";
            this.toolTip1.SetToolTip(this.decypherButton, "Użyj klucza z pola \"Klucz\" do odszyfrowania tekstu z pola \"Wczytany tekst\"");
            this.decypherButton.UseVisualStyleBackColor = true;
            this.decypherButton.Click += new System.EventHandler(this.decypherButton_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.InitialDirectory = ".";
            this.saveFileDialog1.Title = "Zapisz sam zaszyfrowany tekst";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.keyTextBox);
            this.splitContainer2.Panel2.Controls.Add(this.textBox1);
            this.splitContainer2.Size = new System.Drawing.Size(715, 436);
            this.splitContainer2.SplitterDistance = 425;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.textBox4);
            this.splitContainer3.Panel1.Controls.Add(this.originalTextBox);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.textBox5);
            this.splitContainer3.Panel2.Controls.Add(this.encryptedTextBox);
            this.splitContainer3.Size = new System.Drawing.Size(425, 436);
            this.splitContainer3.SplitterDistance = 213;
            this.splitContainer3.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox4.Location = new System.Drawing.Point(0, 191);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(425, 22);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "Wczytany tekst";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // originalTextBox
            // 
            this.originalTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originalTextBox.Location = new System.Drawing.Point(0, 0);
            this.originalTextBox.Multiline = true;
            this.originalTextBox.Name = "originalTextBox";
            this.originalTextBox.ReadOnly = true;
            this.originalTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.originalTextBox.Size = new System.Drawing.Size(425, 213);
            this.originalTextBox.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.textBox5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox5.Location = new System.Drawing.Point(0, 197);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(425, 22);
            this.textBox5.TabIndex = 6;
            this.textBox5.Text = "Zmodyfikowany tekst";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // encryptedTextBox
            // 
            this.encryptedTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.encryptedTextBox.Location = new System.Drawing.Point(0, 0);
            this.encryptedTextBox.Multiline = true;
            this.encryptedTextBox.Name = "encryptedTextBox";
            this.encryptedTextBox.ReadOnly = true;
            this.encryptedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.encryptedTextBox.Size = new System.Drawing.Size(425, 219);
            this.encryptedTextBox.TabIndex = 4;
            // 
            // keyTextBox
            // 
            this.keyTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keyTextBox.Location = new System.Drawing.Point(0, 0);
            this.keyTextBox.Multiline = true;
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.ReadOnly = true;
            this.keyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.keyTextBox.Size = new System.Drawing.Size(286, 414);
            this.keyTextBox.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(0, 414);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(286, 22);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "Klucz";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(166, 100);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(55, 22);
            this.numericUpDown1.TabIndex = 8;
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(12, 374);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(148, 52);
            this.quitButton.TabIndex = 1;
            this.quitButton.Text = "Zamknij program";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.exitButton);
            // 
            // fileNameBox
            // 
            this.fileNameBox.Location = new System.Drawing.Point(12, 56);
            this.fileNameBox.Name = "fileNameBox";
            this.fileNameBox.ReadOnly = true;
            this.fileNameBox.Size = new System.Drawing.Size(148, 22);
            this.fileNameBox.TabIndex = 2;
            this.fileNameBox.Text = "nazwa pliku";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBox3);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.decypherButton);
            this.splitContainer1.Panel1.Controls.Add(this.loadCypherButton);
            this.splitContainer1.Panel1.Controls.Add(this.textBox2);
            this.splitContainer1.Panel1.Controls.Add(this.saveWithCypherButton);
            this.splitContainer1.Panel1.Controls.Add(this.saveWithoutCypherButton);
            this.splitContainer1.Panel1.Controls.Add(this.chooseFileButton);
            this.splitContainer1.Panel1.Controls.Add(this.newSubstitutionCypherButton);
            this.splitContainer1.Panel1.Controls.Add(this.fileNameBox);
            this.splitContainer1.Panel1.Controls.Add(this.quitButton);
            this.splitContainer1.Panel1.Controls.Add(this.numericUpDown1);
            this.splitContainer1.Panel1.Controls.Add(this.caesaeButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1115, 436);
            this.splitContainer1.SplitterDistance = 396;
            this.splitContainer1.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(166, 198);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(204, 52);
            this.textBox3.TabIndex = 18;
            this.textBox3.Text = "Zastąp każdą literę tekstu na jeden z losowych numerów";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 51);
            this.button1.TabIndex = 17;
            this.button1.Text = "Zaawansowany szyfr podstawieniowy...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(166, 141);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(204, 52);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "Zastąp każdą literę tekstu na inną, wybraną literę";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 436);
            this.Controls.Add(this.splitContainer1);
            this.MaximumSize = new System.Drawing.Size(1133, 483);
            this.MinimumSize = new System.Drawing.Size(1133, 483);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Szyfrowanie";
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox originalTextBox;
        protected System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox encryptedTextBox;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button caesaeButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.TextBox fileNameBox;
        private System.Windows.Forms.Button newSubstitutionCypherButton;
        private System.Windows.Forms.Button chooseFileButton;
        private System.Windows.Forms.Button saveWithoutCypherButton;
        private System.Windows.Forms.Button saveWithCypherButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button loadCypherButton;
        private System.Windows.Forms.Button decypherButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
    }
}

