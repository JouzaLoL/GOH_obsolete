using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace GOH.Zastupovani
{
    public partial class Credits : MaterialForm
    {
        public Credits()
        {
            InitializeComponent();
        }

        private void Credits_Load(object sender, EventArgs e)
        {
            logo.Load("http://www.hejcin-absolventi.cz/wp-content/themes/alumnipress/_inc/images/g-logo.png");
            versionLabel.Text = "Verze: " + Assembly.GetExecutingAssembly().GetName().Version;
        }
    }
}
