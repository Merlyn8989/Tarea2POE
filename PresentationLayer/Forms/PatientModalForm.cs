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
    public partial class PatientModalForm : Form
    {
        public bool editMode { get; set; }
        public PatientModalForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.Load += PatientModalForm_Load;
        }

        private void PatientModalForm_Load(object sender, EventArgs e)
        {
            if (editMode)
            {
                titleLabel.Text = "Editar Paciente";
            }
            else
            {
                titleLabel.Text = "Agregar Paciente";
            }
        }


    }
}
