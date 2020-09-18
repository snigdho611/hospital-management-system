namespace HospitalManagementSystem.Windows
{
    partial class AddPatient
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblDgn = new System.Windows.Forms.Label();
            this.txtDgn = new System.Windows.Forms.TextBox();
            this.lblDocId = new System.Windows.Forms.Label();
            this.txtDocId = new System.Windows.Forms.TextBox();
            this.lblDocName = new System.Windows.Forms.Label();
            this.txtDocName = new System.Windows.Forms.TextBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.lblBill = new System.Windows.Forms.Label();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(130, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(242, 22);
            this.txtName.TabIndex = 0;
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(130, 108);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(71, 22);
            this.txtAge.TabIndex = 1;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbGender.Location = new System.Drawing.Point(130, 81);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(121, 21);
            this.cmbGender.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblName.Location = new System.Drawing.Point(66, 52);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 19);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name: ";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblGender.Location = new System.Drawing.Point(55, 80);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(69, 19);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender: ";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblAge.Location = new System.Drawing.Point(81, 107);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(43, 19);
            this.lblAge.TabIndex = 5;
            this.lblAge.Text = "Age: ";
            // 
            // lblDgn
            // 
            this.lblDgn.AutoSize = true;
            this.lblDgn.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDgn.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblDgn.Location = new System.Drawing.Point(43, 135);
            this.lblDgn.Name = "lblDgn";
            this.lblDgn.Size = new System.Drawing.Size(81, 19);
            this.lblDgn.TabIndex = 7;
            this.lblDgn.Text = "Diagnosis:";
            // 
            // txtDgn
            // 
            this.txtDgn.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDgn.Location = new System.Drawing.Point(130, 136);
            this.txtDgn.Name = "txtDgn";
            this.txtDgn.Size = new System.Drawing.Size(242, 22);
            this.txtDgn.TabIndex = 6;
            // 
            // lblDocId
            // 
            this.lblDocId.AutoSize = true;
            this.lblDocId.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocId.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblDocId.Location = new System.Drawing.Point(43, 163);
            this.lblDocId.Name = "lblDocId";
            this.lblDocId.Size = new System.Drawing.Size(80, 19);
            this.lblDocId.TabIndex = 9;
            this.lblDocId.Text = "Doctor ID:";
            // 
            // txtDocId
            // 
            this.txtDocId.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocId.Location = new System.Drawing.Point(130, 164);
            this.txtDocId.Name = "txtDocId";
            this.txtDocId.Size = new System.Drawing.Size(71, 22);
            this.txtDocId.TabIndex = 8;
            // 
            // lblDocName
            // 
            this.lblDocName.AutoSize = true;
            this.lblDocName.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocName.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblDocName.Location = new System.Drawing.Point(20, 192);
            this.lblDocName.Name = "lblDocName";
            this.lblDocName.Size = new System.Drawing.Size(104, 19);
            this.lblDocName.TabIndex = 11;
            this.lblDocName.Text = "Doctor Name:";
            // 
            // txtDocName
            // 
            this.txtDocName.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocName.Location = new System.Drawing.Point(130, 192);
            this.txtDocName.Name = "txtDocName";
            this.txtDocName.Size = new System.Drawing.Size(242, 22);
            this.txtDocName.TabIndex = 10;
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblRoom.Location = new System.Drawing.Point(70, 219);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(53, 19);
            this.lblRoom.TabIndex = 13;
            this.lblRoom.Text = "Room:";
            // 
            // txtRoom
            // 
            this.txtRoom.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoom.Location = new System.Drawing.Point(130, 220);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(242, 22);
            this.txtRoom.TabIndex = 12;
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBill.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblBill.Location = new System.Drawing.Point(86, 247);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(38, 19);
            this.lblBill.TabIndex = 15;
            this.lblBill.Text = "Bill:";
            // 
            // txtBill
            // 
            this.txtBill.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBill.Location = new System.Drawing.Point(130, 248);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(242, 22);
            this.txtBill.TabIndex = 14;
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddPatient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddPatient.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPatient.Location = new System.Drawing.Point(82, 333);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(92, 25);
            this.btnAddPatient.TabIndex = 16;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.UseVisualStyleBackColor = false;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(289, 333);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 25);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(224)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(460, 379);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.lblBill);
            this.Controls.Add(this.txtBill);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.lblDocName);
            this.Controls.Add(this.txtDocName);
            this.Controls.Add(this.lblDocId);
            this.Controls.Add(this.txtDocId);
            this.Controls.Add(this.lblDgn);
            this.Controls.Add(this.txtDgn);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Name = "AddPatient";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Patient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblDgn;
        private System.Windows.Forms.TextBox txtDgn;
        private System.Windows.Forms.Label lblDocId;
        private System.Windows.Forms.TextBox txtDocId;
        private System.Windows.Forms.Label lblDocName;
        private System.Windows.Forms.TextBox txtDocName;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Button btnCancel;
    }
}