using System.Text.Json.Serialization;

namespace MyPortfolio.Models
{
    public class DataModel
    {
        [JsonPropertyName("projects")]
        public List<ProjectInfo> Projects { get; set; }

        [JsonPropertyName("categories")]
        public List<CategoryModel> Categories { get; set; }

        [JsonPropertyName("techs")]
        public List<TechModel> Techs { get; set; }
    }
}
