using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cbend_V2
{
    public partial class Welcome : UserControl
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void SetUpBtn_Click(object sender, EventArgs e)
        {
            MainForm.Instance.PnlContainer.Controls.Clear();
            MainForm.Instance.PnlContainer.Controls.Add(new Login());
        }
    }
}
