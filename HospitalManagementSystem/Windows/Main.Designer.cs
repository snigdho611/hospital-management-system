namespace HospitalManagementSystem.Windows
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.phrBtn = new System.Windows.Forms.Button();
            this.apnBtn = new System.Windows.Forms.Button();
            this.docBtn = new System.Windows.Forms.Button();
            this.ptnBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.tblLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.phrBtn);
            this.panel1.Controls.Add(this.apnBtn);
            this.panel1.Controls.Add(this.docBtn);
            this.panel1.Controls.Add(this.ptnBtn);
            this.panel1.Location = new System.Drawing.Point(5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 675);
            this.panel1.TabIndex = 0;
            // 
            // phrBtn
            // 
            this.phrBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("phrBtn.BackgroundImage")));
            this.phrBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.phrBtn.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.phrBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.phrBtn.Location = new System.Drawing.Point(3, 408);
            this.phrBtn.Name = "phrBtn";
            this.phrBtn.Size = new System.Drawing.Size(141, 129);
            this.phrBtn.TabIndex = 3;
            this.phrBtn.Text = "PHARMACY";
            this.phrBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.phrBtn.UseVisualStyleBackColor = true;
            // 
            // apnBtn
            // 
            this.apnBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("apnBtn.BackgroundImage")));
            this.apnBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.apnBtn.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.apnBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.apnBtn.Location = new System.Drawing.Point(3, 273);
            this.apnBtn.Name = "apnBtn";
            this.apnBtn.Size = new System.Drawing.Size(141, 129);
            this.apnBtn.TabIndex = 2;
            this.apnBtn.Text = "APPOINTMENTS";
            this.apnBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.apnBtn.UseVisualStyleBackColor = true;
            // 
            // docBtn
            // 
            this.docBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("docBtn.BackgroundImage")));
            this.docBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.docBtn.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.docBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.docBtn.Location = new System.Drawing.Point(3, 138);
            this.docBtn.Name = "docBtn";
            this.docBtn.Size = new System.Drawing.Size(141, 129);
            this.docBtn.TabIndex = 1;
            this.docBtn.Text = "DOCTORS";
            this.docBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.docBtn.UseVisualStyleBackColor = true;
            this.docBtn.Click += new System.EventHandler(this.docBtn_Click);
            // 
            // ptnBtn
            // 
            this.ptnBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptnBtn.BackgroundImage")));
            this.ptnBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptnBtn.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptnBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ptnBtn.Location = new System.Drawing.Point(3, 3);
            this.ptnBtn.Name = "ptnBtn";
            this.ptnBtn.Size = new System.Drawing.Size(141, 129);
            this.ptnBtn.TabIndex = 0;
            this.ptnBtn.Text = "PATIENTS";
            this.ptnBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ptnBtn.UseVisualStyleBackColor = true;
            this.ptnBtn.Click += new System.EventHandler(this.ptnBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.searchBox);
            this.panel2.Controls.Add(this.tblLbl);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(176, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(932, 663);
            this.panel2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ID",
            "Name"});
            this.comboBox1.Location = new System.Drawing.Point(94, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(95, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(195, 88);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(342, 26);
            this.searchBox.TabIndex = 2;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // tblLbl
            // 
            this.tblLbl.AutoSize = true;
            this.tblLbl.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblLbl.Location = new System.Drawing.Point(40, 14);
            this.tblLbl.Name = "tblLbl";
            this.tblLbl.Size = new System.Drawing.Size(97, 25);
            this.tblLbl.TabIndex = 1;
            this.tblLbl.Text = "ABCDE";
            this.tblLbl.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(755, 524);
            this.dataGridView1.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(224)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(1120, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CCH Ltd.";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ptnBtn;
        private System.Windows.Forms.Button docBtn;
        private System.Windows.Forms.Button apnBtn;
        private System.Windows.Forms.Button phrBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label tblLbl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox searchBox;
    }
}