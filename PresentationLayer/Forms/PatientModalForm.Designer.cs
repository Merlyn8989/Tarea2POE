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
            nameLabel = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lastNameLabel = new Label();
            textBox3 = new TextBox();
            label1 = new Label();
            textBox4 = new TextBox();
            label2 = new Label();
            titleLabel = new Label();
            SuspendLayout();
            // 
            // patientCancelButton
            // 
            patientCancelButton.BackColor = SystemColors.MenuBar;
            patientCancelButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            patientCancelButton.ForeColor = Color.Teal;
            patientCancelButton.Location = new Point(308, 338);
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
            patientSaveButton.Location = new Point(139, 338);
            patientSaveButton.Name = "patientSaveButton";
            patientSaveButton.Size = new Size(122, 53);
            patientSaveButton.TabIndex = 9;
            patientSaveButton.Text = "Guardar";
            patientSaveButton.UseVisualStyleBackColor = false;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = SystemColors.Window;
            nameLabel.Location = new Point(173, 85);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(89, 28);
            nameLabel.TabIndex = 10;
            nameLabel.Text = "Nombre:";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuBar;
            textBox1.Location = new Point(280, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 27);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.MenuBar;
            textBox2.Location = new Point(280, 142);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(167, 27);
            textBox2.TabIndex = 13;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameLabel.ForeColor = SystemColors.Window;
            lastNameLabel.Location = new Point(161, 142);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(90, 28);
            lastNameLabel.TabIndex = 12;
            lastNameLabel.Text = "Apellido:";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.MenuBar;
            textBox3.Location = new Point(280, 203);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(167, 27);
            textBox3.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(66, 203);
            label1.Name = "label1";
            label1.Size = new Size(195, 28);
            label1.TabIndex = 14;
            label1.Text = "Fecha de nacimiento:";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.MenuBar;
            textBox4.Location = new Point(280, 256);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(167, 27);
            textBox4.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(178, 252);
            label2.Name = "label2";
            label2.Size = new Size(80, 28);
            label2.TabIndex = 16;
            label2.Text = "Género:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = Color.FromArgb(21, 108, 108);
            titleLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = SystemColors.MenuBar;
            titleLabel.Location = new Point(178, 20);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(0, 38);
            titleLabel.TabIndex = 18;
            // 
            // PatientModalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 108, 108);
            ClientSize = new Size(571, 450);
            Controls.Add(titleLabel);
            Controls.Add(textBox4);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(lastNameLabel);
            Controls.Add(textBox1);
            Controls.Add(nameLabel);
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
        private Label nameLabel;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lastNameLabel;
        private TextBox textBox3;
        private Label label1;
        private TextBox textBox4;
        private Label label2;
        private Label titleLabel;
    }
}