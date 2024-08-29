﻿using System.ComponentModel.DataAnnotations;

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
        public int? AppartmentNo { get; set; }
        public int? ZipCode { get; set; }
    }
}
