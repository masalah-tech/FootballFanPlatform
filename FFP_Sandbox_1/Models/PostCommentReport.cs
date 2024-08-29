using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FFP.Models
{
    public class PostCommentReport
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
        [Required]
        [ForeignKey("PostComment")]
        public int PostCommentId { get; set; }
        public PostComment PostComment { get; set; }
        [Required]
        [ForeignKey("ReportType")]
        public int ReportTypeId { get; set; }
        public ReportType ReportType { get; set; }
        [Required]
        [Column(TypeName = "Date")]
        public DateTime Date { get; set; }
    }
}
