using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace CultureHelper
{
    public interface ICultureHelper
    {
        IEnumerable<string> SupportedCultureNames { get; }
        IEnumerable<CultureInfo> SupportedCultures { get; }
    }
}
