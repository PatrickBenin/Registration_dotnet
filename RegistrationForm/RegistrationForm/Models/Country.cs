using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RegistrationForm.Models
{
    public class Country
    {
        [Key]
        [MaxLength(2)]
        public string CountryId { get; set; }

        [Required]
        [MaxLength(50)]
        public string CountryNameEnglish { get; set; }
        public List<City> Cities { get; set; }
    }
}
