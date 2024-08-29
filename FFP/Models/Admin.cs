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
        [Required]
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
        public DateTime BirthDate { get; set; }
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
