using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SharedResources;

namespace DesktopConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length > 0 && !string.IsNullOrWhiteSpace(args[0]))
                {
                    var newCulture = new CultureInfo(args[0].Trim());
                    Thread.CurrentThread.CurrentCulture = newCulture;
                    Thread.CurrentThread.CurrentUICulture = newCulture;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(@"Caught exception trying to switch language:");
                Console.WriteLine(e);
            }
            Console.WriteLine(Invariants.ApplicationName);
            Console.WriteLine(Localized.Greeting);
            Console.WriteLine(DateTime.Now.ToLongDateString());

        }
    }
}
