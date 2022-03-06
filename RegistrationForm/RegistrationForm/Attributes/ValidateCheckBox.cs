using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace RegistrationForm.Attributes
{
    public class ValidateCheckBox: ValidationAttribute, IClientModelValidator
    {
        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val-checkbox", ErrorMessage);
        }

        public override bool IsValid(object value)
        {
            return (bool)value; 
        }
    }
}
