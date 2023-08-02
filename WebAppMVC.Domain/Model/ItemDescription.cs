namespace WebAppMVC.Domain.Model
{
    public class ItemDescription
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int ItemRef { get; set; }

        public virtual Item Item { get; set; }
    }
}