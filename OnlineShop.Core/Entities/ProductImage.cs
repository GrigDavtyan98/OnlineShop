using System.ComponentModel.DataAnnotations.Schema;
namespace OnlineShop.Core.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
