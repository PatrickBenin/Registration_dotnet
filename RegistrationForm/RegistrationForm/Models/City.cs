using System.ComponentModel.DataAnnotations;

namespace RegistrationForm.Models
{
    public class City
    {
        [Key]
        [MaxLength(2)]
        public string CityId { get; set; }

        [Required]
        public string CityNameEnglish { get; set; }

        [Required]
        public string CountryId { get; set; }
        public Country Country { get; set; }
    }
}
