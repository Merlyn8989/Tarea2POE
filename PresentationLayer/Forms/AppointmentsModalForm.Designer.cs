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
<<<<<<< HEAD
            LabelDateAppointments = new Label();
            TratamientAppointmentTextBox = new TextBox();
            DoctorLabel = new Label();
            DiagnosticAppointmentTextBox = new TextBox();
            PatientLabel = new Label();
            TratamientLabel = new Label();
            DiacnosticLabel = new Label();
            AppointmentSaveButton = new Button();
            AppointmentCancelButton = new Button();
            patientsTitleLabel = new Label();
            AppointmentDateTimePicker = new DateTimePicker();
            PatientComboBox = new ComboBox();
            DoctorComboBox = new ComboBox();
            SuspendLayout();
            // 
            // LabelDateAppointments
            // 
            LabelDateAppointments.AutoSize = true;
            LabelDateAppointments.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelDateAppointments.ForeColor = SystemColors.Window;
            LabelDateAppointments.Location = new Point(223, 91);
            LabelDateAppointments.Name = "LabelDateAppointments";
            LabelDateAppointments.Size = new Size(148, 28);
            LabelDateAppointments.TabIndex = 32;
            LabelDateAppointments.Text = "Fecha de la Cita";
            // 
            // TratamientAppointmentTextBox
            // 
            TratamientAppointmentTextBox.BackColor = SystemColors.MenuBar;
            TratamientAppointmentTextBox.Location = new Point(377, 316);
            TratamientAppointmentTextBox.Name = "TratamientAppointmentTextBox";
            TratamientAppointmentTextBox.Size = new Size(167, 27);
            TratamientAppointmentTextBox.TabIndex = 30;
            // 
            // DoctorLabel
            // 
            DoctorLabel.AutoSize = true;
            DoctorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DoctorLabel.ForeColor = SystemColors.Window;
            DoctorLabel.Location = new Point(223, 198);
            DoctorLabel.Name = "DoctorLabel";
            DoctorLabel.Size = new Size(77, 28);
            DoctorLabel.TabIndex = 29;
            DoctorLabel.Text = "Doctor:";
            // 
            // DiagnosticAppointmentTextBox
            // 
            DiagnosticAppointmentTextBox.BackColor = SystemColors.MenuBar;
            DiagnosticAppointmentTextBox.Location = new Point(377, 263);
            DiagnosticAppointmentTextBox.Name = "DiagnosticAppointmentTextBox";
            DiagnosticAppointmentTextBox.Size = new Size(167, 27);
            DiagnosticAppointmentTextBox.TabIndex = 28;
            // 
            // PatientLabel
            // 
            PatientLabel.AutoSize = true;
            PatientLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PatientLabel.ForeColor = SystemColors.Window;
            PatientLabel.Location = new Point(223, 145);
            PatientLabel.Name = "PatientLabel";
            PatientLabel.Size = new Size(88, 28);
            PatientLabel.TabIndex = 27;
            PatientLabel.Text = "Paciente:";
            // 
            // TratamientLabel
            // 
            TratamientLabel.AutoSize = true;
            TratamientLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TratamientLabel.ForeColor = SystemColors.Window;
            TratamientLabel.Location = new Point(223, 312);
            TratamientLabel.Name = "TratamientLabel";
            TratamientLabel.Size = new Size(116, 28);
            TratamientLabel.TabIndex = 25;
            TratamientLabel.Text = "Tratamiento";
            // 
            // DiacnosticLabel
            // 
            DiacnosticLabel.AutoSize = true;
            DiacnosticLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DiacnosticLabel.ForeColor = SystemColors.Window;
            DiacnosticLabel.Location = new Point(223, 259);
            DiacnosticLabel.Name = "DiacnosticLabel";
            DiacnosticLabel.Size = new Size(121, 28);
            DiacnosticLabel.TabIndex = 23;
            DiacnosticLabel.Text = "Diagnostico:";
            // 
            // AppointmentSaveButton
            // 
            AppointmentSaveButton.BackColor = SystemColors.MenuBar;
            AppointmentSaveButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AppointmentSaveButton.ForeColor = Color.Teal;
            AppointmentSaveButton.Location = new Point(223, 385);
            AppointmentSaveButton.Name = "AppointmentSaveButton";
            AppointmentSaveButton.Size = new Size(122, 53);
            AppointmentSaveButton.TabIndex = 22;
            AppointmentSaveButton.Text = "Guardar";
            AppointmentSaveButton.UseVisualStyleBackColor = false;
            // 
            // AppointmentCancelButton
            // 
            AppointmentCancelButton.BackColor = SystemColors.MenuBar;
            AppointmentCancelButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AppointmentCancelButton.ForeColor = Color.Teal;
            AppointmentCancelButton.Location = new Point(405, 385);
            AppointmentCancelButton.Name = "AppointmentCancelButton";
            AppointmentCancelButton.Size = new Size(139, 53);
            AppointmentCancelButton.TabIndex = 21;
            AppointmentCancelButton.Text = "Salir";
            AppointmentCancelButton.UseVisualStyleBackColor = false;
            // 
            // patientsTitleLabel
            // 
            patientsTitleLabel.AutoSize = true;
            patientsTitleLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientsTitleLabel.ForeColor = SystemColors.Window;
            patientsTitleLabel.Location = new Point(237, 22);
            patientsTitleLabel.Name = "patientsTitleLabel";
            patientsTitleLabel.Size = new Size(277, 54);
            patientsTitleLabel.TabIndex = 34;
            patientsTitleLabel.Text = " Citas Medicas";
            // 
            // AppointmentDateTimePicker
            // 
            AppointmentDateTimePicker.Location = new Point(377, 93);
            AppointmentDateTimePicker.Name = "AppointmentDateTimePicker";
            AppointmentDateTimePicker.Size = new Size(167, 27);
            AppointmentDateTimePicker.TabIndex = 35;
            // 
            // PatientComboBox
            // 
            PatientComboBox.FormattingEnabled = true;
            PatientComboBox.Location = new Point(374, 149);
            PatientComboBox.Name = "PatientComboBox";
            PatientComboBox.Size = new Size(170, 28);
            PatientComboBox.TabIndex = 36;
            // 
            // DoctorComboBox
            // 
            DoctorComboBox.FormattingEnabled = true;
            DoctorComboBox.Location = new Point(374, 202);
            DoctorComboBox.Name = "DoctorComboBox";
            DoctorComboBox.Size = new Size(170, 28);
            DoctorComboBox.TabIndex = 37;
