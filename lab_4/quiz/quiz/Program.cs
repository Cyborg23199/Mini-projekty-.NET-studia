using quiz.Modele;
using quiz.Prezenter;

namespace quiz
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Form1 form = new Form1();
            QuizFileService service = new QuizFileService();
            QuizGeneratorPresenter presenter = new QuizGeneratorPresenter(form, service);
            Application.Run(form);
        }
    }
}