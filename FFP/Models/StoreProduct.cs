using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FFP.Models
{
    public class StoreProduct
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("Store")]
        public int StoreId { get; set; }
        public Store Store { get; set; }
        [Required]
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        [Required]
        public int InStock { get; set; }
    }
}
