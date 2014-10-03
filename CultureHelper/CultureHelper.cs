using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace CultureHelper
{
    public class CultureHelper : ICultureHelper
    {
        private List<CultureInfo> _cultures;

        public IEnumerable<string> SupportedCultureNames
        {
            get
            {
                if (_cultures == null)
                {
                    _cultures = GetSupportedCultures().ToList();
                }
                
                return _cultures.Select(x => x.DisplayName);
            }
        }
        public IEnumerable<CultureInfo> SupportedCultures
        {
            get
            {
                if (_cultures == null)
                {
                    _cultures = GetSupportedCultures().ToList();
                }
                
                return _cultures.AsReadOnly();
            }
        }

        // Based on this answer http://stackoverflow.com/a/3227549/269608 by Hans Holzbart
        private IEnumerable<CultureInfo> GetSupportedCultures()
        {
            ResourceManager rm = new ResourceManager(typeof(SharedResources.Localized));

            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.AllCultures);
            var supportedCultures = new List<CultureInfo>();
            foreach (CultureInfo culture in cultures)
            {
                try
                {
                    ResourceSet rs = rm.GetResourceSet(culture, true, false);
                    if (rs != null && !string.IsNullOrEmpty(culture.Name))
                    {
                        supportedCultures.Add(culture);
                    }
                }
                catch (CultureNotFoundException exc)
                {
                    // ignore the exception as it means we do not support this culture
                }
            }

            return supportedCultures;
        }
    }
}
