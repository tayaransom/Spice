using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Spice.Models.ViewModels
{
    public class SubCategoryAndCategoryViewModel
    {
        [ValidateNever]
        public IEnumerable<Category> CategoryList { get; set; } = default!;

        public SubCategory SubCategory { get; set; } = default!;

        [ValidateNever]
        public List<string> SubCategoryList { get; set; } = default!;

        [ValidateNever]
        public string StatusMessage { get; set; } = string.Empty;
    }
}