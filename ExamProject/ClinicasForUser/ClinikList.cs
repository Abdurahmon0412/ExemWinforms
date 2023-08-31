using Backend;
using Backend.ServiceLayer.ClinikManagmetService;
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
using WInforms.UserControllsFolder;

namespace WInforms.Clinicas
{
    public partial class ClinikList : UserControl
    {
        public Form1 Parent;
        public int chooseClinikId = 0;
        private ICLinikManagement _clinikManagemt;
        public ClinikList(Form1 parent, ICLinikManagement service)
        {
            Parent = parent;
            InitializeComponent();
            _clinikManagemt = service;
            ShowDatagridForClinik();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Parent._enterorLoginUserControl.BringToFront();

        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (chooseClinikId != 0)
                Parent._checkClinik.BringToFront();
            else
                MessageBox.Show("Iltimos biror clinikani tanlang ");
        }

        private void ClinikListDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ShowDatagridForClinik();
            if (e.RowIndex >= 0 && e.RowIndex < ClinikListDataGrid.Rows.Count)
            {
                DataGridViewRow row = this.ClinikListDataGrid.Rows[e.RowIndex];
                chooseClinikId = (int)row.Cells[0].Value;
                //Parent._registrationUserControl..Push(clinikId);
                MessageBox.Show("ILtimos Enter tugmasini bosing");
            }
        }

        public void ShowDatagridForClinik()
        {

            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("FullName", typeof(string));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("PhoneNumber", typeof(string));
            table.Columns.Add("Descriptions", typeof(string));
            
            if (_clinikManagemt.GetClinikas() != null)
            {
                foreach (var item in _clinikManagemt.GetClinikas())
                {
                    table.Rows.Add(item.Id, item.Fullname, item.Address, item.PhoneNumber, "");
                }
            }

            ClinikListDataGrid.DataSource = table;

        }

        
    }
}
