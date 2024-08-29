using System.ComponentModel.DataAnnotations;

namespace FFP.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string EncPassword { get; set; }
        public string? PhotoPath { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}
