using lab_3.Prezenter;

namespace lab_3
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 view = new Form1();
            var model = new lab_3.Modele.WeatherService();
            var presenter = new WeatherPresenter(view, model);

            Application.Run(view);
        }
    }
}