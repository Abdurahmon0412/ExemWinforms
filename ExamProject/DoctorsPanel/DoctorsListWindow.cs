using Backend;
using Backend.DataLayer;
using Backend.ServiceLayer.MedServiceServices;
using Backend.ServiceLayer.SeeDoctors;
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
//using Backend.Model;
namespace WInforms.DoctorsPanel
{
    public partial class DoctorsListWindow : UserControl
    {
        public Form1 Parent;
        private IMedService _doctorService;
        public DoctorsListWindow(Form1 parent, IMedService doctorservice)
        {
            _doctorService = doctorservice;
            InitializeComponent();
            Parent = parent;
        }


        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ShowDatagridForDoctors();
        }


        private void BackButton_Click(object sender, EventArgs e)
        {
            Parent._checkClinik.BringToFront();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            ShowDatagridForDoctors();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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

            var medservices = _doctorService.GetMedservices(Parent._clinikList.chooseClinikId);

            foreach (var item in medservices)
            {
                foreach (var item2 in item.Doctors)
                {
                    table.Rows.Add(item2.Id, item2.DoctorName, item.MedserviceName,
                    Convert.ToString((item2.StartTime, item2.EndTime)), "Du .. Ju", item2.FloorPlace,
                    item2.RoomPlace, item2.Experience);
                }
            }
            dataGridView1.DataSource = table;
        }
    }
}
