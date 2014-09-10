using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CultureHelper
{
    public interface ICultureHelper
    {
        IEnumerable<string> SupportedCultures { get; }
    }
}
