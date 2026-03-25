namespace Lab1_czwartek1
{
    partial class MainWindow
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox_imie = new TextBox();
            textBox_nazwisko = new TextBox();
            btnZapisz = new Button();
            listBox_listaStudentow = new ListBox();
            dateTimePicker1 = new DateTimePicker();
            errorProvider1 = new ErrorProvider(components);
            textBox_ulica = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            comboBox_rok = new ComboBox();
            textBox_miasto = new TextBox();
            textBox_numerBudynku = new TextBox();
            checkBox_mieszkanie = new CheckBox();
            textBox_numerMieszkania = new TextBox();
            btnDodaj = new Button();
            btnEdytuj = new Button();
            btnUsun = new Button();
            btnWczytaj = new Button();
            myslnik = new Label();
            textBox_kod1 = new TextBox();
            textBox_kod2 = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(17, 39);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "Imię";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(17, 83);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Nazwisko";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(17, 124);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 2;
            label3.Text = "Data urodzenia";
            // 
            // textBox_imie
            // 
            textBox_imie.Location = new Point(226, 28);
            textBox_imie.Name = "textBox_imie";
            textBox_imie.Size = new Size(147, 27);
            textBox_imie.TabIndex = 3;
            textBox_imie.TextChanged += WalidujFormularz_TextChanged;
            textBox_imie.KeyPress += textBox_Litery_KeyPress;
            // 
            // textBox_nazwisko
            // 
            textBox_nazwisko.Location = new Point(226, 72);
            textBox_nazwisko.Name = "textBox_nazwisko";
            textBox_nazwisko.Size = new Size(147, 27);
            textBox_nazwisko.TabIndex = 4;
            textBox_nazwisko.TextChanged += WalidujFormularz_TextChanged;
            textBox_nazwisko.KeyPress += textBox_Litery_KeyPress;
            // 
            // btnZapisz
            // 
            btnZapisz.BackColor = Color.Cyan;
            btnZapisz.FlatStyle = FlatStyle.Flat;
            btnZapisz.ForeColor = SystemColors.ControlLightLight;
            btnZapisz.Location = new Point(525, 663);
            btnZapisz.Name = "btnZapisz";
            btnZapisz.Size = new Size(461, 29);
            btnZapisz.TabIndex = 6;
            btnZapisz.Text = "Zapisz liste studentów";
            btnZapisz.UseVisualStyleBackColor = false;
            btnZapisz.Click += btnZapisz_Click;
            // 
            // listBox_listaStudentow
            // 
            listBox_listaStudentow.FormattingEnabled = true;
            listBox_listaStudentow.Location = new Point(525, 83);
            listBox_listaStudentow.Name = "listBox_listaStudentow";
            listBox_listaStudentow.Size = new Size(460, 544);
            listBox_listaStudentow.TabIndex = 7;
            listBox_listaStudentow.SelectedIndexChanged += listBox_listaStudentow_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.ImeMode = ImeMode.NoControl;
            dateTimePicker1.Location = new Point(226, 113);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(147, 27);
            dateTimePicker1.TabIndex = 8;
            dateTimePicker1.Value = new DateTime(2026, 3, 12, 0, 0, 0, 0);
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // textBox_ulica
            // 
            textBox_ulica.Location = new Point(169, 107);
            textBox_ulica.Margin = new Padding(3, 4, 3, 4);
            textBox_ulica.Name = "textBox_ulica";
            textBox_ulica.Size = new Size(212, 27);
            textBox_ulica.TabIndex = 9;
            textBox_ulica.TextChanged += WalidujFormularz_TextChanged;
            textBox_ulica.KeyPress += textBox_Litery_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 125);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(525, 41);
            label5.Name = "label5";
            label5.Size = new Size(188, 35);
            label5.TabIndex = 11;
            label5.Text = "Lista studentów";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(15, 41);
            label6.Name = "label6";
            label6.Size = new Size(272, 35);
            label6.TabIndex = 12;
            label6.Text = "Dodaj studenta do listy";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(17, 160);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 13;
            label7.Text = "Rok studiów";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(7, 40);
            label9.Name = "label9";
            label9.Size = new Size(93, 20);
            label9.TabIndex = 15;
            label9.Text = "Miejscowość";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 79);
            label10.Name = "label10";
            label10.Size = new Size(104, 20);
            label10.TabIndex = 16;
            label10.Text = "Kod pocztowy";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(7, 116);
            label11.Name = "label11";
            label11.Size = new Size(42, 20);
            label11.TabIndex = 17;
            label11.Text = "Ulica";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(7, 156);
            label12.Name = "label12";
            label12.Size = new Size(114, 20);
            label12.TabIndex = 18;
            label12.Text = "Numer budynku";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(7, 199);
            label13.Name = "label13";
            label13.Size = new Size(131, 20);
            label13.TabIndex = 19;
            label13.Text = "Numer mieszkania";
            // 
            // comboBox_rok
            // 
            comboBox_rok.FormattingEnabled = true;
            comboBox_rok.Location = new Point(226, 149);
            comboBox_rok.Margin = new Padding(3, 4, 3, 4);
            comboBox_rok.Name = "comboBox_rok";
            comboBox_rok.Size = new Size(114, 28);
            comboBox_rok.TabIndex = 20;
            // 
            // textBox_miasto
            // 
            textBox_miasto.Location = new Point(169, 29);
            textBox_miasto.Margin = new Padding(3, 4, 3, 4);
            textBox_miasto.Name = "textBox_miasto";
            textBox_miasto.Size = new Size(212, 27);
            textBox_miasto.TabIndex = 21;
            textBox_miasto.TextChanged += WalidujFormularz_TextChanged;
            textBox_miasto.KeyPress += textBox_Litery_KeyPress;
            // 
            // textBox_numerBudynku
            // 
            textBox_numerBudynku.Location = new Point(169, 145);
            textBox_numerBudynku.Margin = new Padding(3, 4, 3, 4);
            textBox_numerBudynku.Name = "textBox_numerBudynku";
            textBox_numerBudynku.Size = new Size(114, 27);
            textBox_numerBudynku.TabIndex = 23;
            textBox_numerBudynku.TextChanged += WalidujFormularz_TextChanged;
            textBox_numerBudynku.KeyPress += tylkoCyfry_KeyPress;
            // 
            // checkBox_mieszkanie
            // 
            checkBox_mieszkanie.AutoSize = true;
            checkBox_mieszkanie.Location = new Point(290, 193);
            checkBox_mieszkanie.Margin = new Padding(3, 4, 3, 4);
            checkBox_mieszkanie.Name = "checkBox_mieszkanie";
            checkBox_mieszkanie.Size = new Size(52, 24);
            checkBox_mieszkanie.TabIndex = 24;
            checkBox_mieszkanie.Text = "Tak";
            checkBox_mieszkanie.UseVisualStyleBackColor = true;
            checkBox_mieszkanie.CheckedChanged += checkBox_mieszkanie_CheckedChanged;
            checkBox_mieszkanie.TextChanged += checkBox_mieszkanie_CheckedChanged;
            // 
            // textBox_numerMieszkania
            // 
            textBox_numerMieszkania.Enabled = false;
            textBox_numerMieszkania.Location = new Point(169, 188);
            textBox_numerMieszkania.Margin = new Padding(3, 4, 3, 4);
            textBox_numerMieszkania.Name = "textBox_numerMieszkania";
            textBox_numerMieszkania.Size = new Size(114, 27);
            textBox_numerMieszkania.TabIndex = 25;
            textBox_numerMieszkania.TextChanged += WalidujFormularz_TextChanged;
            textBox_numerMieszkania.KeyPress += tylkoCyfry_KeyPress;
            // 
            // btnDodaj
            // 
            btnDodaj.BackColor = Color.FromArgb(0, 192, 0);
            btnDodaj.FlatStyle = FlatStyle.Flat;
            btnDodaj.ForeColor = SystemColors.ControlLightLight;
            btnDodaj.Location = new Point(14, 661);
            btnDodaj.Margin = new Padding(3, 4, 3, 4);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(458, 31);
            btnDodaj.TabIndex = 26;
            btnDodaj.Text = "Dodaj studenta";
            btnDodaj.UseVisualStyleBackColor = false;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnEdytuj
            // 
            btnEdytuj.BackColor = Color.Blue;
            btnEdytuj.FlatStyle = FlatStyle.Flat;
            btnEdytuj.ForeColor = SystemColors.ButtonHighlight;
            btnEdytuj.Location = new Point(14, 700);
            btnEdytuj.Margin = new Padding(3, 4, 3, 4);
            btnEdytuj.Name = "btnEdytuj";
            btnEdytuj.Size = new Size(458, 31);
            btnEdytuj.TabIndex = 27;
            btnEdytuj.Text = "Edytuj dane studenta";
            btnEdytuj.UseVisualStyleBackColor = false;
            btnEdytuj.Click += btnEdytuj_Click;
            // 
            // btnUsun
            // 
            btnUsun.BackColor = Color.FromArgb(192, 64, 0);
            btnUsun.FlatStyle = FlatStyle.Flat;
            btnUsun.ForeColor = SystemColors.ControlLightLight;
            btnUsun.Location = new Point(15, 739);
            btnUsun.Margin = new Padding(3, 4, 3, 4);
            btnUsun.Name = "btnUsun";
            btnUsun.Size = new Size(457, 31);
            btnUsun.TabIndex = 28;
            btnUsun.Text = "Usuń studenta";
            btnUsun.UseVisualStyleBackColor = false;
            btnUsun.Click += btnUsun_Click;
            // 
            // btnWczytaj
            // 
            btnWczytaj.BackColor = Color.FromArgb(0, 0, 192);
            btnWczytaj.FlatStyle = FlatStyle.Flat;
            btnWczytaj.ForeColor = SystemColors.ControlLightLight;
            btnWczytaj.Location = new Point(525, 700);
            btnWczytaj.Margin = new Padding(3, 4, 3, 4);
            btnWczytaj.Name = "btnWczytaj";
            btnWczytaj.Size = new Size(461, 31);
            btnWczytaj.TabIndex = 29;
            btnWczytaj.Text = "Wczytaj listę studentów";
            btnWczytaj.UseVisualStyleBackColor = false;
            btnWczytaj.Click += btnWczytaj_Click;
            // 
            // myslnik
            // 
            myslnik.AutoSize = true;
            myslnik.Location = new Point(223, 72);
            myslnik.Name = "myslnik";
            myslnik.Size = new Size(15, 20);
            myslnik.TabIndex = 30;
            myslnik.Text = "-";
            // 
            // textBox_kod1
            // 
            textBox_kod1.Location = new Point(169, 68);
            textBox_kod1.Margin = new Padding(3, 4, 3, 4);
            textBox_kod1.MaxLength = 2;
            textBox_kod1.Name = "textBox_kod1";
            textBox_kod1.Size = new Size(46, 27);
            textBox_kod1.TabIndex = 31;
            textBox_kod1.TextChanged += textBox_kod1_TextChanged;
            textBox_kod1.KeyPress += tylkoCyfry_KeyPress;
            textBox_kod1.Leave += textBox_kod_Leave;
            // 
            // textBox_kod2
            // 
            textBox_kod2.Location = new Point(243, 68);
            textBox_kod2.Margin = new Padding(3, 4, 3, 4);
            textBox_kod2.MaxLength = 3;
            textBox_kod2.Name = "textBox_kod2";
            textBox_kod2.Size = new Size(73, 27);
            textBox_kod2.TabIndex = 32;
            textBox_kod2.TextChanged += textBox_kod2_TextChanged;
            textBox_kod2.KeyPress += tylkoCyfry_KeyPress;
            textBox_kod2.Leave += textBox_kod_Leave;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox_imie);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox_nazwisko);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(comboBox_rok);
            groupBox1.Location = new Point(15, 95);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(457, 217);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dane podstawowe";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(myslnik);
            groupBox2.Controls.Add(textBox_kod2);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(textBox_kod1);
            groupBox2.Controls.Add(checkBox_mieszkanie);
            groupBox2.Controls.Add(textBox_numerMieszkania);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(textBox_numerBudynku);
            groupBox2.Controls.Add(textBox_miasto);
            groupBox2.Controls.Add(textBox_ulica);
            groupBox2.Location = new Point(15, 351);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(457, 244);
            groupBox2.TabIndex = 34;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dane adresowe";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 855);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnWczytaj);
            Controls.Add(btnUsun);
            Controls.Add(btnEdytuj);
            Controls.Add(btnDodaj);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(listBox_listaStudentow);
            Controls.Add(btnZapisz);
            Name = "MainWindow";
            Text = "StudenciFormularzApp";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox_imie;
        private TextBox textBox_nazwisko;
        private Button btnZapisz;
        private ListBox listBox_listaStudentow;
        private DateTimePicker dateTimePicker1;
        private ErrorProvider errorProvider1;
        private TextBox textBox_ulica;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private ComboBox comboBox_rok;
        private TextBox textBox_miasto;
        private Button btnUsun;
        private Button btnEdytuj;
        private Button btnDodaj;
        private TextBox textBox_numerMieszkania;
        private CheckBox checkBox_mieszkanie;
        private TextBox textBox_numerBudynku;
        private Button btnWczytaj;
        private Label myslnik;
        private TextBox textBox_kod2;
        private TextBox textBox_kod1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}
