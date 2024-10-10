using BussisnesLayer.Services;
using CommonLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{

    public partial class DoctorModalForm : Form
    {
        public bool editMode = false;
        private DoctorService _doctorService;
        public Doctor Doctor { get; set; }

        public Doctor DoctorData { get; set; }
        public DoctorModalForm(DoctorsForm doctorsForm)
        {
            InitializeComponent();
            DoctorData = new Doctor();
            Doctor = new Doctor();
            this.StartPosition = FormStartPosition.CenterParent;
            this.Load += DoctorModalForm_Load;
            _doctorService = new DoctorService();
        }
        private void DoctorModalForm_Load(object? sender, EventArgs e)
        {
            if (editMode)
            {
                textDoctor.Text = "Editar Doctor";
            }
            else
            {
                textDoctor.Text = "Agregar Doctor";
            }
        }

        private void doctorSaveButton_Click(object sender, EventArgs e)
        {

            if (editMode)
            {
                int id = Convert.ToInt32(idDoctorTextBox.Text);
                string firstName = nameDoctorTextBox.Text;
                string specialty = specialtyDoctorTextBox.Text;

                Doctor doctor = new Doctor()
                {
                    Id = id,
                    FirstName = firstName,
                    Specialty = specialty
                };

                _doctorService.EditDoctor(doctor);
                editMode = false;
            }
            else
            {
                Doctor doctor = new Doctor()
                {
                    FirstName = nameDoctorTextBox.Text,
                    Specialty = specialtyDoctorTextBox.Text
                };

                _doctorService.AddDoctor(doctor);

            }
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}