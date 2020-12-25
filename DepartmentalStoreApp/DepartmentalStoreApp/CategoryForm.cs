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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        BusinessLogicClass blc = new BusinessLogicClass();
        ManageCategory mc = new ManageCategory();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text == "")
            {
                MessageBox.Show("Please provide category name");
            }
            else if (txtDescription.Text == "")
            { MessageBox.Show("Please provide description"); }
            else
            {
                try
                {
                    bool x = blc.MCategory(0, txtCategoryName.Text, txtDescription.Text, 1);
                    if (x == true)
                    {
                        MessageBox.Show("Category Successfully Added");
                        dgvCategoryDetails.DataSource = mc.GetAllCategories();
                        HelperClass.makeFieldsBlank(pnlContainer);
                    }
                    else
                    {
                        MessageBox.Show("Error in creating category");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            dgvCategoryDetails.DataSource = mc.GetAllCategories();
        }

        private void dgvCategoryDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(dgvCategoryDetails.SelectedRows[0].Cells["CategoryId"].Value.ToString());
                txtCategoryName.Text = dgvCategoryDetails.SelectedRows[0].Cells["CategoryName"].Value.ToString();
                txtDescription.Text = dgvCategoryDetails.SelectedRows[0].Cells["Description"].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text == "")
            {
                MessageBox.Show("Please provide category name");
            }
            else if (txtDescription.Text == "")
            { MessageBox.Show("Please provide description"); }
            else
            {
                try
                {
                    bool x = blc.MCategory(id, txtCategoryName.Text, txtDescription.Text, 2);
                    if (x == true)
                    {
                        MessageBox.Show("Category Successfully Updated");
                        dgvCategoryDetails.DataSource = mc.GetAllCategories();
                        HelperClass.makeFieldsBlank(pnlContainer);
                    }
                    else
                    {
                        MessageBox.Show("Error in updating category");
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
            if (txtCategoryName.Text == "")
            {
                MessageBox.Show("Please provide category name");
            }
            else if (txtDescription.Text == "")
            { MessageBox.Show("Please provide description"); }
            else
            {
                try
                {
                    bool x = blc.MCategory(id, txtCategoryName.Text, txtDescription.Text, 3);
                    if (x == true)
                    {
                        MessageBox.Show("Category Successfully deleted");
                        dgvCategoryDetails.DataSource = mc.GetAllCategories();
                        HelperClass.makeFieldsBlank(pnlContainer);
                    }
                    else
                    {
                        MessageBox.Show("Error in delete category");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }            
        }
    }
}
