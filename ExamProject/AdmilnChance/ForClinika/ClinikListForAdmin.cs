using Backend;
using Backend.DataLayer;
using Backend.ServiceLayer.AccountService;
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

namespace WInforms.AdmilnChance
{
    public partial class ClinikListForAdmin : UserControl
    {
        public Form1 Parent;
        private readonly ICLinikManagement _cLinikManagement;
        private readonly Clinika _checkClinik;
        private int _newClinikId = 0;
        public ClinikListForAdmin(Form1 parent, ICLinikManagement cervice)
        {
            _checkClinik = new Clinika();
            InitializeComponent();
            Parent = parent;
            _cLinikManagement = cervice;
            ShowDatagridForClinik();
        }


        private void DeleteCLinikButton_Click(object sender, EventArgs e)
        {
            if (_newClinikId == 0)
            {
                MessageBox.Show("Biror Clinikani tanlang");
            }
            else if (MessageBox.Show("Do you want delete thsi clinik?", "Delete clinik",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Clinika uchiriladi va 
                if (_cLinikManagement.DeleteClinikas(_newClinikId))
                {
                    GetCliniks();
                    Parent._clinikListForAdmin.ShowDatagridForClinik();
                    MessageBox.Show("Success");
                    Parent._checkClinikListForAdmin.BringToFront();
                }
                else
                    MessageBox.Show("This event invalid");
            }
        }

        private void EditClinikButton_Click(object sender, EventArgs e)
        {
            ClinikListDataGrid.AutoGenerateColumns = true;
            ClinikListDataGrid.ReadOnly = true;
            Parent._editClinik.BringToFront();
            ShowDatagridForClinik();
        }

        private void AddClinikButton_Click(object sender, EventArgs e)
        {
            Parent._addClinik.BringToFront();

        }

        private void Back_Click(object sender, EventArgs e)
        {
            ShowDatagridForClinik();
            Parent._checkClinikListForAdmin.BringToFront();

        }

        private void ClinikListDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < ClinikListDataGrid.Rows.Count)
            {
                DataGridViewRow row = this.ClinikListDataGrid.Rows[e.RowIndex];
                _newClinikId = (int)row.Cells[0].Value;
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
           // var a = GetCliniks();
            if (GetCliniks() != null)
            {
                foreach (var item in GetCliniks())
                {
                    table.Rows.Add(item.Id, item.Fullname, item.Address, item.PhoneNumber, "");
                }
            }

            ClinikListDataGrid.DataSource = table;

        }

        private List<Clinika> GetCliniks()
        {
            return _cLinikManagement.GetClinikas();
        }
    }
}
