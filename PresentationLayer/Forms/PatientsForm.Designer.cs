﻿namespace PresentationLayer.Forms
{
    partial class PatientsForm
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
            DoctorsButton = new Button();
            SuspendLayout();
            // 
            // DoctorsButton
            // 
            DoctorsButton.BackColor = Color.FromArgb(21, 108, 108);
            DoctorsButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DoctorsButton.ForeColor = Color.White;
            DoctorsButton.Location = new Point(260, 198);
            DoctorsButton.Name = "DoctorsButton";
            DoctorsButton.Size = new Size(648, 286);
            DoctorsButton.TabIndex = 3;
            DoctorsButton.Text = "Formulario Pacientes";
            DoctorsButton.UseVisualStyleBackColor = false;
            // 
            // PatientsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 730);
            Controls.Add(DoctorsButton);
            Name = "PatientsForm";
            Text = "PatientsForm";
            ResumeLayout(false);
        }

        #endregion

        private Button DoctorsButton;
    }
}