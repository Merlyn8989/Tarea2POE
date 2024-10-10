using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussisnesLayer.Services;
using CommonLayer.Entities;
using DataAccessLayer.Repositories;

namespace PresentationLayer.Forms
{
    public partial class PatientModalForm : Form
    {
        public bool editMode = false;
        private PatientService _patientService;
        public PatientModalForm(PatientsForm patientsForm)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.Load += PatientModalForm_Load;
            _patientService = new PatientService();
  
        }

        private void PatientModalForm_Load(object sender, EventArgs e)
        {
            if (editMode)
            {
                titleLabel.Text = "Editar Paciente";
            }
            else
            {
                titleLabel.Text = "Agregar Paciente";
            }
        }

        private void patientSaveButton_Click(object sender, EventArgs e)
        {

            if (editMode)
            {
                int id = Convert.ToInt32(idPatientTextBox.Text);
                string firstName = namePatientTextBox.Text;
                string lastName = lastNamePatientTextBox.Text;
                string gender = genderPatientTextBox.Text;
                DateTime dateTime = DateTime.Parse(dateOfBirthPatientTextBox.Text);
                DateOnly dateOfBirth = DateOnly.FromDateTime(dateTime);

                Patient patient = new Patient()
                {
                    Id = id,
                    FirstName = firstName,
                    LastName = lastName,
                    DateOfBirth = dateOfBirth,
                    Gender = gender
                };

                _patientService.EditPatient(patient);
                editMode = false;
            }
            else
            {
                DateTime dateTime = DateTime.Parse(dateOfBirthPatientTextBox.Text);
                DateOnly dateOfBirth = DateOnly.FromDateTime(dateTime);

                Patient patient = new Patient()
                {
                    FirstName = namePatientTextBox.Text,
                    LastName = lastNamePatientTextBox.Text,
                    DateOfBirth = dateOfBirth,  
                    Gender = genderPatientTextBox.Text
                };

                _patientService.AddPatient(patient);

            }
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
