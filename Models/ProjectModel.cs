using System.Text.Json.Serialization;

namespace MyPortfolio.Models
{
    public class ProjectInfo
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonPropertyName("category")]
        public int Category { get; set; }

        [JsonPropertyName("techs")]
        public List<int> Techs { get; set; }

        [JsonPropertyName("links")]
        public List<LinkModel> Links { get; set; }
    }

    public class ProjectModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public CategoryModel Category { get; set; }
        public List<TechModel> Techs { get; set; }
        public List<LinkModel> Links { get; set; }
    }
}
