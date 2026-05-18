using quiz.Modele;
using quiz.Widok.Interfejsy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz.Prezenter
{
    public class QuizGeneratorPresenter
    {
        private readonly IQuizGeneratorView _view;
        private readonly QuizFileService _fileService;
        private Quiz _currentQuiz;
        private int _editingIndex = -1;

        public QuizGeneratorPresenter(IQuizGeneratorView view, QuizFileService fileService)
        {
            _view = view;
            _fileService = fileService;
            _currentQuiz = new Quiz();

            _view.NewQuizClicked += OnNewQuiz;
            _view.LoadQuizClicked += OnLoadQuiz;
            _view.SaveQuizClicked += OnSaveQuiz;

            _view.AddQuestionClicked += OnAddOrUpdateQuestion;
            _view.EditQuestionClicked += OnEditQuestion;
            _view.DeleteQuestionClicked += OnDeleteQuestion;
        }

        private void OnNewQuiz(object sender, EventArgs e)
        {
            _currentQuiz = new Quiz();
            _view.QuizName = "";
            _view.ClearQuestionForm();
            _view.DisplayQuestions(_currentQuiz.Questions);
            _editingIndex = -1;
        }

        private void OnAddOrUpdateQuestion(object sender, EventArgs e)
        {
            var answers = _view.GetAnswersFromUI();

            if (string.IsNullOrWhiteSpace(_view.QuestionText))
            {
                _view.ShowMessage("Treść pytania nie może być pusta!");
                return;
            }
            if (answers.Any(a => string.IsNullOrWhiteSpace(a.Text)))
            {
                _view.ShowMessage("Wszystkie 4 odpowiedzi muszą być uzupełnione!");
                return;
            }
            if (!answers.Any(a => a.IsCorrect))
            {
                _view.ShowMessage("Przynajmniej jedna odpowiedź musi być zaznaczona jako poprawna!");
                return;
            }

            if (_editingIndex == -1)
            {
                var newQuestion = new Question { Text = _view.QuestionText, Answers = answers };
                _currentQuiz.Questions.Add(newQuestion);
            }
            else
            {
                _currentQuiz.Questions[_editingIndex].Text = _view.QuestionText;
                _currentQuiz.Questions[_editingIndex].Answers = answers;
                _editingIndex = -1;
            }

            _view.ClearQuestionForm();
            _view.DisplayQuestions(_currentQuiz.Questions);
        }

        private void OnEditQuestion(object sender, EventArgs e)
        {
            int index = _view.SelectedQuestionIndex;
            if (index < 0 || index >= _currentQuiz.Questions.Count)
            {
                _view.ShowMessage("Wybierz pytanie z listy, które chcesz edytować!");
                return;
            }

            _editingIndex = index;
            var questionToEdit = _currentQuiz.Questions[index];

            _view.QuestionText = questionToEdit.Text;
            _view.SetAnswersInUI(questionToEdit.Answers);
        }

        private void OnDeleteQuestion(object sender, EventArgs e)
        {
            int index = _view.SelectedQuestionIndex;
            if (index < 0 || index >= _currentQuiz.Questions.Count)
            {
                _view.ShowMessage("Wybierz pytanie z listy, które chcesz usunąć!");
                return;
            }

            _currentQuiz.Questions.RemoveAt(index);
            _view.DisplayQuestions(_currentQuiz.Questions);
            _view.ClearQuestionForm();
            _editingIndex = -1;
        }

        private void OnSaveQuiz(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_view.QuizName))
            {
                _view.ShowMessage("Podaj nazwę quizu przed zapisem!");
                return;
            }
            if (_currentQuiz.Questions.Count == 0)
            {
                _view.ShowMessage("Nie można zapisać pustego quizu. Dodaj najpierw pytania!");
                return;
            }

            _currentQuiz.Name = _view.QuizName;

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Pliki quizu (*.dat)|*.dat";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _fileService.SaveEncrypted(sfd.FileName, _currentQuiz);
                        _view.ShowMessage("Quiz został pomyślnie zaszyfrowany i zapisany!");
                    }
                    catch (Exception ex)
                    {
                        _view.ShowMessage($"Błąd zapisu: {ex.Message}");
                    }
                }
            }
        }

        private void OnLoadQuiz(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Pliki quizu (*.dat)|*.dat";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _currentQuiz = _fileService.LoadDecrypted(ofd.FileName);
                        _view.QuizName = _currentQuiz.Name;
                        _view.DisplayQuestions(_currentQuiz.Questions);
                        _view.ClearQuestionForm();
                        _editingIndex = -1;
                        _view.ShowMessage("Quiz wczytany i odszyfrowany pomyślnie!");
                    }
                    catch (Exception ex)
                    {
                        _view.ShowMessage($"Błąd odczytu (upewnij się, że klucz AES jest poprawny): {ex.Message}");
                    }
                }
            }
        }
    }
}
