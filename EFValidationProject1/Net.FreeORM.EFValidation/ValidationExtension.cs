using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Net.FreeORM.EFValidation
{
    public static class ValidationExtension
    {
        public static EntityValidationResult Validate<T>(this T entity) where T : class
        {
            var validationResults = new List<ValidationResult>();
            var vc = new ValidationContext(entity, null, null);
            var isValid = Validator.TryValidateObject
                    (entity, vc, validationResults, true);

            return new EntityValidationResult(validationResults);
        }
    }
}