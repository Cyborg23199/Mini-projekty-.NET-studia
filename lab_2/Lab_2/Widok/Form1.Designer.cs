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
            components = new System.ComponentModel.Container();
            listBox_sale = new ListBox();
            listBox_prowadzacy = new ListBox();
            listBox_rezerwacje = new ListBox();
            errorProvider1 = new ErrorProvider(components);
            listBox_wydzialy = new ListBox();
            uC_DodajWydzial1 = new Lab_2.Widok.Kontrolki.UC_DodajWydzial();
            uC_DodajSale1 = new Lab_2.Widok.Kontrolki.UC_DodajSale();
            uC_DodajProwadzacego1 = new Lab_2.Widok.Kontrolki.UC_DodajProwadzacego();
            uC_Rezerwacja1 = new Lab_2.Widok.Kontrolki.UC_Rezerwacja();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // listBox_sale
            // 
            listBox_sale.FormattingEnabled = true;
            listBox_sale.ItemHeight = 15;
            listBox_sale.Location = new Point(1014, 318);
            listBox_sale.Name = "listBox_sale";
            listBox_sale.Size = new Size(184, 139);
            listBox_sale.TabIndex = 12;
            // 
            // listBox_prowadzacy
            // 
            listBox_prowadzacy.FormattingEnabled = true;
            listBox_prowadzacy.ItemHeight = 15;
            listBox_prowadzacy.Location = new Point(792, 318);
            listBox_prowadzacy.Name = "listBox_prowadzacy";
            listBox_prowadzacy.Size = new Size(189, 139);
            listBox_prowadzacy.TabIndex = 13;
            // 
            // listBox_rezerwacje
            // 
            listBox_rezerwacje.FormattingEnabled = true;
            listBox_rezerwacje.ItemHeight = 15;
            listBox_rezerwacje.Location = new Point(792, 103);
            listBox_rezerwacje.Name = "listBox_rezerwacje";
            listBox_rezerwacje.Size = new Size(405, 154);
            listBox_rezerwacje.TabIndex = 14;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // listBox_wydzialy
            // 
            listBox_wydzialy.FormattingEnabled = true;
            listBox_wydzialy.ItemHeight = 15;
            listBox_wydzialy.Location = new Point(394, 348);
            listBox_wydzialy.Name = "listBox_wydzialy";
            listBox_wydzialy.Size = new Size(360, 109);
            listBox_wydzialy.TabIndex = 22;
            // 
            // uC_DodajWydzial1
            // 
            uC_DodajWydzial1.Location = new Point(394, 25);
            uC_DodajWydzial1.MaximumSize = new Size(370, 275);
            uC_DodajWydzial1.MinimumSize = new Size(370, 275);
            uC_DodajWydzial1.Name = "uC_DodajWydzial1";
            uC_DodajWydzial1.Size = new Size(370, 275);
            uC_DodajWydzial1.TabIndex = 25;
            // 
            // uC_DodajSale1
            // 
            uC_DodajSale1.Location = new Point(61, 5);
            uC_DodajSale1.Name = "uC_DodajSale1";
            uC_DodajSale1.Size = new Size(276, 190);
            uC_DodajSale1.TabIndex = 26;
            // 
            // uC_DodajProwadzacego1
            // 
            uC_DodajProwadzacego1.Location = new Point(7, 190);
            uC_DodajProwadzacego1.Name = "uC_DodajProwadzacego1";
            uC_DodajProwadzacego1.Size = new Size(369, 161);
            uC_DodajProwadzacego1.TabIndex = 27;
            // 
            // uC_Rezerwacja1
            // 
            uC_Rezerwacja1.Location = new Point(6, 348);
            uC_Rezerwacja1.Name = "uC_Rezerwacja1";
            uC_Rezerwacja1.Size = new Size(370, 173);
            uC_Rezerwacja1.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(792, 25);
            label1.Name = "label1";
            label1.Size = new Size(406, 21);
            label1.TabIndex = 29;
            label1.Text = "Listy sa automatycznie zapisywane i czytane z pliku JSON";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(792, 75);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 30;
            label2.Text = "Lista rezerwacji:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(394, 318);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 31;
            label3.Text = "Lista wydzialow:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(792, 287);
            label4.Name = "label4";
            label4.Size = new Size(113, 15);
            label4.TabIndex = 32;
            label4.Text = "Lista prowadzacych:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1014, 285);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 33;
            label5.Text = "Lista sal:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 533);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(uC_Rezerwacja1);
            Controls.Add(uC_DodajProwadzacego1);
            Controls.Add(uC_DodajSale1);
            Controls.Add(uC_DodajWydzial1);
            Controls.Add(listBox_wydzialy);
            Controls.Add(listBox_rezerwacje);
            Controls.Add(listBox_prowadzacy);
            Controls.Add(listBox_sale);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Rezerwacja sal";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listBox_sale_dostepne;
        private ListBox listBox_sale;
        private ListBox listBox_prowadzacy;
        private ListBox listBox_rezerwacje;
        private ErrorProvider errorProvider1;
        private Label myslnik;
        private TextBox textBox_kod2;
        private TextBox textBox_kod1;
        private Label label20;
        private TextBox textBox_miasto;
        private ListBox listBox_wydzialy;
        private Widok.Kontrolki.UC_DodajWydzial uC_DodajWydzial1;
        private Widok.Kontrolki.UC_DodajSale uC_DodajSale1;
        private Widok.Kontrolki.UC_DodajProwadzacego uC_DodajProwadzacego1;
        private Widok.Kontrolki.UC_Rezerwacja uC_Rezerwacja1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
