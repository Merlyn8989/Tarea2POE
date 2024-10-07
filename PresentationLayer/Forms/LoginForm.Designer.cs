namespace PresentationLayer.Forms
{
    partial class LoginForm
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
            Initbutton = new Button();
            ExitButton = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Initbutton
            // 
            Initbutton.BackColor = Color.FromArgb(21, 108, 108);
            Initbutton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Initbutton.ForeColor = Color.White;
            Initbutton.Location = new Point(137, 417);
            Initbutton.Name = "Initbutton";
            Initbutton.Size = new Size(280, 55);
            Initbutton.TabIndex = 3;
            Initbutton.Text = "INICIAR SESION";
            Initbutton.UseVisualStyleBackColor = false;
            Initbutton.Click += Initbutton_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.FromArgb(21, 108, 108);
            ExitButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.ForeColor = Color.White;
            ExitButton.Location = new Point(522, 417);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(280, 55);
            ExitButton.TabIndex = 4;
            ExitButton.Text = "SALIR";
            ExitButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(202, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(588, 402);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backgorund;
            ClientSize = new Size(990, 548);
            Controls.Add(pictureBox1);
            Controls.Add(ExitButton);
            Controls.Add(Initbutton);
            Name = "LoginForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Initbutton;
        private Button ExitButton;
        private PictureBox pictureBox1;
    }
}