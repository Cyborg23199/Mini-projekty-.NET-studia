namespace lab_3
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
            textBox_City = new TextBox();
            comboBox_Capitals = new ComboBox();
            button_Search = new Button();
            label_Temperature = new Label();
            label_Pressure = new Label();
            label_Humidity = new Label();
            label_Description = new Label();
            pictureBox_Icon = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Icon).BeginInit();
            SuspendLayout();
            // 
            // textBox_City
            // 
            textBox_City.Location = new Point(294, 75);
            textBox_City.Name = "textBox_City";
            textBox_City.Size = new Size(121, 23);
            textBox_City.TabIndex = 0;
            // 
            // comboBox_Capitals
            // 
            comboBox_Capitals.FormattingEnabled = true;
            comboBox_Capitals.Location = new Point(294, 113);
            comboBox_Capitals.Name = "comboBox_Capitals";
            comboBox_Capitals.Size = new Size(121, 23);
            comboBox_Capitals.TabIndex = 1;
            // 
            // button_Search
            // 
            button_Search.Location = new Point(319, 151);
            button_Search.Name = "button_Search";
            button_Search.Size = new Size(75, 23);
            button_Search.TabIndex = 2;
            button_Search.Text = "Wyszukaj";
            button_Search.UseVisualStyleBackColor = true;
            // 
            // label_Temperature
            // 
            label_Temperature.AutoSize = true;
            label_Temperature.Location = new Point(294, 186);
            label_Temperature.Name = "label_Temperature";
            label_Temperature.Size = new Size(17, 15);
            label_Temperature.TabIndex = 3;
            label_Temperature.Text = "--";
            // 
            // label_Pressure
            // 
            label_Pressure.AutoSize = true;
            label_Pressure.Location = new Point(294, 211);
            label_Pressure.Name = "label_Pressure";
            label_Pressure.Size = new Size(17, 15);
            label_Pressure.TabIndex = 4;
            label_Pressure.Text = "--";
            // 
            // label_Humidity
            // 
            label_Humidity.AutoSize = true;
            label_Humidity.Location = new Point(294, 235);
            label_Humidity.Name = "label_Humidity";
            label_Humidity.Size = new Size(17, 15);
            label_Humidity.TabIndex = 5;
            label_Humidity.Text = "--";
            // 
            // label_Description
            // 
            label_Description.AutoSize = true;
            label_Description.Location = new Point(294, 260);
            label_Description.Name = "label_Description";
            label_Description.Size = new Size(17, 15);
            label_Description.TabIndex = 6;
            label_Description.Text = "--";
            // 
            // pictureBox_Icon
            // 
            pictureBox_Icon.BackColor = SystemColors.ActiveCaption;
            pictureBox_Icon.Location = new Point(226, 301);
            pictureBox_Icon.Name = "pictureBox_Icon";
            pictureBox_Icon.Size = new Size(271, 137);
            pictureBox_Icon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Icon.TabIndex = 7;
            pictureBox_Icon.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 174);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(284, 20);
            label2.Name = "label2";
            label2.Size = new Size(141, 30);
            label2.TabIndex = 9;
            label2.Text = "Podaj miasto:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox_Icon);
            Controls.Add(label_Description);
            Controls.Add(label_Humidity);
            Controls.Add(label_Pressure);
            Controls.Add(label_Temperature);
            Controls.Add(button_Search);
            Controls.Add(comboBox_Capitals);
            Controls.Add(textBox_City);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox_Icon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_City;
        private ComboBox comboBox_Capitals;
        private Button button_Search;
        private Label label_Temperature;
        private Label label_Pressure;
        private Label label_Humidity;
        private Label label_Description;
        private PictureBox pictureBox_Icon;
        private Label label1;
        private Label label2;
    }
}
