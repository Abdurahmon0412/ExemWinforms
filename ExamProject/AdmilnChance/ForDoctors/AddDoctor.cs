using Backend;
using Backend.ServiceLayer.DoctorsServiceForAdmin;
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

namespace WInforms.AdmilnChance.ForDoctors
{
    public partial class AddDoctor : UserControl
    {
        Form1 Parent;
        private readonly IDoctorServiceForAdmin _service;
        private readonly Doctor newDoctor;

        public AddDoctor(Form1 parent, IDoctorServiceForAdmin service)
        {
            InitializeComponent();
            Parent = parent;
            _service = service;
            newDoctor = new Doctor();
            
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            var result = ReadDoctor();
            if (result == null)
                MessageBox.Show("Malumotlarda hatolik bor");
            else
            {
                _service.AddDoctor(newDoctor);
                MessageBox.Show("Success");
                ClearInformation();
                Parent._checkClinikListForAdmin.BringToFront();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // addf
            var result = ReadDoctor();
            if (result == null)
                MessageBox.Show("Malumotlarda hatolik bor");
            else
            {
               _service.AddDoctor(newDoctor);
                MessageBox.Show("Success");
                ClearInformation();
                Parent._checkClinikListForAdmin.BringToFront();
            }

        }

        private Doctor? ReadDoctor()
        {
            try
            {
                var doctorName = NameTextBox.Text;
                var StartTime = Convert.ToDateTime( StartTimetext.Text); //textboxni name = starttime
                var EndTime = Convert.ToDateTime( EndTimeText.Text);
                var doctorRoom = DoctorRoom.Text;
                var doctorFloor = DoctorFloorText.Text;
                var doctorLavel = DoctorLavelText.Text;
                var doctorMedServiceId = Parent._doctorTypesforAdmin.medServiceID;

                if (doctorName is null)
                    throw new Exception();
                //var doctorStartTime = Convert.ToDateTime(StartTime);
                //var doctorEndTime = Convert.ToDateTime(EndTime);
                if (doctorRoom is null) throw new Exception();
                if (doctorFloor is null) throw new Exception();
                if (doctorLavel is null) throw new Exception();

                newDoctor.DoctorName = doctorName;
                newDoctor.StartTime = DateOnly.FromDateTime( StartTime );
                newDoctor.EndTime = DateOnly.FromDateTime( EndTime );
                newDoctor.RoomPlace = Convert.ToInt32(doctorRoom);
                newDoctor.FloorPlace = Convert.ToInt32(doctorFloor);
                newDoctor.Experience = Convert.ToInt32(doctorLavel);
                newDoctor.MedserviceId = Convert.ToInt32(doctorMedServiceId);
                newDoctor.PersonId = Parent._registrationUserControl.LastPersons.Peek();
                return newDoctor;

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private void ClearInformation()
        {
            NameTextBox.Text = null;
            StartTimetext.Text = null;
            EndTimeText.Text = null;
            DoctorRoom.Text = null;
            DoctorFloor.Text = null;
            DoctorLavel.Text = null;
        }
    }
}
