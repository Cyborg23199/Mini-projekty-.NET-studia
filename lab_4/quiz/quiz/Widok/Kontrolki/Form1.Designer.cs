namespace quiz
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
            groupBox1 = new GroupBox();
            btnSaveQuiz = new Button();
            btnLoadQuiz = new Button();
            btnNewQuiz = new Button();
            label1 = new Label();
            txtQuizName = new TextBox();
            groupBox2 = new GroupBox();
            btnAddQuestion = new Button();
            txtAns4 = new TextBox();
            txtAns3 = new TextBox();
            txtAns2 = new TextBox();
            txtAns1 = new TextBox();
            chkAns4 = new CheckBox();
            chkAns3 = new CheckBox();
            chkAns2 = new CheckBox();
            chkAns1 = new CheckBox();
            label3 = new Label();
            txtQuestion = new TextBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            btnDeleteQuestion = new Button();
            btnEditQuestion = new Button();
            listBoxQuestions = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSaveQuiz);
            groupBox1.Controls.Add(btnLoadQuiz);
            groupBox1.Controls.Add(btnNewQuiz);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtQuizName);
            groupBox1.Location = new Point(12, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Konfiguracja Quizu";
            // 
            // btnSaveQuiz
            // 
            btnSaveQuiz.Location = new Point(547, 63);
            btnSaveQuiz.Name = "btnSaveQuiz";
            btnSaveQuiz.Size = new Size(195, 23);
            btnSaveQuiz.TabIndex = 4;
            btnSaveQuiz.Text = "Zapisz";
            btnSaveQuiz.UseVisualStyleBackColor = true;
            // 
            // btnLoadQuiz
            // 
            btnLoadQuiz.Location = new Point(275, 63);
            btnLoadQuiz.Name = "btnLoadQuiz";
            btnLoadQuiz.Size = new Size(193, 23);
            btnLoadQuiz.TabIndex = 3;
            btnLoadQuiz.Text = "Wczytaj";
            btnLoadQuiz.UseVisualStyleBackColor = true;
            // 
            // btnNewQuiz
            // 
            btnNewQuiz.Location = new Point(30, 63);
            btnNewQuiz.Name = "btnNewQuiz";
            btnNewQuiz.Size = new Size(187, 23);
            btnNewQuiz.TabIndex = 2;
            btnNewQuiz.Text = "Nowy";
            btnNewQuiz.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(231, 25);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 1;
            label1.Text = "Nazwa quizu:";
            // 
            // txtQuizName
            // 
            txtQuizName.Location = new Point(314, 22);
            txtQuizName.Name = "txtQuizName";
            txtQuizName.Size = new Size(268, 23);
            txtQuizName.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAddQuestion);
            groupBox2.Controls.Add(txtAns4);
            groupBox2.Controls.Add(txtAns3);
            groupBox2.Controls.Add(txtAns2);
            groupBox2.Controls.Add(txtAns1);
            groupBox2.Controls.Add(chkAns4);
            groupBox2.Controls.Add(chkAns3);
            groupBox2.Controls.Add(chkAns2);
            groupBox2.Controls.Add(chkAns1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtQuestion);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(12, 136);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(396, 287);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dodaj / Edytuj Pytanie";
            // 
            // btnAddQuestion
            // 
            btnAddQuestion.Location = new Point(128, 257);
            btnAddQuestion.Name = "btnAddQuestion";
            btnAddQuestion.Size = new Size(142, 23);
            btnAddQuestion.TabIndex = 11;
            btnAddQuestion.Text = "Dodaj";
            btnAddQuestion.UseVisualStyleBackColor = true;
            // 
            // txtAns4
            // 
            txtAns4.Location = new Point(61, 222);
            txtAns4.Name = "txtAns4";
            txtAns4.Size = new Size(306, 23);
            txtAns4.TabIndex = 10;
            // 
            // txtAns3
            // 
            txtAns3.Location = new Point(61, 188);
            txtAns3.Name = "txtAns3";
            txtAns3.Size = new Size(306, 23);
            txtAns3.TabIndex = 9;
            // 
            // txtAns2
            // 
            txtAns2.Location = new Point(61, 152);
            txtAns2.Name = "txtAns2";
            txtAns2.Size = new Size(306, 23);
            txtAns2.TabIndex = 8;
            // 
            // txtAns1
            // 
            txtAns1.Location = new Point(61, 116);
            txtAns1.Name = "txtAns1";
            txtAns1.Size = new Size(306, 23);
            txtAns1.TabIndex = 7;
            // 
            // chkAns4
            // 
            chkAns4.AutoSize = true;
            chkAns4.Location = new Point(9, 226);
            chkAns4.Name = "chkAns4";
            chkAns4.Size = new Size(15, 14);
            chkAns4.TabIndex = 6;
            chkAns4.UseVisualStyleBackColor = true;
            // 
            // chkAns3
            // 
            chkAns3.AutoSize = true;
            chkAns3.Location = new Point(9, 190);
            chkAns3.Name = "chkAns3";
            chkAns3.Size = new Size(15, 14);
            chkAns3.TabIndex = 5;
            chkAns3.UseVisualStyleBackColor = true;
            // 
            // chkAns2
            // 
            chkAns2.AutoSize = true;
            chkAns2.Location = new Point(9, 156);
            chkAns2.Name = "chkAns2";
            chkAns2.Size = new Size(15, 14);
            chkAns2.TabIndex = 4;
            chkAns2.UseVisualStyleBackColor = true;
            // 
            // chkAns1
            // 
            chkAns1.AutoSize = true;
            chkAns1.Location = new Point(9, 120);
            chkAns1.Name = "chkAns1";
            chkAns1.Size = new Size(15, 14);
            chkAns1.TabIndex = 3;
            chkAns1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 92);
            label3.Name = "label3";
            label3.Size = new Size(232, 15);
            label3.TabIndex = 2;
            label3.Text = "Odpowiedzi (zaznacz wszystkie poprawne):";
            // 
            // txtQuestion
            // 
            txtQuestion.Location = new Point(6, 53);
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(361, 23);
            txtQuestion.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 35);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 0;
            label2.Text = "Tresc pytania:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnDeleteQuestion);
            groupBox3.Controls.Add(btnEditQuestion);
            groupBox3.Controls.Add(listBoxQuestions);
            groupBox3.Location = new Point(440, 136);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(348, 287);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Lista pytan";
            // 
            // btnDeleteQuestion
            // 
            btnDeleteQuestion.Location = new Point(177, 238);
            btnDeleteQuestion.Name = "btnDeleteQuestion";
            btnDeleteQuestion.Size = new Size(153, 23);
            btnDeleteQuestion.TabIndex = 2;
            btnDeleteQuestion.Text = "Usun";
            btnDeleteQuestion.UseVisualStyleBackColor = true;
            // 
            // btnEditQuestion
            // 
            btnEditQuestion.Location = new Point(17, 238);
            btnEditQuestion.Name = "btnEditQuestion";
            btnEditQuestion.Size = new Size(154, 23);
            btnEditQuestion.TabIndex = 1;
            btnEditQuestion.Text = "Edytuj";
            btnEditQuestion.UseVisualStyleBackColor = true;
            // 
            // listBoxQuestions
            // 
            listBoxQuestions.FormattingEnabled = true;
            listBoxQuestions.ItemHeight = 15;
            listBoxQuestions.Location = new Point(17, 35);
            listBoxQuestions.Name = "listBoxQuestions";
            listBoxQuestions.Size = new Size(313, 169);
            listBoxQuestions.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Generator Quizow";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSaveQuiz;
        private Button btnLoadQuiz;
        private Button btnNewQuiz;
        private Label label1;
        private TextBox txtQuizName;
        private GroupBox groupBox2;
        private Label label2;
        private Label label3;
        private TextBox txtQuestion;
        private CheckBox chkAns4;
        private CheckBox chkAns3;
        private CheckBox chkAns2;
        private CheckBox chkAns1;
        private TextBox txtAns4;
        private TextBox txtAns3;
        private TextBox txtAns2;
        private TextBox txtAns1;
        private Button btnAddQuestion;
        private GroupBox groupBox3;
        private ListBox listBoxQuestions;
        private Button btnDeleteQuestion;
        private Button btnEditQuestion;
    }
}
