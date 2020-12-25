using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataAccessLayer;
using BusinessLogicLayer;

namespace DepartmentalStoreApp
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        //Closes the form when Escape key is pressed
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        SubCategoryClass scc = new SubCategoryClass();
        ProductClass pc = new ProductClass();
        BusinessLogicClass blc = new BusinessLogicClass();
        public int ProductId;
        private void ProductForm_Load(object sender, EventArgs e)
        {
            try
            {
                cmbSubCategory.DataSource = scc.GetAllSubCategories();
                cmbSubCategory.DisplayMember = "SubCategoryName";
                cmbSubCategory.ValueMember = "SubCategoryId";
                cmbSubCategory.SelectedIndex = -1;
                dgvProductDetails.DataSource = pc.GetAllProducts();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "")
            {
                MessageBox.Show("Please provide product name");
            }
            else if (txtRate.Text == "")
            { MessageBox.Show("Please provide rate of the product"); }
            else if (txtStockQuantity.Text == "")
            { MessageBox.Show("Please provide stock of the product"); }
            else if (txtThresholdValue.Text == "")
            { MessageBox.Show("Please provide threshold value"); }
            else
            {
                try
                {
                    bool x = blc.ManageProducts(0,
                        txtProductName.Text,
                        Convert.ToDouble(txtRate.Text),
                        Convert.ToInt32(cmbSubCategory.SelectedValue.ToString()),
                        dtpMfgDate.Text,
                        dtpExpDate.Text,
                        Convert.ToInt32(txtStockQuantity.Text),
                        Convert.ToInt32(txtThresholdValue.Text),
                        1);
                    if (x == true)
                    {
                        MessageBox.Show("Product Successfully Added");
                        dgvProductDetails.DataSource = pc.GetAllProducts();
                        HelperClass.makeFieldsBlank(pnlContainer);
                    }
                    else
                    {
                        MessageBox.Show("Error in creating product");
                        HelperClass.makeFieldsBlank(pnlContainer);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "")
            {
                MessageBox.Show("Please provide product name");
            }
            else if (txtRate.Text == "")
            { MessageBox.Show("Please provide rate of the product"); }
            else if (txtStockQuantity.Text == "")
            { MessageBox.Show("Please provide stock of the product"); }
            else if (txtThresholdValue.Text == "")
            { MessageBox.Show("Please provide threshold value"); }
            else
            {
                try
                {
                    bool x = blc.ManageProducts(ProductId,
                        txtProductName.Text,
                        Convert.ToDouble(txtRate.Text),
                        Convert.ToInt32(cmbSubCategory.SelectedValue.ToString()),
                        dtpMfgDate.Text,
                        dtpExpDate.Text,
                        Convert.ToInt32(txtStockQuantity.Text),
                        Convert.ToInt32(txtThresholdValue.Text),
                        2);
                    if (x == true)
                    {
                        MessageBox.Show("Product Successfully Updated");
                        dgvProductDetails.DataSource = pc.GetAllProducts();
                        HelperClass.makeFieldsBlank(pnlContainer);
                    }
                    else
                    {
                        MessageBox.Show("Error in updating product");
                        HelperClass.makeFieldsBlank(pnlContainer);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "")
            {
                MessageBox.Show("Please provide product name");
            }
            else if (txtRate.Text == "")
            { MessageBox.Show("Please provide rate of the product"); }
            else if (txtStockQuantity.Text == "")
            { MessageBox.Show("Please provide stock of the product"); }
            else if (txtThresholdValue.Text == "")
            { MessageBox.Show("Please provide threshold value"); }
            else
            {
                try
                {
                    bool x = blc.ManageProducts(ProductId,
                        txtProductName.Text,
                        Convert.ToDouble(txtRate.Text),
                        Convert.ToInt32(cmbSubCategory.SelectedValue.ToString()),
                        dtpMfgDate.Text,
                        dtpExpDate.Text,
                        Convert.ToInt32(txtStockQuantity.Text),
                        Convert.ToInt32(txtThresholdValue.Text),
                        3);
                    if (x == true)
                    {
                        MessageBox.Show("Product Successfully Deleted");
                        dgvProductDetails.DataSource = pc.GetAllProducts();
                        HelperClass.makeFieldsBlank(pnlContainer);
                    }
                    else
                    {
                        MessageBox.Show("Error in deleting product");
                        HelperClass.makeFieldsBlank(pnlContainer);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }       
        }

        private void dgvProductDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ProductId = Convert.ToInt32(dgvProductDetails.SelectedRows[0].Cells["ProductId"].Value.ToString());
                txtProductName.Text = dgvProductDetails.SelectedRows[0].Cells["ProductName"].Value.ToString();
                cmbSubCategory.Text = dgvProductDetails.SelectedRows[0].Cells["SubCategoryName"].Value.ToString();
                txtRate.Text = dgvProductDetails.SelectedRows[0].Cells["Rate"].Value.ToString();
                dtpMfgDate.Text = dgvProductDetails.SelectedRows[0].Cells["MfgDate"].Value.ToString();
                dtpExpDate.Text = dgvProductDetails.SelectedRows[0].Cells["ExpDate"].Value.ToString();
                txtStockQuantity.Text = dgvProductDetails.SelectedRows[0].Cells["QuantityInStock"].Value.ToString();
                txtThresholdValue.Text = dgvProductDetails.SelectedRows[0].Cells["ThresholdValue"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
