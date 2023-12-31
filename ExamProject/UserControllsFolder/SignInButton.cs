﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend;
using Backend.DataLayer;
using Backend.ServiceLayer;
using Backend.ServiceLayer.AccountService;
using ExamProject;

namespace WInforms.UserControllsFolder
{
    public partial class SignInButton : UserControl
    {
        public Form1 Parent;
        private readonly IAccountService _accountService;
        public SignInButton(Form1 parent, IAccountService accountService)
        {
            _accountService = accountService;
            Parent = parent;
            InitializeComponent();

        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            var findperson = _accountService.SignIn(textBox1.Text, textBox2.Text);
            if (findperson != null && findperson.RoleId == 1)
            {
                TextBoxChanged();
                Parent._registrationUserControl.LastPersons.Push(findperson.Id);
                Parent._checkClinikListForAdmin.BringToFront();
            }
            else if (findperson != null && findperson.RoleId == 2)
            {
                TextBoxChanged();
                Parent._clinikList.BringToFront();
                Parent._registrationUserControl.LastPersons.Push(findperson.Id);
            }
            else
            {
                TextBoxChanged();
                Parent._registrationUserControl.BringToFront();
            }
        }

        private void TextBoxChanged()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Parent._checkClinikListForAdmin.BringToFront();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
