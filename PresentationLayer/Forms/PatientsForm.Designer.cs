namespace PresentationLayer.Forms
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            patientsDataGridView = new DataGridView();
            patientAddButton = new Button();
            patientUpdateButton = new Button();
            patientDeleteButton = new Button();
            panel1 = new Panel();
            patientsTitleLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)patientsDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // patientsDataGridView
            // 
            patientsDataGridView.BackgroundColor = SystemColors.Window;
            patientsDataGridView.BorderStyle = BorderStyle.None;
            patientsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            patientsDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Teal;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            patientsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            patientsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            patientsDataGridView.EnableHeadersVisualStyles = false;
            patientsDataGridView.GridColor = Color.Teal;
            patientsDataGridView.Location = new Point(68, 149);
            patientsDataGridView.Name = "patientsDataGridView";
            patientsDataGridView.RowHeadersWidth = 51;
            patientsDataGridView.Size = new Size(674, 545);
            patientsDataGridView.TabIndex = 6;
            // 
            // patientAddButton
            // 
            patientAddButton.BackColor = Color.FromArgb(21, 108, 108);
            patientAddButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientAddButton.ForeColor = Color.White;
            patientAddButton.Location = new Point(830, 149);
            patientAddButton.Name = "patientAddButton";
            patientAddButton.Size = new Size(223, 53);
            patientAddButton.TabIndex = 7;
            patientAddButton.Text = "New";
            patientAddButton.UseVisualStyleBackColor = false;
            patientAddButton.Click += patientAddButton_Click;
            // 
            // patientUpdateButton
            // 
            patientUpdateButton.BackColor = Color.FromArgb(21, 108, 108);
            patientUpdateButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientUpdateButton.ForeColor = Color.White;
            patientUpdateButton.Location = new Point(830, 235);
            patientUpdateButton.Name = "patientUpdateButton";
            patientUpdateButton.Size = new Size(223, 53);
            patientUpdateButton.TabIndex = 8;
            patientUpdateButton.Text = "Edit";
            patientUpdateButton.UseVisualStyleBackColor = false;
            patientUpdateButton.Click += patientUpdateButton_Click;
            // 
            // patientDeleteButton
            // 
            patientDeleteButton.BackColor = Color.FromArgb(21, 108, 108);
            patientDeleteButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientDeleteButton.ForeColor = Color.White;
            patientDeleteButton.Location = new Point(830, 319);
            patientDeleteButton.Name = "patientDeleteButton";
            patientDeleteButton.Size = new Size(223, 53);
            patientDeleteButton.TabIndex = 9;
            patientDeleteButton.Text = "Delete";
            patientDeleteButton.UseVisualStyleBackColor = false;
            patientDeleteButton.Click += patientDeleteButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(21, 108, 108);
            panel1.Controls.Add(patientsTitleLabel);
            panel1.Location = new Point(2, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(1107, 67);
            panel1.TabIndex = 0;
            // 
            // patientsTitleLabel
            // 
            patientsTitleLabel.AutoSize = true;
            patientsTitleLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientsTitleLabel.ForeColor = SystemColors.Window;
            patientsTitleLabel.Location = new Point(53, 0);
            patientsTitleLabel.Name = "patientsTitleLabel";
            patientsTitleLabel.Size = new Size(174, 54);
            patientsTitleLabel.TabIndex = 0;
            patientsTitleLabel.Text = "Patients ";
            // 
            // PatientsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1110, 730);
            Controls.Add(panel1);
            Controls.Add(patientDeleteButton);
            Controls.Add(patientUpdateButton);
            Controls.Add(patientAddButton);
            Controls.Add(patientsDataGridView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PatientsForm";
            Text = "PatientsForm";
            ((System.ComponentModel.ISupportInitialize)patientsDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button patientAddButton;
        private Button patientUpdateButton;
        private Button patientDeleteButton;
        private Panel panel1;
        private Label patientsTitleLabel;
        public DataGridView patientsDataGridView;
    }
}