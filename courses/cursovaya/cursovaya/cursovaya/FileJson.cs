using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace cursovaya
{
    public static class FileJson
    {
        public const string PATH = "data.json";
        public static List<Client> ReadTextJson(string path)
        {
            List<Client> clients = new List<Client>();
            if (File.Exists(path))
            {
                string readText = File.ReadAllText(path);
                foreach (var item in JsonSerializer.Deserialize<List<Client>>(readText))
                {
                    clients.Add(item);
                }
            }
            return clients;

        }
        public static void WriteTextJson(List<Client> clients, string path)
        {
            var options = new JsonSerializerOptions { Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic), WriteIndented = true };
            string text = JsonSerializer.Serialize(clients, options);
            File.WriteAllText(path, text);
        }
    }
}
