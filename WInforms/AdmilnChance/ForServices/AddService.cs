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
    public partial class AddService : UserControl
    {
        Form1 Parent;
        public AddService(Form1 parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Parent._typesService.BringToFront();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }
    }
}
