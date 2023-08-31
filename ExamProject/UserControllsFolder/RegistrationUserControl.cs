using Backend;
using Backend.ServiceLayer.AccountService;
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
using WInforms.Clinicas;

namespace WInforms.UserControllsFolder
{
    public partial class RegistrationUserControl : UserControl
    {
        Form1 Parent;
        private readonly IAccountService _accountService;
        public int _clinikId;
        public Stack<int> LastPersons;


        public RegistrationUserControl(Form1 parent, IAccountService accountService)
        {
            _accountService = accountService;
            Parent = parent;
            InitializeComponent();
            LastPersons = new Stack<int>();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegistrationUserControl_Load(object sender, EventArgs e)
        {
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Parent._enterorLoginUserControl.BringToFront();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            var login = LoginTextbox.Text;
            var password = PasswordTextbox.Text;
            var firstname = Firstnametextbox.Text;
            var lastname = Lastnametextbox.Text;
            var roleId = 1;
            var clinik_id = _clinikId;
            var med_Id = 1;

            if (!IsValidString(login))
                MessageBox.Show("this is invalid1");
            else if (!IsValidString(password))
                MessageBox.Show("this is invalid2");
            else if (!IsValidString(firstname))
                MessageBox.Show("this is invalid3");
            else if (!IsValidString(lastname))
                MessageBox.Show("this is invalid4");
            else if (_clinikId == 0)
                MessageBox.Show("this is invalid5");
            else
            {
                var person = new Person
                {
                    Login = login,
                    Password = password,
                    Firstname = firstname,
                    Lastname = lastname,
                    RoleId = roleId,
                    ClinikaId = clinik_id,
                    MedserviceId = med_Id,
                };
                _accountService.AddPerson(person);
                LastPersons.Push(_accountService.GetPersonId(login, password));
                
                LoginTextbox.Clear();
                PasswordTextbox.Clear();
                Firstnametextbox.Clear();
                Lastnametextbox.Clear();
                Parent._checkClinik.BringToFront();
            }
        }



        private void ClinikCombobox_MouseClick(object sender, MouseEventArgs e)
        {
            ClinikCombobox.Items.Clear();
            var allCliniks = _accountService.GetAllCliniks(ClinikCombobox.Text);
            foreach (var item in allCliniks)
                ClinikCombobox.Items.Add(item.Fullname);
        }

        private void ClinikCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var combotext = ClinikCombobox.Text;
            _clinikId = _accountService.GetClinikId(combotext);

        }

        private bool IsValidString(string str)
        {
            if (string.IsNullOrWhiteSpace(str) || string.IsNullOrEmpty(str))
                return false;
            return true;
        }
    }
}