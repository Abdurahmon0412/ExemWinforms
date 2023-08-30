using Backend;
using Backend.DataLayer;
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
        private IDoctorService _doctorService;
        public DoctorsListWindow(Form1 parent, IDoctorService doctorservice)
        {
            _doctorService = doctorservice;
            InitializeComponent();
            Parent = parent;
        }


        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void BackButton_Click(object sender, EventArgs e)
        {
            Parent._checkClinik.BringToFront();
        }

        private void Confirm_Click(object sender, EventArgs e)
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


            table.Rows.Add(1, "Ganisher", "uchuvchi");
            table.Rows.Add(2, "qodir");
            table.Rows.Add(3, "omil");


            List<Doctor> doctors;
            List<string> list = new List<string> { "skdal", "dslkjadl", "ddsaakl" };
            var i = 4;
            foreach (var s in list)
            {
                table.Rows.Add(i, s);
                i++;
            }
            //foreach (DataRow row in table.Rows)
            //{
            //databasadagi doktorlar soniga qarab uqiydi
            //}

            dataGridView1.DataSource = table;
        }

        public void ShowDatagridForDoctors()
        {


            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Spetificik", typeof(Medservice));
            table.Columns.Add("Start/End time", typeof(string));
            table.Columns.Add("WorkDays", typeof(string));
            table.Columns.Add("Floor", typeof(int));
            table.Columns.Add("Room", typeof(int));
            table.Columns.Add("Graduate", typeof(int));

            var docotrs = _doctorService.GetAllDoctors(Parent._registrationUserControl.LastPersons.Peek());

            foreach(var item in  docotrs)
            {
                table.Rows.Add(item.Id, item.DoctorName, _doctorService.GetMedservices(item.Id),
                    Convert.ToString((item.StartTime, item.EndTime)), "Du .. Ju", item.FloorPlace, item.RoomPlace, item.Experience);
            }
            //var a = GetCliniks();
            //if (GetCliniks() != null)
            //{
            //    foreach (var item in GetCliniks())
            //    {
            //        table.Rows.Add(item.Id, item.Fullname, item.Address, item.PhoneNumber, "");
            //    }
            //}

            dataGridView1.DataSource = table;

        }

    }
}
