using System;
using System.Windows.Forms;
using BusinessLayer.Services;
using BussisnesLayer.Services;
using CommonLayer.Entities;

namespace PresentationLayer.Forms
{
    public partial class AppointmentsModalForm : Form
    {
        public bool EditMode { get; set; } = false;
        private readonly AppointmentService _appointmentService;

        public AppointmentsModalForm()
        {
            InitializeComponent();
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
        }
    }
}
