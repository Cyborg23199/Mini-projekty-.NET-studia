using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using quiz.Modele;

namespace quiz.Modele
{
    public class QuizFileService
    {
        private readonly byte[] _key = Encoding.UTF8.GetBytes("ToJestKluczAES12");
        private readonly byte[] _iv = Encoding.UTF8.GetBytes("WektorInicjalny1");

        public void SaveEncrypted(string filePath, Quiz quiz)
        {
            string json = JsonSerializer.Serialize(quiz);
            byte[] encryptedBytes;

            using (Aes aes = Aes.Create())
            {
                aes.Key = _key;
                aes.IV = _iv;
                using (var encryptor = aes.CreateEncryptor())
                using (var ms = new MemoryStream())
                {
                    using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    using (var sw = new StreamWriter(cs))
                    {
                        sw.Write(json);
                    }
                    encryptedBytes = ms.ToArray();
                }
            }
            //File.WriteAllBytes(filePath, encryptedBytes);
            File.WriteAllText(filePath, json);
        }

        public Quiz LoadDecrypted(string filePath)
        {
            byte[] encryptedBytes = File.ReadAllBytes(filePath);
            string json;

            using (Aes aes = Aes.Create())
            {
                aes.Key = _key;
                aes.IV = _iv;
                using (var decryptor = aes.CreateDecryptor())
                using (var ms = new MemoryStream(encryptedBytes))
                using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                using (var sr = new StreamReader(cs))
                {
                    json = sr.ReadToEnd();
                }
            }
            return JsonSerializer.Deserialize<Quiz>(json);
        }
    }
}
