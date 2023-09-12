using System.Text.Json.Serialization;

namespace MyPortfolio.Models
{
    public class LinkModel
    {        
        [JsonPropertyName("destination")]
        public string Destination { get; set; }

        [JsonPropertyName("displayText")]
        public string DisplayText { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }
    }
}
