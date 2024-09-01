using System.ComponentModel;
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
        [DisplayName("Password")]
        public string EncPassword { get; set; }
        [Required]
        [ForeignKey("AdminRole")]
        [DisplayName("Role")]
        public int AdminRoleId { get; set; }
        public AdminRole AdminRole { get; set; } = new AdminRole();
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Second Name")]
        public string SecondName { get; set; }
        [Required]
        [DisplayName("Third Name")]
        public string ThirdName { get; set; }
        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Required]
        [Column(TypeName = "Date")]
        [DisplayName("Birth Date")]
        public DateTime BirthDate { get; set; } = new DateTime(2000, 1, 1);
        [Required]
        public string PersonalPhotoPath { get; set; } = "/img/user.png";
        [Required]
        public string Email { get; set; }
        [Required]
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }
        [Required]
        public string Nationality { get; set; }
        [Required]
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; } = new Address();
        [Required]
        public bool Status { get; set; } = true;
    }
}
