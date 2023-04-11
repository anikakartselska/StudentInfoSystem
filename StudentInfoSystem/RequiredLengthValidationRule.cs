using System.Globalization;
using System.Windows.Controls;

namespace StudentInfoSystem
{
    public class RequiredLengthValidationRule : ValidationRule
    {
        public string ErrorMessage { get; set; }
        public int MinLength { get; set; }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (string.IsNullOrEmpty(value as string) || ((string)value).Length < MinLength)
            {
                return new ValidationResult(false, ErrorMessage);
            }

            return ValidationResult.ValidResult;
        }
    }
}