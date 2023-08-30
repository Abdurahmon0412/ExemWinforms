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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WInforms.AdmilnChance.ForClinika
{
    public partial class AddClinika : UserControl
    {
        Form1 Parent;
        private readonly ICLinikManagement _cLinikManagement;
        private Clinika newClinik;
        public AddClinika(Form1 parent, ICLinikManagement service)
        {
            _cLinikManagement = service;
            InitializeComponent();
            Parent = parent;
            newClinik = new Clinika();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //
            newClinik.Fullname = NameTextBox.Text;
            newClinik.Address = AddressTextBoxs.Text;
            newClinik.PhoneNumber = PhonenumberText.Text;
            if(IsValidClinik(newClinik))
            {
                if (_cLinikManagement.AddClinikas(newClinik))
                {
                    MessageBox.Show("Success");
                    Parent._clinikListForAdmin.BringToFront();
                    Parent._clinikListForAdmin.ShowDatagridForClinik();
                }
                else
                {
                    MessageBox.Show("Uzur Malumot qushilmadi Yana urinib kuring");
                    Parent._clinikListForAdmin.BringToFront();
                }
            }
            else
            {
                MessageBox.Show("Error! Error! Error!\n \t Value is invalid");
            }
        }

        private void OKButton_Click(object sender, EventArgs e) // OK buttoni Extga uzgartirdim
        {
            Parent._checkClinikListForAdmin.BringToFront();
        }

        private bool IsValidClinik(Clinika clinik)
        {
            if (string.IsNullOrEmpty(clinik.Fullname)
                || string.IsNullOrEmpty(clinik.Address)
                || !Regex.IsMatch(clinik.PhoneNumber, @"^\+998\d{9}$"))
                return false;
            return true;
        }
    }
}
