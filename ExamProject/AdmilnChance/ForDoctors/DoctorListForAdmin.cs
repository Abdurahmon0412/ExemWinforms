using ExamProject;
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
    public partial class DoctorListForAdmin : UserControl
    {
        Form1 Parent;
        public DoctorListForAdmin(Form1 parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void DeleteCLinikButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want delete thsi clinik?", "Delete clinik",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Clinika uchiriladi va 
                Parent._doctorTypesforAdmin.BringToFront();
            }
        }

        private void EditClinikButton_Click(object sender, EventArgs e)
        {
            Parent._editDoctor.BringToFront();
        }

        private void AddClinikButton_Click(object sender, EventArgs e)
        {
            Parent._addDoctor.BringToFront();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Parent._doctorTypesforAdmin.BringToFront();
        }
    }
}
