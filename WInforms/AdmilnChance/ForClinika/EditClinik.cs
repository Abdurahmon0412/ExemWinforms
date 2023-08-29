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
    public partial class EditClinik : UserControl
    {
        Form1 Parent;
        public EditClinik(Form1 parent)
        {
            Parent = parent;
            InitializeComponent();
        }

        
        

        private void OKButton_Click(object sender, EventArgs e)
        {
            Parent._checkClinikListForAdmin.BringToFront();
        }

        private void EditPhoneNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void ChangeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmCall_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmName_Click(object sender, EventArgs e)
        {

        }

        private void ChangeCallSenter_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditNameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
