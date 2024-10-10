namespace PresentationLayer.Forms
{
    partial class DoctorModalForm
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
            components = new System.ComponentModel.Container();
            specialtyDoctorTextBox = new TextBox();
            specialtyDoctorLabel = new Label();
            nameDoctorTextBox = new TextBox();
            firstNameDoctor = new Label();
            doctorSaveButton = new Button();
            doctorCancelButton = new Button();
            textDoctor = new Label();
            idDoctorTextBox = new TextBox();
            idDoctorLabel = new Label();
            ErrorDoctorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)ErrorDoctorProvider).BeginInit();
            SuspendLayout();
            // 
            // specialtyDoctorTextBox
            // 
            specialtyDoctorTextBox.BackColor = SystemColors.MenuBar;
            specialtyDoctorTextBox.Location = new Point(254, 248);
            specialtyDoctorTextBox.Name = "specialtyDoctorTextBox";
            specialtyDoctorTextBox.Size = new Size(167, 27);
            specialtyDoctorTextBox.TabIndex = 27;
            // 
            // specialtyDoctorLabel
            // 
            specialtyDoctorLabel.AutoSize = true;
            specialtyDoctorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            specialtyDoctorLabel.ForeColor = SystemColors.Window;
            specialtyDoctorLabel.Location = new Point(124, 248);
            specialtyDoctorLabel.Name = "specialtyDoctorLabel";
            specialtyDoctorLabel.Size = new Size(124, 28);
            specialtyDoctorLabel.TabIndex = 26;
            specialtyDoctorLabel.Text = "Especialidad:";
            // 
            // nameDoctorTextBox
            // 
            nameDoctorTextBox.BackColor = SystemColors.MenuBar;
            nameDoctorTextBox.Location = new Point(254, 185);
            nameDoctorTextBox.Name = "nameDoctorTextBox";
            nameDoctorTextBox.Size = new Size(167, 27);
            nameDoctorTextBox.TabIndex = 21;
            // 
            // firstNameDoctor
            // 
            firstNameDoctor.AutoSize = true;
            firstNameDoctor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameDoctor.ForeColor = SystemColors.Window;
            firstNameDoctor.Location = new Point(147, 185);
            firstNameDoctor.Name = "firstNameDoctor";
            firstNameDoctor.Size = new Size(89, 28);
            firstNameDoctor.TabIndex = 20;
            firstNameDoctor.Text = "Nombre:";
            // 
            // doctorSaveButton
            // 
            doctorSaveButton.BackColor = SystemColors.MenuBar;
            doctorSaveButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            doctorSaveButton.ForeColor = Color.Teal;
            doctorSaveButton.Location = new Point(113, 325);
            doctorSaveButton.Name = "doctorSaveButton";
            doctorSaveButton.Size = new Size(122, 53);
            doctorSaveButton.TabIndex = 19;
            doctorSaveButton.Text = "Guardar";
            doctorSaveButton.UseVisualStyleBackColor = false;
            doctorSaveButton.Click += doctorSaveButton_Click;
            // 
            // doctorCancelButton
            // 
            doctorCancelButton.BackColor = SystemColors.MenuBar;
            doctorCancelButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            doctorCancelButton.ForeColor = Color.Teal;
            doctorCancelButton.Location = new Point(282, 325);
            doctorCancelButton.Name = "doctorCancelButton";
            doctorCancelButton.Size = new Size(139, 53);
            doctorCancelButton.TabIndex = 18;
            doctorCancelButton.Text = "Salir";
            doctorCancelButton.UseVisualStyleBackColor = false;
            // 
            // textDoctor
            // 
            textDoctor.AutoSize = true;
            textDoctor.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            textDoctor.ForeColor = SystemColors.MenuBar;
            textDoctor.Location = new Point(152, 19);
            textDoctor.Name = "textDoctor";
            textDoctor.Size = new Size(0, 38);
            textDoctor.TabIndex = 28;
            // 
            // idDoctorTextBox
            // 
            idDoctorTextBox.BackColor = SystemColors.MenuBar;
            idDoctorTextBox.Location = new Point(254, 130);
            idDoctorTextBox.Name = "idDoctorTextBox";
            idDoctorTextBox.Size = new Size(167, 27);
            idDoctorTextBox.TabIndex = 30;
            // 
            // idDoctorLabel
            // 
            idDoctorLabel.AutoSize = true;
            idDoctorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idDoctorLabel.ForeColor = SystemColors.Window;
            idDoctorLabel.Location = new Point(199, 129);
            idDoctorLabel.Name = "idDoctorLabel";
            idDoctorLabel.Size = new Size(33, 28);
            idDoctorLabel.TabIndex = 29;
            idDoctorLabel.Text = "Id:";
            // 
            // ErrorDoctorProvider
            // 
            ErrorDoctorProvider.ContainerControl = this;
            // 
            // DoctorModalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 108, 108);
            ClientSize = new Size(512, 450);
            Controls.Add(idDoctorTextBox);
            Controls.Add(idDoctorLabel);
            Controls.Add(textDoctor);
            Controls.Add(specialtyDoctorTextBox);
            Controls.Add(specialtyDoctorLabel);
            Controls.Add(nameDoctorTextBox);
            Controls.Add(firstNameDoctor);
            Controls.Add(doctorSaveButton);
            Controls.Add(doctorCancelButton);
            Name = "DoctorModalForm";
            Text = "DoctorModalForm";
            ((System.ComponentModel.ISupportInitialize)ErrorDoctorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label specialtyDoctorLabel;
        private Label firstNameDoctor;
        private Button doctorSaveButton;
        private Button doctorCancelButton;
        private Label textDoctor;
        public TextBox nameDoctorTextBox;
        public TextBox specialtyDoctorTextBox;
        public TextBox idDoctorTextBox;
        private Label idDoctorLabel;
        private ErrorProvider ErrorDoctorProvider;
    }
}