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
            textBox4 = new TextBox();
            gender = new Label();
            textBox3 = new TextBox();
            fechaNacLabel = new Label();
            textBox2 = new TextBox();
            lastNameDoctor = new Label();
            textBox1 = new TextBox();
            firstNameDoctor = new Label();
            doctorSaveButton = new Button();
            doctorCancelButton = new Button();
            textDoctor = new Label();
            SuspendLayout();
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.MenuBar;
            textBox4.Location = new Point(254, 243);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(167, 27);
            textBox4.TabIndex = 27;
            // 
            // gender
            // 
            gender.AutoSize = true;
            gender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gender.ForeColor = SystemColors.Window;
            gender.Location = new Point(152, 239);
            gender.Name = "gender";
            gender.Size = new Size(80, 28);
            gender.TabIndex = 26;
            gender.Text = "Género:";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.MenuBar;
            textBox3.Location = new Point(254, 190);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(167, 27);
            textBox3.TabIndex = 25;
            // 
            // fechaNacLabel
            // 
            fechaNacLabel.AutoSize = true;
            fechaNacLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fechaNacLabel.ForeColor = SystemColors.Window;
            fechaNacLabel.Location = new Point(40, 190);
            fechaNacLabel.Name = "fechaNacLabel";
            fechaNacLabel.Size = new Size(195, 28);
            fechaNacLabel.TabIndex = 24;
            fechaNacLabel.Text = "Fecha de nacimiento:";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.MenuBar;
            textBox2.Location = new Point(254, 129);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(167, 27);
            textBox2.TabIndex = 23;
            // 
            // lastNameDoctor
            // 
            lastNameDoctor.AutoSize = true;
            lastNameDoctor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameDoctor.ForeColor = SystemColors.Window;
            lastNameDoctor.Location = new Point(135, 129);
            lastNameDoctor.Name = "lastNameDoctor";
            lastNameDoctor.Size = new Size(90, 28);
            lastNameDoctor.TabIndex = 22;
            lastNameDoctor.Text = "Apellido:";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuBar;
            textBox1.Location = new Point(254, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 27);
            textBox1.TabIndex = 21;
            // 
            // firstNameDoctor
            // 
            firstNameDoctor.AutoSize = true;
            firstNameDoctor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameDoctor.ForeColor = SystemColors.Window;
            firstNameDoctor.Location = new Point(147, 72);
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
            // DoctorModalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 108, 108);
            ClientSize = new Size(512, 450);
            Controls.Add(textDoctor);
            Controls.Add(textBox4);
            Controls.Add(gender);
            Controls.Add(textBox3);
            Controls.Add(fechaNacLabel);
            Controls.Add(textBox2);
            Controls.Add(lastNameDoctor);
            Controls.Add(textBox1);
            Controls.Add(firstNameDoctor);
            Controls.Add(doctorSaveButton);
            Controls.Add(doctorCancelButton);
            Name = "DoctorModalForm";
            Text = "DoctorModalForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox4;
        private Label gender;
        private TextBox textBox3;
        private Label fechaNacLabel;
        private TextBox textBox2;
        private Label lastNameDoctor;
        private TextBox textBox1;
        private Label firstNameDoctor;
        private Button doctorSaveButton;
        private Button doctorCancelButton;
        private Label textDoctor;
    }
}