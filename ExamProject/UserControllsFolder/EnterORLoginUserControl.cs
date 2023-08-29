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

namespace WInforms.UserControllsFolder
{
    public partial class EnterORLoginUserControl : UserControl
    {
        public Form1 Parent;
        public EnterORLoginUserControl(Form1 parent)
        {
            Parent = parent;
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Parent._registrationUserControl.BringToFront();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            Parent._clinikList.BringToFront();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            Parent._signInButton.BringToFront();
        }

        private void SugnUpButton_Click(object sender, EventArgs e)
        {
            Parent._registrationUserControl.BringToFront();
        }
    }
}
