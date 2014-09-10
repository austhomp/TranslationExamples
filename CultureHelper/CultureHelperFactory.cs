using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureHelper
{
    public class CultureHelperFactory
    {
        private static ICultureHelper _instance;
        public ICultureHelper Create()
        {
            if (_instance == null)
            {
                _instance = new CultureHelper() as ICultureHelper;
            }

            return _instance;
        }
    }
}
