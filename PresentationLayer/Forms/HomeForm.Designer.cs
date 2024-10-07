namespace PresentationLayer.Forms
{
    partial class HomeForm
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
            DoctorsButton.Size = new Size(280, 55);
            DoctorsButton.TabIndex = 4;
            DoctorsButton.Text = "Formulario Home";
            DoctorsButton.UseVisualStyleBackColor = false;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DoctorsButton);
            Name = "HomeForm";
            Text = "HomeForm";
            ResumeLayout(false);
        }

        #endregion

        private Button DoctorsButton;
    }
}