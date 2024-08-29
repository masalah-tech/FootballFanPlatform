using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FFP.Models
{
    public class ProductReview
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
        [Required]
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        [Required]
        public int Value { get; set; }
        public string? Comment { get; set; }
        [Required]
        [Column(TypeName = "Date")]
        public DateTime Date { get; set; }
    }
}
