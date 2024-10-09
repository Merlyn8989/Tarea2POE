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

namespace PresentationLayer.Forms
{
    public partial class PatientsForm : Form
    {
        private PatientService _patientService;
        public PatientsForm()
        {
            InitializeComponent();
            _patientService = new PatientService();
            LoadDoctorsData();
            
        }
        private void LoadDoctorsData()
        {
            patientsDataGridView.DataSource = _patientService.GetAllPatients();
        }

        private void patientAddButton_Click(object sender, EventArgs e)
        {
            var formModal = new PatientModalForm();

            formModal.editMode = false;

            formModal.ShowDialog(this);

        }

        private void patientUpdateButton_Click(object sender, EventArgs e)
        {
            var formModal = new PatientModalForm();

            formModal.editMode = true;

            formModal.ShowDialog(this);
        }
    }
}
