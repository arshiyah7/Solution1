namespace Intermediate_mvc.Models.Entities
{
    public class Category
    {
        public string Name { get; set; }
        public List<Product> products { get; set; }
        public int Id { get; set; }
    }
}
