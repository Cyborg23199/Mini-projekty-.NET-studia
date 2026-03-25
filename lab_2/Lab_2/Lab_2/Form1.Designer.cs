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
            textBox4 = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox_imie
            // 
            textBox_imie.Location = new Point(151, 26);
            textBox_imie.Name = "textBox_imie";
            textBox_imie.Size = new Size(174, 27);
            textBox_imie.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 33);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 3;
            label3.Text = "Imie:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 74);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 4;
            label4.Text = "Nazwisko:";
            // 
            // textBox_nazwisko
            // 
            textBox_nazwisko.Location = new Point(200, 71);
            textBox_nazwisko.Name = "textBox_nazwisko";
            textBox_nazwisko.Size = new Size(125, 27);
            textBox_nazwisko.TabIndex = 5;
            // 
            // textBox_numerSali
            // 
            textBox_numerSali.Location = new Point(130, 37);
            textBox_numerSali.Name = "textBox_numerSali";
            textBox_numerSali.Size = new Size(125, 27);
            textBox_numerSali.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(596, 52);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox_imie);
            groupBox1.Controls.Add(textBox_nazwisko);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(62, 212);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(367, 192);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodaj prowadzacego:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBox_numerSali);
            groupBox2.Location = new Point(62, 42);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(367, 151);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dodaj sale:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 110);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 124);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 7;
            label2.Text = "Tytul:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 40);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 8;
            label5.Text = "Numer:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(174, 124);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 572);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(textBox4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox_imie;
        private Label label3;
        private Label label4;
        private TextBox textBox_nazwisko;
        private TextBox textBox_numerSali;
        private TextBox textBox4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label1;
        private Label label5;
        private ComboBox comboBox1;
    }
}
