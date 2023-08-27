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
    public partial class SignInButton : UserControl
    {
        public Form1 Parent;
        public SignInButton(Form1 parent)
        {
            Parent = parent;
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            //if agar Admin bulsa 
                Parent._checkClinikListForAdmin.BringToFront();
            //else  User bulsa: 
                //Parent._clinikList.BringToFront();

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Parent._checkClinikListForAdmin.BringToFront();
        }
    }
}
