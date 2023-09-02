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

namespace WInforms.Coasts
{
    public partial class PricesUserControl : UserControl
    {
        public Form1 Parent ;
        private IMedService _service;
        public PricesUserControl(Form1 parent, IMedService service)
        {
            Parent = parent;
            _service = service;
            InitializeComponent();
            ShowDatagridMedService();

        }


        private void BackButton_Click(object sender, EventArgs e)
        {
            Parent._checkClinik.BringToFront();
        }



        private void MedServiceDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowDatagridMedService();
        }

        public void ShowDatagridMedService()
        {

            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("ServiceName", typeof(string));
            table.Columns.Add("Price", typeof(decimal));


            if (_service.GetMedservices() != null)
            {
                foreach (var item in _service.GetMedservices())
                {
                    table.Rows.Add(item.Id, item.MedserviceName, item.ServicePrice);
                }
            }

            MedServiceDataGrid.DataSource = table;

        }

    }
}
