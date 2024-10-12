using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp_v2.Presenters.Common
{
    internal class ModelDataValidation
    {
        public void Validate(object model)
        {
            List<ValidationResult> validationResults = new List<ValidationResult>();
            ValidationContext validationContext = new ValidationContext(model);
            bool isValid = Validator.TryValidateObject(
                model, validationContext, validationResults, true);

            if (!isValid)
            {
                
                var firstError = validationResults.FirstOrDefault();
                if (firstError != null)
                {
                    throw new Exception(firstError.ErrorMessage);
                }
            }
        }
    }
}
