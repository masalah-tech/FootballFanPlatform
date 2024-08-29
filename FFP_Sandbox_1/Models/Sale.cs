using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FFP.Models
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("StoreProduct")]
        public int StoreProductId { get; set; }
        public StoreProduct StoreProduct { get; set; }
        [Required]
        [ForeignKey("User")]
        public int CustomerId { get; set; }
        public User Customer { get; set; }
        [Required]
        [Column(TypeName = "Date")]
        public DateTime Date { get; set; }
    }
}
