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
    public partial class ClinikListForAdmin : UserControl
    {
        public Form1 Parent;
        public ClinikListForAdmin(Form1 parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void DeleteCLinikButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want delete thsi clinik?", "Delete clinik",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Clinika uchiriladi va 
                Parent._checkClinikListForAdmin.BringToFront();
            }
        }

        private void EditClinikButton_Click(object sender, EventArgs e)
        {
            Parent._editClinik.BringToFront();
        }

        private void AddClinikButton_Click(object sender, EventArgs e)
        {
            Parent._addClinik.BringToFront();

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Parent._checkClinikListForAdmin.BringToFront();

        }
    }
}
