using System.ComponentModel.DataAnnotations;

namespace FFP.Models
{
    public class Club
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LogoPath { get; set; }
    }
}
