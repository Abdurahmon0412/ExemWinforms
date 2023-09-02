using Backend;
using Backend.ServiceLayer.MedServiceServices;
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

namespace WInforms.AdmilnChance.ForServices
{
    public partial class EditService : UserControl
    {
        Form1 Parent;
        private Medservice _newMedservice;
        private IMedService _service;
        public EditService(Form1 parent, IMedService service)
        {
            InitializeComponent();
            Parent = parent;
            _service = service;
            _newMedservice = new Medservice();
        }





        private void ExitButton_Click(object sender, EventArgs e)
        {
            Parent._typesService.medServiceId = 0;
            Parent._typesService.ShowDatagridMedService();
            Parent._typesService.BringToFront();
        }

        private void AddButton_Click(object sender, EventArgs e) //Add urniga Edit bulishi kerak!
        {
            if (IsvValidPrice(EditServicePrice.Text))
            {
                _newMedservice.Id = Parent._typesService.medServiceId;
                _newMedservice.ServicePrice = Convert.ToDecimal(EditServicePrice.Text);
                if (_service.EditMedServie(_newMedservice)) 
                {
                    MessageBox.Show("Success");
                    Parent._typesService.BringToFront();
                }
                else
                    MessageBox.Show("Qandaydir xatolik ruy berdi!");
            }
            else
            {
                MessageBox.Show("Iltimos Narxni tugri tipda kiriting ");
            }
        }
        private bool IsvValidPrice(string price)
        {
            try
            {
                Convert.ToDecimal(price); return true;
            }
            catch { return false; }
        }
        private void EditServicePrice_TextChanged(object sender, EventArgs e) { }
        private void EditService_Load(object sender, EventArgs e) { }
    }
}
