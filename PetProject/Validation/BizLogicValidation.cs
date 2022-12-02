using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProject.Validation
{
    class BizLogicValidation
    {
        private readonly List<ValidationErrorUnit> errors = new List<ValidationErrorUnit>();
        public List<ValidationErrorUnit> Errors => errors;
        public bool HasErrors => errors.Count > 0;
        public void AddError(ValidationErrorUnit error)
        {
            errors.Add(error);
        }
    }
}