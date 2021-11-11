using Newtonsoft.Json;

namespace CodeExamples
{
    public class DeviceInfo
    {
        public string Manufacturer { get; set; }

        [JsonProperty("Serial Number")]
        public string SerialNumber { get; set; }

        [JsonProperty("Product Name")]
        public string ProductName { get; set; }
    }
}
