﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProject.Validation
{
    interface IValidationMediator
    {
        bool HasErrors { get; }
        List<ValidationErrorUnit> Errors { get; }
    }
}