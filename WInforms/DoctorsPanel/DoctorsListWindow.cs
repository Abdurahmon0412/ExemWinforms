using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WInforms.DoctorsPanel
{
    public partial class DoctorsListWindow : UserControl
    {
        public Form1 Parent;
        public DoctorsListWindow(Form1 parent)
        {
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


            table.Rows.Add(1, "Ganisher","uchuvchi");
            table.Rows.Add(2, "qodir");
            table.Rows.Add(3, "omil");


            //List<Doctor> doctors;
            List<string> list = new List<string> { "skdal", "dslkjadl", "ddsaakl"};
            var i = 4;
            foreach(var s in list)
            {
                table.Rows.Add(i,s);
                i++;
            }
            //foreach (DataRow row in table.Rows)
            //{
            //databasadagi doktorlar soniga qarab uqiydi
            //}

            dataGridView1.DataSource = table;
        }

    }
}
