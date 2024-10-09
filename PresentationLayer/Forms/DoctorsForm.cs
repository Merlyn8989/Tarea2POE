using BussisnesLayer.Services;
using CommonLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class DoctorsForm : Form
    {
        private DoctorService _doctorService;

        public DoctorsForm()
        {
            InitializeComponent();
            _doctorService = new DoctorService();
            LoadDoctors(); // Cargar la lista de doctores al iniciar el formulario
        }

        // Método para cargar la lista de doctores en un control DataGridView
        private void LoadDoctors()
        {
            DataTable doctorsTable = _doctorService.GetAllDoctors();
            doctorsDataGridView.DataSource = doctorsTable; // doctorDataGridView es el control que muestra la lista
        }

        // Evento del botón para agregar un nuevo doctor
        private void doctorAddButton_Click(object sender, EventArgs e)
        {
            var formModal = new DoctorModalForm();
            formModal.editMode = false; // Modo agregar

            if (formModal.ShowDialog(this) == DialogResult.OK)
            {
                Doctor newDoctor = formModal.DoctorData; // Obtenemos los datos del nuevo doctor
                _doctorService.AddDoctor(newDoctor);
                LoadDoctors(); // Refrescamos la lista de doctores
            }
        }

        // Evento del botón para actualizar la información de un doctor
        private void doctorUpdateButton_Click(object sender, EventArgs e)
        {
            if (doctorsDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = doctorsDataGridView.SelectedRows[0];
                var selectedDoctorId = (int)selectedRow.Cells["id"].Value; // Obtener el ID del doctor seleccionado

                // Crear objeto Doctor con los datos del doctor seleccionado
                Doctor selectedDoctor = new Doctor
                {
                    Id = selectedDoctorId,
                    FirstName = (string)selectedRow.Cells["firstName"].Value,
                    Specialty = (string)selectedRow.Cells["specialty"].Value
                };

                var formModal = new DoctorModalForm();
                formModal.editMode = true; // Modo editar
                formModal.DoctorData = selectedDoctor; // Pasar datos del doctor al modal

                if (formModal.ShowDialog(this) == DialogResult.OK)
                {
                    Doctor updatedDoctor = formModal.DoctorData; // Obtener los datos actualizados del doctor
                    _doctorService.EditDoctor(updatedDoctor);
                    LoadDoctors(); // Refrescar la lista de doctores
                }
            }
            else
            {
                MessageBox.Show("Seleccione un doctor para actualizar.");
            }
        }

        // Evento del botón para eliminar un doctor
        private void doctorDeleteButton_Click(object sender, EventArgs e)
        {
            if (doctorsDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = doctorsDataGridView.SelectedRows[0];
                var selectedDoctorId = (int)selectedRow.Cells["id"].Value; // Obtener el ID del doctor seleccionado

                var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este doctor?",
                                                    "Confirmar eliminación",
                                                    MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    _doctorService.DeleteDoctor(selectedDoctorId);
                    LoadDoctors(); // Refrescar la lista de doctores
                }
            }
            else
            {
                MessageBox.Show("Seleccione un doctor para eliminar.");
            }
        }
    }
}