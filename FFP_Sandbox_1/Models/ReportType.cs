using System.ComponentModel.DataAnnotations;

namespace FFP.Models
{
    public class ReportType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
    }
}
