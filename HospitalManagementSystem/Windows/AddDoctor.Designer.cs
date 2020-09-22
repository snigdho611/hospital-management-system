namespace HospitalManagementSystem.Windows
{
    partial class AddDoctor
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.lblDeptID = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblNationality = new System.Windows.Forms.Label();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblHireCmb = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblBDT = new System.Windows.Forms.Label();
            this.dtpHire = new System.Windows.Forms.DateTimePicker();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.cmbDeptID = new System.Windows.Forms.ComboBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(273, 282);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 25);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddPatient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddPatient.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPatient.Location = new System.Drawing.Point(66, 282);
            this.btnAddPatient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(92, 25);
            this.btnAddPatient.TabIndex = 34;
            this.btnAddPatient.Text = "Add Doctor";
            this.btnAddPatient.UseVisualStyleBackColor = false;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // lblDeptID
            // 
            this.lblDeptID.AutoSize = true;
            this.lblDeptID.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptID.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblDeptID.Location = new System.Drawing.Point(24, 204);
            this.lblDeptID.Name = "lblDeptID";
            this.lblDeptID.Size = new System.Drawing.Size(118, 19);
            this.lblDeptID.TabIndex = 29;
            this.lblDeptID.Text = "Department ID:";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblDOB.Location = new System.Drawing.Point(38, 176);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(104, 19);
            this.lblDOB.TabIndex = 27;
            this.lblDOB.Text = "Date of Birth:";
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationality.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblNationality.Location = new System.Drawing.Point(49, 148);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(93, 19);
            this.lblNationality.TabIndex = 25;
            this.lblNationality.Text = "Nationality:";
            // 
            // txtNationality
            // 
            this.txtNationality.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtNationality.Location = new System.Drawing.Point(149, 148);
            this.txtNationality.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(233, 22);
            this.txtNationality.TabIndex = 24;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblSalary.Location = new System.Drawing.Point(85, 121);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(62, 19);
            this.lblSalary.TabIndex = 23;
            this.lblSalary.Text = "Salary: ";
            // 
            // lblHireCmb
            // 
            this.lblHireCmb.AutoSize = true;
            this.lblHireCmb.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHireCmb.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblHireCmb.Location = new System.Drawing.Point(62, 92);
            this.lblHireCmb.Name = "lblHireCmb";
            this.lblHireCmb.Size = new System.Drawing.Size(81, 19);
            this.lblHireCmb.TabIndex = 22;
            this.lblHireCmb.Text = "Hire Date:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblName.Location = new System.Drawing.Point(85, 64);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 19);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "Name: ";
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtSalary.Location = new System.Drawing.Point(149, 121);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(78, 22);
            this.txtSalary.TabIndex = 19;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtName.Location = new System.Drawing.Point(149, 65);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(233, 22);
            this.txtName.TabIndex = 18;
            // 
            // lblBDT
            // 
            this.lblBDT.AutoSize = true;
            this.lblBDT.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblBDT.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblBDT.Location = new System.Drawing.Point(226, 124);
            this.lblBDT.Name = "lblBDT";
            this.lblBDT.Size = new System.Drawing.Size(36, 14);
            this.lblBDT.TabIndex = 36;
            this.lblBDT.Text = "BDT";
            this.lblBDT.Click += new System.EventHandler(this.lblBDT_Click);
            // 
            // dtpHire
            // 
            this.dtpHire.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtpHire.Location = new System.Drawing.Point(149, 95);
            this.dtpHire.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpHire.Name = "dtpHire";
            this.dtpHire.Size = new System.Drawing.Size(233, 22);
            this.dtpHire.TabIndex = 37;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtpDOB.Location = new System.Drawing.Point(149, 176);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(233, 22);
            this.dtpDOB.TabIndex = 38;
            // 
            // cmbDeptID
            // 
            this.cmbDeptID.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbDeptID.FormattingEnabled = true;
            this.cmbDeptID.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60"});
            this.cmbDeptID.Location = new System.Drawing.Point(149, 204);
            this.cmbDeptID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDeptID.Name = "cmbDeptID";
            this.cmbDeptID.Size = new System.Drawing.Size(56, 22);
            this.cmbDeptID.TabIndex = 39;
            this.cmbDeptID.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtDepartment
            // 
            this.txtDepartment.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtDepartment.Location = new System.Drawing.Point(211, 204);
            this.txtDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.ReadOnly = true;
            this.txtDepartment.Size = new System.Drawing.Size(154, 22);
            this.txtDepartment.TabIndex = 40;
            // 
            // AddDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(200)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(438, 332);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.cmbDeptID);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.dtpHire);
            this.Controls.Add(this.lblBDT);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.lblDeptID);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblNationality);
            this.Controls.Add(this.txtNationality);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblHireCmb);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtName);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddDoctor";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Doctor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Label lblDeptID;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.TextBox txtNationality;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblHireCmb;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblBDT;
        private System.Windows.Forms.DateTimePicker dtpHire;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.ComboBox cmbDeptID;
        private System.Windows.Forms.TextBox txtDepartment;
    }
}