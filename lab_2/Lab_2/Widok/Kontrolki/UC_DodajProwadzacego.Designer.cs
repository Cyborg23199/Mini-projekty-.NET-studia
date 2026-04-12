namespace Lab_2.Widok.Kontrolki
{
    partial class UC_DodajProwadzacego
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button_dodajProwadzacego = new Button();
            comboBox_tytul = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            textBox_imie = new TextBox();
            textBox_nazwisko = new TextBox();
            label3 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_dodajProwadzacego);
            groupBox1.Controls.Add(comboBox_tytul);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox_imie);
            groupBox1.Controls.Add(textBox_nazwisko);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(3, 2);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(358, 152);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodaj prowadzacego:";
            // 
            // button_dodajProwadzacego
            // 
            button_dodajProwadzacego.BackColor = Color.White;
            button_dodajProwadzacego.Location = new Point(75, 124);
            button_dodajProwadzacego.Name = "button_dodajProwadzacego";
            button_dodajProwadzacego.Size = new Size(165, 23);
            button_dodajProwadzacego.TabIndex = 9;
            button_dodajProwadzacego.Text = "Dodaj";
            button_dodajProwadzacego.UseVisualStyleBackColor = false;
            // 
            // comboBox_tytul
            // 
            comboBox_tytul.FormattingEnabled = true;
            comboBox_tytul.Location = new Point(97, 90);
            comboBox_tytul.Margin = new Padding(3, 2, 3, 2);
            comboBox_tytul.Name = "comboBox_tytul";
            comboBox_tytul.Size = new Size(133, 23);
            comboBox_tytul.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 92);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 7;
            label2.Text = "Tytul:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 81);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 6;
            // 
            // textBox_imie
            // 
            textBox_imie.Location = new Point(97, 20);
            textBox_imie.Margin = new Padding(3, 2, 3, 2);
            textBox_imie.Name = "textBox_imie";
            textBox_imie.Size = new Size(153, 23);
            textBox_imie.TabIndex = 1;
            // 
            // textBox_nazwisko
            // 
            textBox_nazwisko.Location = new Point(97, 53);
            textBox_nazwisko.Margin = new Padding(3, 2, 3, 2);
            textBox_nazwisko.Name = "textBox_nazwisko";
            textBox_nazwisko.Size = new Size(110, 23);
            textBox_nazwisko.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 24);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 3;
            label3.Text = "Imie:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 55);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 4;
            label4.Text = "Nazwisko:";
            // 
            // UC_DodajProwadzacego
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "UC_DodajProwadzacego";
            Size = new Size(364, 156);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button_dodajProwadzacego;
        private ComboBox comboBox_tytul;
        private Label label2;
        private Label label1;
        private TextBox textBox_imie;
        private TextBox textBox_nazwisko;
        private Label label3;
        private Label label4;
    }
}
