using Backend;
using Backend.ServiceLayer.AccountService;
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
    public partial class AddService : UserControl
    {
        Form1 Parent;
        private IMedService _service;
        private IAccountService _accountService;
        private readonly Medservice _newMedservice;
        private int _clinikId;
        public AddService(Form1 parent, IMedService service, IAccountService accountService)
        {
            InitializeComponent();
            Parent = parent;
            _service = service;
            _accountService = accountService;
            _newMedservice = new Medservice();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Parent._typesService.medServiceId = 0;
            Parent._typesService.BringToFront();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (_clinikId == 0)
            {
                MessageBox.Show("Clinikani tanlang!");
                return;
            }
            var result = ReadMedService();
            if (result != null)
            {
                if (_service.AddMedservice(result))
                {
                    MessageBox.Show("Success");
                    Parent._typesService.BringToFront();
                }
                else
                    MessageBox.Show("Qandaydir xatolik ruy berdi");



            }
            else
                MessageBox.Show("Malumotlar notug'ri kiritildi");
        }

        private Medservice? ReadMedService()
        {
            try
            {
                _newMedservice.MedserviceName = AddServiceName.Text;
                _newMedservice.ServicePrice = Convert.ToDecimal(PriceTextBox.Text);
                _newMedservice.ClinikaId = _clinikId;
                return _newMedservice;
            }
            catch
            {
                return null;
            }
        }

        private void ChooseClinikCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var combotext = ChooseClinikCombo.Text;
            _clinikId = _accountService.GetClinikId(combotext);
        }

        private void ChooseClinikCombo_MouseDown(object sender, MouseEventArgs e)
        {
            ChooseClinikCombo.Items.Clear();
            var allCliniks = _accountService.GetAllCliniks(ChooseClinikCombo.Text);
            foreach (var item in allCliniks)
                ChooseClinikCombo.Items.Add(item.Fullname);
        }
    }
}
