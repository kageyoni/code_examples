using CodeExamples.Utils;
using Newtonsoft.Json;
using System;
using System.IO;

namespace CodeExamples.Examples
{
    public static class JsonDeserializationExample
    {
        private const string JSON_FILE_NAME = "DeviceInfo.json";
        private const string JSON_FILE_DIR = "JSON";
        public static void Run()
        {
            // Получаем текущую директорию
            var currentDir = AppDomain.CurrentDomain.BaseDirectory;

            // Строим путь до файла json
            var jsonFilePath = Path.Combine(currentDir, JSON_FILE_DIR, JSON_FILE_NAME);

            // Читаем json
            var jsonContent = FileUtils.ReadFromFile(jsonFilePath);

            // Десериализуем json
            var deviceInfo = JsonConvert.DeserializeObject<DeviceInfo>(jsonContent);

            Console.WriteLine("Успех!");
            Console.WriteLine("Manufacturer: " + deviceInfo.Manufacturer);
            Console.WriteLine("ProductName: " + deviceInfo.ProductName);
            Console.WriteLine("SerialNumber: " + deviceInfo.SerialNumber);
        }
    }
}
