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

namespace WInforms.AdmilnChance.ForDoctors
{
    public partial class DoctorListForAdmin : UserControl
    {
        Form1 Parent;
        private IMedService _service;
        private int _doctorId = 0;
        public DoctorListForAdmin(Form1 parent, IMedService service)
        {
            InitializeComponent();
            Parent = parent;
            _service = service;
            ShowDatagridForDoctors();

        }

        private void DeleteCLinikButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want delete thsi clinik?", "Delete clinik",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (_doctorId == 0)
                        throw new Exception("Iltimos biror doctorni tanlang!");
                    // doctor uchiriladi va 
                    if (_service.DeleteDoctor(_doctorId))
                        MessageBox.Show("Success!");
                    else
                        throw new Exception("Malumot uchirishda hatolik ruy berdi!");
                    ShowDatagridForDoctors();
                }
                throw new Exception("Malumot uchirilmadi!");
                               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditClinikButton_Click(object sender, EventArgs e)
        {
            Parent._editDoctor.ShowDatagridForDoctors() ;
            Parent._editDoctor.BringToFront();
        }

        private void AddClinikButton_Click(object sender, EventArgs e)
        {
            Parent._addDoctor.BringToFront();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Parent._doctorTypesforAdmin.BringToFront();
        }

        private void ClinikListDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < ClinikListDataGrid.Rows.Count)
            {
                DataGridViewRow row = this.ClinikListDataGrid.Rows[e.RowIndex];
                _doctorId = (int)row.Cells[0].Value;
            }
            ShowDatagridForDoctors();
        }

        public void ShowDatagridForDoctors()
        {


            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Spetificik", typeof(string));
            table.Columns.Add("Start/End time", typeof(string));
            table.Columns.Add("WorkDays", typeof(string));
            table.Columns.Add("Floor", typeof(int));
            table.Columns.Add("Room", typeof(int));
            table.Columns.Add("Graduate", typeof(int));

            var medservices = _service.GetDoctors(Parent._doctorTypesforAdmin.medServiceID);

            foreach (var item2 in medservices)
                {
                    table.Rows.Add(item2.Id, item2.DoctorName, _service
                        .GetMedserviceName(Parent._doctorTypesforAdmin.medServiceID),
                    Convert.ToString((item2.StartTime, item2.EndTime)), "Du .. Ju",
                    item2.FloorPlace,
                    item2.RoomPlace, item2.Experience);
                }
            
            ClinikListDataGrid.DataSource = table;

        }
    }
}
