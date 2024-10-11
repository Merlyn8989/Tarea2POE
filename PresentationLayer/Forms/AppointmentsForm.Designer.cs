namespace PresentationLayer.Forms
{
    partial class AppointmentsForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            AppointmentsDataGridView = new DataGridView();
            AddAppointmentsbutton = new Button();
            UbdateAppointmentsButton = new Button();
            DeleteAppointmentsButton = new Button();
            patientsTitleLabel = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)AppointmentsDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // AppointmentsDataGridView
            // 
            AppointmentsDataGridView.BackgroundColor = SystemColors.Window;
            AppointmentsDataGridView.BorderStyle = BorderStyle.None;
            AppointmentsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            AppointmentsDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Teal;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            AppointmentsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            AppointmentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AppointmentsDataGridView.EnableHeadersVisualStyles = false;
            AppointmentsDataGridView.GridColor = Color.Teal;
            AppointmentsDataGridView.Location = new Point(55, 140);
            AppointmentsDataGridView.Name = "AppointmentsDataGridView";
            AppointmentsDataGridView.RowHeadersWidth = 51;
            AppointmentsDataGridView.Size = new Size(751, 545);
            AppointmentsDataGridView.TabIndex = 11;
            // 
            // AddAppointmentsbutton
            // 
            AddAppointmentsbutton.BackColor = Color.FromArgb(21, 108, 108);
            AddAppointmentsbutton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddAppointmentsbutton.ForeColor = Color.White;
            AddAppointmentsbutton.Location = new Point(825, 140);
            AddAppointmentsbutton.Name = "AddAppointmentsbutton";
            AddAppointmentsbutton.Size = new Size(223, 53);
            AddAppointmentsbutton.TabIndex = 15;
            AddAppointmentsbutton.Text = "Nueva Cita";
            AddAppointmentsbutton.UseVisualStyleBackColor = false;
            AddAppointmentsbutton.Click += AddAppointmentsbutton_Click;
            // 
            // UbdateAppointmentsButton
            // 
            UbdateAppointmentsButton.BackColor = Color.FromArgb(21, 108, 108);
            UbdateAppointmentsButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UbdateAppointmentsButton.ForeColor = Color.White;
            UbdateAppointmentsButton.Location = new Point(825, 229);
            UbdateAppointmentsButton.Name = "UbdateAppointmentsButton";
            UbdateAppointmentsButton.Size = new Size(223, 53);
            UbdateAppointmentsButton.TabIndex = 16;
            UbdateAppointmentsButton.Text = "Editar";
            UbdateAppointmentsButton.UseVisualStyleBackColor = false;
            UbdateAppointmentsButton.Click += UpdateAppointmentsButton_Click;
            // 
            // DeleteAppointmentsButton
            // 
            DeleteAppointmentsButton.BackColor = Color.FromArgb(21, 108, 108);
            DeleteAppointmentsButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteAppointmentsButton.ForeColor = Color.White;
            DeleteAppointmentsButton.Location = new Point(825, 312);
            DeleteAppointmentsButton.Name = "DeleteAppointmentsButton";
            DeleteAppointmentsButton.Size = new Size(223, 53);
            DeleteAppointmentsButton.TabIndex = 17;
            DeleteAppointmentsButton.Text = "Eliminar";
            DeleteAppointmentsButton.UseVisualStyleBackColor = false;
            DeleteAppointmentsButton.Click += DeleteAppointmentsButton_Click;
            // 
            // patientsTitleLabel
            // 
            patientsTitleLabel.AutoSize = true;
            patientsTitleLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientsTitleLabel.ForeColor = SystemColors.Window;
            patientsTitleLabel.Location = new Point(119, 7);
            patientsTitleLabel.Name = "patientsTitleLabel";
            patientsTitleLabel.Size = new Size(277, 54);
            patientsTitleLabel.TabIndex = 35;
            patientsTitleLabel.Text = " Citas Medicas";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(21, 108, 108);
            panel1.Controls.Add(patientsTitleLabel);
            panel1.Location = new Point(12, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(1107, 67);
            panel1.TabIndex = 36;
            // 
            // AppointmentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 730);
            Controls.Add(panel1);
            Controls.Add(DeleteAppointmentsButton);
            Controls.Add(UbdateAppointmentsButton);
            Controls.Add(AddAppointmentsbutton);
            Controls.Add(AppointmentsDataGridView);
            Name = "AppointmentsForm";
            Text = "AppointmentsForm";
            ((System.ComponentModel.ISupportInitialize)AppointmentsDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView AppointmentsDataGridView;
        private Button AddAppointmentsbutton;
        private Button UbdateAppointmentsButton;
        private Button DeleteAppointmentsButton;
        private Label patientsTitleLabel;
        private Panel panel1;
    }
}
