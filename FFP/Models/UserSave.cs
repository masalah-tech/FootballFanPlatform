using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FFP.Models
{
    public class UserSave
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("User")]
        public int SavingUserId { get; set; }
        public User SavingUser { get; set; }
        [Required]
        [ForeignKey("User")]
        public int SavedUserId { get; set; }
        public User SavedUser { get; set; }
        [Required]
        [Column(TypeName = "Date")]
        public DateTime Date { get; set; }
    }
}
