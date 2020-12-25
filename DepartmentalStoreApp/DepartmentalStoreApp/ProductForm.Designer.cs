namespace DepartmentalStoreApp
{
    partial class ProductForm
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
            this.cmbSubCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtThresholdValue = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStockQuantity = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpExpDate = new System.Windows.Forms.DateTimePicker();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.dtpMfgDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvProductDetails = new System.Windows.Forms.DataGridView();
            this.pnlContainer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSubCategory
            // 
            this.cmbSubCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubCategory.FormattingEnabled = true;
            this.cmbSubCategory.Location = new System.Drawing.Point(134, 40);
            this.cmbSubCategory.Name = "cmbSubCategory";
            this.cmbSubCategory.Size = new System.Drawing.Size(515, 33);
            this.cmbSubCategory.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sub Category:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "MANAGE PRODUCTS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Rate:";
            // 
            // pnlContainer
            // 
            this.pnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlContainer.Controls.Add(this.btnDelete);
            this.pnlContainer.Controls.Add(this.txtThresholdValue);
            this.pnlContainer.Controls.Add(this.btnUpdate);
            this.pnlContainer.Controls.Add(this.label8);
            this.pnlContainer.Controls.Add(this.txtStockQuantity);
            this.pnlContainer.Controls.Add(this.btnAdd);
            this.pnlContainer.Controls.Add(this.label7);
            this.pnlContainer.Controls.Add(this.dtpExpDate);
            this.pnlContainer.Controls.Add(this.txtRate);
            this.pnlContainer.Controls.Add(this.dtpMfgDate);
            this.pnlContainer.Controls.Add(this.label6);
            this.pnlContainer.Controls.Add(this.label3);
            this.pnlContainer.Controls.Add(this.cmbSubCategory);
            this.pnlContainer.Controls.Add(this.label5);
            this.pnlContainer.Controls.Add(this.label4);
            this.pnlContainer.Controls.Add(this.txtProductName);
            this.pnlContainer.Controls.Add(this.label2);
            this.pnlContainer.Location = new System.Drawing.Point(9, 33);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(656, 205);
            this.pnlContainer.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(502, 160);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 36);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtThresholdValue
            // 
            this.txtThresholdValue.Location = new System.Drawing.Point(134, 142);
            this.txtThresholdValue.Name = "txtThresholdValue";
            this.txtThresholdValue.Size = new System.Drawing.Size(122, 33);
            this.txtThresholdValue.TabIndex = 17;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SeaGreen;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(401, 160);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 36);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "Threshold value:";
            // 
            // txtStockQuantity
            // 
            this.txtStockQuantity.Location = new System.Drawing.Point(560, 110);
            this.txtStockQuantity.Name = "txtStockQuantity";
            this.txtStockQuantity.Size = new System.Drawing.Size(89, 33);
            this.txtStockQuantity.TabIndex = 15;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(300, 160);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 36);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(448, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Stock Quantity:";
            // 
            // dtpExpDate
            // 
            this.dtpExpDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpDate.Location = new System.Drawing.Point(328, 110);
            this.dtpExpDate.Name = "dtpExpDate";
            this.dtpExpDate.Size = new System.Drawing.Size(111, 29);
            this.dtpExpDate.TabIndex = 13;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(134, 75);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(515, 33);
            this.txtRate.TabIndex = 12;
            // 
            // dtpMfgDate
            // 
            this.dtpMfgDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMfgDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMfgDate.Location = new System.Drawing.Point(134, 110);
            this.dtpMfgDate.Name = "dtpMfgDate";
            this.dtpMfgDate.Size = new System.Drawing.Size(109, 29);
            this.dtpMfgDate.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(247, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Exp Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mfg Date:";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(134, 5);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(515, 33);
            this.txtProductName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Product Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.pnlContainer);
            this.groupBox1.Location = new System.Drawing.Point(4, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 395);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categories";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dgvProductDetails);
            this.panel2.Location = new System.Drawing.Point(9, 244);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(658, 145);
            this.panel2.TabIndex = 1;
            // 
            // dgvProductDetails
            // 
            this.dgvProductDetails.AllowUserToAddRows = false;
            this.dgvProductDetails.AllowUserToDeleteRows = false;
            this.dgvProductDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductDetails.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvProductDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvProductDetails.Name = "dgvProductDetails";
            this.dgvProductDetails.ReadOnly = true;
            this.dgvProductDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductDetails.Size = new System.Drawing.Size(654, 141);
            this.dgvProductDetails.TabIndex = 0;
            this.dgvProductDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductDetails_CellClick);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(687, 462);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSubCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvProductDetails;
        private System.Windows.Forms.DateTimePicker dtpMfgDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtThresholdValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStockQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpExpDate;
        private System.Windows.Forms.TextBox txtRate;
    }
}