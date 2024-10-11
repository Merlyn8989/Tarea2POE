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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }
        bool menuExpand = false;

        private void menutransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                CitasContainerMenu.Height += 10;
                if (CitasContainerMenu.Height >= 130)
                {
                    TransitionTimer.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                CitasContainerMenu.Height -= 10;
                if (CitasContainerMenu.Height <= 45)
                {
                    TransitionTimer.Stop();
                    menuExpand = false;
                }
            }
        }

        private void MenuCitasButton_Click(object sender, EventArgs e)
        {
            MenuCitasButton_Click(sender, e, TransitionTimer);
        }

        private void MenuCitasButton_Click(object sender, EventArgs e, System.Windows.Forms.Timer transitionTimer)
        {
            transitionTimer.Start();
        }
        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Principalpanel.Controls.Add(childForm);
            Principalpanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }



        private void Homebutton_Click(object sender, EventArgs e)
        {
            openChildForm(new HomeForm());
        }

        private void PatientsButton_Click(object sender, EventArgs e)
        {
            openChildForm(new PatientsForm());
        }

        private void DoctorsButton_Click(object sender, EventArgs e)
        {
            openChildForm(new DoctorsForm());

        }
    }
}
