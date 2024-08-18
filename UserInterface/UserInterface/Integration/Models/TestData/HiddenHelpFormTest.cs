using Newtonsoft.Json;

namespace UserInterface.Integration.Models.TestData
{
    public class HiddenHelpFormTest
    {
        [JsonProperty("min_height_help_form")]
        public int MinHeightHelpForm { get; set; }

        [JsonProperty("unit_measure")]
        public string UnitMeasure { get; set; }

        [JsonProperty("dimension_parameter")]
        public string DimensionParameter { get; set; }
    }
}
