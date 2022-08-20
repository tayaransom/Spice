namespace Spice.Models.ViewModels
{
    public class MenuItemViewModel
    {
        public MenuItem MenuItem { get; set; } = default!;
        public IEnumerable<Category> Category { get; set; } = default!;
        public IEnumerable<SubCategory> SubCategory { get; set; } = default!;

    }
}
