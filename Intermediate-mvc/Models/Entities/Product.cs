namespace Intermediate_mvc.Models.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int price { get; set; }
        public Category category { get; set; }
    }
}
