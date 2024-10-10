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

namespace PresentationLayer.Forms
{
    public partial class PatientsForm : Form
    {
        private PatientService _patientService;
        public PatientsForm()
        {
            InitializeComponent();
            _patientService = new PatientService();
            LoadPatientsData();

        }
        public void LoadPatientsData()
        {
            patientsDataGridView.DataSource = _patientService.GetAllPatients();
            
        }

        private void patientAddButton_Click(object sender, EventArgs e)
        {
            var formModal = new PatientModalForm(this) 
            {
                editMode = false
            };

            if (formModal.ShowDialog(this) == DialogResult.OK)
            {
                LoadPatientsData(); 
            }

        }

        private void patientUpdateButton_Click(object sender, EventArgs e)
        {
            var formModal = new PatientModalForm(this);
            if (patientsDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debes seleccionar un paciente", "cuidado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                formModal.idPatientTextBox.Text = patientsDataGridView.CurrentRow.Cells[0].Value.ToString();
                formModal.namePatientTextBox.Text = patientsDataGridView.CurrentRow.Cells[1].Value.ToString();
                formModal.lastNamePatientTextBox.Text = patientsDataGridView.CurrentRow.Cells[2].Value.ToString();
                formModal.dateOfBirthPatientTextBox.Text = patientsDataGridView.CurrentRow.Cells[3].Value.ToString();
                formModal.genderPatientTextBox.Text = patientsDataGridView.CurrentRow.Cells[4].Value.ToString();
                formModal.editMode = true;
                if (formModal.ShowDialog(this) == DialogResult.OK)
                {
                    LoadPatientsData(); 
                }
            }
            
        }

        private void patientDeleteButton_Click(object sender, EventArgs e)
        {
            if(patientsDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debes seleccionar un paciente", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var deleteConfirm = new DialogResult();

                deleteConfirm = MessageBox.Show("Está seguro que desea eliminar el dato?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (deleteConfirm == DialogResult.Yes)
                {
                    int id = int.Parse(patientsDataGridView.CurrentRow.Cells[0].Value.ToString());
                    _patientService.DeletePatient(id);
                    LoadPatientsData();
                }
            }
        }
    }
}
