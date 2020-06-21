namespace ADO_NET_02
{
    partial class ADO_NET_02
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEmpID = new System.Windows.Forms.TextBox();
            this.tbEmpName = new System.Windows.Forms.TextBox();
            this.tbDesig = new System.Windows.Forms.TextBox();
            this.tbQual = new System.Windows.Forms.TextBox();
            this.tbJoinDt = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbEmp = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Designation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Qualification";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Joning Date";
            // 
            // tbEmpID
            // 
            this.tbEmpID.Location = new System.Drawing.Point(135, 30);
            this.tbEmpID.Name = "tbEmpID";
            this.tbEmpID.Size = new System.Drawing.Size(208, 20);
            this.tbEmpID.TabIndex = 5;
            // 
            // tbEmpName
            // 
            this.tbEmpName.Location = new System.Drawing.Point(135, 64);
            this.tbEmpName.Name = "tbEmpName";
            this.tbEmpName.Size = new System.Drawing.Size(208, 20);
            this.tbEmpName.TabIndex = 6;
            // 
            // tbDesig
            // 
            this.tbDesig.Location = new System.Drawing.Point(135, 100);
            this.tbDesig.Name = "tbDesig";
            this.tbDesig.Size = new System.Drawing.Size(208, 20);
            this.tbDesig.TabIndex = 7;
            // 
            // tbQual
            // 
            this.tbQual.Location = new System.Drawing.Point(135, 139);
            this.tbQual.Name = "tbQual";
            this.tbQual.Size = new System.Drawing.Size(208, 20);
            this.tbQual.TabIndex = 8;
            // 
            // tbJoinDt
            // 
            this.tbJoinDt.Location = new System.Drawing.Point(135, 174);
            this.tbJoinDt.Name = "tbJoinDt";
            this.tbJoinDt.Size = new System.Drawing.Size(208, 20);
            this.tbJoinDt.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(411, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(251, 26);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add Employee";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbEmp
            // 
            this.cmbEmp.FormattingEnabled = true;
            this.cmbEmp.Location = new System.Drawing.Point(481, 77);
            this.cmbEmp.Name = "cmbEmp";
            this.cmbEmp.Size = new System.Drawing.Size(181, 21);
            this.cmbEmp.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(408, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Employee ID";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(411, 124);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(64, 26);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update Employee";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(502, 124);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 26);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete Employee";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(598, 124);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 26);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search Employee";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(411, 168);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(251, 26);
            this.btnDisplay.TabIndex = 21;
            this.btnDisplay.Text = "Employee Details";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(82, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(549, 185);
            this.dataGridView1.TabIndex = 22;
            // 
            // ADO_NET_02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 410);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbEmp);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbJoinDt);
            this.Controls.Add(this.tbQual);
            this.Controls.Add(this.tbDesig);
            this.Controls.Add(this.tbEmpName);
            this.Controls.Add(this.tbEmpID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ADO_NET_02";
            this.Text = "Employee Management";
            this.Load += new System.EventHandler(this.ADO_NET_02_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEmpID;
        private System.Windows.Forms.TextBox tbEmpName;
        private System.Windows.Forms.TextBox tbDesig;
        private System.Windows.Forms.TextBox tbQual;
        private System.Windows.Forms.TextBox tbJoinDt;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbEmp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

