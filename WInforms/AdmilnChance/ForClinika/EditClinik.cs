using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WInforms.AdmilnChance
{
    public partial class EditClinik : UserControl
    {
        Form1 Parent;
        public EditClinik(Form1 parent)
        {
            Parent = parent;
            InitializeComponent();
        }

        
        

        private void OKButton_Click(object sender, EventArgs e)
        {
            Parent._checkClinikListForAdmin.BringToFront();
        }
    }
}
