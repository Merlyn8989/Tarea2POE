namespace PresentationLayer.Forms
{
    partial class AppointmentsModalForm
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
            idDoctorTextBox = new TextBox();
            idAppintmentLabel = new Label();
            specialtyDoctorTextBox = new TextBox();
            specialtyDoctorLabel = new Label();
            nameDoctorTextBox = new TextBox();
            firstNameDoctor = new Label();
            doctorSaveButton = new Button();
            doctorCancelButton = new Button();
            SuspendLayout();
            // 
            // idDoctorTextBox
            // 
            idDoctorTextBox.BackColor = SystemColors.MenuBar;
            idDoctorTextBox.Location = new Point(387, 102);
            idDoctorTextBox.Name = "idDoctorTextBox";
            idDoctorTextBox.Size = new Size(167, 27);
            idDoctorTextBox.TabIndex = 38;
            // 
            // idAppintmentLabel
            // 
            idAppintmentLabel.AutoSize = true;
            idAppintmentLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idAppintmentLabel.ForeColor = SystemColors.Window;
            idAppintmentLabel.Location = new Point(332, 101);
            idAppintmentLabel.Name = "idAppintmentLabel";
            idAppintmentLabel.Size = new Size(33, 28);
            idAppintmentLabel.TabIndex = 37;
            idAppintmentLabel.Text = "Id:";
            // 
            // specialtyDoctorTextBox
            // 
            specialtyDoctorTextBox.BackColor = SystemColors.MenuBar;
            specialtyDoctorTextBox.Location = new Point(387, 220);
            specialtyDoctorTextBox.Name = "specialtyDoctorTextBox";
            specialtyDoctorTextBox.Size = new Size(167, 27);
            specialtyDoctorTextBox.TabIndex = 36;
            // 
            // specialtyDoctorLabel
            // 
            specialtyDoctorLabel.AutoSize = true;
            specialtyDoctorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            specialtyDoctorLabel.ForeColor = SystemColors.Window;
            specialtyDoctorLabel.Location = new Point(257, 220);
            specialtyDoctorLabel.Name = "specialtyDoctorLabel";
            specialtyDoctorLabel.Size = new Size(124, 28);
            specialtyDoctorLabel.TabIndex = 35;
            specialtyDoctorLabel.Text = "Especialidad:";
            // 
            // nameDoctorTextBox
            // 
            nameDoctorTextBox.BackColor = SystemColors.MenuBar;
            nameDoctorTextBox.Location = new Point(387, 157);
            nameDoctorTextBox.Name = "nameDoctorTextBox";
            nameDoctorTextBox.Size = new Size(167, 27);
            nameDoctorTextBox.TabIndex = 34;
            // 
            // firstNameDoctor
            // 
            firstNameDoctor.AutoSize = true;
            firstNameDoctor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameDoctor.ForeColor = SystemColors.Window;
            firstNameDoctor.Location = new Point(280, 157);
            firstNameDoctor.Name = "firstNameDoctor";
            firstNameDoctor.Size = new Size(89, 28);
            firstNameDoctor.TabIndex = 33;
            firstNameDoctor.Text = "Nombre:";
            // 
            // doctorSaveButton
            // 
            doctorSaveButton.BackColor = SystemColors.MenuBar;
            doctorSaveButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            doctorSaveButton.ForeColor = Color.Teal;
            doctorSaveButton.Location = new Point(246, 297);
            doctorSaveButton.Name = "doctorSaveButton";
            doctorSaveButton.Size = new Size(122, 53);
            doctorSaveButton.TabIndex = 32;
            doctorSaveButton.Text = "Guardar";
            doctorSaveButton.UseVisualStyleBackColor = false;
            // 
            // doctorCancelButton
            // 
            doctorCancelButton.BackColor = SystemColors.MenuBar;
            doctorCancelButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            doctorCancelButton.ForeColor = Color.Teal;
            doctorCancelButton.Location = new Point(415, 297);
            doctorCancelButton.Name = "doctorCancelButton";
            doctorCancelButton.Size = new Size(139, 53);
            doctorCancelButton.TabIndex = 31;
            doctorCancelButton.Text = "Salir";
            doctorCancelButton.UseVisualStyleBackColor = false;
            // 
            // AppointmentsModalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 108, 108);
            ClientSize = new Size(800, 450);
            Controls.Add(idDoctorTextBox);
            Controls.Add(idAppintmentLabel);
            Controls.Add(specialtyDoctorTextBox);
            Controls.Add(specialtyDoctorLabel);
            Controls.Add(nameDoctorTextBox);
            Controls.Add(firstNameDoctor);
            Controls.Add(doctorSaveButton);
            Controls.Add(doctorCancelButton);
            Name = "AppointmentsModalForm";
            Text = "AppointmentsModalForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox idDoctorTextBox;
        private Label idAppintmentLabel;
        public TextBox specialtyDoctorTextBox;
        private Label specialtyDoctorLabel;
        public TextBox nameDoctorTextBox;
        private Label firstNameDoctor;
        private Button doctorSaveButton;
        private Button doctorCancelButton;
    }
}