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
            LoadDoctorsData();

            doctorsDataGridView.DataSource = _doctorService.GetAllDoctors();
        }

        public void LoadDoctorsData()
        {
            doctorsDataGridView.DataSource = _doctorService.GetAllDoctors();

        }

        private void doctorAddButton_Click_1(object sender, EventArgs e)
        {
            var formModal = new DoctorModalForm(this)
            {
                editMode = false
            };

            if (formModal.ShowDialog(this) == DialogResult.OK)
            {
                LoadDoctorsData();
            }
        }

        private void doctorUpdateButton_Click(object sender, EventArgs e)
        {
            var formModal = new DoctorModalForm(this);
            if (doctorsDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debes seleccionar un doctor", "cuidado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                formModal.idDoctorTextBox.Text = doctorsDataGridView.CurrentRow.Cells[0].Value.ToString();
                formModal.nameDoctorTextBox.Text = doctorsDataGridView.CurrentRow.Cells[1].Value.ToString();
                formModal.specialtyDoctorTextBox.Text = doctorsDataGridView.CurrentRow.Cells[2].Value.ToString();
                formModal.editMode = true;
                if (formModal.ShowDialog(this) == DialogResult.OK)
                {
                    LoadDoctorsData();
                }
            }
        }

        private void doctorDeleteButton_Click(object sender, EventArgs e)
        {
            if (doctorsDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debes seleccionar un doctor", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var deleteConfirm = new DialogResult();

                deleteConfirm = MessageBox.Show("Está seguro que desea eliminar el dato?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (deleteConfirm == DialogResult.Yes)
                {
                    int id = int.Parse(doctorsDataGridView.CurrentRow.Cells[0].Value.ToString());
                    _doctorService.DeleteDoctor(id);
                    LoadDoctorsData();
                }
            }
        }
    }
}

