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
    public partial class DoctorTypesforAdmin : UserControl
    {
        Form1 Parent;
        public DoctorTypesforAdmin(Form1 parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void DoctorTypeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            Parent._doctorListForAdmin.BringToFront();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Parent._checkClinikListForAdmin.BringToFront();
        }

        private void DoctorTypesforAdmin_Load(object sender, EventArgs e)
        {

        }

        private void Confirm_Click(object sender, EventArgs e)
        {

        }
    }
}
