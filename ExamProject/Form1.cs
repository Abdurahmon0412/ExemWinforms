using Backend.DataLayer;
using Backend.ServiceLayer.AccountService;
using Backend.ServiceLayer.ClinikManagmetService;
using Backend.ServiceLayer.SeeDoctors;
using WInforms.AdmilnChance;
using WInforms.AdmilnChance.ForClinika;
using WInforms.AdmilnChance.ForDoctors;
using WInforms.AdmilnChance.ForServices;
using WInforms.Clinicas;
using WInforms.Coasts;
using WInforms.DoctorsPanel;
using WInforms.UserControllsFolder;

namespace ExamProject
{
    public partial class Form1 : Form
    {
        static EfCoreContext _context = new EfCoreContext();

        IAccountService _accountService = new AccountService(_context);
        ICLinikManagement _clinikManagement = new ClinikManagement(_context);
        IDoctorService _doctorservice = new DoctorService(_context);

        public ClinikList _clinikList;
        public EnterORLoginUserControl _enterorLoginUserControl;
        public RegistrationUserControl _registrationUserControl;
        public SignInButton _signInButton;
        public CheckClinik _checkClinik;
        public DoctorsListWindow _doctorsListWindow;
        public PricesUserControl _priceUserControl;
        public ClinikListForAdmin _clinikListForAdmin;
        public CheckClinikListForAdmin _checkClinikListForAdmin;
        public EditClinik _editClinik;
        public AddClinika _addClinik;
        public DoctorTypesforAdmin _doctorTypesforAdmin;
        public DoctorListForAdmin _doctorListForAdmin;
        public EditDoctor _editDoctor;
        public AddDoctor _addDoctor;
        public TypesService _typesService;
        public AddService _addService;
        public EditService _editService;
        public Form1()
        {
            _clinikList = new ClinikList(this);
            _enterorLoginUserControl = new EnterORLoginUserControl(this);
            _registrationUserControl = new RegistrationUserControl(this, _accountService);
            _signInButton = new SignInButton(this, _accountService);
            _checkClinik = new CheckClinik(this);
            _doctorsListWindow = new DoctorsListWindow(this, _doctorservice);
            _priceUserControl = new PricesUserControl(this);
            _clinikListForAdmin = new ClinikListForAdmin(this, _clinikManagement);
            _checkClinikListForAdmin = new CheckClinikListForAdmin(this);
            _editClinik = new EditClinik(this, _clinikManagement);
            _addClinik = new AddClinika(this, _clinikManagement);
            _doctorTypesforAdmin = new DoctorTypesforAdmin(this);
            _doctorListForAdmin = new DoctorListForAdmin(this);
            _editDoctor = new EditDoctor(this);
            _addDoctor = new AddDoctor(this);
            _typesService = new TypesService(this);
            _addService = new AddService(this);
            _editService = new EditService(this);


            Controls.Add(_doctorTypesforAdmin);
            Controls.Add(_clinikList);
            Controls.Add(_enterorLoginUserControl);
            Controls.Add(_registrationUserControl);
            Controls.Add(_signInButton);
            Controls.Add(_checkClinik);
            Controls.Add(_doctorsListWindow);
            Controls.Add(_priceUserControl);
            Controls.Add(_clinikListForAdmin);
            Controls.Add(_checkClinikListForAdmin);
            Controls.Add(_editClinik);
            Controls.Add(_addClinik);
            Controls.Add(_doctorListForAdmin);
            Controls.Add(_editDoctor);
            Controls.Add(_addDoctor);
            Controls.Add(_typesService);
            Controls.Add(_addService);
            Controls.Add(_editService);
            InitializeComponent();
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            _enterorLoginUserControl.BringToFront();
        }
    }
}