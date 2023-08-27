using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WInforms.AdmilnChance.ForClinika
{
    public partial class AddClinika : UserControl
    {
        Form1 Parent;
        public AddClinika(Form1 parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Parent._checkClinikListForAdmin.BringToFront();
        }
    }
}
