using Newtonsoft.Json;

namespace UserInterface.Framework.Models
{
    public class Config
    {
        [JsonProperty("base_url")]
        public string BaseUrl { get; set; }

        [JsonProperty("test_data_path")]
        public string[] TestDataPath { get; set; }
    }
}
