using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationForm.ViewModel
{
    public class RegistrationEditViewModel
    {
        //[Display(Name = "Customer Number")]
        //public string CustomerId { get; set; }

        //[Display(Name = "Customer Name")]
        //public string CustomerName { get; set; }

        [Required]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirm password")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Mobile")]
        public string MobileNo { get; set; }

        [Required]
        [Display(Name = "Country")]
        public string SelectedCountryId { get; set; }
        public IEnumerable<SelectListItem> Countries { get; set; }

        [Required]
        [Display(Name = "City")]
        public string SelectedCityId { get; set; }        
        public IEnumerable<SelectListItem> Cities { get; set; }

        [Display(Name = "Gender")]
        public bool Gender { get; set; }

        [Display(Name = "Terms and Conditions")]
        public bool TermsAccepted { get; set; }
    }
}
