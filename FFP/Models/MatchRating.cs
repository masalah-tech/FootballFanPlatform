using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FFP.Models
{
    public class MatchRating
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Value { get; set; }
        [Required]
        [ForeignKey("Match")]
        public int MatchId { get; set; }
        public Match Match { get; set; }
        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
        public string? Comment { get; set; }
        [Required]
        [Column(TypeName = "Date")]
        public DateTime Date { get; set; }
    }
}
