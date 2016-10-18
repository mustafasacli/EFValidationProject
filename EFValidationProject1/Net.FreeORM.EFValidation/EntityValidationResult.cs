using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Net.FreeORM.EFValidation
{
    public class EntityValidationResult
    {
        public EntityValidationResult(IList<ValidationResult> errors = null)
        {
            Errors = errors ?? new List<ValidationResult>();
        }

        public IList<ValidationResult> Errors { get; private set; }

        public bool HasError
        {
            get
            {
                return Errors.Count > 0;
            }
        }
    }
}