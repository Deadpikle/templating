﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.TemplateEngine.Core.Contracts
{
    public interface IReplacementTokens
    {
        string VariableName { get; }

        string OriginalValue { get; }
    }
}
