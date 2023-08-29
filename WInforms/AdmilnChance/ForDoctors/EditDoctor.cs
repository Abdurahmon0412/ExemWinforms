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
    public partial class EditDoctor : UserControl
    {
        Form1 Parent;
        public EditDoctor(Form1 parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Editroom_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Parent._checkClinikListForAdmin.BringToFront();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Parent._checkClinikListForAdmin.BringToFront();

        }
    }
}
