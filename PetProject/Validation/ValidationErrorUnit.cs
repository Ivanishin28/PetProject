using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProject.Validation
{
    internal class ValidationErrorUnit
    {
        public ValidationErrorUnit(int id, BizLogicErrors error)
        {
            RowId = id;
            BizLogicError = error;
        }
        static Dictionary<BizLogicErrors, string> dictionary
            = new Dictionary<BizLogicErrors, string>()
            {
                {BizLogicErrors.Error, "Something went wrong!" },
                {BizLogicErrors.EmptyLine, "Empty line!" },
            };
        public int RowId { get; set; }
        public BizLogicErrors BizLogicError { get; set; }
        public override string ToString()
        {
            return $"Line {RowId}: {dictionary[BizLogicError]}";
        }
    }
}
