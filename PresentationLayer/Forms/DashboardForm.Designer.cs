namespace PresentationLayer.Forms
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            LogoPicture = new PictureBox();
            panel1 = new Panel();
            Homebutton = new Button();
            panel4 = new Panel();
            PatientsButton = new Button();
            panel5 = new Panel();
            DoctorsButton = new Button();
            CitasContainerMenu = new Panel();
            MenuCitasButton = new Button();
            Principalpanel = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPicture).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            CitasContainerMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Teal;
            flowLayoutPanel1.Controls.Add(LogoPicture);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(CitasContainerMenu);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(250, 777);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // LogoPicture
            // 
            LogoPicture.Image = Properties.Resources.logoblanco;
            LogoPicture.Location = new Point(3, 3);
            LogoPicture.Name = "LogoPicture";
            LogoPicture.Size = new Size(247, 215);
            LogoPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoPicture.TabIndex = 1;
            LogoPicture.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(Homebutton);
            panel1.Location = new Point(0, 222);
            panel1.Margin = new Padding(0, 1, 0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 45);
            panel1.TabIndex = 4;
            // 
            // Homebutton
            // 
            Homebutton.BackColor = Color.FromArgb(21, 108, 108);
            Homebutton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Homebutton.ForeColor = Color.White;
            Homebutton.Location = new Point(-26, -6);
            Homebutton.Name = "Homebutton";
            Homebutton.Size = new Size(280, 55);
            Homebutton.TabIndex = 2;
            Homebutton.Text = "Inicio";
            Homebutton.UseVisualStyleBackColor = false;
            Homebutton.Click += Homebutton_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(PatientsButton);
            panel4.Location = new Point(0, 268);
            panel4.Margin = new Padding(0, 1, 0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 45);
            panel4.TabIndex = 6;
            // 
            // PatientsButton
            // 
            PatientsButton.BackColor = Color.FromArgb(21, 108, 108);
            PatientsButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PatientsButton.ForeColor = Color.White;
            PatientsButton.Location = new Point(-16, -6);
            PatientsButton.Name = "PatientsButton";
            PatientsButton.Size = new Size(280, 55);
            PatientsButton.TabIndex = 2;
            PatientsButton.Text = "Pacientes";
            PatientsButton.UseVisualStyleBackColor = false;
            PatientsButton.Click += PatientsButton_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(DoctorsButton);
            panel5.Location = new Point(0, 314);
            panel5.Margin = new Padding(0, 1, 0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 45);
            panel5.TabIndex = 6;
            // 
            // DoctorsButton
            // 
            DoctorsButton.BackColor = Color.FromArgb(21, 108, 108);
            DoctorsButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DoctorsButton.ForeColor = Color.White;
            DoctorsButton.Location = new Point(-16, -6);
            DoctorsButton.Name = "DoctorsButton";
            DoctorsButton.Size = new Size(280, 55);
            DoctorsButton.TabIndex = 2;
            DoctorsButton.Text = "Doctores";
            DoctorsButton.UseVisualStyleBackColor = false;
            DoctorsButton.Click += DoctorsButton_Click;
            // 
            // CitasContainerMenu
            // 
            CitasContainerMenu.BackColor = Color.FromArgb(14, 44, 44);
            CitasContainerMenu.Controls.Add(MenuCitasButton);
            CitasContainerMenu.Location = new Point(0, 360);
            CitasContainerMenu.Margin = new Padding(0, 1, 0, 0);
            CitasContainerMenu.Name = "CitasContainerMenu";
            CitasContainerMenu.Size = new Size(250, 47);
            CitasContainerMenu.TabIndex = 5;
            // 
            // MenuCitasButton
            // 
            MenuCitasButton.BackColor = Color.FromArgb(21, 108, 108);
            MenuCitasButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MenuCitasButton.ForeColor = Color.White;
            MenuCitasButton.Location = new Point(-36, -4);
            MenuCitasButton.Name = "MenuCitasButton";
            MenuCitasButton.Size = new Size(300, 55);
            MenuCitasButton.TabIndex = 2;
            MenuCitasButton.Text = "Citas";
            MenuCitasButton.UseVisualStyleBackColor = false;
            // 
            // Principalpanel
            // 
            Principalpanel.BackColor = Color.Transparent;
            Principalpanel.BackgroundImage = Properties.Resources.Home;
            Principalpanel.Dock = DockStyle.Fill;
            Principalpanel.Location = new Point(250, 0);
            Principalpanel.Name = "Principalpanel";
            Principalpanel.Size = new Size(1128, 777);
            Principalpanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Home;
            pictureBox1.Location = new Point(1128, 777);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 215);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Home;
            pictureBox2.Location = new Point(253, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1128, 777);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 777);
            Controls.Add(pictureBox1);
            Controls.Add(Principalpanel);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox2);
            Name = "DashboardForm";
            Text = "DashboardForm";
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LogoPicture).EndInit();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            CitasContainerMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox LogoPicture;
        private Panel panel1;
        private Button Homebutton;
        private Panel panel4;
        private Button PatientsButton;
        private Panel panel5;
        private Button DoctorsButton;
        private Panel CitasContainerMenu;
        private Button MenuCitasButton;
        private Panel Principalpanel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}