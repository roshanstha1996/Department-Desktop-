namespace DepartmentalStoreApp
{
    partial class SubCategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubCategoryForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvSubCategoryDetails = new System.Windows.Forms.DataGridView();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtSubCategory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategoryDetails)).BeginInit();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.pnlContainer);
            this.groupBox1.Location = new System.Drawing.Point(4, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 362);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categories";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Location = new System.Drawing.Point(452, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(114, 127);
            this.panel3.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(8, 83);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 36);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SeaGreen;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(8, 43);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 36);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(7, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 36);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dgvSubCategoryDetails);
            this.panel2.Location = new System.Drawing.Point(6, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 145);
            this.panel2.TabIndex = 1;
            // 
            // dgvSubCategoryDetails
            // 
            this.dgvSubCategoryDetails.AllowUserToAddRows = false;
            this.dgvSubCategoryDetails.AllowUserToDeleteRows = false;
            this.dgvSubCategoryDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubCategoryDetails.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvSubCategoryDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubCategoryDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubCategoryDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvSubCategoryDetails.Name = "dgvSubCategoryDetails";
            this.dgvSubCategoryDetails.ReadOnly = true;
            this.dgvSubCategoryDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubCategoryDetails.Size = new System.Drawing.Size(556, 141);
            this.dgvSubCategoryDetails.TabIndex = 0;
            this.dgvSubCategoryDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubCategoryDetails_CellClick);
            // 
            // pnlContainer
            // 
            this.pnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlContainer.Controls.Add(this.cmbCategory);
            this.pnlContainer.Controls.Add(this.label4);
            this.pnlContainer.Controls.Add(this.txtDescription);
            this.pnlContainer.Controls.Add(this.txtSubCategory);
            this.pnlContainer.Controls.Add(this.label3);
            this.pnlContainer.Controls.Add(this.label2);
            this.pnlContainer.Location = new System.Drawing.Point(9, 33);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(437, 135);
            this.pnlContainer.TabIndex = 0;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(120, 40);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(309, 33);
            this.cmbCategory.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Category:";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(120, 76);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(309, 50);
            this.txtDescription.TabIndex = 3;
            // 
            // txtSubCategory
            // 
            this.txtSubCategory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubCategory.Location = new System.Drawing.Point(120, 5);
            this.txtSubCategory.Name = "txtSubCategory";
            this.txtSubCategory.Size = new System.Drawing.Size(309, 33);
            this.txtSubCategory.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sub Category:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "MANAGE SUB CATEGORY";
            // 
            // SubCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(582, 436);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SubCategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubCategoryForm";
            this.Load += new System.EventHandler(this.SubCategoryForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategoryDetails)).EndInit();
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvSubCategoryDetails;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtSubCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label4;
    }
}