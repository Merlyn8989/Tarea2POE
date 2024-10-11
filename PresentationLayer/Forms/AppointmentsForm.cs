using System;
using System.Data;
using System.Windows.Forms;
using BussisnesLayer.Services;
using CommonLayer.Entities;

namespace PresentationLayer.Forms
{
    public partial class AppointmentsForm : Form
    {
        private readonly AppointmentService appointmentService;

        public AppointmentsForm()
        {
            InitializeComponent();
            appointmentService = new AppointmentService();
            LoadAppointments();

            // Enlazar eventos de los botones a sus respectivos métodos
            AddAppointmentsbutton.Click += AddAppointmentsbutton_Click;
            UbdateAppointmentsButton.Click += UpdateAppointmentsButton_Click;
            DeleteAppointmentsButton.Click += DeleteAppointmentsButton_Click;
        }

        private void LoadAppointments()
        {
            try
            {
                var appointmentsTable = appointmentService.GetAllAppointments();
                AppointmentsDataGridView.DataSource = appointmentsTable;
                // Ocultar columnas innecesarias en el DataGridView.
                AppointmentsDataGridView.Columns["patientId"].Visible = false;
                AppointmentsDataGridView.Columns["doctorId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las citas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddAppointmentsbutton_Click(object sender, EventArgs e)
        {
            using (var modalForm = new AppointmentsModalForm())
            {
                modalForm.Text = "Nueva Cita";

                if (modalForm.ShowDialog() == DialogResult.OK)
                {
                    var appointment = new Appointment
                    {
                        DateAppointments = modalForm.AppointmentDate,
                        Diagnosis = modalForm.Diagnosis,
                        Treatment = modalForm.Treatment,
                        PatientId = modalForm.PatientId,
                        DoctorId = modalForm.DoctorId
                    };

                    try
                    {
                        appointmentService.AddAppointment(appointment);
                        LoadAppointments();
                        MessageBox.Show("Cita agregada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al agregar la cita: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void UpdateAppointmentsButton_Click(object sender, EventArgs e)
        {
            if (AppointmentsDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = AppointmentsDataGridView.SelectedRows[0];
                var appointmentId = int.Parse(selectedRow.Cells["id"].Value.ToString());

                using (var modalForm = new AppointmentsModalForm())
                {
                    modalForm.Text = "Editar Cita";

                    // Llenar los campos del modal con los datos de la cita seleccionada
                    modalForm.AppointmentDateTimePicker.Value = DateTime.Parse(selectedRow.Cells["appointmentDate"].Value.ToString());
                    modalForm.DiagnosticAppointmentTextBox.Text = selectedRow.Cells["diagnosis"].Value.ToString();
                    modalForm.TratamientAppointmentTextBox.Text = selectedRow.Cells["treatment"].Value.ToString();

                    try
                    {
                        // Asignar el valor del ComboBox de paciente y doctor, si existen en la lista
                        var patientId = int.Parse(selectedRow.Cells["patientId"].Value.ToString());
                        var doctorId = int.Parse(selectedRow.Cells["doctorId"].Value.ToString());

                        if (modalForm.PatientComboBox.Items.Contains(patientId))
                        {
                            modalForm.PatientComboBox.SelectedValue = patientId;
                        }

                        if (modalForm.DoctorComboBox.Items.Contains(doctorId))
                        {
                            modalForm.DoctorComboBox.SelectedValue = doctorId;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al cargar datos de la cita para edición: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (modalForm.ShowDialog() == DialogResult.OK)
                    {
                        var appointment = new Appointment
                        {
                            AppointmentsId = appointmentId,
                            DateAppointments = modalForm.AppointmentDate,
                            Diagnosis = modalForm.Diagnosis,
                            Treatment = modalForm.Treatment,
                            PatientId = modalForm.PatientId,
                            DoctorId = modalForm.DoctorId
                        };

                        try
                        {
                            appointmentService.EditAppointment(appointment);
                            LoadAppointments();
                            MessageBox.Show("Cita actualizada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al actualizar la cita: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una cita para editar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteAppointmentsButton_Click(object sender, EventArgs e)
        {
            if (AppointmentsDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = AppointmentsDataGridView.SelectedRows[0];
                var appointmentId = int.Parse(selectedRow.Cells["id"].Value.ToString());

                var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar esta cita?",
                                                    "Confirmar Eliminación",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        appointmentService.DeleteAppointment(appointmentId);
                        LoadAppointments();
                        MessageBox.Show("Cita eliminada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar la cita: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una cita para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
