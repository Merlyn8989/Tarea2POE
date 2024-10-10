namespace PresentationLayer.Forms
{
    partial class PatientModalForm
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
            patientCancelButton = new Button();
            patientSaveButton = new Button();
            namePatientLabel = new Label();
            namePatientTextBox = new TextBox();
            lastNamePatientTextBox = new TextBox();
            lastNameLabel = new Label();
            dateOfBirthPatientTextBox = new TextBox();
            dateOfBirthPatientLabel = new Label();
            genderPatientTextBox = new TextBox();
            genderPatientLabel = new Label();
            titleLabel = new Label();
            idPatientTextBox = new TextBox();
            idPatientLabel = new Label();
            SuspendLayout();
            // 
            // patientCancelButton
            // 
            patientCancelButton.BackColor = SystemColors.MenuBar;
            patientCancelButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            patientCancelButton.ForeColor = Color.Teal;
            patientCancelButton.Location = new Point(308, 368);
            patientCancelButton.Name = "patientCancelButton";
            patientCancelButton.Size = new Size(139, 53);
            patientCancelButton.TabIndex = 8;
            patientCancelButton.Text = "Salir";
            patientCancelButton.UseVisualStyleBackColor = false;
            // 
            // patientSaveButton
            // 
            patientSaveButton.BackColor = SystemColors.MenuBar;
            patientSaveButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            patientSaveButton.ForeColor = Color.Teal;
            patientSaveButton.Location = new Point(139, 368);
            patientSaveButton.Name = "patientSaveButton";
            patientSaveButton.Size = new Size(122, 53);
            patientSaveButton.TabIndex = 9;
            patientSaveButton.Text = "Guardar";
            patientSaveButton.UseVisualStyleBackColor = false;
            patientSaveButton.Click += patientSaveButton_Click;
            // 
            // namePatientLabel
            // 
            namePatientLabel.AutoSize = true;
            namePatientLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            namePatientLabel.ForeColor = SystemColors.Window;
            namePatientLabel.Location = new Point(173, 129);
            namePatientLabel.Name = "namePatientLabel";
            namePatientLabel.Size = new Size(89, 28);
            namePatientLabel.TabIndex = 10;
            namePatientLabel.Text = "Nombre:";
            // 
            // namePatientTextBox
            // 
            namePatientTextBox.BackColor = SystemColors.MenuBar;
            namePatientTextBox.Location = new Point(280, 129);
            namePatientTextBox.Name = "namePatientTextBox";
            namePatientTextBox.Size = new Size(167, 27);
            namePatientTextBox.TabIndex = 11;
            // 
            // lastNamePatientTextBox
            // 
            lastNamePatientTextBox.BackColor = SystemColors.MenuBar;
            lastNamePatientTextBox.Location = new Point(280, 186);
            lastNamePatientTextBox.Name = "lastNamePatientTextBox";
            lastNamePatientTextBox.Size = new Size(167, 27);
            lastNamePatientTextBox.TabIndex = 13;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameLabel.ForeColor = SystemColors.Window;
            lastNameLabel.Location = new Point(171, 185);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(90, 28);
            lastNameLabel.TabIndex = 12;
            lastNameLabel.Text = "Apellido:";
            // 
            // dateOfBirthPatientTextBox
            // 
            dateOfBirthPatientTextBox.BackColor = SystemColors.MenuBar;
            dateOfBirthPatientTextBox.Location = new Point(280, 247);
            dateOfBirthPatientTextBox.Name = "dateOfBirthPatientTextBox";
            dateOfBirthPatientTextBox.Size = new Size(167, 27);
            dateOfBirthPatientTextBox.TabIndex = 15;
            // 
            // dateOfBirthPatientLabel
            // 
            dateOfBirthPatientLabel.AutoSize = true;
            dateOfBirthPatientLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateOfBirthPatientLabel.ForeColor = SystemColors.Window;
            dateOfBirthPatientLabel.Location = new Point(66, 246);
            dateOfBirthPatientLabel.Name = "dateOfBirthPatientLabel";
            dateOfBirthPatientLabel.Size = new Size(195, 28);
            dateOfBirthPatientLabel.TabIndex = 14;
            dateOfBirthPatientLabel.Text = "Fecha de nacimiento:";
            // 
            // genderPatientTextBox
            // 
            genderPatientTextBox.BackColor = SystemColors.MenuBar;
            genderPatientTextBox.Location = new Point(280, 300);
            genderPatientTextBox.Name = "genderPatientTextBox";
            genderPatientTextBox.Size = new Size(167, 27);
            genderPatientTextBox.TabIndex = 17;
            // 
            // genderPatientLabel
            // 
            genderPatientLabel.AutoSize = true;
            genderPatientLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genderPatientLabel.ForeColor = SystemColors.Window;
            genderPatientLabel.Location = new Point(178, 296);
            genderPatientLabel.Name = "genderPatientLabel";
            genderPatientLabel.Size = new Size(80, 28);
            genderPatientLabel.TabIndex = 16;
            genderPatientLabel.Text = "Género:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = Color.FromArgb(21, 108, 108);
            titleLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = SystemColors.MenuBar;
            titleLabel.Location = new Point(179, 19);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(0, 38);
            titleLabel.TabIndex = 18;
            // 
            // idPatientTextBox
            // 
            idPatientTextBox.BackColor = SystemColors.MenuBar;
            idPatientTextBox.Location = new Point(280, 75);
            idPatientTextBox.Name = "idPatientTextBox";
            idPatientTextBox.Size = new Size(167, 27);
            idPatientTextBox.TabIndex = 20;
            // 
            // idPatientLabel
            // 
            idPatientLabel.AutoSize = true;
            idPatientLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idPatientLabel.ForeColor = SystemColors.Window;
            idPatientLabel.Location = new Point(225, 74);
            idPatientLabel.Name = "idPatientLabel";
            idPatientLabel.Size = new Size(33, 28);
            idPatientLabel.TabIndex = 19;
            idPatientLabel.Text = "Id:";
            // 
            // PatientModalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 108, 108);
            ClientSize = new Size(571, 458);
            Controls.Add(idPatientTextBox);
            Controls.Add(idPatientLabel);
            Controls.Add(titleLabel);
            Controls.Add(genderPatientTextBox);
            Controls.Add(genderPatientLabel);
            Controls.Add(dateOfBirthPatientTextBox);
            Controls.Add(dateOfBirthPatientLabel);
            Controls.Add(lastNamePatientTextBox);
            Controls.Add(lastNameLabel);
            Controls.Add(namePatientTextBox);
            Controls.Add(namePatientLabel);
            Controls.Add(patientSaveButton);
            Controls.Add(patientCancelButton);
            ForeColor = SystemColors.MenuBar;
            Name = "PatientModalForm";
            Text = "PatientModalForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button patientCancelButton;
        private Button patientSaveButton;
        private Label namePatientLabel;
        private Label lastNameLabel;
        private Label genderPatientLabel;
        private Label titleLabel;
        public Label dateOfBirthPatientLabel;
        public TextBox namePatientTextBox;
        public TextBox lastNamePatientTextBox;
        public TextBox dateOfBirthPatientTextBox;
        public TextBox genderPatientTextBox;
        public TextBox idPatientTextBox;
        private Label idPatientLabel;
    }
}