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

namespace WInforms.Clinicas
{
    public partial class CheckClinik : UserControl
    {
        public Form1 Parent;
        public CheckClinik(Form1 parent)
        {
            Parent = parent;
            InitializeComponent();
        }



        private void DoctorsButton_Click(object sender, EventArgs e)
        {
            Parent._doctorsListWindow.BringToFront();
            Parent._doctorsListWindow.ShowDatagridForDoctors();

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Parent._clinikList.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CoastsButton_Click(object sender, EventArgs e)
        {
            Parent._priceUserControl.BringToFront();
        }

        private void ServicesButton_Click(object sender, EventArgs e)
        {

        }
    }
}
