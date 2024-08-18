using Newtonsoft.Json;

namespace UserInterface.Framework.Utils
{
    public static class JsonFileReader
    {
        public static T ReadFromFile<T>(string filePath) where T : class
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentException("Путь к файлу не может быть пустым или null.", nameof(filePath));
            }

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"Файл не найден по указанному пути: {filePath}");
            }

            var json = File.ReadAllText(filePath);

            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
