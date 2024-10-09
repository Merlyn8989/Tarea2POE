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
        }


        // Evento del botón para eliminar un doctor
        private void doctorDeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void doctorAddButton_Click_1(object sender, EventArgs e)
        {
            var formModal = new DoctorModalForm();

            formModal.editMode = false;

            formModal.ShowDialog(this);
        }

        private void doctorUpdateButton_Click(object sender, EventArgs e)
        {
            var formModal = new DoctorModalForm();

            formModal.editMode = true;

            formModal.ShowDialog(this);
        }
    }
}