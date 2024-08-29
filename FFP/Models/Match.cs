using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FFP.Models
{
    public class Match
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("Club")]
        public int Club1Id { get; set; }
        public Club Club1 { get; set; }
        [Required]
        [ForeignKey("Club")]
        public int Club2Id { get; set; }
        public Club Club2 { get; set; }
        public int? Club1Goals { get; set; }
        public int? Club2Goals { get; set; }
        [Required]
        [ForeignKey("League")]
        public int LeagueId { get; set; }
        public League League { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
    }
}
