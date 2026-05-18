using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quiz.Modele;

namespace quiz.Widok.Interfejsy
{
    public interface IQuizGeneratorView
    {
        string QuizName { get; set; }
        string QuestionText { get; set; }
        int SelectedQuestionIndex { get; }

        void DisplayQuestions(List<Question> questions);
        List<Answer> GetAnswersFromUI();
        void SetAnswersInUI(List<Answer> answers);
        void ClearQuestionForm();
        void ShowMessage(string message);

        event EventHandler NewQuizClicked;
        event EventHandler LoadQuizClicked;
        event EventHandler SaveQuizClicked;
        event EventHandler AddQuestionClicked;
        event EventHandler EditQuestionClicked;
        event EventHandler DeleteQuestionClicked;
    }
}
