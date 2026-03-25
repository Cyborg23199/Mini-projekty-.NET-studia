namespace Lab_2
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
            textBox_imie = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox_nazwisko = new TextBox();
            textBox_numerSali = new TextBox();
            groupBox1 = new GroupBox();
            comboBox_Tytul = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label5 = new Label();
            groupBox3 = new GroupBox();
            label6 = new Label();
            comboBox2 = new ComboBox();
            listBox_sale = new ListBox();
            listBox_prowadzacy = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // textBox_imie
            // 
            textBox_imie.Location = new Point(97, 20);
            textBox_imie.Margin = new Padding(3, 2, 3, 2);
            textBox_imie.Name = "textBox_imie";
            textBox_imie.Size = new Size(153, 23);
            textBox_imie.TabIndex = 1;
            textBox_imie.KeyPress += tylkoLitery_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 25);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 3;
            label3.Text = "Imie:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 56);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 4;
            label4.Text = "Nazwisko:";
            // 
            // textBox_nazwisko
            // 
            textBox_nazwisko.Location = new Point(97, 53);
            textBox_nazwisko.Margin = new Padding(3, 2, 3, 2);
            textBox_nazwisko.Name = "textBox_nazwisko";
            textBox_nazwisko.Size = new Size(110, 23);
            textBox_nazwisko.TabIndex = 5;
            textBox_nazwisko.KeyPress += tylkoLitery_KeyPress;
            // 
            // textBox_numerSali
            // 
            textBox_numerSali.Location = new Point(97, 52);
            textBox_numerSali.Margin = new Padding(3, 2, 3, 2);
            textBox_numerSali.Name = "textBox_numerSali";
            textBox_numerSali.Size = new Size(110, 23);
            textBox_numerSali.TabIndex = 6;
            textBox_numerSali.KeyPress += tylkoCyfry_KeyPress;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox_Tytul);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox_imie);
            groupBox1.Controls.Add(textBox_nazwisko);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(18, 139);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(321, 144);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodaj prowadzacego:";
            // 
            // comboBox_Tytul
            // 
            comboBox_Tytul.FormattingEnabled = true;
            comboBox_Tytul.Location = new Point(97, 90);
            comboBox_Tytul.Margin = new Padding(3, 2, 3, 2);
            comboBox_Tytul.Name = "comboBox_Tytul";
            comboBox_Tytul.Size = new Size(133, 23);
            comboBox_Tytul.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 93);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 7;
            label2.Text = "Tytul:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 82);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBox_numerSali);
            groupBox2.Location = new Point(18, 22);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(321, 113);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dodaj sale:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 55);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 8;
            label5.Text = "Numer:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(comboBox2);
            groupBox3.Location = new Point(18, 298);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(321, 119);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Zarezerwuj sale:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 55);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 1;
            label6.Text = "Numer sali:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(114, 52);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 0;
            // 
            // listBox_sale
            // 
            listBox_sale.FormattingEnabled = true;
            listBox_sale.ItemHeight = 15;
            listBox_sale.Location = new Point(619, 248);
            listBox_sale.Name = "listBox_sale";
            listBox_sale.Size = new Size(183, 169);
            listBox_sale.TabIndex = 12;
            // 
            // listBox_prowadzacy
            // 
            listBox_prowadzacy.FormattingEnabled = true;
            listBox_prowadzacy.ItemHeight = 15;
            listBox_prowadzacy.Location = new Point(397, 248);
            listBox_prowadzacy.Name = "listBox_prowadzacy";
            listBox_prowadzacy.Size = new Size(184, 169);
            listBox_prowadzacy.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 429);
            Controls.Add(listBox_prowadzacy);
            Controls.Add(listBox_sale);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Rezerwacja sal";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox_imie;
        private Label label3;
        private Label label4;
        private TextBox textBox_nazwisko;
        private TextBox textBox_numerSali;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label1;
        private Label label5;
        private ComboBox comboBox_Tytul;
        private GroupBox groupBox3;
        private Label label6;
        private ComboBox comboBox2;
        private ListBox listBox_sale_dostepne;
        private ListBox listBox_sale;
        private ListBox listBox_prowadzacy;
    }
}
