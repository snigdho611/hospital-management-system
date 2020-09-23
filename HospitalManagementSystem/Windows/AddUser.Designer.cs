namespace HospitalManagementSystem.Windows
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblUsr = new System.Windows.Forms.Label();
            this.txtUsr = new System.Windows.Forms.TextBox();
            this.lblPhn = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtPhn = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCnfPass = new System.Windows.Forms.Label();
            this.txtCnfPass = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblPass.Location = new System.Drawing.Point(76, 185);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(81, 19);
            this.lblPass.TabIndex = 27;
            this.lblPass.Text = "Password:";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtPass.Location = new System.Drawing.Point(159, 186);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '•';
            this.txtPass.Size = new System.Drawing.Size(185, 22);
            this.txtPass.TabIndex = 26;
            // 
            // lblUsr
            // 
            this.lblUsr.AutoSize = true;
            this.lblUsr.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsr.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblUsr.Location = new System.Drawing.Point(72, 157);
            this.lblUsr.Name = "lblUsr";
            this.lblUsr.Size = new System.Drawing.Size(85, 19);
            this.lblUsr.TabIndex = 25;
            this.lblUsr.Text = "Username:";
            // 
            // txtUsr
            // 
            this.txtUsr.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtUsr.Location = new System.Drawing.Point(159, 158);
            this.txtUsr.Name = "txtUsr";
            this.txtUsr.Size = new System.Drawing.Size(185, 22);
            this.txtUsr.TabIndex = 24;
            // 
            // lblPhn
            // 
            this.lblPhn.AutoSize = true;
            this.lblPhn.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhn.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblPhn.Location = new System.Drawing.Point(96, 129);
            this.lblPhn.Name = "lblPhn";
            this.lblPhn.Size = new System.Drawing.Size(61, 19);
            this.lblPhn.TabIndex = 23;
            this.lblPhn.Text = "Phone: ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblEmail.Location = new System.Drawing.Point(99, 103);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 19);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "Email:";
            this.lblEmail.Click += new System.EventHandler(this.lblGender_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblName.Location = new System.Drawing.Point(99, 74);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 19);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "Name: ";
            // 
            // txtPhn
            // 
            this.txtPhn.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtPhn.Location = new System.Drawing.Point(159, 130);
            this.txtPhn.Name = "txtPhn";
            this.txtPhn.Size = new System.Drawing.Size(185, 22);
            this.txtPhn.TabIndex = 19;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtName.Location = new System.Drawing.Point(159, 75);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(185, 22);
            this.txtName.TabIndex = 18;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtEmail.Location = new System.Drawing.Point(159, 104);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(185, 22);
            this.txtEmail.TabIndex = 36;
            // 
            // lblCnfPass
            // 
            this.lblCnfPass.AutoSize = true;
            this.lblCnfPass.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnfPass.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblCnfPass.Location = new System.Drawing.Point(15, 213);
            this.lblCnfPass.Name = "lblCnfPass";
            this.lblCnfPass.Size = new System.Drawing.Size(142, 19);
            this.lblCnfPass.TabIndex = 38;
            this.lblCnfPass.Text = "Confirm Password:";
            // 
            // txtCnfPass
            // 
            this.txtCnfPass.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtCnfPass.Location = new System.Drawing.Point(159, 214);
            this.txtCnfPass.Name = "txtCnfPass";
            this.txtCnfPass.PasswordChar = '•';
            this.txtCnfPass.Size = new System.Drawing.Size(185, 22);
            this.txtCnfPass.TabIndex = 37;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(263, 298);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 25);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddUser.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(90, 298);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(92, 25);
            this.btnAddUser.TabIndex = 39;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(200)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(399, 345);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.lblCnfPass);
            this.Controls.Add(this.txtCnfPass);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblUsr);
            this.Controls.Add(this.txtUsr);
            this.Controls.Add(this.lblPhn);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtPhn);
            this.Controls.Add(this.txtName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddUser";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblUsr;
        private System.Windows.Forms.TextBox txtUsr;
        private System.Windows.Forms.Label lblPhn;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtPhn;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCnfPass;
        private System.Windows.Forms.TextBox txtCnfPass;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddUser;
    }
}