using System;
using System.Windows.Forms;
<<<<<<< HEAD
using BussisnesLayer.Services;
=======
using BusinessLayer.Services;
using BussisnesLayer.Services;
using CommonLayer.Entities;
>>>>>>> 0533192f96ffacaf2b496e433d87d41693b467d4

namespace PresentationLayer.Forms
{
    public partial class AppointmentsModalForm : Form
    {
<<<<<<< HEAD
        private readonly AppointmentService appointmentService;
=======
        public bool EditMode { get; set; } = false;
        private readonly AppointmentService _appointmentService;
>>>>>>> 0533192f96ffacaf2b496e433d87d41693b467d4

        public AppointmentsModalForm()
        {
            InitializeComponent();
<<<<<<< HEAD
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

        // Verificación del SelectedValue para evitar errores de conversión
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
=======
            this.StartPosition = FormStartPosition.CenterParent;
            this.Load += AppointmentsModalForm_Load;
            _appointmentService = new AppointmentService();
        }

        private void AppointmentsModalForm_Load(object sender, EventArgs e)
        {
            if (EditMode)
            {
                Text = "Editar Cita";
                int appointmentId = Convert.ToInt32(this.Tag);
                var appointmentData = _appointmentService.GetAppointmentById(appointmentId);

                if (appointmentData != null)
                {
                    FechaCitaTextBox.Text = appointmentData.AppointmentDate.ToString("yyyy-MM-dd");
                    PacienteTextBox.Text = appointmentData.PatientId.ToString();
                    DiagnosticoTextBox.Text = appointmentData.Diagnosis;
                    DoctorTextBox.Text = appointmentData.DoctorId.ToString();
                    TratamientoTextBox.Text = appointmentData.Treatment;
                }
            }
            else
            {
                Text = "Agregar Cita";
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Validaciones de campos
            if (string.IsNullOrEmpty(FechaCitaTextBox.Text) ||
                string.IsNullOrEmpty(PacienteTextBox.Text) ||
                string.IsNullOrEmpty(DiagnosticoTextBox.Text) ||
                string.IsNullOrEmpty(DoctorTextBox.Text) ||
                string.IsNullOrEmpty(TratamientoTextBox.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                DateTime appointmentDate = DateTime.Parse(FechaCitaTextBox.Text);
                int patientId = Convert.ToInt32(PacienteTextBox.Text);
                int doctorId = Convert.ToInt32(DoctorTextBox.Text);
                string diagnosis = DiagnosticoTextBox.Text;
                string treatment = TratamientoTextBox.Text;

                if (EditMode)
                {
                    int appointmentId = Convert.ToInt32(this.Tag);

                    var appointment = new Appointment
                    {
                        Id = appointmentId,
                        AppointmentDate = appointmentDate,
                        PatientId = patientId,
                        DoctorId = doctorId,
                        Diagnosis = diagnosis,
                        Treatment = treatment
                    };

                    _appointmentService.EditAppointment(appointment);
                }
                else
                {
                    var appointment = new Appointment
                    {
                        AppointmentDate = appointmentDate,
                        PatientId = patientId,
                        DoctorId = doctorId,
                        Diagnosis = diagnosis,
                        Treatment = treatment
                    };

                    _appointmentService.AddAppointment(appointment);
                }

                MessageBox.Show("La cita se guardó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("El formato de la fecha es incorrecto. Por favor, ingresa una fecha válida (YYYY-MM-DD).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar la cita: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
>>>>>>> 0533192f96ffacaf2b496e433d87d41693b467d4
        }
    }
}
