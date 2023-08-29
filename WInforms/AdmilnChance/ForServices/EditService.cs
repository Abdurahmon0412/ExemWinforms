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
    public partial class EditService : UserControl
    {
        Form1 Parent;
        public EditService(Form1 parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void EditService_Load(object sender, EventArgs e)
        {

        }

        

        private void EditServicePrice_TextChanged(object sender, EventArgs e)
        {

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
