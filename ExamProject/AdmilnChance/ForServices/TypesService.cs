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
    public partial class TypesService : UserControl
    {
        Form1 Parent;
        public IMedService _medService;
        public int medServiceId = 0;
        public TypesService(Form1 parent, IMedService service)
        {
            Parent = parent;
            InitializeComponent();
            _medService = service;
            ShowDatagridMedService();
        }



        private void AddButton_Click(object sender, EventArgs e)
        {
            Parent._addService.BringToFront();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if(medServiceId == 0)
            {
                MessageBox.Show("Biror Serviceni tanlang!");
                return;
            }
            else
            Parent._editService.BringToFront();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (medServiceId == 0)
            {
                MessageBox.Show("Iltimos biror Serviceni tanlang!");
                return;
            }
            if (MessageBox.Show("Do you want delete thsi clinik?", "Delete clinik",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (_medService.DeleteMedservice(Parent._registrationUserControl.LastPersons.Peek(), medServiceId))
                {
                    MessageBox.Show("Success");
                    ShowDatagridMedService();
                    return;
                }
                MessageBox.Show("Faild");
                ShowDatagridMedService();
                // Clinika uchiriladi va 
                //Parent._checkClinikListForAdmin.BringToFront();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            medServiceId = 0;
            Parent._checkClinikListForAdmin.BringToFront();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            ShowDatagridMedService();
        }

        public void ShowDatagridMedService()
        {

            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("ServiceName", typeof(string));
            table.Columns.Add("Price", typeof(decimal));


            if (_medService.GetMedservices() != null)
            {
                foreach (var item in _medService.GetMedservices())
                {
                    table.Rows.Add(item.Id, item.MedserviceName, item.ServicePrice);
                }
            }

            dataGridView1.DataSource = table;

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.ShowDatagridMedService();
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                medServiceId = (int)row.Cells[0].Value;
            }
            MessageBox.Show("OK Endi biror xizmat turini tanlang!");
        }
    }
}
