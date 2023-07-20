using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebAppMVC.Models
{
    public class RecipeToCreateItem : ItemIngredients
    {
        [DisplayName("Descripction")]
        public string RecipeDescripction { get; set; }

        public decimal Hours { get; set; }
        
        [DisplayName("Steps")]
        public int StepOfRecipe { get; set; }
    }
}
