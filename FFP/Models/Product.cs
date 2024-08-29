using System.ComponentModel.DataAnnotations;

namespace FFP.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public double? OldPrice { get; set; }
        [Required]
        public double NewPrice { get; set; }
        [Required]
        public string MainPosterPath { get; set; }
    }
}
