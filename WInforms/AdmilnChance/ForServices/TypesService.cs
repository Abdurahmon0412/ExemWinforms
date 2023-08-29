using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WInforms.AdmilnChance.ForServices
{
    public partial class TypesService : UserControl
    {
        Form1 Parent;
        public TypesService(Form1 parent)
        {
            Parent = parent;
            InitializeComponent();
        }

        

        private void AddButton_Click(object sender, EventArgs e)
        {
            Parent._addClinik.BringToFront();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Parent._editService.BringToFront();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want delete thsi clinik?", "Delete clinik",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Clinika uchiriladi va 
                Parent._checkClinikListForAdmin.BringToFront();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Parent._checkClinikListForAdmin.BringToFront();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {

        }
    }
}
