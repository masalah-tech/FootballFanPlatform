using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FFP.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Street { get; set; }
        [DisplayName("Appartment No")]
        public int? AppartmentNo { get; set; }
        [DisplayName("Zip Code")]
        public int? ZipCode { get; set; }
    }
}
