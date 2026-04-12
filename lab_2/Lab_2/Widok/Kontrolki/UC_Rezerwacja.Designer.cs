namespace Lab_2.Widok.Kontrolki
{
    partial class UC_Rezerwacja
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
            groupBox3 = new GroupBox();
            dateTimePicker_koniec = new DateTimePicker();
            dateTimePicker_start = new DateTimePicker();
            dateTimePicker_data = new DateTimePicker();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            button_rezerwacja = new Button();
            comboBox_wyborProwadzacego = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            comboBox_wyborSali = new ComboBox();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dateTimePicker_koniec);
            groupBox3.Controls.Add(dateTimePicker_start);
            groupBox3.Controls.Add(dateTimePicker_data);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(button_rezerwacja);
            groupBox3.Controls.Add(comboBox_wyborProwadzacego);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(comboBox_wyborSali);
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(358, 164);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Zarezerwuj sale:";
            // 
            // dateTimePicker_koniec
            // 
            dateTimePicker_koniec.Format = DateTimePickerFormat.Time;
            dateTimePicker_koniec.Location = new Point(183, 102);
            dateTimePicker_koniec.Name = "dateTimePicker_koniec";
            dateTimePicker_koniec.ShowUpDown = true;
            dateTimePicker_koniec.Size = new Size(77, 23);
            dateTimePicker_koniec.TabIndex = 23;
            // 
            // dateTimePicker_start
            // 
            dateTimePicker_start.Format = DateTimePickerFormat.Time;
            dateTimePicker_start.Location = new Point(75, 102);
            dateTimePicker_start.Name = "dateTimePicker_start";
            dateTimePicker_start.ShowUpDown = true;
            dateTimePicker_start.Size = new Size(72, 23);
            dateTimePicker_start.TabIndex = 22;
            // 
            // dateTimePicker_data
            // 
            dateTimePicker_data.Format = DateTimePickerFormat.Short;
            dateTimePicker_data.Location = new Point(97, 73);
            dateTimePicker_data.Name = "dateTimePicker_data";
            dateTimePicker_data.Size = new Size(97, 23);
            dateTimePicker_data.TabIndex = 21;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(44, 75);
            label13.Name = "label13";
            label13.Size = new Size(34, 15);
            label13.TabIndex = 20;
            label13.Text = "Data:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(153, 107);
            label12.Name = "label12";
            label12.Size = new Size(24, 15);
            label12.TabIndex = 19;
            label12.Text = "do:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(43, 107);
            label11.Name = "label11";
            label11.Size = new Size(26, 15);
            label11.TabIndex = 18;
            label11.Text = "Od:";
            // 
            // button_rezerwacja
            // 
            button_rezerwacja.BackColor = Color.White;
            button_rezerwacja.Location = new Point(75, 135);
            button_rezerwacja.Name = "button_rezerwacja";
            button_rezerwacja.Size = new Size(165, 23);
            button_rezerwacja.TabIndex = 15;
            button_rezerwacja.Text = "Rezerwuj";
            button_rezerwacja.UseVisualStyleBackColor = false;
            // 
            // comboBox_wyborProwadzacego
            // 
            comboBox_wyborProwadzacego.FormattingEnabled = true;
            comboBox_wyborProwadzacego.Location = new Point(97, 44);
            comboBox_wyborProwadzacego.Name = "comboBox_wyborProwadzacego";
            comboBox_wyborProwadzacego.Size = new Size(121, 23);
            comboBox_wyborProwadzacego.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 47);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 2;
            label7.Text = "Prowadzacy:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 19);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 1;
            label6.Text = "Numer sali:";
            // 
            // comboBox_wyborSali
            // 
            comboBox_wyborSali.FormattingEnabled = true;
            comboBox_wyborSali.Location = new Point(97, 16);
            comboBox_wyborSali.Name = "comboBox_wyborSali";
            comboBox_wyborSali.Size = new Size(121, 23);
            comboBox_wyborSali.TabIndex = 0;
            // 
            // UC_Rezerwacja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox3);
            Name = "UC_Rezerwacja";
            Size = new Size(365, 169);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private DateTimePicker dateTimePicker_koniec;
        private DateTimePicker dateTimePicker_start;
        private DateTimePicker dateTimePicker_data;
        private Label label13;
        private Label label12;
        private Label label11;
        private Button button_rezerwacja;
        private ComboBox comboBox_wyborProwadzacego;
        private Label label7;
        private Label label6;
        private ComboBox comboBox_wyborSali;
    }
}
