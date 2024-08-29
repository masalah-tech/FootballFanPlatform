using System.ComponentModel.DataAnnotations;

namespace FFP.Models
{
    public class League
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Color { get; set; }
    }
}
