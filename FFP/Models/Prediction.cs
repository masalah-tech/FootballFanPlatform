using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FFP.Models
{
    public class Prediction
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
        [Required]
        [ForeignKey("Match")]
        public int MatchId { get; set; }
        public Match Match { get; set; }
        [Required]
        public int PredictedWinnerClub { get; set; }
    }
}
