namespace Lab_2.Widok.Kontrolki
{
    partial class UC_DodajSale
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
            groupBox2 = new GroupBox();
            numericUpDown_liczbaMiejsc = new NumericUpDown();
            comboBox_wydzial = new ComboBox();
            button_dodajSale = new Button();
            label14 = new Label();
            comboBox_typSali = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label5 = new Label();
            textBox_numerSali = new TextBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_liczbaMiejsc).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox2.Controls.Add(numericUpDown_liczbaMiejsc);
            groupBox2.Controls.Add(comboBox_wydzial);
            groupBox2.Controls.Add(button_dodajSale);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(comboBox_typSali);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBox_numerSali);
            groupBox2.Location = new Point(3, 2);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(266, 183);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dodaj sale:";
            // 
            // numericUpDown_liczbaMiejsc
            // 
            numericUpDown_liczbaMiejsc.Location = new Point(140, 50);
            numericUpDown_liczbaMiejsc.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown_liczbaMiejsc.Name = "numericUpDown_liczbaMiejsc";
            numericUpDown_liczbaMiejsc.Size = new Size(53, 23);
            numericUpDown_liczbaMiejsc.TabIndex = 18;
            // 
            // comboBox_wydzial
            // 
            comboBox_wydzial.FormattingEnabled = true;
            comboBox_wydzial.Location = new Point(139, 78);
            comboBox_wydzial.Name = "comboBox_wydzial";
            comboBox_wydzial.Size = new Size(121, 23);
            comboBox_wydzial.TabIndex = 17;
            // 
            // button_dodajSale
            // 
            button_dodajSale.BackColor = Color.White;
            button_dodajSale.Location = new Point(51, 137);
            button_dodajSale.Name = "button_dodajSale";
            button_dodajSale.Size = new Size(165, 25);
            button_dodajSale.TabIndex = 16;
            button_dodajSale.Text = "Dodaj";
            button_dodajSale.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(33, 137);
            label14.Name = "label14";
            label14.Size = new Size(0, 15);
            label14.TabIndex = 15;
            // 
            // comboBox_typSali
            // 
            comboBox_typSali.FormattingEnabled = true;
            comboBox_typSali.Location = new Point(139, 107);
            comboBox_typSali.Name = "comboBox_typSali";
            comboBox_typSali.Size = new Size(121, 23);
            comboBox_typSali.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 108);
            label10.Name = "label10";
            label10.Size = new Size(49, 15);
            label10.TabIndex = 13;
            label10.Text = "Typ sali:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 81);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 10;
            label9.Text = "Wydzial:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 53);
            label8.Name = "label8";
            label8.Size = new Size(80, 15);
            label8.TabIndex = 9;
            label8.Text = "Liczba miejsc:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 27);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 8;
            label5.Text = "Numer:";
            // 
            // textBox_numerSali
            // 
            textBox_numerSali.Location = new Point(139, 23);
            textBox_numerSali.Margin = new Padding(3, 2, 3, 2);
            textBox_numerSali.Name = "textBox_numerSali";
            textBox_numerSali.Size = new Size(110, 23);
            textBox_numerSali.TabIndex = 6;
            // 
            // UC_DodajSale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Name = "UC_DodajSale";
            Size = new Size(273, 190);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_liczbaMiejsc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private ComboBox comboBox_wydzial;
        private Button button_dodajSale;
        private Label label14;
        private ComboBox comboBox_typSali;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label5;
        private TextBox textBox_numerSali;
        private NumericUpDown numericUpDown_liczbaMiejsc;
    }
}
