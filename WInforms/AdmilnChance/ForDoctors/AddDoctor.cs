using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WInforms.AdmilnChance.ForDoctors
{
    public partial class AddDoctor : UserControl
    {
        Form1 Parent;
        public AddDoctor(Form1 parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Parent._checkClinikListForAdmin.BringToFront();
        }
    }
}
