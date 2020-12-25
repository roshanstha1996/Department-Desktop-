using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataAccessLayer;

namespace DepartmentalStoreApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BusinessLogicClass blc = new BusinessLogicClass();
        SalesCodeClass sct = new SalesCodeClass();
        SalesClass sc = new SalesClass();
        ProductClass pc = new ProductClass();
        ManageCategory mc = new ManageCategory();
        SubCategoryClass scc = new SubCategoryClass();
        public int id;
        public int SalesCodeId;
        public int SalesId;

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString();
        }

        private void lblDateTime_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString();
            dgvSalesCodeDetails.DataSource = sct.GetAllSalesCode();
            cmbCategory.DataSource = mc.GetAllCategories();
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
            cmbCategory.SelectedIndex = -1;
            cmbSubCategory.DataSource = scc.GetAllSubCategories();
            cmbSubCategory.DisplayMember = "SubCategoryName";
            cmbSubCategory.ValueMember = "SubCategoryId";
            cmbSubCategory.SelectedIndex = -1;
            cmbProduct.DataSource = pc.GetAllProducts();
            cmbProduct.DisplayMember = "ProductName";
            cmbProduct.ValueMember = "ProductId";
            cmbProduct.SelectedIndex = -1;
        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "")
            {
                MessageBox.Show("Please provide customer name");
            }
            else if (txtAddress.Text == "")
            { MessageBox.Show("Please provide address"); }
            else if (txtContact.Text == "")
            { MessageBox.Show("Please provide contact no"); }
            else if (txtEmail.Text == "")
            { MessageBox.Show("Please provide Email"); }
            else
            {
                if (txtCustomerName.Text == "")
                    txtCustomerName.BackColor = Color.LightGray;
                if (txtAddress.Text == "")
                    txtAddress.BackColor = Color.LightGray;
                if (txtContact.Text == "")
                    txtContact.BackColor = Color.LightGray;
                if (txtEmail.Text == "")
                    txtEmail.BackColor = Color.LightGray;

                try
                {
                    bool result = blc.ManageSCT(0, txtCustomerName.Text, dtpSalesDate.Text, txtEmail.Text, txtContact.Text, txtAddress.Text, 1);
                    if (result == true)
                    {
                        MessageBox.Show("Invoice Number Successfully Created");
                        dgvSalesCodeDetails.DataSource = sct.GetAllSalesCode();
                        lblLastInvoice.Text = sct.GetSalesCodeId();
                        HelperClass.makeFieldsBlank(grpContainer);
                    }
                    else
                    {
                        MessageBox.Show("Error in creating Invoice");
                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }

        private void txtCustomerName_MouseClick(object sender, MouseEventArgs e)
        {
            txtCustomerName.BackColor = Color.White;
        }

        private void txtAddress_MouseClick(object sender, MouseEventArgs e)
        {
            txtAddress.BackColor = Color.White;
        }

        private void txtContact_MouseClick(object sender, MouseEventArgs e)
        {
            txtContact.BackColor = Color.White;
        }

        private void txtEmail_MouseClick(object sender, MouseEventArgs e)
        {
            txtEmail.BackColor = Color.White;
        }

        private void btnAddInvoice_MouseHover(object sender, EventArgs e)
        {
            btnAddInvoice.BackColor = Color.Gray;
            btnAddInvoice.ForeColor = Color.White;
        }

        private void btnAddInvoice_MouseLeave(object sender, EventArgs e)
        {
            btnAddInvoice.BackColor = Color.SeaGreen;
            btnAddInvoice.ForeColor = Color.Black;
        }

        private void btnEditInvoice_MouseHover(object sender, EventArgs e)
        {
            btnEditInvoice.BackColor = Color.Gray;
            btnEditInvoice.ForeColor = Color.White;
        }

        private void btnEditInvoice_MouseLeave(object sender, EventArgs e)
        {
            btnEditInvoice.BackColor = Color.SeaGreen;
            btnEditInvoice.ForeColor = Color.Black;
        }

        private void btnDeleteInvoice_MouseHover(object sender, EventArgs e)
        {
            btnDeleteInvoice.BackColor = Color.Gray;
            btnDeleteInvoice.ForeColor = Color.White;
        }

        private void btnDeleteInvoice_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteInvoice.BackColor = Color.SeaGreen;
            btnDeleteInvoice.ForeColor = Color.Black;
        }

        private void btnViewGrossAmount_MouseHover(object sender, EventArgs e)
        {
            btnViewGrossAmount.BackColor = Color.Gray;
            btnViewGrossAmount.ForeColor = Color.White;
        }

        private void btnViewGrossAmount_MouseLeave(object sender, EventArgs e)
        {
            btnViewGrossAmount.BackColor = Color.SeaGreen;
            btnViewGrossAmount.ForeColor = Color.Black;
        }

        private void btnViewNetTotal_MouseHover(object sender, EventArgs e)
        {
            btnViewNetTotal.BackColor = Color.Gray;
            btnViewNetTotal.ForeColor = Color.White;
        }

        private void btnViewNetTotal_MouseLeave(object sender, EventArgs e)
        {
            btnViewNetTotal.BackColor = Color.SeaGreen;
            btnViewNetTotal.ForeColor = Color.Black;
        }

        private void btnBilling_MouseHover(object sender, EventArgs e)
        {
            btnBilling.BackColor = Color.Gray;
            btnBilling.ForeColor = Color.White;
        }

        private void btnBilling_MouseLeave(object sender, EventArgs e)
        {
            btnBilling.BackColor = Color.SeaGreen;
            btnBilling.ForeColor = Color.Black;
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm frm = new UserForm();
            frm.Show();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm frm = new CategoryForm();
            frm.Show();
        }

        private void sUBCATEGORYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubCategoryForm frm = new SubCategoryForm();
            frm.Show();
        }

        private void sEARCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductForm frm = new ProductForm();
            frm.Show();
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

        private void aDMINToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            btnAddSales.BackColor = Color.Gray;
            btnAddSales.ForeColor = Color.White;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAddSales.BackColor = Color.SeaGreen;
            btnAddSales.ForeColor = Color.Black;
        }

        private void btnEdit_MouseHover(object sender, EventArgs e)
        {
            btnEditSales.BackColor = Color.Gray;
            btnEditSales.ForeColor = Color.White;
        }

        private void btnEdit_MouseLeave(object sender, EventArgs e)
        {
            btnEditSales.BackColor = Color.SeaGreen;
            btnEditSales.ForeColor = Color.Black;
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            btnDeleteSales.BackColor = Color.Gray;
            btnDeleteSales.ForeColor = Color.White;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteSales.BackColor = Color.SeaGreen;
            btnDeleteSales.ForeColor = Color.Black;
        }


        private void btnEditInvoice_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "")
            {
                MessageBox.Show("Please provide customer name");
            }
            else if (txtAddress.Text == "")
            { MessageBox.Show("Please provide address"); }
            else if (txtContact.Text == "")
            { MessageBox.Show("Please provide contact no"); }
            else if (txtEmail.Text == "")
            { MessageBox.Show("Please provide Email"); }
            else
            {
                try
                {
                    bool result = blc.ManageSCT(id, txtCustomerName.Text, dtpSalesDate.Text, txtEmail.Text, txtContact.Text, txtAddress.Text, 2);
                    if (result == true)
                    {
                        MessageBox.Show("Invoice Number Successfully Updated");
                        dgvSalesCodeDetails.DataSource = sct.GetAllSalesCode();
                        HelperClass.makeFieldsBlank(grpContainer);
                    }
                    else
                    {
                        MessageBox.Show("Error in updating Invoice");
                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }

        private void btnDeleteInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = blc.ManageSCT(id, txtCustomerName.Text, dtpSalesDate.Text, txtEmail.Text, txtContact.Text, txtAddress.Text, 3);
                if (result == true)
                {
                    MessageBox.Show("Invoice Number Successfully Deleted");
                    dgvSalesCodeDetails.DataSource = sct.GetAllSalesCode();
                    HelperClass.makeFieldsBlank(grpContainer);

                }
                else
                {
                    MessageBox.Show("Error in deleting Invoice");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        private void dgvSalesCodeDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCustomerName.Text = dgvSalesCodeDetails.SelectedRows[0].Cells["CustomerName"].Value.ToString();
                txtAddress.Text = dgvSalesCodeDetails.SelectedRows[0].Cells["Address"].Value.ToString();
                dtpSalesDate.Text = dgvSalesCodeDetails.SelectedRows[0].Cells["SalesDate"].Value.ToString();
                txtContact.Text = dgvSalesCodeDetails.SelectedRows[0].Cells["ContactNumber"].Value.ToString();
                txtEmail.Text = dgvSalesCodeDetails.SelectedRows[0].Cells["CustomerEmail"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            lblLastInvoice.Text = dgvSalesCodeDetails.SelectedRows[0].Cells["SalesCodeId"].Value.ToString();
            dgvSalesRecord.DataSource = sc.GetAllSales(Convert.ToInt32(lblLastInvoice.Text));
            GetGrossAmount();
           
        }

        private void btnAddSales_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = blc.ManageSales(0,
                    Convert.ToInt32(lblLastInvoice.Text),
                    Convert.ToInt32(cmbProduct.SelectedValue.ToString()),
                    Convert.ToInt32(txtQuantity.Text), 1);
                if (result == true)
                {
                    MessageBox.Show("Sales Record Successfully Created");
                    dgvSalesRecord.DataSource = sc.GetAllSales(Convert.ToInt32(lblLastInvoice.Text));
                    HelperClass.makeFieldsBlank(pnlSales);
                    GetGrossAmount();
                }
                else
                {
                    MessageBox.Show("Error in creating sales record");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cmbSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbProduct.DataSource = pc.GetProductBySubCategoryId(Convert.ToInt32(cmbSubCategory.SelectedValue.ToString()));
                cmbProduct.DisplayMember = "ProductName";
                cmbProduct.ValueMember = "ProductId";
                cmbProduct.SelectedIndex = -1;
            }
            catch (Exception)
            {

                
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbSubCategory.DataSource = scc.GetSubCategoryByCategoryId(Convert.ToInt32(cmbCategory.SelectedValue.ToString()));
                cmbSubCategory.DisplayMember = "SubCategoryName";
                cmbSubCategory.ValueMember = "SubCategoryId";
                cmbSubCategory.SelectedIndex = -1;
            }
            catch (Exception)
            {

              
            }
        }

        private void dgvSalesRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvSalesCodeDetails.DataSource = sc.GetAllSales(Convert.ToInt32(lblLastInvoice.Text));
            cmbProduct.Text = dgvSalesCodeDetails.SelectedRows[0].Cells["ProductName"].Value.ToString();
            //SalesCodeId = Convert.ToInt32(dgvSalesCodeDetails.SelectedRows[0].Cells["SalesCodeId"].Value.ToString());
            txtQuantity.Text = dgvSalesCodeDetails.SelectedRows[0].Cells["SalesQuantity"].Value.ToString();
            SalesId = Convert.ToInt32(dgvSalesCodeDetails.SelectedRows[0].Cells["SalesId"].Value.ToString());
        }

        private void chkDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDiscount.Checked==true)
            {
                pnlDiscount.Enabled = true;
            }
            if (chkDiscount.Checked==false)
            {
                pnlDiscount.Enabled = false;
            }
        }

        private void rdbPercentage_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPercentage.Checked == true)
                txtPercentage.Enabled = true;
            if (rdbAmount.Checked == false)
                txtAmount.Enabled = false;
        }
          
        private void rdbAmount_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAmount.Checked == true)
                txtAmount.Enabled = true;
            if (rdbPercentage.Checked == false)
                txtPercentage.Enabled = false;
        }

        public void GetGrossAmount()
        {
            Double GrossTotal = 0;
            for (int i=0;i<dgvSalesRecord.Rows.Count;i++)
            {
                GrossTotal = GrossTotal + Convert.ToDouble(dgvSalesRecord.Rows[i].Cells["Amount"].Value.ToString());
            }
            lblGrossTotal.Text = GrossTotal.ToString();
        }

        private void txtPercentage_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double GrossTotal = Convert.ToDouble(lblGrossTotal.Text);
                double dPercent = Convert.ToDouble(txtPercentage.Text);
                double discount = dPercent / 100 * GrossTotal;
                lblDiscount.Text = discount.ToString();
                Double DiscountedTotal = GrossTotal - discount;
                lblGrossTotal.Text = DiscountedTotal.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            lblDiscount.Text = txtAmount.Text;
            try
            {
                double discountamount = Convert.ToDouble(txtAmount.Text);
                double GrossAmount = Convert.ToDouble(lblGrossTotal.Text);
                double grosstotal = GrossAmount - discountamount;
                lblGrossTotal.Text = grosstotal.ToString();
                lblDiscount.Text = discountamount.ToString();
            }
            catch (Exception )
            {
                
            }
        }

        private void chkVat_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVat.Checked==true)
            {
                double GrossTotal = Convert.ToDouble(lblGrossTotal.Text);
                double vat = 0.13 * GrossTotal;
                lblVat.Text = vat.ToString();
                GrossTotal = GrossTotal + vat;
                lblGrossTotal.Text = GrossTotal.ToString();
            }
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = blc.ManageBill(0, 
                    Convert.ToInt32(lblLastInvoice.Text),
                    Convert.ToDouble(lblDiscount.Text),
                    Convert.ToDouble(lblVat.Text),
                    Convert.ToDouble(lblGrossTotal.Text), 1);
                if (result == true)
                {
                    MessageBox.Show("Bill Successfully Added");
                    DialogResult dr = new DialogResult();
                    dr = MessageBox.Show("Do you want to print the bill?", "Confirm Bill Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dr==DialogResult.Yes)
                    {
                        BillingForm frm = new BillingForm();
                        frm.SalesCodeId = Convert.ToInt32(lblLastInvoice.Text);
                        frm.Show();
                    }

                }
                else
                {
                    MessageBox.Show("Error in Generating Bill");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);            
            }
        }

        private void btnEditSales_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = blc.ManageSales(id,
                    Convert.ToInt32(lblLastInvoice.Text),
                    Convert.ToInt32(cmbProduct.SelectedValue.ToString()),
                    Convert.ToInt32(txtQuantity.Text), 2);
                if (result == true)
                {
                    MessageBox.Show("Sales Record Successfully Updated");
                    dgvSalesRecord.DataSource = sc.GetAllSales(Convert.ToInt32(lblLastInvoice.Text));
                    HelperClass.makeFieldsBlank(pnlSales);
                    GetGrossAmount();
                }
                else
                {
                    MessageBox.Show("Error in updating sales record");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteSales_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = blc.ManageSales(id,
                    Convert.ToInt32(lblLastInvoice.Text),
                    Convert.ToInt32(cmbProduct.SelectedValue.ToString()),
                    Convert.ToInt32(txtQuantity.Text), 3);
                if (result == true)
                {
                    MessageBox.Show("Sales Record Successfully Deleted");
                    dgvSalesRecord.DataSource = sc.GetAllSales(Convert.ToInt32(lblLastInvoice.Text));
                    HelperClass.makeFieldsBlank(pnlSales);
                    GetGrossAmount();
                }
                else
                {
                    MessageBox.Show("Error in deleting sales record");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
