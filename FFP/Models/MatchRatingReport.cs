using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FFP.Models
{
    public class MatchRatingReport
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
        [Required]
        [ForeignKey("MatchRating")]
        public int MatchRatingId { get; set; }
        public MatchRating MatchRating { get; set; }
        [Required]
        [ForeignKey("ReportType")]
        public int ReportTypeId { get; set; }
        public ReportType ReportType { get; set; }
        [Required]
        [Column(TypeName = "Date")]
        public DateTime Date { get; set; }
    }
}
