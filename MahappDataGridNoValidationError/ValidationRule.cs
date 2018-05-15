using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahappDataGridNoValidationError
{
    public class ValidationRule : System.Windows.Controls.ValidationRule
    {
        public override System.Windows.Controls.ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            return new System.Windows.Controls.ValidationResult(false, "Always False");

            //return System.Windows.Controls.ValidationResult.ValidResult;
        }
    }
}
