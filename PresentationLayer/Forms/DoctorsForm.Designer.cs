namespace PresentationLayer.Forms
{
    partial class DoctorsForm
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
            panel1 = new Panel();
            doctorsTitleLabel = new Label();
            doctorDeleteButton = new Button();
            doctorUpdateButton = new Button();
            doctorAddButton = new Button();
            doctorsDataGridView = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)doctorsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(21, 108, 108);
            panel1.Controls.Add(doctorsTitleLabel);
            panel1.Location = new Point(2, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(1107, 67);
            panel1.TabIndex = 10;
            // 
            // doctorsTitleLabel
            // 
            doctorsTitleLabel.AutoSize = true;
            doctorsTitleLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            doctorsTitleLabel.ForeColor = SystemColors.Window;
            doctorsTitleLabel.Location = new Point(53, 0);
            doctorsTitleLabel.Name = "doctorsTitleLabel";
            doctorsTitleLabel.Size = new Size(160, 54);
            doctorsTitleLabel.TabIndex = 0;
            doctorsTitleLabel.Text = "Doctors";
            // 
            // doctorDeleteButton
            // 
            doctorDeleteButton.BackColor = Color.FromArgb(21, 108, 108);
            doctorDeleteButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            doctorDeleteButton.ForeColor = Color.White;
            doctorDeleteButton.Location = new Point(830, 320);
            doctorDeleteButton.Name = "doctorDeleteButton";
            doctorDeleteButton.Size = new Size(223, 53);
            doctorDeleteButton.TabIndex = 14;
            doctorDeleteButton.Text = "Delete";
            doctorDeleteButton.UseVisualStyleBackColor = false;
            doctorDeleteButton.Click += doctorDeleteButton_Click;
            // 
            // doctorUpdateButton
            // 
            doctorUpdateButton.BackColor = Color.FromArgb(21, 108, 108);
            doctorUpdateButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            doctorUpdateButton.ForeColor = Color.White;
            doctorUpdateButton.Location = new Point(830, 236);
            doctorUpdateButton.Name = "doctorUpdateButton";
            doctorUpdateButton.Size = new Size(223, 53);
            doctorUpdateButton.TabIndex = 13;
            doctorUpdateButton.Text = "Edit";
            doctorUpdateButton.UseVisualStyleBackColor = false;
            doctorUpdateButton.Click += doctorUpdateButton_Click;
            // 
            // doctorAddButton
            // 
            doctorAddButton.BackColor = Color.FromArgb(21, 108, 108);
            doctorAddButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            doctorAddButton.ForeColor = Color.White;
            doctorAddButton.Location = new Point(830, 150);
            doctorAddButton.Name = "doctorAddButton";
            doctorAddButton.Size = new Size(223, 53);
            doctorAddButton.TabIndex = 12;
            doctorAddButton.Text = "Nuevo";
            doctorAddButton.UseVisualStyleBackColor = false;
            doctorAddButton.Click += doctorAddButton_Click_1;
            // 
            // doctorsDataGridView
            // 
            doctorsDataGridView.BackgroundColor = SystemColors.Window;
            doctorsDataGridView.BorderStyle = BorderStyle.None;
            doctorsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            doctorsDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Teal;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            doctorsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            doctorsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            doctorsDataGridView.EnableHeadersVisualStyles = false;
            doctorsDataGridView.GridColor = Color.Teal;
            doctorsDataGridView.Location = new Point(27, 150);
            doctorsDataGridView.Name = "doctorsDataGridView";
            doctorsDataGridView.RowHeadersWidth = 51;
            doctorsDataGridView.Size = new Size(755, 545);
            doctorsDataGridView.TabIndex = 11;
            // 
            // DoctorsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 730);
            Controls.Add(panel1);
            Controls.Add(doctorDeleteButton);
            Controls.Add(doctorUpdateButton);
            Controls.Add(doctorAddButton);
            Controls.Add(doctorsDataGridView);
            Name = "DoctorsForm";
            Text = "DoctorsForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)doctorsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label doctorsTitleLabel;
        private Button doctorDeleteButton;
        private Button doctorUpdateButton;
        private DataGridView doctorsDataGridView;
        private Button doctorAddButton;
    }
}