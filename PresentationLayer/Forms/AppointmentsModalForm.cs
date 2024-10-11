using System;
using System.Windows.Forms;
using BussisnesLayer.Services;
using CommonLayer.Entities;

namespace PresentationLayer.Forms
{
    public partial class AppointmentsModalForm : Form
    {
        public bool EditMode { get; set; } = false;
        private readonly AppointmentService appointmentService;

        public AppointmentsModalForm()
        {
            InitializeComponent();
            appointmentService = new AppointmentService();
            LoadPatients();
            LoadDoctors();

            // Enlazar los eventos a los botones
            AppointmentSaveButton.Click += AppointmentSaveButton_Click;
            AppointmentCancelButton.Click += AppointmentCancelButton_Click;
        }

        // Propiedades públicas para acceder a los valores seleccionados
        public DateTime AppointmentDate => AppointmentDateTimePicker.Value;
        public string Diagnosis => DiagnosticAppointmentTextBox.Text;
        public string Treatment => TratamientAppointmentTextBox.Text;
        public int PatientId => PatientComboBox.SelectedValue != null ? (int)PatientComboBox.SelectedValue : -1;
        public int DoctorId => DoctorComboBox.SelectedValue != null ? (int)DoctorComboBox.SelectedValue : -1;

        private void LoadPatients()
        {
            try
            {
                var patients = appointmentService.GetPatients();
                PatientComboBox.DataSource = patients;
                PatientComboBox.DisplayMember = "Patients";
                PatientComboBox.ValueMember = "Id";
                PatientComboBox.SelectedIndex = -1; // Selección vacía inicial para evitar selecciones por defecto.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los pacientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDoctors()
        {
            try
            {
                var doctors = appointmentService.GetDoctors();
                DoctorComboBox.DataSource = doctors;
                DoctorComboBox.DisplayMember = "Doctors";
                DoctorComboBox.ValueMember = "Id";
                DoctorComboBox.SelectedIndex = -1; // Selección vacía inicial para evitar selecciones por defecto.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los doctores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AppointmentSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
                {
                    // Verificar si los IDs seleccionados son válidos
                    if (PatientId == -1 || DoctorId == -1)
                    {
                        MessageBox.Show("Seleccione un paciente y un doctor válidos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Si todo es válido, cerrar el modal con un resultado de OK.
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, complete todos los campos correctamente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la cita: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AppointmentCancelButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar salir: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateForm()
        {
            return PatientComboBox.SelectedIndex != -1 &&
                   DoctorComboBox.SelectedIndex != -1 &&
                   !string.IsNullOrWhiteSpace(DiagnosticAppointmentTextBox.Text) &&
                   !string.IsNullOrWhiteSpace(TratamientAppointmentTextBox.Text);
        }
    }
}
