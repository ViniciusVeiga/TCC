using System.ComponentModel.DataAnnotations;
using TCC.BusinessLayer.Security;

namespace TCC.UI.CustomValidations
{
    public class EmailExist : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null && BLUser.CheckEmail(value.ToString()))
            {
                return new ValidationResult("E-mail já existe");
            }

            return ValidationResult.Success;
        }
    }
}