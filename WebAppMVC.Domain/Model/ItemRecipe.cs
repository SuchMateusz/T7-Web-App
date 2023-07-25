namespace WebAppMVC.Domain.Model
{
    public class ItemRecipe
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int ItemId { get; set; }

        public virtual Item Item { get; set; }
    }
}