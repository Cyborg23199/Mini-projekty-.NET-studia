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

        /*public void SaveEncrypted(string filePath, Quiz quiz)
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
            File.WriteAllBytes(filePath, encryptedBytes);
        }*/

        public void SaveEncrypted(string filePath, Quiz quiz)
        {
            string json = JsonSerializer.Serialize(quiz);
            byte[] jsonBytes = Encoding.UTF8.GetBytes(json);

            using (Aes aes = Aes.Create())
            {
                aes.Key = _key;
                aes.GenerateIV();

                byte[] iv = aes.IV;

                using (var encryptor = aes.CreateEncryptor())
                using (var ms = new MemoryStream())
                {
                    ms.Write(iv, 0, iv.Length);

                    using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        cs.Write(jsonBytes, 0, jsonBytes.Length);
                    }

                    File.WriteAllBytes(filePath, ms.ToArray());
                }
            }
        }

        public Quiz LoadDecrypted(string filePath)
        {
            byte[] allFileBytes = File.ReadAllBytes(filePath);

            byte[] iv = new byte[16];
            byte[] ciphertext = new byte[allFileBytes.Length - 16];

            Buffer.BlockCopy(allFileBytes, 0, iv, 0, 16);
            Buffer.BlockCopy(allFileBytes, 16, ciphertext, 0, ciphertext.Length);

            using (Aes aes = Aes.Create())
            {
                aes.Key = _key;
                aes.IV = iv;

                using (var decryptor = aes.CreateDecryptor())
                using (var ms = new MemoryStream(ciphertext))
                using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                using (var sr = new StreamReader(cs))
                {
                    string jsonText = sr.ReadToEnd();
                    return JsonSerializer.Deserialize<Quiz>(jsonText);
                }
            }
        }
        /*public Quiz LoadDecrypted(string filePath)
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
        }*/
    }
}
