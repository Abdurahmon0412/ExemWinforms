using Backend;
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
    public partial class EditClinik : UserControl
    {
        Form1 Parent;
        private Clinika _newClinik;
        private readonly ICLinikManagement _cLinikManagement;

        public EditClinik(Form1 parent, ICLinikManagement cLinikManagement)
        {
            _newClinik = new Clinika();
            _cLinikManagement = cLinikManagement;
            Parent = parent;
            InitializeComponent();
            ShowDatagridForClinik();
        }




        private void OKButton_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.ReadOnly = true;
            ShowDatagridForClinik();

            //ChangeCallSenter.Text = string.Empty;
            //ChangeName.Text = string.Empty;
            if (IsValidClinik(_newClinik))
                if (_cLinikManagement.EditClinikas(_newClinik))
                {
                    Parent._clinikListForAdmin.ShowDatagridForClinik();
                    Parent._checkClinikListForAdmin.BringToFront();
                }
                else
                    MessageBox.Show("this is invalid");
            else
                MessageBox.Show("this is invalid");
        }

        private bool IsValidClinik(Clinika clinik)
        {
            if (string.IsNullOrEmpty(clinik.Fullname) || string.IsNullOrEmpty(clinik.PhoneNumber))
                return false;
            return true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                ChangeName.Text = row.Cells[1].Value.ToString();
                ChangeCallSenter.Text = row.Cells[3].Value.ToString();

                _newClinik.Id = (int)row.Cells[0].Value;
                _newClinik.Fullname = row.Cells[1].Value.ToString();
                _newClinik.Address = row.Cells[2].Value.ToString();
                _newClinik.PhoneNumber = row.Cells[3].Value.ToString();
            }
        }



        private void ShowDatagridForClinik()
        {

            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("FullName", typeof(string));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("PhoneNumber", typeof(string));
            table.Columns.Add("Descriptions", typeof(string));
            var a = _cLinikManagement.GetClinikas();
            if (_cLinikManagement.GetClinikas() != null)
            {
                foreach (var item in _cLinikManagement.GetClinikas())
                {
                    table.Rows.Add(item.Id, item.Fullname, item.Address, item.PhoneNumber, "");
                }
            }

            dataGridView1.DataSource = table;

        }





        private void ChangeCallSenter_TextChanged(object sender, EventArgs e)
        {
            _newClinik.PhoneNumber = ChangeCallSenter.Text;
        }
        private void ChangeName_TextChanged(object sender, EventArgs e)
        {
            _newClinik.Fullname = ChangeName.Text;
        }
        //bu yoqi kerak emas
        private void EditPhoneNumberLabel_Click(object sender, EventArgs e)
        {

        }



        private void EditNameLabel_Click(object sender, EventArgs e)
        {

        }

    }
}
