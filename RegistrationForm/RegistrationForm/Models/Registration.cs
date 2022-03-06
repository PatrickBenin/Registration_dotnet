using RegistrationForm.Attributes;
using System.ComponentModel.DataAnnotations;

namespace RegistrationForm.Models
{
    public class Registration
    {
        [Required(ErrorMessage = "Please Enter Email Address")]
        [Display(Name = "UserName")]
        [RegularExpression(".+@.+\\..+", ErrorMessage = "Please Enter Correct Email Address")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Enter Confirm Password")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Country")]        
        public string? CountryId { get; set; }
        public Country Country { get; set; }

        [Required]
        [Display(Name = "City")]
        public string? CityId { get; set; }
        public City City { get; set; }

        [Required(ErrorMessage = "Please Enter Address")]
        [Display(Name = "Address")]
        [StringLength(200)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please Enter Mobile No")]
        [Display(Name = "Mobile")]
        [StringLength(10, ErrorMessage = "The Mobile must contains 10 characters", MinimumLength = 10)]
        public string MobileNo { get; set; }

        
        [Required(ErrorMessage = "Please select the Gender!")]
        [Display(Name = "Gender")]       
        public string Gender { get; set; }

        
        [Display(Name = "Terms and Conditions")]
        [ValidateCheckBox(ErrorMessage = "Please Accept the Terms & Conditions!")]
        public bool TermsAccepted { get; set; }
    }

    

   }