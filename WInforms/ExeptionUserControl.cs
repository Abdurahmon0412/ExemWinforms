using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WInforms
{
    public partial class ExeptionUserControl : UserControl
    {
        Form1 Parent;
        public ExeptionUserControl(Form1 parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void ExeptionUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
