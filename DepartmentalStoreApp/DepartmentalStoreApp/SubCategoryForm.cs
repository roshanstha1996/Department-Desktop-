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
    public partial class SubCategoryForm : Form
    {
        public SubCategoryForm()
        {
            InitializeComponent();
        }

        ManageCategory mc = new ManageCategory();
        SubCategoryClass scc = new SubCategoryClass();
        BusinessLogicClass blc = new BusinessLogicClass();
        public int id;

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

        private void SubCategoryForm_Load(object sender, EventArgs e)
        {
            cmbCategory.DataSource = mc.GetAllCategories();
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
            cmbCategory.SelectedIndex = -1;
            dgvSubCategoryDetails.DataSource = scc.GetAllSubCategories();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtSubCategory.Text == "")
            {
                MessageBox.Show("Please provide Sub category name");
            }
            else if (txtDescription.Text == "")
            { MessageBox.Show("Please provide description"); }
            else
            {
                try
                {
                    bool x = blc.ManageSubCategory(0, Convert.ToInt32(cmbCategory.SelectedValue.ToString()), txtSubCategory.Text, txtDescription.Text, 1);
                    if (x == true)
                    {
                        MessageBox.Show(" Sub Category Successfully Added");
                        dgvSubCategoryDetails.DataSource = scc.GetAllSubCategories();
                        HelperClass.makeFieldsBlank(pnlContainer);
                    }
                    else
                    {
                        MessageBox.Show("Error in creating sub category");
                        HelperClass.makeFieldsBlank(pnlContainer);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvSubCategoryDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(dgvSubCategoryDetails.SelectedRows[0].Cells["SubCategoryId"].Value.ToString());
                txtSubCategory.Text = dgvSubCategoryDetails.SelectedRows[0].Cells["SubCategoryName"].Value.ToString();
                cmbCategory.Text = dgvSubCategoryDetails.SelectedRows[0].Cells["CategoryName"].Value.ToString();
                txtDescription.Text = dgvSubCategoryDetails.SelectedRows[0].Cells["Description"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtSubCategory.Text == "")
            {
                MessageBox.Show("Please provide Sub category name");
            }
            else if (txtDescription.Text == "")
            { MessageBox.Show("Please provide description"); }
            else
            {
                try
                {
                    bool x = blc.ManageSubCategory(id, Convert.ToInt32(cmbCategory.SelectedValue.ToString()), txtSubCategory.Text, txtDescription.Text, 2);
                    if (x == true)
                    {
                        MessageBox.Show(" Sub Category Successfully Updated");
                        dgvSubCategoryDetails.DataSource = scc.GetAllSubCategories();
                        HelperClass.makeFieldsBlank(pnlContainer);
                    }
                    else
                    {
                        MessageBox.Show("Error in updating sub category");
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
            if (txtSubCategory.Text == "")
            {
                MessageBox.Show("Please provide Sub category name");
            }
            else if (txtDescription.Text == "")
            { MessageBox.Show("Please provide description"); }
            else
            {
                try
                {
                    bool x = blc.ManageSubCategory(id, Convert.ToInt32(cmbCategory.SelectedValue.ToString()), txtSubCategory.Text, txtDescription.Text, 3);
                    if (x == true)
                    {
                        MessageBox.Show(" Sub Category Successfully Deleted");
                        dgvSubCategoryDetails.DataSource = scc.GetAllSubCategories();
                        HelperClass.makeFieldsBlank(pnlContainer);
                    }
                    else
                    {
                        MessageBox.Show("Error in deleting sub category");
                        HelperClass.makeFieldsBlank(pnlContainer);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }     
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
