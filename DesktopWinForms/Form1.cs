using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var helper = new CultureHelper.CultureHelperFactory().Create();
            foreach (var culture in helper.SupportedCultures)
            {
                languageSelector.Items.Add(culture.IetfLanguageTag);
            }
            
        }

        private void languageSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                RuntimeLocalizer.ChangeCulture(this, languageSelector.SelectedItem.ToString());
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}
