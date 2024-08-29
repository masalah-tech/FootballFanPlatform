using System.ComponentModel.DataAnnotations;

namespace FFP.Models
{
    public class AdminRole
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
    }
}