=======
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
>>>>>>> 0533192f96ffacaf2b496e433d87d41693b467d4
            // 
            // AppointmentsModalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 108, 108);
<<<<<<< HEAD
            ClientSize = new Size(773, 476);
            Controls.Add(DoctorComboBox);
            Controls.Add(PatientComboBox);
            Controls.Add(AppointmentDateTimePicker);
            Controls.Add(patientsTitleLabel);
            Controls.Add(LabelDateAppointments);
            Controls.Add(TratamientAppointmentTextBox);
            Controls.Add(DoctorLabel);
            Controls.Add(DiagnosticAppointmentTextBox);
            Controls.Add(PatientLabel);
            Controls.Add(TratamientLabel);
            Controls.Add(DiacnosticLabel);
            Controls.Add(AppointmentSaveButton);
            Controls.Add(AppointmentCancelButton);
=======
            ClientSize = new Size(800, 450);
            Controls.Add(idDoctorTextBox);
            Controls.Add(idAppintmentLabel);
            Controls.Add(specialtyDoctorTextBox);
            Controls.Add(specialtyDoctorLabel);
            Controls.Add(nameDoctorTextBox);
            Controls.Add(firstNameDoctor);
            Controls.Add(doctorSaveButton);
            Controls.Add(doctorCancelButton);
>>>>>>> 0533192f96ffacaf2b496e433d87d41693b467d4
            Name = "AppointmentsModalForm";
            Text = "AppointmentsModalForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
<<<<<<< HEAD
        private Label LabelDateAppointments;
        public TextBox TratamientAppointmentTextBox;
        private Label DoctorLabel;
        public TextBox DiagnosticAppointmentTextBox;
        public Label PatientLabel;
        private Label TratamientLabel;
        private Label DiacnosticLabel;
        private Button AppointmentSaveButton;
        private Button AppointmentCancelButton;
        private Label patientsTitleLabel;
        public DateTimePicker AppointmentDateTimePicker;
        public ComboBox PatientComboBox;
        public ComboBox DoctorComboBox;
=======

        public TextBox idDoctorTextBox;
        private Label idAppintmentLabel;
        public TextBox specialtyDoctorTextBox;
        private Label specialtyDoctorLabel;
        public TextBox nameDoctorTextBox;
        private Label firstNameDoctor;
        private Button doctorSaveButton;
        private Button doctorCancelButton;
>>>>>>> 0533192f96ffacaf2b496e433d87d41693b467d4
    }
}