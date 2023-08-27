using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WInforms.UserControllsFolder;

namespace WInforms.Clinicas
{
    public partial class ClinikList : UserControl
    {
        public Form1 Parent;
        public ClinikList(Form1 parent)
        {
            Parent = parent;
            InitializeComponent();
        }

        private void MedPlusButton_Click(object sender, EventArgs e)
        {
            /// agar user bulib kirsa
            Parent._checkClinik.BringToFront();
        }

        private void ShifoMedButton_Click(object sender, EventArgs e)
        {
            Parent._checkClinik.BringToFront();
        }

        private void HayotButton_Click(object sender, EventArgs e)
        {
            Parent._checkClinik.BringToFront();
        }

        private void GuanJouButton_Click(object sender, EventArgs e)
        {
            Parent._checkClinik.BringToFront();
        }

        private void DarmonButton_Click(object sender, EventArgs e)
        {
            Parent._checkClinik.BringToFront();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Parent._enterorLoginUserControl.BringToFront();

        }
    }
}
