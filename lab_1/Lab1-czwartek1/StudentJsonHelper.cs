
using System.Text.Json;

namespace Lab1_czwartek1
{
    internal static class StudentJsonHelper
    {
        private static readonly JsonSerializerOptions _options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        public static void ZapiszDoPliku(string sciezka, List<Student> studenci)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(studenci, _options);

                File.WriteAllText(sciezka, jsonString);
            }
            catch (Exception ex)
            {
                throw new Exception($"Błąd podczas zapisu do pliku: {ex.Message}");
            }
        }

        public static List<Student> OdczytajZPliku(string sciezka)
        {
            try
            {
                if (!File.Exists(sciezka))
                    return new List<Student>();

                string jsonString = File.ReadAllText(sciezka);

                return JsonSerializer.Deserialize<List<Student>>(jsonString);
            }
            catch (Exception ex)
            {
                throw new Exception($"Błąd podczas odczytu z pliku: {ex.Message}");
            }
        }
    }
}
