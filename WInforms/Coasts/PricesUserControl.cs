using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WInforms.Coasts
{
    public partial class PricesUserControl : UserControl
    {
        public Form1 Parent;
        public PricesUserControl(Form1 parent)
        {
            Parent = parent;
            InitializeComponent();
        }


        private void BackButton_Click(object sender, EventArgs e)
        {
            Parent._checkClinik.BringToFront();
        }
    }
}
