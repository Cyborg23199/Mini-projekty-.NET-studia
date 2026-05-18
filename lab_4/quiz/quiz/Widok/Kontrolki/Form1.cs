using quiz.Widok.Interfejsy;
using quiz.Modele;

namespace quiz
{
    public partial class Form1 : Form, IQuizGeneratorView
    {
        public Form1()
        {
            InitializeComponent();

            btnNewQuiz.Click += (s, e) => NewQuizClicked?.Invoke(this, EventArgs.Empty);
            btnLoadQuiz.Click += (s, e) => LoadQuizClicked?.Invoke(this, EventArgs.Empty);
            btnSaveQuiz.Click += (s, e) => SaveQuizClicked?.Invoke(this, EventArgs.Empty);

            btnAddQuestion.Click += (s, e) => AddQuestionClicked?.Invoke(this, EventArgs.Empty);
            btnEditQuestion.Click += (s, e) => EditQuestionClicked?.Invoke(this, EventArgs.Empty);
            btnDeleteQuestion.Click += (s, e) => DeleteQuestionClicked?.Invoke(this, EventArgs.Empty);
        }

        public string QuizName { get => txtQuizName.Text; set => txtQuizName.Text = value; }
        public string QuestionText { get => txtQuestion.Text; set => txtQuestion.Text = value; }
        public int SelectedQuestionIndex => listBoxQuestions.SelectedIndex;

        public void DisplayQuestions(List<Question> questions)
        {
            listBoxQuestions.DataSource = null;
            listBoxQuestions.DataSource = questions;
            listBoxQuestions.DisplayMember = "Text";
        }

        public List<Answer> GetAnswersFromUI()
        {
            return new List<Answer>
        {
            new Answer { Text = txtAns1.Text, IsCorrect = chkAns1.Checked },
            new Answer { Text = txtAns2.Text, IsCorrect = chkAns2.Checked },
            new Answer { Text = txtAns3.Text, IsCorrect = chkAns3.Checked },
            new Answer { Text = txtAns4.Text, IsCorrect = chkAns4.Checked }
        };
        }

        public void SetAnswersInUI(List<Answer> answers)
        {
            if (answers == null || answers.Count < 4) return;

            txtAns1.Text = answers[0].Text; chkAns1.Checked = answers[0].IsCorrect;
            txtAns2.Text = answers[1].Text; chkAns2.Checked = answers[1].IsCorrect;
            txtAns3.Text = answers[2].Text; chkAns3.Checked = answers[2].IsCorrect;
            txtAns4.Text = answers[3].Text; chkAns4.Checked = answers[3].IsCorrect;
        }
        public void ClearQuestionForm()
        {
            txtQuestion.Clear();
            txtAns1.Clear(); txtAns2.Clear(); txtAns3.Clear(); txtAns4.Clear();
            chkAns1.Checked = chkAns2.Checked = chkAns3.Checked = chkAns4.Checked = false;
        }

        public void ShowMessage(string message) => MessageBox.Show(message);

        public event EventHandler NewQuizClicked;
        public event EventHandler LoadQuizClicked;
        public event EventHandler SaveQuizClicked;
        public event EventHandler AddQuestionClicked;
        public event EventHandler EditQuestionClicked;
        public event EventHandler DeleteQuestionClicked;
    }
}
