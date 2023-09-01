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

namespace WInforms.AdmilnChance.ForDoctors
{
    public partial class DoctorTypesforAdmin : UserControl
    {
        Form1 Parent;
        private IMedService _cervice;
        public int medServiceID = 0;
        public DoctorTypesforAdmin(Form1 parent, IMedService service)
        {
            InitializeComponent();
            Parent = parent;
            _cervice = service;
            ShowDatagridMedService();
        }

        private void DoctorTypeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (medServiceID == 0)
                MessageBox.Show("Iltimos biror Xizmat turini tanlang!");
            else
            {
                Parent._doctorListForAdmin.ShowDatagridForDoctors();
                Parent._doctorListForAdmin.BringToFront();
            }

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            medServiceID = 0;
            Parent._checkClinikListForAdmin.BringToFront();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            this.ShowDatagridMedService();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ShowDatagridMedService();
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                medServiceID = (int)row.Cells[0].Value;
            }
            MessageBox.Show("Endi enter tugmmasini bosing");
        }

        public void ShowDatagridMedService()
        {

            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("ServiceName", typeof(string));
            table.Columns.Add("Price", typeof(decimal));


            if (_cervice.GetMedservices() != null)
            {
                foreach (var item in _cervice.GetMedservices())
                {
                    table.Rows.Add(item.Id, item.MedserviceName, item.ServicePrice);
                }
            }

            dataGridView1.DataSource = table;

        }

        private void DearchBox_TextChanged(object sender, EventArgs e)
        {
            ShowDatagridMedService();
        }
        private void DoctorTypesforAdmin_Load(object sender, EventArgs e)
        {

        }

    }
}
