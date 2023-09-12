using Microsoft.AspNetCore.Components;
using MyPortfolio.Models;
using System.Net.Http.Json;

namespace MyPortfolio.Pages
{
    public class IndexBase : ComponentBase
    {
        [Inject]
        HttpClient Http { get; set; }

        public List<ProjectModel>? Projects { get; set; }
        public List<CategoryModel>? Categories { get; set; }
        public List<TechModel>? Techs { get; set; }
        public DataModel? Data { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Data = await Http.GetFromJsonAsync<DataModel>("data/data.json");

            Categories = Data.Categories;

            Techs = Data.Techs;

            Projects = (from project in Data.Projects
                        join category in Categories
                        on project.Category equals category.Id
                        select new ProjectModel
                        {
                            Id = project.Id,
                            Name = project.Name,
                            Description = project.Description,
                            ImageUrl = project.ImageUrl,
                            Category = category,
                            Techs = (from tech in Techs
                                     where project.Techs.Contains(tech.Id)
                                     select tech).ToList(),
                            Links = project.Links
                        }).ToList();
        }

        protected IOrderedEnumerable<IGrouping<int, ProjectModel>> GetGroupedProjects()
        {
            return from project in Projects
                   group project by project.Category.Id into projectGroup
                   orderby projectGroup.Key
                   select projectGroup;
        }

        protected string GetCategoryName(IGrouping<int, ProjectModel> groupedProjects)
        {
            return groupedProjects.FirstOrDefault(p => p.Category.Id == groupedProjects.Key).Category.Name;
        }
    }
}
