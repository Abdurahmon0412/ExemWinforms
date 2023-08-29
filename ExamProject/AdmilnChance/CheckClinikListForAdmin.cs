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

namespace WInforms.AdmilnChance
{
    public partial class CheckClinikListForAdmin : UserControl
    {
        public Form1 Parent;
        public CheckClinikListForAdmin(Form1 parent)
        {
            Parent = parent;
            InitializeComponent();
        }

        private void ClinikasButton_Click(object sender, EventArgs e)
        {
            Parent._clinikListForAdmin.BringToFront();
        }

        private void DoctorsButton_Click(object sender, EventArgs e)
        {
            Parent._doctorTypesforAdmin.BringToFront();
        }

        private void ServicesButton_Click(object sender, EventArgs e)
        {
            Parent._typesService.BringToFront();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Parent._enterorLoginUserControl.BringToFront();
        }
    }
}
