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
using WInforms.Coasts;
using WInforms.DoctorsPanel;
using WInforms.UserControllsFolder;

namespace WInforms
{
    public partial class Form1 : Form
    {
        public ClinikList _clinikList;
        public EnterORLoginUserControl _enterorLoginUserControl;
        public RegistrationUserControl _registrationUserControl;
        public SignInButton _signInButton;
        public CheckClinik _checkClinik;
        public DoctorsListWindow _doctorsListWindow;
        public PricesUserControl _priceUserControl;
        public Form1()
        {

            _clinikList = new ClinikList(this);
            _enterorLoginUserControl = new EnterORLoginUserControl(this);
            _registrationUserControl = new RegistrationUserControl(this);
            _signInButton = new SignInButton(this);
            _checkClinik = new CheckClinik(this);
            _doctorsListWindow = new DoctorsListWindow(this);
            _priceUserControl = new PricesUserControl(this);

            Controls.Add(_clinikList);
            Controls.Add(_enterorLoginUserControl);
            Controls.Add(_registrationUserControl);
            Controls.Add(_signInButton);
            Controls.Add(_checkClinik);
            Controls.Add(_doctorsListWindow);
            Controls.Add(_priceUserControl);
            InitializeComponent();
        }


        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            _enterorLoginUserControl.BringToFront();
        }
    }
}
