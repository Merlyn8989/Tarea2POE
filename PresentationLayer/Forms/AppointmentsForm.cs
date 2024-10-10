using System;
using System.Windows.Forms;
using BusinessLayer.Services;
using BussisnesLayer.Services;

namespace PresentationLayer.Forms
{
    public partial class AppointmentsForm : Form
    {
        private readonly AppointmentService _appointmentService;

        public AppointmentsForm()
        {
            InitializeComponent();
            _appointmentService = new AppointmentService();
            LoadAppointments();

            // Enlazar eventos de los botones a sus respectivos métodos
            AppointmentsAddButton.Click += AppointmentsAddButton_Click;
            AppointmentsUpdateButton.Click += AppointmentsUpdateButton_Click;
            AppointmentsDeleteButton.Click += AppointmentsDeleteButton_Click;
        }

        private void LoadAppointments()
        {
            try
            {
                AppointmentsDataGridView.DataSource = _appointmentService.GetAllAppointments();
                AppointmentsDataGridView.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar las citas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AppointmentsAddButton_Click(object sender, EventArgs e)
        {
            using (var appointmentModal = new AppointmentsModalForm())
            {
                appointmentModal.EditMode = false;
                var result = appointmentModal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    LoadAppointments();
                }
            }
        }

        private void AppointmentsUpdateButton_Click(object sender, EventArgs e)
        {
            if (AppointmentsDataGridView.SelectedRows.Count > 0)
            {
                int appointmentId = Convert.ToInt32(AppointmentsDataGridView.SelectedRows[0].Cells["id"].Value);

                using (var appointmentModal = new AppointmentsModalForm())
                {
                    appointmentModal.EditMode = true;
                    appointmentModal.Tag = appointmentId;
                    var result = appointmentModal.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        LoadAppointments();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una cita para editar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AppointmentsDeleteButton_Click(object sender, EventArgs e)
        {
            if (AppointmentsDataGridView.SelectedRows.Count > 0)
            {
                int appointmentId = Convert.ToInt32(AppointmentsDataGridView.SelectedRows[0].Cells["id"].Value);

                var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar esta cita?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        _appointmentService.DeleteAppointment(appointmentId);
                        LoadAppointments();
                        MessageBox.Show("La cita ha sido eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocurrió un error al eliminar la cita: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una cita para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
