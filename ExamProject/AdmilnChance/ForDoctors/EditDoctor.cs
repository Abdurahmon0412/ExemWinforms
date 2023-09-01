using Backend;
using Backend.ServiceLayer.DoctorsServiceForAdmin;
using Backend.ServiceLayer.MedServiceServices;
using ExamProject;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class EditDoctor : UserControl
    {
        Form1 Parent;
        private IDoctorServiceForAdmin _service;
        private IMedService _medService;
        private Doctor newDoctor;
        private int _newDoctorId;
        public EditDoctor(Form1 parent, IDoctorServiceForAdmin service, IMedService medService)
        {
            InitializeComponent();
            Parent = parent;
            _service = service;
            newDoctor = new Doctor();
            _medService = medService;
            //ShowDatagridForDoctors();
        }




        private void OKButton_Click(object sender, EventArgs e)
        {
            newDoctor.Id = _newDoctorId;
            newDoctor.StartTime = ToDateOnly(EditStartTimetext.Text);  // change name dib yozilib qolgan name ni uzgartirsam xato berdi winformda;
            newDoctor.EndTime = ToDateOnly(EditEndTimeText.Text);
            newDoctor.FloorPlace = int.Parse(EditFloortext.Text);
            newDoctor.RoomPlace = int.Parse(EditRoomText.Text);
            newDoctor.Experience = int.Parse(EditLavelText.Text);

            if(_service.EditDoctor(newDoctor))
            {
                MessageBox.Show("Success");
                Parent._checkClinikListForAdmin.BringToFront();
            }
            else
            {
                MessageBox.Show("UZur nimadir hatolik ruy berdi!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowDatagridForDoctors();
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                _newDoctorId = (int)row.Cells[0].Value;
                EditStartTimetext.Text = row.Cells[3].Value.ToString();
                EditEndTimeText.Text = row.Cells[4].Value.ToString();
                EditFloortext.Text = row.Cells[6].Value.ToString();
                EditRoomText.Text = row.Cells[7].Value.ToString();
                EditLavelText.Text = row.Cells[8].Value.ToString();
            }
        }

        public void ShowDatagridForDoctors()
        {


            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Spetificik", typeof(string));
            table.Columns.Add("Start time", typeof(DateOnly));
            table.Columns.Add("End time", typeof(DateOnly));
            table.Columns.Add("WorkDays", typeof(string));
            table.Columns.Add("Floor", typeof(int));
            table.Columns.Add("Room", typeof(int));
            table.Columns.Add("Graduate", typeof(int));

            var medservices = _medService.GetDoctors(Parent._doctorTypesforAdmin.medServiceID);

            foreach (var item2 in medservices)
            {
                table.Rows.Add(item2.Id, item2.DoctorName, _medService
                    .GetMedserviceName(Parent._doctorTypesforAdmin.medServiceID),
                item2.StartTime, item2.EndTime, "Du .. Ju",
                item2.FloorPlace,
                item2.RoomPlace, item2.Experience);
            }

            dataGridView1.DataSource = table;

        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Parent._doctorListForAdmin.ShowDatagridForDoctors();
            Parent._doctorListForAdmin.BringToFront();
        }


        private DateOnly ToDateOnly(string text)
        {
            var times = text.Split('/');
            var dateOnly = new DateOnly(int.Parse(times[2]), int.Parse(times[1]), int.Parse(times[0]));
            return dateOnly;
        }

        private void Editroom_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
    }
}
