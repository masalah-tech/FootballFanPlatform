using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FFP.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,20}$", ErrorMessage = "Password must be 8-20 characters long, contain at least one uppercase letter, one lowercase letter, one number, and one special character.")]
        public string EncPassword { get; set; }
        [Required]
        [ForeignKey("AdminRole")]
        public int AdminRoleId { get; set; }
        public AdminRole AdminRole { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string SecondName { get; set; }
        [Required]
        public string ThirdName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [Column(TypeName = "Date")]
        [Range(typeof(DateTime), "1900-01-01", "2024-12-31", ErrorMessage = "Birth Date must be between January 1, 1900, and December 31, 2024.")]
        public DateTime BirthDate { get; set; } = new DateTime(2000, 1, 1);
        [Required]
        public string PersonalPhotoPath { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Nationality { get; set; }
        [Required]
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}
