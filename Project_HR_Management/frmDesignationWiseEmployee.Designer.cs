namespace Project_HR_Management
{
    partial class frmDesignationWiseEmployee
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDesignation = new System.Windows.Forms.ComboBox();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnShow = new System.Windows.Forms.Button();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeePhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeCurrentSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeJoiningDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.religionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spEmployeeListResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spEmployeeListResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Designation : ";
            // 
            // cmbDesignation
            // 
            this.cmbDesignation.FormattingEnabled = true;
            this.cmbDesignation.Location = new System.Drawing.Point(187, 65);
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Size = new System.Drawing.Size(201, 21);
            this.cmbDesignation.TabIndex = 1;
            this.cmbDesignation.SelectedIndexChanged += new System.EventHandler(this.cmbDesignation_SelectedIndexChanged);
            // 
            // btnViewReport
            // 
            this.btnViewReport.Location = new System.Drawing.Point(734, 420);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(75, 23);
            this.btnViewReport.TabIndex = 3;
            this.btnViewReport.Text = "View Report";
            this.btnViewReport.UseVisualStyleBackColor = true;
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIdDataGridViewTextBoxColumn,
            this.employeeNameDataGridViewTextBoxColumn,
            this.employeeAddressDataGridViewTextBoxColumn,
            this.employeeDOBDataGridViewTextBoxColumn,
            this.employeePhoneDataGridViewTextBoxColumn,
            this.employeeEmailDataGridViewTextBoxColumn,
            this.employeeCurrentSalaryDataGridViewTextBoxColumn,
            this.employeeJoiningDateDataGridViewTextBoxColumn,
            this.designationNameDataGridViewTextBoxColumn,
            this.sectionNameDataGridViewTextBoxColumn,
            this.departmentNameDataGridViewTextBoxColumn,
            this.genderNameDataGridViewTextBoxColumn,
            this.religionNameDataGridViewTextBoxColumn,
            this.cityNameDataGridViewTextBoxColumn,
            this.countryNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.spEmployeeListResultBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(829, 272);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(418, 64);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "employeeId";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "employeeId";
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            this.employeeNameDataGridViewTextBoxColumn.DataPropertyName = "employeeName";
            this.employeeNameDataGridViewTextBoxColumn.HeaderText = "employeeName";
            this.employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            // 
            // employeeAddressDataGridViewTextBoxColumn
            // 
            this.employeeAddressDataGridViewTextBoxColumn.DataPropertyName = "employeeAddress";
            this.employeeAddressDataGridViewTextBoxColumn.HeaderText = "employeeAddress";
            this.employeeAddressDataGridViewTextBoxColumn.Name = "employeeAddressDataGridViewTextBoxColumn";
            // 
            // employeeDOBDataGridViewTextBoxColumn
            // 
            this.employeeDOBDataGridViewTextBoxColumn.DataPropertyName = "employeeDOB";
            this.employeeDOBDataGridViewTextBoxColumn.HeaderText = "employeeDOB";
            this.employeeDOBDataGridViewTextBoxColumn.Name = "employeeDOBDataGridViewTextBoxColumn";
            // 
            // employeePhoneDataGridViewTextBoxColumn
            // 
            this.employeePhoneDataGridViewTextBoxColumn.DataPropertyName = "employeePhone";
            this.employeePhoneDataGridViewTextBoxColumn.HeaderText = "employeePhone";
            this.employeePhoneDataGridViewTextBoxColumn.Name = "employeePhoneDataGridViewTextBoxColumn";
            // 
            // employeeEmailDataGridViewTextBoxColumn
            // 
            this.employeeEmailDataGridViewTextBoxColumn.DataPropertyName = "employeeEmail";
            this.employeeEmailDataGridViewTextBoxColumn.HeaderText = "employeeEmail";
            this.employeeEmailDataGridViewTextBoxColumn.Name = "employeeEmailDataGridViewTextBoxColumn";
            // 
            // employeeCurrentSalaryDataGridViewTextBoxColumn
            // 
            this.employeeCurrentSalaryDataGridViewTextBoxColumn.DataPropertyName = "employeeCurrentSalary";
            this.employeeCurrentSalaryDataGridViewTextBoxColumn.HeaderText = "employeeCurrentSalary";
            this.employeeCurrentSalaryDataGridViewTextBoxColumn.Name = "employeeCurrentSalaryDataGridViewTextBoxColumn";
            // 
            // employeeJoiningDateDataGridViewTextBoxColumn
            // 
            this.employeeJoiningDateDataGridViewTextBoxColumn.DataPropertyName = "employeeJoiningDate";
            this.employeeJoiningDateDataGridViewTextBoxColumn.HeaderText = "employeeJoiningDate";
            this.employeeJoiningDateDataGridViewTextBoxColumn.Name = "employeeJoiningDateDataGridViewTextBoxColumn";
            // 
            // designationNameDataGridViewTextBoxColumn
            // 
            this.designationNameDataGridViewTextBoxColumn.DataPropertyName = "designationName";
            this.designationNameDataGridViewTextBoxColumn.HeaderText = "designationName";
            this.designationNameDataGridViewTextBoxColumn.Name = "designationNameDataGridViewTextBoxColumn";
            // 
            // sectionNameDataGridViewTextBoxColumn
            // 
            this.sectionNameDataGridViewTextBoxColumn.DataPropertyName = "sectionName";
            this.sectionNameDataGridViewTextBoxColumn.HeaderText = "sectionName";
            this.sectionNameDataGridViewTextBoxColumn.Name = "sectionNameDataGridViewTextBoxColumn";
            // 
            // departmentNameDataGridViewTextBoxColumn
            // 
            this.departmentNameDataGridViewTextBoxColumn.DataPropertyName = "departmentName";
            this.departmentNameDataGridViewTextBoxColumn.HeaderText = "departmentName";
            this.departmentNameDataGridViewTextBoxColumn.Name = "departmentNameDataGridViewTextBoxColumn";
            // 
            // genderNameDataGridViewTextBoxColumn
            // 
            this.genderNameDataGridViewTextBoxColumn.DataPropertyName = "genderName";
            this.genderNameDataGridViewTextBoxColumn.HeaderText = "genderName";
            this.genderNameDataGridViewTextBoxColumn.Name = "genderNameDataGridViewTextBoxColumn";
            // 
            // religionNameDataGridViewTextBoxColumn
            // 
            this.religionNameDataGridViewTextBoxColumn.DataPropertyName = "religionName";
            this.religionNameDataGridViewTextBoxColumn.HeaderText = "religionName";
            this.religionNameDataGridViewTextBoxColumn.Name = "religionNameDataGridViewTextBoxColumn";
            // 
            // cityNameDataGridViewTextBoxColumn
            // 
            this.cityNameDataGridViewTextBoxColumn.DataPropertyName = "cityName";
            this.cityNameDataGridViewTextBoxColumn.HeaderText = "cityName";
            this.cityNameDataGridViewTextBoxColumn.Name = "cityNameDataGridViewTextBoxColumn";
            // 
            // countryNameDataGridViewTextBoxColumn
            // 
            this.countryNameDataGridViewTextBoxColumn.DataPropertyName = "countryName";
            this.countryNameDataGridViewTextBoxColumn.HeaderText = "countryName";
            this.countryNameDataGridViewTextBoxColumn.Name = "countryNameDataGridViewTextBoxColumn";
            // 
            // spEmployeeListResultBindingSource
            // 
            this.spEmployeeListResultBindingSource.DataSource = typeof(Project_HR_Management.spEmployeeList_Result);
            // 
            // frmDesignationWiseEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 455);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnViewReport);
            this.Controls.Add(this.cmbDesignation);
            this.Controls.Add(this.label1);
            this.Name = "frmDesignationWiseEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDesignationWiseEmployee";
            this.Load += new System.EventHandler(this.frmDesignationWiseEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spEmployeeListResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDesignation;
        private System.Windows.Forms.Button btnViewReport;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeDOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeePhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeCurrentSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeJoiningDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn religionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource spEmployeeListResultBindingSource;
        private System.Windows.Forms.Button btnShow;
    }
}