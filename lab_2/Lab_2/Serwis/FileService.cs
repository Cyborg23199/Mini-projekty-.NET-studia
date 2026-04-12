using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lab_2.Serwis
{
    internal class FileService
    {
        public static void ZapiszDane<T>(string nazwaPliku, T dane)
        {
            var opcje = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(dane);
            File.WriteAllText(nazwaPliku, json);
        }

        public static T WczytajDane<T>(string nazwaPliku) where T : new()
        {
            if (!File.Exists(nazwaPliku)) return new T();
            string json = File.ReadAllText(nazwaPliku);
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}
