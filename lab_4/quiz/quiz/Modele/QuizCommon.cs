using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz.Modele
{
    [Serializable]
    public class Answer
    {
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
    }

    [Serializable]
    public class Question
    {
        public string Text { get; set; }
        public List<Answer> Answers { get; set; } = new List<Answer>();
    }

    [Serializable]
    public class Quiz
    {
        public string Name { get; set; }
        public List<Question> Questions { get; set; } = new List<Question>();
    }
}
