using System.ComponentModel.DataAnnotations.Schema;

namespace L7_Layout.Models
{
    [Table("products")]
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public float ProductPrice { get; set; }
        public int ProductSale {  get; set; }
        public bool Stastus { get; set; }
        public int? CategotyId { get; set; }
        public string Image {  get; set; }
        public string Description { get; set; }

        public Category Category { get; set; }
    }
}
