using CommonLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{

    public partial class DoctorModalForm : Form
    {
        public bool editMode { get; set; }
        public Doctor Doctor { get; set; }

        public Doctor DoctorData { get; set; }
        public DoctorModalForm()
        {
            InitializeComponent();
            DoctorData = new Doctor();
            Doctor = new Doctor();
            this.StartPosition = FormStartPosition.CenterParent;
            this.Load += DoctorModalForm_Load;
        }
        private void DoctorModalForm_Load(object? sender, EventArgs e)
        {
            if (editMode)
            {
                textDoctor.Text = "Editar Doctor";
            }
            else
            {
                textDoctor.Text = "Agregar Doctor";
            }
        }
    }
}