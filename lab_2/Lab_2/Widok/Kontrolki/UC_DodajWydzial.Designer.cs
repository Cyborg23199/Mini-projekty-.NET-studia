using Lab_2.Widok.Interfejsy;

namespace Lab_2.Widok.Kontrolki
{
    partial class UC_DodajWydzial
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
            groupBox4 = new GroupBox();
            uC_DodajSale1 = new UC_DodajSale();
            button_dodajWydzial = new Button();
            groupBox5 = new GroupBox();
            label1 = new Label();
            textBox_kodPocztowy2 = new TextBox();
            textBox_numerBudynku = new TextBox();
            textBox_ulica = new TextBox();
            textBox_kodPocztowy1 = new TextBox();
            textBox_miejscowosc = new TextBox();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            textBox_nazwaWydzialu = new TextBox();
            label15 = new Label();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(uC_DodajSale1);
            groupBox4.Controls.Add(button_dodajWydzial);
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Controls.Add(textBox_nazwaWydzialu);
            groupBox4.Controls.Add(label15);
            groupBox4.Location = new Point(2, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(360, 268);
            groupBox4.TabIndex = 16;
            groupBox4.TabStop = false;
            groupBox4.Text = "Dodaj wydzial:";
            // 
            // uC_DodajSale1
            // 
            uC_DodajSale1.Location = new Point(207, 42);
            uC_DodajSale1.Name = "uC_DodajSale1";
            uC_DodajSale1.Size = new Size(8, 8);
            uC_DodajSale1.TabIndex = 5;
            // 
            // button_dodajWydzial
            // 
            button_dodajWydzial.BackColor = Color.White;
            button_dodajWydzial.Location = new Point(130, 226);
            button_dodajWydzial.Name = "button_dodajWydzial";
            button_dodajWydzial.Size = new Size(119, 23);
            button_dodajWydzial.TabIndex = 4;
            button_dodajWydzial.Text = "Dodaj";
            button_dodajWydzial.UseVisualStyleBackColor = false;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label1);
            groupBox5.Controls.Add(textBox_kodPocztowy2);
            groupBox5.Controls.Add(textBox_numerBudynku);
            groupBox5.Controls.Add(textBox_ulica);
            groupBox5.Controls.Add(textBox_kodPocztowy1);
            groupBox5.Controls.Add(textBox_miejscowosc);
            groupBox5.Controls.Add(label19);
            groupBox5.Controls.Add(label18);
            groupBox5.Controls.Add(label17);
            groupBox5.Controls.Add(label16);
            groupBox5.Location = new Point(16, 55);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(331, 158);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            groupBox5.Text = "Adres:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(156, 60);
            label1.Name = "label1";
            label1.Size = new Size(12, 15);
            label1.TabIndex = 9;
            label1.Text = "-";
            // 
            // textBox_kodPocztowy2
            // 
            textBox_kodPocztowy2.Location = new Point(170, 54);
            textBox_kodPocztowy2.Name = "textBox_kodPocztowy2";
            textBox_kodPocztowy2.Size = new Size(53, 23);
            textBox_kodPocztowy2.TabIndex = 8;
            // 
            // textBox_numerBudynku
            // 
            textBox_numerBudynku.Location = new Point(123, 112);
            textBox_numerBudynku.Name = "textBox_numerBudynku";
            textBox_numerBudynku.Size = new Size(100, 23);
            textBox_numerBudynku.TabIndex = 7;
            // 
            // textBox_ulica
            // 
            textBox_ulica.Location = new Point(123, 83);
            textBox_ulica.Name = "textBox_ulica";
            textBox_ulica.Size = new Size(100, 23);
            textBox_ulica.TabIndex = 6;
            // 
            // textBox_kodPocztowy1
            // 
            textBox_kodPocztowy1.Location = new Point(123, 54);
            textBox_kodPocztowy1.Name = "textBox_kodPocztowy1";
            textBox_kodPocztowy1.Size = new Size(30, 23);
            textBox_kodPocztowy1.TabIndex = 5;
            // 
            // textBox_miejscowosc
            // 
            textBox_miejscowosc.Location = new Point(123, 27);
            textBox_miejscowosc.Name = "textBox_miejscowosc";
            textBox_miejscowosc.Size = new Size(100, 23);
            textBox_miejscowosc.TabIndex = 4;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(15, 115);
            label19.Name = "label19";
            label19.Size = new Size(97, 15);
            label19.TabIndex = 3;
            label19.Text = "Numer budynku:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(15, 88);
            label18.Name = "label18";
            label18.Size = new Size(36, 15);
            label18.TabIndex = 2;
            label18.Text = "Ulica:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(15, 60);
            label17.Name = "label17";
            label17.Size = new Size(85, 15);
            label17.TabIndex = 1;
            label17.Text = "Kod pocztowy:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(15, 31);
            label16.Name = "label16";
            label16.Size = new Size(78, 15);
            label16.TabIndex = 0;
            label16.Text = "Miejscowość:";
            // 
            // textBox_nazwaWydzialu
            // 
            textBox_nazwaWydzialu.Location = new Point(84, 26);
            textBox_nazwaWydzialu.Name = "textBox_nazwaWydzialu";
            textBox_nazwaWydzialu.Size = new Size(100, 23);
            textBox_nazwaWydzialu.TabIndex = 2;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(16, 28);
            label15.Name = "label15";
            label15.Size = new Size(45, 15);
            label15.TabIndex = 0;
            label15.Text = "Nazwa:";
            // 
            // UC_DodajWydzial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox4);
            Name = "UC_DodajWydzial";
            Size = new Size(365, 271);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox4;
        private Button button_dodajWydzial;
        private GroupBox groupBox5;
        private TextBox textBox_numerBudynku;
        private TextBox textBox_ulica;
        private TextBox textBox_kodPocztowy1;
        private TextBox textBox_miejscowosc;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private TextBox textBox_nazwaWydzialu;
        private Label label15;
        private TextBox textBox_kodPocztowy2;
        private Label label1;
        private UC_DodajSale uC_DodajSale1;
    }
}
