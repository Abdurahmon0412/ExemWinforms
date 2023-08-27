using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WInforms.Clinicas;

namespace WInforms.UserControllsFolder
{
    public partial class RegistrationUserControl : UserControl
    {
        Form1 Parent;
        public RegistrationUserControl(Form1 parent)
        {
            //ClinikCombobox.Items.Clear();
            //foreach(var item in "dadas")
            Parent = parent;
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegistrationUserControl_Load(object sender, EventArgs e)
        {
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Parent._enterorLoginUserControl.BringToFront();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            Parent._clinikList.BringToFront();
        }

        private void ClinikCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var s = ClinikCombobox.Text;
        }

        private void ClinikCombobox_MouseClick(object sender, MouseEventArgs e)
        {
            //ClinikCombobox.Items.Clear();
            //ClinikCombobox.Items.Add("salom");

        }
    }
}