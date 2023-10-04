namespace clickathon3000
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnPocni = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            oAplikacijiToolStripMenuItem = new ToolStripMenuItem();
            uputstvoToolStripMenuItem = new ToolStripMenuItem();
            informacijaToolStripMenuItem = new ToolStripMenuItem();
            fajlToolStripMenuItem = new ToolStripMenuItem();
            otvoriFajlToolStripMenuItem = new ToolStripMenuItem();
            izaberiAktivniFajlToolStripMenuItem = new ToolStripMenuItem();
            pomocToolStripMenuItem = new ToolStripMenuItem();
            komandeToolStripMenuItem = new ToolStripMenuItem();
            btnZaustavi = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            cmbInterval = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            btnPocniOdmah = new Button();
            openFileDialog1 = new OpenFileDialog();
            lblTrenutnaKomanda = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // btnPocni
            // 
            btnPocni.Location = new Point(12, 27);
            btnPocni.Name = "btnPocni";
            btnPocni.Size = new Size(75, 23);
            btnPocni.TabIndex = 0;
            btnPocni.Text = "Počni";
            btnPocni.UseVisualStyleBackColor = true;
            btnPocni.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 85);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 1;
            label1.Text = "Pozicija miša: ";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { oAplikacijiToolStripMenuItem, fajlToolStripMenuItem, pomocToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(314, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // oAplikacijiToolStripMenuItem
            // 
            oAplikacijiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { uputstvoToolStripMenuItem, informacijaToolStripMenuItem });
            oAplikacijiToolStripMenuItem.Name = "oAplikacijiToolStripMenuItem";
            oAplikacijiToolStripMenuItem.Size = new Size(77, 20);
            oAplikacijiToolStripMenuItem.Text = "O aplikaciji";
            // 
            // uputstvoToolStripMenuItem
            // 
            uputstvoToolStripMenuItem.Image = (Image)resources.GetObject("uputstvoToolStripMenuItem.Image");
            uputstvoToolStripMenuItem.Name = "uputstvoToolStripMenuItem";
            uputstvoToolStripMenuItem.Size = new Size(180, 22);
            uputstvoToolStripMenuItem.Text = "Uputstvo";
            uputstvoToolStripMenuItem.Click += uputstvoToolStripMenuItem_Click;
            // 
            // informacijaToolStripMenuItem
            // 
            informacijaToolStripMenuItem.Image = (Image)resources.GetObject("informacijaToolStripMenuItem.Image");
            informacijaToolStripMenuItem.Name = "informacijaToolStripMenuItem";
            informacijaToolStripMenuItem.Size = new Size(180, 22);
            informacijaToolStripMenuItem.Text = "Informacija";
            informacijaToolStripMenuItem.Click += informacijaToolStripMenuItem_Click;
            // 
            // fajlToolStripMenuItem
            // 
            fajlToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { otvoriFajlToolStripMenuItem, izaberiAktivniFajlToolStripMenuItem });
            fajlToolStripMenuItem.Name = "fajlToolStripMenuItem";
            fajlToolStripMenuItem.Size = new Size(37, 20);
            fajlToolStripMenuItem.Text = "Fajl";
            // 
            // otvoriFajlToolStripMenuItem
            // 
            otvoriFajlToolStripMenuItem.Image = (Image)resources.GetObject("otvoriFajlToolStripMenuItem.Image");
            otvoriFajlToolStripMenuItem.Name = "otvoriFajlToolStripMenuItem";
            otvoriFajlToolStripMenuItem.Size = new Size(180, 22);
            otvoriFajlToolStripMenuItem.Text = "Otvori aktivni fajl";
            otvoriFajlToolStripMenuItem.Click += otvoriFajlToolStripMenuItem_Click;
            // 
            // izaberiAktivniFajlToolStripMenuItem
            // 
            izaberiAktivniFajlToolStripMenuItem.Image = (Image)resources.GetObject("izaberiAktivniFajlToolStripMenuItem.Image");
            izaberiAktivniFajlToolStripMenuItem.Name = "izaberiAktivniFajlToolStripMenuItem";
            izaberiAktivniFajlToolStripMenuItem.Size = new Size(180, 22);
            izaberiAktivniFajlToolStripMenuItem.Text = "Izaberi aktivni fajl";
            izaberiAktivniFajlToolStripMenuItem.Click += izaberiAktivniFajlToolStripMenuItem_Click;
            // 
            // pomocToolStripMenuItem
            // 
            pomocToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { komandeToolStripMenuItem });
            pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            pomocToolStripMenuItem.Size = new Size(57, 20);
            pomocToolStripMenuItem.Text = "Pomoć";
            // 
            // komandeToolStripMenuItem
            // 
            komandeToolStripMenuItem.Image = (Image)resources.GetObject("komandeToolStripMenuItem.Image");
            komandeToolStripMenuItem.Name = "komandeToolStripMenuItem";
            komandeToolStripMenuItem.Size = new Size(180, 22);
            komandeToolStripMenuItem.Text = "Komande";
            komandeToolStripMenuItem.Click += komandeToolStripMenuItem_Click;
            // 
            // btnZaustavi
            // 
            btnZaustavi.Enabled = false;
            btnZaustavi.Location = new Point(231, 27);
            btnZaustavi.Name = "btnZaustavi";
            btnZaustavi.Size = new Size(75, 23);
            btnZaustavi.TabIndex = 3;
            btnZaustavi.Text = "Zaustavi";
            btnZaustavi.UseVisualStyleBackColor = true;
            btnZaustavi.Click += btnZaustavi_Click;
            // 
            // timer2
            // 
            timer2.Interval = 10;
            timer2.Tick += timer2_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 5;
            label2.Text = "Interval okidanja";
            // 
            // cmbInterval
            // 
            cmbInterval.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbInterval.FormattingEnabled = true;
            cmbInterval.Items.AddRange(new object[] { "Sati", "Minuta", "Sekundi", "Milisekundi" });
            cmbInterval.Location = new Point(218, 56);
            cmbInterval.Name = "cmbInterval";
            cmbInterval.Size = new Size(88, 23);
            cmbInterval.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(112, 57);
            numericUpDown1.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(100, 23);
            numericUpDown1.TabIndex = 7;
            numericUpDown1.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // btnPocniOdmah
            // 
            btnPocniOdmah.Location = new Point(93, 27);
            btnPocniOdmah.Name = "btnPocniOdmah";
            btnPocniOdmah.Size = new Size(91, 23);
            btnPocniOdmah.TabIndex = 8;
            btnPocniOdmah.Text = "Počni odmah";
            btnPocniOdmah.UseVisualStyleBackColor = true;
            btnPocniOdmah.Click += button1_Click_1;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblTrenutnaKomanda
            // 
            lblTrenutnaKomanda.AutoSize = true;
            lblTrenutnaKomanda.Location = new Point(12, 111);
            lblTrenutnaKomanda.Name = "lblTrenutnaKomanda";
            lblTrenutnaKomanda.Size = new Size(109, 15);
            lblTrenutnaKomanda.TabIndex = 9;
            lblTrenutnaKomanda.Text = "Trenutna komanda:";
            lblTrenutnaKomanda.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 135);
            Controls.Add(lblTrenutnaKomanda);
            Controls.Add(btnPocniOdmah);
            Controls.Add(numericUpDown1);
            Controls.Add(cmbInterval);
            Controls.Add(label2);
            Controls.Add(btnZaustavi);
            Controls.Add(label1);
            Controls.Add(btnPocni);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MaximumSize = new Size(334, 178);
            MinimumSize = new Size(334, 178);
            Name = "Form1";
            Text = "Clickathon 3000";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPocni;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem pomocToolStripMenuItem;
        private ToolStripMenuItem komandeToolStripMenuItem;
        private ToolStripMenuItem fajlToolStripMenuItem;
        private ToolStripMenuItem otvoriFajlToolStripMenuItem;
        private Button btnZaustavi;
        private System.Windows.Forms.Timer timer2;
        private Label label2;
        private ComboBox cmbInterval;
        private NumericUpDown numericUpDown1;
        private ToolStripMenuItem oAplikacijiToolStripMenuItem;
        private ToolStripMenuItem uputstvoToolStripMenuItem;
        private ToolStripMenuItem informacijaToolStripMenuItem;
        private Button btnPocniOdmah;
        private ToolStripMenuItem izaberiAktivniFajlToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private Label lblTrenutnaKomanda;
    }
}